using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using TradingPlatform.BusinessLayer.Utils;

namespace TradingPlatform.BusinessLayer;

public static class IntervalExtensions
{
	[Serializable]
	[CompilerGenerated]
	private sealed class 녴<녴> where 녴 : IComparable<녴>
	{
		public static readonly 녴<녴> 놭녢 = new 녴<녴>();

		public static Func<Interval<녴>, 녴> 놭놞;

		public static Func<녴, 녴> 놭놳;

		public static Func<Interval<녴>, 녴> 놭놺;

		public static Func<녴, 녴> 놭놅;

		internal 녴 녴(Interval<녴> P_0)
		{
			return P_0.Min;
		}

		internal 녴 녴(녴 P_0)
		{
			return P_0;
		}

		internal 녴 놴(Interval<녴> P_0)
		{
			return P_0.Max;
		}

		internal 녴 놴(녴 P_0)
		{
			return P_0;
		}
	}

	[CompilerGenerated]
	private sealed class 놴<녴> : IEnumerable<Interval<녴>>, IEnumerable, IEnumerator<Interval<녴>>, IEnumerator, IDisposable where 녴 : IComparable<녴>
	{
		private int 놭녜;

		private Interval<녴> 놭뇃;

		private int 놭녯;

		private IEnumerable<Interval<녴>> 놭놮;

		public IEnumerable<Interval<녴>> 놭녫;

		private 녴[] 놭뇁;

		private 녴[] 놭놧;

		private int 놭녝;

		private int 놭뇈;

		private int 놭놑;

		private 녴 놭놦;

		Interval<녴> IEnumerator<Interval<녴>>.Current
		{
			[DebuggerHidden]
			get
			{
				return 놭뇃;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return 놭뇃;
			}
		}

		[DebuggerHidden]
		public 놴(int P_0)
		{
			놭녜 = P_0;
			놭녯 = Environment.CurrentManagedThreadId;
		}

		[DebuggerHidden]
		private void 녴()
		{
			놭뇁 = null;
			놭놧 = null;
			놭놦 = default(녴);
			놭녜 = -2;
		}

		void IDisposable.Dispose()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 녴
			this.녴();
		}

		private bool MoveNext()
		{
			녴 from;
			switch (놭녜)
			{
			default:
				return false;
			case 0:
			{
				놭녜 = -1;
				Interval<녴>[] source = 놭놮.ToArray();
				놭뇁 = (from P_0 in source
					select P_0.Min into P_0
					orderby P_0
					select P_0).ToArray();
				놭놧 = (from P_0 in source
					select P_0.Max into P_0
					orderby P_0
					select P_0).ToArray();
				놭녝 = 0;
				놭뇈 = 0;
				from = 놭뇁.First();
				놭놑 = 0;
				goto IL_01bc;
			}
			case 1:
				놭녜 = -1;
				from = 놭놦;
				goto IL_01b0;
			case 2:
				{
					놭녜 = -1;
					return false;
				}
				IL_01bc:
				if (놭녝 < 놭뇁.Length && 놭뇈 < 놭놧.Length)
				{
					놭놦 = 놭뇁[놭녝];
					녴 val = 놭놧[놭뇈];
					if (놭놦.CompareTo(val) <= 0)
					{
						놭놑++;
						놭녝++;
					}
					else
					{
						놭놑--;
						놭뇈++;
					}
					if (놭놑 == 0)
					{
						놭뇃 = new Interval<녴>(from, val);
						놭녜 = 1;
						return true;
					}
					goto IL_01b0;
				}
				놭뇃 = new Interval<녴>(from, 놭놧.Last());
				놭녜 = 2;
				return true;
				IL_01b0:
				놭놦 = default(녴);
				goto IL_01bc;
			}
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
		private IEnumerator<Interval<녴>> 놂()
		{
			놴<녴> 놴;
			if (놭녜 == -2 && 놭녯 == Environment.CurrentManagedThreadId)
			{
				놭녜 = 0;
				놴 = this;
			}
			else
			{
				놴 = new 놴<녴>(0);
			}
			놴.놭놮 = 놭녫;
			return 놴;
		}

		IEnumerator<Interval<녴>> IEnumerable<Interval<녴>>.GetEnumerator()
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

	/// <summary>
	/// Combines intersecting intervals
	/// </summary>
	[IteratorStateMachine(typeof(놴<>))]
	public static IEnumerable<Interval<T>> Optimize<T>(this IEnumerable<Interval<T>> intervals) where T : IComparable<T>
	{
		//yield-return decompiler failed: Unexpected instruction in Iterator.Dispose()
		return new 놴<T>(-2)
		{
			놭녫 = intervals
		};
	}
}
