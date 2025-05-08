using System;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using ProtoBuf;
using TradingPlatform.BusinessLayer.Serialization;

namespace TradingPlatform.BusinessLayer;

[ProtoContract]
public class HolidayInfo : IXElementSerialization
{
	[CompilerGenerated]
	private string 놫놧;

	[CompilerGenerated]
	private DateTime 놫녝;

	[ProtoMember(1)]
	public string Name
	{
		[CompilerGenerated]
		get
		{
			return 놫놧;
		}
		[CompilerGenerated]
		set
		{
			놫놧 = value;
		}
	}

	[ProtoMember(2)]
	public DateTime Date
	{
		[CompilerGenerated]
		get
		{
			return 놫녝;
		}
		[CompilerGenerated]
		set
		{
			놫녝 = value;
		}
	}

	public HolidayInfo()
	{
	}

	internal HolidayInfo(HolidayInfo P_0)
	{
		Name = P_0.Name;
		Date = P_0.Date;
	}

	public override string ToString()
	{
		return Core.Instance.TimeUtils.ConvertFromSelectedTimeZoneToUTC(Date).ToShortDateString() + _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴뇎() + Name;
	}

	public XElement ToXElement()
	{
		XElement xElement = new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶녝());
		xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놵(), Name));
		xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶뇈(), Date));
		return xElement;
	}

	public void FromXElement(XElement element, DeserializationInfo deserializationInfo)
	{
		XElement xElement = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놵());
		if (xElement != null)
		{
			Name = xElement.Value;
		}
		XElement xElement2 = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶뇈());
		if (xElement2 != null)
		{
			Date = xElement2.ToDateTime(toUTC: true);
		}
	}
}
