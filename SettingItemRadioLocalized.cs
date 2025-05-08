using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Xml.Linq;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using TradingPlatform.BusinessLayer.DataBinding;
using TradingPlatform.BusinessLayer.Serialization;

namespace TradingPlatform.BusinessLayer;

[Serializable]
[DataContract]
public sealed class SettingItemRadioLocalized : SettingItem
{
	[CompilerGenerated]
	private new sealed class 녴
	{
		public object 뇇녦;

		internal bool 녴(SelectItem P_0)
		{
			return P_0.Value.CompareTo(뇇녦) == 0;
		}
	}

	private List<SelectItem> 놃놢;

	public override SettingItemType Type => SettingItemType.RadioLocalized;

	[Bindable("items")]
	public List<SelectItem> Items
	{
		get
		{
			return 놃놢;
		}
		set
		{
			SetValue(ref 놃놢, value, null, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰놏());
		}
	}

	[DataMember(Name = "Value")]
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

	public SettingItemRadioLocalized()
	{
	}

	public SettingItemRadioLocalized(string name, SelectItem value, List<SelectItem> items, int sortIndex = 0)
		: base(name, value, sortIndex)
	{
		Items = items;
	}

	private SettingItemRadioLocalized(SettingItemRadioLocalized P_0)
		: base(P_0)
	{
		Items = P_0.Items;
	}

	public override SettingItem GetCopy()
	{
		return new SettingItemRadioLocalized(this);
	}

	public static implicit operator SelectItem(SettingItemRadioLocalized item)
	{
		return item.Value as SelectItem;
	}

	protected override bool IsValueTypeValid(object value)
	{
		return value is SelectItem;
	}

	internal override void 녴(object P_0, bool P_1 = false)
	{
		if (!(P_0 is SelectItem))
		{
			SelectItem selectItem = Items?.FirstOrDefault((SelectItem P_0) => P_0.Value.CompareTo(P_0) == 0);
			P_0 = selectItem ?? new SelectItem(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놇(), (IComparable)P_0);
		}
		base.녴(P_0, P_1);
	}

	protected override XElement ValueToXElement()
	{
		string content = string.Empty;
		if (SeletedItem != null)
		{
			if (SeletedItem.Value is int num)
			{
				content = num.ToString();
			}
			else if (SeletedItem.Value != null)
			{
				content = SeletedItem.Value.ToString();
			}
		}
		return new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴놯(), content);
	}

	protected override void ValueFromXElement(XElement element, DeserializationInfo deserializationInfo)
	{
		XElement xElement = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴놯());
		if (xElement != null)
		{
			if (int.TryParse(xElement.Value, out var result))
			{
				SeletedItem = new SelectItem(string.Empty, result);
			}
			else
			{
				SeletedItem = new SelectItem(string.Empty, xElement.Value);
			}
		}
	}
}
