using System.Collections.Generic;

namespace TradingPlatform.BusinessLayer;

public static class StrategyMetricExtensions
{
	public static void Add(this List<StrategyMetric> metrics, string name, string formattedValue)
	{
		metrics.Add(new StrategyMetric
		{
			Name = name,
			FormattedValue = formattedValue
		});
	}

	public static void Add(this List<StrategyMetric> metrics, string name, object value)
	{
		metrics.Add(name, value.ToString());
	}
}
