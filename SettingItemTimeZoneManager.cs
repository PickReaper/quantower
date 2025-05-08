using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Linq;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using TradingPlatform.BusinessLayer.Serialization;

namespace TradingPlatform.BusinessLayer;

[Serializable]
[DataContract]
public class SettingItemTimeZoneManager : SettingItemList
{
	public override SettingItemType Type => SettingItemType.TimeZoneManager;

	public List<TimeZone> FavoriteTimeZones
	{
		get
		{
			List<TimeZone> list = new List<TimeZone>();
			foreach (SettingItemTimeZone item in Value as List<SettingItemTimeZone>)
			{
				if (item.IsFavorite)
				{
					list.Add((TimeZone)item.Value);
				}
			}
			return list;
		}
	}

	[DataMember(Name = "Items")]
	protected override List<SettingItem> Items
	{
		get
		{
			List<SettingItem> list = new List<SettingItem>();
			foreach (SettingItemTimeZone item in Value as List<SettingItemTimeZone>)
			{
				if (item.IsFavorite)
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

	public SettingItemTimeZoneManager()
	{
	}

	public SettingItemTimeZoneManager(string name, IList<SettingItem> items, int sortIndex = 0)
		: base(name, new List<SettingItem>(), sortIndex)
	{
		Value = 녴(items);
	}

	private SettingItemTimeZoneManager(SettingItemTimeZoneManager P_0)
		: base(P_0)
	{
		Value = 녴(CopyItems());
	}

	public override SettingItem GetCopy()
	{
		return new SettingItemTimeZoneManager(this);
	}

	protected override bool IsValueTypeValid(object value)
	{
		return value is IList<SettingItemTimeZone>;
	}

	private new List<SettingItemTimeZone> 녴(IList<SettingItem> P_0)
	{
		List<SettingItemTimeZone> list = new List<SettingItemTimeZone>();
		Dictionary<string, SettingItemTimeZone> dictionary = new Dictionary<string, SettingItemTimeZone>();
		foreach (SettingItem item in P_0)
		{
			if (item is SettingItemTimeZone settingItemTimeZone)
			{
				dictionary[((TimeZone)settingItemTimeZone.Value).TimeZoneInfo.Id] = settingItemTimeZone;
			}
		}
		foreach (TimeZoneInfo systemTimeZone in TimeZoneInfo.GetSystemTimeZones())
		{
			SettingItemTimeZone settingItemTimeZone2 = new SettingItemTimeZone(systemTimeZone.Id, new TimeZone(TimeZoneType.Specific, systemTimeZone));
			if (dictionary.ContainsKey(systemTimeZone.Id))
			{
				settingItemTimeZone2.IsFavorite = true;
			}
			list.Add(settingItemTimeZone2);
		}
		return list;
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
		if (xElement != null)
		{
			foreach (XElement item in xElement.Elements())
			{
				SettingItemTimeZone settingItemTimeZone = new SettingItemTimeZone();
				settingItemTimeZone.FromXElement(item, deserializationInfo);
				list.Add(settingItemTimeZone);
			}
		}
		Items = list;
	}
}
