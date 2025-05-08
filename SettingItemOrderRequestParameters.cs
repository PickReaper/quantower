using System;
using System.Runtime.Serialization;
using System.Xml.Linq;
using TradingPlatform.BusinessLayer.Serialization;

namespace TradingPlatform.BusinessLayer;

[Serializable]
[DataContract]
public class SettingItemOrderRequestParameters : SettingItem
{
	public override SettingItemType Type => SettingItemType.OrderRequestParameters;

	[DataMember(Name = "Value")]
	private OrderRequestParameters ValueInfo
	{
		get
		{
			return Value as OrderRequestParameters;
		}
		set
		{
			Value = value;
		}
	}

	public SettingItemOrderRequestParameters()
	{
	}

	public SettingItemOrderRequestParameters(string name, OrderRequestParameters value, int sortIndex = 0)
		: base(name, value, sortIndex)
	{
	}

	private SettingItemOrderRequestParameters(SettingItemOrderRequestParameters P_0)
		: base(P_0)
	{
	}

	public override SettingItem GetCopy()
	{
		return new SettingItemOrderRequestParameters(this);
	}

	protected override bool IsValueTypeValid(object value)
	{
		return value is OrderRequestParameters;
	}

	protected override XElement ValueToXElement()
	{
		return ValueInfo.ToXElement();
	}

	protected override void ValueFromXElement(XElement element, DeserializationInfo deserializationInfo)
	{
		PlaceOrderRequestParameters placeOrderRequestParameters = new PlaceOrderRequestParameters();
		placeOrderRequestParameters.FromXElement(element, deserializationInfo);
		value = placeOrderRequestParameters;
	}
}
