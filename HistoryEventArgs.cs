using System;
using System.Runtime.CompilerServices;

namespace TradingPlatform.BusinessLayer;

public class HistoryEventArgs : EventArgs
{
	[CompilerGenerated]
	private IHistoryItem 녮;

	[CompilerGenerated]
	private bool 뇆;

	public IHistoryItem HistoryItem
	{
		[CompilerGenerated]
		get
		{
			return 녮;
		}
		[CompilerGenerated]
		set
		{
			녮 = value;
		}
	}

	public bool ResetVolumeAnalysisRequired
	{
		[CompilerGenerated]
		get
		{
			return 뇆;
		}
		[CompilerGenerated]
		set
		{
			뇆 = value;
		}
	}
}
