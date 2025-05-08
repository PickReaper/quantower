using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using TradingPlatform.BusinessLayer.Utils;

namespace TradingPlatform.BusinessLayer;

public sealed class IndicatorManager : ScriptManager<IndicatorInfo, Indicator>
{
	[CompilerGenerated]
	private BuiltInIndicators 놈;

	public BuiltInIndicators BuiltIn
	{
		[CompilerGenerated]
		get
		{
			return 놈;
		}
		[CompilerGenerated]
		private set
		{
			놈 = value;
		}
	}

	protected override string DefaultScriptsPath => Const.DEFAULT_INDICATORS_RELATIVE_PATH;

	public override string CustomScriptsPath => Const.CUSTOM_INDICATORS_PATH;

	internal IndicatorManager()
	{
		BuiltIn = new BuiltInIndicators();
	}

	internal override void 녴()
	{
		Core.Instance.Loggers.Log(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴녗(), LoggingLevel.Verbose);
		try
		{
			base.녴();
		}
		catch (Exception ex)
		{
			Core.Instance.Loggers.Log(ex);
		}
		Core.Instance.Loggers.Log(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴놜(), LoggingLevel.Verbose);
	}

	public Indicator CreateIndicator(string indicatorName, string assemblyName = "", string relativePath = "", ScriptCreationType scriptCreationType = ScriptCreationType.Custom)
	{
		if (string.IsNullOrEmpty(indicatorName))
		{
			throw new ArgumentNullException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴놨());
		}
		ScriptKey scriptKey = SearchScriptKey(indicatorName, assemblyName, relativePath, scriptCreationType);
		return CreateIndicator(scriptKey);
	}

	public Indicator CreateIndicator(ScriptKey scriptKey)
	{
		if (scriptsInfoCache.TryGetValue(scriptKey, out var value))
		{
			return CreateIndicator(value);
		}
		return null;
	}

	public Indicator CreateIndicator(IndicatorInfo indicatorInfo)
	{
		return indicatorInfo.녴();
	}

	protected override string GetScriptsFolderPath(ScriptCreationType scriptCreationType)
	{
		if (scriptCreationType != 0)
		{
			return Const.CUSTOM_INDICATORS_PATH;
		}
		return Path.Combine(Const.EXECUTING_FOLDER, Const.DEFAULT_INDICATORS_RELATIVE_PATH);
	}

	protected override IndicatorInfo CreateScriptInfo(ConstructorInfo ctor, ScriptCreationType scriptCreationType, string relativePath, string assemblyName)
	{
		return new IndicatorInfo(ctor, scriptCreationType, relativePath, assemblyName);
	}
}
