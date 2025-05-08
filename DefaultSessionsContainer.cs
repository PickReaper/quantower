using System;
using System.Linq;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using TradingPlatform.BusinessLayer.Integration;

namespace TradingPlatform.BusinessLayer;

public sealed class DefaultSessionsContainer : ISessionsContainer, IMessageBuilder<MessageSessionsContainer>
{
	[Serializable]
	[CompilerGenerated]
	private sealed class 녴
	{
		public static readonly 녴 놄녹 = new 녴();

		public static Func<CustomSession, SessionsSet> 놄녔;

		internal SessionsSet 녴(CustomSession P_0)
		{
			return new SessionsSet
			{
				Days = P_0.Days,
				CertainDates = new DateTime[0],
				Sessions = new Session[1]
				{
					new Session(P_0.Name, P_0.OpenTime, P_0.CloseTime)
				}
			};
		}
	}

	private static DefaultSessionsContainer 녞놱;

	private readonly CustomSession[] 녞놖;

	public static DefaultSessionsContainer Instance
	{
		get
		{
			lock (typeof(DefaultSessionsContainer))
			{
				if (녞놱 == null)
				{
					녞놱 = new DefaultSessionsContainer();
				}
			}
			return 녞놱;
		}
	}

	public ISession[] ActiveSessions => 녞놖;

	public TimeZoneInfo TimeZone => null;

	private DefaultSessionsContainer()
	{
		녞놖 = new CustomSession[1]
		{
			new CustomSession
			{
				Name = _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶놽(),
				OpenOffset = TimeSpan.Zero,
				CloseOffset = TimeSpan.FromTicks(863999999999L),
				Days = Enum.GetValues(typeof(DayOfWeek)).Cast<DayOfWeek>().ToArray(),
				Type = SessionType.Main
			}
		};
	}

	public ISession[] GetSessionsForDate(DateTime dateTime)
	{
		return 녞놖;
	}

	public MessageSessionsContainer BuildMessage()
	{
		return new MessageSessionsContainer
		{
			Id = _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶녿(),
			Name = _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶녿(),
			Description = string.Empty,
			Holidays = new HolidayInfo[0],
			SessionsSets = 녞놖?.Select((CustomSession P_0) => new SessionsSet
			{
				Days = P_0.Days,
				CertainDates = new DateTime[0],
				Sessions = new Session[1]
				{
					new Session(P_0.Name, P_0.OpenTime, P_0.CloseTime)
				}
			}).ToArray()
		};
	}
}
