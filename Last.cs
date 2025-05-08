using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using ProtoBuf;
using TradingPlatform.BusinessLayer.Integration;

namespace TradingPlatform.BusinessLayer;

/// <summary>
/// Represent access to trade information.
/// </summary>
[DataContract(Name = "Last", Namespace = "TradingPlatform")]
[ProtoContract]
[Published]
public class Last : MessageQuote, IVolumeTickData, IBuyerSellerData
{
	[CompilerGenerated]
	private double 뇅녗;

	[CompilerGenerated]
	private double 뇅놜;

	[CompilerGenerated]
	private AggressorFlag 뇅놨;

	[CompilerGenerated]
	private TickDirection 뇅녢;

	[CompilerGenerated]
	private double 뇅놞;

	[CompilerGenerated]
	private string 뇅놳;

	[CompilerGenerated]
	private string 뇅놺;

	[CompilerGenerated]
	private string 뇅놅;

	[CompilerGenerated]
	private double 뇅녜;

	[NotPublished]
	public override MessageType Type => MessageType.Last;

	/// <summary>
	/// Price at which trade occured
	/// </summary>
	[DataMember(Name = "Price")]
	[ProtoMember(1)]
	public double Price
	{
		[CompilerGenerated]
		get
		{
			return 뇅녗;
		}
		[CompilerGenerated]
		private set
		{
			뇅녗 = value;
		}
	}

	/// <summary>
	/// Size of the trade
	/// </summary>
	[DataMember(Name = "Size")]
	[ProtoMember(2)]
	public double Size
	{
		[CompilerGenerated]
		get
		{
			return 뇅놜;
		}
		[CompilerGenerated]
		set
		{
			뇅놜 = value;
		}
	}

	/// <summary>
	/// Information about operation side of the trade
	/// </summary>
	[DataMember(Name = "AggressorFlag")]
	[ProtoMember(3)]
	public AggressorFlag AggressorFlag
	{
		[CompilerGenerated]
		get
		{
			return 뇅놨;
		}
		[CompilerGenerated]
		set
		{
			뇅놨 = value;
		}
	}

	/// <summary>
	/// Shows the direction of price movement, comparing to previous value.
	/// </summary>
	[DataMember(Name = "TickDirection")]
	[ProtoMember(4)]
	public TickDirection TickDirection
	{
		[CompilerGenerated]
		get
		{
			return 뇅녢;
		}
		[CompilerGenerated]
		set
		{
			뇅녢 = value;
		}
	}

	[DataMember(Name = "OpenInterest")]
	[ProtoMember(5)]
	public double OpenInterest
	{
		[CompilerGenerated]
		get
		{
			return 뇅놞;
		}
		[CompilerGenerated]
		set
		{
			뇅놞 = value;
		}
	}

	[DataMember(Name = "Buyer")]
	[ProtoMember(6)]
	public string Buyer
	{
		[CompilerGenerated]
		get
		{
			return 뇅놳;
		}
		[CompilerGenerated]
		set
		{
			뇅놳 = value;
		}
	}

	[DataMember(Name = "Seller")]
	[ProtoMember(7)]
	public string Seller
	{
		[CompilerGenerated]
		get
		{
			return 뇅놺;
		}
		[CompilerGenerated]
		set
		{
			뇅놺 = value;
		}
	}

	[DataMember(Name = "TradeId")]
	[ProtoMember(8)]
	public string TradeId
	{
		[CompilerGenerated]
		get
		{
			return 뇅놅;
		}
		[CompilerGenerated]
		set
		{
			뇅놅 = value;
		}
	}

	[DataMember(Name = "QuoteAssetVolume")]
	[ProtoMember(9)]
	public double QuoteAssetVolume
	{
		[CompilerGenerated]
		get
		{
			return 뇅녜;
		}
		[CompilerGenerated]
		set
		{
			뇅녜 = value;
		}
	}

	VolumeTickDataType IVolumeTickData.VolumeTickDataType => VolumeTickDataType.Lasts;

	long IVolumeTickData.Time => base.Time.Ticks;

	double IVolumeTickData.Volume => Size;

	private Last()
	{
	}

	[NotPublished]
	public Last(string symbol, double price, double size, DateTime time)
		: base(symbol, time)
	{
		OpenInterest = double.NaN;
		Price = price;
		Size = size;
		QuoteAssetVolume = double.NaN;
		AggressorFlag = AggressorFlag.NotSet;
		TickDirection = TickDirection.NotSet;
	}

	[NotPublished]
	public override string ToString()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 4);
		defaultInterpolatedStringHandler.AppendFormatted(base.ToString());
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇋놝());
		defaultInterpolatedStringHandler.AppendFormatted(Price);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿녯());
		defaultInterpolatedStringHandler.AppendFormatted(Size);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놮());
		defaultInterpolatedStringHandler.AppendFormatted(TradeId);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}
}
