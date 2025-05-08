using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Xml.Linq;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using TradingPlatform.BusinessLayer.Serialization;

namespace TradingPlatform.BusinessLayer;

/// <summary>
/// Typecasts setting as TabControl item
/// </summary>
[Serializable]
[Published]
[DataContract]
public sealed class SettingItemGroup : SettingItemList, ISettingsGroup
{
	public bool AllowCreateEmptyGroup;

	[CompilerGenerated]
	private GroupActionInfo 뇇놩;

	[CompilerGenerated]
	private GroupActionInfo 뇇녡;

	public override SettingItemType Type => SettingItemType.Group;

	public GroupActionInfo FirstActionInfo
	{
		[CompilerGenerated]
		get
		{
			return 뇇놩;
		}
		[CompilerGenerated]
		set
		{
			뇇놩 = value;
		}
	}

	public GroupActionInfo SecondActionInfo
	{
		[CompilerGenerated]
		get
		{
			return 뇇녡;
		}
		[CompilerGenerated]
		set
		{
			뇇녡 = value;
		}
	}

	string ISettingsGroup.Text => Text;

	int ISettingsGroup.SortIndex => base.SortIndex;

	ISettingsGroup ISettingsGroup.ParentGroup => base.Group;

	IList<ISettingsGroup> ISettingsGroup.ChildGroups => (Value as IList<SettingItem>)?.OfType<ISettingsGroup>().ToList() ?? new List<ISettingsGroup>();

	protected override List<SettingItem> Items
	{
		get
		{
			return base.Items;
		}
		set
		{
			if (value != null)
			{
				foreach (SettingItem item in value)
				{
					item.Group = this;
				}
			}
			base.Items = value;
		}
	}

	public SettingItemGroup()
		: base(string.Empty, new List<SettingItem>())
	{
	}

	public SettingItemGroup(string name, IList<SettingItem> items, int sortIndex = 0)
		: base(name, items, sortIndex)
	{
		foreach (SettingItem item in items)
		{
			놴(item);
		}
	}

	[NotPublished]
	public override SettingItem GetCopy()
	{
		return new SettingItemGroup(base.Name, CopyItems(), base.SortIndex)
		{
			Text = Text
		};
	}

	public void AddItem(SettingItem item)
	{
		Items.Add(item);
		놴(item);
	}

	public override int GetHashCode()
	{
		return SettingItemVisualGroup.녴(this);
	}

	private void 놴(SettingItem P_0)
	{
		P_0.Group = this;
	}

	[NotPublished]
	public override XElement ToXElement()
	{
		XElement xElement = new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녲놾());
		xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놵(), base.Name));
		xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶놐(), GetType().Name));
		for (int i = 0; i < Items.Count; i++)
		{
			try
			{
				xElement.Add(Items[i].ToXElement());
			}
			catch (Exception ex)
			{
				Core.Instance.Loggers.Log(ex);
			}
		}
		return xElement;
	}

	[NotPublished]
	public override void FromXElement(XElement element, DeserializationInfo deserializationInfo)
	{
		base.Name = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놵()).Value;
		Items.Clear();
		foreach (XElement item in element.Elements(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녲놾()))
		{
			if (Serializer.DeserializeNode(item, deserializationInfo) is SettingItem settingItem)
			{
				settingItem.Group = this;
				Items.Add(settingItem);
			}
		}
	}
}
