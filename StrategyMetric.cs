using System.Runtime.CompilerServices;
using System.Xml.Linq;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using ProtoBuf;
using TradingPlatform.BusinessLayer.Serialization;

namespace TradingPlatform.BusinessLayer;

[ProtoContract]
[Published]
public class StrategyMetric : IXElementSerialization
{
	[CompilerGenerated]
	private string 녶녩;

	[CompilerGenerated]
	private string 녶놤;

	[ProtoMember(1)]
	public string Name
	{
		[CompilerGenerated]
		get
		{
			return 녶녩;
		}
		[CompilerGenerated]
		set
		{
			녶녩 = value;
		}
	}

	[ProtoMember(2)]
	public string FormattedValue
	{
		[CompilerGenerated]
		get
		{
			return 녶놤;
		}
		[CompilerGenerated]
		set
		{
			녶놤 = value;
		}
	}

	public void FromXElement(XElement element, DeserializationInfo deserializationInfo)
	{
		XElement xElement = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놵());
		if (xElement != null)
		{
			Name = xElement.Value;
		}
		XElement xElement2 = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭녳());
		if (xElement2 != null)
		{
			FormattedValue = xElement2.Value;
		}
	}

	public XElement ToXElement()
	{
		XElement xElement = new XElement(GetType().Name);
		xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놵(), Name));
		xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭녳(), FormattedValue));
		return xElement;
	}
}
