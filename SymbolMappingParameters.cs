using System.Runtime.CompilerServices;

namespace TradingPlatform.BusinessLayer;

public class SymbolMappingParameters
{
	[CompilerGenerated]
	private bool 놴놮;

	[CompilerGenerated]
	private Symbol 놴녫;

	[CompilerGenerated]
	private Symbol 놴뇁;

	[CompilerGenerated]
	private Symbol 놴놧;

	[CompilerGenerated]
	private Symbol 놴녝;

	[CompilerGenerated]
	private Symbol 놴뇈;

	[CompilerGenerated]
	private Symbol 놴놑;

	public bool IsActive
	{
		[CompilerGenerated]
		get
		{
			return 놴놮;
		}
		[CompilerGenerated]
		set
		{
			놴놮 = value;
		}
	}

	public Symbol TradableSymbol
	{
		[CompilerGenerated]
		get
		{
			return 놴녫;
		}
		[CompilerGenerated]
		set
		{
			놴녫 = value;
		}
	}

	public Symbol QuotesSymbol
	{
		[CompilerGenerated]
		get
		{
			return 놴뇁;
		}
		[CompilerGenerated]
		set
		{
			놴뇁 = value;
		}
	}

	public Symbol TickHistorySymbol
	{
		[CompilerGenerated]
		get
		{
			return 놴놧;
		}
		[CompilerGenerated]
		set
		{
			놴놧 = value;
		}
	}

	public Symbol MinuteHistorySymbol
	{
		[CompilerGenerated]
		get
		{
			return 놴녝;
		}
		[CompilerGenerated]
		set
		{
			놴녝 = value;
		}
	}

	public Symbol DayHistorySymbol
	{
		[CompilerGenerated]
		get
		{
			return 놴뇈;
		}
		[CompilerGenerated]
		set
		{
			놴뇈 = value;
		}
	}

	public Symbol VolumeAnalysisSymbol
	{
		[CompilerGenerated]
		get
		{
			return 놴놑;
		}
		[CompilerGenerated]
		set
		{
			놴놑 = value;
		}
	}

	public SymbolMappingParameters(Symbol tradableSymbol)
	{
		TradableSymbol = tradableSymbol;
	}

	public SymbolMappingParameters(SymbolMap symbolMap)
	{
		IsActive = symbolMap.IsActive;
		TradableSymbol = symbolMap.TradableSymbol;
		QuotesSymbol = symbolMap.QuotesSymbol;
		TickHistorySymbol = symbolMap.TickHistorySymbol;
		MinuteHistorySymbol = symbolMap.MinuteHistorySymbol;
		DayHistorySymbol = symbolMap.DayHistorySymbol;
		VolumeAnalysisSymbol = symbolMap.VolumeAnalysisSymbol;
	}
}
