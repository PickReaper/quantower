using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Linq;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using ProtoBuf;
using TradingPlatform.BusinessLayer.Serialization;
using TradingPlatform.BusinessLayer.Utils;

namespace TradingPlatform.BusinessLayer;

public class SettingItemPnlAlertsContainer : SettingItem
{
	public override SettingItemType Type => SettingItemType.PnlAlertsContainer;

	[DataMember(Name = "Value")]
	[ProtoMember(1)]
	private PnlAlertsContainer PnlAlertsContainer
	{
		get
		{
			return (PnlAlertsContainer)Value;
		}
		set
		{
			Value = value;
		}
	}

	public SettingItemPnlAlertsContainer()
	{
	}

	public SettingItemPnlAlertsContainer(string name, PnlAlertsContainer pnLAlertsCollection, int sortIndex = 0)
		: base(name, pnLAlertsCollection, sortIndex)
	{
	}

	public SettingItemPnlAlertsContainer(SettingItemPnlAlertsContainer settingItem)
		: base(settingItem)
	{
		value = ((PnlAlertsContainer)settingItem.Value).Clone();
	}

	public override SettingItem GetCopy()
	{
		return new SettingItemPnlAlertsContainer(this);
	}

	protected override bool IsValueTypeValid(object value)
	{
		return value is PnlAlertsContainer;
	}

	protected override XElement ValueToXElement()
	{
		XElement xElement = new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰녠());
		PnlAlertItem[] pnlAlerts = PnlAlertsContainer.PnlAlerts;
		foreach (PnlAlertItem pnlAlertItem in pnlAlerts)
		{
			XElement xElement2 = new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰놠());
			xElement2.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰녯(), pnlAlertItem.IsChecked));
			if (pnlAlertItem.Symbol != null)
			{
				xElement2.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶놅(), pnlAlertItem.Symbol.CreateInfo().ToXElement()));
			}
			xElement2.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰놟(), pnlAlertItem.TargetValue));
			xElement2.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰놐(), pnlAlertItem.Increment));
			xElement2.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶놈(), pnlAlertItem.Precision));
			xElement.Add(xElement2);
		}
		return xElement;
	}

	protected override void ValueFromXElement(XElement element, DeserializationInfo deserializationInfo)
	{
		XElement xElement = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰녠());
		if (xElement != null)
		{
			element = xElement;
		}
		List<PnlAlertItem> list = new List<PnlAlertItem>();
		IEnumerable<XElement> enumerable = element.Elements(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰놠());
		if (enumerable != null)
		{
			foreach (XElement item in enumerable)
			{
				PnlAlertItem pnlAlertItem = new PnlAlertItem
				{
					IsChecked = (item.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰녯())?.ToBool() ?? false),
					TargetValue = (item.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰놟())?.ToDouble() ?? 0.0),
					Increment = (item.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰놐())?.ToDouble() ?? 1.0),
					Precision = (item.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶놈())?.ToInt() ?? 0)
				};
				XElement xElement2 = item.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶놅());
				if (xElement2 != null)
				{
					XElement xElement3 = xElement2.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶녬());
					if (xElement3 != null)
					{
						BusinessObjectInfo businessObjectInfo = new BusinessObjectInfo();
						businessObjectInfo.FromXElement(xElement3, deserializationInfo);
						pnlAlertItem.Symbol = Core.Instance.GetSymbol(businessObjectInfo);
					}
				}
				list.Add(pnlAlertItem);
			}
		}
		Value = new PnlAlertsContainer
		{
			PnlAlerts = list.ToArray()
		};
	}
}
