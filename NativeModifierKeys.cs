using System;

namespace TradingPlatform.BusinessLayer;

[Flags]
public enum NativeModifierKeys
{
	None = 0,
	Alt = 1,
	Shift = 2,
	Control = 4
}
