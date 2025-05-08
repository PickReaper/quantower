namespace TradingPlatform.BusinessLayer;

public interface ISyntheticSynhroniserItem
{
	SyntheticItem SyntheticItem { get; set; }

	HistoricalData HistoricalData { get; set; }

	int Position { get; }

	long NextPositionTime { get; }

	void Move();
}
