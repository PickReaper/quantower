using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using TradingPlatform.BusinessLayer.Integration;
using TradingPlatform.BusinessLayer.Utils.Extensions;

namespace TradingPlatform.BusinessLayer;

public class CustomSessionsContainer : ISessionsContainer, ICustomizable, IComparable<CustomSessionsContainer>, IComparable, IMessageBuilder<MessageSessionsContainer>
{
	[Serializable]
	[CompilerGenerated]
	private sealed class 녴
	{
		public static readonly 녴 놇놛 = new 녴();

		public static Func<CustomSession, bool> 놇놼;

		public static Func<CustomSession, SettingItemGroup> 놇놗;

		public static Func<CustomHoliday, SettingItemGroup> 놇뇂;

		public static Func<CustomHoliday, HolidayInfo> 놇놩;

		public static Func<DayOfWeek, int> 놇녡;

		public static Func<CustomSession, int> 놇녦;

		public static Func<CustomSession, Session> 놇놀;

		public static Func<IGrouping<int, CustomSession>, SessionsSet> 놇놔;

		internal bool 녴(CustomSession P_0)
		{
			return P_0.IsActive;
		}

		internal SettingItemGroup 놴(CustomSession P_0)
		{
			return new SettingItemGroup(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸놬(), P_0.Settings);
		}

		internal SettingItemGroup 녴(CustomHoliday P_0)
		{
			return new SettingItemGroup(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸놊(), P_0.Settings);
		}

		internal HolidayInfo 놴(CustomHoliday P_0)
		{
			return new HolidayInfo
			{
				Name = P_0.Name,
				Date = P_0.Date
			};
		}

		internal int 놂(CustomSession P_0)
		{
			return ((IStructuralEquatable)P_0.Days.Select((DayOfWeek P_0) => (int)P_0).ToArray()).GetHashCode((IEqualityComparer)EqualityComparer<int>.Default);
		}

		internal int 녴(DayOfWeek P_0)
		{
			return (int)P_0;
		}

		internal SessionsSet 녴(IGrouping<int, CustomSession> P_0)
		{
			return new SessionsSet
			{
				Days = P_0.FirstOrDefault().Days,
				Sessions = P_0.Select((CustomSession P_0) => new Session(P_0.Name, P_0.OpenTime, P_0.CloseTime, P_0.Type)).ToArray()
			};
		}

		internal Session 놎(CustomSession P_0)
		{
			return new Session(P_0.Name, P_0.OpenTime, P_0.CloseTime, P_0.Type);
		}
	}

	[CompilerGenerated]
	private sealed class 놴
	{
		public DateTime 놇놾;

		public DayOfWeek 놇뇀;

		internal bool 녴(CustomHoliday P_0)
		{
			return P_0.Date.Date == 놇놾.Date;
		}

		internal bool 녴(CustomSession P_0)
		{
			if (P_0.IsActive)
			{
				return P_0.Days.Contains(놇뇀);
			}
			return false;
		}
	}

	[CompilerGenerated]
	private string 녶놾;

	[CompilerGenerated]
	private string 녶뇀;

	[CompilerGenerated]
	private TimeZone 녶놽;

	[CompilerGenerated]
	private CustomSession[] 녶녿;

	[CompilerGenerated]
	private CustomHoliday[] 녶놁;

	public string Id
	{
		[CompilerGenerated]
		get
		{
			return 녶놾;
		}
		[CompilerGenerated]
		private set
		{
			녶놾 = value;
		}
	}

	public string Name
	{
		[CompilerGenerated]
		get
		{
			return 녶뇀;
		}
		[CompilerGenerated]
		private set
		{
			녶뇀 = value;
		}
	}

	public TimeZone TimeZone
	{
		[CompilerGenerated]
		get
		{
			return 녶놽;
		}
		[CompilerGenerated]
		private set
		{
			녶놽 = value;
		}
	}

	public CustomSession[] Sessions
	{
		[CompilerGenerated]
		get
		{
			return 녶녿;
		}
		[CompilerGenerated]
		private set
		{
			녶녿 = value;
		}
	}

	public ISession[] ActiveSessions => Sessions.Where((CustomSession P_0) => P_0.IsActive).Cast<ISession>().ToArray();

	public CustomHoliday[] Holidays
	{
		[CompilerGenerated]
		get
		{
			return 녶놁;
		}
		[CompilerGenerated]
		private set
		{
			녶놁 = value;
		}
	}

	TimeZoneInfo ISessionsContainer.TimeZone
	{
		get
		{
			if (!TimeZone.IsEmpty)
			{
				return TimeZone.TimeZoneInfo;
			}
			return null;
		}
	}

