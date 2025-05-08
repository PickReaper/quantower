using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using TradingPlatform.BusinessLayer.History.Aggregations;
using TradingPlatform.BusinessLayer.Integration;

namespace TradingPlatform.BusinessLayer;

public sealed class HistoryAggregationVwap : HistoryAggregation
{
	[CompilerGenerated]
	private readonly HistoryAggregationVwapParameters 놇놦;

	public override string Name => _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿녡();

	public HistoryAggregationVwapParameters Parameters
	{
		[CompilerGenerated]
		get
		{
			return 놇놦;
		}
	}

	public override TimeScaleType TimeScaleType => Parameters.Aggregation.TimeScaleType;

	public override Period DefaultRange => Period.HOUR1;

	public override Period GetPeriod
	{
		get
		{
			if (Parameters.DataType == VwapDataType.Tick)
			{
				return Period.TICK1;
			}
			return Parameters.Aggregation.GetPeriod;
		}
	}

	public override HistoryType GetHistoryType => Parameters.Aggregation.GetHistoryType;

	public override IList<SettingItem> Settings
	{
		get
		{
			return Parameters?.Settings ?? new List<SettingItem>();
		}
		set
		{
			if (Parameters != null)
			{
				Parameters.Settings = value;
			}
		}
	}

	public HistoryAggregationVwap()
	{
		놇놦 = new HistoryAggregationVwapParameters();
	}

	public HistoryAggregationVwap(HistoryAggregationVwapParameters parameters)
		: this()
	{
		놇놦 = new HistoryAggregationVwapParameters(parameters);
	}

	protected HistoryAggregationVwap(HistoryAggregationVwap aggregation)
		: base(aggregation)
	{
		놇놦 = new HistoryAggregationVwapParameters(aggregation.Parameters);
	}

	[NotPublished]
	public override object Clone()
	{
		return new HistoryAggregationVwap(this);
	}

	public override HistoryAggregation GetAggregationToDirectDownload(HistoryMetadata metadata)
	{
		if (Parameters.DataType == VwapDataType.Tick)
		{
			if (!metadata.AllowedHistoryTypesHistoryAggregationTick.Contains(HistoryType.Last))
			{
				return null;
			}
			return new HistoryAggregationTick(HistoryType.Last);
		}
		return Parameters.Aggregation.GetAggregationToDirectDownload(metadata);
	}
}
