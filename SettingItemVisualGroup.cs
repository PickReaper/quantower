using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace TradingPlatform.BusinessLayer;

public class SettingItemVisualGroup : ISettingsGroup, ISettingsGroupCollapseBehaviour
{
	[CompilerGenerated]
	private string 녵놿;

	[CompilerGenerated]
	private int 녵놄;

	[CompilerGenerated]
	private ISettingsGroup 녵놰;

	[CompilerGenerated]
	private GroupActionInfo 녵놓;

	[CompilerGenerated]
	private GroupActionInfo 녵놇;

	[CompilerGenerated]
	private IList<ISettingsGroup> 녵뇅;

	[CompilerGenerated]
	private SettingsGroupCollapseBehaviour 녵놵;

	public string Text
	{
		[CompilerGenerated]
		get
		{
			return 녵놿;
		}
		[CompilerGenerated]
		private set
		{
			녵놿 = value;
		}
	}

	public int SortIndex
	{
		[CompilerGenerated]
		get
		{
			return 녵놄;
		}
		[CompilerGenerated]
		private set
		{
			녵놄 = value;
		}
	}

	public ISettingsGroup ParentGroup
	{
		[CompilerGenerated]
		get
		{
			return 녵놰;
		}
		[CompilerGenerated]
		private set
		{
			녵놰 = value;
		}
	}

	public GroupActionInfo FirstActionInfo
	{
		[CompilerGenerated]
		get
		{
			return 녵놓;
		}
		[CompilerGenerated]
		set
		{
			녵놓 = value;
		}
	}

	public GroupActionInfo SecondActionInfo
	{
		[CompilerGenerated]
		get
		{
			return 녵놇;
		}
		[CompilerGenerated]
		set
		{
			녵놇 = value;
		}
	}

	public IList<ISettingsGroup> ChildGroups
	{
		[CompilerGenerated]
		get
		{
			return 녵뇅;
		}
		[CompilerGenerated]
		private set
		{
			녵뇅 = value;
		}
	}

	public SettingsGroupCollapseBehaviour CollapseBehaviour
	{
		[CompilerGenerated]
		get
		{
			return 녵놵;
		}
		[CompilerGenerated]
		set
		{
			녵놵 = value;
		}
	}

	public SettingItemVisualGroup(string text, int sortIndex = 0, ISettingsGroup parentGroup = null)
	{
		Text = text;
		SortIndex = sortIndex;
		ParentGroup = parentGroup;
		ChildGroups = new List<ISettingsGroup>();
		if (ParentGroup != null)
		{
			ParentGroup.ChildGroups.Add(this);
		}
	}

	public override bool Equals(object obj)
	{
		return GetHashCode() == obj.GetHashCode();
	}

	public override int GetHashCode()
	{
		return 녴(this);
	}

	public override string ToString()
	{
		return Text;
	}

	internal static int 녴(ISettingsGroup P_0)
	{
		int num = 17;
		num = num * 23 + P_0.Text.GetHashCode();
		num = num * 23 + P_0.SortIndex.GetHashCode();
		foreach (ISettingsGroup childGroup in P_0.ChildGroups)
		{
			num = num * 23 + childGroup.GetHashCode();
		}
		return num;
	}
}
