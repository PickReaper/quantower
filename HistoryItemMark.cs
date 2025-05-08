using System.Runtime.CompilerServices;
using ProtoBuf;

namespace TradingPlatform.BusinessLayer;

[ProtoContract]
public class HistoryItemMark : HistoryItem
{
	[CompilerGenerated]
	private double 뇅녴;

	[CompilerGenerated]
	private double 뇅놴;

	[ProtoMember(1)]
	public double Price
	{
		[CompilerGenerated]
		get
		{
			return 뇅녴;
		}
		[CompilerGenerated]
		set
		{
			뇅녴 = value;
		}
	}

	[ProtoMember(2)]
	public double Volume
	{
		[CompilerGenerated]
		get
		{
			return 뇅놴;
		}
		[CompilerGenerated]
		set
		{
			뇅놴 = value;
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
			case PriceType.Ask:
			case PriceType.Last:
			case PriceType.Mark:
				return Price;
			case PriceType.Volume:
				return Volume;
			default:
				return base[priceType];
			}
		}
	}

	/// <summary>
	/// Creates HistoryItemLast instance
	/// </summary>
	public HistoryItemMark()
	{
		Price = double.NaN;
		Volume = double.NaN;
	}

	private HistoryItemMark(HistoryItemMark P_0)
		: base(P_0)
	{
		Price = P_0.Price;
		Volume = P_0.Volume;
	}

	[NotPublished]
	public override object Clone()
	{
		return new HistoryItemMark(this);
	}
}
