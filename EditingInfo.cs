using System;
using System.Runtime.CompilerServices;

namespace TradingPlatform.BusinessLayer;

public class EditingInfo
{
	[CompilerGenerated]
	private SettingItem 녪;

	[CompilerGenerated]
	private Action<SettingItem> 녶;

	public SettingItem SettingItem
	{
		[CompilerGenerated]
		get
		{
			return 녪;
		}
		[CompilerGenerated]
		set
		{
			녪 = value;
		}
	}

	public Action<SettingItem> ValueChanged
	{
		[CompilerGenerated]
		get
		{
			return 녶;
		}
		[CompilerGenerated]
		set
		{
			녶 = value;
		}
	}

	public EditingInfo()
	{
	}

	public EditingInfo(EditingInfo origin)
	{
		SettingItem = origin.SettingItem.GetCopy();
		ValueChanged = origin.ValueChanged;
	}
}
