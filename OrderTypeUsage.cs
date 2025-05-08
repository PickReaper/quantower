using System;

namespace TradingPlatform.BusinessLayer;

[Flags]
public enum OrderTypeUsage
{
	Order = 1,
	CloseOrder = 2,
	All = 3
}
