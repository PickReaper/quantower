using System.ComponentModel;

namespace TradingPlatform.BusinessLayer;

public enum DealTicketType
{
	[Description("Info")]
	Info,
	[Description("Refuse")]
	Refuse,
	[Description("Order opened")]
	OrderOpened,
	[Description("Order filled")]
	OrderFilled,
	[Description("Order partially filled")]
	OrderPartiallyFilled,
	[Description("Order cancelled")]
	OrderCancelled,
	[Description("Trading operation request")]
	TradingOperationRequest,
	[Description("Trading operation success")]
	TradingOperationResultSuccess,
	[Description("Trading operation refuse")]
	TradingOperationResultRefuse,
	[Description("Trading signal")]
	TradingSignal,
	[Description("Terminal update")]
	TerminalUpdate,
	[Description("License")]
	License,
	[Description("Connection success")]
	ConnectionSuccess,
	[Description("Connection lost")]
	ConnectionLost
}
