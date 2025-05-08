using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using ProtoBuf;
using TradingPlatform.BusinessLayer.Integration;

namespace TradingPlatform.BusinessLayer;

/// <summary>
/// Represent access to Level2 quote. 
/// </summary>
[DataContract(Name = "Level2Quote", Namespace = "TradingPlatform")]
[ProtoContract]
[Published]
public class Level2Quote : MessageQuote
{
	[CompilerGenerated]
	private QuotePriceType 뇅뇃;

	[CompilerGenerated]
	private double 뇅녯;

	[CompilerGenerated]
	private double 뇅놮;

	[CompilerGenerated]
	private string 뇅녫;

	[CompilerGenerated]
	private bool 뇅뇁;

	[CompilerGenerated]
	private string 뇅놧;

	[CompilerGenerated]
	private double 뇅녝;

	[CompilerGenerated]
	private long 뇅뇈;

	[NotPublished]
	public override MessageType Type => MessageType.Level2;

	/// <summary>
	/// Price type of Level2 quote: Bid or Ask
	/// </summary>
	[DataMember(Name = "PriceType")]
	[ProtoMember(1)]
	public QuotePriceType PriceType
	{
		[CompilerGenerated]
		get
		{
			return 뇅뇃;
		}
		[CompilerGenerated]
		private set
		{
			뇅뇃 = value;
		}
	}

	/// <summary>
	/// Price of Level2 quote
	/// </summary>
	[DataMember(Name = "Price")]
	[ProtoMember(2)]
	public double Price
	{
		[CompilerGenerated]
		get
		{
			return 뇅녯;
		}
		[CompilerGenerated]
		private set
		{
			뇅녯 = value;
		}
	}

	/// <summary>
	/// Size of Level2 quote
	/// </summary>
	[DataMember(Name = "Size")]
	[ProtoMember(3)]
	public double Size
	{
		[CompilerGenerated]
		get
		{
			return 뇅놮;
		}
		[CompilerGenerated]
		private set
		{
			뇅놮 = value;
		}
	}

	/// <summary>
	/// Unique ID of Level2 quote
	/// </summary>
	[DataMember(Name = "Id")]
	[ProtoMember(4)]
	public string Id
	{
		[CompilerGenerated]
		get
		{
			return 뇅녫;
		}
		[CompilerGenerated]
		private set
		{
			뇅녫 = value;
		}
	}

	/// <summary>
	/// Shows, whether Level2 quote is using only for removing from depth
	/// </summary>
	[DataMember(Name = "Closed")]
	[ProtoMember(5)]
	public bool Closed
	{
		[CompilerGenerated]
		get
		{
			return 뇅뇁;
		}
		[CompilerGenerated]
		set
		{
			뇅뇁 = value;
		}
	}

	/// <summary>
	/// Broker identifier that send level2 quote
	/// </summary>
	[DataMember(Name = "Broker")]
	[ProtoMember(6)]
	public string Broker
	{
		[CompilerGenerated]
		get
		{
			return 뇅놧;
		}
		[CompilerGenerated]
		set
		{
			뇅놧 = value;
		}
	}

	/// <summary>
	/// specifies the implied quantity associated with the price for the quote. Subtracting this amount from the Size yields the outright quantity for the price level. A value of zero indicates that the implied size is not available/defined or that it is actually zero.
	/// </summary>
	[DataMember(Name = "ImpliedSize")]
	[ProtoMember(7)]
	public double ImpliedSize
	{
		[CompilerGenerated]
		get
		{
			return 뇅녝;
		}
		[CompilerGenerated]
		set
		{
			뇅녝 = value;
		}
	}

	[DataMember(Name = "Priority")]
	[ProtoMember(8)]
	public long Priority
	{
		[CompilerGenerated]
		get
		{
			return 뇅뇈;
		}
		[CompilerGenerated]
		set
		{
			뇅뇈 = value;
		}
	}

	private Level2Quote()
	{
	}

	[NotPublished]
	public Level2Quote(QuotePriceType priceType, string symbolId, string id, double price, double size, DateTime time)
		: base(symbolId, time)
	{
		PriceType = priceType;
		Price = price;
		Size = size;
		Id = id;
	}

	[NotPublished]
	public override string ToString()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(33, 5);
		defaultInterpolatedStringHandler.AppendFormatted(base.ToString());
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇋녬());
		defaultInterpolatedStringHandler.AppendFormatted(Id);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇋놝());
		defaultInterpolatedStringHandler.AppendFormatted(Price);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿녯());
		defaultInterpolatedStringHandler.AppendFormatted(Size);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿녫());
		defaultInterpolatedStringHandler.AppendFormatted(Closed);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}
}
