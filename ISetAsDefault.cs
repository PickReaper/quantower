using System.Collections.Generic;

namespace TradingPlatform.BusinessLayer;

public interface ISetAsDefault
{
	IList<SettingItem> DefaultSetting { get; }

	void SetAsDefault();
}