	public IList<SettingItem> Settings
	{
		get
		{
			List<SettingItem> list = new List<SettingItem>();
			list.AddRange(new SettingItem[4]
			{
				new SettingItemString(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭놸(), Id),
				new SettingItemString(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놝(), Name),
				new SettingItemGroup(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭놇(), new List<SettingItem>
				{
					new SettingItemString(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭뇅(), TimeZone.TimeZoneInfo.Id),
					new SettingItemInteger(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶농(), (int)TimeZone.Type)
				}),
				new SettingItemGroup(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭놵(), Sessions.Select((CustomSession P_0) => new SettingItemGroup(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸놬(), P_0.Settings)).Cast<SettingItem>().ToList())
			});
			if (Holidays != null)
			{
				list.Add(new SettingItemGroup(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭놡(), Holidays?.Select((CustomHoliday P_0) => new SettingItemGroup(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸놊(), P_0.Settings)).Cast<SettingItem>().ToList()));
			}
			return list;
		}
		set
		{
			Id = value.GetValueOrDefault(Id, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭놸());
			Name = value.GetValueOrDefault(Name, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놝());
			if (value.TryGetValue<IList<SettingItem>>(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭놇(), out var value2))
			{
				TimeZoneType value3 = value2.GetValue<TimeZoneType>(new string[1] { _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶농() });
				TimeZoneInfo timeZoneInfo = null;
				if (value3 != TimeZoneType.Local)
				{
					timeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById(value2.GetValue<string>(new string[1] { _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭뇅() }));
				}
				TimeZone = new TimeZone(value3, timeZoneInfo);
			}
			if (value.TryGetValue<IList<SettingItem>>(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭놵(), out var value4))
			{
				List<CustomSession> list = new List<CustomSession>();
				foreach (SettingItem item2 in value4)
				{
					if (item2.Value is IList<SettingItem> settings)
					{
						CustomSession customSession = new CustomSession
						{
							Settings = settings
						};
						customSession.RecalculateOpenCloseTime(TimeZone.TimeZoneInfo);
						list.Add(customSession);
					}
				}
				Sessions = list.ToArray();
			}
			if (!value.TryGetValue<IList<SettingItem>>(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭놡(), out var value5))
			{
				return;
			}
			List<CustomHoliday> list2 = new List<CustomHoliday>();
			foreach (SettingItem item3 in value5)
			{
				if (item3.Value is IList<SettingItem> settings2)
				{
					CustomHoliday item = new CustomHoliday
					{
						Settings = settings2
					};
					list2.Add(item);
				}
			}
			Holidays = list2.ToArray();
		}
	}

	internal CustomSessionsContainer()
	{
	}

	public CustomSessionsContainer(string name, TimeZone? timeZone = null, CustomSession[] sessions = null, CustomHoliday[] holidays = null)
	{
		Id = Guid.NewGuid().ToShortString();
		Name = name;
		TimeZone = timeZone ?? Core.Instance.TimeUtils.SelectedTimeZone;
		Sessions = sessions ?? Array.Empty<CustomSession>();
		Holidays = holidays ?? Array.Empty<CustomHoliday>();
	}

	internal void 녴(CustomSessionsContainer P_0)
	{
		Name = P_0.Name;
		TimeZone = P_0.TimeZone;
		Sessions = P_0.Sessions ?? Array.Empty<CustomSession>();
		Holidays = P_0.Holidays ?? Array.Empty<CustomHoliday>();
	}

	public ISession[] GetSessionsForDate(DateTime dateTime)
	{
		DateTime 놇놾 = TimeZoneInfo.ConvertTimeFromUtc(dateTime, TimeZone.TimeZoneInfo);
		if (Holidays?.FirstOrDefault((CustomHoliday P_0) => P_0.Date.Date == 놇놾.Date) != null)
		{
			return Array.Empty<ISession>();
		}
		DayOfWeek 놇뇀 = 놇놾.DayOfWeek;
		return Sessions.Where((CustomSession P_0) => P_0.IsActive && P_0.Days.Contains(놇뇀)).Cast<ISession>().ToArray();
	}

	public int CompareTo(CustomSessionsContainer other)
	{
		return string.Compare(Name, other.Name, StringComparison.Ordinal);
	}

	public int CompareTo(object obj)
	{
		if (!(obj is CustomSessionsContainer other))
		{
			return 0;
		}
		return CompareTo(other);
	}

	public override string ToString()
	{
		return Name;
	}

	public MessageSessionsContainer BuildMessage()
	{
		return new MessageSessionsContainer
		{
			Id = Id,
			Name = Name,
			Description = string.Empty,
			Holidays = Holidays?.Select((CustomHoliday P_0) => new HolidayInfo
			{
				Name = P_0.Name,
				Date = P_0.Date
			}).ToArray(),
			SessionsSets = (from P_0 in Sessions?.GroupBy((CustomSession P_0) => ((IStructuralEquatable)P_0.Days.Select((DayOfWeek P_0) => (int)P_0).ToArray()).GetHashCode((IEqualityComparer)EqualityComparer<int>.Default))
				select new SessionsSet
				{
					Days = P_0.FirstOrDefault().Days,
					Sessions = P_0.Select((CustomSession P_0) => new Session(P_0.Name, P_0.OpenTime, P_0.CloseTime, P_0.Type)).ToArray()
				}).ToArray()
		};
	}
}
