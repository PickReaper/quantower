using System.Collections.Generic;

namespace TradingPlatform.BusinessLayer;

public interface ICustomizableVisualGroups
{
	void ProcessSettingsVisualGroups(IList<SettingItem> settings);
}
