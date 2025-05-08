using System;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;

namespace TradingPlatform.BusinessLayer;

public sealed class HistoricalDataCustom : HistoricalData
{
	private Indicator 놇놐;

	public double this[PriceType priceType, int offset = 0]
	{
		get
		{
			IHistoryItem historyItem = this[offset, SeekOriginHistory.End];
			switch (priceType)
			{
			case PriceType.Open:
				return historyItem[PriceType.Open];
			case PriceType.High:
				return historyItem[PriceType.High];
			case PriceType.Low:
				return historyItem[PriceType.Low];
			case PriceType.Close:
				return historyItem[PriceType.Close];
			default:
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(8, 1);
				defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿녦());
				defaultInterpolatedStringHandler.AppendFormatted(priceType);
				throw new InvalidOperationException(defaultInterpolatedStringHandler.ToStringAndClear());
			}
			}
		}
		set
		{
			IHistoryItem historyItem = this[offset, SeekOriginHistory.End];
			switch (priceType)
			{
			case PriceType.Open:
				SetValue(value, historyItem[PriceType.High], historyItem[PriceType.Low], historyItem[PriceType.Close], offset);
				return;
			case PriceType.High:
				SetValue(historyItem[PriceType.Open], value, historyItem[PriceType.Low], historyItem[PriceType.Close], offset);
				return;
			case PriceType.Low:
				SetValue(historyItem[PriceType.Open], historyItem[PriceType.High], value, historyItem[PriceType.Close], offset);
				return;
			case PriceType.Close:
				SetValue(historyItem[PriceType.Open], historyItem[PriceType.High], historyItem[PriceType.Low], value, offset);
				return;
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(8, 1);
			defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿녦());
			defaultInterpolatedStringHandler.AppendFormatted(priceType);
			throw new InvalidOperationException(defaultInterpolatedStringHandler.ToStringAndClear());
		}
	}

	public HistoricalDataCustom(Indicator indicator = null)
	{
		Parameters = new HistoryRequestParameters();
		if (indicator != null)
		{
			놇놐 = indicator;
			Parameters.Symbol = indicator.HistoricalData.Symbol;
			Parameters.Aggregation = indicator.HistoricalData.Aggregation.Clone() as HistoryAggregation;
			indicator.녴(this);
		}
		else
		{
			Parameters.Aggregation = new HistoryAggregationTime(Period.MIN1, HistoryType.Bid);
		}
	}

	public void AddValue(double open, double high, double low, double close)
	{
		if (놇놐 != null)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(153, 4);
			defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놀());
			defaultInterpolatedStringHandler.AppendFormatted(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놔());
			defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놾());
			defaultInterpolatedStringHandler.AppendFormatted(놇놐.ShortName);
			defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿뇀());
			defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놽());
			defaultInterpolatedStringHandler.AppendFormatted(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿녿());
			defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놁());
			defaultInterpolatedStringHandler.AppendFormatted(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놔());
			defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿녭());
			throw new InvalidOperationException(defaultInterpolatedStringHandler.ToStringAndClear());
		}
		AddNewItem(new HistoryItemCustom(open, high, low, close));
	}

	public void SetValue(double open, double high, double low, double close, int offset = 0)
	{
		if (!(this[offset, SeekOriginHistory.End] is HistoryItemCustom historyItemCustom))
		{
			throw new IndexOutOfRangeException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿녱());
		}
		if (녶뇃.Count > 0)
		{
			while (Count - 녶뇃[0].Count > 1)
			{
				녴(new UpdateArgs(UpdateReason.NewBar), null);
			}
		}
		bool isEmpty = historyItemCustom.IsEmpty;
		historyItemCustom.Open = open;
		historyItemCustom.High = high;
		historyItemCustom.Low = low;
		historyItemCustom.Close = close;
		historyItemCustom.IsEmpty = false;
		if (offset == 0)
		{
			녴(new UpdateArgs(isEmpty ? UpdateReason.NewBar : UpdateReason.NewTick), null);
		}
	}

	internal void 놴()
	{
		AddNewItem(new HistoryItemCustom(double.NaN, double.NaN, double.NaN, double.NaN)
		{
			IsEmpty = true
		}, updateIndicators: false);
	}

	private protected override void 녴(IHistoryItem P_0)
	{
		HistoryItemCustom obj = P_0 as HistoryItemCustom;
		if (obj != null && !obj.IsEmpty)
		{
			base.녴(P_0);
		}
	}

	private protected override void 녴(HistoryEventArgs P_0 = null, IndicatorUpdateType? P_1 = null)
	{
		if (Count != 0 && !(base[0, SeekOriginHistory.End] as HistoryItemCustom).IsEmpty)
		{
			녴(new UpdateArgs(UpdateReason.NewBar), P_1);
		}
	}

	public override void Dispose()
	{
		base.Dispose();
		놇놐 = null;
	}

	internal HistoricalDataCustom(HistoryRequestParameters P_0)
		: base(P_0)
	{
	}

	private protected override void 녴()
	{
	}

	protected override void SubscribeSymbol()
	{
	}

	protected override void UnSubscribeSymbol()
	{
	}
}
