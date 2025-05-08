using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using TradingPlatform.BusinessLayer.Serialization;
using TradingPlatform.BusinessLayer.Utils;

namespace TradingPlatform.BusinessLayer;

public sealed class StrategyManager : ScriptManager<StrategyInfo, Strategy>
{
	[CompilerGenerated]
	private new sealed class 녴
	{
		public Strategy 녶놋;

		public StrategyManager 녶녣;

		internal void 녴()
		{
			녶녣.녴(녶놋);
		}
	}

	private readonly List<Strategy> 놴놗;

	[CompilerGenerated]
	private StrategyEventHandler 놴뇂;

	[CompilerGenerated]
	private Action<Strategy> 놴놩;

	[CompilerGenerated]
	private Action<Strategy> 놴녡;

	[CompilerGenerated]
	private bool 놴녦;

	public Strategy[] Created => 놴놗.ToArray();

	protected override string DefaultScriptsPath => Const.DEFAULT_STRATEGIES_RELATIVE_PATH;

	public override string CustomScriptsPath => Const.CUSTOM_STRATEGIES_PATH;

	public bool RestoreStateAfterShutdown
	{
		[CompilerGenerated]
		get
		{
			return 놴녦;
		}
		[CompilerGenerated]
		set
		{
			놴녦 = value;
		}
	}

	public event StrategyEventHandler StrategyStateChanged
	{
		[CompilerGenerated]
		add
		{
			StrategyEventHandler strategyEventHandler = 놴뇂;
			StrategyEventHandler strategyEventHandler2;
			do
			{
				strategyEventHandler2 = strategyEventHandler;
				StrategyEventHandler value2 = (StrategyEventHandler)Delegate.Combine(strategyEventHandler2, value);
				strategyEventHandler = Interlocked.CompareExchange(ref 놴뇂, value2, strategyEventHandler2);
			}
			while ((object)strategyEventHandler != strategyEventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			StrategyEventHandler strategyEventHandler = 놴뇂;
			StrategyEventHandler strategyEventHandler2;
			do
			{
				strategyEventHandler2 = strategyEventHandler;
				StrategyEventHandler value2 = (StrategyEventHandler)Delegate.Remove(strategyEventHandler2, value);
				strategyEventHandler = Interlocked.CompareExchange(ref 놴뇂, value2, strategyEventHandler2);
			}
			while ((object)strategyEventHandler != strategyEventHandler2);
		}
	}

	public event Action<Strategy> StrategyCreated
	{
		[CompilerGenerated]
		add
		{
			Action<Strategy> action = 놴놩;
			Action<Strategy> action2;
			do
			{
				action2 = action;
				Action<Strategy> value2 = (Action<Strategy>)Delegate.Combine(action2, value);
				action = Interlocked.CompareExchange(ref 놴놩, value2, action2);
			}
			while ((object)action != action2);
		}
		[CompilerGenerated]
		remove
		{
			Action<Strategy> action = 놴놩;
			Action<Strategy> action2;
			do
			{
				action2 = action;
				Action<Strategy> value2 = (Action<Strategy>)Delegate.Remove(action2, value);
				action = Interlocked.CompareExchange(ref 놴놩, value2, action2);
			}
			while ((object)action != action2);
		}
	}

	public event Action<Strategy> StrategyRemoved
	{
		[CompilerGenerated]
		add
		{
			Action<Strategy> action = 놴녡;
			Action<Strategy> action2;
			do
			{
				action2 = action;
				Action<Strategy> value2 = (Action<Strategy>)Delegate.Combine(action2, value);
				action = Interlocked.CompareExchange(ref 놴녡, value2, action2);
			}
			while ((object)action != action2);
		}
		[CompilerGenerated]
		remove
		{
			Action<Strategy> action = 놴녡;
			Action<Strategy> action2;
			do
			{
				action2 = action;
				Action<Strategy> value2 = (Action<Strategy>)Delegate.Remove(action2, value);
				action = Interlocked.CompareExchange(ref 놴녡, value2, action2);
			}
			while ((object)action != action2);
		}
	}

	internal StrategyManager()
	{
		놴놗 = new List<Strategy>();
		RestoreStateAfterShutdown = false;
	}

	internal override void 녴()
	{
		Core.Instance.Loggers.Log(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴뇁(), LoggingLevel.Verbose);
		try
		{
			base.녴();
		}
		catch (Exception ex)
		{
			Core.Instance.Loggers.Log(ex);
		}
		Core.Instance.Loggers.Log(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴놧(), LoggingLevel.Verbose);
	}

	public Strategy CreateStrategy(string strategyName, string assemblyName = "", string relativePath = "", ScriptCreationType scriptCreationType = ScriptCreationType.Default)
	{
		if (string.IsNullOrEmpty(strategyName))
		{
			throw new ArgumentNullException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴녝());
		}
		ScriptKey scriptKey = SearchScriptKey(strategyName, assemblyName, relativePath, scriptCreationType);
		return CreateStrategy(scriptKey);
	}

