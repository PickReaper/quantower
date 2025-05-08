using System.ComponentModel;

namespace TradingPlatform.BusinessLayer;

public enum HistoryProcessorReversalCalculationType
{
	[Description("Previous bar")]
	PreviousBar,
	[Description("Independent")]
	Independent
}
