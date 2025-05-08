using System;
using System.Runtime.Serialization;
using System.Xml.Linq;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using ProtoBuf;
using TradingPlatform.BusinessLayer.Serialization;

namespace TradingPlatform.BusinessLayer;

[Serializable]
[Published]
[DataContract]
[ProtoContract]
public sealed class SettingItemLong : SettingItemNumber<long>
{
	public override SettingItemType Type => SettingItemType.Long;

	[DataMember(Name = "Value")]
	[ProtoMember(1)]
	private long ValueLong
	{
		get
		{
			return (long)value;
		}
		set
		{
			base.value = value;
		}
	}

	public SettingItemLong()
	{
	}

	public SettingItemLong(string name, long value, int sortIndex = 0)
		: base(name, value, sortIndex)
	{
		base.Maximum = long.MaxValue;
		base.Minimum = long.MinValue;
		base.Increment = 1L;
	}

	private SettingItemLong(SettingItemLong P_0)
		: base((SettingItemNumber<long>)P_0)
	{
	}

	[NotPublished]
	public override SettingItem GetCopy()
	{
		return new SettingItemLong(this);
	}

	[NotPublished]
	public static implicit operator long(SettingItemLong item)
	{
		return (long)item.Value;
	}

	[NotPublished]
	protected override bool IsValueTypeValid(object value)
	{
		return value is long;
	}

	[NotPublished]
	protected override object ValidateValue(object value)
	{
		value = base.ValidateValue(value);
		long num = (long)value;
		if (num > base.Maximum)
		{
			num = base.Maximum;
		}
		else if (num < base.Minimum)
		{
			num = base.Minimum;
		}
		else if (base.Increment != 0L)
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
			ValueLong = xElement.ToLong();
		}
	}
}
