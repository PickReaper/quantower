using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using ProtoBuf;

namespace TradingPlatform.BusinessLayer;

/// <summary>
/// Represents historical data trade item
/// </summary>
[Published]
[ProtoContract]
[DataContract]
public sealed class HistoryItemLast : HistoryItem, IVolumeTickData, IBuyerSellerData
{
	[CompilerGenerated]
	private double 놇놪;

	[CompilerGenerated]
	private double 놇놌;

	[CompilerGenerated]
	private AggressorFlag 놇놕;

	[CompilerGenerated]
	private TickDirection 놇뇊;

	[CompilerGenerated]
	private double 놇놋;

	[CompilerGenerated]
	private string 놇녣;

	[CompilerGenerated]
	private string 놇녩;

	[CompilerGenerated]
	private double 놇놤;

	[CompilerGenerated]
	private double 놇논;

	/// <summary>
	/// Defines price value
	/// </summary>
	[ProtoMember(1)]
	[DataMember(Order = 2)]
	public double Price
	{
		[CompilerGenerated]
		get
		{
			return 놇놪;
		}
		[CompilerGenerated]
		set
		{
			놇놪 = value;
		}
	}

	/// <summary>
	/// Defines volume value
	/// </summary>
	[ProtoMember(2)]
	[DataMember(Order = 3)]
	public double Volume
	{
		[CompilerGenerated]
		get
		{
			return 놇놌;
		}
		[CompilerGenerated]
		set
		{
			놇놌 = value;
		}
	}

	/// <summary>
	/// Defines trade operation side as aggressor flag
	/// </summary>
	[ProtoMember(3)]
	[DataMember(Order = 4)]
	public AggressorFlag AggressorFlag
	{
		[CompilerGenerated]
		get
		{
			return 놇놕;
		}
		[CompilerGenerated]
		set
		{
			놇놕 = value;
		}
	}

	[ProtoMember(4)]
	[DataMember(Order = 5)]
	public TickDirection TickDirection
	{
		[CompilerGenerated]
		get
		{
			return 놇뇊;
		}
		[CompilerGenerated]
		set
		{
			놇뇊 = value;
		}
	}

	[ProtoMember(5)]
	[DataMember(Order = 6)]
	public double OpenInterest
	{
		[CompilerGenerated]
		get
		{
			return 놇놋;
		}
		[CompilerGenerated]
		set
		{
			놇놋 = value;
		}
	}

	[ProtoMember(6)]
	[DataMember(Order = 7)]
	public string Buyer
	{
		[CompilerGenerated]
		get
		{
			return 놇녣;
		}
		[CompilerGenerated]
		set
		{
			놇녣 = value;
		}
	}

	[ProtoMember(7)]
	[DataMember(Order = 8)]
	public string Seller
	{
		[CompilerGenerated]
		get
		{
			return 놇녩;
		}
		[CompilerGenerated]
		set
		{
			놇녩 = value;
		}
	}

	[ProtoMember(8)]
	[DataMember(Order = 9)]
	public double FundingRate
	{
		[CompilerGenerated]
		get
		{
			return 놇놤;
		}
		[CompilerGenerated]
		set
		{
			놇놤 = value;
		}
	}

	[ProtoMember(9)]
	[DataMember(Order = 10)]
	public double QuoteAssetVolume
	{
		[CompilerGenerated]
		get
		{
			return 놇논;
		}
		[CompilerGenerated]
		set
		{
			놇논 = value;
		}
	}

