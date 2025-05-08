using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using TradingPlatform.BusinessLayer.Utils.Extensions;

namespace TradingPlatform.BusinessLayer;

public class CustomSession : ISession, ICustomizable
{
	[Serializable]
	[CompilerGenerated]
	private sealed class 녴
	{
		public static readonly 녴 놇놵 = new 녴();

		public static Func<DayOfWeek, string> 놇놡;

		internal string 녴(DayOfWeek P_0)
		{
			return P_0.ToString();
		}
	}

	[CompilerGenerated]
	private bool 녶놸;

	[CompilerGenerated]
	private string 녶놿;

	[CompilerGenerated]
	private SessionType 녶놄;

	[CompilerGenerated]
	private TimeSpan 녶놰;

	[CompilerGenerated]
	private TimeSpan 녶놓;

	[CompilerGenerated]
	private TimeSpan 녶놇;

	[CompilerGenerated]
	private TimeSpan 녶뇅;

	private bool 녶놵;

	[CompilerGenerated]
	private DayOfWeek[] 녶놡;

	[CompilerGenerated]
	private bool 녶놻;

	public bool IsActive
	{
		[CompilerGenerated]
		get
		{
			return 녶놸;
		}
		[CompilerGenerated]
		set
		{
			녶놸 = value;
		}
	}

	public string Name
	{
		[CompilerGenerated]
		get
		{
			return 녶놿;
		}
		[CompilerGenerated]
		set
		{
			녶놿 = value;
		}
	}

	public SessionType Type
	{
		[CompilerGenerated]
		get
		{
			return 녶놄;
		}
		[CompilerGenerated]
		set
		{
			녶놄 = value;
		}
	}

	public TimeSpan OpenTime
	{
		[CompilerGenerated]
		get
		{
			return 녶놰;
		}
		[CompilerGenerated]
		private set
		{
			녶놰 = value;
		}
	}

	public TimeSpan CloseTime
	{
		[CompilerGenerated]
		get
		{
			return 녶놓;
		}
		[CompilerGenerated]
		private set
		{
			녶놓 = value;
		}
	}

	public TimeSpan OpenOffset
	{
		[CompilerGenerated]
		get
		{
			return 녶놇;
		}
		[CompilerGenerated]
		set
		{
			녶놇 = value;
		}
	}

	public TimeSpan CloseOffset
	{
		[CompilerGenerated]
		get
		{
			return 녶뇅;
		}
		[CompilerGenerated]
		set
		{
			녶뇅 = value;
		}
	}

	public DayOfWeek[] Days
	{
		[CompilerGenerated]
		get
		{
			return 녶놡;
		}
		[CompilerGenerated]
		set
		{
			녶놡 = value;
		}
	}

	public bool IsPrimary
	{
		[CompilerGenerated]
		get
		{
			return 녶놻;
		}
		[CompilerGenerated]
		set
		{
			녶놻 = value;
		}
	}

	public IList<SettingItem> Settings
	{
		get
		{
			return new List<SettingItem>
			{
				new SettingItemBoolean(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭놫(), IsActive),
				new SettingItemString(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놝(), Name),
				new SettingItemInteger(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶농(), (int)Type),
				new SettingItemLong(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭녶(), OpenOffset.Ticks),
				new SettingItemLong(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭녵(), CloseOffset.Ticks),
				new SettingItemString(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭놭(), string.Join(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂녤(), Days.Select((DayOfWeek P_0) => P_0.ToString())))
			};
		}
		set
		{
			IsActive = value.GetValueOrDefault(IsActive, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭놫());
			Name = value.GetValueOrDefault(Name, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놝());
			Type = (SessionType)value.GetValueOrDefault((int)Type, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶농());
			if (value.TryGetValue<long>(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭녶(), out var value2))
			{
				OpenOffset = TimeSpan.FromTicks(value2);
				if (value.TryGetValue<long>(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭녵(), out var value3))
				{
					CloseOffset = TimeSpan.FromTicks(value3);
				}
			}
			else
			{
				녶놵 = true;
				if (value.TryGetValue<long>(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭녲(), out var value4))
				{
					OpenTime = TimeSpan.FromTicks(value4);
				}
				if (value.TryGetValue<long>(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭뇋(), out var value5))
				{
					CloseTime = TimeSpan.FromTicks(value5);
				}
			}
			if (!value.TryGetValue<string>(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭놭(), out var value6))
			{
				return;
			}
			string[] array = value6.Split(new string[1] { _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂녤() }, StringSplitOptions.RemoveEmptyEntries);
			List<DayOfWeek> list = new List<DayOfWeek>();
			string[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				if (Enum.TryParse<DayOfWeek>(array2[i], ignoreCase: true, out var result))
				{
					list.Add(result);
				}
			}
			Days = list.ToArray();
		}
	}

	public void RecalculateOpenCloseTime(TimeZoneInfo timeZoneInfo)
	{
		if (녶놵)
		{
			OpenOffset = OpenTime.ConvertTimeZone(TimeZoneInfo.Utc, timeZoneInfo);
			CloseOffset = CloseTime.ConvertTimeZone(TimeZoneInfo.Utc, timeZoneInfo);
		}
		else
		{
			OpenTime = OpenOffset.ConvertTimeZone(timeZoneInfo, TimeZoneInfo.Utc);
			CloseTime = CloseOffset.ConvertTimeZone(timeZoneInfo, TimeZoneInfo.Utc);
		}
	}
}
