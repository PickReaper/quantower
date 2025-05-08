using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Xml.Linq;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using TradingPlatform.BusinessLayer.Serialization;

namespace TradingPlatform.BusinessLayer;

[Serializable]
[DataContract]
public class SettingItemFile : SettingItem
{
	public string Filter;

	[CompilerGenerated]
	private bool 놃놗;

	[CompilerGenerated]
	private bool 놃뇂;

	[CompilerGenerated]
	private string 놃놩;

	public override SettingItemType Type => SettingItemType.File;

	public bool Checked
	{
		[CompilerGenerated]
		get
		{
			return 놃놗;
		}
		[CompilerGenerated]
		set
		{
			놃놗 = value;
		}
	}

	public bool WithCheckBox
	{
		[CompilerGenerated]
		get
		{
			return 놃뇂;
		}
		[CompilerGenerated]
		set
		{
			놃뇂 = value;
		}
	}

	public string DefaultFolder
	{
		[CompilerGenerated]
		get
		{
			return 놃놩;
		}
		[CompilerGenerated]
		set
		{
			놃놩 = value;
		}
	}

	[DataMember(Name = "Value")]
	private string ValueString
	{
		get
		{
			return Value as string;
		}
		set
		{
			Value = value;
		}
	}

	public SettingItemFile()
	{
	}

	public SettingItemFile(string name, string value, string filter, int sortIndex = 0)
		: base(name, value, sortIndex)
	{
		Filter = filter;
	}

	private SettingItemFile(SettingItemFile P_0)
		: base(P_0)
	{
		Filter = P_0.Filter;
	}

	public override SettingItem GetCopy()
	{
		return new SettingItemFile(this);
	}

	public static implicit operator string(SettingItemFile item)
	{
		return item.Value as string;
	}

	protected override bool IsValueTypeValid(object value)
	{
		return value is string;
	}

	public override XElement ToXElement()
	{
		XElement xElement = base.ToXElement();
		xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰녯(), Checked));
		return xElement;
	}

	public override void FromXElement(XElement element, DeserializationInfo deserializationInfo)
	{
		base.FromXElement(element, deserializationInfo);
		Checked = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰녯())?.ToBool() ?? false;
	}
}
