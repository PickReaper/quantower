using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using ProtoBuf;
using TradingPlatform.BusinessLayer.Integration;

namespace TradingPlatform.BusinessLayer;

[DataContract(Name = "Mark", Namespace = "TradingPlatform")]
[ProtoContract]
[Published]
public class Mark : MessageQuote
{
	[CompilerGenerated]
	private double 뇅놑;

	[CompilerGenerated]
	private double 뇅놦;

	[NotPublished]
	public override MessageType Type => MessageType.Mark;

	[DataMember(Name = "Price")]
	[ProtoMember(1)]
	public double Price
	{
		[CompilerGenerated]
		get
		{
			return 뇅놑;
		}
		[CompilerGenerated]
		private set
		{
			뇅놑 = value;
		}
	}

	[DataMember(Name = "Size")]
	[ProtoMember(2)]
	public double Size
	{
		[CompilerGenerated]
		get
		{
			return 뇅놦;
		}
		[CompilerGenerated]
		private set
		{
			뇅놦 = value;
		}
	}

	private Mark()
	{
	}

	[NotPublished]
	public Mark(string symbol, DateTime time, double price, double size = double.NaN)
		: base(symbol, time)
	{
		Price = price;
		Size = size;
	}

	[NotPublished]
	public override string ToString()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(17, 3);
		defaultInterpolatedStringHandler.AppendFormatted(base.ToString());
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇋놝());
		defaultInterpolatedStringHandler.AppendFormatted(Price);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿녯());
		defaultInterpolatedStringHandler.AppendFormatted(Size);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}
}
