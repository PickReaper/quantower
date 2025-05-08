using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using TradingPlatform.BusinessLayer.Integration;

namespace TradingPlatform.BusinessLayer;

public class SessionsContainer : BusinessObject, ISessionsContainer, IMessageBuilder<MessageSessionsContainer>
{
	[Serializable]
	[CompilerGenerated]
	private sealed class 녴
	{
		public static readonly 녴 놻뇃 = new 녴();

		public static Func<SessionsSet, IEnumerable<Session>> 놻녯;

		public static Func<HolidayInfo, HolidayInfo> 놻놮;

		public static Func<SessionsSet, SessionsSet> 놻녫;

		public static Func<HolidayInfo, HolidayInfo> 놻뇁;

		public static Func<SessionsSet, SessionsSet> 놻놧;

		internal IEnumerable<Session> 녴(SessionsSet P_0)
		{
			return P_0.Sessions;
		}

		internal HolidayInfo 녴(HolidayInfo P_0)
		{
			return new HolidayInfo(P_0);
		}

		internal SessionsSet 놴(SessionsSet P_0)
		{
			return new SessionsSet(P_0);
		}

		internal HolidayInfo 놴(HolidayInfo P_0)
		{
			return new HolidayInfo(P_0);
		}

		internal SessionsSet 놂(SessionsSet P_0)
		{
			return new SessionsSet(P_0);
		}
	}

	[CompilerGenerated]
	private sealed class 놴
	{
		public DateTime 놻녝;

		public DayOfWeek 놻뇈;

		public Func<DateTime, bool> 놻놑;

		public Func<DayOfWeek, bool> 놻놦;

		internal bool 녴(HolidayInfo P_0)
		{
			return P_0.Date.Date == 놻녝.Date;
		}

		internal bool 녴(SessionsSet P_0)
		{
			return P_0.CertainDates?.Any((DateTime P_0) => P_0.Date == 놻녝.Date) ?? false;
		}

		internal bool 녴(DateTime P_0)
		{
			return P_0.Date == 놻녝.Date;
		}

		internal bool 놴(SessionsSet P_0)
		{
			return P_0.Days?.Any((DayOfWeek P_0) => P_0 == 놻뇈) ?? false;
		}

		internal bool 녴(DayOfWeek P_0)
		{
			return P_0 == 놻뇈;
		}
	}

	[CompilerGenerated]
	private string 놰뇀;

	[CompilerGenerated]
	private string 놰놽;

	[CompilerGenerated]
	private string 놰녿;

	[CompilerGenerated]
	private HolidayInfo[] 놰놁;

	[CompilerGenerated]
	private SessionsSet[] 놰녭;

	public string Id
	{
		[CompilerGenerated]
		get
		{
			return 놰뇀;
		}
		[CompilerGenerated]
		private set
		{
			놰뇀 = value;
		}
	}

	public string Name
	{
		[CompilerGenerated]
		get
		{
			return 놰놽;
		}
		[CompilerGenerated]
		private set
		{
			놰놽 = value;
		}
	}

	public string Description
	{
		[CompilerGenerated]
		get
		{
			return 놰녿;
		}
		[CompilerGenerated]
		private set
		{
			놰녿 = value;
		}
	}

	public HolidayInfo[] Holidays
	{
		[CompilerGenerated]
		get
		{
			return 놰놁;
		}
		[CompilerGenerated]
		private set
		{
			놰놁 = value;
		}
	}

	public SessionsSet[] SessionsSets
	{
		[CompilerGenerated]
		get
		{
			return 놰녭;
		}
		[CompilerGenerated]
		private set
		{
			놰녭 = value;
		}
	}

	public ISession[] ActiveSessions => SessionsSets?.SelectMany((SessionsSet P_0) => P_0.Sessions).Cast<ISession>().ToArray();

	public TimeZoneInfo TimeZone => null;

	internal SessionsContainer(string P_0)
		: base(P_0)
	{
	}

	public void UpdateByMessage(MessageSessionsContainer message)
	{
		Id = message.Id;
		Name = message.Name;
		Description = message.Description;
		Holidays = message.Holidays?.Select((HolidayInfo P_0) => new HolidayInfo(P_0)).ToArray();
		SessionsSets = message.SessionsSets?.Select((SessionsSet P_0) => new SessionsSet(P_0)).ToArray();
	}

	public ISession[] GetSessionsForDate(DateTime dateTime)
	{
		if (Holidays?.FirstOrDefault((HolidayInfo P_0) => P_0.Date.Date == dateTime.Date) != null)
		{
			return Array.Empty<ISession>();
		}
		DayOfWeek 놻뇈 = dateTime.DayOfWeek;
		return (SessionsSets.FirstOrDefault((SessionsSet P_0) => P_0.CertainDates?.Any((DateTime P_0) => P_0.Date == dateTime.Date) ?? false) ?? SessionsSets.FirstOrDefault((SessionsSet P_0) => P_0.Days?.Any((DayOfWeek P_0) => P_0 == 놻뇈) ?? false))?.Sessions.Cast<ISession>().ToArray() ?? Array.Empty<ISession>();
	}

	public MessageSessionsContainer BuildMessage()
	{
		return new MessageSessionsContainer
		{
			Id = Id,
			Name = Name,
			Description = Description,
			Holidays = Holidays?.Select((HolidayInfo P_0) => new HolidayInfo(P_0)).ToArray(),
			SessionsSets = SessionsSets?.Select((SessionsSet P_0) => new SessionsSet(P_0)).ToArray()
		};
	}
}
