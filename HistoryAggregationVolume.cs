using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using TradingPlatform.BusinessLayer.Integration;

namespace TradingPlatform.BusinessLayer;

public sealed class HistoryAggregationVolume : HistoryAggregation
{
	public const string SETTINGS_AGGREGATION_VOLUME_VALUE = "Volume value";

	[CompilerGenerated]
	private int 놇뇈;

	public override string Name => _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놤();

	public int VolumeValue
	{
		[CompilerGenerated]
		get
		{
			return 놇뇈;
		}
		[CompilerGenerated]
		private set
		{
			놇뇈 = value;
		}
	}

	public override IList<SettingItem> Settings
	{
		get
		{
			return new List<SettingItem>
			{
				new SettingItemInteger(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놩(), VolumeValue)
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
				if (item.Name == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놩())
				{
					VolumeValue = (int)item.Value;
				}
			}
		}
	}

	public override Period GetPeriod => Period.TICK1;

	public override HistoryType GetHistoryType => HistoryType.Last;

	[NotPublished]
	public override Period DefaultRange => Period.HOUR1;

	public HistoryAggregationVolume(int volumeValue)
	{
		VolumeValue = volumeValue;
	}

	[NotPublished]
	public override string ToString()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(8, 2);
		defaultInterpolatedStringHandler.AppendFormatted(Name);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴뇎());
		defaultInterpolatedStringHandler.AppendFormatted(VolumeValue);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸뇊());
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	private HistoryAggregationVolume(HistoryAggregationVolume P_0)
		: base(P_0)
	{
		VolumeValue = P_0.VolumeValue;
	}

	[NotPublished]
	public override object Clone()
	{
		return new HistoryAggregationVolume(this);
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