	/// <summary>
	/// Gets price by indexing <see cref="T:TradingPlatform.BusinessLayer.PriceType" />
	/// </summary>
	/// <param name="priceType"></param>
	/// <returns></returns>
	public override double this[PriceType priceType] => priceType switch
	{
		PriceType.Last => Price, 
		PriceType.Open => Price, 
		PriceType.High => Price, 
		PriceType.Low => Price, 
		PriceType.Close => Price, 
		PriceType.Median => Price, 
		PriceType.Weighted => Price, 
		PriceType.Typical => Price, 
		PriceType.Bid => Price, 
		PriceType.Ask => Price, 
		PriceType.Mark => Price, 
		PriceType.Volume => Volume, 
		PriceType.AggressorFlag => (double)AggressorFlag, 
		PriceType.TickDirection => (double)TickDirection, 
		PriceType.BidTickDirection => (double)TickDirection, 
		PriceType.AskTickDirection => (double)TickDirection, 
		PriceType.OpenInterest => OpenInterest, 
		PriceType.FundingRate => FundingRate, 
		PriceType.QuoteAssetVolume => QuoteAssetVolume, 
		_ => base[priceType], 
	};

	VolumeTickDataType IVolumeTickData.VolumeTickDataType => VolumeTickDataType.Lasts;

	long IVolumeTickData.Time => base.TicksLeft;

	/// <summary>
	/// Creates HistoryItemLast instance
	/// </summary>
	public HistoryItemLast()
	{
		Price = double.NaN;
		Volume = double.NaN;
		QuoteAssetVolume = double.NaN;
		AggressorFlag = AggressorFlag.NotSet;
		TickDirection = TickDirection.NotSet;
	}

	public HistoryItemLast(Last last)
		: base(last)
	{
		Price = last.Price;
		Volume = last.Size;
		AggressorFlag = last.AggressorFlag;
		TickDirection = last.TickDirection;
		OpenInterest = last.OpenInterest;
		Buyer = last.Buyer;
		Seller = last.Seller;
		QuoteAssetVolume = last.QuoteAssetVolume;
	}

	private HistoryItemLast(HistoryItemLast P_0)
		: base(P_0)
	{
		Price = P_0.Price;
		Volume = P_0.Volume;
		AggressorFlag = P_0.AggressorFlag;
		TickDirection = P_0.TickDirection;
		OpenInterest = P_0.OpenInterest;
		FundingRate = P_0.FundingRate;
		Buyer = P_0.Buyer;
		Seller = P_0.Seller;
		QuoteAssetVolume = P_0.QuoteAssetVolume;
	}

	[NotPublished]
	public override object Clone()
	{
		return new HistoryItemLast(this);
	}

	/// <summary>
	/// Comparing by <see cref="P:TradingPlatform.BusinessLayer.HistoryItem.TicksLeft" />, OHLC, <see cref="P:TradingPlatform.BusinessLayer.HistoryItemLast.Volume" />
	/// </summary>
	/// <param name="obj"></param>
	/// <returns></returns>
	[NotPublished]
	public override bool Equals(object obj)
	{
		HistoryItemLast historyItemLast = obj as HistoryItemLast;
		if (historyItemLast == null)
		{
			return false;
		}
		if (base.TicksLeft == historyItemLast.TicksLeft && Price == historyItemLast.Price && Volume == historyItemLast.Volume && QuoteAssetVolume == historyItemLast.QuoteAssetVolume)
		{
			return AggressorFlag == historyItemLast.AggressorFlag;
		}
		return false;
	}

	[NotPublished]
	public override int GetHashCode()
	{
		return base.TicksLeft.GetHashCode() ^ Price.GetHashCode() ^ Volume.GetHashCode() ^ QuoteAssetVolume.GetHashCode() ^ AggressorFlag.GetHashCode();
	}

	[NotPublished]
	public static bool operator ==(HistoryItemLast a, HistoryItemLast b)
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
	public static bool operator !=(HistoryItemLast a, HistoryItemLast b)
	{
		return !(a == b);
	}

	[NotPublished]
	public override string ToString()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(22, 3);
		defaultInterpolatedStringHandler.AppendFormatted(base.ToString());
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿녤());
		defaultInterpolatedStringHandler.AppendFormatted(Price);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놆());
		defaultInterpolatedStringHandler.AppendFormatted(Volume);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}
}
