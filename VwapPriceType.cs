using System.ComponentModel;

namespace TradingPlatform.BusinessLayer;

public enum VwapPriceType
{
	[Description("Open")]
	Open,
	[Description("High")]
	High,
	[Description("Low")]
	Low,
	[Description("Close")]
	Close,
	[Description("HL/2")]
	HL2,
	[Description("HLC/3")]
	HLC3,
	[Description("OHLC/4")]
	OHLC4
}
