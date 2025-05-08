using System;
using TradingPlatform.BusinessLayer.Utils;

namespace TradingPlatform.BusinessLayer;

public static class PeriodExtensions
{
	public static Interval<DateTime> FindInterval(this Period period, DateTime dateTime)
	{
		return period.FindInterval(dateTime.Ticks);
	}

	public static Interval<DateTime> FindInterval(this Period period, long dateTimeTicks)
	{
		long ticks = period.Ticks;
		DateTime from = new DateTime(dateTimeTicks - dateTimeTicks % ticks, DateTimeKind.Utc);
		DateTime to = from.AddTicks(ticks - 1);
		return new Interval<DateTime>(from, to);
	}
}
