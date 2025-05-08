using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using ProtoBuf;
using TradingPlatform.BusinessLayer.Serialization;

namespace TradingPlatform.BusinessLayer;

[ProtoContract]
public class SessionsSet : IXElementSerialization
{
	[Serializable]
	[CompilerGenerated]
	private sealed class 녴
	{
		public static readonly 녴 놰녱 = new 녴();

		public static Func<Session, Session> 놰놲;

		public static Func<XElement, DayOfWeek> 놰높;

		public static Func<XElement, DateTime> 놰놶;

		internal Session 녴(Session P_0)
		{
			return new Session(P_0);
		}

		internal DayOfWeek 녴(XElement P_0)
		{
			return (DayOfWeek)P_0.ToInt();
		}

		internal DateTime 놴(XElement P_0)
		{
			return P_0.ToDateTime(toUTC: true);
		}
	}

	[CompilerGenerated]
	private Session[] 놫녳;

	[CompilerGenerated]
	private DayOfWeek[] 놫놉;

	[CompilerGenerated]
	private DateTime[] 놫놥;

	[ProtoMember(1)]
	public Session[] Sessions
	{
		[CompilerGenerated]
		get
		{
			return 놫녳;
		}
		[CompilerGenerated]
		set
		{
			놫녳 = value;
		}
	}

	[ProtoMember(2)]
	public DayOfWeek[] Days
	{
		[CompilerGenerated]
		get
		{
			return 놫놉;
		}
		[CompilerGenerated]
		set
		{
			놫놉 = value;
		}
	}

	[ProtoMember(3)]
	public DateTime[] CertainDates
	{
		[CompilerGenerated]
		get
		{
			return 놫놥;
		}
		[CompilerGenerated]
		set
		{
			놫놥 = value;
		}
	}

	public SessionsSet()
	{
	}

	internal SessionsSet(SessionsSet P_0)
	{
		Sessions = P_0.Sessions.Select((Session P_0) => new Session(P_0)).ToArray();
		Days = P_0.Days?.Clone() as DayOfWeek[];
		CertainDates = P_0.CertainDates?.ToArray();
	}

	public XElement ToXElement()
	{
		XElement xElement = new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶녝());
		XElement xElement2 = new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶놉());
		Session[] sessions = Sessions;
		foreach (Session session in sessions)
		{
			xElement2.Add(session.ToXElement());
		}
		xElement.Add(xElement2);
		XElement xElement3 = new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶놥());
		DayOfWeek[] days = Days;
		foreach (DayOfWeek dayOfWeek in days)
		{
			xElement3.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶놯(), (int)dayOfWeek));
		}
		xElement.Add(xElement3);
		if (CertainDates != null)
		{
			XElement xElement4 = new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶놥());
			DateTime[] certainDates = CertainDates;
			foreach (DateTime dateTime in certainDates)
			{
				xElement4.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶뇈(), dateTime));
			}
			xElement.Add(xElement4);
		}
		return xElement;
	}

	public void FromXElement(XElement element, DeserializationInfo deserializationInfo)
	{
		XElement xElement = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶놉());
		if (xElement != null)
		{
			List<Session> list = new List<Session>();
			foreach (XElement item in xElement.Elements())
			{
				Session session = new Session();
				session.FromXElement(item, deserializationInfo);
				list.Add(session);
			}
			Sessions = list.ToArray();
		}
		XElement xElement2 = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶놥());
		if (xElement2 != null)
		{
			Days = (from P_0 in xElement2.Elements()
				select (DayOfWeek)P_0.ToInt()).ToArray();
		}
		XElement xElement3 = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶녾());
		if (xElement3 != null)
		{
			CertainDates = (from P_0 in xElement3.Elements()
				select P_0.ToDateTime(toUTC: true)).ToArray();
		}
	}
}
