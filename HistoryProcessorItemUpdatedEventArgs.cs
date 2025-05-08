using System.Runtime.CompilerServices;

namespace TradingPlatform.BusinessLayer;

public class HistoryProcessorItemUpdatedEventArgs : HistoryProcessorEventArgs
{
	[CompilerGenerated]
	private int 녶녙;

	public int ItemOffset
	{
		[CompilerGenerated]
		get
		{
			return 녶녙;
		}
		[CompilerGenerated]
		private set
		{
			녶녙 = value;
		}
	}

	public HistoryProcessorItemUpdatedEventArgs(int itemOffset = 0)
	{
		ItemOffset = itemOffset;
	}
}
