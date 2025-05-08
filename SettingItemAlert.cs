using System;
using System.Runtime.Serialization;
using System.Xml.Linq;
using TradingPlatform.BusinessLayer.Serialization;
using TradingPlatform.BusinessLayer.Utils;

namespace TradingPlatform.BusinessLayer;

[Serializable]
[DataContract]
public class SettingItemAlert : SettingItem
{
	public override SettingItemType Type => SettingItemType.ConditionSet;

	[DataMember(Name = "Value")]
	private AlertData ValueAlert
	{
		get
		{
			return Value as AlertData;
		}
		set
		{
			Value = value;
		}
	}

	public SettingItemAlert()
	{
	}

	public SettingItemAlert(string name, object value, int sortIndex = 0)
		: base(name, value, sortIndex)
	{
	}

	private SettingItemAlert(SettingItemAlert P_0)
		: base(P_0)
	{
	}

	public override SettingItem GetCopy()
	{
		return new SettingItemAlert(this);
	}

	protected override bool IsValueTypeValid(object value)
	{
		return value is AlertData;
	}

	protected override void ValueFromXElement(XElement element, DeserializationInfo deserializationInfo)
	{
		AlertData alertData = new AlertData();
		alertData.FromXElement(element, deserializationInfo);
		value = alertData;
	}
}
