using System.Runtime.CompilerServices;
using ProtoBuf;

namespace TradingPlatform.BusinessLayer;

/// <summary>
/// Represents historical data tick item
/// </summary>
[Published]
[ProtoContract]
public class HistoryItemTick : HistoryItem, IVolumeTickData
{
	[CompilerGenerated]
	private double 뇅놂;

	[CompilerGenerated]
	private double 뇅놎;

	[CompilerGenerated]
	private double 뇅녞;

	[CompilerGenerated]
	private double 뇅놫;

	[CompilerGenerated]
	private TickDirection 뇅녪;

	[CompilerGenerated]
	private TickDirection 뇅녶;

	/// <summary>
	/// Defines Bid price
	/// </summary>
	[ProtoMember(1)]
	public double Bid
	{
		[CompilerGenerated]
		get
		{
			return 뇅놂;
		}
		[CompilerGenerated]
		set
		{
			뇅놂 = value;
		}
	}

	/// <summary>
	/// Defines Bid size
	/// </summary>
	[ProtoMember(2)]
	public double BidSize
	{
		[CompilerGenerated]
		get
		{
			return 뇅놎;
		}
		[CompilerGenerated]
		set
		{
			뇅놎 = value;
		}
	}

	/// <summary>
	/// Defines Ask price
	/// </summary>
	[ProtoMember(3)]
	public double Ask
	{
		[CompilerGenerated]
		get
		{
			return 뇅녞;
		}
		[CompilerGenerated]
		set
		{
			뇅녞 = value;
		}
	}

	/// <summary>
	/// Defines Ask size    
	/// </summary>
	[ProtoMember(4)]
	public double AskSize
	{
		[CompilerGenerated]
		get
		{
			return 뇅놫;
		}
		[CompilerGenerated]
		set
		{
			뇅놫 = value;
		}
	}

	[ProtoMember(5)]
	public TickDirection BidTickDirection
	{
		[CompilerGenerated]
		get
		{
			return 뇅녪;
		}
		[CompilerGenerated]
		set
		{
			뇅녪 = value;
		}
	}

	[ProtoMember(6)]
	public TickDirection AskTickDirection
	{
		[CompilerGenerated]
		get
		{
			return 뇅녶;
		}
		[CompilerGenerated]
		set
		{
			뇅녶 = value;
		}
	}

	/// <summary>
	/// Gets price by indexing <see cref="T:TradingPlatform.BusinessLayer.PriceType" />
	/// </summary>
	/// <param name="priceType"></param>
	/// <returns></returns>
	public override double this[PriceType priceType]
	{
		get
		{
			switch (priceType)
			{
			case PriceType.Open:
			case PriceType.High:
			case PriceType.Low:
			case PriceType.Close:
			case PriceType.Median:
			case PriceType.Typical:
			case PriceType.Weighted:
			case PriceType.Bid:
			case PriceType.Last:
			case PriceType.Mark:
				return Bid;
			case PriceType.BidSize:
				return BidSize;
			case PriceType.Ask:
				return Ask;
			case PriceType.AskSize:
				return AskSize;
			case PriceType.Volume:
				return 0.0;
			case PriceType.TickDirection:
			case PriceType.BidTickDirection:
				return (double)BidTickDirection;
			case PriceType.AskTickDirection:
				return (double)AskTickDirection;
			default:
				return base[priceType];
			}
		}
	}

	VolumeTickDataType IVolumeTickData.VolumeTickDataType => VolumeTickDataType.Ticks;

	long IVolumeTickData.Time => base.TicksLeft;

	double IVolumeTickData.Price => Bid;

	double IVolumeTickData.Volume => 1.0;

	TickDirection IVolumeTickData.TickDirection => BidTickDirection;

	AggressorFlag IVolumeTickData.AggressorFlag => Symbol.ConvertTickDirection(BidTickDirection);

	/// <summary>
	/// Creates HistoryItemBar instance with default Ask/AskSize/Bid/BidSize = <see cref="F:TradingPlatform.BusinessLayer.Utils.Const.DOUBLE_UNDEFINED" />
	/// </summary>
	public HistoryItemTick()
	{
		Bid = double.NaN;
		BidSize = double.NaN;
		Ask = double.NaN;
		AskSize = double.NaN;
		BidTickDirection = TickDirection.NotSet;
		AskTickDirection = TickDirection.NotSet;
	}

	private HistoryItemTick(HistoryItemTick P_0)
		: base(P_0)
	{
		Bid = P_0.Bid;
		BidSize = P_0.BidSize;
		Ask = P_0.Ask;
		AskSize = P_0.AskSize;
	}

	[NotPublished]
	public override object Clone()
	{
		return new HistoryItemTick(this);
	}

	/// <summary>
	/// Comparing by <see cref="P:TradingPlatform.BusinessLayer.HistoryItem.TicksLeft" />, OHLC, <see cref="P:TradingPlatform.BusinessLayer.HistoryItemTick.Ask" />, <see cref="P:TradingPlatform.BusinessLayer.HistoryItemTick.AskSize" />, <see cref="P:TradingPlatform.BusinessLayer.HistoryItemTick.Bid" />, <see cref="P:TradingPlatform.BusinessLayer.HistoryItemTick.BidSize" />
	/// </summary>
	/// <param name="obj"></param>
	/// <returns></returns>
	[NotPublished]
	public override bool Equals(object obj)
	{
		HistoryItemTick historyItemTick = obj as HistoryItemTick;
		if (historyItemTick == null)
		{
			return false;
		}
		if (base.TicksLeft == historyItemTick.TicksLeft && Ask == historyItemTick.Ask && AskSize == historyItemTick.AskSize && Bid == historyItemTick.Bid)
		{
			return BidSize == historyItemTick.BidSize;
		}
		return false;
	}

	[NotPublished]
	public override int GetHashCode()
	{
		return base.TicksLeft.GetHashCode() ^ Ask.GetHashCode() ^ AskSize.GetHashCode() ^ Bid.GetHashCode() ^ BidSize.GetHashCode();
	}

	[NotPublished]
	public static bool operator ==(HistoryItemTick a, HistoryItemTick b)
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
	public static bool operator !=(HistoryItemTick a, HistoryItemTick b)
	{
		return !(a == b);
	}
}
