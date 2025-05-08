using System.Collections.Generic;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;

namespace TradingPlatform.BusinessLayer;

[Published]
public sealed class HistoryAggregationLineBreak : HistoryAggregationTime
{
	public const string SETTINGS_AGGREGATION_LINE_BREAK = "Line break";

	[CompilerGenerated]
	private int 놻놣;

	public override string Name => _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰놀();

	public int LineBreak
	{
		[CompilerGenerated]
		get
		{
			return 놻놣;
		}
		[CompilerGenerated]
		set
		{
			놻놣 = value;
		}
	}

	[NotPublished]
	public override TimeScaleType TimeScaleType => TimeScaleType.NonLinear;

	public override IList<SettingItem> Settings
	{
		get
		{
			IList<SettingItem> settings = base.Settings;
			if (settings.GetItemByName(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇁()) is SettingItemPeriod settingItemPeriod)
			{
				settingItemPeriod.ExcludedPeriods = new BasePeriod[2]
				{
					BasePeriod.Month,
					BasePeriod.Year
				};
			}
			SettingItemInteger item = new SettingItemInteger(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰놔(), LineBreak)
			{
				Minimum = 1,
				Maximum = 100,
				SortIndex = 20
			};
			settings.Add(item);
			return settings;
		}
		set
		{
			if (value == null)
			{
				return;
			}
			base.Settings = value;
			foreach (SettingItem item in value)
			{
				if (item.Name == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰놔())
				{
					LineBreak = (int)item.Value;
				}
			}
		}
	}

	public override Period GetPeriod => base.Period;

	public HistoryAggregationLineBreak(Period period, HistoryType historyType, int lineBreak)
		: base(period, historyType)
	{
		LineBreak = lineBreak;
	}

	private HistoryAggregationLineBreak(HistoryAggregationLineBreak P_0)
		: base(P_0)
	{
		LineBreak = P_0.LineBreak;
	}

	public override object Clone()
	{
		return new HistoryAggregationLineBreak(this);
	}

	[NotPublished]
	public override string ToString()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(11, 3);
		defaultInterpolatedStringHandler.AppendFormatted(Name);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴뇎());
		defaultInterpolatedStringHandler.AppendFormatted(LineBreak);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰놾());
		defaultInterpolatedStringHandler.AppendFormatted(base.Period.Format());
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}
}
