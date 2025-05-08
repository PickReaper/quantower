using System.Collections.Generic;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;

namespace TradingPlatform.BusinessLayer;

[Published]
public sealed class HistoryAggregationKagi : HistoryAggregationTime
{
	public const string SETTINGS_AGGREGATION_REVERSAL = "Reversal";

	[CompilerGenerated]
	private int 놻녺;

	public override string Name => _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰녡();

	public int Reversal
	{
		[CompilerGenerated]
		get
		{
			return 놻녺;
		}
		[CompilerGenerated]
		set
		{
			놻녺 = value;
		}
	}

	[NotPublished]
	public override TimeScaleType TimeScaleType => TimeScaleType.NonLinear;

	[NotPublished]
	public override BarCreationBehavior BarCreationBehavior => BarCreationBehavior.Deferred;

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
			settings.Add(new SettingItemInteger(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놄(), Reversal)
			{
				Minimum = 1,
				SortIndex = 20
			});
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
				if (item.Name == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놄())
				{
					Reversal = (int)item.Value;
				}
			}
		}
	}

	public HistoryAggregationKagi(Period period, HistoryType historyType, int reversal)
		: base(period, historyType)
	{
		Reversal = reversal;
	}

	private HistoryAggregationKagi(HistoryAggregationKagi P_0)
		: base(P_0)
	{
		Reversal = P_0.Reversal;
	}

	public override object Clone()
	{
		return new HistoryAggregationKagi(this);
	}

	[NotPublished]
	public override string ToString()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(7, 3);
		defaultInterpolatedStringHandler.AppendFormatted(Name);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴뇎());
		defaultInterpolatedStringHandler.AppendFormatted(Reversal);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰녦());
		defaultInterpolatedStringHandler.AppendFormatted(base.Period.Format());
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}
}
