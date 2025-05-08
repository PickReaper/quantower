namespace TradingPlatform.BusinessLayer;

public interface IVolumeData
{
	double Volume { get; set; }

	double BuyVolume { get; set; }

	double SellVolume { get; set; }

	int Trades { get; set; }

	int BuyTrades { get; set; }

	int SellTrades { get; set; }
}
