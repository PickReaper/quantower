using System.Collections.Generic;

namespace TradingPlatform.BusinessLayer;

public interface ICustomizable
{
	IList<SettingItem> Settings { get; set; }
}
