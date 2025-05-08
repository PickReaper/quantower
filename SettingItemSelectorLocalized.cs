using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Xml.Linq;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using ProtoBuf;
using TradingPlatform.BusinessLayer.DataBinding;
using TradingPlatform.BusinessLayer.Serialization;

namespace TradingPlatform.BusinessLayer;

[Serializable]
[DataContract]
[ProtoContract]
public sealed class SettingItemSelectorLocalized : SettingItem
{
	[CompilerGenerated]
	private new sealed class 녴
	{
		public SelectItem 뇇놀;

		internal bool 녴(SelectItem P_0)
		{
			IComparable value = P_0.Value;
			if (value == null)
			{
				return false;
			}
			return value.CompareTo(뇇놀.Value) == 0;
		}
	}

	[CompilerGenerated]
	private sealed class 놴
	{
		public object 뇇놔;

		internal bool 녴(SelectItem P_0)
		{
			return P_0.Value.CompareTo(뇇놔) == 0;
		}
	}

	[CompilerGenerated]
	private sealed class 놂
	{
		public IComparable 뇇놾;

		internal bool 녴(SelectItem P_0)
		{
			return P_0.Value.CompareTo(뇇놾) == 0;
		}
	}

	private List<SelectItem> 놃녤;

	public override SettingItemType Type => SettingItemType.SelectorLocalized;

	[Bindable("items")]
	public List<SelectItem> Items
	{
		get
		{
			return 놃녤;
		}
		set
		{
			SetValue(ref 놃녤, value, null, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰놏());
		}
	}

	private SelectItem SeletedItem
	{
		get
		{
			return Value as SelectItem;
		}
		set
		{
			Value = value;
		}
	}

	[DataMember(Name = "Value")]
	[ProtoMember(1)]
	private string SerializeValue
	{
		get
		{
			string result = string.Empty;
			if (SeletedItem == null)
			{
				return result;
			}
			if (SeletedItem.Value is int || SeletedItem.Value is Enum)
			{
				result = ((int)(object)SeletedItem.Value).ToString();
			}
			else if (SeletedItem.Value != null)
			{
				result = SeletedItem.Value.ToString();
			}
			return result;
		}
		set
		{
			if (int.TryParse(value, out var result))
			{
				SeletedItem = new SelectItem(string.Empty, result);
			}
			else
			{
				SeletedItem = new SelectItem(string.Empty, value);
			}
		}
	}

	public SettingItemSelectorLocalized()
	{
	}

	public SettingItemSelectorLocalized(string name, SelectItem value, List<SelectItem> items, int sortIndex = 0)
		: base(name, value, sortIndex)
	{
		Items = items;
	}

	public SettingItemSelectorLocalized(string name, IComparable value, List<SelectItem> items, int sortIndex = 0)
		: this(name, items?.FirstOrDefault((SelectItem P_0) => P_0.Value.CompareTo(value) == 0), items, sortIndex)
	{
	}

	private SettingItemSelectorLocalized(SettingItemSelectorLocalized P_0)
		: base(P_0)
	{
		Items = P_0.Items;
	}

	public override SettingItem GetCopy()
	{
		return new SettingItemSelectorLocalized(this);
	}

	public static implicit operator SelectItem(SettingItemSelectorLocalized item)
	{
		return item.Value as SelectItem;
	}

	protected override bool IsValueTypeValid(object value)
	{
		return value is SelectItem;
	}

	protected override object ValidateValue(object value)
	{
		SelectItem 뇇놀 = value as SelectItem;
		if (뇇놀 == null)
		{
			return Value;
		}
		if (Items == null || Items.Count == 0)
		{
			return value;
		}
		if (Items.Any(delegate(SelectItem P_0)
		{
			IComparable comparable = P_0.Value;
			return comparable != null && comparable.CompareTo(뇇놀.Value) == 0;
		}))
		{
			return value;
		}
		return Value;
	}

	internal override void 녴(object P_0, bool P_1 = false)
	{
		if (P_0 is SelectItem selectItem)
		{
			P_0 = selectItem.Value;
		}
		SelectItem selectItem2 = Items?.FirstOrDefault((SelectItem P_0) => P_0.Value.CompareTo(P_0) == 0);
		P_0 = selectItem2 ?? new SelectItem(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놇(), (IComparable)P_0);
		base.녴(P_0, P_1);
	}

	internal override void 녴(SettingItem P_0)
	{
		if (P_0 is SettingItemSelectorLocalized { Items: not null } settingItemSelectorLocalized)
		{
			Items = settingItemSelectorLocalized.Items;
		}
		base.녴(P_0);
	}

	protected override XElement ValueToXElement()
	{
		return new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴놯(), SerializeValue);
	}

	protected override void ValueFromXElement(XElement element, DeserializationInfo deserializationInfo)
	{
		XElement xElement = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴놯());
		if (xElement != null)
		{
			SerializeValue = xElement.Value;
		}
	}
}
