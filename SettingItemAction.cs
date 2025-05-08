using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Xml.Linq;
using TradingPlatform.BusinessLayer.Serialization;

namespace TradingPlatform.BusinessLayer;

/// <summary>
/// Typecasts setting as Button item
/// </summary>
[Serializable]
[Published]
[DataContract]
public sealed class SettingItemAction : SettingItem
{
	[CompilerGenerated]
	private string 놃녴;

	public override SettingItemType Type => SettingItemType.Action;

	public string LabelText
	{
		[CompilerGenerated]
		get
		{
			return 놃녴;
		}
		[CompilerGenerated]
		set
		{
			놃녴 = value;
		}
	}

	public SettingItemAction()
	{
	}

	public SettingItemAction(string name, SettingItemActionDelegate value, int sortIndex = 0)
		: base(name, value, sortIndex)
	{
	}

	public SettingItemAction(SettingItemAction settingItem)
		: base(settingItem)
	{
		LabelText = settingItem.LabelText;
	}

	[NotPublished]
	public override SettingItem GetCopy()
	{
		return new SettingItemAction(this);
	}

	[NotPublished]
	public static implicit operator SettingItemActionDelegate(SettingItemAction item)
	{
		return item.Value as SettingItemActionDelegate;
	}

	[NotPublished]
	protected override bool IsValueTypeValid(object value)
	{
		return value is SettingItemActionDelegate;
	}

	protected override void ValueFromXElement(XElement element, DeserializationInfo deserializationInfo)
	{
	}
}
