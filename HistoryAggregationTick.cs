using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using TradingPlatform.BusinessLayer.Integration;

namespace TradingPlatform.BusinessLayer;

[Published]
public sealed class HistoryAggregationTick : HistoryAggregation, IHistoryAggregationHistoryTypeSupport
{
	[CompilerGenerated]
	private HistoryType 놇놅;

	public override string Name => _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭놀();

	public HistoryType HistoryType
	{
		[CompilerGenerated]
		get
		{
			return 놇놅;
		}
		[CompilerGenerated]
		set
		{
			놇놅 = value;
		}
	}

	public override IList<SettingItem> Settings
	{
		get
		{
			List<SelectItem> list = new List<SelectItem>
			{
				new SelectItem(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸녖(), 3),
				new SelectItem(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놵(), 4),
				new SelectItem(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿녴(), 5)
			};
			return new List<SettingItem>
			{
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
				if (item.Name == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿녶())
				{
					HistoryType = (HistoryType)(int)(object)((SelectItem)item.Value).Value;
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

	public HistoryAggregationTick(HistoryType historyType)
	{
		HistoryType = historyType;
	}

	public HistoryAggregationTick(HistoryAggregationTick aggregation)
		: base(aggregation)
	{
		HistoryType = aggregation.HistoryType;
	}

	[NotPublished]
	public override string ToString()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 2);
		defaultInterpolatedStringHandler.AppendFormatted(Name);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴뇎());
		defaultInterpolatedStringHandler.AppendFormatted(HistoryType);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	[NotPublished]
	public override string FormatTime(DateTime dt)
	{
		return dt.ToString(DateTimeFormatInfo.CurrentInfo.ShortDatePattern + _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭녤());
	}

	[NotPublished]
	public override object Clone()
	{
		return new HistoryAggregationTick(this);
	}

	public override HistoryAggregation GetAggregationToDirectDownload(HistoryMetadata metadata)
	{
		if (!metadata.AllowedAggregations.Contains(Name))
		{
			return null;
		}
		if (!metadata.AllowedHistoryTypesHistoryAggregationTick.Contains(HistoryType))
		{
			return null;
		}
		return this;
	}

	[CompilerGenerated]
	private bool 녴(SelectItem P_0)
	{
		return (int)(object)P_0.Value == (int)HistoryType;
	}
}
