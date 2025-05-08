using System.Collections.Generic;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using TradingPlatform.BusinessLayer.History.Aggregations;
using TradingPlatform.BusinessLayer.Integration;

namespace TradingPlatform.BusinessLayer;

public sealed class HistoryAggregationPowerTrades : HistoryAggregation
{
	[CompilerGenerated]
	private readonly HistoryAggregationPowerTradesParameters 놇녧;

	public override string Name => _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놎놧();

	public HistoryAggregationPowerTradesParameters Parameters
	{
		[CompilerGenerated]
		get
		{
			return 놇녧;
		}
	}

	public override Period GetPeriod => Period.TICK1;

	public override HistoryType GetHistoryType => HistoryType.Last;

	[NotPublished]
	public override Period DefaultRange => Period.HOUR1;

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

	public HistoryAggregationPowerTrades()
	{
		놇녧 = new HistoryAggregationPowerTradesParameters();
	}

	public HistoryAggregationPowerTrades(HistoryAggregationPowerTradesParameters parameters)
		: this()
	{
		놇녧 = parameters;
	}

	protected HistoryAggregationPowerTrades(HistoryAggregationPowerTrades aggregation)
		: base(aggregation)
	{
		놇녧 = aggregation.Parameters?.Clone() as HistoryAggregationPowerTradesParameters;
	}

	[NotPublished]
	public override object Clone()
	{
		return new HistoryAggregationPowerTrades(this);
	}

	public override HistoryAggregation GetAggregationToDirectDownload(HistoryMetadata metadata)
	{
		return new HistoryAggregationTick(HistoryType.Last);
	}
}
