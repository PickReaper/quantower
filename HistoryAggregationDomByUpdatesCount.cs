using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using TradingPlatform.BusinessLayer.Integration;

namespace TradingPlatform.BusinessLayer;

public sealed class HistoryAggregationDomByUpdatesCount : HistoryAggregation
{
	private const string 놇놶 = "Ticks count";

	[CompilerGenerated]
	private int 놇뇏;

	public override string Name => _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸노();

	public int TicksCount
	{
		[CompilerGenerated]
		get
		{
			return 놇뇏;
		}
		[CompilerGenerated]
		private set
		{
			놇뇏 = value;
		}
	}

	public override IList<SettingItem> Settings
	{
		get
		{
			return new List<SettingItem>
			{
				new SettingItemInteger(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸녒(), TicksCount)
				{
					Minimum = 1,
					Increment = 1,
					SortIndex = 10
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
				if (item.Name == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸녒())
				{
					TicksCount = (int)item.Value;
				}
			}
		}
	}

	[NotPublished]
	public override Period GetPeriod => new Period(BasePeriod.Tick, TicksCount);

	[NotPublished]
	public override HistoryType GetHistoryType
	{
		get
		{
			throw new Exception(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸놤());
		}
	}

	public HistoryAggregationDomByUpdatesCount(int ticksCount)
	{
		TicksCount = ticksCount;
	}

	private HistoryAggregationDomByUpdatesCount(HistoryAggregationDomByUpdatesCount P_0)
		: base(P_0)
	{
		TicksCount = P_0.TicksCount;
	}

	[NotPublished]
	public override object Clone()
	{
		return new HistoryAggregationDomByUpdatesCount(this);
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

	public override HistoryAggregation GetAggregationToDirectDownload(HistoryMetadata metadata)
	{
		if (!metadata.AllowedAggregations.Contains(Name))
		{
			return null;
		}
		return this;
	}
}
