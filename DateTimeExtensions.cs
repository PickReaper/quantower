using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace TradingPlatform.BusinessLayer;

public static class DateTimeExtensions
{
	[CompilerGenerated]
	private sealed class 녴 : IEnumerable<DateTime>, IEnumerable, IEnumerator<DateTime>, IEnumerator, IDisposable
	{
		private int 놭놗;

		private DateTime 놭뇂;

		private int 놭놩;

		private DateTime 놭녡;

		public DateTime 놭녦;

		private DayOfWeek 놭놀;

		public DayOfWeek 놭놔;

		private DateTime 놭놾;

		private DateTime 놭뇀;

		DateTime IEnumerator<DateTime>.Current
		{
			[DebuggerHidden]
			get
			{
				return 놭뇂;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return 놭뇂;
			}
		}

		[DebuggerHidden]
		public 녴(int P_0)
		{
			놭놗 = P_0;
			놭놩 = Environment.CurrentManagedThreadId;
		}

		[DebuggerHidden]
		private void 녴()
		{
			놭놗 = -2;
		}

		void IDisposable.Dispose()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 녴
			this.녴();
		}

		private bool MoveNext()
		{
			switch (놭놗)
			{
			default:
				return false;
			case 0:
				놭놗 = -1;
				놭놾 = new DateTime(놭녡.Year, 놭녡.Month, 1);
				놭뇀 = 놭놾.AddMonths(1);
				while (놭놾 < 놭뇀 && 놭놾.DayOfWeek != 놭놀)
				{
					놭놾 = 놭놾.AddDays(1.0);
				}
				break;
			case 1:
				놭놗 = -1;
				놭놾 = 놭놾.AddDays(7.0);
				break;
			}
			if (놭놾 < 놭뇀)
			{
				놭뇂 = 놭놾;
				놭놗 = 1;
				return true;
			}
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		private void 놴()
		{
			throw new NotSupportedException();
		}

		void IEnumerator.Reset()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 놴
			this.놴();
		}

		[DebuggerHidden]
		private IEnumerator<DateTime> 놂()
		{
			녴 녴;
			if (놭놗 == -2 && 놭놩 == Environment.CurrentManagedThreadId)
			{
				놭놗 = 0;
				녴 = this;
			}
			else
			{
				녴 = new 녴(0);
			}
			녴.놭녡 = 놭녦;
			녴.놭놀 = 놭놔;
			return 녴;
		}

		IEnumerator<DateTime> IEnumerable<DateTime>.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 놂
			return this.놂();
		}

		[DebuggerHidden]
		private IEnumerator 놎()
		{
			return 놂();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 놎
			return this.놎();
		}
	}

	public static DateTime ToSelectedTimeZone(this DateTime dt)
	{
		return Core.Instance.TimeUtils.ConvertFromUTCToSelectedTimeZone(dt);
	}

	public static DateTime FromSelectedTimeZoneToUtc(this DateTime dt)
	{
		return Core.Instance.TimeUtils.ConvertFromSelectedTimeZoneToUTC(dt);
	}

	public static DateTime TrimSeconds(this DateTime value)
	{
		return new DateTime(value.Year, value.Month, value.Day, value.Hour, value.Minute, 0, value.Kind);
	}

	public static DateTime CeilingTo(this DateTime value, TimeSpan timeSpan)
	{
		long num = value.Ticks % timeSpan.Ticks;
		if (num == 0L)
		{
			return value;
		}
		return new DateTime(value.Ticks - num + timeSpan.Ticks, value.Kind);
	}

	public static DateTime CeilingTo(this DateTime value, Period period)
	{
		return value.CeilingTo(TimeSpan.FromTicks(period.Ticks));
	}

	public static DateTime FloorTo(this DateTime value, TimeSpan timeSpan)
	{
		return new DateTime(value.Ticks - value.Ticks % timeSpan.Ticks, value.Kind);
	}

	public static DateTime FloorTo(this DateTime value, Period period)
	{
		return value.FloorTo(TimeSpan.FromTicks(period.Ticks));
	}

	public static long ToUnixSeconds(this DateTime dateTime)
	{
		return new DateTimeOffset(dateTime).ToUnixTimeSeconds();
	}

	public static long ToUnixMilliseconds(this DateTime dateTime)
	{
		return new DateTimeOffset(dateTime).ToUnixTimeMilliseconds();
	}

	public static DateTime SetKind(this DateTime dateTime, DateTimeKind kind)
	{
		return new DateTime(dateTime.Ticks, kind);
	}

	public static int GetWeekOfYear(this DateTime dateTime, DayOfWeek firstWeekDay = DayOfWeek.Monday)
	{
		return CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(dateTime, CalendarWeekRule.FirstFullWeek, firstWeekDay);
	}

	[IteratorStateMachine(typeof(녴))]
	public static IEnumerable<DateTime> GetDaysOfWeekForCurrMonth(this DateTime date, DayOfWeek dayOfWeek)
	{
		//yield-return decompiler failed: Unexpected instruction in Iterator.Dispose()
		return new 녴(-2)
		{
			놭녦 = date,
			놭놔 = dayOfWeek
		};
	}
}
