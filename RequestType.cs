namespace TradingPlatform.BusinessLayer;

public enum RequestType
{
	PlaceOrder,
	ModifyOrder,
	History,
	Symbol,
	SearchSymbol,
	QuoteSubscribe,
	FutureContracts,
	OptionSeries,
	Strikes,
	ClosePosition,
	CancelOrder,
	Custom,
	PnL,
	Report,
	Connect,
	VolumeAnalysis,
	VolumeAnalysisByPeriod,
	PlaceMultiOrderOrder,
	TradesHistory,
	OrdersHistory,
	ConvertPosition,
	TradingSignals
}
