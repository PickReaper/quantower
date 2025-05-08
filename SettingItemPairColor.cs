using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Xml.Linq;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using TradingPlatform.BusinessLayer.Serialization;

namespace TradingPlatform.BusinessLayer;

[Serializable]
[DataContract]
public sealed class SettingItemPairColor : SettingItem
{
	[CompilerGenerated]
	private bool 놃녿;

	[CompilerGenerated]
	private bool 놃놁;

	[CompilerGenerated]
	private bool 놃녭;

	[CompilerGenerated]
	private bool 놃녱;

	public override SettingItemType Type => SettingItemType.PairColor;

	public bool Checked
	{
		[CompilerGenerated]
		get
		{
			return 놃녿;
		}
		[CompilerGenerated]
		set
		{
			놃녿 = value;
		}
	}

	public bool WithCheckBox
	{
		[CompilerGenerated]
		get
		{
			return 놃놁;
		}
		[CompilerGenerated]
		set
		{
			놃놁 = value;
		}
	}

	public bool AllowDisableColor1
	{
		[CompilerGenerated]
		get
		{
			return 놃녭;
		}
		[CompilerGenerated]
		set
		{
			놃녭 = value;
		}
	}

	public bool AllowDisableColor2
	{
		[CompilerGenerated]
		get
		{
			return 놃녱;
		}
		[CompilerGenerated]
		set
		{
			놃녱 = value;
		}
	}

	[DataMember(Name = "Value")]
	private PairColor ValueColor
	{
		get
		{
			return (PairColor)Value;
		}
		set
		{
			Value = value;
		}
	}

	public SettingItemPairColor()
	{
	}

	public SettingItemPairColor(string name, PairColor value, int sortIndex = 0)
		: base(name, value, sortIndex)
	{
	}

	private SettingItemPairColor(SettingItemPairColor P_0)
		: base(P_0)
	{
		Checked = P_0.Checked;
		WithCheckBox = P_0.WithCheckBox;
		AllowDisableColor1 = P_0.AllowDisableColor1;
		AllowDisableColor2 = P_0.AllowDisableColor2;
	}

	public override SettingItem GetCopy()
	{
		return new SettingItemPairColor(this);
	}

	public static implicit operator PairColor(SettingItemPairColor item)
	{
		return (PairColor)item.Value;
	}

	protected override bool IsValueTypeValid(object value)
	{
		return value is PairColor;
	}

	protected override void ValueFromXElement(XElement element, DeserializationInfo deserializationInfo)
	{
		value = new PairColor();
		ValueColor.FromXElement(element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녲뇅()), deserializationInfo);
	}

	public override void FromXElement(XElement element, DeserializationInfo deserializationInfo)
	{
		base.FromXElement(element, deserializationInfo);
		XElement xElement = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녲녺());
		if (xElement != null)
		{
			WithCheckBox = xElement.ToBool();
		}
		XElement xElement2 = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰녯());
		if (xElement2 != null)
		{
			Checked = xElement2.ToBool();
		}
		XElement xElement3 = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰녳());
		if (xElement3 != null)
		{
			AllowDisableColor1 = xElement3.ToBool();
		}
		XElement xElement4 = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰놉());
		if (xElement4 != null)
		{
			AllowDisableColor2 = xElement4.ToBool();
		}
	}

	public override XElement ToXElement()
	{
		XElement xElement = base.ToXElement();
		xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰녯(), Checked));
		xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녲녺(), WithCheckBox));
		xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰녳(), AllowDisableColor1));
		xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰놉(), AllowDisableColor2));
		return xElement;
	}
}
