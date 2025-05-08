using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Xml.Linq;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using ProtoBuf;
using TradingPlatform.BusinessLayer.Serialization;

namespace TradingPlatform.BusinessLayer;

[Serializable]
[DataContract]
[ProtoContract]
public sealed class SettingItemTimeZone : SettingItem
{
	[CompilerGenerated]
	private bool 놃녗;

	[DataMember(Name = "Type")]
	[ProtoMember(1)]
	private TimeZoneType 놃놜;

	[DataMember(Name = "InfoId")]
	[ProtoMember(2)]
	private string 놃놨;

	[DataMember(Name = "BaseUtcOffset")]
	[ProtoMember(3)]
	private TimeSpan 놃녢;

	[DataMember(Name = "DisplayName")]
	[ProtoMember(4)]
	private string 놃놞;

	[DataMember(Name = "StandardDisplayName")]
	[ProtoMember(5)]
	private string 놃놳;

	public override SettingItemType Type => SettingItemType.TimeZone;

	public bool IsFavorite
	{
		[CompilerGenerated]
		get
		{
			return 놃녗;
		}
		[CompilerGenerated]
		set
		{
			놃녗 = value;
		}
	}

	public override object Value
	{
		get
		{
			if (놃놜 == TimeZoneType.Local)
			{
				return new TimeZone(놃놜);
			}
			TimeZoneInfo timeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById(놃놨);
			if (timeZoneInfo == null)
			{
				timeZoneInfo = TimeZoneInfo.CreateCustomTimeZone(놃놨, 놃녢, 놃놞, 놃놳);
			}
			return new TimeZone(놃놜, timeZoneInfo);
		}
		set
		{
			base.Value = value;
		}
	}

	public SettingItemTimeZone()
	{
	}

	public SettingItemTimeZone(string name, TimeZone value, int sortIndex = 0)
		: base(name, value, sortIndex)
	{
		놃놜 = value.Type;
		놃놨 = value.TimeZoneInfo.Id;
		놃녢 = value.TimeZoneInfo.BaseUtcOffset;
		놃놞 = value.TimeZoneInfo.DisplayName;
		놃놳 = value.TimeZoneInfo.StandardName;
	}

	private SettingItemTimeZone(SettingItemTimeZone P_0)
		: base(P_0)
	{
		놃놜 = P_0.놃놜;
		놃놨 = P_0.놃놨;
		놃녢 = P_0.놃녢;
		놃놞 = P_0.놃놞;
		놃놳 = P_0.놃놳;
	}

	public override SettingItem GetCopy()
	{
		return new SettingItemTimeZone(this);
	}

	public static implicit operator TimeZone(SettingItemTimeZone item)
	{
		return (TimeZone)item.Value;
	}

	protected override bool IsValueTypeValid(object value)
	{
		return value is TimeZone;
	}

	protected override XElement ValueToXElement()
	{
		XElement xElement = new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰녮());
		xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶놐(), (int)놃놜));
		xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰뇆(), 놃놨));
		xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰뇉(), 놃녢));
		xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰뇍(), 놃놞));
		xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰놙(), 놃놳));
		return xElement;
	}

	protected override void ValueFromXElement(XElement element, DeserializationInfo deserializationInfo)
	{
		XElement xElement = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰녮());
		if (xElement != null)
		{
			놃놜 = (TimeZoneType)xElement.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶놐()).ToInt();
			놃놨 = xElement.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰뇆()).Value;
			놃녢 = xElement.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰뇉()).ToTimeSpan();
			놃놞 = xElement.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰뇍()).Value;
			놃놳 = xElement.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰놙()).Value;
		}
	}
}
