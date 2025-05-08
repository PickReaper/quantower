using System.Collections.Generic;
using TradingPlatform.BusinessLayer.Utils;

namespace TradingPlatform.BusinessLayer;

public class SettingItemMinotauroFibonacciLevelOptions : SettingItemFibonacciLevelOptions
{
	public override SettingItemType Type => SettingItemType.MinotauroFibonacciLevelOptions;

	protected override FibonacciLevelOptions CreateFibonaccilevel()
	{
		return new MinotauroFibonacciLevelOptions();
	}

	private SettingItemMinotauroFibonacciLevelOptions(SettingItemFibonacciLevelOptions P_0)
		: base(P_0)
	{
	}

	public override SettingItem GetCopy()
	{
		return new SettingItemMinotauroFibonacciLevelOptions(this);
	}

	public SettingItemMinotauroFibonacciLevelOptions()
	{
	}

	public SettingItemMinotauroFibonacciLevelOptions(string name, List<FibonacciLevelOptions> value, int sortIndex = 0)
		: base(name, value, sortIndex)
	{
	}
}
