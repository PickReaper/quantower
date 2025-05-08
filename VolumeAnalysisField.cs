using System.Reflection;

namespace TradingPlatform.BusinessLayer;

[Published]
[Obfuscation(ApplyToMembers = true, Exclude = true)]
public enum VolumeAnalysisField
{
	Trades,
	BuyTrades,
	SellTrades,
	Volume,
	BuyVolume,
	SellVolume,
	BuySellVolume,
	FilteredVolume,
	FilteredBuyVolume,
	FilteredSellVolume,
	MaxOneTradeVolume,
	BuyVolumePercent,
	SellVolumePercent,
	Delta,
	DeltaPercent,
	CumulativeDelta,
	FilteredTotalVolumePercent,
	FilteredBuyVolumePercent,
	FilteredSellVolumePercent,
	MaxOneTradeVolumePercent,
	AverageSize,
	AverageBuySize,
	AverageSellSize,
	OpenInterest,
	MinDelta,
	MaxDelta,
	DeltaFinish
}
