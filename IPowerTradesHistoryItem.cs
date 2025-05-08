using System;

namespace TradingPlatform.BusinessLayer.PowerTrades;

public interface IPowerTradesHistoryItem : IHistoryItem, ICloneable
{
	double Cumulative { get; }

	double Delta { get; }

	double DeltaPercent { get; }

	double MaxPrice { get; }

	double MinPrice { get; }

	double BasisRatioPercent { get; }

	DateTime LeftTime { get; }

	DateTime RightTime { get; }
}
