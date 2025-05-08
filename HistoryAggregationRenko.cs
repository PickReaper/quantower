using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using TradingPlatform.BusinessLayer.Integration;

namespace TradingPlatform.BusinessLayer;

[Published]
public sealed class HistoryAggregationRenko : HistoryAggregationTime
{
	[Serializable]
	[CompilerGenerated]
	private sealed class 녴
	{
		public static readonly 녴 뇇놼 = new 녴();

		public static Func<SelectItem, bool> 뇇놗;

		public static Func<SelectItem, bool> 뇇뇂;

		internal bool 녴(SelectItem P_0)
		{
			return (int)(object)P_0.Value == 2;
		}

		internal bool 놴(SelectItem P_0)
		{
			return (int)(object)P_0.Value == 3;
		}
	}

	public const string SETTINGS_AGGREGATION_RENKO_BRICK_SIZE = "Brick size";

	public const string SETTINGS_AGGREGATION_RENKO_STYLE = "Style";

	public const string SETTINGS_AGGREGATION_RENKO_BUILD_CURRENT_BAR = "Build current bar";

	public const string SETTINGS_AGGREGATION_RENKO_EXTENSION = "Extension, %";

	public const string SETTINGS_AGGREGATION_RENKO_INVERSION = "Inversion, %";

	public const string SETTINGS_AGGREGATION_RENKO_SHOW_WICKS = "Show wicks";

	private const string 놻뇍 = "W";

	private static readonly Dictionary<RenkoStyle, string> 놻놙;

	[CompilerGenerated]
	private int 놻녰;

	[CompilerGenerated]
	private RenkoStyle 놻놚;

	[CompilerGenerated]
	private int 놻놹;

	[CompilerGenerated]
	private int 놻놘;

	[CompilerGenerated]
	private bool 놻뇌;

	[CompilerGenerated]
	private bool 놻녷;

	public override string Name => _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰놶();

	public int BrickSize
	{
		[CompilerGenerated]
		get
		{
			return 놻녰;
		}
		[CompilerGenerated]
		private set
		{
			놻녰 = value;
		}
	}

	public RenkoStyle RenkoStyle
	{
		[CompilerGenerated]
		get
		{
			return 놻놚;
		}
		[CompilerGenerated]
		private set
		{
			놻놚 = value;
		}
	}

	public int Extension
	{
		[CompilerGenerated]
		get
		{
			return 놻놹;
		}
		[CompilerGenerated]
		private set
		{
			놻놹 = value;
		}
	}

	public int Inversion
	{
		[CompilerGenerated]
		get
		{
			return 놻놘;
		}
		[CompilerGenerated]
		private set
		{
			놻놘 = value;
		}
	}

	public bool ShowWicks
	{
		[CompilerGenerated]
		get
		{
			return 놻뇌;
		}
		[CompilerGenerated]
		private set
		{
			놻뇌 = value;
		}
	}

	public bool BuildCurrentBar
	{
		[CompilerGenerated]
		get
		{
			return 놻녷;
		}
		[CompilerGenerated]
		private set
		{
			놻녷 = value;
		}
	}

	private protected override IList<HistoryType> SupportedHistoryTypes
	{
		get
		{
			IList<HistoryType> supportedHistoryTypes = base.SupportedHistoryTypes;
			supportedHistoryTypes.Add(HistoryType.BidAsk);
			return supportedHistoryTypes;
		}
	}

