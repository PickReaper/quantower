using System;
using System.Runtime.CompilerServices;

namespace TradingPlatform.BusinessLayer;

public class HistoryProcessorEventArgs : EventArgs
{
	[CompilerGenerated]
	private UpdateReason 녨;

	public new static HistoryProcessorEventArgs Empty => new HistoryProcessorEventArgs();

	public UpdateReason IndicatorUpdateReason
	{
		[CompilerGenerated]
		get
		{
			return 녨;
		}
		[CompilerGenerated]
		private set
		{
			녨 = value;
		}
	}

	public HistoryProcessorEventArgs(UpdateReason updateReason = UpdateReason.Unknown)
	{
		IndicatorUpdateReason = updateReason;
	}
}
