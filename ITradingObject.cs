namespace TradingPlatform.BusinessLayer;

public interface ITradingObject
{
	string Id { get; }

	Account Account { get; }

	Symbol Symbol { get; }

	Side Side { get; }

	string Comment { get; }

	AdditionalInfoCollection AdditionalInfo { get; }
}
