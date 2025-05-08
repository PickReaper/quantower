using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Xml.Linq;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using TradingPlatform.BusinessLayer.Serialization;

namespace TradingPlatform.BusinessLayer;

/// <summary>
/// Typecasts setting as Color item
/// </summary>
[Serializable]
[Published]
[DataContract]
public sealed class SettingItemColor : SettingItem
{
	[CompilerGenerated]
	private string 놃놄;

	[CompilerGenerated]
	private bool 놃놰;

	[CompilerGenerated]
	private bool 놃놓;

	[CompilerGenerated]
	private bool 놃놇;

	public override SettingItemType Type => SettingItemType.Color;

	public string ColorText
	{
		[CompilerGenerated]
		get
		{
			return 놃놄;
		}
		[CompilerGenerated]
		set
		{
			놃놄 = value;
		}
	}

	public bool Checked
	{
		[CompilerGenerated]
		get
		{
			return 놃놰;
		}
		[CompilerGenerated]
		set
		{
			놃놰 = value;
		}
	}

	public bool WithCheckBox
	{
		[CompilerGenerated]
		get
		{
			return 놃놓;
		}
		[CompilerGenerated]
		set
		{
			놃놓 = value;
		}
	}

	public bool AllowDisableColor
	{
		[CompilerGenerated]
		get
		{
			return 놃놇;
		}
		[CompilerGenerated]
		set
		{
			놃놇 = value;
		}
	}

	[DataMember(Name = "Value")]
	private Color ValueColor
	{
		get
		{
			return (Color)Value;
		}
		set
		{
			Value = value;
		}
	}

	public SettingItemColor()
	{
	}

	public SettingItemColor(string name, Color value, int sortIndex = 0)
		: base(name, value, sortIndex)
	{
	}

	private SettingItemColor(SettingItemColor P_0)
		: base(P_0)
	{
		ColorText = P_0.ColorText;
		Checked = P_0.Checked;
		WithCheckBox = P_0.WithCheckBox;
		AllowDisableColor = P_0.AllowDisableColor;
	}

	[NotPublished]
	public override SettingItem GetCopy()
	{
		return new SettingItemColor(this);
	}

	[NotPublished]
	public static implicit operator Color(SettingItemColor item)
	{
		return (Color)item.Value;
	}

	[NotPublished]
	protected override bool IsValueTypeValid(object value)
	{
		return value is Color;
	}

	[NotPublished]
	protected override XElement ValueToXElement()
	{
		return ValueColor.ToXElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녲뇈());
	}

	[NotPublished]
	protected override void ValueFromXElement(XElement element, DeserializationInfo deserializationInfo)
	{
		XElement xElement = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녲뇈());
		if (xElement != null)
		{
			ValueColor = xElement.ToColor();
		}
	}

	[NotPublished]
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
		XElement xElement3 = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰놮());
		if (xElement3 != null)
		{
			AllowDisableColor = xElement3.ToBool();
		}
	}

	[NotPublished]
	public override XElement ToXElement()
	{
		XElement xElement = base.ToXElement();
		xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰녯(), Checked));
		xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녲녺(), WithCheckBox));
		xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰놮(), AllowDisableColor));
		return xElement;
	}
}
