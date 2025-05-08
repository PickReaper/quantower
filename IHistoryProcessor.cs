using System;
using System.Collections.Generic;

namespace TradingPlatform.BusinessLayer;

public interface IHistoryProcessor : IDisposable
{
	SubscribeQuoteType? GetSubscribeQuoteType { get; }

	event HistoryEventHandler NewHistoryItem;

	event HistoryEventHandler HistoryItemUpdated;

	void Initialize(HistoryRequestParameters historyRequestParameters);

	IList<IHistoryItem> AggregateHistory(HistoryHolder historyHolder);

	void ProcessQuote(MessageQuote messageQuote);

	void CorrectHistoryRequestBorders(HistoryRequestParameters historyRequestParameters);

	string GetTimeToNextBar();
}
