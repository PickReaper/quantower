using System.ComponentModel;

namespace TradingPlatform.BusinessLayer;

public enum OrderStatus
{
	[Description("Unspecified")]
	Unspecified,
	[Description("Opened")]
	Opened,
	[Description("Partially Filled")]
	PartiallyFilled,
	[Description("Filled")]
	Filled,
	[Description("Cancelled")]
	Cancelled,
	[Description("Refused")]
	Refused,
	[Description("Inactive")]
	Inactive
}
