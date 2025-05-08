using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Linq;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using TradingPlatform.BusinessLayer.Serialization;

namespace TradingPlatform.BusinessLayer;

[Serializable]
[DataContract]
public class SettingItemSymbolsList : SettingItemList
{
	public override SettingItemType Type => SettingItemType.SymbolsList;

	[DataMember(Name = "Items")]
	protected override List<SettingItem> Items
	{
		get
		{
			List<SettingItem> list = new List<SettingItem>();
			foreach (SettingItemSymbol item in Value as List<SettingItemSymbol>)
			{
				if (item.Value is Symbol)
				{
					list.Add(item);
				}
			}
			return list;
		}
		set
		{
			Value = 녴(value);
		}
	}

	public SettingItemSymbolsList(string name, IList<SettingItem> items, int sortIndex = 0)
		: base(name, new List<SettingItem>(), sortIndex)
	{
		Value = 녴(items);
	}

	public SettingItemSymbolsList()
	{
	}

	protected SettingItemSymbolsList(SettingItemSymbolsList settingItem)
		: base(settingItem)
	{
	}

	public override SettingItem GetCopy()
	{
		return new SettingItemSymbolsList(this);
	}

	private new IList<SettingItem> 녴(IList<SettingItem> P_0)
	{
		List<SettingItem> list = new List<SettingItem>();
		foreach (SettingItem item in P_0)
		{
			if (item.Value is Symbol)
			{
				list.Add(item);
			}
		}
		return list;
	}

	protected override XElement ValueToXElement()
	{
		XElement xElement = new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰놏());
		foreach (SettingItem item in Items)
		{
			xElement.Add(item.ToXElement());
		}
		return xElement;
	}

	protected override void ValueFromXElement(XElement element, DeserializationInfo deserializationInfo)
	{
		List<SettingItem> list = new List<SettingItem>();
		XElement xElement = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰놏());
		if (xElement != null)
		{
			foreach (XElement item in xElement.Elements())
			{
				SettingItemSymbol settingItemSymbol = new SettingItemSymbol();
				settingItemSymbol.FromXElement(item, deserializationInfo);
				list.Add(settingItemSymbol);
			}
		}
		Items = list;
	}
}
