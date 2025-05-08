using System;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using TradingPlatform.BusinessLayer.Integration;
using TradingPlatform.BusinessLayer.Utils;

namespace TradingPlatform.BusinessLayer;

public static class SymbolExtensions
{
	public static ISessionsContainer FindSessionsContainer(this Symbol symbol)
	{
		if (symbol == null)
		{
			return null;
		}
		if (Core.Instance.CustomSessions.Assignments.TryGetSessionsContainer(symbol, out var container))
		{
			return container;
		}
		SessionsContainer currentSessionsInfo = symbol.CurrentSessionsInfo;
		if (currentSessionsInfo == null)
		{
			Exchange exchange = symbol.Exchange;
			if (exchange == null)
			{
				return null;
			}
			currentSessionsInfo = exchange.CurrentSessionsInfo;
		}
		return currentSessionsInfo;
	}

	public static TimeSpan GetHistoryDownloadingStep(this Symbol symbol, HistoryAggregation aggregation)
	{
		return symbol?.HistoryMetadata?.녴(aggregation) ?? new TimeSpan(10, 0, 0, 0);
	}

	public static double CalculateValue(this Symbol symbol, Side side, double price, double quantity)
	{
		if (symbol == null || double.IsNaN(price) || double.IsNaN(quantity))
		{
			return double.NaN;
		}
		return (double)((side == Side.Buy) ? 1 : (-1)) * ((symbol.QuotingType == SymbolQuotingType.LotSize) ? (price * symbol.LotSize * quantity) : (price * (symbol.GetTickCost(price) / symbol.GetTickSize(price)) * quantity));
	}

	public static string GetFormattedPoints(this Symbol symbol, Side side, double closePrice, double openPrice)
	{
		double num = symbol.CalculatePoints(side, closePrice, openPrice);
		if (double.IsNaN(num))
		{
			return _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇅();
		}
		int precision = symbol.FindVariableTick(openPrice)?.Precision ?? CoreMath.GetValuePrecision((decimal)symbol.TickSize);
		return num.Format(precision);
	}

	public static string GetFormattedPoints(this Symbol symbol, double points, string suffix = "points")
	{
		if (double.IsNaN(points))
		{
			return _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇅();
		}
		int valuePrecision = CoreMath.GetValuePrecision((decimal)symbol.TickSize);
		return points.Format(valuePrecision) + _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놀() + suffix;
	}

	public static double CalculatePoints(this Symbol symbol, Side side, double closePrice, double openPrice)
	{
		if (double.IsNaN(closePrice) || double.IsNaN(openPrice))
		{
			return double.NaN;
		}
		decimal num = (decimal)closePrice;
		decimal num2 = (decimal)openPrice;
		if (side != 0)
		{
			return (double)(num2 - num);
		}
		return (double)(num - num2);
	}

	public static HistoricalData GetHistory(this Symbol symbol, Period period, HistoryType historyType, int itemsCount)
	{
		TimeSpan timeSpan = TimeSpan.FromDays(36500.0);
		HistoricalData historicalData = null;
		int i = 1;
		long num = period.Ticks * itemsCount;
		num *= 3;
		num = Math.Min(timeSpan.Ticks, num);
		DateTime dateTime = Core.Instance.TimeUtils.DateTimeUtcNow.AddTicks(-num);
		DateTime dateTime2 = Core.Instance.TimeUtils.DateTimeUtcNow.Add(-timeSpan);
		int num2 = -1;
		for (; historicalData == null || (dateTime > dateTime2 && 10 >= i); i++)
		{
			if (period.BasePeriod != 0)
			{
				historicalData = symbol.GetHistory(period, historyType, dateTime);
			}
			else
			{
				long ticks = 녴(symbol.Connection, i);
				historicalData = symbol.GetHistory(period, historyType, new DateTime(ticks, DateTimeKind.Utc));
			}
			if (historicalData.Count > itemsCount || (num2 != -1 && num2 == historicalData.Count && period.BasePeriod == BasePeriod.Day))
			{
				break;
			}
			if (historicalData.Count > 0)
			{
				num *= itemsCount / historicalData.Count + 1;
			}
			if (num >= dateTime.Ticks)
			{
				break;
			}
			dateTime = dateTime.AddTicks(-num);
			num2 = historicalData.Count;
		}
		if (historicalData.Count > itemsCount && itemsCount != 0)
		{
			historicalData.CutItems(historicalData.Count - itemsCount);
		}
		return historicalData;
	}

