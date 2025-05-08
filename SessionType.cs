using System.ComponentModel;

namespace TradingPlatform.BusinessLayer;

public enum SessionType
{
	[Description("Main")]
	Main,
	[Description("Pre-market")]
	PreMarket,
	[Description("Post-market")]
	PostMarket
}
