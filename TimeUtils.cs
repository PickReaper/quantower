using System;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using 녴;

namespace TradingPlatform.BusinessLayer;

public sealed class TimeUtils
{
	public const long UNIX_START_TIME_TICKS = 621355968000000000L;

	[CompilerGenerated]
	private TimeZone 놂녡;

	[CompilerGenerated]
	private DateTime 놂녦;

	[CompilerGenerated]
	private 뇅 놂놀;

	public DateTime DateTimeUtcNow => DateTime.UtcNow.AddMilliseconds(TimeSynchronizer.ServerTimeOffset);

	public int ServerTimeOffset => TimeSynchronizer?.ServerTimeOffset ?? 0;

	public TimeZone SelectedTimeZone
	{
		[CompilerGenerated]
		get
		{
			return 놂녡;
		}
		[CompilerGenerated]
		set
		{
			놂녡 = value;
		}
	}

	public DateTime StartTerminalDateTimeUtc
	{
		[CompilerGenerated]
		get
		{
			return 놂녦;
		}
		[CompilerGenerated]
		private set
		{
			놂녦 = value;
		}
	}

	internal 뇅 TimeSynchronizer
	{
		[CompilerGenerated]
		get
		{
			return 놂놀;
		}
		[CompilerGenerated]
		private set
		{
			놂놀 = value;
		}
	}

	public bool IsSyncFailed => TimeSynchronizer.State == 놵.놂놥;

	public string SyncErrorMessage => TimeSynchronizer.LastSyncErrorMessage;

	public TimeUtils()
	{
		TimeSynchronizer = new 뇅();
		SelectedTimeZone = new TimeZone(TimeZoneType.Local);
	}

	internal void 녴()
	{
		Core.Instance.Loggers.Log(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂녚(), LoggingLevel.Verbose);
		TimeSynchronizer.녴();
		StartTerminalDateTimeUtc = DateTimeUtcNow;
		Core.Instance.Loggers.Log(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂녳(), LoggingLevel.Verbose);
	}

	internal void 놴()
	{
		TimeSynchronizer.Dispose();
	}

	public DateTime ConvertFromUTCToSelectedTimeZone(DateTime dateTime)
	{
		return ConvertFromUTCToTimeZone(dateTime, SelectedTimeZone);
	}

	public TimeSpan ConvertFromUTCToSelectedTimeZone(TimeSpan time)
	{
		return ConvertFromUTCToTimeZone(time, SelectedTimeZone);
	}

	public DateTime ConvertFromSelectedTimeZoneToUTC(DateTime dateTime)
	{
		return ConvertFromTimeZoneToUTC(dateTime, SelectedTimeZone);
	}

	public DateTime ConvertFromUTCToTimeZone(DateTime dateTime, TimeZone timeZone)
	{
		if (timeZone.TimeZoneInfo != null && dateTime.Kind != DateTimeKind.Local)
		{
			return TimeZoneInfo.ConvertTimeFromUtc(dateTime, timeZone.TimeZoneInfo);
		}
		return dateTime;
	}

	public TimeSpan ConvertFromUTCToTimeZone(TimeSpan time, TimeZone timeZone)
	{
		DateTime dateTime = DateTimeUtcNow.Date + time;
		if (timeZone.TimeZoneInfo != null && dateTime.Kind != DateTimeKind.Local)
		{
			return TimeZoneInfo.ConvertTimeFromUtc(dateTime, timeZone.TimeZoneInfo).TimeOfDay;
		}
		return time;
	}

	public DateTime ConvertFromTimeZoneToUTC(DateTime dateTime, TimeZone timeZone)
	{
		if (dateTime.Kind == DateTimeKind.Utc)
		{
			return dateTime;
		}
		if (dateTime.Kind == DateTimeKind.Local)
		{
			dateTime = DateTime.SpecifyKind(dateTime, DateTimeKind.Unspecified);
		}
		if (timeZone.TimeZoneInfo != null)
		{
			return TimeZoneInfo.ConvertTimeToUtc(dateTime, timeZone.TimeZoneInfo);
		}
		return dateTime;
	}
}
