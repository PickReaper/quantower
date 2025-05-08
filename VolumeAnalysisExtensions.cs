using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using TradingPlatform.BusinessLayer.Utils;

namespace TradingPlatform.BusinessLayer;

public static class VolumeAnalysisExtensions
{
	[Serializable]
	[CompilerGenerated]
	private sealed class 녴
	{
		public static readonly 녴 놭녟 = new 녴();

		public static Func<VolumeAnalysisData, DateTime> 놭놱;

		public static Func<VolumeAnalysisData, VolumeAnalysisData> 놭놖;

		public static Func<KeyValuePair<DateTime, VolumeAnalysisData>, VolumeAnalysisData> 놭놝;

		public static Func<VolumeAnalysisData, DateTime> 놭뇄;

		internal DateTime 녴(VolumeAnalysisData P_0)
		{
			return P_0.TimeLeft;
		}

		internal VolumeAnalysisData 놴(VolumeAnalysisData P_0)
		{
			return P_0;
		}

		internal VolumeAnalysisData 녴(KeyValuePair<DateTime, VolumeAnalysisData> P_0)
		{
			return P_0.Value;
		}

		internal DateTime 놂(VolumeAnalysisData P_0)
		{
			return P_0.TimeLeft;
		}
	}

	[CompilerGenerated]
	private sealed class 놴 : IEnumerable<VolumeAnalysisData>, IEnumerable, IEnumerator<VolumeAnalysisData>, IEnumerator, IDisposable
	{
		private int 놭녑;

		private VolumeAnalysisData 놭놈;

		private int 놭놬;

		private IEnumerable<IVolumeTickData> 놭놊;

		public IEnumerable<IVolumeTickData> 놭놪;

		private CancellationToken 놭놌;

		public CancellationToken 놭놕;

		private Period 놭뇊;

		public Period 놭놋;

		private double 놭녣;

		public double 놭녩;

		private IEnumerator<IVolumeTickData> 놭놤;

		private IVolumeTickData 놭논;

		private DateTime 놭녘;

		VolumeAnalysisData IEnumerator<VolumeAnalysisData>.Current
		{
			[DebuggerHidden]
			get
			{
				return 놭놈;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return 놭놈;
			}
		}

		[DebuggerHidden]
		public 놴(int P_0)
		{
			놭녑 = P_0;
			놭놬 = Environment.CurrentManagedThreadId;
		}

		[DebuggerHidden]
		private void 녴()
		{
			int num = 놭녑;
			if (num == -3 || num == 1)
			{
				try
				{
				}
				finally
				{
					놴();
				}
			}
			놭놤 = null;
			놭논 = null;
			놭녑 = -2;
		}

		void IDisposable.Dispose()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 녴
			this.녴();
		}

		private bool MoveNext()
		{
			bool result;
			try
			{
				VolumeAnalysisData volumeAnalysisData;
				Interval<DateTime> interval;
				double num;
				switch (놭녑)
				{
				default:
					result = false;
					goto end_IL_0000;
				case 0:
					놭녑 = -1;
					if (놭놊 != null)
					{
						volumeAnalysisData = null;
						interval = default(Interval<DateTime>);
						놭놤 = 놭놊.GetEnumerator();
						놭녑 = -3;
						goto IL_0146;
					}
					result = false;
					goto end_IL_0000;
				case 1:
					놭녑 = -3;
					goto IL_00c9;
				case 2:
					{
						놭녑 = -1;
						break;
					}
					IL_00dd:
					if (volumeAnalysisData == null)
					{
						volumeAnalysisData = new VolumeAnalysisData
						{
							TimeLeft = interval.From
						};
					}
					num = 놭논.Price;
					if (!double.IsNaN(놭녣))
					{
						num = CoreMath.RoundToIncrement(num, 놭녣);
					}
					volumeAnalysisData.Calculate(num, 놭논.Volume, Symbol.ConvertTickDirection(놭논.TickDirection));
					놭논 = null;
					goto IL_0146;
					IL_00c9:
					interval = 놭뇊.FindInterval(놭녘);
					volumeAnalysisData = null;
					goto IL_00dd;
					IL_0146:
					if (놭놤.MoveNext())
					{
						놭논 = 놭놤.Current;
						if (놭놌.IsCancellationRequested)
						{
							result = false;
							놴();
						}
						else
						{
							놭녘 = new DateTime(놭논.Time, DateTimeKind.Utc);
							if (interval.Contains(놭녘))
							{
								goto IL_00dd;
							}
							if (volumeAnalysisData == null)
							{
								goto IL_00c9;
							}
							놭놈 = volumeAnalysisData;
							놭녑 = 1;
							result = true;
						}
					}
					else
					{
						놴();
						놭놤 = null;
						if (volumeAnalysisData == null)
						{
							break;
						}
						놭놈 = volumeAnalysisData;
						놭녑 = 2;
						result = true;
					}
					goto end_IL_0000;
				}
				result = false;
				end_IL_0000:;
			}
			catch
			{
				//try-fault
				녴();
				throw;
			}
			return result;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void 놴()
		{
			놭녑 = -1;
			if (놭놤 != null)
			{
				놭놤.Dispose();
			}
		}

		[DebuggerHidden]
		private void 놂()
		{
			throw new NotSupportedException();
		}

		void IEnumerator.Reset()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 놂
			this.놂();
		}

