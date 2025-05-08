using System.Collections.Generic;
using System.Reflection;

namespace TradingPlatform.BusinessLayer;

public class StrategyInfo : ScriptInfo
{
	internal StrategyInfo(ConstructorInfo P_0, ScriptCreationType P_1, string P_2, string P_3)
		: base(P_0, P_1, P_2, P_3)
	{
	}

	protected override void Initialize(string relativePath, string assemblyName)
	{
		using Strategy strategy = ctor.Invoke(null) as Strategy;
		base.Name = strategy.Name;
		base.Description = strategy.Description;
		base.Version = strategy.Version;
		base.Key = new ScriptKey(base.ScriptCreationType, relativePath, assemblyName, base.Name);
		strategy.Key = base.Key;
		base.Settings = strategy.Settings as List<SettingItem>;
	}

	internal Strategy 녴()
	{
		Strategy strategy = ctor?.Invoke(null) as Strategy;
		if (strategy != null)
		{
			strategy.Key = base.Key;
		}
		return strategy;
	}

	public override string ToString()
	{
		return base.Name;
	}
}
