using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using ProtoBuf;
using TradingPlatform.BusinessLayer.DataBinding;

namespace TradingPlatform.BusinessLayer;

/// <summary>
/// Typecasts setting as ComboBox item
/// </summary>
[Serializable]
[Published]
[DataContract]
[ProtoContract]
public sealed class SettingItemSelector : SettingItem
{
	private IEnumerable<string> 놃녧;

	public override SettingItemType Type => SettingItemType.Selector;

	[Bindable("items")]
	public IEnumerable<string> Items
	{
		get
		{
			return 놃녧;
		}
		set
		{
			SetValue(ref 놃녧, value, null, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰놏());
		}
	}

	[DataMember(Name = "Value")]
	[ProtoMember(1)]
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

	public SettingItemSelector()
	{
	}

	public SettingItemSelector(string name, string value, IEnumerable<string> items, int sortIndex = 0)
		: base(name, value, sortIndex)
	{
		Items = items;
	}

	private SettingItemSelector(SettingItemSelector P_0)
		: base(P_0)
	{
		Items = P_0.Items;
	}

	[NotPublished]
	public override SettingItem GetCopy()
	{
		return new SettingItemSelector(this);
	}

	[NotPublished]
	public static implicit operator string(SettingItemSelector item)
	{
		return item.Value as string;
	}

	[NotPublished]
	protected override bool IsValueTypeValid(object value)
	{
		return value is string;
	}
}
