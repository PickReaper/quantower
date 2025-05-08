namespace TradingPlatform.BusinessLayer;

/// <summary>
/// Specifies the type of events when indicator should recalculate itself.
/// </summary>
public enum IndicatorUpdateType
{
	OnTick,
	OnBarClose
}
