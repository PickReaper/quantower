using System;

namespace TradingPlatform.BusinessLayer;

[Flags]
public enum GroupTradingOperationFilters
{
	None = 0,
	Connection = 1,
	Symbol = 2,
	Account = 4,
	Side = 8,
	TimeInForce = 0x10,
	OrderType = 0x20,
	CertainOrders = 0x40
}
