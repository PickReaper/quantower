using System;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using ProtoBuf;

namespace TradingPlatform.BusinessLayer;

/// <summary>
/// Represents historical data bar item
/// </summary>
[Published]
[ProtoContract]
public class HistoryItemBar : HistoryItem
{
	[CompilerGenerated]
	private long 놇놘;

	[CompilerGenerated]
	private double 놇뇌;

	[CompilerGenerated]
	private double 놇녷;

	[CompilerGenerated]
	private double 놇녟;

	[CompilerGenerated]
	private double 놇놱;

	[CompilerGenerated]
	private long 놇놖;

	[CompilerGenerated]
	private double 놇놝;

	[CompilerGenerated]
	private double 놇뇄;

	[CompilerGenerated]
	private double 놇녑;

	[CompilerGenerated]
	private double 놇놈;

	/// <summary>
	/// Gets bar's right time border
	/// </summary>
	public DateTime TimeRight => new DateTime(TicksRight, DateTimeKind.Utc);

	/// <summary>
	/// Defines bar's ticks count
	/// </summary>
	public override long TicksRight
	{
		[CompilerGenerated]
		get
		{
			return 놇놘;
		}
		[CompilerGenerated]
		set
		{
			놇놘 = value;
		}
	}

	/// <summary>
	/// Defines Open price
	/// </summary>
	[ProtoMember(1)]
	public double Open
	{
		[CompilerGenerated]
		get
		{
			return 놇뇌;
		}
		[CompilerGenerated]
		set
		{
			놇뇌 = value;
		}
	}

	/// <summary>
	/// Defines High price
	/// </summary>
	[ProtoMember(2)]
	public double High
	{
		[CompilerGenerated]
		get
		{
			return 놇녷;
		}
		[CompilerGenerated]
		set
		{
			놇녷 = value;
		}
	}

	/// <summary>
	/// Defines Low price
	/// </summary>
	[ProtoMember(3)]
	public double Low
	{
		[CompilerGenerated]
		get
		{
			return 놇녟;
		}
		[CompilerGenerated]
		set
		{
			놇녟 = value;
		}
	}

	/// <summary>
	/// Defines Close price
	/// </summary>
	[ProtoMember(4)]
	public double Close
	{
		[CompilerGenerated]
		get
		{
			return 놇놱;
		}
		[CompilerGenerated]
		set
		{
			놇놱 = value;
		}
	}

	/// <summary>
	/// Gets Median (High+Low)/2 price
	/// </summary>
	public double Median => (High + Low) / 2.0;

	/// <summary>
	/// Gets Typical (High+Low+Close)/3  price
	/// </summary>
	public double Typical => (High + Low + Close) / 3.0;

	/// <summary>
	/// Gets Weighted (High+Low+Close+Close)/4  price
	/// </summary>
	public double Weighted => (High + Low + Close + Close) / 4.0;

	/// <summary>
	/// Defines ticks amount
	/// </summary>
	[ProtoMember(5)]
	public long Ticks
	{
		[CompilerGenerated]
		get
		{
			return 놇놖;
		}
		[CompilerGenerated]
		set
		{
			놇놖 = value;
		}
	}

	/// <summary>
	/// Defines volume value
	/// </summary>
	[ProtoMember(6)]
	public double Volume
	{
		[CompilerGenerated]
		get
		{
			return 놇놝;
		}
		[CompilerGenerated]
		set
		{
			놇놝 = value;
		}
	}

	[ProtoMember(7)]
	public double OpenInterest
	{
		[CompilerGenerated]
		get
		{
			return 놇뇄;
		}
		[CompilerGenerated]
		set
		{
			놇뇄 = value;
		}
	}

	[ProtoMember(8)]
	public double FundingRate
	{
		[CompilerGenerated]
		get
		{
			return 놇녑;
		}
		[CompilerGenerated]
		set
		{
			놇녑 = value;
		}
	}

	[ProtoMember(9)]
	public double QuoteAssetVolume
	{
		[CompilerGenerated]
		get
		{
			return 놇놈;
		}
		[CompilerGenerated]
		set
		{
			놇놈 = value;
		}
	}

