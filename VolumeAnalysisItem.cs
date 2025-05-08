using System;
using System.Runtime.CompilerServices;

namespace TradingPlatform.BusinessLayer;

/// <summary>
/// Represent item with Volume Analysis calculation results
/// </summary>
[Published]
public class VolumeAnalysisItem : IVolumeAnalysisItem
{
	private const double 녲녨 = double.MaxValue;

	private const double 녲녺 = double.MinValue;

	[CompilerGenerated]
	private int 녲놣;

	[CompilerGenerated]
	private int 녲녮;

	[CompilerGenerated]
	private int 녲뇆;

	[CompilerGenerated]
	private double 녲뇉;

	[CompilerGenerated]
	private double 녲뇍;

	[CompilerGenerated]
	private double 녲놙;

	[CompilerGenerated]
	private double 녲녰;

	[CompilerGenerated]
	private double 녲놚;

	[CompilerGenerated]
	private double 녲놹;

	[CompilerGenerated]
	private double 녲놘;

	[CompilerGenerated]
	private double 녲뇌;

	[CompilerGenerated]
	private double 녲녷;

	internal double 녲녟;

	public int Trades
	{
		[CompilerGenerated]
		get
		{
			return 녲놣;
		}
		[CompilerGenerated]
		set
		{
			녲놣 = value;
		}
	}

	public int BuyTrades
	{
		[CompilerGenerated]
		get
		{
			return 녲녮;
		}
		[CompilerGenerated]
		set
		{
			녲녮 = value;
		}
	}

	public int SellTrades
	{
		[CompilerGenerated]
		get
		{
			return 녲뇆;
		}
		[CompilerGenerated]
		set
		{
			녲뇆 = value;
		}
	}

	public double Volume
	{
		[CompilerGenerated]
		get
		{
			return 녲뇉;
		}
		[CompilerGenerated]
		set
		{
			녲뇉 = value;
		}
	}

	public double BuyVolume
	{
		[CompilerGenerated]
		get
		{
			return 녲뇍;
		}
		[CompilerGenerated]
		set
		{
			녲뇍 = value;
		}
	}

	public double SellVolume
	{
		[CompilerGenerated]
		get
		{
			return 녲놙;
		}
		[CompilerGenerated]
		set
		{
			녲놙 = value;
		}
	}

	public double FilteredTotalVolume
	{
		[CompilerGenerated]
		get
		{
			return 녲녰;
		}
		[CompilerGenerated]
		private set
		{
			녲녰 = value;
		}
	}

	public double FilteredBuyVolume
	{
		[CompilerGenerated]
		get
		{
			return 녲놚;
		}
		[CompilerGenerated]
		private set
		{
			녲놚 = value;
		}
	}

	public double FilteredSellVolume
	{
		[CompilerGenerated]
		get
		{
			return 녲놹;
		}
		[CompilerGenerated]
		private set
		{
			녲놹 = value;
		}
	}

	public double MaxOneTradeVolume
	{
		[CompilerGenerated]
		get
		{
			return 녲놘;
		}
		[CompilerGenerated]
		set
		{
			녲놘 = value;
		}
	}

	public double MinDelta
	{
		[CompilerGenerated]
		get
		{
			return 녲뇌;
		}
		[CompilerGenerated]
		set
		{
			녲뇌 = value;
		}
	}

	public double MaxDelta
	{
		[CompilerGenerated]
		get
		{
			return 녲녷;
		}
		[CompilerGenerated]
		set
		{
			녲녷 = value;
		}
	}

	public double BuyVolumePercent
	{
		get
		{
			if (!(Volume > 0.0))
			{
				return 0.0;
			}
			return BuyVolume / Volume * 100.0;
		}
	}

	public double SellVolumePercent
	{
		get
		{
			if (!(Volume > 0.0))
			{
				return 0.0;
			}
			return SellVolume / Volume * 100.0;
		}
	}

	public double Delta => BuyVolume - SellVolume;

	public double DeltaPercent
	{
		get
		{
			if (Volume == 0.0)
			{
				return 0.0;
			}
			return Delta / Volume * 100.0;
		}
	}

	public double CumulativeDelta => 녲녟 + Delta;

	public double FilteredTotalVolumePercent
	{
		get
		{
			if (!(Volume > 0.0))
			{
				return 0.0;
			}
			return FilteredTotalVolume / Volume * 100.0;
		}
	}

	public double FilteredBuyVolumePercent
	{
		get
		{
			if (!(Volume > 0.0))
			{
				return 0.0;
			}
			return FilteredBuyVolume / Volume * 100.0;
		}
	}

	public double FilteredSellVolumePercent
	{
		get
		{
			if (!(Volume > 0.0))
			{
				return 0.0;
			}
			return FilteredSellVolume / Volume * 100.0;
		}
	}

	public double MaxOneTradeVolumePercent
	{
		get
		{
			if (!(Volume > 0.0))
			{
				return 0.0;
			}
			return MaxOneTradeVolume / Volume * 100.0;
		}
	}

	public double AverageSize
	{
		get
		{
			if (Trades <= 0)
			{
				return 0.0;
			}
			return Volume / (double)Trades;
		}
	}

	public double AverageBuySize
	{
		get
		{
			if (BuyTrades <= 0)
			{
				return 0.0;
			}
			return BuyVolume / (double)BuyTrades;
		}
	}

	public double AverageSellSize
	{
		get
		{
			if (SellTrades <= 0)
			{
				return 0.0;
			}
			return SellVolume / (double)SellTrades;
		}
	}

