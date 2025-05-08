using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using TradingPlatform.BusinessLayer.Integration;

namespace TradingPlatform.BusinessLayer;

public sealed class HistoryAggregationTickBars : HistoryAggregation, IHistoryAggregationHistoryTypeSupport
{
	private const string 놇녜 = "Ticks count";

	[CompilerGenerated]
	private int 놇뇃;

	[CompilerGenerated]
	private HistoryType 놇녯;

	public override string Name => _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녲녯();

	public int TicksCount
	{
		[CompilerGenerated]
		get
		{
			return 놇뇃;
		}
		[CompilerGenerated]
		private set
		{
			놇뇃 = value;
		}
	}

	public HistoryType HistoryType
	{
		[CompilerGenerated]
		get
		{
			return 놇녯;
		}
		[CompilerGenerated]
		set
		{
			놇녯 = value;
		}
	}

	public override bool IsWaitingFirstQuoteRequired => true;

	public override IList<SettingItem> Settings
	{
		get
		{
			List<SelectItem> list = new List<SelectItem>
			{
				new SelectItem(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸녖(), 3),
				new SelectItem(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿녴(), 5),
				new SelectItem(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놴(), 0),
				new SelectItem(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놂(), 1),
				new SelectItem(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놎(), 2),
				new SelectItem(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놡(), 4)
			};
			return new List<SettingItem>
			{
				new SettingItemInteger(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸녒(), TicksCount)
				{
					Minimum = 1,
					Increment = 1,
					SortIndex = 10
				},
				new SettingItemSelectorLocalized(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿녶(), list.FirstOrDefault((SelectItem P_0) => (int)(object)P_0.Value == (int)HistoryType) ?? list.FirstOrDefault(), list)
				{
					SortIndex = 11
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
				if (!(name == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸녒()))
				{
					if (name == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿녶())
					{
						HistoryType = (HistoryType)(int)(object)((SelectItem)item.Value).Value;
					}
				}
				else
				{
					TicksCount = (int)item.Value;
				}
			}
		}
	}

	[NotPublished]
	public override Period DefaultRange => Period.HOUR1;

	[NotPublished]
	public override Period GetPeriod => new Period(BasePeriod.Tick, TicksCount);

	[NotPublished]
	public override HistoryType GetHistoryType => HistoryType;

	public HistoryAggregationTickBars(int ticksCount, HistoryType historyType)
	{
		TicksCount = ticksCount;
		HistoryType = historyType;
	}

	public HistoryAggregationTickBars(HistoryAggregationTickBars aggregation)
		: base(aggregation)
	{
		TicksCount = aggregation.TicksCount;
		HistoryType = aggregation.HistoryType;
	}

	[NotPublished]
	public override string ToString()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 3);
		defaultInterpolatedStringHandler.AppendFormatted(Name);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴뇎());
		defaultInterpolatedStringHandler.AppendFormatted(TicksCount);
		defaultInterpolatedStringHandler.AppendFormatted(Period.BasePeriodToShortString(BasePeriod.Tick));
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	[NotPublished]
	public override string FormatTime(DateTime dt)
	{
		return dt.ToString(DateTimeFormatInfo.CurrentInfo.ShortDatePattern + _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놀() + ((TicksCount > 1) ? _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿뇋() : _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿녲()));
	}

	[NotPublished]
	public override object Clone()
	{
		return new HistoryAggregationTickBars(this);
	}

	public override HistoryAggregation GetAggregationToDirectDownload(HistoryMetadata metadata)
	{
		if (metadata.AllowedAggregations.Contains(Name))
		{
			return this;
		}
		HistoryType historyType = HistoryType;
		if (!metadata.AllowedHistoryTypesHistoryAggregationTick.Contains(historyType))
		{
			return null;
		}
		return new HistoryAggregationTick(HistoryType);
	}

	[CompilerGenerated]
	private bool 녴(SelectItem P_0)
	{
		return (int)(object)P_0.Value == (int)HistoryType;
	}
}
