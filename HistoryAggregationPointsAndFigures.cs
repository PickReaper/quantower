using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;

namespace TradingPlatform.BusinessLayer;

[Published]
public sealed class HistoryAggregationPointsAndFigures : HistoryAggregationTime
{
	[CompilerGenerated]
	private int 놻녮;

	[CompilerGenerated]
	private int 놻뇆;

	[CompilerGenerated]
	private PointsAndFiguresStyle 놻뇉;

	public override string Name => _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰뇀();

	public int BoxSize
	{
		[CompilerGenerated]
		get
		{
			return 놻녮;
		}
		[CompilerGenerated]
		private set
		{
			놻녮 = value;
		}
	}

	public int Reversal
	{
		[CompilerGenerated]
		get
		{
			return 놻뇆;
		}
		[CompilerGenerated]
		private set
		{
			놻뇆 = value;
		}
	}

	public PointsAndFiguresStyle Style
	{
		[CompilerGenerated]
		get
		{
			return 놻뇉;
		}
		[CompilerGenerated]
		private set
		{
			놻뇉 = value;
		}
	}

	public override IList<SettingItem> Settings
	{
		get
		{
			List<SelectItem> list = new List<SelectItem>();
			SelectItem value = null;
			foreach (PointsAndFiguresStyle value2 in Enum.GetValues(typeof(PointsAndFiguresStyle)))
			{
				SelectItem selectItem = new SelectItem(loc._(value2.GetDescription(), null, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰놽()), (int)value2);
				list.Add(selectItem);
				if (Style == value2)
				{
					value = selectItem;
				}
			}
			IList<SettingItem> settings = base.Settings;
			if (settings.GetItemByName(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇁()) is SettingItemPeriod settingItemPeriod)
			{
				settingItemPeriod.ExcludedPeriods = null;
			}
			settings.Add(new SettingItemInteger(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰녿(), BoxSize, 10)
			{
				Text = loc._(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰놁(), null, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰놽()),
				Minimum = 1,
				Maximum = int.MaxValue
			});
			settings.Add(new SettingItemInteger(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놄(), Reversal, 20)
			{
				Text = loc._(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놄(), null, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰놽()),
				Minimum = 1,
				Maximum = int.MaxValue
			});
			settings.Add(new SettingItemSelectorLocalized(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녲놑(), value, list, 30)
			{
				Text = loc._(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녲놑(), null, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰놽())
			});
			return settings;
		}
		set
		{
			base.Settings = value;
			SettingItem itemByName = value.GetItemByName(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰녿());
			if (itemByName != null)
			{
				BoxSize = (int)itemByName.Value;
			}
			itemByName = value.GetItemByName(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놄());
			if (itemByName != null)
			{
				Reversal = (int)itemByName.Value;
			}
			if (value.GetItemByName(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녲놑())?.Value is SelectItem selectItem)
			{
				Style = (PointsAndFiguresStyle)(int)(object)selectItem.Value;
			}
		}
	}

	[NotPublished]
	public override TimeScaleType TimeScaleType => TimeScaleType.NonLinear;

	[NotPublished]
	public override BarCreationBehavior BarCreationBehavior => BarCreationBehavior.Deferred;

	public HistoryAggregationPointsAndFigures(Period period, HistoryType historyType, int boxSize, int reversal, PointsAndFiguresStyle style)
		: base(period, historyType)
	{
		BoxSize = boxSize;
		Reversal = reversal;
		Style = style;
	}

	[NotPublished]
	public override string ToString()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(9, 4);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰녭());
		defaultInterpolatedStringHandler.AppendFormatted(Reversal);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰녱());
		defaultInterpolatedStringHandler.AppendFormatted(BoxSize);
		defaultInterpolatedStringHandler.AppendFormatted((Style == PointsAndFiguresStyle.Classic) ? _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰높() : _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰놲());
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂녹());
		defaultInterpolatedStringHandler.AppendFormatted(base.Period.Format());
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	protected HistoryAggregationPointsAndFigures(HistoryAggregationPointsAndFigures aggregation)
		: base(aggregation)
	{
		BoxSize = aggregation.BoxSize;
		Reversal = aggregation.Reversal;
		Style = aggregation.Style;
	}

	[NotPublished]
	public override object Clone()
	{
		return new HistoryAggregationPointsAndFigures(this);
	}
}
