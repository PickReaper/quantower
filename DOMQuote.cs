using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using ProtoBuf;
using TradingPlatform.BusinessLayer.Integration;

namespace TradingPlatform.BusinessLayer;

/// <summary>
/// Represent access to DOM2 quote, which contains Bids and Asks. 
/// </summary>
[DataContract(Name = "DOMQuote", Namespace = "TradingPlatform")]
[ProtoContract]
[Published]
public class DOMQuote : MessageQuote
{
	[CompilerGenerated]
	private List<Level2Quote> 뇅뇎;

	[CompilerGenerated]
	private List<Level2Quote> 뇅놷;

	[NotPublished]
	public override MessageType Type => MessageType.DOM;

	/// <summary>
	/// Collection of Asks quotes
	/// </summary>
	[DataMember(Name = "Asks")]
	[ProtoMember(1)]
	public List<Level2Quote> Asks
	{
		[CompilerGenerated]
		get
		{
			return 뇅뇎;
		}
		[CompilerGenerated]
		set
		{
			뇅뇎 = value;
		}
	}

	/// <summary>
	/// Collection of Bids quotes
	/// </summary>
	[DataMember(Name = "Bids")]
	[ProtoMember(2)]
	public List<Level2Quote> Bids
	{
		[CompilerGenerated]
		get
		{
			return 뇅놷;
		}
		[CompilerGenerated]
		set
		{
			뇅놷 = value;
		}
	}

	private DOMQuote()
	{
	}

	[NotPublished]
	public DOMQuote(string symbolId, DateTime time)
		: base(symbolId, time)
	{
		Asks = new List<Level2Quote>();
		Bids = new List<Level2Quote>();
	}

	[NotPublished]
	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		StringBuilder stringBuilder2 = stringBuilder;
		StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(2, 1, stringBuilder2);
		handler.AppendFormatted(base.ToString());
		handler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂녹());
		stringBuilder2.Append(ref handler);
		foreach (Level2Quote ask in Asks)
		{
			stringBuilder.Append(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿녜());
			stringBuilder.Append(ask.ToString());
		}
		foreach (Level2Quote bid in Bids)
		{
			stringBuilder.Append(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿뇃());
			stringBuilder.Append(bid.ToString());
		}
		return stringBuilder.ToString();
	}
}
