using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Xml.Linq;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using ProtoBuf;
using TradingPlatform.BusinessLayer.Serialization;

namespace TradingPlatform.BusinessLayer;

/// <summary>
/// Represents mechanism for supporting predefined and custom periods
/// </summary>
[Serializable]
[Published]
[DataContract(Name = "Period", Namespace = "TradingPlatform")]
[ProtoContract]
public struct Period : IComparable, IXElementSerialization
{
	[CompilerGenerated]
	private int 녶녓;

	[CompilerGenerated]
	private BasePeriod 녶녛;

	/// <summary>
	/// Gets period multiplier
	/// </summary>
	[DataMember(Name = "PeriodMultiplier")]
	[ProtoMember(1)]
	public int PeriodMultiplier
	{
		[CompilerGenerated]
		readonly get
		{
			return 녶녓;
		}
		[CompilerGenerated]
		private set
		{
			녶녓 = value;
		}
	}

	/// <summary>
	/// Gets base period type
	/// </summary>
	[DataMember(Name = "BasePeriod")]
	[ProtoMember(2)]
	public BasePeriod BasePeriod
	{
		[CompilerGenerated]
		readonly get
		{
			return 녶녛;
		}
		[CompilerGenerated]
		private set
		{
			녶녛 = value;
		}
	}

	/// <summary>
	/// Gets ticks value as an result of base period <see cref="M:TradingPlatform.BusinessLayer.Period.TicksInBasePeriod(TradingPlatform.BusinessLayer.BasePeriod)" /> multiplicated by <see cref="P:TradingPlatform.BusinessLayer.Period.PeriodMultiplier" />
	/// </summary>
	public long Ticks => TicksInBasePeriod(BasePeriod) * PeriodMultiplier;

	public TimeSpan Duration => TimeSpan.FromTicks(Ticks);

	/// <summary>
	/// Predefined period
	/// </summary>
	public static Period TICK1 => new Period(BasePeriod.Tick, 1);

	/// <summary>
	/// Predefined period
	/// </summary>
	public static Period SECOND1 => new Period(BasePeriod.Second, 1);

	/// <summary>
	/// Predefined period
	/// </summary>
	public static Period SECOND5 => new Period(BasePeriod.Second, 5);

	/// <summary>
	/// Predefined period
	/// </summary>
	public static Period SECOND10 => new Period(BasePeriod.Second, 10);

	/// <summary>
	/// Predefined period
	/// </summary>
	public static Period SECOND15 => new Period(BasePeriod.Second, 15);

	/// <summary>
	/// Predefined period
	/// </summary>
	public static Period SECOND30 => new Period(BasePeriod.Second, 30);

	/// <summary>
	/// Predefined period
	/// </summary>
	public static Period MIN1 => new Period(BasePeriod.Minute, 1);

	/// <summary>
	/// Predefined period
	/// </summary>
	public static Period MIN2 => new Period(BasePeriod.Minute, 2);

	/// <summary>
	/// Predefined period
	/// </summary>
	public static Period MIN3 => new Period(BasePeriod.Minute, 3);

	/// <summary>
	/// Predefined period
	/// </summary>
	public static Period MIN4 => new Period(BasePeriod.Minute, 4);

	/// <summary>
	/// Predefined period
	/// </summary>
	public static Period MIN5 => new Period(BasePeriod.Minute, 5);

	/// <summary>
	/// Predefined period
	/// </summary>
	public static Period MIN10 => new Period(BasePeriod.Minute, 10);

	/// <summary>
	/// Predefined period
	/// </summary>
	public static Period MIN15 => new Period(BasePeriod.Minute, 15);

	/// <summary>
	/// Predefined period
	/// </summary>
	public static Period MIN30 => new Period(BasePeriod.Minute, 30);

	/// <summary>
	/// Predefined period
	/// </summary>
	public static Period HOUR1 => new Period(BasePeriod.Hour, 1);

	/// <summary>
	/// Predefined period
	/// </summary>
	public static Period HOUR2 => new Period(BasePeriod.Hour, 2);

	/// <summary>
	/// Predefined period
	/// </summary>
	public static Period HOUR3 => new Period(BasePeriod.Hour, 3);

	/// <summary>
	/// Predefined period
	/// </summary>
	public static Period HOUR4 => new Period(BasePeriod.Hour, 4);

	/// <summary>
	/// Predefined period
	/// </summary>
	public static Period HOUR6 => new Period(BasePeriod.Hour, 6);

	/// <summary>
	/// Predefined period
	/// </summary>
	public static Period HOUR8 => new Period(BasePeriod.Hour, 8);

	/// <summary>
	/// Predefined period
	/// </summary>
	public static Period HOUR12 => new Period(BasePeriod.Hour, 12);

	/// <summary>
	/// Predefined period
	/// </summary>
	public static Period DAY1 => new Period(BasePeriod.Day, 1);

	/// <summary>
	/// Predefined period
	/// </summary>
	public static Period WEEK1 => new Period(BasePeriod.Week, 1);

	/// <summary>
	/// Predefined period
	/// </summary>
	public static Period MONTH1 => new Period(BasePeriod.Month, 1);

