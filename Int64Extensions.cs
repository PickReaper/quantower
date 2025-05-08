using System;

namespace TradingPlatform.BusinessLayer;

public static class Int64Extensions
{
	public static DateTime AsUnixSecondsToDateTime(this long seconds)
	{
		return DateTimeOffset.FromUnixTimeSeconds(seconds).DateTime.SetKind(DateTimeKind.Utc);
	}

	public static DateTime AsUnixMillisecondsToDateTime(this long milliseconds)
	{
		return DateTimeOffset.FromUnixTimeMilliseconds(milliseconds).DateTime.SetKind(DateTimeKind.Utc);
	}
}
