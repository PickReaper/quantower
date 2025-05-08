using System;

namespace TradingPlatform.BusinessLayer;

public interface IRangeWatchlistIndicator : IWatchlistIndicator
{
	TimeSpan MinHistoryRange { get; }
}
