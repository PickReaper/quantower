using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using TradingPlatform.BusinessLayer.Utils;
using 녴;

namespace TradingPlatform.BusinessLayer;

/// <summary>
/// Represent access to historical data information and indicators control.
/// </summary>
[Published]
public class HistoricalData : IDisposable, IIndicatorsCollection, 놎, IEnumerable<IHistoryItem>, IEnumerable
{
	[Serializable]
	[CompilerGenerated]
	private sealed class 녴
	{
		public static readonly 녴 놇녬 = new 녴();

		public static Action<Indicator> 놇녹;

		public static Func<Period, BasePeriod> 놇녔;

		public static Func<Period, int> 놇녠;

		public static Func<IGrouping<BasePeriod, Period>, Period> 놇놠;

		public static Func<BasePeriod, Period> 놇놟;

		public static Func<Period, long> 놇녓;

		public static Func<Period, BasePeriod> 놇녛;

		public static Func<Period, int> 놇녽;

		public static Func<IGrouping<BasePeriod, Period>, Period> 놇놏;

		public static Func<BasePeriod, Period> 놇녥;

		public static Func<Period, long> 놇농;

		public static Func<Period, HistoryAggregationTimeStatistics> 놇념;

		public static Func<Period, BasePeriod> 놇녨;

		public static Func<Period, int> 놇녺;

		public static Func<IGrouping<BasePeriod, Period>, Period> 놇놣;

		public static Func<BasePeriod, Period> 놇녮;

		public static Func<Period, long> 놇뇆;

		public static Func<Period, HistoryAggregationVolumeProfile> 놇뇉;

		internal void 녴(Indicator P_0)
		{
			P_0.Refresh();
		}

		internal BasePeriod 녴(Period P_0)
		{
			return P_0.BasePeriod;
		}

		internal Period 녴(IGrouping<BasePeriod, Period> P_0)
		{
			return P_0.OrderByDescending((Period P_0) => P_0.PeriodMultiplier).Last();
		}

		internal int 놴(Period P_0)
		{
			return P_0.PeriodMultiplier;
		}

		internal Period 녴(BasePeriod P_0)
		{
			return new Period(P_0, 1);
		}

		internal long 놂(Period P_0)
		{
			return P_0.Ticks;
		}

		internal BasePeriod 놎(Period P_0)
		{
			return P_0.BasePeriod;
		}

		internal Period 놴(IGrouping<BasePeriod, Period> P_0)
		{
			return P_0.OrderByDescending((Period P_0) => P_0.PeriodMultiplier).Last();
		}

		internal int 녞(Period P_0)
		{
			return P_0.PeriodMultiplier;
		}

		internal Period 놴(BasePeriod P_0)
		{
			return new Period(P_0, 1);
		}

		internal long 놫(Period P_0)
		{
			return P_0.Ticks;
		}

		internal HistoryAggregationTimeStatistics 녪(Period P_0)
		{
			return new HistoryAggregationTimeStatistics(P_0);
		}

		internal BasePeriod 녶(Period P_0)
		{
			return P_0.BasePeriod;
		}

		internal Period 놂(IGrouping<BasePeriod, Period> P_0)
		{
			return P_0.OrderByDescending((Period P_0) => P_0.PeriodMultiplier).Last();
		}

		internal int 녵(Period P_0)
		{
			return P_0.PeriodMultiplier;
		}

		internal Period 놂(BasePeriod P_0)
		{
			return new Period(P_0, 1);
		}

		internal long 놭(Period P_0)
		{
			return P_0.Ticks;
		}

		internal HistoryAggregationVolumeProfile 녲(Period P_0)
		{
			return new HistoryAggregationVolumeProfile(P_0);
		}
	}

	[CompilerGenerated]
	private sealed class 놴
	{
		public HistoryAggregationTime 놇뇍;

		public HistoryAggregationTimeStatistics 놇놙;

		public HistoryAggregationVolumeProfile 놇녰;

		internal bool 녴(Period P_0)
		{
			return 놇뇍.Period.Ticks % P_0.Ticks == 0;
		}

		internal bool 놴(Period P_0)
		{
			return P_0.Ticks < 놇뇍.Period.Ticks;
		}

		internal HistoryAggregationTime 놂(Period P_0)
		{
			return new HistoryAggregationTime(P_0, 놇뇍.HistoryType);
		}

		internal bool 놎(Period P_0)
		{
			return 놇놙.Period.Ticks % P_0.Ticks == 0;
		}

		internal bool 녞(Period P_0)
		{
			return P_0.Ticks < 놇놙.Period.Ticks;
		}

		internal bool 놫(Period P_0)
		{
			return 놇녰.Period.Ticks % P_0.Ticks == 0;
		}

