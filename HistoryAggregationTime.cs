using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using TradingPlatform.BusinessLayer.Integration;

namespace TradingPlatform.BusinessLayer;

[Published]
public class HistoryAggregationTime : HistoryAggregation, IHistoryAggregationHistoryTypeSupport
{
	[Serializable]
	[CompilerGenerated]
	private sealed class 녴
	{
		public static readonly 녴 놻녟 = new 녴();

		public static Func<HistoryType, SelectItem> 놻놱;

		internal SelectItem 녴(HistoryType P_0)
		{
			return new SelectItem(P_0.GetDescription(), (int)P_0);
		}
	}

	[CompilerGenerated]
	private Period 놇녫;

	[CompilerGenerated]
	private HistoryType 놇뇁;

	[CompilerGenerated]
	private bool 놇놧;

	public override string Name => _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놼();

	public Period Period
	{
		[CompilerGenerated]
		get
		{
			return 놇녫;
		}
		[CompilerGenerated]
		set
		{
			놇녫 = value;
		}
	}

	public HistoryType HistoryType
	{
		[CompilerGenerated]
		get
		{
			return 놇뇁;
		}
		[CompilerGenerated]
		set
		{
			놇뇁 = value;
		}
	}

	public bool UsePrevCloseAsOpenPriceBar
	{
		[CompilerGenerated]
		get
		{
			return 놇놧;
		}
		[CompilerGenerated]
		set
		{
			놇놧 = value;
		}
	}

	private protected virtual IList<HistoryType> SupportedHistoryTypes => new List<HistoryType>
	{
		HistoryType.Last,
		HistoryType.Mark,
		HistoryType.Bid,
		HistoryType.Ask,
		HistoryType.Midpoint
	};

	public override IList<SettingItem> Settings
	{
		get
		{
			List<SelectItem> list = SupportedHistoryTypes.Select((HistoryType P_0) => new SelectItem(P_0.GetDescription(), (int)P_0)).ToList();
			List<SettingItem> list2 = new List<SettingItem>();
			list2.Add(new SettingItemPeriod(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇁(), Period)
			{
				SortIndex = 10,
				ExcludedPeriods = new BasePeriod[1],
				Description = _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸녣()
			});
			list2.Add(new SettingItemSelectorLocalized(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿녶(), list.FirstOrDefault((SelectItem P_0) => (int)(object)P_0.Value == (int)HistoryType) ?? list.FirstOrDefault(), list)
			{
				SortIndex = 11
			});
			return list2;
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
					if (name == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿녶())
					{
						HistoryType = (HistoryType)(int)(object)((SelectItem)item.Value).Value;
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
	public override HistoryType GetHistoryType => HistoryType;

	[NotPublished]
	public override TimeScaleType TimeScaleType => TimeScaleType.Linear;

	[NotPublished]
	public override Period DefaultRange
	{
		get
		{
			if (Period.Ticks < 600000000)
			{
				return Period.DAY1;
			}
			if (Period.Ticks == 600000000)
			{
				return new Period(BasePeriod.Day, 3);
			}
			if (Period.Ticks <= 864000000000L)
			{
				return Period.MONTH1;
			}
			return new Period(BasePeriod.Year, 10);
		}
	}

	public HistoryAggregationTime(Period period, HistoryType historyType)
	{
		Period = period;
		HistoryType = historyType;
	}

	[NotPublished]
	public override string ToString()
	{
		return Name + _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴뇎() + Period.Format();
	}

	protected HistoryAggregationTime(HistoryAggregationTime aggregation)
		: base(aggregation)
	{
		Period = aggregation.Period;
		HistoryType = aggregation.HistoryType;
	}

	[NotPublished]
	public override object Clone()
	{
		return new HistoryAggregationTime(this);
	}

	[NotPublished]
	public override string FormatTime(DateTime dt)
	{
		return Period.Format(dt);
	}

	public override HistoryAggregation GetAggregationToDirectDownload(HistoryMetadata metadata)
	{
		if (metadata.AllowedAggregations.Contains(Name) && metadata.AllowedHistoryTypesHistoryAggregationTime.Contains(HistoryType))
		{
			if (metadata.AllowedPeriodsHistoryAggregationTime.Contains(Period))
			{
				return this;
			}
			if (metadata.AllowedBasePeriodsHistoryAggregationTime.Contains(Period.BasePeriod))
			{
				return new HistoryAggregationTime(Period, HistoryType);
			}
			Period period = metadata.AllowedPeriodsHistoryAggregationTime.FirstOrDefault((Period P_0) => Period.Ticks % P_0.Ticks == 0);
			if (period != default(Period))
			{
				return new HistoryAggregationTime(period, HistoryType);
			}
		}
		if (!metadata.AllowedAggregations.Contains(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭놀()))
		{
			return null;
		}
		HistoryType historyType = ((HistoryType == HistoryType.Ask || HistoryType == HistoryType.Bid) ? HistoryType.BidAsk : HistoryType);
		if (!metadata.AllowedHistoryTypesHistoryAggregationTick.Contains(historyType))
		{
			return null;
		}
		return new HistoryAggregationTick(historyType);
	}

	[CompilerGenerated]
	private bool 녴(SelectItem P_0)
	{
		return (int)(object)P_0.Value == (int)HistoryType;
	}

	[CompilerGenerated]
	private bool 녴(Period P_0)
	{
		return Period.Ticks % P_0.Ticks == 0;
	}
}
