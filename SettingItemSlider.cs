using System;
using System.Runtime.Serialization;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using ProtoBuf;
using TradingPlatform.BusinessLayer.DataBinding;

namespace TradingPlatform.BusinessLayer;

[Serializable]
[DataContract]
[ProtoContract]
public class SettingItemSlider : SettingItem
{
	private ulong 놃놆;

	public override SettingItemType Type => SettingItemType.Slider;

	[Bindable("stepsCount")]
	public ulong StepsCount
	{
		get
		{
			return 놃놆;
		}
		set
		{
			SetValue(ref 놃놆, value, null, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰녥());
		}
	}

	[DataMember(Name = "Value")]
	[ProtoMember(1)]
	private ulong ValueUlong
	{
		get
		{
			return (ulong)Value;
		}
		set
		{
			Value = value;
		}
	}

	public SettingItemSlider()
	{
	}

	public SettingItemSlider(string name, ulong value, int sortIndex = 0)
		: base(name, value, sortIndex)
	{
	}

	private SettingItemSlider(SettingItemSlider P_0)
		: base(P_0)
	{
		StepsCount = P_0.StepsCount;
	}

	[NotPublished]
	public static implicit operator ulong(SettingItemSlider item)
	{
		return (ulong)item.Value;
	}

	[NotPublished]
	public override SettingItem GetCopy()
	{
		return new SettingItemSlider(this);
	}

	[NotPublished]
	protected override bool IsValueTypeValid(object value)
	{
		return value is ulong;
	}

	[NotPublished]
	protected override object ValidateValue(object value)
	{
		value = base.ValidateValue(value);
		return Math.Min((ulong)value, StepsCount);
	}
}
