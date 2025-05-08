using System.Collections.Generic;

namespace TradingPlatform.BusinessLayer;

public class SettingsHolder : Dictionary<string, SettingItem>
{
	public SettingsHolder(IList<SettingItem> settings)
	{
		if (settings == null)
		{
			return;
		}
		foreach (SettingItem setting in settings)
		{
			if (!ContainsKey(setting.Name))
			{
				Add(setting.Name, setting);
			}
		}
	}
}
