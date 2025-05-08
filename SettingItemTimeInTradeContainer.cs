using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Linq;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using ProtoBuf;
using TradingPlatform.BusinessLayer.Serialization;
using TradingPlatform.BusinessLayer.Utils;

namespace TradingPlatform.BusinessLayer;

public class SettingItemTimeInTradeContainer : SettingItem
{
	[DataMember(Name = "Value")]
	[ProtoMember(1)]
	private TimeInTradeContainer TimeInTradeContainer
	{
		get
		{
			return (TimeInTradeContainer)Value;
		}
		set
		{
			Value = value;
		}
	}

	public override SettingItemType Type => SettingItemType.TimeInTradeContainer;

	public SettingItemTimeInTradeContainer()
	{
	}

	public SettingItemTimeInTradeContainer(string name, TimeInTradeContainer timeInTradeCollection, int sortIndex = 0)
		: base(name, timeInTradeCollection, sortIndex)
	{
	}

	public SettingItemTimeInTradeContainer(SettingItemTimeInTradeContainer settingItem)
	{
		value = ((TimeInTradeContainer)settingItem.Value).Clone();
	}

	public override SettingItem GetCopy()
	{
		return new SettingItemTimeInTradeContainer(this);
	}

	protected override bool IsValueTypeValid(object value)
	{
		return value is TimeInTradeContainer;
	}

	protected override XElement ValueToXElement()
	{
		XElement xElement = new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰념());
		TimeInTradeItem[] timeInTradeItems = TimeInTradeContainer.TimeInTradeItems;
		foreach (TimeInTradeItem timeInTradeItem in timeInTradeItems)
		{
			XElement xElement2 = new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰녨());
			xElement2.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰녯(), timeInTradeItem.IsChecked));
			if (timeInTradeItem.Symbol != null)
			{
				xElement2.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶놅(), timeInTradeItem.Symbol.CreateInfo().ToXElement()));
			}
			xElement2.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰녺(), timeInTradeItem.TimeInSeconds));
			xElement2.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰놣(), (int)timeInTradeItem.PLDirection));
			xElement.Add(xElement2);
		}
		return xElement;
	}

	protected override void ValueFromXElement(XElement element, DeserializationInfo deserializationInfo)
	{
		XElement xElement = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰념());
		if (xElement != null)
		{
			element = xElement;
		}
		List<TimeInTradeItem> list = new List<TimeInTradeItem>();
		IEnumerable<XElement> enumerable = element.Elements(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰녨());
		if (enumerable != null)
		{
			foreach (XElement item in enumerable)
			{
				TimeInTradeItem timeInTradeItem = new TimeInTradeItem
				{
					IsChecked = (item.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰녯())?.ToBool() ?? false),
					TimeInSeconds = (item.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰녺())?.ToInt() ?? 0),
					PLDirection = (TimeInTradePlDirection)(item.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰놣())?.ToInt() ?? 0)
				};
				XElement xElement2 = item.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶놅());
				if (xElement2 != null)
				{
					XElement xElement3 = xElement2.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶녬());
					if (xElement3 != null)
					{
						BusinessObjectInfo businessObjectInfo = new BusinessObjectInfo();
						businessObjectInfo.FromXElement(xElement3, deserializationInfo);
						timeInTradeItem.Symbol = Core.Instance.GetSymbol(businessObjectInfo);
					}
				}
				list.Add(timeInTradeItem);
			}
		}
		Value = new TimeInTradeContainer
		{
			TimeInTradeItems = list.ToArray()
		};
	}
}
