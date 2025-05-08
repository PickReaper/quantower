using System.ComponentModel;

namespace TradingPlatform.BusinessLayer;

public enum CumulativeDeltaReset
{
	[Description("Full chart range")]
	Never,
	[Description("Daily")]
	Daily,
	[Description("Weekly")]
	Weekly,
	[Description("By chart session")]
	ByChartSession
}
