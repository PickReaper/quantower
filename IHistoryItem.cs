using System;

namespace TradingPlatform.BusinessLayer;

public interface IHistoryItem : ICloneable
{
	DateTime TimeLeft { get; }

	long TicksLeft { get; set; }

	long TicksRight { get; set; }

	double this[PriceType priceType] { get; }

	VolumeAnalysisData VolumeAnalysisData { get; set; }

	void SetData(string key, object value);

	bool TryGetData<TData>(string key, out TData data);
}
