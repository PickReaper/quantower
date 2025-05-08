namespace TradingPlatform.BusinessLayer;

public static class StrategyExtensions
{
	/// <summary>
	/// Write info log message
	/// </summary>
	public static void LogInfo(this Strategy strategy, string message)
	{
		strategy.Log(message);
	}

	/// <summary>
	/// Write trading log message
	/// </summary>
	public static void LogTrading(this Strategy strategy, string message)
	{
		strategy.Log(message, StrategyLoggingLevel.Trading);
	}

	/// <summary>
	/// Write error log message
	/// </summary>
	public static void LogError(this Strategy strategy, string message)
	{
		strategy.Log(message, StrategyLoggingLevel.Error);
	}
}