	public static DeltaCalculationType GetDeltaCalculationTypeForQuotes(this Symbol symbol)
	{
		if (!Core.Instance.SymbolsMapping.TryGetQuotesSymbol(symbol, out var quotesSymbol))
		{
			return symbol.DeltaCalculationType;
		}
		return quotesSymbol.DeltaCalculationType;
	}

	public static DeltaCalculationType GetDeltaCalculationTypeForHistory(this Symbol symbol, Period period)
	{
		if (!Core.Instance.SymbolsMapping.TryGetHistorySymbol(symbol, period, out var historySymbol))
		{
			return symbol.DeltaCalculationType;
		}
		return historySymbol.DeltaCalculationType;
	}

	public static DeltaCalculationType GetDeltaCalculationTypeForVolumeAnalysis(this Symbol symbol)
	{
		if (!Core.Instance.SymbolsMapping.TryGetVolumeAnalysisSymbol(symbol, out var volumeAnalysisSymbol))
		{
			return symbol.DeltaCalculationType;
		}
		return volumeAnalysisSymbol.DeltaCalculationType;
	}

	public static HistoryMetadata GetHistoryMetadata(this Symbol symbol)
	{
		if (!Core.Instance.SymbolsMapping.TryGetVolumeAnalysisSymbol(symbol, out var volumeAnalysisSymbol))
		{
			return symbol.HistoryMetadata;
		}
		return volumeAnalysisSymbol.HistoryMetadata;
	}

	public static bool TryGetTradingSymbolId(this Symbol symbol, out string tradingSymbolId)
	{
		tradingSymbolId = null;
		if (symbol == null)
		{
			return false;
		}
		if (symbol.State == BusinessObjectState.Fake)
		{
			return false;
		}
		if (symbol.AdditionalInfo == null)
		{
			return false;
		}
		if (!symbol.AdditionalInfo.TryGetItem(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂녻(), out var item))
		{
			return false;
		}
		tradingSymbolId = item.Value as string;
		return !string.IsNullOrEmpty(tradingSymbolId);
	}

	public static bool IsSameAs(this Symbol symbol, Symbol otherSymbol)
	{
		if (symbol.Equals(otherSymbol))
		{
			return true;
		}
		if (symbol.TryGetTradingSymbolId(out var tradingSymbolId) && otherSymbol.Id == tradingSymbolId)
		{
			return true;
		}
		if (otherSymbol.TryGetTradingSymbolId(out tradingSymbolId) && symbol.Id == tradingSymbolId)
		{
			return true;
		}
		return false;
	}

	public static Symbol GetTradingSymbol(this Symbol symbol)
	{
		if (!symbol.TryGetTradingSymbolId(out var tradingSymbolId))
		{
			return null;
		}
		return Core.Instance.GetSymbol(new GetSymbolRequestParameters
		{
			SymbolId = tradingSymbolId
		}, symbol.ConnectionId);
	}

	[CompilerGenerated]
	internal static long 녴(Connection P_0, int P_1)
	{
		long ticks = P_0.HistoryMetaData.DownloadingStep_Tick.Ticks;
		ticks = (long)((double)ticks * Math.Pow(2.0, --P_1));
		return Core.Instance.TimeUtils.DateTimeUtcNow.Ticks - ticks;
	}
}
