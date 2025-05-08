namespace TradingPlatform.BusinessLayer;

public interface IVolumeTickData
{
	VolumeTickDataType VolumeTickDataType { get; }

	long Time { get; }

	double Price { get; }

	double Volume { get; }

	TickDirection TickDirection { get; }

	AggressorFlag AggressorFlag { get; }
}
