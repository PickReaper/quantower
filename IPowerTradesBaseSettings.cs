namespace TradingPlatform.BusinessLayer.PowerTrades;

public interface IPowerTradesBaseSettings
{
	double MinTradeVolume { get; }

	double MaxTradeVolume { get; }

	double TotalVolume { get; }

	double TimeInterval { get; }

	double BasisVolumeInterval { get; }

	int MaxZoneHeight { get; }

	int MinZoneHeight { get; }

	double DeltaFilter { get; }

	double BasisRatioFilter { get; }
}