	public Strategy CreateStrategy(ScriptKey scriptKey)
	{
		if (scriptsInfoCache.TryGetValue(scriptKey, out var value))
		{
			return CreateStrategy(value);
		}
		return null;
	}

	public Strategy CreateStrategy(StrategyInfo strategyInfo)
	{
		Strategy strategy = strategyInfo.녴();
		녴(strategy);
		return strategy;
	}

	private void 녴(Strategy P_0)
	{
		P_0.녴();
		놴놗.Add(P_0);
		놴놩?.Invoke(P_0);
	}

	public void DeleteStrategy(Strategy strategy)
	{
		if (strategy == null)
		{
			throw new ArgumentNullException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴뇈());
		}
		놴놗.Remove(strategy);
		strategy.Remove();
		strategy.Dispose();
		놴녡?.Invoke(strategy);
	}

	public void OnSettingsLoaded()
	{
		if (RestoreStateAfterShutdown)
		{
			놴();
		}
	}

	public void SaveStrategies()
	{
		if (놴놗 == null)
		{
			return;
		}
		foreach (Strategy item in 놴놗)
		{
			try
			{
				Serializer.SerializeXML(Path.Combine(item.DataFolderPath, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴놑()), new List<IXElementSerialization> { item });
			}
			catch (Exception ex)
			{
				Core.Instance.Loggers.Log(ex);
			}
		}
	}

	public void LoadStrategies()
	{
		if (!Directory.Exists(Const.SCRIPTS_DATA_PATH))
		{
			return;
		}
		foreach (string item in Directory.EnumerateFiles(Const.SCRIPTS_DATA_PATH, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴놑(), SearchOption.AllDirectories))
		{
			try
			{
				double version;
				Strategy 녶놋 = Serializer.DeserializeXML(item, out version, 녴).FirstOrDefault() as Strategy;
				if (녶놋 != null)
				{
					Task.Run(delegate
					{
						녴(녶놋);
					});
				}
			}
			catch (Exception ex)
			{
				Core.Instance.Loggers.Log(ex);
			}
		}
	}

	private void 놴()
	{
		Strategy[] created = Created;
		for (int i = 0; i < created.Length; i++)
		{
			created[i].놴();
		}
	}

	protected override string GetScriptsFolderPath(ScriptCreationType scriptCreationType)
	{
		if (scriptCreationType != 0)
		{
			return Const.CUSTOM_STRATEGIES_PATH;
		}
		return Path.Combine(Const.EXECUTING_FOLDER, Const.DEFAULT_STRATEGIES_RELATIVE_PATH);
	}

	protected override StrategyInfo CreateScriptInfo(ConstructorInfo ctor, ScriptCreationType scriptCreationType, string relativePath, string assemblyName)
	{
		return new StrategyInfo(ctor, scriptCreationType, relativePath, assemblyName);
	}

	public override void Dispose()
	{
		if (놴놗 != null)
		{
			foreach (Strategy item in 놴놗)
			{
				item.Stop();
				item.Dispose();
			}
			놴놗.Clear();
		}
		base.Dispose();
	}

	internal void 녴(Strategy P_0, StrategyState P_1, StrategyState P_2)
	{
		놴뇂?.Invoke(P_0, new StrategyEventArgs(P_1)
		{
			StrategyPreviousState = P_2
		});
	}

	protected override void OnScriptUpdated(ScriptInfo scriptInfo)
	{
		Strategy[] created = Created;
		foreach (Strategy strategy in created)
		{
			if (!(strategy.Key != scriptInfo.Key))
			{
				strategy.NewVersionAvailable = true;
			}
		}
		base.OnScriptUpdated(scriptInfo);
	}

	private IXElementSerialization 녴(XElement P_0)
	{
		if (P_0 == null)
		{
			return null;
		}
		string text = P_0.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴놦())?.Value;
		if (string.IsNullOrEmpty(text))
		{
			return SettingItem.DesserrializationFabric(P_0);
		}
		ScriptKey key = ScriptKey.CreateScriptKeyFromString(text);
		if (!scriptsInfoCache.TryGetValue(key, out var value))
		{
			return null;
		}
		return value.녴();
	}
}
