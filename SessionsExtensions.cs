using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace TradingPlatform.BusinessLayer;

public static class SessionsExtensions
{
	[Serializable]
	[CompilerGenerated]
	private sealed class 녴
	{
		public static readonly 녴 놭놥 = new 녴();

		public static Func<ISession, bool> 놭놯;

		public static Func<ISession, bool> 놭녾;

		public static Func<ISession, bool> 놭녬;

		public static Comparison<ISession> 놭녹;

		internal bool 녴(ISession P_0)
		{
			return P_0.IsPrimary;
		}

		internal bool 놴(ISession P_0)
		{
			return P_0.ContainsTime(TimeSpan.Zero);
		}

		internal bool 놂(ISession P_0)
		{
			return P_0.CloseTime > P_0.OpenTime;
		}

		internal int 녴(ISession P_0, ISession P_1)
		{
			return P_0.OpenTime.CompareTo(P_1.OpenTime);
		}
	}

	[CompilerGenerated]
	private sealed class 놴
	{
		public DateTime 놭녔;

		internal bool 녴(TimeZoneInfo.AdjustmentRule P_0)
		{
			return P_0.DateStart < 놭녔.Date;
		}

		internal bool 놴(TimeZoneInfo.AdjustmentRule P_0)
		{
			return P_0.DateEnd > 놭녔.Date;
		}

		internal bool 놂(TimeZoneInfo.AdjustmentRule P_0)
		{
			return P_0.DateStart < 놭녔.Date;
		}

		internal bool 놎(TimeZoneInfo.AdjustmentRule P_0)
		{
			return P_0.DateEnd > 놭녔.Date;
		}
	}

	[CompilerGenerated]
	private sealed class 놂
	{
		public DateTime 놭녠;

		internal bool 녴(ISession P_0)
		{
			return P_0.ContainsDate(놭녠);
		}
	}

	[CompilerGenerated]
	private sealed class 놎
	{
		public DateTime 놭놠;

		public ISessionsContainer 놭놟;

		internal bool 녴(ISession P_0)
		{
			return P_0.ContainsDate(놭놠, 놭놟.TimeZone);
		}

		internal bool 놴(ISession P_0)
		{
			return P_0.ContainsDate(놭놠);
		}
	}

	public static bool ContainsDate(this ISession session, DateTime dateTime)
	{
		return session.ContainsTime(dateTime.TimeOfDay);
	}

	public static bool ContainsDate(this ISession session, long dateTimeTicks)
	{
		return session.ContainsTime(dateTimeTicks % 864000000000L);
	}

	public static bool ContainsTime(this ISession session, TimeSpan time)
	{
		return session.ContainsTime(time.Ticks);
	}

	public static bool ContainsTime(this ISession session, long timeTicks)
	{
		if (session.OpenTime < session.CloseTime)
		{
			if (timeTicks < session.OpenTime.Ticks || timeTicks >= session.CloseTime.Ticks)
			{
				return false;
			}
		}
		else if (timeTicks >= session.CloseTime.Ticks && timeTicks < session.OpenTime.Ticks)
		{
			return false;
		}
		return true;
	}

	public static bool ContainsDate(this ISession session, DateTime dateTime, TimeZoneInfo timeZone)
	{
		TimeSpan time = dateTime.TimeOfDay + 녴(dateTime, timeZone);
		return session.ContainsTime(time);
	}

