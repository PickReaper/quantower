using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;

namespace TradingPlatform.BusinessLayer;

public abstract class HistoryProcessor : IHistoryProcessor, IDisposable
{
	protected long sessionOffset;

	[CompilerGenerated]
	private HistoryEventHandler 녶뇏;

	[CompilerGenerated]
	private HistoryEventHandler 녶녻;

	public virtual SubscribeQuoteType? GetSubscribeQuoteType => null;

	public event HistoryEventHandler NewHistoryItem
	{
		[CompilerGenerated]
		add
		{
			HistoryEventHandler historyEventHandler = 녶뇏;
			HistoryEventHandler historyEventHandler2;
			do
			{
				historyEventHandler2 = historyEventHandler;
				HistoryEventHandler value2 = (HistoryEventHandler)Delegate.Combine(historyEventHandler2, value);
				historyEventHandler = Interlocked.CompareExchange(ref 녶뇏, value2, historyEventHandler2);
			}
			while ((object)historyEventHandler != historyEventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			HistoryEventHandler historyEventHandler = 녶뇏;
			HistoryEventHandler historyEventHandler2;
			do
			{
				historyEventHandler2 = historyEventHandler;
				HistoryEventHandler value2 = (HistoryEventHandler)Delegate.Remove(historyEventHandler2, value);
				historyEventHandler = Interlocked.CompareExchange(ref 녶뇏, value2, historyEventHandler2);
			}
			while ((object)historyEventHandler != historyEventHandler2);
		}
	}

	public event HistoryEventHandler HistoryItemUpdated
	{
		[CompilerGenerated]
		add
		{
			HistoryEventHandler historyEventHandler = 녶녻;
			HistoryEventHandler historyEventHandler2;
			do
			{
				historyEventHandler2 = historyEventHandler;
				HistoryEventHandler value2 = (HistoryEventHandler)Delegate.Combine(historyEventHandler2, value);
				historyEventHandler = Interlocked.CompareExchange(ref 녶녻, value2, historyEventHandler2);
			}
			while ((object)historyEventHandler != historyEventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			HistoryEventHandler historyEventHandler = 녶녻;
			HistoryEventHandler historyEventHandler2;
			do
			{
				historyEventHandler2 = historyEventHandler;
				HistoryEventHandler value2 = (HistoryEventHandler)Delegate.Remove(historyEventHandler2, value);
				historyEventHandler = Interlocked.CompareExchange(ref 녶녻, value2, historyEventHandler2);
			}
			while ((object)historyEventHandler != historyEventHandler2);
		}
	}

	public HistoryProcessor()
	{
	}

	public virtual void Initialize(HistoryRequestParameters historyRequestParameters)
	{
		try
		{
			if (historyRequestParameters?.SessionsContainer != null)
			{
				sessionOffset = -historyRequestParameters.SessionsContainer.GetSessionOpenTime(Core.Instance.TimeUtils.SelectedTimeZone);
			}
		}
		catch (Exception ex)
		{
			Core.Instance.Loggers.Log(ex);
		}
	}

	public virtual IList<IHistoryItem> AggregateHistory(HistoryHolder historyHolder)
	{
		return historyHolder.History;
	}

	public virtual void ProcessQuote(MessageQuote messageQuote)
	{
	}

	public virtual void CorrectHistoryRequestBorders(HistoryRequestParameters historyRequestParameters)
	{
	}

	public virtual string GetTimeToNextBar()
	{
		return null;
	}

	public virtual void Dispose()
	{
	}

	protected void OnNewHistoryItem(HistoryEventArgs e)
	{
		녶뇏?.Invoke(this, e);
	}

	protected void OnHistoryItemUpdated(HistoryEventArgs e)
	{
		녶녻?.Invoke(this, e);
	}

	public static bool IsDayOpeningNow(long barTime, long currentTime, long sessionOffset)
	{
		return (barTime + sessionOffset) / 864000000000L != (currentTime + sessionOffset) / 864000000000L;
	}
}
