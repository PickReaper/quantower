using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using TradingPlatform.BusinessLayer.Utils.EqualityComparers;

namespace TradingPlatform.BusinessLayer;

[Serializable]
[DataContract]
public abstract class SettingItemList : SettingItem
{
	private static readonly ListEqualityComparer<SettingItem> 놻녘 = new ListEqualityComparer<SettingItem>(EqualityComparer<SettingItem>.Default);

	[DataMember(Name = "Items")]
	protected virtual List<SettingItem> Items
	{
		get
		{
			return Value as List<SettingItem>;
		}
		set
		{
			Value = value;
		}
	}

	protected SettingItemList(string name, IList<SettingItem> items, int sortIndex = 0)
		: base(name, items, sortIndex)
	{
		if (items == null)
		{
			throw new ArgumentNullException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놁());
		}
	}

	public SettingItemList()
	{
	}

	protected SettingItemList(SettingItemList settingItem)
		: base(settingItem)
	{
		Items = settingItem.CopyItems() as List<SettingItem>;
	}

	protected override bool IsValueTypeValid(object value)
	{
		return value is IList<SettingItem>;
	}

	protected IList<SettingItem> CopyItems()
	{
		List<SettingItem> list = new List<SettingItem>();
		if (Value is IList<SettingItem> list2)
		{
			foreach (SettingItem item in list2)
			{
				list.Add(item.GetCopy());
			}
		}
		return list;
	}

	protected override bool ValueEquals(object other)
	{
		return 놻녘.Equals(Items, other as IList<SettingItem>);
	}
}
