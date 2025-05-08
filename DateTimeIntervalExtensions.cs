using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using TradingPlatform.BusinessLayer.Utils;

namespace TradingPlatform.BusinessLayer;

public static class DateTimeIntervalExtensions
{
	[CompilerGenerated]
	private sealed class 녴 : IEnumerable<Interval<DateTime>>, IEnumerable, IEnumerator<Interval<DateTime>>, IEnumerator, IDisposable
	{
		private int 놭놽;

		private Interval<DateTime> 놭녿;

		private int 놭놁;

		private TimeSpan 놭녭;

		public TimeSpan 놭녱;

		private Interval<DateTime> 놭놲;

		public Interval<DateTime> 놭높;

		private bool 놭놶;

		public bool 놭뇏;

		private DateTime 놭녻;

		private DateTime 놭녙;

		Interval<DateTime> IEnumerator<Interval<DateTime>>.Current
		{
			[DebuggerHidden]
			get
			{
				return 놭녿;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return 놭녿;
			}
		}

		[DebuggerHidden]
		public 녴(int P_0)
		{
			놭놽 = P_0;
			놭놁 = Environment.CurrentManagedThreadId;
		}

		[DebuggerHidden]
		private void 녴()
		{
			놭놽 = -2;
		}

		void IDisposable.Dispose()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 녴
			this.녴();
		}

		private bool MoveNext()
		{
			switch (놭놽)
			{
			default:
				return false;
			case 0:
				놭놽 = -1;
				if (놭녭 == TimeSpan.Zero || 놭녭 == Timeout.InfiniteTimeSpan)
				{
					놭녿 = 놭놲;
					놭놽 = 1;
					return true;
				}
				if (놭놲.IsReversal)
				{
					놭녙 = 놭놲.From;
					goto IL_0089;
				}
				놭녻 = 놭놲.From;
				goto IL_0151;
			case 1:
				놭놽 = -1;
				return false;
			case 2:
				놭놽 = -1;
				놭녙 = 놭녻;
				if (!(놭녻 > 놭놲.To))
				{
					break;
				}
				goto IL_0089;
			case 3:
				{
					놭놽 = -1;
					놭녻 = 놭녙;
					if (놭녙.Ticks >= 놭놲.To.Ticks)
					{
						break;
					}
					goto IL_0151;
				}
				IL_0151:
				놭녙 = 놭녻.Add(놭녭);
				if (놭놶)
				{
					놭녙 = 놭녙.FloorTo(놭녭);
				}
				if (놭녙 > 놭놲.To)
				{
					놭녙 = 놭놲.To;
				}
				놭녿 = new Interval<DateTime>(놭녻, 놭녙);
				놭놽 = 3;
				return true;
				IL_0089:
				놭녻 = 놭녙.Add(-놭녭);
				if (놭놶)
				{
					놭녻 = 놭녻.CeilingTo(놭녭);
				}
				if (놭녻 < 놭놲.To)
				{
					놭녻 = 놭놲.To;
				}
				놭녿 = new Interval<DateTime>(놭녻, 놭녙);
				놭놽 = 2;
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
		private IEnumerator<Interval<DateTime>> 놂()
		{
			녴 녴;
			if (놭놽 == -2 && 놭놁 == Environment.CurrentManagedThreadId)
			{
				놭놽 = 0;
				녴 = this;
			}
			else
			{
				녴 = new 녴(0);
			}
			녴.놭놲 = 놭높;
			녴.놭녭 = 놭녱;
			녴.놭놶 = 놭뇏;
			return 녴;
		}

		IEnumerator<Interval<DateTime>> IEnumerable<Interval<DateTime>>.GetEnumerator()
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

	public static TimeSpan GetLength(this Interval<DateTime> interval)
	{
		return TimeSpan.FromTicks(Math.Abs(interval.From.Ticks - interval.To.Ticks));
	}

	[IteratorStateMachine(typeof(녴))]
	public static IEnumerable<Interval<DateTime>> Split(this Interval<DateTime> interval, TimeSpan step, bool roundToStep = false)
	{
		//yield-return decompiler failed: Unexpected instruction in Iterator.Dispose()
		return new 녴(-2)
		{
			놭높 = interval,
			놭녱 = step,
			놭뇏 = roundToStep
		};
	}

	public static bool Contains(this Interval<DateTime> interval, Period period)
	{
		DateTime value = interval.From;
		DateTime dateTime = interval.To;
		if (interval.IsReversal)
		{
			value = interval.To;
			dateTime = interval.From;
		}
		dateTime = dateTime.AddTicks(1L);
		long ticks = value.CeilingTo(period).Ticks;
		long ticks2 = dateTime.FloorTo(period).Ticks;
		return period.Ticks <= ticks2 - ticks;
	}
}
