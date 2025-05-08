namespace TradingPlatform.BusinessLayer;

/// <summary>
/// Moving average mode
/// </summary>
[Published]
public enum MaMode
{
	/// <summary>
	/// Simple Moving Average
	/// </summary>
	SMA,
	/// <summary>
	/// Exponential Moving Average
	/// </summary>
	EMA,
	/// <summary>
	/// Smoothed Moving Average
	/// </summary>
	SMMA,
	/// <summary>
	/// Linearly Weighted Moving Average
	/// </summary>
	LWMA
}
