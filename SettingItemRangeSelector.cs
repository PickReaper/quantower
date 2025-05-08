using System.Runtime.Serialization;
using System.Xml.Linq;
using ProtoBuf;
using TradingPlatform.BusinessLayer.Serialization;
using TradingPlatform.BusinessLayer.Utils;

namespace TradingPlatform.BusinessLayer;

public class SettingItemRangeSelector : SettingItem
{
	public override SettingItemType Type => SettingItemType.RangeSelector;

	[DataMember(Name = "Value")]
	[ProtoMember(29)]
	private DateTimeRange ValueSelector
	{
		get
		{
			return (DateTimeRange)value;
		}
		set
		{
			base.value = value;
		}
	}

	public SettingItemRangeSelector()
	{
	}

	public SettingItemRangeSelector(string name, DateTimeRange value, int sortIndex = 0)
		: base(name, value, sortIndex)
	{
	}

	private SettingItemRangeSelector(SettingItemRangeSelector P_0)
		: base(P_0)
	{
	}

	public override SettingItem GetCopy()
	{
		return new SettingItemRangeSelector(this);
	}

	protected override bool IsValueTypeValid(object value)
	{
		return Value is DateTimeRange;
	}

	protected override void ValueFromXElement(XElement element, DeserializationInfo deserializationInfo)
	{
		base.ValueFromXElement(element, deserializationInfo);
		DateTimeRange dateTimeRange = new DateTimeRange();
		dateTimeRange.FromXElement(element, deserializationInfo);
		ValueSelector = dateTimeRange;
	}
}
