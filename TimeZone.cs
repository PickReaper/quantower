using System;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;

namespace TradingPlatform.BusinessLayer;

public readonly struct TimeZone : IEquatable<TimeZone>, IComparable<TimeZone>, IComparable
{
	[CompilerGenerated]
	private readonly TimeZoneInfo 놂놔;

	[CompilerGenerated]
	private readonly TimeZoneType 놂놾;

	public TimeZoneInfo TimeZoneInfo
	{
		[CompilerGenerated]
		get
		{
			return 놂놔;
		}
	}

	public TimeZoneType Type
	{
		[CompilerGenerated]
		get
		{
			return 놂놾;
		}
	}

	public bool IsEmpty
	{
		get
		{
			if (Type == TimeZoneType.Specific)
			{
				return TimeZoneInfo == null;
			}
			return false;
		}
	}

	public TimeZone(TimeZoneType type, TimeZoneInfo timeZoneInfo = null)
	{
		if (type == TimeZoneType.Local && timeZoneInfo != null)
		{
			throw new ArgumentException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놉());
		}
		if (type == TimeZoneType.Specific && timeZoneInfo == null)
		{
			throw new ArgumentNullException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놥());
		}
		놂놾 = type;
		놂놔 = ((type == TimeZoneType.Local) ? TimeZoneInfo.Local : timeZoneInfo);
	}

	public static string ShortName(TimeZone timeZone)
	{
		if (timeZone.Type != TimeZoneType.Local)
		{
			return 녴(timeZone.TimeZoneInfo, false);
		}
		return _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놯();
	}

	public static string Cities(TimeZone timeZone)
	{
		return 녴(timeZone.TimeZoneInfo, true);
	}

	private static string 녴(TimeZoneInfo P_0, bool P_1)
	{
		if (P_0 == null)
		{
			return string.Empty;
		}
		if (P_0.Id == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂녾())
		{
			return _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂녬();
		}
		if (P_1)
		{
			int num = P_0.DisplayName.IndexOf(')') + 1;
			return _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놀() + P_0.DisplayName.Substring(num, P_0.DisplayName.Length - num);
		}
		return _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놀() + P_0.DisplayName.Substring(1, P_0.DisplayName.IndexOf(')') - 1);
	}

	public static bool operator ==(TimeZone timeZone1, TimeZone timeZone2)
	{
		if (timeZone1.Type == timeZone2.Type)
		{
			return timeZone1.TimeZoneInfo?.Id == timeZone2.TimeZoneInfo?.Id;
		}
		return false;
	}

	public static bool operator !=(TimeZone timeZone1, TimeZone timeZone2)
	{
		if (timeZone1.Type == timeZone2.Type)
		{
			return timeZone1.TimeZoneInfo?.Id != timeZone2.TimeZoneInfo?.Id;
		}
		return true;
	}

	public bool Equals(TimeZone other)
	{
		if (object.Equals(TimeZoneInfo, other.TimeZoneInfo))
		{
			return Type == other.Type;
		}
		return false;
	}

	public override bool Equals(object obj)
	{
		if (obj is TimeZone other)
		{
			return Equals(other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return (((TimeZoneInfo != null) ? TimeZoneInfo.GetHashCode() : 0) * 397) ^ (int)Type;
	}

	public int CompareTo(TimeZone other)
	{
		if (TimeZoneInfo == null)
		{
			return 1;
		}
		if (other.TimeZoneInfo == null)
		{
			return -1;
		}
		int num = TimeZoneInfo.BaseUtcOffset.CompareTo(other.TimeZoneInfo.BaseUtcOffset);
		if (num != 0)
		{
			return num;
		}
		return string.Compare(TimeZoneInfo.Id, other.TimeZoneInfo.Id, StringComparison.Ordinal);
	}

	public int CompareTo(object obj)
	{
		if (!(obj is TimeZone other))
		{
			return 0;
		}
		return CompareTo(other);
	}

	public override string ToString()
	{
		return TimeZoneInfo?.DisplayName;
	}
}
