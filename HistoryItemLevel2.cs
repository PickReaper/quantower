using System.Runtime.CompilerServices;
using ProtoBuf;
using TradingPlatform.BusinessLayer.Integration;

namespace TradingPlatform.BusinessLayer;

[ProtoContract]
public sealed class HistoryItemLevel2 : HistoryItem
{
	[CompilerGenerated]
	private string 놇녘;

	[CompilerGenerated]
	private QuotePriceType 놇노;

	[CompilerGenerated]
	private double 놇녒;

	[CompilerGenerated]
	private double 놇녕;

	[CompilerGenerated]
	private bool 놇녖;

	[ProtoMember(1)]
	public string Id
	{
		[CompilerGenerated]
		get
		{
			return 놇녘;
		}
		[CompilerGenerated]
		set
		{
			놇녘 = value;
		}
	}

	[ProtoMember(2)]
	public QuotePriceType PriceType
	{
		[CompilerGenerated]
		get
		{
			return 놇노;
		}
		[CompilerGenerated]
		set
		{
			놇노 = value;
		}
	}

	[ProtoMember(3)]
	public double Price
	{
		[CompilerGenerated]
		get
		{
			return 놇녒;
		}
		[CompilerGenerated]
		set
		{
			놇녒 = value;
		}
	}

	[ProtoMember(4)]
	public double Size
	{
		[CompilerGenerated]
		get
		{
			return 놇녕;
		}
		[CompilerGenerated]
		set
		{
			놇녕 = value;
		}
	}

	[ProtoMember(5)]
	public bool Closed
	{
		[CompilerGenerated]
		get
		{
			return 놇녖;
		}
		[CompilerGenerated]
		set
		{
			놇녖 = value;
		}
	}

	/// <summary>
	/// Creates HistoryItemLast instance
	/// </summary>
	public HistoryItemLevel2()
	{
		Price = double.NaN;
		Size = double.NaN;
	}

	public HistoryItemLevel2(Level2Quote level2Quote)
		: base(level2Quote)
	{
		Id = level2Quote.Id;
		PriceType = level2Quote.PriceType;
		Price = level2Quote.Price;
		Size = level2Quote.Size;
		Closed = level2Quote.Closed;
	}

	public HistoryItemLevel2(HistoryItemLevel2 original)
		: base(original)
	{
		Id = original.Id;
		PriceType = original.PriceType;
		Price = original.Price;
		Size = original.Size;
		Closed = original.Closed;
	}

	[NotPublished]
	public override object Clone()
	{
		return new HistoryItemLevel2(this);
	}
}
