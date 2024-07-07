using System.Collections.Immutable;

namespace Righthand.RetroDbgDataProvider.Models.Program;

public record Segment(string Name, ImmutableArray<Block> Items, 
    ImmutableArray<Breakpoint> Breakpoints, ImmutableArray<Watchpoint> Watchpoints);