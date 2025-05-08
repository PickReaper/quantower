using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using TradingPlatform.BusinessLayer.Integration;

namespace TradingPlatform.BusinessLayer;

[Published]
public sealed class HistoryAggregationHeikenAshi : HistoryAggregation, IHistoryAggregationHistoryTypeSupport
{
	[Serializable]
	[CompilerGenerated]
	private sealed class 녴
	{
		public static readonly 녴 놻념 = new 녴();

		public static Func<HeikenAshiSource, SelectItem> 놻녨;

		internal SelectItem 녴(HeikenAshiSource P_0)
		{
			return new SelectItem(P_0.ToString(), P_0);
		}
	}

	[CompilerGenerated]
	private int 놇녻;

	[CompilerGenerated]
	private HeikenAshiSource 놇녙;

	[CompilerGenerated]
	private HistoryType 놇놢;

	public override string Name => _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸녕();

	public int Value
	{
		[CompilerGenerated]
		get
		{
			return 놇녻;
		}
		[CompilerGenerated]
		set
		{
			놇녻 = value;
		}
	}

	public HeikenAshiSource Source
	{
		[CompilerGenerated]
		get
		{
			return 놇녙;
		}
		[CompilerGenerated]
		set
		{
			놇녙 = value;
		}
	}

	[NotPublished]
	public override TimeScaleType TimeScaleType
	{
		get
		{
			HeikenAshiSource source = Source;
			if (source == HeikenAshiSource.Tick || source == HeikenAshiSource.Volume)
			{
				return TimeScaleType.NonLinear;
			}
			return TimeScaleType.Linear;
		}
	}

	public HistoryType HistoryType
	{
		[CompilerGenerated]
		get
		{
			return 놇놢;
		}
		[CompilerGenerated]
		set
		{
			놇놢 = value;
		}
	}

	public override IList<SettingItem> Settings
	{
		get
		{
			List<SelectItem> list = (from HeikenAshiSource P_0 in Enum.GetValues(typeof(HeikenAshiSource))
				select new SelectItem(P_0.ToString(), P_0)).ToList();
			List<SelectItem> list2 = new List<SelectItem>
			{
				new SelectItem(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸녖(), 3),
				new SelectItem(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿녴(), 5),
				new SelectItem(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놴(), 0),
				new SelectItem(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놂(), 1),
				new SelectItem(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놎(), 2)
			};
			return new List<SettingItem>
			{
				new SettingItemInteger(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂뇄(), Value)
				{
					Text = loc._(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴놯(), null, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿녞()),
					Minimum = 1
				},
				new SettingItemSelectorLocalized(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놫(), list.FirstOrDefault((SelectItem P_0) => P_0.Value.Equals(Source)), list)
				{
					Text = loc._(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿녪(), null, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿녞())
				},
				new SettingItemSelectorLocalized(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿녶(), list2.FirstOrDefault((SelectItem P_0) => (int)(object)P_0.Value == (int)HistoryType) ?? list2.FirstOrDefault(), list2)
				{
					SortIndex = 11
				}
			};
		}
		set
		{
			Value = value.GetValueOrDefault(Value, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂뇄());
			Source = value.GetValueOrDefault(Source, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놫());
			HistoryType = value.GetValueOrDefault(HistoryType, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿녶());
		}
	}

	[NotPublished]
	public override Period GetPeriod
	{
		get
		{
			if (Source != HeikenAshiSource.Volume)
			{
				return new Period((BasePeriod)Source, Value);
			}
			return Period.TICK1;
		}
	}

	[NotPublished]
	public override HistoryType GetHistoryType => HistoryType;

	[NotPublished]
	public override Period DefaultRange
	{
		get
		{
			if (Source == HeikenAshiSource.Volume || Source == HeikenAshiSource.Tick)
			{
				return Period.HOUR1;
			}
			if (Source <= HeikenAshiSource.Minute)
			{
				return Period.DAY1;
			}
			if (Source <= HeikenAshiSource.Day)
			{
				return Period.MONTH1;
			}
			return new Period(BasePeriod.Year, 10);
		}
	}

	public HistoryAggregationHeikenAshi(HeikenAshiSource source, int value, HistoryType historyType)
	{
		Source = source;
		Value = value;
		HistoryType = historyType;
	}

	[NotPublished]
	public override string FormatTime(DateTime dt)
	{
		return GetPeriod.Format(dt);
	}

	[NotPublished]
	public override string ToString()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 3);
		defaultInterpolatedStringHandler.AppendFormatted(Name);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴뇎());
		defaultInterpolatedStringHandler.AppendFormatted(Value);
		defaultInterpolatedStringHandler.AppendFormatted((Source == HeikenAshiSource.Volume) ? _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놤() : Period.BasePeriodToShortString((BasePeriod)Source));
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	protected HistoryAggregationHeikenAshi(HistoryAggregationHeikenAshi aggregation)
		: base(aggregation)
	{
		Source = aggregation.Source;
		Value = aggregation.Value;
		HistoryType = aggregation.HistoryType;
	}

	[NotPublished]
	public override object Clone()
	{
		return new HistoryAggregationHeikenAshi(this);
	}

	public override HistoryAggregation GetAggregationToDirectDownload(HistoryMetadata metadata)
	{
		return (Source switch
		{
			HeikenAshiSource.Volume => new HistoryAggregationVolume(Value), 
			HeikenAshiSource.Tick => new HistoryAggregationTickBars(Value, HistoryType), 
			_ => new HistoryAggregationTime(new Period((BasePeriod)Source, Value), HistoryType), 
		}).GetAggregationToDirectDownload(metadata);
	}

	[CompilerGenerated]
	private bool 녴(SelectItem P_0)
	{
		return P_0.Value.Equals(Source);
	}

	[CompilerGenerated]
	private bool 놴(SelectItem P_0)
	{
		return (int)(object)P_0.Value == (int)HistoryType;
	}
}
