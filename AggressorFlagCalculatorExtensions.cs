using TradingPlatform.BusinessLayer.Utils;

namespace TradingPlatform.BusinessLayer;

/// <summary>
/// The aggressor flag calculator extensions.
/// </summary>
public static class AggressorFlagCalculatorExtensions
{
	/// <summary>
	/// Collect bid ask.
	/// </summary>
	/// <param name="calculator">The calculator.</param>
	/// <param name="quote">The quote.</param>
	public static void CollectBidAsk(this IAggressorFlagCalculator calculator, Quote quote)
	{
		calculator.CollectBidAsk(quote.SymbolId, quote.Time.Ticks, quote.Bid, quote.Ask);
	}

	/// <summary>
	/// Calculate aggressor flag.
	/// </summary>
	/// <param name="calculator">The calculator.</param>
	/// <param name="last">The last.</param>
	/// <returns>An AggressorFlag.</returns>
	public static AggressorFlag CalculateAggressorFlag(this IAggressorFlagCalculator calculator, Last last)
	{
		return calculator.CalculateAggressorFlag(last.SymbolId, last.Time.Ticks, last.Price);
	}
}
