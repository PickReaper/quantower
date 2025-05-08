using System.ComponentModel;

namespace TradingPlatform.BusinessLayer;

public enum TimeInForce
{
	[Description("Default")]
	Default,
	[Description("Day")]
	Day,
	[Description("Fill Or Kill")]
	FOK,
	[Description("Good Till Cancel")]
	GTC,
	[Description("Immediate Or Cancel")]
	IOC,
	[Description("Good Till Date")]
	GTD,
	[Description("Good Till Time")]
	GTT,
	[Description("Fill And Kill")]
	FAK,
	[Description("At The Open")]
	ATO,
	[Description("At The Close")]
	ATC
}
