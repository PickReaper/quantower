using System.Runtime.Serialization;

namespace TradingPlatform.BusinessLayer;

public class SettingItemLabel : SettingItem
{
	public override SettingItemType Type => SettingItemType.Label;

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

	public SettingItemLabel()
	{
	}

	public SettingItemLabel(string name, string value = null, int sortIndex = 0)
		: base(name, value ?? string.Empty, sortIndex)
	{
	}

	private SettingItemLabel(SettingItemLabel P_0)
		: base(P_0)
	{
	}

	public override SettingItem GetCopy()
	{
		return new SettingItemLabel(this);
	}

	protected override bool IsValueTypeValid(object value)
	{
		return value is string;
	}
}
