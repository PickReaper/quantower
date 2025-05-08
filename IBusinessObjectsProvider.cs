namespace TradingPlatform.BusinessLayer;

public interface IBusinessObjectsProvider
{
	/// <summary>
	/// Gets <see cref="T:TradingPlatform.BusinessLayer.Symbol" />s list
	/// </summary>
	Symbol[] Symbols { get; }

	/// <summary>
	/// Gets symbol types list
	/// </summary>
	SymbolType[] SymbolTypes { get; }

	/// <summary>
	/// Gets <see cref="T:TradingPlatform.BusinessLayer.Account" />s list
	/// </summary>
	Account[] Accounts { get; }

	/// <summary>
	/// Gets <see cref="T:TradingPlatform.BusinessLayer.Asset" />s list
	/// </summary>
	Asset[] Assets { get; }

	/// <summary>
	/// Gets Exchanges list
	/// </summary>
	Exchange[] Exchanges { get; }

	/// <summary>
	/// Gets Orders list
	/// </summary>
	Order[] Orders { get; }

	/// <summary>
	/// Gets Order Types list
	/// </summary>
	OrderType[] OrderTypes { get; }

	/// <summary>
	/// Gets Positions list
	/// </summary>
	Position[] Positions { get; }

	/// <summary>
	/// Gets Closed Positions list
	/// </summary>
	ClosedPosition[] ClosedPositions { get; }

	/// <summary>
	/// Gets Corporate Actions list
	/// </summary>
	CorporateAction[] CorporateActions { get; }

	/// <summary>
	/// Gets Report Types list
	/// </summary>
	ReportType[] ReportTypes { get; }

	DeliveredAsset[] DeliveredAssets { get; }

	AccountOperation[] AccountOperations { get; }

	/// <summary>
	/// Gets <see cref="T:TradingPlatform.BusinessLayer.TradingSignal" />s list
	/// </summary>
	TradingSignal[] TradingSignals { get; }
}
