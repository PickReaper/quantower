using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace TradingPlatform.BusinessLayer;

[Serializable]
[DataContract]
public sealed class SettingItemIconedAction : SettingItem
{
	[CompilerGenerated]
	private SettingItemIconedActionType 놃녡;

	public override SettingItemType Type => SettingItemType.IconedAction;

	public SettingItemIconedActionType IconType
	{
		[CompilerGenerated]
		get
		{
			return 놃녡;
		}
		[CompilerGenerated]
		set
		{
			놃녡 = value;
		}
	}

	public SettingItemIconedAction()
	{
	}

	public SettingItemIconedAction(string name, SettingItemActionDelegate value, int sortIndex = 0)
		: base(name, value, sortIndex)
	{
	}

	private SettingItemIconedAction(SettingItemIconedAction P_0)
		: base(P_0)
	{
	}

	public override SettingItem GetCopy()
	{
		return new SettingItemIconedAction(this);
	}

	protected override bool IsValueTypeValid(object value)
	{
		return value is SettingItemActionDelegate;
	}

	public static implicit operator SettingItemActionDelegate(SettingItemIconedAction item)
	{
		return item.Value as SettingItemActionDelegate;
	}
}