	public double DeltaFinish => Delta - ((Math.Abs(MinDelta) > Math.Abs(MaxDelta)) ? MinDelta : MaxDelta);

	public VolumeAnalysisItem()
	{
		MinDelta = double.MaxValue;
		MaxDelta = double.MinValue;
	}

	internal VolumeAnalysisItem(VolumeAnalysisItem P_0)
	{
		Trades = P_0.Trades;
		BuyTrades = P_0.BuyTrades;
		SellTrades = P_0.SellTrades;
		Volume = P_0.Volume;
		BuyVolume = P_0.BuyVolume;
		SellVolume = P_0.SellVolume;
		FilteredTotalVolume = P_0.FilteredTotalVolume;
		FilteredBuyVolume = P_0.FilteredBuyVolume;
		FilteredSellVolume = P_0.FilteredSellVolume;
		MaxOneTradeVolume = P_0.MaxOneTradeVolume;
		MinDelta = P_0.MinDelta;
		MaxDelta = P_0.MaxDelta;
		녲녟 = P_0.녲녟;
	}

	public double GetValue(VolumeAnalysisField field)
	{
		return field switch
		{
			VolumeAnalysisField.Trades => Trades, 
			VolumeAnalysisField.BuyTrades => BuyTrades, 
			VolumeAnalysisField.SellTrades => SellTrades, 
			VolumeAnalysisField.Volume => Volume, 
			VolumeAnalysisField.BuySellVolume => Volume, 
			VolumeAnalysisField.BuyVolume => BuyVolume, 
			VolumeAnalysisField.BuyVolumePercent => BuyVolumePercent, 
			VolumeAnalysisField.SellVolume => SellVolume, 
			VolumeAnalysisField.SellVolumePercent => SellVolumePercent, 
			VolumeAnalysisField.Delta => Delta, 
			VolumeAnalysisField.DeltaPercent => DeltaPercent, 
			VolumeAnalysisField.CumulativeDelta => CumulativeDelta, 
			VolumeAnalysisField.AverageSize => AverageSize, 
			VolumeAnalysisField.AverageBuySize => AverageBuySize, 
			VolumeAnalysisField.AverageSellSize => AverageSellSize, 
			VolumeAnalysisField.MaxOneTradeVolume => MaxOneTradeVolume, 
			VolumeAnalysisField.MaxOneTradeVolumePercent => MaxOneTradeVolumePercent, 
			VolumeAnalysisField.FilteredVolume => FilteredTotalVolume, 
			VolumeAnalysisField.FilteredTotalVolumePercent => FilteredTotalVolumePercent, 
			VolumeAnalysisField.FilteredBuyVolume => FilteredBuyVolume, 
			VolumeAnalysisField.FilteredBuyVolumePercent => FilteredBuyVolumePercent, 
			VolumeAnalysisField.FilteredSellVolume => FilteredSellVolume, 
			VolumeAnalysisField.FilteredSellVolumePercent => FilteredSellVolumePercent, 
			VolumeAnalysisField.MinDelta => (MinDelta != double.MaxValue) ? MinDelta : 0.0, 
			VolumeAnalysisField.MaxDelta => (MaxDelta != double.MinValue) ? MaxDelta : 0.0, 
			VolumeAnalysisField.DeltaFinish => DeltaFinish, 
			_ => 0.0, 
		};
	}

	public void Combine(VolumeAnalysisItem item)
	{
		Trades += item.Trades;
		BuyTrades += item.BuyTrades;
		SellTrades += item.SellTrades;
		Volume += item.Volume;
		BuyVolume += item.BuyVolume;
		SellVolume += item.SellVolume;
		FilteredTotalVolume += item.FilteredTotalVolume;
		FilteredBuyVolume += item.FilteredBuyVolume;
		FilteredSellVolume += item.FilteredSellVolume;
		MaxOneTradeVolume = Math.Max(item.MaxOneTradeVolume, MaxOneTradeVolume);
		MinDelta = ((MinDelta == double.MaxValue) ? Math.Min(MinDelta, item.MinDelta) : double.NaN);
		MaxDelta = ((MaxDelta == double.MinValue) ? Math.Max(MaxDelta, item.MaxDelta) : double.NaN);
	}

	internal void 녴(double P_0, AggressorFlag P_1 = AggressorFlag.None, bool P_2 = false, double P_3 = 0.0)
	{
		Volume += P_0;
		BuyVolume += ((P_1 == AggressorFlag.Buy) ? P_0 : 0.0);
		SellVolume += ((P_1 == AggressorFlag.Sell) ? P_0 : 0.0);
		double delta = Delta;
		MinDelta = Math.Min(MinDelta, delta);
		MaxDelta = Math.Max(MaxDelta, delta);
		if (P_2)
		{
			return;
		}
		Trades++;
		if (P_0 > MaxOneTradeVolume)
		{
			MaxOneTradeVolume = P_0;
		}
		if (P_0 >= P_3)
		{
			FilteredTotalVolume += P_0;
		}
		switch (P_1)
		{
		case AggressorFlag.Buy:
			BuyTrades++;
			if (P_0 >= P_3)
			{
				FilteredBuyVolume += P_0;
			}
			break;
		case AggressorFlag.Sell:
			SellTrades++;
			if (P_0 >= P_3)
			{
				FilteredSellVolume += P_0;
			}
			break;
		}
	}
}