	/// <summary>
	/// Predefined period
	/// </summary>
	public static Period YEAR1 => new Period(BasePeriod.Year, 1);

	/// <summary>
	/// Creates Period instance with <see cref="P:TradingPlatform.BusinessLayer.Period.PeriodMultiplier" /> greater than 0
	/// </summary>
	/// <param name="basePeriod"></param>
	/// <param name="periodMultiplier"></param>
	public Period(BasePeriod basePeriod, int periodMultiplier)
	{
		if (periodMultiplier <= 0)
		{
			throw new ArgumentException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭녙(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭놢());
		}
		BasePeriod = basePeriod;
		PeriodMultiplier = periodMultiplier;
	}

	/// <summary>
	/// True if their base paeriods and <see cref="P:TradingPlatform.BusinessLayer.Period.PeriodMultiplier" /> are respectively equal.
	/// </summary>
	/// <param name="period1"></param>
	/// <param name="period2"></param>
	/// <returns></returns>
	[NotPublished]
	public static bool operator ==(Period period1, Period period2)
	{
		if (period1.BasePeriod == period2.BasePeriod)
		{
			return period1.PeriodMultiplier == period2.PeriodMultiplier;
		}
		return false;
	}

	/// <summary>
	/// True if any of their base paeriods and <see cref="P:TradingPlatform.BusinessLayer.Period.PeriodMultiplier" /> are respectively not equal.
	/// </summary>
	/// <param name="period1"></param>
	/// <param name="period2"></param>
	/// <returns></returns>
	[NotPublished]
	public static bool operator !=(Period period1, Period period2)
	{
		if (period1.BasePeriod == period2.BasePeriod)
		{
			return period1.PeriodMultiplier != period2.PeriodMultiplier;
		}
		return true;
	}

	/// <summary>
	/// True if their ticks values are satisfying initial condition
	/// </summary>
	/// <param name="period1"></param>
	/// <param name="period2"></param>
	/// <returns></returns>
	[NotPublished]
	public static bool operator <(Period period1, Period period2)
	{
		long ticks = period1.Ticks;
		long ticks2 = period2.Ticks;
		if (ticks < 0 && ticks2 < 0)
		{
			return ticks > ticks2;
		}
		return ticks < ticks2;
	}

	/// <summary>
	/// True if their ticks values are satisfying initial condition
	/// </summary>
	/// <param name="period1"></param>
	/// <param name="period2"></param>
	/// <returns></returns>
	[NotPublished]
	public static bool operator >(Period period1, Period period2)
	{
		long ticks = period1.Ticks;
		long ticks2 = period2.Ticks;
		if (ticks < 0 && ticks2 < 0)
		{
			return ticks < ticks2;
		}
		return ticks > ticks2;
	}

	/// <summary>
	/// True if their ticks values are satisfying initial condition
	/// </summary>
	/// <param name="period1"></param>
	/// <param name="period2"></param>
	/// <returns></returns>
	[NotPublished]
	public static bool operator <=(Period period1, Period period2)
	{
		long ticks = period1.Ticks;
		long ticks2 = period2.Ticks;
		if (ticks < 0 && ticks2 < 0)
		{
			return ticks >= ticks2;
		}
		return ticks <= ticks2;
	}

	/// <summary>
	/// True if their ticks values are satisfying initial condition
	/// </summary>
	/// <param name="period1"></param>
	/// <param name="period2"></param>
	/// <returns></returns>
	[NotPublished]
	public static bool operator >=(Period period1, Period period2)
	{
		long ticks = period1.Ticks;
		long ticks2 = period2.Ticks;
		if (ticks < 0 && ticks2 < 0)
		{
			return ticks <= ticks2;
		}
		return ticks >= ticks2;
	}

	/// <summary>
	/// True if their base paeriods and <see cref="P:TradingPlatform.BusinessLayer.Period.PeriodMultiplier" /> are respectively equal.
	/// </summary>
	/// <param name="obj"></param>
	/// <returns></returns>
	[NotPublished]
	public override bool Equals(object obj)
	{
		if (obj is Period period)
		{
			if (BasePeriod == period.BasePeriod)
			{
				return PeriodMultiplier == period.PeriodMultiplier;
			}
			return false;
		}
		return false;
	}

	[NotPublished]
	public override int GetHashCode()
	{
		return PeriodMultiplier ^ (int)BasePeriod;
	}

	/// <summary>
	/// Formats given value to a specific user friendly string
	/// </summary>
	/// <param name="dateTime"></param>
	/// <returns></returns>
	[NotPublished]
	public string Format(DateTime dateTime)
	{
		string shortDatePattern = DateTimeFormatInfo.CurrentInfo.ShortDatePattern;
		switch (BasePeriod)
		{
		case BasePeriod.Tick:
			if (PeriodMultiplier > 1)
			{
				return dateTime.ToString(shortDatePattern + _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭녧());
			}
			return dateTime.ToString(shortDatePattern + _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭녤());
		case BasePeriod.Second:
			return dateTime.ToString(shortDatePattern + _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭녧());
		case BasePeriod.Minute:
		case BasePeriod.Hour:
			return dateTime.ToString(shortDatePattern + _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭놆());
		case BasePeriod.Day:
		case BasePeriod.Week:
			return dateTime.ToString(shortDatePattern);
		case BasePeriod.Month:
		case BasePeriod.Year:
			return dateTime.ToString(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭뇎());
		default:
			return dateTime.ToString(shortDatePattern);
		}
	}