	public override IList<SettingItem> Settings
	{
		get
		{
			List<SelectItem> list = new List<SelectItem>
			{
				new SelectItem(RenkoStyle.Classic.ToString(), 0),
				new SelectItem(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰뇏(), 1),
				new SelectItem(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰녻(), 2),
				new SelectItem(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰녙(), 3)
			};
			SettingItemRelationVisibility relation = new SettingItemRelationVisibility(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녲놑(), list.FirstOrDefault((SelectItem P_0) => (int)(object)P_0.Value == 2), list.FirstOrDefault((SelectItem P_0) => (int)(object)P_0.Value == 3));
			IList<SettingItem> settings = base.Settings;
			if (settings.GetItemByName(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇁()) is SettingItemPeriod settingItemPeriod)
			{
				settingItemPeriod.ExcludedPeriods = null;
			}
			settings.Add(new SettingItemInteger(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰놢(), BrickSize)
			{
				SortIndex = 20,
				Minimum = 1,
				Maximum = int.MaxValue,
				Increment = 1
			});
			settings.Add(new SettingItemSelectorLocalized(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녲놑(), list.GetItemByValue((int)RenkoStyle), list)
			{
				SortIndex = 30,
				Description = _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰녧()
			});
			settings.Add(new SettingItemInteger(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰녤(), Extension)
			{
				Minimum = 1,
				Maximum = 1000,
				SortIndex = 40,
				Relation = relation
			});
			settings.Add(new SettingItemInteger(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰놆(), Inversion)
			{
				Minimum = 1,
				Maximum = 1000,
				SortIndex = 50,
				Relation = relation
			});
			settings.Add(new SettingItemBoolean(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰뇎(), ShowWicks)
			{
				SortIndex = 60
			});
			settings.Add(new SettingItemBoolean(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰놷(), BuildCurrentBar)
			{
				SortIndex = 70
			});
			return settings;
		}
		set
		{
			if (value == null)
			{
				return;
			}
			foreach (SettingItem item in value)
			{
				if (item == null)
				{
					continue;
				}
				string name = item.Name;
				if (!(name == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰놢()))
				{
					if (!(name == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녲놑()))
					{
						if (!(name == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰녤()))
						{
							if (!(name == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰놆()))
							{
								if (!(name == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰놷()))
								{
									if (name == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰뇎())
									{
										ShowWicks = (bool)item.Value;
									}
								}
								else
								{
									BuildCurrentBar = (bool)item.Value;
								}
							}
							else
							{
								Inversion = (int)item.Value;
							}
						}
						else
						{
							Extension = (int)item.Value;
						}
					}
					else
					{
						RenkoStyle = (RenkoStyle)(int)(object)((SelectItem)item.Value).Value;
					}
				}
				else
				{
					BrickSize = (int)item.Value;
				}
			}
			base.Settings = value;
		}
	}

	[NotPublished]
	public override TimeScaleType TimeScaleType => TimeScaleType.NonLinear;

	[NotPublished]
	public override BarCreationBehavior BarCreationBehavior => BarCreationBehavior.Deferred;

	static HistoryAggregationRenko()
	{
		놻놙 = new Dictionary<RenkoStyle, string>
		{
			{
				RenkoStyle.Classic,
				_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰높()
			},
			{
				RenkoStyle.HighLow,
				_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰놲()
			},
			{
				RenkoStyle.AdvancedClassic,
				_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰녗()
			},
			{
				RenkoStyle.AdvancedHighLow,
				_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰놜()
			}
		};
	}

	public HistoryAggregationRenko(Period period, HistoryType historyType, int brickSize, RenkoStyle renkoStyle, int extension = 100, int inversion = 100, bool showWicks = false, bool buildCurrentBar = true)
		: base(period, historyType)
	{
		BrickSize = brickSize;
		RenkoStyle = renkoStyle;
		Extension = extension;
		Inversion = inversion;
		ShowWicks = showWicks;
		BuildCurrentBar = buildCurrentBar;
	}

	public HistoryAggregation GetBaseAggregation()
	{
		if (base.Period.BasePeriod == BasePeriod.Tick)
		{
			if (base.Period.PeriodMultiplier == 1)
			{
				return new HistoryAggregationTick(base.HistoryType);
			}
			if (base.Period.PeriodMultiplier > 1)
			{
				return new HistoryAggregationTickBars(base.Period.PeriodMultiplier, base.HistoryType);
			}
		}
		return new HistoryAggregationTime(base.Period, base.HistoryType);
	}

	public override HistoryAggregation GetAggregationToDirectDownload(HistoryMetadata metadata)
	{
		HistoryAggregation baseAggregation = GetBaseAggregation();
		if (baseAggregation is HistoryAggregationTime && !metadata.AllowedHistoryTypesHistoryAggregationTime.Contains(base.HistoryType))
		{
			return null;
		}
		return baseAggregation.GetAggregationToDirectDownload(metadata);
	}

	private HistoryAggregationRenko(HistoryAggregationRenko P_0)
		: base(P_0)
	{
		BrickSize = P_0.BrickSize;
		RenkoStyle = P_0.RenkoStyle;
		ShowWicks = P_0.ShowWicks;
		BuildCurrentBar = P_0.BuildCurrentBar;
		Extension = P_0.Extension;
		Inversion = P_0.Inversion;
	}

	[NotPublished]
	public override object Clone()
	{
		return new HistoryAggregationRenko(this);
	}

	[NotPublished]
	public override string ToString()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 5);
		defaultInterpolatedStringHandler.AppendFormatted(Name);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴뇎());
		defaultInterpolatedStringHandler.AppendFormatted(BrickSize);
		defaultInterpolatedStringHandler.AppendFormatted(놻놙[RenkoStyle]);
		defaultInterpolatedStringHandler.AppendFormatted(ShowWicks ? _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰놨() : string.Empty);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂녹());
		defaultInterpolatedStringHandler.AppendFormatted(base.Period.Format());
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}
}
