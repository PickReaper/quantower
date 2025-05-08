using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using TradingPlatform.BusinessLayer.Integration;

namespace TradingPlatform.BusinessLayer;

public sealed class HistoryAggregationTickLastAggregated : HistoryAggregation
{
	[CompilerGenerated]
	private TimeSpan 놇놮;

	public override string Name => _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놻();

	public override Period GetPeriod => Period.TICK1;

	public override HistoryType GetHistoryType => HistoryType.Last;

	public TimeSpan TimeDelay
	{
		[CompilerGenerated]
		get
		{
			return 놇놮;
		}
		[CompilerGenerated]
		set
		{
			놇놮 = value;
		}
	}

	public override IList<SettingItem> Settings
	{
		get
		{
			return new List<SettingItem>
			{
				new SettingItemInteger(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놃(), (int)TimeDelay.TotalMilliseconds)
				{
					SortIndex = 10,
					Text = loc._(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿뇇(), null, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놛()),
					Minimum = 1
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
				if (item.Name == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놃())
				{
					TimeDelay = TimeSpan.FromMilliseconds((int)item.Value);
				}
			}
		}
	}

	[NotPublished]
	public override Period DefaultRange => Period.HOUR1;

	public HistoryAggregationTickLastAggregated()
	{
		TimeDelay = TimeSpan.FromMilliseconds(500.0);
	}

	public HistoryAggregationTickLastAggregated(HistoryAggregationTickLastAggregated original)
	{
		TimeDelay = original.TimeDelay;
	}

	public override object Clone()
	{
		return new HistoryAggregationTickLastAggregated(this);
	}

	[NotPublished]
	public override string FormatTime(DateTime dt)
	{
		return dt.ToString(DateTimeFormatInfo.CurrentInfo.ShortDatePattern + _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭녤());
	}

	public override HistoryAggregation GetAggregationToDirectDownload(HistoryMetadata metadata)
	{
		return new HistoryAggregationTick(HistoryType.Last);
	}
}
