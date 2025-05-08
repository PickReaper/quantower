using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using TradingPlatform.BusinessLayer.Integration;

namespace TradingPlatform.BusinessLayer;

public sealed class HistoryAggregationDomAggregated : HistoryAggregation
{
	private const string 놇녭 = "Price levels limit";

	[CompilerGenerated]
	private Period 놇녱;

	[CompilerGenerated]
	private int 놇놲;

	public override string Name => _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸놋();

	public Period Period
	{
		[CompilerGenerated]
		get
		{
			return 놇녱;
		}
		[CompilerGenerated]
		private set
		{
			놇녱 = value;
		}
	}

	public int PriceLevelsLimit
	{
		[CompilerGenerated]
		get
		{
			return 놇놲;
		}
		[CompilerGenerated]
		private set
		{
			놇놲 = value;
		}
	}

	public override IList<SettingItem> Settings
	{
		get
		{
			return new List<SettingItem>
			{
				new SettingItemPeriod(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇁(), Period)
				{
					SortIndex = 10,
					Description = _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸녣()
				},
				new SettingItemInteger(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸녩(), PriceLevelsLimit)
				{
					SortIndex = 11,
					Minimum = 0,
					Maximum = 1000
				}
			};
		}
		set
		{
			if (value == null)
			{
				return;
			}
			foreach (SettingItem item in value)
			{
				string name = item.Name;
				if (!(name == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇁()))
				{
					if (name == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸녩())
					{
						PriceLevelsLimit = (int)item.Value;
					}
				}
				else
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

	public HistoryAggregationDomAggregated(Period period)
	{
		Period = period;
	}

	protected HistoryAggregationDomAggregated(HistoryAggregationDomAggregated aggregation)
		: base(aggregation)
	{
		Period = aggregation.Period;
		PriceLevelsLimit = aggregation.PriceLevelsLimit;
	}

	[NotPublished]
	public override object Clone()
	{
		return new HistoryAggregationDomAggregated(this);
	}

	[NotPublished]
	public override string ToString()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(13, 3);
		defaultInterpolatedStringHandler.AppendFormatted(Name);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴뇎());
		defaultInterpolatedStringHandler.AppendFormatted(Period.Format());
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴뇎());
		defaultInterpolatedStringHandler.AppendFormatted(PriceLevelsLimit);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸논());
		return defaultInterpolatedStringHandler.ToStringAndClear();
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
