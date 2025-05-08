using System;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using ProtoBuf;
using TradingPlatform.BusinessLayer.Serialization;

namespace TradingPlatform.BusinessLayer;

[ProtoContract]
public class Session : ISession, IXElementSerialization
{
	[CompilerGenerated]
	private string 놫뇈;

	[CompilerGenerated]
	private TimeSpan 놫놑;

	[CompilerGenerated]
	private TimeSpan 놫놦;

	[CompilerGenerated]
	private SessionType 놫놐;

	[CompilerGenerated]
	private bool 놫녚;

	[ProtoMember(1)]
	public string Name
	{
		[CompilerGenerated]
		get
		{
			return 놫뇈;
		}
		[CompilerGenerated]
		private set
		{
			놫뇈 = value;
		}
	}

	[ProtoMember(2)]
	public TimeSpan OpenTime
	{
		[CompilerGenerated]
		get
		{
			return 놫놑;
		}
		[CompilerGenerated]
		private set
		{
			놫놑 = value;
		}
	}

	[ProtoMember(3)]
	public TimeSpan CloseTime
	{
		[CompilerGenerated]
		get
		{
			return 놫놦;
		}
		[CompilerGenerated]
		private set
		{
			놫놦 = value;
		}
	}

	[ProtoMember(4)]
	public SessionType Type
	{
		[CompilerGenerated]
		get
		{
			return 놫놐;
		}
		[CompilerGenerated]
		private set
		{
			놫놐 = value;
		}
	}

	[ProtoMember(5)]
	public bool IsPrimary
	{
		[CompilerGenerated]
		get
		{
			return 놫녚;
		}
		[CompilerGenerated]
		set
		{
			놫녚 = value;
		}
	}

	public Session(string name, TimeSpan openTime, TimeSpan closeTime, SessionType type = SessionType.Main, bool isPrimary = false)
		: this()
	{
		Name = name;
		OpenTime = openTime;
		CloseTime = closeTime;
		Type = type;
		IsPrimary = isPrimary;
	}

	public Session(Session session)
		: this(session.Name, session.OpenTime, session.CloseTime, session.Type, session.IsPrimary)
	{
	}

	internal Session()
	{
		Type = SessionType.Main;
	}

	public XElement ToXElement()
	{
		XElement xElement = new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶놑());
		xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놵(), Name));
		xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶놦(), OpenTime));
		xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶놦(), OpenTime));
		xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶놐(), (int)Type));
		xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶녚(), IsPrimary));
		return xElement;
	}

	public void FromXElement(XElement element, DeserializationInfo deserializationInfo)
	{
		XElement xElement = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놵());
		if (xElement != null)
		{
			Name = xElement.Value;
		}
		XElement xElement2 = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶놦());
		if (xElement2 != null)
		{
			OpenTime = xElement2.ToTimeSpan();
		}
		XElement xElement3 = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶녳());
		if (xElement3 != null)
		{
			CloseTime = xElement3.ToTimeSpan();
		}
		XElement xElement4 = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶놐());
		if (xElement4 != null)
		{
			Type = (SessionType)xElement4.ToInt();
		}
		XElement xElement5 = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶녚());
		if (xElement5 != null)
		{
			IsPrimary = xElement5.ToBool();
		}
	}
}
