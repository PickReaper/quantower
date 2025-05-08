using System;

namespace TradingPlatform.BusinessLayer;

[Flags]
public enum LoggerScope
{
	Hidden = 0,
	Application = 1,
	General = 2,
	LocalCopyTrading = 4
}
