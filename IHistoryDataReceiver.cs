namespace TradingPlatform.BusinessLayer;

public interface IHistoryDataReceiver
{
	void SaveHistory(HistoryHolder historyFromProvider);
}
