using System;

namespace TradingPlatform.BusinessLayer;

public class SettingItemEventArgs : EventArgs
{
	public new static SettingItemEventArgs Empty => new SettingItemEventArgs();
}
