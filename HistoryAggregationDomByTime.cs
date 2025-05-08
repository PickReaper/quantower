using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using TradingPlatform.BusinessLayer.Integration;

namespace TradingPlatform.BusinessLayer;

public sealed class HistoryAggregationDomByTime : HistoryAggregation
{
	[CompilerGenerated]
	private Period 놇높;

	public override string Name => _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸녘();

	public Period Period
	{
		[CompilerGenerated]
		get
		{
			return 놇높;
		}
		[CompilerGenerated]
		private set
		{
			놇높 = value;
		}
	}

	public override IList<SettingItem> Settings
	{
		get
		{
			List<SettingItem> list = new List<SettingItem>();
			list.Add(new SettingItemPeriod(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇁(), Period)
			{
				SortIndex = 10,
				ExcludedPeriods = new BasePeriod[1],
				Description = _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸녣()
			});
			return list;
		}
		set
		{
			if (value == null)
			{
				return;
			}
			foreach (SettingItem item in value)
			{
				if (item.Name == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇁())
				{
					Period = (Period)item.Value;
				}
			}
		}
	}

	[NotPublished]
	public override Period GetPeriod => Period;

	[NotPublished]
	public override HistoryType GetHistoryType
	{
		get
		{
			throw new Exception(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸놤());
		}
	}

	public HistoryAggregationDomByTime(Period period)
	{
		Period = period;
	}

	protected HistoryAggregationDomByTime(HistoryAggregationDomByTime aggregation)
		: base(aggregation)
	{
		Period = aggregation.Period;
	}

	[NotPublished]
	public override object Clone()
	{
		return new HistoryAggregationDomByTime(this);
	}

	[NotPublished]
	public override string ToString()
	{
		return Name + _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴뇎() + Period.Format();
	}

	public override HistoryAggregation GetAggregationToDirectDownload(HistoryMetadata metadata)
	{
		if (!metadata.AllowedAggregations.Contains(Name))
		{
			return null;
		}
		return this;
	}
}
