﻿using Microsoft.Extensions.Logging;
using Righthand.RetroDbgDataProvider.KickAssembler.Models;
using Righthand.RetroDbgDataProvider.KickAssembler.Services.Abstract;
using System.Collections.Frozen;
using System.Collections.Immutable;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Righthand.RetroDbgDataProvider.KickAssembler.Services.Implementation;

/// <inheritdoc/>
public partial class KickAssemblerByteDumpParser(ILogger<KickAssemblerByteDumpParser> _logger)
: IKickAssemblerByteDumpParser
{
    internal enum State
    {
        WaitingForSegment,
        ReadingBlockName,
        ReadingLine,
    }
    internal enum LineType
    {
        SegmentHeader,
        BlockHeader,
        Line,
        Empty,
        Error
    }
    /// <inheritdoc/>
    public async ValueTask<FrozenDictionary<string, AssemblySegment>> LoadFileAsync(string path, CancellationToken ct = default)
    {
        if (!File.Exists(path))
        {
            throw new Exception($"File {path} does not exist");
        }
        string content;
        try
        {
            content = await File.ReadAllTextAsync(path, ct);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, $"Failed to load KickAssembler debug files {path}");
            throw;
        }
        var segments = ParseContent(content);
        _logger.LogInformation("Parsed {Count} segments", segments.Length);
        return segments.ToFrozenDictionary(s => s.Name);
    }

    internal ImmutableArray<AssemblySegment> ParseContent(string content)
    {
        var state = State.WaitingForSegment;
        var reader = new StringReader(content);
        string? segmentName = null;
        string? blockName = null;
        var segments = new List<AssemblySegment>();
        var blocks = new List<AssemblyBlock>();
        var blockLines = new List<AssemblyLine>();
        while (reader.ReadLine() is { } line)
        {
            var (headerName, lineType) = GetLineType(line);
            if (headerName is null && (lineType == LineType.SegmentHeader || lineType == LineType.BlockHeader))
            {
                throw new Exception($"Missing header name in line {line}");
            }
            _logger.LogDebug("Read line {Line} of type {LineType} with header {Header}", line, lineType, headerName);
            switch (state)
            {
                case State.WaitingForSegment:
                    if (lineType != LineType.SegmentHeader)
                    {
                        throw new Exception($"Expecting segment start but got line {line}");
                    }
                    StartNewSegment(headerName!);
                    break;
                case State.ReadingBlockName:
                    if (lineType != LineType.BlockHeader)
                    {
                        throw new Exception($"Expecting segment start but got line {line}");
                    }
                    StartNewBlock(headerName!);
                    break;
                case State.ReadingLine:
                    switch (lineType)
                    {
                        case LineType.Line:
                            blockLines.Add(ConvertLineToAssemblyLine(line));
                            break;
                        case LineType.SegmentHeader:
                            AddSegment();
                            StartNewSegment(headerName!);
                            break;
                        case LineType.BlockHeader:
                            if (blockName is null)
                            {
                                throw new Exception($"Block name is missing name when got new block {headerName}");
                            }
                            blocks.Add(new AssemblyBlock(blockName, [..blockLines]));
                            StartNewBlock(headerName!);
                            break;
                        default:
                            throw new Exception($"Error while reading assembly line {line}");
                    }
                    break;
            }
        }
        if (segmentName is not null && blockName is not null)
        {
            blocks.Add(new AssemblyBlock(blockName, [..blockLines]));
            AddSegment();
        }
        else
        {
            throw new Exception("Couldn't collect last segment");
        }
        return [..segments];

        void AddSegment()
        {
            if (segmentName is null)
            {
                throw new Exception($"Segment name is missing name when got new segment");
            }
            segments.Add(new AssemblySegment(segmentName!, [..blocks]));
        }

        void StartNewSegment(string newName)
        {
            segmentName = newName;
            blocks.Clear();
            blockLines.Clear();
            state = State.ReadingBlockName;
        }
        void StartNewBlock(string newName)
        {
            blockName = newName;
            blockLines.Clear();
            state = State.ReadingLine;
        }
    }

    internal AssemblyLine ConvertLineToAssemblyLine(string line)
    {
        var splitResult = SplitAssemblyLine(line);
        return ReadAssemblyLine(splitResult.Data, splitResult.Instructions);
    }

    internal AssemblyLine ReadAssemblyLine(ReadOnlySpan<char> data, ReadOnlySpan<char> description)
    {
        if (data.Length < 5)
        {
            throw new Exception($"Assembly line should be at least 5 chars long: {data}");
        }
        if (data[4] != ':')
        {
            throw new Exception($"Assembly line address should end with colon: {data}");
        }
        if (!ushort.TryParse(data[0..4], NumberStyles.HexNumber, CultureInfo.InvariantCulture.NumberFormat, out ushort address))
        {
            throw new Exception($"Assembly line should start with ushort address: {data}");
        }
        var bytesText = data[5..].Trim();
        int bytesCount = (bytesText.Length + 1) / 3;
        var bytes = new byte[bytesCount];
        for (int i = 0; i < bytesCount; i++)
        {
            int index = i * 3;
            var byteText = bytesText[index..(index + 2)];
            if (!byte.TryParse(byteText, NumberStyles.HexNumber, CultureInfo.InvariantCulture.NumberFormat, out byte b))
            {
                throw new Exception($"Expected byte but got {byteText} instead");
            }
            bytes[i] = b;
        }

        int colonIndex = description.IndexOf(':');
        var labels = ImmutableArray<string>.Empty;
        if (colonIndex > 0)
        {
            string[] parts = description[..colonIndex].ToString().Split(',', StringSplitOptions.TrimEntries);
            if (parts.All(p => IsValidLabelName(p)))
            {
                labels = [..parts];
            }
        }
        return new AssemblyLine(address, [..bytes], labels, description.ToString());
    }

    [GeneratedRegex(@"^(?<Label>[a-zA-Z0-9_]+)$", RegexOptions.Singleline)]
    private static partial Regex LabelRegex();
    internal bool IsValidLabelName(ReadOnlySpan<char> part)
    {
        return LabelRegex().Match(part.ToString()).Success;
    }

    internal ref struct SplitAssemblyLineResult
    {
        internal ReadOnlySpan<char> Data { get; init; }
        internal ReadOnlySpan<char> Instructions { get; init; }
        public SplitAssemblyLineResult(ReadOnlySpan<char> data, ReadOnlySpan<char> instructions)
        {
            Data = data;
            Instructions = instructions;
        }
    }
    internal SplitAssemblyLineResult SplitAssemblyLine(ReadOnlySpan<char> line)
    {
        int index = line.IndexOf('-');
        if (index < 0)
        {
            return new(line, []);
        }
        else
        {
            var data = line[0..index].TrimEnd();
            var rest = line[(index + 1)..].TrimStart();
            return new(data, rest);
        }
    }

    internal (string? Name, LineType LineType) GetLineType(string line)
    {
        if (string.IsNullOrWhiteSpace(line))
        {
            return (null, LineType.Empty);
        }
        string? name;
        switch (line[0])
        {
            case '[':
                name = GetBlockName(line);
                if (name is not null)
                {
                    return (name, LineType.BlockHeader);
                }
                break;
            case '*':
                name = GetSegmentName(line);
                if (name is not null)
                {
                    return (name, LineType.SegmentHeader);
                }
                break;
            default:
                return (null, LineType.Line);
        }
        return (null, LineType.Error);
    }

    [GeneratedRegex(@"^\*+\s+Segment:\s+(?<name>\w+)\s+\*+$", RegexOptions.Singleline)]
    private static partial Regex SegmentNameRegex();
    internal string? GetSegmentName(string line)
    {
        var match = SegmentNameRegex().Match(line);
        if (match.Success)
        {
            return match.Groups["name"].Value;
        }
        return null;
    }

    [GeneratedRegex(@"^\[(?<name>\w+)\]$", RegexOptions.Singleline)]
    private static partial Regex BlockNameRegex();
    internal string? GetBlockName(string line)
    {
        var match = BlockNameRegex().Match(line);
        if (match.Success)
        {
            return match.Groups["name"].Value;
        }
        return null;
    }
}
