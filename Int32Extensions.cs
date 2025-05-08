using System;

namespace TradingPlatform.BusinessLayer;

public static class Int32Extensions
{
	public static DateTime AsUnixSecondsToDateTime(this int seconds)
	{
		return DateTimeOffset.FromUnixTimeSeconds(seconds).DateTime;
	}
}
