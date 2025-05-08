using System.Runtime.Serialization;
using System.Xml.Linq;
using TradingPlatform.BusinessLayer.Serialization;
using TradingPlatform.BusinessLayer.Utils;

namespace TradingPlatform.BusinessLayer;

public class SettingItemTimeFrameConfig : SettingItem
{
	public override SettingItemType Type => SettingItemType.TimeFrameConfig;

	[DataMember(Name = "Value")]
	private string ValueString
	{
		get
		{
			return Value as string;
		}
		set
		{
			Value = value;
		}
	}

	public SettingItemTimeFrameConfig()
	{
	}

	public SettingItemTimeFrameConfig(string name, TimeFrameConfig value, int sortIndex = 0)
		: base(name, value, sortIndex)
	{
	}

	private SettingItemTimeFrameConfig(SettingItemTimeFrameConfig P_0)
		: base(P_0)
	{
	}

	public override SettingItem GetCopy()
	{
		return new SettingItemTimeFrameConfig(this);
	}

	protected override bool IsValueTypeValid(object value)
	{
		return value is TimeFrameConfig;
	}

	protected override void ValueFromXElement(XElement element, DeserializationInfo deserializationInfo)
	{
		TimeFrameConfig timeFrameConfig = new TimeFrameConfig();
		timeFrameConfig.FromXElement(element, deserializationInfo);
		Value = timeFrameConfig;
	}
}
