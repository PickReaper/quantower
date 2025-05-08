using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Xml.Linq;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using TradingPlatform.BusinessLayer.Serialization;

namespace TradingPlatform.BusinessLayer;

[Serializable]
[DataContract]
public class SettingItemBooleanLocalized : SettingItemList
{
	[Serializable]
	[CompilerGenerated]
	private new sealed class 녴
	{
		public static readonly 녴 뇇놑 = new 녴();

		public static Predicate<SettingItem> 뇇놦;

		internal bool 녴(SettingItem P_0)
		{
			return P_0 is SettingItemBoolean;
		}
	}

	public override SettingItemType Type => SettingItemType.BooleanLocalized;

	public SettingItemBooleanLocalized()
	{
	}

	public SettingItemBooleanLocalized(string name, IList<SettingItem> items, int sortIndex = 0)
		: base(name, items, sortIndex)
	{
	}

	private SettingItemBooleanLocalized(SettingItemBooleanLocalized P_0)
		: base(P_0)
	{
	}

	public override SettingItem GetCopy()
	{
		return new SettingItemBooleanLocalized(this);
	}

	protected override bool IsValueTypeValid(object value)
	{
		if (value is List<SettingItem> list)
		{
			return list.TrueForAll((SettingItem P_0) => P_0 is SettingItemBoolean);
		}
		return false;
	}

	protected override XElement ValueToXElement()
	{
		XElement xElement = new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰놏());
		List<SettingItem> items = Items;
		for (int i = 0; i < items.Count; i++)
		{
			xElement.Add(items[i].ToXElement());
		}
		return xElement;
	}

	protected override void ValueFromXElement(XElement element, DeserializationInfo deserializationInfo)
	{
		List<SettingItem> list = new List<SettingItem>();
		XElement xElement = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰놏());
		foreach (XElement item in xElement.Elements())
		{
			SettingItemBoolean settingItemBoolean = new SettingItemBoolean();
			settingItemBoolean.FromXElement(item, deserializationInfo);
			list.Add(settingItemBoolean);
		}
		Items = list;
	}
}