	[NotPublished]
	public string Format()
	{
		return $"{PeriodMultiplier}{BasePeriodToShortString(BasePeriod)}";
	}

	[NotPublished]
	public override string ToString()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 2);
		defaultInterpolatedStringHandler.AppendFormatted(PeriodMultiplier);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴뇎());
		defaultInterpolatedStringHandler.AppendFormatted(BasePeriod);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	/// <summary>
	/// Returns value in ticks according to base period type
	/// </summary>
	/// <param name="basePeriod"></param>
	/// <returns></returns>
	public static long TicksInBasePeriod(BasePeriod basePeriod)
	{
		return basePeriod switch
		{
			BasePeriod.Tick => -1L, 
			BasePeriod.Second => 10000000L, 
			BasePeriod.Minute => 600000000L, 
			BasePeriod.Hour => 36000000000L, 
			BasePeriod.Day => 864000000000L, 
			BasePeriod.Week => 6048000000000L, 
			BasePeriod.Month => 25920000000000L, 
			BasePeriod.Year => 315360000000000L, 
			_ => throw new ArgumentException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭놷()), 
		};
	}

	/// <summary>
	/// Returns shorted string according to base period type
	/// </summary>
	/// <param name="basePeriod"></param>
	/// <returns></returns>
	public static string BasePeriodToShortString(BasePeriod basePeriod)
	{
		return basePeriod switch
		{
			BasePeriod.Tick => loc._(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놎놊(), null, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭녗()), 
			BasePeriod.Second => loc._(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놎뇀(), null, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭녗()), 
			BasePeriod.Minute => loc._(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭놜(), null, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭녗()), 
			BasePeriod.Hour => loc._(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭놨(), null, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭녗()), 
			BasePeriod.Day => loc._(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭녢(), null, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭녗()), 
			BasePeriod.Week => loc._(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭놞(), null, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭녗()), 
			BasePeriod.Month => loc._(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂녡(), null, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭녗()), 
			BasePeriod.Year => loc._(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭놳(), null, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭녗()), 
			_ => string.Empty, 
		};
	}

	/// <summary>
	/// Converts time gap into dates range
	/// </summary>
	/// <param name="from"></param>
	/// <param name="to"></param>
	public void ToDatesRange(out DateTime from, out DateTime to)
	{
		DateTime dateTimeUtcNow = Core.Instance.TimeUtils.DateTimeUtcNow;
		if (BasePeriod == BasePeriod.Day)
		{
			from = dateTimeUtcNow.AddDays(-PeriodMultiplier);
		}
		else if (BasePeriod == BasePeriod.Month)
		{
			from = dateTimeUtcNow.AddMonths(-PeriodMultiplier);
		}
		else if (BasePeriod == BasePeriod.Year)
		{
			from = dateTimeUtcNow.AddYears(-PeriodMultiplier);
		}
		else
		{
			from = dateTimeUtcNow.AddTicks(-Ticks);
		}
		to = dateTimeUtcNow;
	}

	/// <summary>
	/// Compares by <see cref="P:TradingPlatform.BusinessLayer.Period.Ticks" />
	/// </summary>
	/// <param name="other"></param>
	/// <returns></returns>
	[NotPublished]
	public int CompareTo(object other)
	{
		return Ticks.CompareTo(((Period)other).Ticks);
	}

	public static bool TryParse(string value, out Period period)
	{
		period = default(Period);
		string[] array = value.Split('-');
		if (array.Length != 2)
		{
			return false;
		}
		if (!int.TryParse(array[0].Trim(), out var result))
		{
			return false;
		}
		if (!Enum.TryParse<BasePeriod>(array[1].Trim(), ignoreCase: true, out var result2))
		{
			return false;
		}
		period = new Period(result2, result);
		return true;
	}

	/// <summary>
	/// Serialize into <see cref="T:System.Xml.Linq.XElement" /> object
	/// </summary>
	/// <returns></returns>
	[NotPublished]
	public XElement ToXElement()
	{
		return new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇁(), new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭놺(), ((int)BasePeriod).ToString()), new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭놅(), PeriodMultiplier.ToString()));
	}

	/// <summary>
	/// Deserialize from <see cref="T:System.Xml.Linq.XElement" />
	/// </summary>
	/// <param name="element"></param>
	/// <param name="deserializationInfo"></param>
	[NotPublished]
	public void FromXElement(XElement element, DeserializationInfo deserializationInfo)
	{
		XElement xElement = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭놺());
		if (xElement != null)
		{
			BasePeriod = (BasePeriod)xElement.ToInt();
		}
		XElement xElement2 = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭놅());
		if (xElement2 != null)
		{
			PeriodMultiplier = xElement2.ToInt();
		}
	}
}
