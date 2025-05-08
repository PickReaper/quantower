using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;

namespace TradingPlatform.BusinessLayer;

public sealed class HistoryAggregationManager
{
	private const string 농 = "HistoryProcessors";

	private Dictionary<string, HistoryAggregation> 념;

	public HistoryAggregation[] All => 념.Values.ToArray();

	public HistoryAggregation this[string aggregatorName]
	{
		get
		{
			if (념.TryGetValue(aggregatorName, out var value))
			{
				return value;
			}
			return null;
		}
	}

	internal HistoryAggregationManager()
	{
		념 = new Dictionary<string, HistoryAggregation>();
	}

	internal void 녴()
	{
		Core.Instance.Loggers.Log(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놩(), LoggingLevel.Verbose);
		List<TypeWrapper> list = AssemblyLoader.LoadTypes(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녡(), typeof(IHistoryProcessor), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녦(), SearchOption.AllDirectories);
		if (list == null)
		{
			return;
		}
		foreach (TypeWrapper item in list)
		{
			Type type = item;
			try
			{
				MethodInfo method = type.GetMethod(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놀(), BindingFlags.Static | BindingFlags.Public);
				if (method == null)
				{
					Core.Instance.Loggers.Log(type.Name + _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놔(), LoggingLevel.Verbose);
					continue;
				}
				if (!(method.Invoke(null, null) is HistoryAggregation historyAggregation))
				{
					Core.Instance.Loggers.Log(type.Name + _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놾(), LoggingLevel.Verbose);
					continue;
				}
				if (념.ContainsKey(historyAggregation.Name))
				{
					Core.Instance.Loggers.Log(type.Name + _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇀(), LoggingLevel.Verbose);
					continue;
				}
				historyAggregation.HistoryProcessorType = type;
				념.Add(historyAggregation.Name, historyAggregation);
			}
			catch (Exception ex)
			{
				Core.Instance.Loggers.Log(ex);
			}
		}
		Core.Instance.Loggers.Log(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놽(), LoggingLevel.Verbose);
	}

	public IHistoryProcessor CreateHistoryProcessor(HistoryRequestParameters parameter)
	{
		if (parameter == null)
		{
			throw new ArgumentNullException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녿());
		}
		if (parameter.Aggregation == null)
		{
			throw new ArgumentNullException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놁());
		}
		HistoryAggregation historyAggregation = this[parameter.Aggregation.Name];
		if (historyAggregation == null)
		{
			throw new ArgumentException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녭() + parameter.Aggregation.Name);
		}
		try
		{
			IHistoryProcessor obj = Activator.CreateInstance(historyAggregation.HistoryProcessorType) as IHistoryProcessor;
			obj?.Initialize(parameter.Copy);
			return obj;
		}
		catch (Exception ex)
		{
			Core.Instance.Loggers.Log(ex);
		}
		return null;
	}

	internal void 놴()
	{
		if (념 != null)
		{
			념.Clear();
			념 = null;
		}
	}
}
