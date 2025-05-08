using System;
using System.Runtime.Serialization;

namespace TradingPlatform.BusinessLayer;

/// <summary>
/// Typecasts setting as AccountLookup item
/// </summary>
[Serializable]
[DataContract]
public sealed class SettingItemObject : SettingItem
{
	public override SettingItemType Type => SettingItemType.Object;

	public SettingItemObject()
	{
	}

	public SettingItemObject(string name, object value, int sortIndex = 0)
		: base(name, value, sortIndex)
	{
	}

	private SettingItemObject(SettingItemObject P_0)
		: base(P_0)
	{
	}

	public override SettingItem GetCopy()
	{
		return new SettingItemObject(this);
	}

	protected override bool IsValueTypeValid(object value)
	{
		return true;
	}
}
