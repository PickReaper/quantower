using System;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using ProtoBuf;
using TradingPlatform.BusinessLayer.Serialization;

namespace TradingPlatform.BusinessLayer;

[Published]
[ProtoContract]
public class OrdersHistoryRequestParameters : ProgressRequestParameters<float>, IXElementSerialization
{
	[CompilerGenerated]
	private DateTime 녶노;

	[CompilerGenerated]
	private DateTime 녶녒;

	public override RequestType Type => RequestType.OrdersHistory;

	[ProtoMember(1)]
	public DateTime From
	{
		[CompilerGenerated]
		get
		{
			return 녶노;
		}
		[CompilerGenerated]
		set
		{
			녶노 = value;
		}
	}

	[ProtoMember(2)]
	public DateTime To
	{
		[CompilerGenerated]
		get
		{
			return 녶녒;
		}
		[CompilerGenerated]
		set
		{
			녶녒 = value;
		}
	}

	public XElement ToXElement()
	{
		XElement xElement = new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭놉());
		xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭놥(), From));
		xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭놯(), To));
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
	}
}