		[DebuggerHidden]
		private IEnumerator<VolumeAnalysisData> 놎()
		{
			놴 놴;
			if (놭녑 == -2 && 놭놬 == Environment.CurrentManagedThreadId)
			{
				놭녑 = 0;
				놴 = this;
			}
			else
			{
				놴 = new 놴(0);
			}
			놴.놭놊 = 놭놪;
			놴.놭뇊 = 놭놋;
			놴.놭놌 = 놭놕;
			놴.놭녣 = 놭녩;
			return 놴;
		}

		IEnumerator<VolumeAnalysisData> IEnumerable<VolumeAnalysisData>.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 놎
			return this.놎();
		}

		[DebuggerHidden]
		private IEnumerator 녞()
		{
			return 놎();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 녞
			return this.녞();
		}
	}

	[CompilerGenerated]
	private sealed class 놂 : IEnumerable<VolumeAnalysisData>, IEnumerable, IEnumerator<VolumeAnalysisData>, IEnumerator, IDisposable
	{
		private int 놭노;

		private VolumeAnalysisData 놭녒;

		private int 놭녕;

		private IEnumerable<VolumeAnalysisData> 놭녖;

		public IEnumerable<VolumeAnalysisData> 녲녴;

		private CancellationToken 녲놴;

		public CancellationToken 녲놂;

		private Period 녲놎;

		public Period 녲녞;

		private IEnumerator<VolumeAnalysisData> 녲놫;

		private VolumeAnalysisData 녲녪;

		private DateTime 녲녶;

		VolumeAnalysisData IEnumerator<VolumeAnalysisData>.Current
		{
			[DebuggerHidden]
			get
			{
				return 놭녒;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return 놭녒;
			}
		}

		[DebuggerHidden]
		public 놂(int P_0)
		{
			놭노 = P_0;
			놭녕 = Environment.CurrentManagedThreadId;
		}

		[DebuggerHidden]
		private void 녴()
		{
			int num = 놭노;
			if (num == -3 || num == 1)
			{
				try
				{
				}
				finally
				{
					놴();
				}
			}
			녲놫 = null;
			녲녪 = null;
			놭노 = -2;
		}

		void IDisposable.Dispose()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 녴
			this.녴();
		}

		private bool MoveNext()
		{
			bool result;
			try
			{
				VolumeAnalysisData volumeAnalysisData;
				Interval<DateTime> interval;
				switch (놭노)
				{
				default:
					result = false;
					goto end_IL_0000;
				case 0:
					놭노 = -1;
					if (놭녖 != null)
					{
						volumeAnalysisData = null;
						interval = default(Interval<DateTime>);
						녲놫 = 놭녖.GetEnumerator();
						놭노 = -3;
						goto IL_0100;
					}
					result = false;
					goto end_IL_0000;
				case 1:
					놭노 = -3;
					goto IL_00c3;
				case 2:
					{
						놭노 = -1;
						break;
					}
					IL_00d7:
					if (volumeAnalysisData == null)
					{
						volumeAnalysisData = new VolumeAnalysisData
						{
							TimeLeft = interval.From
						};
					}
					volumeAnalysisData.Combine(녲녪);
					녲녪 = null;
					goto IL_0100;
					IL_00c3:
					interval = 녲놎.FindInterval(녲녶);
					volumeAnalysisData = null;
					goto IL_00d7;
					IL_0100:
					if (녲놫.MoveNext())
					{
						녲녪 = 녲놫.Current;
						if (녲놴.IsCancellationRequested)
						{
							result = false;
							놴();
						}
						else
						{
							녲녶 = 녲녪.TimeLeft;
							if (interval.Contains(녲녶))
							{
								goto IL_00d7;
							}
							if (volumeAnalysisData == null)
							{
								goto IL_00c3;
							}
							놭녒 = volumeAnalysisData;
							놭노 = 1;
							result = true;
						}
					}
					else
					{
						놴();
						녲놫 = null;
						if (volumeAnalysisData == null)
						{
							break;
						}
						놭녒 = volumeAnalysisData;
						놭노 = 2;
						result = true;
					}
					goto end_IL_0000;
				}
				result = false;
				end_IL_0000:;
			}
			catch
			{
				//try-fault
				녴();
				throw;
			}
			return result;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void 놴()
		{
			놭노 = -1;
			if (녲놫 != null)
			{
				녲놫.Dispose();
			}
		}

		[DebuggerHidden]
		private void 놂()
		{
			throw new NotSupportedException();
		}

		void IEnumerator.Reset()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 놂
			this.놂();
		}

		[DebuggerHidden]
		private IEnumerator<VolumeAnalysisData> 놎()
		{
			놂 놂;
			if (놭노 == -2 && 놭녕 == Environment.CurrentManagedThreadId)
			{
				놭노 = 0;
				놂 = this;
			}
			else
			{
				놂 = new 놂(0);
			}
			놂.놭녖 = 녲녴;
			놂.녲놎 = 녲녞;
			놂.녲놴 = 녲놂;
			return 놂;
		}

		IEnumerator<VolumeAnalysisData> IEnumerable<VolumeAnalysisData>.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 놎
			return this.놎();
		}

		[DebuggerHidden]
		private IEnumerator 녞()
		{
			return 놎();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 녞
			return this.녞();
		}
	}

	[CompilerGenerated]
	private sealed class 놎 : IEnumerable<VolumeAnalysisData>, IEnumerable, IEnumerator<VolumeAnalysisData>, IEnumerator, IDisposable
	{
		private int 녲녵;

		private VolumeAnalysisData 녲놭;

		private int 녲녲;

		private IEnumerable<IVolumeTickData> 녲뇋;

		public IEnumerable<IVolumeTickData> 녲놸;

		private CancellationToken 녲놿;

		public CancellationToken 녲놄;

		private Period 녲놰;

		public Period 녲놓;

		private double 녲놇;

		public double 녲뇅;

		private IEnumerator<IVolumeTickData> 녲놵;

		private IVolumeTickData 녲놡;

		private DateTime 녲놻;

		VolumeAnalysisData IEnumerator<VolumeAnalysisData>.Current
		{
			[DebuggerHidden]
			get
			{
				return 녲놭;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return 녲놭;
			}
		}

		[DebuggerHidden]
		public 놎(int P_0)
		{
			녲녵 = P_0;
			녲녲 = Environment.CurrentManagedThreadId;
		}

		[DebuggerHidden]
		private void 녴()
		{
			int num = 녲녵;
			if (num == -3 || num == 1)
			{
				try
				{
				}
				finally
				{
					놴();
				}
			}
			녲놵 = null;
			녲놡 = null;
			녲녵 = -2;
		}

		void IDisposable.Dispose()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 녴
			this.녴();
		}

		private bool MoveNext()
		{
			bool result;
			try
			{
				VolumeAnalysisData volumeAnalysisData;
				Interval<DateTime> interval;
				double num;
				switch (녲녵)
				{
				default:
					result = false;
					goto end_IL_0000;
				case 0:
					녲녵 = -1;
					if (녲뇋 != null)
					{
						volumeAnalysisData = null;
						interval = default(Interval<DateTime>);
						녲놵 = 녲뇋.GetEnumerator();
						녲녵 = -3;
						goto IL_0141;
					}
					result = false;
					goto end_IL_0000;
				case 1:
					녲녵 = -3;
					goto IL_00c9;
				case 2:
					{
						녲녵 = -1;
						break;
					}
					IL_00dd:
					if (volumeAnalysisData == null)
					{
						volumeAnalysisData = new VolumeAnalysisData
						{
							TimeLeft = interval.From
						};
					}
					num = 녲놡.Price;
					if (!double.IsNaN(녲놇))
					{
						num = CoreMath.RoundToIncrement(num, 녲놇);
					}
					volumeAnalysisData.Calculate(num, 녲놡.Volume, 녲놡.AggressorFlag);
					녲놡 = null;
					goto IL_0141;
					IL_00c9:
					interval = 녲놰.FindInterval(녲놻);
					volumeAnalysisData = null;
					goto IL_00dd;
					IL_0141:
					if (녲놵.MoveNext())
					{
						녲놡 = 녲놵.Current;
						if (녲놿.IsCancellationRequested)
						{
							result = false;
							놴();
						}
						else
						{
							녲놻 = new DateTime(녲놡.Time, DateTimeKind.Utc);
							if (interval.Contains(녲놻))
							{
								goto IL_00dd;
							}
							if (volumeAnalysisData == null)
							{
								goto IL_00c9;
							}
							녲놭 = volumeAnalysisData;
							녲녵 = 1;
							result = true;
						}
					}
					else
					{
						놴();
						녲놵 = null;
						if (volumeAnalysisData == null)
						{
							break;
						}
						녲놭 = volumeAnalysisData;
						녲녵 = 2;
						result = true;
					}
					goto end_IL_0000;
				}
				result = false;
				end_IL_0000:;
			}
			catch
			{
				//try-fault
				녴();
				throw;
			}
			return result;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void 놴()
		{
			녲녵 = -1;
			if (녲놵 != null)
			{
				녲놵.Dispose();
			}
		}

		[DebuggerHidden]
		private void 놂()
		{
			throw new NotSupportedException();
		}

		void IEnumerator.Reset()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 놂
			this.놂();
		}

		[DebuggerHidden]
		private IEnumerator<VolumeAnalysisData> 놎()
		{
			놎 놎;
			if (녲녵 == -2 && 녲녲 == Environment.CurrentManagedThreadId)
			{
				녲녵 = 0;
				놎 = this;
			}
			else
			{
				놎 = new 놎(0);
			}
			놎.녲뇋 = 녲놸;
			놎.녲놰 = 녲놓;
			놎.녲놿 = 녲놄;
			놎.녲놇 = 녲뇅;
			return 놎;
		}

		IEnumerator<VolumeAnalysisData> IEnumerable<VolumeAnalysisData>.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 놎
			return this.놎();
		}

		[DebuggerHidden]
		private IEnumerator 녞()
		{
			return 놎();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 녞
			return this.녞();
		}
	}

	[IteratorStateMachine(typeof(놴))]
	public static IEnumerable<VolumeAnalysisData> AggregateVolumeAnalysis(this IEnumerable<IVolumeTickData> tickItems, Period period, CancellationToken cancellationToken, double minVolumeAnalysisTickSize = double.NaN)
	{
		//yield-return decompiler failed: Unexpected instruction in Iterator.Dispose()
		return new 놴(-2)
		{
			놭놪 = tickItems,
			놭놋 = period,
			놭놕 = cancellationToken,
			놭녩 = minVolumeAnalysisTickSize
		};
	}

	[IteratorStateMachine(typeof(놎))]
	public static IEnumerable<VolumeAnalysisData> AggregateVolumeAnalysisByAgressor(this IEnumerable<IVolumeTickData> tickItems, Period period, CancellationToken cancellationToken, double minVolumeAnalysisTickSize = double.NaN)
	{
		//yield-return decompiler failed: Unexpected instruction in Iterator.Dispose()
		return new 놎(-2)
		{
			녲놸 = tickItems,
			녲놓 = period,
			녲놄 = cancellationToken,
			녲뇅 = minVolumeAnalysisTickSize
		};
	}

	[IteratorStateMachine(typeof(놂))]
	public static IEnumerable<VolumeAnalysisData> AggregateVolumeAnalysis(this IEnumerable<VolumeAnalysisData> dataItems, Period period, CancellationToken cancellationToken)
	{
		//yield-return decompiler failed: Unexpected instruction in Iterator.Dispose()
		return new 놂(-2)
		{
			녲녴 = dataItems,
			녲녞 = period,
			녲놂 = cancellationToken
		};
	}

	public static IList<VolumeAnalysisData> Combine(this IEnumerable<VolumeAnalysisData> dataItems, IEnumerable<VolumeAnalysisData> anotherItems)
	{
		Dictionary<DateTime, VolumeAnalysisData> dictionary = dataItems.ToDictionary((VolumeAnalysisData P_0) => P_0.TimeLeft, (VolumeAnalysisData P_0) => P_0);
		foreach (VolumeAnalysisData anotherItem in anotherItems)
		{
			if (dictionary.TryGetValue(anotherItem.TimeLeft, out var value))
			{
				value.Combine(anotherItem);
			}
			else
			{
				dictionary.Add(anotherItem.TimeLeft, anotherItem);
			}
		}
		return (from P_0 in dictionary
			select P_0.Value into P_0
			orderby P_0.TimeLeft
			select P_0).ToList();
	}

	public static VolumeAnalysisData Collapse(this IEnumerable<VolumeAnalysisData> dataItems)
	{
		VolumeAnalysisData volumeAnalysisData = new VolumeAnalysisData();
		foreach (VolumeAnalysisData dataItem in dataItems)
		{
			volumeAnalysisData.Combine(dataItem);
		}
		return volumeAnalysisData;
	}
}