		internal bool 녪(Period P_0)
		{
			return P_0.Ticks < 놇녰.Period.Ticks;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct 놂
	{
		public HistoricalData 놇놚;

		public MessageQuote 놇놹;
	}

	[CompilerGenerated]
	private HistoryEventHandler 녶놢;

	[CompilerGenerated]
	private HistoryEventHandler 녶녧;

	[CompilerGenerated]
	private HistoryEventHandler 녶녤;

	private readonly List<IHistoryItem> 녶놆;

	protected readonly object itemsLocker;

	protected HistoryRequestParameters Parameters;

	private protected IHistoryProcessor 녶뇎;

	[CompilerGenerated]
	private readonly BuiltInIndicators 녶놷;

	private bool 녶녗;

	private CancellationTokenSource 녶놜;

	private HistoricalDataState 녶놨;

	private readonly ConcurrentQueue<MessageQuote> 녶녢;

	private readonly bool 녶놞;

	private MessageQuote 녶놳;

	private MessageQuote 녶놺;

	private MessageQuote 녶놅;

	private readonly ManualResetEventSlim 녶녜;

	private protected readonly List<Indicator> 녶뇃;

	private readonly object 녶녯;

	[CompilerGenerated]
	private Action 녶놮;

	[CompilerGenerated]
	private IVolumeAnalysisCalculationProgress 녶녫;

	/// <summary>
	/// Gets HistoricalData symbol
	/// </summary>
	public Symbol Symbol => Parameters?.Symbol;

	/// <summary>
	/// Gets HistoricalData aggregation
	/// </summary>
	public HistoryAggregation Aggregation => Parameters?.Aggregation;

	/// <summary>
	/// Gets HistoricalData left time boundary
	/// </summary>
	public DateTime FromTime => Parameters.FromTime;

	/// <summary>
	/// Gets HistoricalData right time boundary
	/// </summary>
	public DateTime ToTime => Parameters.ToTime;

	/// <summary>
	/// Gets HistoricalData items amount
	/// </summary>
	public virtual int Count
	{
		get
		{
			lock (itemsLocker)
			{
				return 녶놆.Count;
			}
		}
	}

	/// <summary>
	/// Retrieves HistoricalData item by indexing offset and direction to find.
	/// </summary>
	/// <param name="offset"></param>
	/// <param name="origin"></param>
	/// <returns></returns>
	public virtual IHistoryItem this[int offset, SeekOriginHistory origin = SeekOriginHistory.End]
	{
		get
		{
			if (origin == SeekOriginHistory.End)
			{
				return 녶놆[Count - 1 - offset];
			}
			return 녶놆[offset];
		}
		private set
		{
			lock (itemsLocker)
			{
				if (P_1 == SeekOriginHistory.End)
				{
					녶놆[Count - 1 - P_0] = value;
				}
				else
				{
					녶놆[P_0] = value;
				}
			}
		}
	}

	/// <summary>
	/// Gets access to built-in indicators
	/// </summary>
	public BuiltInIndicators BuiltInIndicators
	{
		[CompilerGenerated]
		get
		{
			return 녶놷;
		}
	}

	protected virtual bool NeedSubscribe
	{
		get
		{
			if (!녶녗)
			{
				return ToTime == default(DateTime);
			}
			return false;
		}
	}

	/// <summary>
	/// Gets array of attached indicators
	/// </summary>
	public Indicator[] AttachedIndicators
	{
		get
		{
			lock (녶녯)
			{
				return 녶뇃.ToArray();
			}
		}
	}

	[NotPublished]
	public IVolumeAnalysisCalculationProgress VolumeAnalysisCalculationProgress
	{
		[CompilerGenerated]
		get
		{
			return 녶녫;
		}
		[CompilerGenerated]
		set
		{
			녶녫 = value;
		}
	}

	/// <summary>
	/// Will be triggered when new historical item created
	/// </summary>
	public event HistoryEventHandler NewHistoryItem
	{
		[CompilerGenerated]
		add
		{
			HistoryEventHandler historyEventHandler = 녶놢;
			HistoryEventHandler historyEventHandler2;
			do
			{
				historyEventHandler2 = historyEventHandler;
				HistoryEventHandler value2 = (HistoryEventHandler)Delegate.Combine(historyEventHandler2, value);
				historyEventHandler = Interlocked.CompareExchange(ref 녶놢, value2, historyEventHandler2);
			}
			while ((object)historyEventHandler != historyEventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			HistoryEventHandler historyEventHandler = 녶놢;
			HistoryEventHandler historyEventHandler2;
			do
			{
				historyEventHandler2 = historyEventHandler;
				HistoryEventHandler value2 = (HistoryEventHandler)Delegate.Remove(historyEventHandler2, value);
				historyEventHandler = Interlocked.CompareExchange(ref 녶놢, value2, historyEventHandler2);
			}
			while ((object)historyEventHandler != historyEventHandler2);
		}
	}

	/// <summary>
	/// Will be triggered when current historical item changed or updated
	/// </summary>
	public event HistoryEventHandler HistoryItemUpdated
	{
		[CompilerGenerated]
		add
		{
			HistoryEventHandler historyEventHandler = 녶녧;
			HistoryEventHandler historyEventHandler2;
			do
			{
				historyEventHandler2 = historyEventHandler;
				HistoryEventHandler value2 = (HistoryEventHandler)Delegate.Combine(historyEventHandler2, value);
				historyEventHandler = Interlocked.CompareExchange(ref 녶녧, value2, historyEventHandler2);
			}
			while ((object)historyEventHandler != historyEventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			HistoryEventHandler historyEventHandler = 녶녧;
			HistoryEventHandler historyEventHandler2;
			do
			{
				historyEventHandler2 = historyEventHandler;
				HistoryEventHandler value2 = (HistoryEventHandler)Delegate.Remove(historyEventHandler2, value);
				historyEventHandler = Interlocked.CompareExchange(ref 녶녧, value2, historyEventHandler2);
			}
			while ((object)historyEventHandler != historyEventHandler2);
		}
	}

	/// <summary>
	/// Will be triggered when volume analysis of current historical item changed or updated
	/// </summary>
	public event Action HistoryItemVolumeAnalysisUpdated
	{
		[CompilerGenerated]
		add
		{
			Action action = 녶놮;
			Action action2;
			do
			{
				action2 = action;
				Action value2 = (Action)Delegate.Combine(action2, value);
				action = Interlocked.CompareExchange(ref 녶놮, value2, action2);
			}
			while ((object)action != action2);
		}
		[CompilerGenerated]
		remove
		{
			Action action = 녶놮;
			Action action2;
			do
			{
				action2 = action;
				Action value2 = (Action)Delegate.Remove(action2, value);
				action = Interlocked.CompareExchange(ref 녶놮, value2, action2);
			}
			while ((object)action != action2);
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal void 녴(HistoryEventHandler P_0)
	{
		HistoryEventHandler historyEventHandler = 녶녤;
		HistoryEventHandler historyEventHandler2;
		do
		{
			historyEventHandler2 = historyEventHandler;
			HistoryEventHandler value = (HistoryEventHandler)Delegate.Combine(historyEventHandler2, P_0);
			historyEventHandler = Interlocked.CompareExchange(ref 녶녤, value, historyEventHandler2);
		}
		while ((object)historyEventHandler != historyEventHandler2);
	}

	[SpecialName]
	[CompilerGenerated]
	internal void 놴(HistoryEventHandler P_0)
	{
		HistoryEventHandler historyEventHandler = 녶녤;
		HistoryEventHandler historyEventHandler2;
		do
		{
			historyEventHandler2 = historyEventHandler;
			HistoryEventHandler value = (HistoryEventHandler)Delegate.Remove(historyEventHandler2, P_0);
			historyEventHandler = Interlocked.CompareExchange(ref 녶녤, value, historyEventHandler2);
		}
		while ((object)historyEventHandler != historyEventHandler2);
	}

	private protected HistoricalData()
	{
		녶놆 = new List<IHistoryItem>();
		itemsLocker = new object();
		녶녗 = false;
		녶뇃 = new List<Indicator>();
		녶녯 = new object();
		녶놨 = HistoricalDataState.Pending;
		녶녢 = new ConcurrentQueue<MessageQuote>();
		녶녜 = new ManualResetEventSlim();
	}

	protected internal HistoricalData(HistoryRequestParameters historyRequestParameters)
		: this()
	{
		Parameters = historyRequestParameters;
		HistoryAggregation historyAggregation = Core.Instance.HistoryAggregations[Parameters.Aggregation.Name];
		if (historyAggregation == null)
		{
			throw new ArgumentException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭뇇() + Parameters.Aggregation.Name);
		}
		historyAggregation = historyAggregation.Clone() as HistoryAggregation;
		if (historyAggregation != null)
		{
			historyAggregation.Settings = Parameters.Aggregation.Settings;
		}
		Parameters.Aggregation = historyAggregation;
		녶놞 = historyRequestParameters.ForceReload;
		녶놷 = new BuiltInIndicators(this);
	}

	/// <summary>
	/// Reloads entire HistoricalData
	/// </summary>
	public void Reload()
	{
		if (Symbol == null || Symbol.State == BusinessObjectState.Fake)
		{
			return;
		}
		try
		{
			녶놨 = HistoricalDataState.Loading;
			녶놜?.Cancel();
			if (Parameters.CancellationToken == CancellationToken.None)
			{
				녶놜 = new CancellationTokenSource();
			}
			놴();
			녴();
			DateTime dateTimeUtcNow = Core.Instance.TimeUtils.DateTimeUtcNow;
			HistoryRequestParameters copy = Parameters.Copy;
			copy.ToTime = ((ToTime == default(DateTime) || ToTime >= dateTimeUtcNow) ? dateTimeUtcNow : ToTime);
			if (Symbol.QuoteDelay != default(TimeSpan) && copy.ToTime > dateTimeUtcNow - Symbol.QuoteDelay)
			{
				copy.ToTime = dateTimeUtcNow - Symbol.QuoteDelay;
			}
			copy.ForceReload = 녶놞;
			copy.CancellationToken = 녶놜?.Token ?? Parameters.CancellationToken;
			copy.ProgressInfo = Parameters.ProgressInfo;
			if (Core.Instance.SymbolsMapping.TryGetHistorySymbol(Symbol, copy.Aggregation.GetPeriod, out var historySymbol))
			{
				copy.Symbol = historySymbol;
			}
			if (NeedSubscribe)
			{
				SubscribeSymbol();
				if (Aggregation.IsWaitingFirstQuoteRequired)
				{
					WaitHandle.WaitAny(new WaitHandle[3]
					{
						copy.CancellationToken.WaitHandle,
						녶녜.WaitHandle,
						new CancellationTokenSource(TimeSpan.FromSeconds(3.0)).Token.WaitHandle
					});
				}
				if (녶놳 != null)
				{
					copy.ToTime = 녶놳.Time.AddMilliseconds(1.0);
				}
			}
			if (!(FromTime == ToTime) || !(ToTime == default(DateTime)))
			{
				IList<IHistoryItem> list = 녴(copy);
				if (Parameters.ExcludeOutOfSession && list != null && list.Count > 0 && Parameters.SessionsContainer != null && Parameters.SessionsContainer.ActiveSessions.Any())
				{
					HistoryAggregation aggregationToDirectDownload = Parameters.Aggregation.GetAggregationToDirectDownload(Parameters.Symbol.HistoryMetadata);
					if (aggregationToDirectDownload == null || !(aggregationToDirectDownload is HistoryAggregationTime historyAggregationTime) || !(historyAggregationTime.Period >= Period.DAY1))
					{
						list = list.Where((IHistoryItem P_0) => Parameters.SessionsContainer.ContainsDate(P_0.TicksLeft)).ToList();
					}
				}
				if (list != null)
				{
					lock (itemsLocker)
					{
						녶놆.AddRange(list);
					}
				}
			}
			lock (녶녯)
			{
				녶뇃.ForEach(delegate(Indicator P_0)
				{
					P_0.Refresh();
				});
			}
			놂();
		}
		catch (Exception ex)
		{
			Core.Instance.Loggers.Log(ex);
		}
		finally
		{
			녶놨 = HistoricalDataState.Working;
		}
	}

	private protected virtual IList<IHistoryItem> 녴(HistoryRequestParameters P_0)
	{
		LoggerManager loggers = Core.Instance.Loggers;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(49, 4);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶놛());
		defaultInterpolatedStringHandler.AppendFormatted(P_0.RequestId);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶놗());
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭놛());
		defaultInterpolatedStringHandler.AppendFormatted(P_0.Symbol);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂녹());
		defaultInterpolatedStringHandler.AppendFormatted(P_0.Aggregation);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂녹());
		defaultInterpolatedStringHandler.AppendFormatted(P_0.Interval);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶놩());
		loggers.Log(defaultInterpolatedStringHandler.ToStringAndClear(), LoggingLevel.Performance);
		DateTime dateTimeUtcNow = Core.Instance.TimeUtils.DateTimeUtcNow;
		long num = 0L;
		int num2 = 0;
		List<IHistoryItem> list = new List<IHistoryItem>();
		if (P_0.Symbol.State == BusinessObjectState.Fake)
		{
			return list;
		}
		if (P_0.FromTime > P_0.ToTime)
		{
			return list;
		}
		Connection connection = Core.Instance.Connections[P_0.Symbol.ConnectionId];
		if (connection == null || !connection.Connected)
		{
			return list;
		}
		CancellationToken cancellationToken = P_0.CancellationToken;
		HistoryRequestParameters copy = P_0.Copy;
		copy.ProgressInfo = P_0.ProgressInfo;
		HistoryAggregation aggregationToDirectDownload = copy.Aggregation.GetAggregationToDirectDownload(P_0.Symbol.HistoryMetadata);
		if (aggregationToDirectDownload == null)
		{
			return list;
		}
		copy.Aggregation = aggregationToDirectDownload;
		Interval<DateTime>[] array = copy.Interval.Split(P_0.Symbol.GetHistoryDownloadingStep(copy.Aggregation)).ToArray();
		if (!array.Any())
		{
			return list;
		}
		long num3 = copy.FromTime.Ticks;
		Interval<DateTime>[] array2 = array;
		for (int i = 0; i < array2.Length; i++)
		{
			Interval<DateTime> interval = array2[i];
			if (cancellationToken.IsCancellationRequested)
			{
				return list;
			}
			int num4 = ++num2 * 100 / array.Length;
			HistoryRequestParameters copy2 = copy.Copy;
			copy2.FromTime = interval.From;
			copy2.ToTime = interval.To;
			LoggerManager loggers2 = Core.Instance.Loggers;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(35, 4);
			defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶놛());
			defaultInterpolatedStringHandler.AppendFormatted(P_0.RequestId);
			defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶놗());
			defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭놼());
			defaultInterpolatedStringHandler.AppendFormatted(num2);
			defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶녢());
			defaultInterpolatedStringHandler.AppendFormatted(array.Length);
			defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭놗());
			defaultInterpolatedStringHandler.AppendFormatted(copy2.Interval);
			defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶놩());
			loggers2.Log(defaultInterpolatedStringHandler.ToStringAndClear(), LoggingLevel.Performance);
			IList<IHistoryItem> list2 = connection.HistoryLoadingManager.녴(copy2);
			IHistoryItem historyItem = list2.LastOrDefault();
			if (historyItem != null)
			{
				num3 = historyItem.TicksLeft + copy.Aggregation.GetPeriod.Ticks;
			}
			LoggerManager loggers3 = Core.Instance.Loggers;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(75, 4);
			defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶놛());
			defaultInterpolatedStringHandler.AppendFormatted(P_0.RequestId);
			defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭뇂());
			defaultInterpolatedStringHandler.AppendFormatted(num2);
			defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶녢());
			defaultInterpolatedStringHandler.AppendFormatted(array.Length);
			defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭놩());
			defaultInterpolatedStringHandler.AppendFormatted(list2.Count);
			loggers3.Log(defaultInterpolatedStringHandler.ToStringAndClear(), LoggingLevel.Performance);
			if (cancellationToken.IsCancellationRequested)
			{
				return list;
			}
			num += list2.Count;
			IList<IHistoryItem> list4;
			if (list2.Count <= 0)
			{
				IList<IHistoryItem> list3 = new List<IHistoryItem>();
				list4 = list3;
			}
			else
			{
				list4 = 녶뇎.AggregateHistory(new HistoryHolder(list2, copy, (P_0.Symbol.HistoryMetadata.BuildUncompletedBars && num4 == 100) ? 99 : num4));
			}
			IList<IHistoryItem> list5 = list4;
			if (cancellationToken.IsCancellationRequested)
			{
				return list;
			}
			list.AddRange(list5);
			LoggerManager loggers4 = Core.Instance.Loggers;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(76, 4);
			defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶놛());
			defaultInterpolatedStringHandler.AppendFormatted(P_0.RequestId);
			defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶놗());
			defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭놼());
			defaultInterpolatedStringHandler.AppendFormatted(num2);
			defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶녢());
			defaultInterpolatedStringHandler.AppendFormatted(array.Length);
			defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭녡());
			defaultInterpolatedStringHandler.AppendFormatted(list5.Count);
			defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶놩());
			loggers4.Log(defaultInterpolatedStringHandler.ToStringAndClear(), LoggingLevel.Performance);
			if (P_0.ProgressInfo != null && array.Length > 2)
			{
				P_0.ProgressInfo.Report((float)num4 / 100f);
			}
			LoggerManager loggers5 = Core.Instance.Loggers;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(40, 3);
			defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶놛());
			defaultInterpolatedStringHandler.AppendFormatted(P_0.RequestId);
			defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭뇂());
			defaultInterpolatedStringHandler.AppendFormatted(num2);
			defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶녢());
			defaultInterpolatedStringHandler.AppendFormatted(array.Length);
			defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭녦());
			loggers5.Log(defaultInterpolatedStringHandler.ToStringAndClear(), LoggingLevel.Performance);
			if (!P_0.Symbol.HistoryMetadata.BuildUncompletedBars || num4 != 100)
			{
				continue;
			}
			HistoryAggregation aggregation = copy.Aggregation;
			HistoryAggregationTime 놇뇍 = aggregation as HistoryAggregationTime;
			if (놇뇍 == null)
			{
				if (!(aggregation is HistoryAggregationTickBars historyAggregationTickBars))
				{
					HistoryAggregationTimeStatistics 놇놙 = aggregation as HistoryAggregationTimeStatistics;
					if (놇놙 == null)
					{
						HistoryAggregationVolumeProfile 놇녰 = aggregation as HistoryAggregationVolumeProfile;
						if (놇녰 == null)
						{
							continue;
						}
						HistoryAggregation[] array3 = (from P_0 in (from P_0 in P_0.Symbol.HistoryMetadata.AllowedPeriodsHistoryAggregationTimeStatistics
								where 놇녰.Period.Ticks % P_0.Ticks == 0
								group P_0 by P_0.BasePeriod into P_0
								select P_0.OrderByDescending((Period P_0) => P_0.PeriodMultiplier).Last()).Union(P_0.Symbol.HistoryMetadata.AllowedBasePeriodsHistoryAggregationTimeStatistics.Select((BasePeriod P_0) => new Period(P_0, 1)))
							where P_0.Ticks < 놇녰.Period.Ticks
							orderby P_0.Ticks descending
							select new HistoryAggregationVolumeProfile(P_0)).Union((!P_0.Symbol.HistoryMetadata.AllowedAggregations.Contains(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭놀())) ? ((IEnumerable<HistoryAggregation>)Array.Empty<HistoryAggregation>()) : ((IEnumerable<HistoryAggregation>)new HistoryAggregation[1]
						{
							new HistoryAggregationTick(HistoryType.Last)
						})).ToArray();
						for (int j = 0; j < array3.Length; j++)
						{
							HistoryAggregation historyAggregation = array3[j];
							TimeSpan historyDownloadingStep = P_0.Symbol.GetHistoryDownloadingStep(historyAggregation);
							if (copy.ToTime.Ticks - num3 > historyDownloadingStep.Ticks)
							{
								num3 = copy.ToTime.Ticks - historyDownloadingStep.Ticks;
							}
							HistoryRequestParameters historyRequestParameters = new HistoryRequestParameters(copy)
							{
								FromTime = new DateTime(num3, DateTimeKind.Utc),
								Aggregation = historyAggregation
							};
							IList<IHistoryItem> list6 = connection.HistoryLoadingManager.녴(historyRequestParameters);
							historyItem = list6.LastOrDefault();
							if (historyItem != null && historyAggregation is HistoryAggregationVolumeProfile historyAggregationVolumeProfile)
							{
								num3 = historyItem.TicksLeft + historyAggregationVolumeProfile.Period.Ticks;
							}
							IList<IHistoryItem> collection = 녶뇎.AggregateHistory(new HistoryHolder(list6, historyRequestParameters, (j == array3.Length - 1) ? 100 : 99));
							list.AddRange(collection);
						}
						continue;
					}
					HistoryAggregation[] array4 = (from P_0 in (from P_0 in P_0.Symbol.HistoryMetadata.AllowedPeriodsHistoryAggregationTimeStatistics
							where 놇놙.Period.Ticks % P_0.Ticks == 0
							group P_0 by P_0.BasePeriod into P_0
							select P_0.OrderByDescending((Period P_0) => P_0.PeriodMultiplier).Last()).Union(P_0.Symbol.HistoryMetadata.AllowedBasePeriodsHistoryAggregationTimeStatistics.Select((BasePeriod P_0) => new Period(P_0, 1)))
						where P_0.Ticks < 놇놙.Period.Ticks
						orderby P_0.Ticks descending
						select new HistoryAggregationTimeStatistics(P_0)).Union((!P_0.Symbol.HistoryMetadata.AllowedAggregations.Contains(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭놀())) ? ((IEnumerable<HistoryAggregation>)Array.Empty<HistoryAggregation>()) : ((IEnumerable<HistoryAggregation>)new HistoryAggregation[1]
					{
						new HistoryAggregationTick(HistoryType.Last)
					})).ToArray();
					for (int k = 0; k < array4.Length; k++)
					{
						HistoryAggregation historyAggregation2 = array4[k];
						TimeSpan historyDownloadingStep2 = P_0.Symbol.GetHistoryDownloadingStep(historyAggregation2);
						if (copy.ToTime.Ticks - num3 > historyDownloadingStep2.Ticks)
						{
							num3 = copy.ToTime.Ticks - historyDownloadingStep2.Ticks;
						}
						HistoryRequestParameters historyRequestParameters2 = new HistoryRequestParameters(copy)
						{
							FromTime = new DateTime(num3, DateTimeKind.Utc),
							Aggregation = historyAggregation2
						};
						IList<IHistoryItem> list7 = connection.HistoryLoadingManager.녴(historyRequestParameters2);
						historyItem = list7.LastOrDefault();
						if (historyItem != null && historyAggregation2 is HistoryAggregationTimeStatistics historyAggregationTimeStatistics)
						{
							num3 = historyItem.TicksLeft + historyAggregationTimeStatistics.Period.Ticks;
						}
						IList<IHistoryItem> collection2 = 녶뇎.AggregateHistory(new HistoryHolder(list7, historyRequestParameters2, (k == array4.Length - 1) ? 100 : 99));
						list.AddRange(collection2);
					}
				}
				else
				{
					if (!P_0.Symbol.HistoryMetadata.AllowedAggregations.Contains(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭놀()) || !P_0.Symbol.HistoryMetadata.AllowedHistoryTypesHistoryAggregationTick.Contains(historyAggregationTickBars.HistoryType))
					{
						continue;
					}
					if (list.Any())
					{
						IHistoryItem historyItem2 = list.Last();
						if (historyItem2.TicksRight == 0L)
						{
							list.RemoveAt(list.Count - 1);
							num3 = historyItem2.TicksLeft;
						}
						else
						{
							num3 = historyItem2.TicksRight + 1;
						}
					}
					TimeSpan downloadingStep_Tick = P_0.Symbol.HistoryMetadata.DownloadingStep_Tick;
					if (copy.ToTime.Ticks - num3 > downloadingStep_Tick.Ticks)
					{
						num3 = copy.ToTime.Ticks - downloadingStep_Tick.Ticks;
					}
					HistoryRequestParameters historyRequestParameters3 = new HistoryRequestParameters(copy)
					{
						FromTime = new DateTime(num3, DateTimeKind.Utc),
						Aggregation = new HistoryAggregationTick(historyAggregationTickBars.HistoryType)
					};
					IList<IHistoryItem> history = connection.HistoryLoadingManager.녴(historyRequestParameters3);
					IList<IHistoryItem> collection3 = 녶뇎.AggregateHistory(new HistoryHolder(history, historyRequestParameters3));
					list.AddRange(collection3);
				}
				continue;
			}
			HistoryAggregation[] array5 = (from P_0 in (from P_0 in P_0.Symbol.HistoryMetadata.AllowedPeriodsHistoryAggregationTime
					where 놇뇍.Period.Ticks % P_0.Ticks == 0
					group P_0 by P_0.BasePeriod into P_0
					select P_0.OrderByDescending((Period P_0) => P_0.PeriodMultiplier).Last()).Union(P_0.Symbol.HistoryMetadata.AllowedBasePeriodsHistoryAggregationTime.Select((BasePeriod P_0) => new Period(P_0, 1)))
				where P_0.Ticks < 놇뇍.Period.Ticks
				orderby P_0.Ticks descending
				select new HistoryAggregationTime(P_0, 놇뇍.HistoryType)).Union((!P_0.Symbol.HistoryMetadata.AllowedAggregations.Contains(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭놀())) ? ((IEnumerable<HistoryAggregation>)Array.Empty<HistoryAggregation>()) : ((IEnumerable<HistoryAggregation>)new HistoryAggregation[1]
			{
				new HistoryAggregationTick((놇뇍.HistoryType == HistoryType.Bid || 놇뇍.HistoryType == HistoryType.Ask) ? HistoryType.BidAsk : 놇뇍.HistoryType)
			})).ToArray();
			for (int l = 0; l < array5.Length; l++)
			{
				HistoryAggregation historyAggregation3 = array5[l];
				TimeSpan historyDownloadingStep3 = P_0.Symbol.GetHistoryDownloadingStep(historyAggregation3);
				if (copy.ToTime.Ticks - num3 > historyDownloadingStep3.Ticks)
				{
					num3 = copy.ToTime.Ticks - historyDownloadingStep3.Ticks;
				}
				HistoryRequestParameters historyRequestParameters4 = new HistoryRequestParameters(copy)
				{
					FromTime = new DateTime(num3, DateTimeKind.Utc),
					Aggregation = historyAggregation3,
					HistoryRequestType = HistoryRequestType.BuildUncompleteBarLogic
				};
				IList<IHistoryItem> list8 = connection.HistoryLoadingManager.녴(historyRequestParameters4);
				historyItem = list8.LastOrDefault();
				if (historyItem != null && historyAggregation3 is HistoryAggregationTime historyAggregationTime)
				{
					num3 = historyItem.TicksLeft + historyAggregationTime.Period.Ticks;
				}
				IList<IHistoryItem> collection4 = 녶뇎.AggregateHistory(new HistoryHolder(list8, historyRequestParameters4, (l == array5.Length - 1) ? 100 : 99));
				list.AddRange(collection4);
			}
		}
		LoggerManager loggers6 = Core.Instance.Loggers;
		defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(123, 4);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶놛());
		defaultInterpolatedStringHandler.AppendFormatted(P_0.RequestId);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶놗());
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭놔());
		defaultInterpolatedStringHandler.AppendFormatted((Core.Instance.TimeUtils.DateTimeUtcNow - dateTimeUtcNow).TotalSeconds, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵녗());
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭놾());
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭뇀());
		defaultInterpolatedStringHandler.AppendFormatted(num);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭놽());
		defaultInterpolatedStringHandler.AppendFormatted(list.Count);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶놩());
		loggers6.Log(defaultInterpolatedStringHandler.ToStringAndClear(), LoggingLevel.Performance);
		return list;
	}

	/// <summary>
	/// Gets index by time with counting on search direction
	/// </summary>
	public double GetIndexByTime(long time, SeekOriginHistory origin = SeekOriginHistory.End)
	{
		if (Count == 0)
		{
			return -1.0;
		}
		if (time > this[0, SeekOriginHistory.End].TicksRight)
		{
			return -1.0;
		}
		double num = -1.0;
		int num2 = 0;
		int num3 = Count - 1;
		while (num2 <= num3)
		{
			int num4 = (num2 + num3) / 2;
			if (num3 - num2 < 2)
			{
				num = ((time >= this[num2, SeekOriginHistory.Begin].TicksLeft) ? ((time >= this[num3, SeekOriginHistory.Begin].TicksLeft) ? ((double)num3) : ((double)num2)) : ((double)(--num2)));
				break;
			}
			if (time < this[num4, SeekOriginHistory.Begin].TicksLeft)
			{
				num3 = num4 - 1;
			}
			else
			{
				num2 = num4 + 1;
			}
		}
		if (origin == SeekOriginHistory.End && num != -1.0)
		{
			return (double)(Count - 1) - num;
		}
		return num;
	}

	private void 놴()
	{
		if (녶뇎 != null)
		{
			녶뇎.NewHistoryItem -= 녴;
			녶뇎.HistoryItemUpdated -= 놴;
			녶뇎.Dispose();
			녶뇎 = null;
		}
		녶녢.Clear();
		lock (itemsLocker)
		{
			녶놆.Clear();
		}
	}

	[NotPublished]
	public virtual void Dispose()
	{
		녶놜?.Cancel();
		놎();
		UnSubscribeSymbol();
		놴();
		if (VolumeAnalysisCalculationProgress != null)
		{
			VolumeAnalysisCalculationProgress.AbortLoading();
			VolumeAnalysisCalculationProgress.Dispose();
			VolumeAnalysisCalculationProgress = null;
		}
		Parameters = null;
	}

	protected virtual void SubscribeSymbol()
	{
		if (Symbol != null && 녶뇎 != null)
		{
			switch (녶뇎.GetSubscribeQuoteType)
			{
			case SubscribeQuoteType.Quote:
				Symbol.NewQuote += Symbol_NewQuote;
				break;
			case SubscribeQuoteType.Level2:
				Symbol.NewLevel2 += 녴;
				break;
			case SubscribeQuoteType.Last:
				Symbol.NewLast += Symbol_NewLast;
				break;
			case SubscribeQuoteType.Mark:
				Symbol.NewMark += 녴;
				break;
			}
			Symbol.NewDayBar += 녴;
			녶녗 = true;
		}
	}

	protected virtual void UnSubscribeSymbol()
	{
		if (Symbol != null && 녶뇎 != null)
		{
			switch (녶뇎.GetSubscribeQuoteType)
			{
			case SubscribeQuoteType.Quote:
				Symbol.NewQuote -= Symbol_NewQuote;
				break;
			case SubscribeQuoteType.Level2:
				Symbol.NewLevel2 -= 녴;
				break;
			case SubscribeQuoteType.Last:
				Symbol.NewLast -= Symbol_NewLast;
				break;
			case SubscribeQuoteType.Mark:
				Symbol.NewMark -= 녴;
				break;
			}
			Symbol.NewDayBar -= 녴;
			녶놳 = null;
			녶놺 = null;
			녶녜.Reset();
		}
	}

	protected void Symbol_NewQuote(Symbol symbol, Quote quote)
	{
		if (!녴(quote))
		{
			ProcessQuote(quote);
		}
	}

	protected void Symbol_NewLast(Symbol symbol, Last last)
	{
		if (!녴(last))
		{
			ProcessLast(last);
		}
	}

	private void 녴(Symbol P_0, Mark P_1)
	{
		if (!녴(P_1))
		{
			ProcessMark(P_1);
		}
	}

	private void 녴(Symbol P_0, DayBar P_1)
	{
		if (!녴((MessageQuote)P_1))
		{
			녴(P_1);
		}
	}

	private void 녴(Symbol P_0, Level2Quote P_1, DOMQuote P_2)
	{
		MessageQuote messageQuote = (MessageQuote)(((object)P_1) ?? ((object)P_2));
		if (!녴(messageQuote))
		{
			ProcessLevel2Qute(messageQuote);
		}
	}

	private bool 녴(MessageQuote P_0)
	{
		놂 놂 = default(놂);
		놂.놇놚 = this;
		놂.놇놹 = P_0;
		if (녶놨 != HistoricalDataState.Loading && 녶녢.IsEmpty)
		{
			return false;
		}
		if (녶놳 == null && 녴(ref 놂))
		{
			녶놳 = 놂.놇놹;
			녶녜.Set();
		}
		녶녢.Enqueue(놂.놇놹);
		return true;
	}

	private void 놂()
	{
		DateTime? dateTime = this.LastOrDefault()?.TimeLeft;
		MessageQuote result;
		while (녶녢.TryDequeue(out result))
		{
			if (result == null)
			{
				continue;
			}
			if (dateTime.HasValue)
			{
				DateTime time = result.Time;
				DateTime? dateTime2 = dateTime;
				if (time <= dateTime2)
				{
					continue;
				}
			}
			if (!(result is Quote quote))
			{
				if (!(result is Last last))
				{
					if (result is Mark mark)
					{
						ProcessMark(mark);
					}
				}
				else
				{
					ProcessLast(last);
				}
			}
			else
			{
				ProcessQuote(quote);
			}
		}
	}

	protected virtual void ProcessQuote(Quote quote)
	{
		녶놺 = quote;
		녶뇎?.ProcessQuote(quote);
	}

	protected virtual void ProcessLast(Last last)
	{
		녶놺 = last;
		녶뇎?.ProcessQuote(last);
	}

	protected virtual void ProcessMark(Mark mark)
	{
		녶놺 = mark;
		녶뇎?.ProcessQuote(mark);
	}

	private void 녴(DayBar P_0)
	{
		녶놺 = P_0;
		녶뇎?.ProcessQuote(P_0);
	}

	protected virtual void ProcessLevel2Qute(MessageQuote quote)
	{
		녶놺 = quote;
		녶뇎?.ProcessQuote(quote);
	}

	/// <summary>
	/// Creates indicator by it's name and if it successfully created adds it to the HistoricalData
	/// </summary>
	/// <param name="indicatorName"></param>
	/// <param name="settings"></param>
	/// <returns></returns>
	public Indicator AddIndicator(string indicatorName, params SettingItem[] settings)
	{
		if (string.IsNullOrEmpty(indicatorName))
		{
			throw new ArgumentNullException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴놨());
		}
		Indicator indicator = Core.Instance.Indicators.CreateIndicator(indicatorName, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놇(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놇());
		if (indicator == null)
		{
			throw new InvalidOperationException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭녿());
		}
		indicator.Settings = settings;
		AddIndicator(indicator);
		return indicator;
	}

	/// <summary>
	/// Adds indicator to the HistoricalData
	/// </summary>
	/// <param name="indicator"></param>
	public void AddIndicator(Indicator indicator)
	{
		if (indicator == null)
		{
			throw new ArgumentNullException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭놁());
		}
		lock (녶녯)
		{
			if (녶뇃.Contains(indicator))
			{
				throw new InvalidOperationException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭녭());
			}
			녶뇃.Add(indicator);
			lock (itemsLocker)
			{
				indicator.HistoricalData = this;
				indicator.Init();
				bool flag = Count > 0;
				if (flag)
				{
					LoggerManager loggers = Core.Instance.Loggers;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(39, 3);
					defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭녱());
					defaultInterpolatedStringHandler.AppendFormatted(Symbol);
					defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놀());
					defaultInterpolatedStringHandler.AppendFormatted(indicator.Name);
					defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭놲());
					defaultInterpolatedStringHandler.AppendFormatted(Count);
					defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶놳());
					loggers.Log(defaultInterpolatedStringHandler.ToStringAndClear());
				}
				DateTime dateTimeUtcNow = Core.Instance.TimeUtils.DateTimeUtcNow;
				for (int i = ((indicator.UpdateType != IndicatorUpdateType.OnTick) ? 1 : 0); i < Count; i++)
				{
					indicator.Update(new UpdateArgs(UpdateReason.HistoricalBar));
				}
				if (flag)
				{
					LoggerManager loggers2 = Core.Instance.Loggers;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(50, 3);
					defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭녱());
					defaultInterpolatedStringHandler.AppendFormatted(Symbol);
					defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놀());
					defaultInterpolatedStringHandler.AppendFormatted(indicator.Name);
					defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭높());
					defaultInterpolatedStringHandler.AppendFormatted((Core.Instance.TimeUtils.DateTimeUtcNow - dateTimeUtcNow).TotalSeconds.ToString(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵녗()));
					defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭놶());
					loggers2.Log(defaultInterpolatedStringHandler.ToStringAndClear());
				}
			}
		}
	}

	/// <summary>
	/// Removes indicator from the HistoricalData
	/// </summary>
	/// <param name="indicator"></param>
	public void RemoveIndicator(Indicator indicator)
	{
		if (indicator == null)
		{
			throw new ArgumentNullException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭놁());
		}
		lock (녶녯)
		{
			녶뇃.Remove(indicator);
		}
		indicator.Clear();
	}

	private void 녴(Indicator P_0)
	{
		lock (녶녯)
		{
			lock (itemsLocker)
			{
				P_0.Clear();
				P_0.Init();
				int num = ((P_0.UpdateType == IndicatorUpdateType.OnBarClose) ? (Count - 1) : Count);
				for (int i = 0; i < num; i++)
				{
					P_0.Update(new UpdateArgs(UpdateReason.HistoricalBar));
				}
			}
		}
	}

	void 놎.녴(Indicator P_0)
	{
		//ILSpy generated this explicit interface implementation from .override directive in 녴
		this.녴(P_0);
	}

	private protected void 녴(UpdateArgs P_0, IndicatorUpdateType? P_1 = null)
	{
		lock (녶녯)
		{
			foreach (Indicator item in 녶뇃)
			{
				if (!P_1.HasValue || item.UpdateType == P_1)
				{
					item.Update(P_0.녴());
				}
			}
		}
	}

	private void 놎()
	{
		lock (녶녯)
		{
			foreach (Indicator item in 녶뇃)
			{
				item.Clear();
				item.Dispose();
			}
			녶뇃.Clear();
		}
	}

	public IVolumeAnalysisCalculationProgress CalculateVolumeProfile(VolumeAnalysisCalculationParameters volumeAnalysisCalculationParameters)
	{
		return Core.Instance.VolumeAnalysis.CalculateProfile(this, volumeAnalysisCalculationParameters);
	}

	public IEnumerator GetEnumerator()
	{
		return 녶놆.GetEnumerator();
	}

	private IEnumerator<IHistoryItem> 녞()
	{
		return 녶놆.GetEnumerator();
	}

	IEnumerator<IHistoryItem> IEnumerable<IHistoryItem>.GetEnumerator()
	{
		//ILSpy generated this explicit interface implementation from .override directive in 녞
		return this.녞();
	}

	protected virtual IHistoryProcessor CreateHistoryProcessor()
	{
		return Core.Instance.HistoryAggregations.CreateHistoryProcessor(Parameters);
	}

	private protected virtual void 녴()
	{
		녶뇎 = CreateHistoryProcessor();
		if (녶뇎 == null)
		{
			throw new InvalidOperationException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭뇏());
		}
		녶뇎.CorrectHistoryRequestBorders(Parameters);
		녶뇎.NewHistoryItem += 녴;
		녶뇎.HistoryItemUpdated += 놴;
	}

	private void 녴(object P_0, HistoryEventArgs P_1)
	{
		if (P_1.HistoryItem != null && (!Parameters.ExcludeOutOfSession || Parameters.SessionsContainer == null || Parameters.SessionsContainer.ContainsDate(P_1.HistoryItem.TicksLeft)))
		{
			AddNewItem(P_1.HistoryItem, updateIndicators: true, P_1);
		}
	}

	private void 놴(object P_0, HistoryEventArgs P_1)
	{
		if (P_1.HistoryItem == null || (Parameters.ExcludeOutOfSession && Parameters.SessionsContainer != null && !Parameters.SessionsContainer.ContainsDate(P_1.HistoryItem.TicksLeft)))
		{
			return;
		}
		if (P_1.ResetVolumeAnalysisRequired)
		{
			P_1.HistoryItem.VolumeAnalysisData = null;
		}
		else
		{
			IHistoryItem historyItem = P_1.HistoryItem;
			if (historyItem.VolumeAnalysisData == null)
			{
				VolumeAnalysisData volumeAnalysisData2 = (historyItem.VolumeAnalysisData = this[0, SeekOriginHistory.End]?.VolumeAnalysisData);
			}
		}
		this[0, SeekOriginHistory.End] = P_1.HistoryItem;
		놴(P_1.HistoryItem);
		녴(new UpdateArgs(UpdateReason.NewTick), IndicatorUpdateType.OnTick);
		녴(P_1);
	}

	protected virtual void AddNewItem(IHistoryItem historyItem, bool updateIndicators = true, HistoryEventArgs e = null)
	{
		if (updateIndicators)
		{
			녴(e, IndicatorUpdateType.OnBarClose);
		}
		lock (itemsLocker)
		{
			녶놆.Add(historyItem);
		}
		놴(historyItem);
		if (updateIndicators)
		{
			녴(e, IndicatorUpdateType.OnTick);
		}
		녴(historyItem);
	}

	private protected virtual void 녴(IHistoryItem P_0)
	{
		녶놢.InvokeSafely(this, new HistoryEventArgs
		{
			HistoryItem = P_0
		});
	}

	private void 녴(HistoryEventArgs P_0)
	{
		녶녧?.Invoke(this, P_0);
	}

	private void 놴(IHistoryItem P_0)
	{
		if (녶놅 != 녶놺)
		{
			녶놅 = 녶놺;
			녶녤?.Invoke(this, new 뇏
			{
				HistoryItem = P_0,
				MessageQuote = 녶놺
			});
		}
	}

	private protected virtual void 녴(HistoryEventArgs P_0 = null, IndicatorUpdateType? P_1 = null)
	{
		녴(new UpdateArgs(UpdateReason.NewBar), P_1);
	}

	internal void 놫()
	{
		녶놮?.Invoke();
	}

	[NotPublished]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public void CutItems(int count)
	{
		lock (itemsLocker)
		{
			count = Math.Min(녶놆.Count, Math.Abs(count));
		}
		lock (itemsLocker)
		{
			녶놆.RemoveRange(0, count);
		}
		Parameters.FromTime = ((Count > 0) ? this[0, SeekOriginHistory.Begin].TimeLeft : Core.Instance.TimeUtils.DateTimeUtcNow);
	}

	[NotPublished]
	protected void InsertRange(int index, IList<IHistoryItem> range)
	{
		lock (itemsLocker)
		{
			녶놆.InsertRange(index, range);
		}
		lock (녶녯)
		{
			foreach (Indicator item in 녶뇃)
			{
				item.Refresh();
			}
		}
	}

	public string GetTimeToNextBar()
	{
		return 녶뇎.GetTimeToNextBar();
	}

	[CompilerGenerated]
	private bool 놂(IHistoryItem P_0)
	{
		return Parameters.SessionsContainer.ContainsDate(P_0.TicksLeft);
	}

	[CompilerGenerated]
	private bool 녴(ref 놂 P_0)
	{
		if (녶뇎 == null)
		{
			return false;
		}
		return 녶뇎.GetSubscribeQuoteType switch
		{
			SubscribeQuoteType.Quote => P_0.놇놹 is Quote, 
			SubscribeQuoteType.Level2 => (P_0.놇놹 is Level2Quote || P_0.놇놹 is DOMQuote) ? true : false, 
			SubscribeQuoteType.Last => P_0.놇놹 is Last, 
			SubscribeQuoteType.Mark => P_0.놇놹 is Mark, 
			_ => false, 
		};
	}
}
