using System;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using ProtoBuf;
using TradingPlatform.BusinessLayer.Serialization;
using TradingPlatform.BusinessLayer.Utils;

namespace TradingPlatform.BusinessLayer;

[Published]
[ProtoContract]
public class TradesHistoryRequestParameters : ProgressRequestParameters<float>, IXElementSerialization
{
	[CompilerGenerated]
	private DateTime 녵녵;

	[CompilerGenerated]
	private DateTime 녵놭;

	[CompilerGenerated]
	private string 녵녲;

	[CompilerGenerated]
	private bool 녵뇋;

	public override RequestType Type => RequestType.TradesHistory;

	public Interval<DateTime> Interval => new Interval<DateTime>(From, To);

	[ProtoMember(1)]
	public DateTime From
	{
		[CompilerGenerated]
		get
		{
			return 녵녵;
		}
		[CompilerGenerated]
		set
		{
			녵녵 = value;
		}
	}

	[ProtoMember(2)]
	public DateTime To
	{
		[CompilerGenerated]
		get
		{
			return 녵놭;
		}
		[CompilerGenerated]
		set
		{
			녵놭 = value;
		}
	}

	[ProtoMember(3)]
	public string SymbolId
	{
		[CompilerGenerated]
		get
		{
			return 녵녲;
		}
		[CompilerGenerated]
		set
		{
			녵녲 = value;
		}
	}

	[ProtoMember(4)]
	public bool ForceReload
	{
		[CompilerGenerated]
		get
		{
			return 녵뇋;
		}
		[CompilerGenerated]
		set
		{
			녵뇋 = value;
		}
	}

	public XElement ToXElement()
	{
		XElement xElement = new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭녾());
		xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭놥(), From));
		xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭놯(), To));
		if (!string.IsNullOrEmpty(SymbolId))
		{
			xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭놰(), SymbolId));
		}
		xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭녬(), ForceReload));
		return xElement;
	}

	public void FromXElement(XElement element, DeserializationInfo deserializationInfo)
	{
		XElement xElement = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭놥());
		if (xElement != null)
		{
			From = xElement.ToDateTime(toUTC: true);
		}
		XElement xElement2 = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭놯());
		if (xElement2 != null)
		{
			From = xElement2.ToDateTime(toUTC: true);
		}
		XElement xElement3 = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭놰());
		if (xElement3 != null)
		{
			SymbolId = xElement3.ToString();
		}
		XElement xElement4 = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭녬());
		if (xElement4 != null)
		{
			ForceReload = xElement4.ToBool();
		}
	}

	public TradesHistoryRequestParameters()
	{
	}

	public TradesHistoryRequestParameters(TradesHistoryRequestParameters origin)
		: base((ProgressRequestParameters<float>)origin)
	{
		From = origin.From;
		To = origin.To;
		SymbolId = origin.SymbolId;
		ForceReload = origin.ForceReload;
	}
}