	/// <summary>
	/// Gets price by indexing <see cref="T:TradingPlatform.BusinessLayer.PriceType" />
	/// </summary>
	/// <param name="priceType"></param>
	/// <returns></returns>
	public override double this[PriceType priceType] => priceType switch
	{
		PriceType.Open => Open, 
		PriceType.High => High, 
		PriceType.Low => Low, 
		PriceType.Close => Close, 
		PriceType.Median => Median, 
		PriceType.Typical => Typical, 
		PriceType.Weighted => Weighted, 
		PriceType.Ticks => Ticks, 
		PriceType.Volume => Volume, 
		PriceType.OpenInterest => OpenInterest, 
		PriceType.FundingRate => FundingRate, 
		PriceType.QuoteAssetVolume => QuoteAssetVolume, 
		_ => base[priceType], 
	};

	/// <summary>
	/// Creates HistoryItemBar instance with default OHLC price = <see cref="F:TradingPlatform.BusinessLayer.Utils.Const.DOUBLE_UNDEFINED" />
	/// </summary>
	public HistoryItemBar()
	{
		Open = double.NaN;
		High = double.NaN;
		Low = double.NaN;
		Close = double.NaN;
	}

	/// <summary>
	/// Comparing by <see cref="P:TradingPlatform.BusinessLayer.HistoryItem.TicksLeft" />, OHLC, <see cref="P:TradingPlatform.BusinessLayer.HistoryItemBar.Volume" />
	/// </summary>
	/// <param name="obj"></param>
	/// <returns></returns>
	[NotPublished]
	public override bool Equals(object obj)
	{
		HistoryItemBar historyItemBar = obj as HistoryItemBar;
		if (historyItemBar == null)
		{
			return false;
		}
		if (base.TicksLeft == historyItemBar.TicksLeft && Open == historyItemBar.Open && High == historyItemBar.High && Low == historyItemBar.Low && Close == historyItemBar.Close && Ticks == historyItemBar.Ticks && Volume == historyItemBar.Volume)
		{
			return QuoteAssetVolume == historyItemBar.QuoteAssetVolume;
		}
		return false;
	}

	[NotPublished]
	public override int GetHashCode()
	{
		return base.TicksLeft.GetHashCode() ^ Open.GetHashCode() ^ High.GetHashCode() ^ Low.GetHashCode() ^ Close.GetHashCode() ^ Ticks.GetHashCode() ^ Volume.GetHashCode() ^ QuoteAssetVolume.GetHashCode();
	}

	[NotPublished]
	public static bool operator ==(HistoryItemBar a, HistoryItemBar b)
	{
		if ((object)a == b)
		{
			return true;
		}
		if ((object)a == null || (object)b == null)
		{
			return false;
		}
		return a.Equals(b);
	}

	[NotPublished]
	public static bool operator !=(HistoryItemBar a, HistoryItemBar b)
	{
		return !(a == b);
	}

	[NotPublished]
	public override string ToString()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(39, 10);
		defaultInterpolatedStringHandler.AppendFormatted(base.TicksLeft);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴뇎());
		defaultInterpolatedStringHandler.AppendFormatted(TicksRight);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놲());
		defaultInterpolatedStringHandler.AppendFormatted(Ticks);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿높());
		defaultInterpolatedStringHandler.AppendFormatted(base.TimeLeft);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴뇎());
		defaultInterpolatedStringHandler.AppendFormatted(TimeRight);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놶());
		defaultInterpolatedStringHandler.AppendFormatted(Open);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿뇏());
		defaultInterpolatedStringHandler.AppendFormatted(High);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿녻());
		defaultInterpolatedStringHandler.AppendFormatted(Low);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿녙());
		defaultInterpolatedStringHandler.AppendFormatted(Close);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놀());
		defaultInterpolatedStringHandler.AppendFormatted((Close > Open) ? _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿녧() : _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놢());
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	private HistoryItemBar(HistoryItemBar P_0)
		: base(P_0)
	{
		TicksRight = P_0.TicksRight;
		Open = P_0.Open;
		High = P_0.High;
		Low = P_0.Low;
		Close = P_0.Close;
		Ticks = P_0.Ticks;
		Volume = P_0.Volume;
		OpenInterest = P_0.OpenInterest;
		FundingRate = P_0.FundingRate;
		QuoteAssetVolume = P_0.QuoteAssetVolume;
		base.VolumeAnalysisData = P_0.VolumeAnalysisData;
	}

	[NotPublished]
	public override object Clone()
	{
		return new HistoryItemBar(this);
	}
}
