using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using TradingPlatform.BusinessLayer.Integration;

namespace TradingPlatform.BusinessLayer;

public sealed class HistoryAggregationPriceChangesCountBars : HistoryAggregation, IHistoryAggregationHistoryTypeSupport
{
	private const string 놇녤 = "Ticks count";

	[CompilerGenerated]
	private int 놇놆;

	[CompilerGenerated]
	private HistoryType 놇뇎;

	public override string Name => _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놭();

	public int PriceChangesCount
	{
		[CompilerGenerated]
		get
		{
			return 놇놆;
		}
		[CompilerGenerated]
		private set
		{
			놇놆 = value;
		}
	}

	public HistoryType HistoryType
	{
		[CompilerGenerated]
		get
		{
			return 놇뇎;
		}
		[CompilerGenerated]
		set
		{
			놇뇎 = value;
		}
	}

	public override IList<SettingItem> Settings
	{
		get
		{
			List<SelectItem> list = new List<SelectItem>
			{
				new SelectItem(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸녖(), 3),
				new SelectItem(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿녴(), 5),
				new SelectItem(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놂(), 1),
				new SelectItem(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놴(), 0)
			};
			return new List<SettingItem>
			{
				new SettingItemInteger(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸녒(), PriceChangesCount)
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
					PriceChangesCount = (int)item.Value;
				}
			}
		}
	}

	[NotPublished]
	public override Period DefaultRange => Period.HOUR1;

	[NotPublished]
	public override Period GetPeriod => Period.TICK1;

	[NotPublished]
	public override HistoryType GetHistoryType => HistoryType;

	public HistoryAggregationPriceChangesCountBars(int priceChangesCount, HistoryType historyType)
	{
		PriceChangesCount = priceChangesCount;
		HistoryType = historyType;
	}

	public HistoryAggregationPriceChangesCountBars(HistoryAggregationPriceChangesCountBars aggregation)
		: base(aggregation)
	{
		PriceChangesCount = aggregation.PriceChangesCount;
		HistoryType = aggregation.HistoryType;
	}

	[NotPublished]
	public override string ToString()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 3);
		defaultInterpolatedStringHandler.AppendFormatted(Name);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴뇎());
		defaultInterpolatedStringHandler.AppendFormatted(PriceChangesCount);
		defaultInterpolatedStringHandler.AppendFormatted(Period.BasePeriodToShortString(BasePeriod.Tick));
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	[NotPublished]
	public override string FormatTime(DateTime dt)
	{
		return dt.ToString(DateTimeFormatInfo.CurrentInfo.ShortDatePattern + _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놀() + ((PriceChangesCount > 1) ? _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿뇋() : _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿녲()));
	}

	[NotPublished]
	public override object Clone()
	{
		return new HistoryAggregationPriceChangesCountBars(this);
	}

	public override HistoryAggregation GetAggregationToDirectDownload(HistoryMetadata metadata)
	{
		if (!metadata.AllowedAggregations.Contains(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭놀()))
		{
			return null;
		}
		HistoryType value = ((HistoryType == HistoryType.Ask || HistoryType == HistoryType.Bid) ? HistoryType.BidAsk : HistoryType);
		if (!metadata.AllowedHistoryTypesHistoryAggregationTick.Contains(value))
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
