using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using TradingPlatform.BusinessLayer.Integration;

namespace TradingPlatform.BusinessLayer;

[Published]
public sealed class HistoryAggregationRangeBars : HistoryAggregation, IHistoryAggregationHistoryTypeSupport
{
	public const string SETTINGS_AGGREGATION_RANGE_BARS = "Range bars";

	[CompilerGenerated]
	private int 놇놷;

	[CompilerGenerated]
	private HistoryType 놇녗;

	public override string Name => _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놸();

	public int RangeBars
	{
		[CompilerGenerated]
		get
		{
			return 놇놷;
		}
		[CompilerGenerated]
		private set
		{
			놇놷 = value;
		}
	}

	public HistoryType HistoryType
	{
		[CompilerGenerated]
		get
		{
			return 놇녗;
		}
		[CompilerGenerated]
		set
		{
			놇녗 = value;
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
				new SelectItem(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놴(), 0),
				new SelectItem(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놂(), 1),
				new SelectItem(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놎(), 2)
			};
			return new List<SettingItem>
			{
				new SettingItemInteger(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놸(), RangeBars)
				{
					Minimum = 1,
					Increment = 1,
					SortIndex = 10,
					Text = _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놿()
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
				if (!(name == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놸()))
				{
					if (name == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿녶())
					{
						HistoryType = (HistoryType)(int)(object)((SelectItem)item.Value).Value;
					}
				}
				else
				{
					RangeBars = (int)item.Value;
				}
			}
		}
	}

	public override Period GetPeriod => Period.TICK1;

	[NotPublished]
	public override HistoryType GetHistoryType => HistoryType;

	public HistoryAggregationRangeBars(int rangeBars, HistoryType historyType)
	{
		RangeBars = rangeBars;
		HistoryType = historyType;
	}

	[NotPublished]
	public override string ToString()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 3);
		defaultInterpolatedStringHandler.AppendFormatted(Name);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴뇎());
		defaultInterpolatedStringHandler.AppendFormatted(RangeBars);
		defaultInterpolatedStringHandler.AppendFormatted(Period.BasePeriodToShortString(BasePeriod.Tick));
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	private HistoryAggregationRangeBars(HistoryAggregationRangeBars P_0)
		: base(P_0)
	{
		RangeBars = P_0.RangeBars;
		HistoryType = P_0.HistoryType;
	}

	[NotPublished]
	public override object Clone()
	{
		return new HistoryAggregationRangeBars(this);
	}

	[NotPublished]
	public override string FormatTime(DateTime dt)
	{
		return dt.ToString(DateTimeFormatInfo.CurrentInfo.ShortDatePattern + _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭녧());
	}

	public override HistoryAggregation GetAggregationToDirectDownload(HistoryMetadata metadata)
	{
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
}
