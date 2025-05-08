using System;
using System.Runtime.Serialization;
using System.Xml.Linq;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using ProtoBuf;
using TradingPlatform.BusinessLayer.Serialization;

namespace TradingPlatform.BusinessLayer;

/// <summary>
/// Typecasts setting as NumericUpDown item
/// </summary>
[Serializable]
[Published]
[DataContract]
[ProtoContract]
public sealed class SettingItemInteger : SettingItemNumber<int>
{
	public override SettingItemType Type => SettingItemType.Integer;

	[DataMember(Name = "Value")]
	[ProtoMember(1)]
	private int ValueInt
	{
		get
		{
			return (int)value;
		}
		set
		{
			base.value = value;
		}
	}

	public SettingItemInteger()
	{
	}

	public SettingItemInteger(string name, int value, int sortIndex = 0)
		: base(name, value, sortIndex)
	{
		base.Maximum = int.MaxValue;
		base.Minimum = int.MinValue;
		base.Increment = 1;
	}

	private SettingItemInteger(SettingItemInteger P_0)
		: base((SettingItemNumber<int>)P_0)
	{
	}

	[NotPublished]
	public override SettingItem GetCopy()
	{
		return new SettingItemInteger(this);
	}

	[NotPublished]
	public static implicit operator int(SettingItemInteger item)
	{
		return (int)item.Value;
	}

	[NotPublished]
	protected override bool IsValueTypeValid(object value)
	{
		return value is int;
	}

	[NotPublished]
	protected override object ValidateValue(object value)
	{
		value = base.ValidateValue(value);
		int num = (int)value;
		if (num > base.Maximum)
		{
			num = base.Maximum;
		}
		else if (num < base.Minimum)
		{
			num = base.Minimum;
		}
		else if (base.Increment != 0)
		{
			num -= num % base.Increment;
		}
		return num;
	}

	[NotPublished]
	protected override void ValueFromXElement(XElement element, DeserializationInfo deserializationInfo)
	{
		XElement xElement = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴놯());
		if (xElement != null)
		{
			ValueInt = xElement.ToInt();
		}
	}
}
