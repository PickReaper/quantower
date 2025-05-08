using System;
using System.Runtime.Serialization;
using System.Xml.Linq;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using ProtoBuf;
using TradingPlatform.BusinessLayer.Serialization;

namespace TradingPlatform.BusinessLayer;

/// <summary>
/// Typecasts setting as CheckBox item
/// </summary>
[Serializable]
[DataContract]
public sealed class SettingItemBooleanSwitcher : SettingItem
{
	public override SettingItemType Type => SettingItemType.BooleanSwitcher;

	[DataMember(Name = "Value")]
	[ProtoMember(1)]
	private bool ValueBool
	{
		get
		{
			return (bool)value;
		}
		set
		{
			base.value = value;
		}
	}

	public SettingItemBooleanSwitcher()
	{
	}

	public SettingItemBooleanSwitcher(string name, bool value, int sortIndex = 0)
		: base(name, value, sortIndex)
	{
	}

	private SettingItemBooleanSwitcher(SettingItemBooleanSwitcher P_0)
		: base(P_0)
	{
	}

	public override SettingItem GetCopy()
	{
		return new SettingItemBooleanSwitcher(this);
	}

	public static implicit operator bool(SettingItemBooleanSwitcher item)
	{
		return (bool)item.Value;
	}

	protected override bool IsValueTypeValid(object value)
	{
		return value is bool;
	}

	protected override void ValueFromXElement(XElement element, DeserializationInfo deserializationInfo)
	{
		XElement xElement = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴놯());
		if (xElement != null)
		{
			ValueBool = xElement.ToBool();
		}
	}
}
