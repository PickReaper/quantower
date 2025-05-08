using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using ProtoBuf;
using TradingPlatform.BusinessLayer.Integration;

namespace TradingPlatform.BusinessLayer;

/// <summary>
/// Represent access to quote information.
/// </summary>
[DataContract(Name = "Quote", Namespace = "TradingPlatform")]
[ProtoContract]
[Published]
public class Quote : MessageQuote, IVolumeTickData
{
	[CompilerGenerated]
	private double 뇅놐;

	[CompilerGenerated]
	private double 뇅녚;

	[CompilerGenerated]
	private double 뇅녳;

	[CompilerGenerated]
	private double 뇅놉;

	[CompilerGenerated]
	private TickDirection 뇅놥;

	[CompilerGenerated]
	private TickDirection 뇅놯;

	[NotPublished]
	public override MessageType Type => MessageType.Quote;

	/// <summary>
	/// Bid price
	/// </summary>
	[DataMember(Name = "Bid")]
	[ProtoMember(1)]
	public double Bid
	{
		[CompilerGenerated]
		get
		{
			return 뇅놐;
		}
		[CompilerGenerated]
		set
		{
			뇅놐 = value;
		}
	}

	/// <summary>
	/// Bid size
	/// </summary>
	[DataMember(Name = "BidSize")]
	[ProtoMember(2)]
	public double BidSize
	{
		[CompilerGenerated]
		get
		{
			return 뇅녚;
		}
		[CompilerGenerated]
		set
		{
			뇅녚 = value;
		}
	}

	/// <summary>
	/// Ask price
	/// </summary>
	[DataMember(Name = "Ask")]
	[ProtoMember(3)]
	public double Ask
	{
		[CompilerGenerated]
		get
		{
			return 뇅녳;
		}
		[CompilerGenerated]
		set
		{
			뇅녳 = value;
		}
	}

	/// <summary>
	/// Ask size
	/// </summary>
	[DataMember(Name = "AskSize")]
	[ProtoMember(4)]
	public double AskSize
	{
		[CompilerGenerated]
		get
		{
			return 뇅놉;
		}
		[CompilerGenerated]
		set
		{
			뇅놉 = value;
		}
	}

	/// <summary>
	/// Shows the direction of bid price movement, comparing to previous value.
	/// </summary>
	[DataMember(Name = "BidTickDirection")]
	[ProtoMember(5)]
	public TickDirection BidTickDirection
	{
		[CompilerGenerated]
		get
		{
			return 뇅놥;
		}
		[CompilerGenerated]
		internal set
		{
			뇅놥 = value;
		}
	}

	/// <summary>
	/// Shows the direction of ask price movement, comparing to previous value.
	/// </summary>
	[DataMember(Name = "AskTickDirection")]
	[ProtoMember(6)]
	public TickDirection AskTickDirection
	{
		[CompilerGenerated]
		get
		{
			return 뇅놯;
		}
		[CompilerGenerated]
		internal set
		{
			뇅놯 = value;
		}
	}

	VolumeTickDataType IVolumeTickData.VolumeTickDataType => VolumeTickDataType.Ticks;

	long IVolumeTickData.Time => base.Time.Ticks;

	double IVolumeTickData.Price => Bid;

	double IVolumeTickData.Volume => 1.0;

	TickDirection IVolumeTickData.TickDirection => BidTickDirection;

	AggressorFlag IVolumeTickData.AggressorFlag => Symbol.ConvertTickDirection(BidTickDirection);

	private Quote()
	{
	}

	[NotPublished]
	public Quote(string symbol, double bid, double bidSize, double ask, double askSize, DateTime time)
		: base(symbol, time)
	{
		Bid = bid;
		BidSize = bidSize;
		Ask = ask;
		AskSize = askSize;
		BidTickDirection = TickDirection.NotSet;
		AskTickDirection = TickDirection.NotSet;
	}

	[NotPublished]
	public override string ToString()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(36, 5);
		defaultInterpolatedStringHandler.AppendFormatted(base.ToString());
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿뇁());
		defaultInterpolatedStringHandler.AppendFormatted(Bid);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놧());
		defaultInterpolatedStringHandler.AppendFormatted(Ask);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿녝());
		defaultInterpolatedStringHandler.AppendFormatted(BidSize);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿뇈());
		defaultInterpolatedStringHandler.AppendFormatted(AskSize);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}
}
