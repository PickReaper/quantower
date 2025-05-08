using System;
using System.Runtime.CompilerServices;

namespace TradingPlatform.BusinessLayer;

public class SymbolsMappingEventArgs : EventArgs
{
	[CompilerGenerated]
	private SymbolMap 놴녾;

	[CompilerGenerated]
	private readonly SymbolMapState 놴녬;

	public SymbolMap SymbolMap
	{
		[CompilerGenerated]
		get
		{
			return 놴녾;
		}
		[CompilerGenerated]
		private set
		{
			놴녾 = value;
		}
	}

	public SymbolMapState PreviousState
	{
		[CompilerGenerated]
		get
		{
			return 놴녬;
		}
	}

	public SymbolsMappingEventArgs(SymbolMap symbolMap, SymbolMapState previousState = null)
	{
		SymbolMap = symbolMap;
		놴녬 = previousState;
	}
}
