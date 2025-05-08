using System;
using System.Drawing;
using System.Runtime.Serialization;
using System.Xml.Linq;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using TradingPlatform.BusinessLayer.Serialization;

namespace TradingPlatform.BusinessLayer;

[Serializable]
[DataContract]
[KnownType(typeof(FontStyle))]
[KnownType(typeof(GraphicsUnit))]
public sealed class SettingItemFont : SettingItem
{
	public bool UseGeneral;

	public override SettingItemType Type => SettingItemType.Font;

	[DataMember(Name = "Value")]
	private Font ValueFont
	{
		get
		{
			return Value as Font;
		}
		set
		{
			if (value != null)
			{
				Value = value;
			}
		}
	}

	public SettingItemFont()
	{
	}

	public SettingItemFont(string name, Font value, int sortIndex = 0)
		: base(name, value, sortIndex)
	{
	}

	private SettingItemFont(SettingItemFont P_0)
		: base(P_0)
	{
	}

	public override SettingItem GetCopy()
	{
		return new SettingItemFont(this);
	}

	public static implicit operator Font(SettingItemFont item)
	{
		return item.Value as Font;
	}

	protected override bool IsValueTypeValid(object value)
	{
		if (!(value is Font))
		{
			return value == null;
		}
		return true;
	}

	protected override XElement ValueToXElement()
	{
		return ValueFont.ToXElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녲뇆());
	}

	protected override void ValueFromXElement(XElement element, DeserializationInfo deserializationInfo)
	{
		XElement xElement = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녲뇆());
		if (xElement != null)
		{
			ValueFont = xElement.ToFont();
		}
	}
}
