using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using TradingPlatform.BusinessLayer.Modules;
using TradingPlatform.BusinessLayer.Modules.PlaceOrderStrategies;
using TradingPlatform.BusinessLayer.Utils;

namespace TradingPlatform.BusinessLayer;

public sealed class OrderPlacingStrategiesManager : ScriptManager<OrderPlacingStrategyInfo, OrderPlacingStrategy>
{
	private readonly List<OrderPlacingStrategy> 녖;

	[CompilerGenerated]
	private Action<OrderPlacingStrategy> 놴녴;

	[CompilerGenerated]
	private Action<OrderPlacingStrategy> 놴놴;

	public OrderPlacingStrategy[] Created => 녖.ToArray();

	public override string CustomScriptsPath => Const.CUSTOM_PLACE_ORDER_STRATEGIES_PATH;

	protected override string DefaultScriptsPath => Const.DEFAULT_PLACE_ORDER_STRATEGIES_RELATIVE_PATH;

	public event Action<OrderPlacingStrategy> StrategyCreated
	{
		[CompilerGenerated]
		add
		{
			Action<OrderPlacingStrategy> action = 놴녴;
			Action<OrderPlacingStrategy> action2;
			do
			{
				action2 = action;
				Action<OrderPlacingStrategy> value2 = (Action<OrderPlacingStrategy>)Delegate.Combine(action2, value);
				action = Interlocked.CompareExchange(ref 놴녴, value2, action2);
			}
			while ((object)action != action2);
		}
		[CompilerGenerated]
		remove
		{
			Action<OrderPlacingStrategy> action = 놴녴;
			Action<OrderPlacingStrategy> action2;
			do
			{
				action2 = action;
				Action<OrderPlacingStrategy> value2 = (Action<OrderPlacingStrategy>)Delegate.Remove(action2, value);
				action = Interlocked.CompareExchange(ref 놴녴, value2, action2);
			}
			while ((object)action != action2);
		}
	}

	public event Action<OrderPlacingStrategy> StrategyRemoved
	{
		[CompilerGenerated]
		add
		{
			Action<OrderPlacingStrategy> action = 놴놴;
			Action<OrderPlacingStrategy> action2;
			do
			{
				action2 = action;
				Action<OrderPlacingStrategy> value2 = (Action<OrderPlacingStrategy>)Delegate.Combine(action2, value);
				action = Interlocked.CompareExchange(ref 놴놴, value2, action2);
			}
			while ((object)action != action2);
		}
		[CompilerGenerated]
		remove
		{
			Action<OrderPlacingStrategy> action = 놴놴;
			Action<OrderPlacingStrategy> action2;
			do
			{
				action2 = action;
				Action<OrderPlacingStrategy> value2 = (Action<OrderPlacingStrategy>)Delegate.Remove(action2, value);
				action = Interlocked.CompareExchange(ref 놴놴, value2, action2);
			}
			while ((object)action != action2);
		}
	}

	public OrderPlacingStrategiesManager()
	{
		녖 = new List<OrderPlacingStrategy>();
	}

	internal override void 녴()
	{
		Core.Instance.Loggers.Log(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴녢(), LoggingLevel.Verbose);
		try
		{
			base.녴();
		}
		catch (Exception ex)
		{
			Core.Instance.Loggers.Log(ex);
		}
		Core.Instance.Loggers.Log(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴놞(), LoggingLevel.Verbose);
	}

	protected override OrderPlacingStrategyInfo CreateScriptInfo(ConstructorInfo ctor, ScriptCreationType scriptCreationType, string relativePath, string assemblyName)
	{
		return new OrderPlacingStrategyInfo(ctor, scriptCreationType, relativePath, assemblyName);
	}

	protected override string GetScriptsFolderPath(ScriptCreationType scriptCreationType)
	{
		if (scriptCreationType != 0)
		{
			return Const.CUSTOM_PLACE_ORDER_STRATEGIES_PATH;
		}
		return Path.Combine(Const.EXECUTING_FOLDER, Const.DEFAULT_PLACE_ORDER_STRATEGIES_RELATIVE_PATH);
	}

	public OrderPlacingStrategy CreateStrategy(OrderPlacingStrategyInfo orderPlacingStrategyInfo)
	{
		OrderPlacingStrategy orderPlacingStrategy = orderPlacingStrategyInfo.녴();
		녖.Add(orderPlacingStrategy);
		놴녴?.Invoke(orderPlacingStrategy);
		return orderPlacingStrategy;
	}

	internal void 녴(OrderPlacingStrategy P_0)
	{
		if (녖.Remove(P_0))
		{
			P_0.Dispose();
			놴놴?.Invoke(P_0);
		}
	}
}
