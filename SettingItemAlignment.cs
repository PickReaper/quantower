using System;
using System.Runtime.Serialization;
using System.Xml.Linq;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using TradingPlatform.BusinessLayer.Serialization;

namespace TradingPlatform.BusinessLayer;

[Serializable]
[DataContract]
public class SettingItemAlignment : SettingItem
{
	public override SettingItemType Type => SettingItemType.Alignment;

	[DataMember(Name = "Value")]
	private NativeAlignment ValueAlignment
	{
		get
		{
			return (NativeAlignment)Value;
		}
		set
		{
			Value = value;
		}
	}

	public SettingItemAlignment()
	{
	}

	public SettingItemAlignment(string name, NativeAlignment value, int sortIndex = 0)
		: base(name, value, sortIndex)
	{
	}

	private SettingItemAlignment(SettingItemAlignment P_0)
		: base(P_0)
	{
	}

	public override SettingItem GetCopy()
	{
		return new SettingItemAlignment(this);
	}

	protected override bool IsValueTypeValid(object value)
	{
		return value is NativeAlignment;
	}

	protected override XElement ValueToXElement()
	{
		return new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴놯(), (int)ValueAlignment);
	}

	protected override void ValueFromXElement(XElement element, DeserializationInfo deserializationInfo)
	{
		XElement xElement = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴놯());
		if (xElement != null)
		{
			ValueAlignment = (NativeAlignment)xElement.ToInt();
		}
	}
}