	internal static TimeSpan 녴(DateTime P_0, TimeZoneInfo P_1)
	{
		TimeSpan result = TimeSpan.Zero;
		if (P_1 == null)
		{
			return result;
		}
		DateTime date = DateTime.UtcNow.Date;
		if (!P_1.IsDaylightSavingTime(P_0) && P_1.IsDaylightSavingTime(date))
		{
			TimeZoneInfo.AdjustmentRule adjustmentRule = (from P_0 in P_1.GetAdjustmentRules()
				where P_0.DateStart < P_0.Date
				where P_0.DateEnd > P_0.Date
				select P_0).FirstOrDefault();
			if (adjustmentRule != null)
			{
				result = -adjustmentRule.DaylightDelta;
			}
		}
		if (P_1.IsDaylightSavingTime(P_0) && !P_1.IsDaylightSavingTime(date))
		{
			TimeZoneInfo.AdjustmentRule adjustmentRule2 = (from P_0 in P_1.GetAdjustmentRules()
				where P_0.DateStart < P_0.Date
				where P_0.DateEnd > P_0.Date
				select P_0).FirstOrDefault();
			if (adjustmentRule2 != null)
			{
				result = adjustmentRule2.DaylightDelta;
			}
		}
		return result;
	}

	public static ISession GetSessionForDate(this ISessionsContainer sessionsContainer, DateTime dateTime)
	{
		ISession[] sessionsForDate = sessionsContainer.GetSessionsForDate(dateTime);
		if (!sessionsForDate.Any())
		{
			return null;
		}
		return sessionsForDate.FirstOrDefault((ISession P_0) => P_0.ContainsDate(dateTime));
	}

	public static bool ContainsDate(this ISessionsContainer sessionsContainer, DateTime dateTime)
	{
		ISession[] sessionsForDate = sessionsContainer.GetSessionsForDate(dateTime);
		if (!sessionsForDate.Any())
		{
			return false;
		}
		if (sessionsContainer.TimeZone != null && sessionsContainer.TimeZone.SupportsDaylightSavingTime)
		{
			return sessionsForDate.Any((ISession P_0) => P_0.ContainsDate(dateTime, sessionsContainer.TimeZone));
		}
		return sessionsForDate.Any((ISession P_0) => P_0.ContainsDate(dateTime));
	}

	public static bool ContainsDate(this ISessionsContainer sessionsContainer, long dateTimeTicks)
	{
		return sessionsContainer.ContainsDate(new DateTime(dateTimeTicks, DateTimeKind.Utc));
	}

	public static long GetSessionOffset(this ISessionsContainer sessionsContainer, TimeZone timezone, bool isWeek, bool applyNegativeSignForInDaySession = true)
	{
		ISession session = sessionsContainer.녴();
		long num = ((session == null) ? (-timezone.TimeZoneInfo.BaseUtcOffset.Ticks) : ((!(session.CloseTime >= session.OpenTime)) ? (-(TimeSpan.FromHours(24.0).Ticks - session.OpenTime.Ticks)) : (((!applyNegativeSignForInDaySession) ? 1 : (-1)) * session.OpenTime.Ticks)));
		if (isWeek)
		{
			num += (long)(new DateTime(1, 1, 1, 0, 0, 0, DateTimeKind.Utc).DayOfWeek - 1) * 864000000000L;
		}
		return num;
	}

	public static long GetSessionOpenTime(this ISessionsContainer sessionsContainer, TimeZone timezone)
	{
		return sessionsContainer.녴()?.OpenTime.Ticks ?? timezone.TimeZoneInfo.BaseUtcOffset.Ticks;
	}

	private static ISession 녴(this ISessionsContainer P_0)
	{
		if (P_0 == null)
		{
			return null;
		}
		List<ISession> list = P_0.ActiveSessions?.Where((ISession P_0) => P_0.IsPrimary).ToList();
		if (list == null || list.Count == 0)
		{
			list = P_0.ActiveSessions?.Where((ISession P_0) => P_0.ContainsTime(TimeSpan.Zero)).ToList();
		}
		if (list == null || list.Count == 0)
		{
			list = P_0.ActiveSessions?.Where((ISession P_0) => P_0.CloseTime > P_0.OpenTime).ToList();
		}
		if (list == null || list.Count == 0)
		{
			list = P_0.ActiveSessions?.ToList();
		}
		list?.Sort((ISession P_0, ISession P_1) => P_0.OpenTime.CompareTo(P_1.OpenTime));
		return list?.FirstOrDefault();
	}
}
