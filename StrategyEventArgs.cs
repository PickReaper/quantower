using System;
using System.Runtime.CompilerServices;

namespace TradingPlatform.BusinessLayer;

public class StrategyEventArgs : EventArgs
{
	[CompilerGenerated]
	private StrategyState 놴뇇;

	[CompilerGenerated]
	private StrategyState 놴놛;

	[CompilerGenerated]
	private LoggerEvent 놴놼;

	public StrategyState StrategyState
	{
		[CompilerGenerated]
		get
		{
			return 놴뇇;
		}
		[CompilerGenerated]
		private set
		{
			놴뇇 = value;
		}
	}

	public StrategyState StrategyPreviousState
	{
		[CompilerGenerated]
		get
		{
			return 놴놛;
		}
		[CompilerGenerated]
		internal set
		{
			놴놛 = value;
		}
	}

	public LoggerEvent LoggerEvent
	{
		[CompilerGenerated]
		get
		{
			return 놴놼;
		}
		[CompilerGenerated]
		private set
		{
			놴놼 = value;
		}
	}

	public StrategyEventArgs(StrategyState strategyState, LoggerEvent loggerEvent = null)
	{
		StrategyState = strategyState;
		LoggerEvent = loggerEvent;
	}
}
