using System;

namespace TradingPlatform.BusinessLayer;

public interface IBalanceCalculator : IDisposable
{
	bool DisplayQuantityInLots { get; set; }

	double? CurrentFillPrice { get; set; }

	string QuantityDefiningSettingName { get; set; }

	void Populate(SettingItem[] orderSettings, OrderRequestParameters requestParameters);

	void OnOrderSettingChanged(string settingName, OrderRequestParameters requestParameters);

	void OnTimerTick();
}
