using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using TradingPlatform.BusinessLayer.Utils;

namespace TradingPlatform.BusinessLayer;

[Published]
public class VolumeAnalysisData
{
	[CompilerGenerated]
	private DateTime 놂녤;

	[CompilerGenerated]
	private VolumeAnalysisItem 놂놆;

	[CompilerGenerated]
	private Dictionary<double, VolumeAnalysisItem> 놂뇎;

	[CompilerGenerated]
	private EventHandler<VolumeAnalysisDataEventArgs> 놂놷;

	public DateTime TimeLeft
	{
		[CompilerGenerated]
		get
		{
			return 놂녤;
		}
		[CompilerGenerated]
		set
		{
			놂녤 = value;
		}
	}

	/// <summary>
	/// Summary calculated Volume info
	/// </summary>
	public VolumeAnalysisItem Total
	{
		[CompilerGenerated]
		get
		{
			return 놂놆;
		}
		[CompilerGenerated]
		set
		{
			놂놆 = value;
		}
	}

	/// <summary>
	/// Volume info for each price
	/// </summary>
	public Dictionary<double, VolumeAnalysisItem> PriceLevels
	{
		[CompilerGenerated]
		get
		{
			return 놂뇎;
		}
		[CompilerGenerated]
		set
		{
			놂뇎 = value;
		}
	}

	/// <summary>
	/// Fire in case of price level was added or existing was updated
	/// </summary>
	public event EventHandler<VolumeAnalysisDataEventArgs> ItemUpdated
	{
		[CompilerGenerated]
		add
		{
			EventHandler<VolumeAnalysisDataEventArgs> eventHandler = 놂놷;
			EventHandler<VolumeAnalysisDataEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<VolumeAnalysisDataEventArgs> value2 = (EventHandler<VolumeAnalysisDataEventArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref 놂놷, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<VolumeAnalysisDataEventArgs> eventHandler = 놂놷;
			EventHandler<VolumeAnalysisDataEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<VolumeAnalysisDataEventArgs> value2 = (EventHandler<VolumeAnalysisDataEventArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref 놂놷, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public VolumeAnalysisData()
	{
		Total = new VolumeAnalysisItem();
		PriceLevels = new Dictionary<double, VolumeAnalysisItem>();
	}

	internal VolumeAnalysisData(VolumeAnalysisData P_0)
	{
		TimeLeft = P_0.TimeLeft;
		Total = new VolumeAnalysisItem(P_0.Total);
		PriceLevels = new Dictionary<double, VolumeAnalysisItem>();
		foreach (KeyValuePair<double, VolumeAnalysisItem> priceLevel in P_0.PriceLevels)
		{
			PriceLevels.Add(priceLevel.Key, new VolumeAnalysisItem(priceLevel.Value));
		}
	}

	internal void 녴(VolumeAnalysisCalculationRequest P_0, HistoricalData P_1)
	{
		foreach (object item in P_1)
		{
			녴(P_0, item);
		}
	}

	internal void 녴(VolumeAnalysisCalculationRequest P_0, MessageQuote P_1)
	{
		녴(P_0, (object)P_1);
	}

	internal void 녴(VolumeAnalysisCalculationRequest P_0, IVolumeTickData P_1)
	{
		녴(P_0, (object)P_1);
	}

	internal void 녴(VolumeAnalysisCalculationRequest P_0, object P_1)
	{
		if (!(P_1 is IVolumeTickData { Price: var price, Volume: var volume } volumeTickData))
		{
			return;
		}
		AggressorFlag aggressorFlag = ((P_0.DeltaCalculationType == DeltaCalculationType.TickDirection) ? Symbol.ConvertTickDirection(volumeTickData.TickDirection) : volumeTickData.AggressorFlag);
		bool flag = volumeTickData.VolumeTickDataType == VolumeTickDataType.Ticks;
		long time = volumeTickData.Time;
		if (P_0.SessionsContainer == null || P_0.SessionsContainer.ContainsDate(time))
		{
			double num = P_0.Symbol.GetTickSize(price);
			if (!P_0.CustomTickSize.IsNanOrDefault())
			{
				num = P_0.CustomTickSize;
			}
			if (P_0.CustomStep > 1)
			{
				num *= (double)P_0.CustomStep;
			}
			if (!double.IsNaN(P_0.Symbol.MinVolumeAnalysisTickSize) && num < P_0.Symbol.MinVolumeAnalysisTickSize)
			{
				num = P_0.Symbol.MinVolumeAnalysisTickSize;
			}
			double num2 = CoreMath.RoundToIncrement(price, num);
			녴(num2, volume, aggressorFlag, flag, P_0.FilteredVolume);
		}
	}

	private void 녴(double P_0, double P_1, AggressorFlag P_2, bool P_3, double P_4)
	{
		Total.녴(P_1, P_2, P_3, P_4);
		if (!PriceLevels.TryGetValue(P_0, out var value))
		{
			PriceLevels.Add(P_0, value = new VolumeAnalysisItem());
		}
		value.녴(P_1, P_2, P_3, P_4);
		녴(P_0, value);
	}

	public void Calculate(double price, double size, AggressorFlag aggressorFlag)
	{
		녴(price, size, aggressorFlag, false, 0.0);
	}

	public VolumeAnalysisData CreateAggregatedSnapshot(double aggregationStep)
	{
		VolumeAnalysisData volumeAnalysisData = new VolumeAnalysisData();
		try
		{
			volumeAnalysisData.Total = Total;
			foreach (KeyValuePair<double, VolumeAnalysisItem> priceLevel in PriceLevels)
			{
				double key = CoreMath.RoundToIncrement(priceLevel.Key, aggregationStep);
				if (!volumeAnalysisData.PriceLevels.TryGetValue(key, out var value))
				{
					volumeAnalysisData.PriceLevels.Add(key, value = new VolumeAnalysisItem());
				}
				value.Combine(priceLevel.Value);
			}
		}
		catch (Exception ex)
		{
			Core.Instance.Loggers.Log(ex);
		}
		return volumeAnalysisData;
	}

	private void 녴(double P_0, VolumeAnalysisItem P_1)
	{
		놂놷?.Invoke(this, new VolumeAnalysisDataEventArgs(P_0, P_1));
	}

	public void Combine(VolumeAnalysisData data)
	{
		Total.Combine(data.Total);
		foreach (KeyValuePair<double, VolumeAnalysisItem> priceLevel in data.PriceLevels)
		{
			if (!PriceLevels.TryGetValue(priceLevel.Key, out var value))
			{
				value = (PriceLevels[priceLevel.Key] = new VolumeAnalysisItem());
			}
			value.Combine(priceLevel.Value);
		}
	}

	public override string ToString()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(15, 2);
		defaultInterpolatedStringHandler.AppendFormatted(TimeLeft);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂녹());
		defaultInterpolatedStringHandler.AppendFormatted(PriceLevels.Count);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂녔());
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}
}
