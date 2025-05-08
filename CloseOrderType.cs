using System.ComponentModel;

namespace TradingPlatform.BusinessLayer;

public enum CloseOrderType
{
	[Description("Stop loss")]
	StopLoss,
	[Description("Take profit")]
	TakeProfit
}
