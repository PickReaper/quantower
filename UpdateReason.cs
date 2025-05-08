namespace TradingPlatform.BusinessLayer;

/// <summary>
/// Specifies the reason of price data updating.
/// </summary>
public enum UpdateReason
{
	Unknown,
	/// <summary>
	/// Indicates the processing of new historical bar.
	/// </summary>
	HistoricalBar,
	/// <summary>
	/// Indicates the coming of new real-time tick.
	/// </summary>
	NewTick,
	/// <summary>
	/// Indicates a start of new real-time bar.
	/// </summary>
	NewBar
}
