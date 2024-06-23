//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.13.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from D:/Git/Righthand/C64/retro-dbg-data-provider/src/Righthand.RetroDbgDataProvider/Righthand.RetroDbgDataProvider/KickAssembler/Grammar/KickAssembler.g4 by ANTLR 4.13.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="KickAssemblerParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.13.1")]
[System.CLSCompliant(false)]
public interface IKickAssemblerListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="KickAssemblerParser.prog"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterProg([NotNull] KickAssemblerParser.ProgContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="KickAssemblerParser.prog"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitProg([NotNull] KickAssemblerParser.ProgContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="KickAssemblerParser.line"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLine([NotNull] KickAssemblerParser.LineContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="KickAssemblerParser.line"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLine([NotNull] KickAssemblerParser.LineContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="KickAssemblerParser.pseudoOps"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPseudoOps([NotNull] KickAssemblerParser.PseudoOpsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="KickAssemblerParser.pseudoOps"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPseudoOps([NotNull] KickAssemblerParser.PseudoOpsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="KickAssemblerParser.expressionPseudoOps"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpressionPseudoOps([NotNull] KickAssemblerParser.ExpressionPseudoOpsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="KickAssemblerParser.expressionPseudoOps"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpressionPseudoOps([NotNull] KickAssemblerParser.ExpressionPseudoOpsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="KickAssemblerParser.hexByteValues"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterHexByteValues([NotNull] KickAssemblerParser.HexByteValuesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="KickAssemblerParser.hexByteValues"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitHexByteValues([NotNull] KickAssemblerParser.HexByteValuesContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="KickAssemblerParser.fillValues"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFillValues([NotNull] KickAssemblerParser.FillValuesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="KickAssemblerParser.fillValues"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFillValues([NotNull] KickAssemblerParser.FillValuesContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="KickAssemblerParser.skipValues"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSkipValues([NotNull] KickAssemblerParser.SkipValuesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="KickAssemblerParser.skipValues"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSkipValues([NotNull] KickAssemblerParser.SkipValuesContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="KickAssemblerParser.alignValues"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlignValues([NotNull] KickAssemblerParser.AlignValuesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="KickAssemblerParser.alignValues"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlignValues([NotNull] KickAssemblerParser.AlignValuesContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="KickAssemblerParser.convtab"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConvtab([NotNull] KickAssemblerParser.ConvtabContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="KickAssemblerParser.convtab"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConvtab([NotNull] KickAssemblerParser.ConvtabContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="KickAssemblerParser.stringValues"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStringValues([NotNull] KickAssemblerParser.StringValuesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="KickAssemblerParser.stringValues"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStringValues([NotNull] KickAssemblerParser.StringValuesContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="KickAssemblerParser.scrxor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterScrxor([NotNull] KickAssemblerParser.ScrxorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="KickAssemblerParser.scrxor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitScrxor([NotNull] KickAssemblerParser.ScrxorContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="KickAssemblerParser.to"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTo([NotNull] KickAssemblerParser.ToContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="KickAssemblerParser.to"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTo([NotNull] KickAssemblerParser.ToContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="KickAssemblerParser.source"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSource([NotNull] KickAssemblerParser.SourceContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="KickAssemblerParser.source"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSource([NotNull] KickAssemblerParser.SourceContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="KickAssemblerParser.binary"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBinary([NotNull] KickAssemblerParser.BinaryContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="KickAssemblerParser.binary"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBinary([NotNull] KickAssemblerParser.BinaryContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="KickAssemblerParser.zone"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterZone([NotNull] KickAssemblerParser.ZoneContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="KickAssemblerParser.zone"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitZone([NotNull] KickAssemblerParser.ZoneContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="KickAssemblerParser.symbollist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSymbollist([NotNull] KickAssemblerParser.SymbollistContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="KickAssemblerParser.symbollist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSymbollist([NotNull] KickAssemblerParser.SymbollistContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="KickAssemblerParser.flowOps"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFlowOps([NotNull] KickAssemblerParser.FlowOpsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="KickAssemblerParser.flowOps"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFlowOps([NotNull] KickAssemblerParser.FlowOpsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="KickAssemblerParser.ifFlow"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIfFlow([NotNull] KickAssemblerParser.IfFlowContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="KickAssemblerParser.ifFlow"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIfFlow([NotNull] KickAssemblerParser.IfFlowContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="KickAssemblerParser.ifDefFlow"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIfDefFlow([NotNull] KickAssemblerParser.IfDefFlowContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="KickAssemblerParser.ifDefFlow"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIfDefFlow([NotNull] KickAssemblerParser.IfDefFlowContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="KickAssemblerParser.forFlow"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterForFlow([NotNull] KickAssemblerParser.ForFlowContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="KickAssemblerParser.forFlow"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitForFlow([NotNull] KickAssemblerParser.ForFlowContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="KickAssemblerParser.set"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSet([NotNull] KickAssemblerParser.SetContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="KickAssemblerParser.set"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSet([NotNull] KickAssemblerParser.SetContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="KickAssemblerParser.doFlow"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDoFlow([NotNull] KickAssemblerParser.DoFlowContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="KickAssemblerParser.doFlow"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDoFlow([NotNull] KickAssemblerParser.DoFlowContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="KickAssemblerParser.whileFlow"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWhileFlow([NotNull] KickAssemblerParser.WhileFlowContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="KickAssemblerParser.whileFlow"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWhileFlow([NotNull] KickAssemblerParser.WhileFlowContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="KickAssemblerParser.endOfFile"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEndOfFile([NotNull] KickAssemblerParser.EndOfFileContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="KickAssemblerParser.endOfFile"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEndOfFile([NotNull] KickAssemblerParser.EndOfFileContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="KickAssemblerParser.reportError"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterReportError([NotNull] KickAssemblerParser.ReportErrorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="KickAssemblerParser.reportError"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitReportError([NotNull] KickAssemblerParser.ReportErrorContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="KickAssemblerParser.errorLevel"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterErrorLevel([NotNull] KickAssemblerParser.ErrorLevelContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="KickAssemblerParser.errorLevel"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitErrorLevel([NotNull] KickAssemblerParser.ErrorLevelContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="KickAssemblerParser.macroTitle"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMacroTitle([NotNull] KickAssemblerParser.MacroTitleContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="KickAssemblerParser.macroTitle"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMacroTitle([NotNull] KickAssemblerParser.MacroTitleContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="KickAssemblerParser.macro"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMacro([NotNull] KickAssemblerParser.MacroContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="KickAssemblerParser.macro"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMacro([NotNull] KickAssemblerParser.MacroContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="KickAssemblerParser.callMarco"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCallMarco([NotNull] KickAssemblerParser.CallMarcoContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="KickAssemblerParser.callMarco"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCallMarco([NotNull] KickAssemblerParser.CallMarcoContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="KickAssemblerParser.callMacroArgument"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCallMacroArgument([NotNull] KickAssemblerParser.CallMacroArgumentContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="KickAssemblerParser.callMacroArgument"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCallMacroArgument([NotNull] KickAssemblerParser.CallMacroArgumentContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="KickAssemblerParser.setProgramCounter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSetProgramCounter([NotNull] KickAssemblerParser.SetProgramCounterContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="KickAssemblerParser.setProgramCounter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSetProgramCounter([NotNull] KickAssemblerParser.SetProgramCounterContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="KickAssemblerParser.initMem"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInitMem([NotNull] KickAssemblerParser.InitMemContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="KickAssemblerParser.initMem"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInitMem([NotNull] KickAssemblerParser.InitMemContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="KickAssemblerParser.xor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterXor([NotNull] KickAssemblerParser.XorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="KickAssemblerParser.xor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitXor([NotNull] KickAssemblerParser.XorContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="KickAssemblerParser.pseudoPc"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPseudoPc([NotNull] KickAssemblerParser.PseudoPcContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="KickAssemblerParser.pseudoPc"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPseudoPc([NotNull] KickAssemblerParser.PseudoPcContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="KickAssemblerParser.cpu"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCpu([NotNull] KickAssemblerParser.CpuContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="KickAssemblerParser.cpu"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCpu([NotNull] KickAssemblerParser.CpuContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="KickAssemblerParser.assume"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAssume([NotNull] KickAssemblerParser.AssumeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="KickAssemblerParser.assume"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAssume([NotNull] KickAssemblerParser.AssumeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="KickAssemblerParser.address"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAddress([NotNull] KickAssemblerParser.AddressContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="KickAssemblerParser.address"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAddress([NotNull] KickAssemblerParser.AddressContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="KickAssemblerParser.expressionPseudoCodes"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpressionPseudoCodes([NotNull] KickAssemblerParser.ExpressionPseudoCodesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="KickAssemblerParser.expressionPseudoCodes"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpressionPseudoCodes([NotNull] KickAssemblerParser.ExpressionPseudoCodesContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="KickAssemblerParser.block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBlock([NotNull] KickAssemblerParser.BlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="KickAssemblerParser.block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBlock([NotNull] KickAssemblerParser.BlockContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="KickAssemblerParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStatement([NotNull] KickAssemblerParser.StatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="KickAssemblerParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStatement([NotNull] KickAssemblerParser.StatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="KickAssemblerParser.statements"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStatements([NotNull] KickAssemblerParser.StatementsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="KickAssemblerParser.statements"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStatements([NotNull] KickAssemblerParser.StatementsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="KickAssemblerParser.filename"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFilename([NotNull] KickAssemblerParser.FilenameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="KickAssemblerParser.filename"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFilename([NotNull] KickAssemblerParser.FilenameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="KickAssemblerParser.condition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCondition([NotNull] KickAssemblerParser.ConditionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="KickAssemblerParser.condition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCondition([NotNull] KickAssemblerParser.ConditionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="KickAssemblerParser.comment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterComment([NotNull] KickAssemblerParser.CommentContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="KickAssemblerParser.comment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitComment([NotNull] KickAssemblerParser.CommentContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="KickAssemblerParser.label"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLabel([NotNull] KickAssemblerParser.LabelContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="KickAssemblerParser.label"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLabel([NotNull] KickAssemblerParser.LabelContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="KickAssemblerParser.instruction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInstruction([NotNull] KickAssemblerParser.InstructionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="KickAssemblerParser.instruction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInstruction([NotNull] KickAssemblerParser.InstructionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="KickAssemblerParser.argumentList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterArgumentList([NotNull] KickAssemblerParser.ArgumentListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="KickAssemblerParser.argumentList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitArgumentList([NotNull] KickAssemblerParser.ArgumentListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="KickAssemblerParser.argument"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterArgument([NotNull] KickAssemblerParser.ArgumentContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="KickAssemblerParser.argument"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitArgument([NotNull] KickAssemblerParser.ArgumentContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="KickAssemblerParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpression([NotNull] KickAssemblerParser.ExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="KickAssemblerParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpression([NotNull] KickAssemblerParser.ExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="KickAssemblerParser.number"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNumber([NotNull] KickAssemblerParser.NumberContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="KickAssemblerParser.number"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNumber([NotNull] KickAssemblerParser.NumberContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="KickAssemblerParser.decNumber"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDecNumber([NotNull] KickAssemblerParser.DecNumberContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="KickAssemblerParser.decNumber"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDecNumber([NotNull] KickAssemblerParser.DecNumberContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="KickAssemblerParser.hexNumber"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterHexNumber([NotNull] KickAssemblerParser.HexNumberContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="KickAssemblerParser.hexNumber"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitHexNumber([NotNull] KickAssemblerParser.HexNumberContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="KickAssemblerParser.binNumber"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBinNumber([NotNull] KickAssemblerParser.BinNumberContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="KickAssemblerParser.binNumber"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBinNumber([NotNull] KickAssemblerParser.BinNumberContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="KickAssemblerParser.logicalop"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLogicalop([NotNull] KickAssemblerParser.LogicalopContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="KickAssemblerParser.logicalop"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLogicalop([NotNull] KickAssemblerParser.LogicalopContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="KickAssemblerParser.symbol"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSymbol([NotNull] KickAssemblerParser.SymbolContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="KickAssemblerParser.symbol"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSymbol([NotNull] KickAssemblerParser.SymbolContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="KickAssemblerParser.binaryop"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBinaryop([NotNull] KickAssemblerParser.BinaryopContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="KickAssemblerParser.binaryop"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBinaryop([NotNull] KickAssemblerParser.BinaryopContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="KickAssemblerParser.opcode"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpcode([NotNull] KickAssemblerParser.OpcodeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="KickAssemblerParser.opcode"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpcode([NotNull] KickAssemblerParser.OpcodeContext context);
}