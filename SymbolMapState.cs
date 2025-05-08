using System.Runtime.CompilerServices;

namespace TradingPlatform.BusinessLayer;

public sealed class SymbolMapState
{
	[CompilerGenerated]
	private readonly bool 놴놦;

	[CompilerGenerated]
	private readonly Symbol 놴놐;

	[CompilerGenerated]
	private readonly Symbol 놴녚;

	[CompilerGenerated]
	private readonly Symbol 놴녳;

	[CompilerGenerated]
	private readonly Symbol 놴놉;

	[CompilerGenerated]
	private readonly Symbol 놴놥;

	[CompilerGenerated]
	private readonly Symbol 놴놯;

	public bool IsActive
	{
		[CompilerGenerated]
		get
		{
			return 놴놦;
		}
	}

	public Symbol TradableSymbol
	{
		[CompilerGenerated]
		get
		{
			return 놴놐;
		}
	}

	public Symbol QuotesSymbol
	{
		[CompilerGenerated]
		get
		{
			return 놴녚;
		}
	}

	public Symbol TickHistorySymbol
	{
		[CompilerGenerated]
		get
		{
			return 놴녳;
		}
	}

	public Symbol MinuteHistorySymbol
	{
		[CompilerGenerated]
		get
		{
			return 놴놉;
		}
	}

	public Symbol DayHistorySymbol
	{
		[CompilerGenerated]
		get
		{
			return 놴놥;
		}
	}

	public Symbol VolumeAnalysisSymbol
	{
		[CompilerGenerated]
		get
		{
			return 놴놯;
		}
	}

	internal SymbolMapState(SymbolMap P_0)
	{
		놴놦 = P_0.IsActive;
		놴놐 = P_0.TradableSymbol;
		놴녚 = P_0.QuotesSymbol;
		놴녳 = P_0.TickHistorySymbol;
		놴놉 = P_0.MinuteHistorySymbol;
		놴놥 = P_0.DayHistorySymbol;
		놴놯 = P_0.VolumeAnalysisSymbol;
	}
}
