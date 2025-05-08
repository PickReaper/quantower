using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using TradingPlatform.BusinessLayer.Chart;
using TradingPlatform.BusinessLayer.Utils;
using 녴;

namespace TradingPlatform.BusinessLayer;

/// <summary>
/// Base class for all indicators.
/// </summary>
[Published]
public abstract class Indicator : ExecutionEntity, IIndicatorsCollection
{
	private class 녴
	{
		[CompilerGenerated]
		private Color? 놻놌;

		[CompilerGenerated]
		private Color? 놻놕;

		public Color? BeginColor
		{
			[CompilerGenerated]
			get
			{
				return 놻놌;
			}
			[CompilerGenerated]
			set
			{
				놻놌 = value;
			}
		}

		public Color? EndColor
		{
			[CompilerGenerated]
			get
			{
				return 놻놕;
			}
			[CompilerGenerated]
			set
			{
				놻놕 = value;
			}
		}

		public override string ToString()
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(15, 2);
			defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰녢());
			defaultInterpolatedStringHandler.AppendFormatted(BeginColor);
			defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰놞());
			defaultInterpolatedStringHandler.AppendFormatted(EndColor);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}
	}

	[NotPublished]
	public const string EMA = "Exponential Moving Average";

	[NotPublished]
	public const string LWMA = "Linearly Weighted Moving Average";

	[NotPublished]
	public const string SMA = "Simple Moving Average";

	[NotPublished]
	public const string SMMA = "Smoothed Moving Average";

	[NotPublished]
	public const string PPMA = "Pivot Point Moving Average";

	[NotPublished]
	public const string CCI = "Commodity Channel Index";

	[NotPublished]
	public const string MAS3 = "3MASignal";

	[NotPublished]
	public const string MMA = "Modified Moving Average";

	[NotPublished]
	public const string Regression = "Regression Line";

	[NotPublished]
	public const string BB = "Bollinger Bands";

	[NotPublished]
	public const string Channel = "Price Channel";

	[NotPublished]
	public const string AFIRMA = "Autoregressive Finite Impulse Response Moving Average";

	[NotPublished]
	public const string RSI = "Relative Strength Index";

	[NotPublished]
	public const string MD = "McGinley Dynamic";

	[NotPublished]
	public const string MAE = "Moving Average Envelope";

	[NotPublished]
	public const string SAR = "Parabolic SAR";

	[NotPublished]
	public const string AO = "Awesome Oscillator";

	[NotPublished]
	public const string CMO = "Chande Momentum Oscillator";

	[NotPublished]
	public const string ZZ = "ZigZag";

	[NotPublished]
	public const string AROON = "Aroon";

	[NotPublished]
	public const string MACD = "Moving Average Convergence/Divergence";

	[NotPublished]
	public const string SD = "Standard Deviation";

	[NotPublished]
	public const string KRI = "Kairi Relative Index";

	[NotPublished]
	public const string BBF = "Bollinger Bands Flat";

	[NotPublished]
	public const string ROC = "Rate of Change";

	[NotPublished]
	public const string Momentum = "Momentum";

	[NotPublished]
	public const string RLW = "%R Larry Williams";

	[NotPublished]
	public const string PO = "Price Oscillator";

	[NotPublished]
	public const string OBV = "On Balance Volume";

	[NotPublished]
	public const string OsMA = "Moving Average of Oscillator";

	[NotPublished]
	public const string PVI = "Positive Volume Index";

	[NotPublished]
	public const string VOLUME = "Volume";

	[NotPublished]
	public const string MFI = "Money Flow Index";

	[NotPublished]
	public const string AC = "Acceleration Oscillator";

	[NotPublished]
	public const string ATR = "Average True Range";

	[NotPublished]
	public const string KAMA = "Kaufman Adaptive Moving Average";

	[NotPublished]
	public const string Stochastic = "Stochastic Slow";

	[NotPublished]
	public const string StochasticxRSI = "Stochastic x Relative Strength Index";

	[NotPublished]
	public const string Qstick = "Qstick";

	[NotPublished]
	public const string SI = "Swing Index";

	[NotPublished]
	public const string ADX = "Average Directional Index";

	[NotPublished]
	public const string Keltner = "Keltner Channel";

	[NotPublished]
	public const string PPO = "Percentage Price Oscillator";

	[NotPublished]
	public const string TSI = "True Strength Index";

	[NotPublished]
	public const string DMI = "Directional Movement Index";

	[NotPublished]
	public const string ICH = "Ichimoku";

	[NotPublished]
	public const string Alligator = "Alligator";

	[NotPublished]
	public const string HV = "Historical Volatility";

	[NotPublished]
	public const string PAZ = "Price Action Zones";

	[NotPublished]
	public const string OSCILLATOR_GROUP = "Oscillators";

	[NotPublished]
	public const string MOVING_AVERAGE_GROUP = "Moving averages";

	[NotPublished]
	public const string TREND_GROUP = "Trend";

	[NotPublished]
	public const string VOLATILITY_GROUP = "Volatility";

	[NotPublished]
	public const string CHANNEL_GROUP = "Channels";

	[NotPublished]
	public const string VOLUME_GROUP = "Volume";

	[NotPublished]
	public const string HIDDEN_GROUP = "Hidden";

	[NotPublished]
	protected internal const IndicatorCalculationType DEFAULT_CALCULATION_TYPE = IndicatorCalculationType.AllAvailableData;

	private string 뇅녥;

	[CompilerGenerated]
	private int 뇅농;

	[CompilerGenerated]
	private HistoricalData 뇅념;

	[CompilerGenerated]
	private bool 뇅녨;

	[CompilerGenerated]
	private bool 뇅녺;

	[CompilerGenerated]
	private bool 뇅놣 = true;

	[CompilerGenerated]
	private int 뇅녮 = -1;

	[CompilerGenerated]
	private TimeFrameConfig 뇅뇆 = new TimeFrameConfig();

	[CompilerGenerated]
	private IndicatorUpdateType 뇅뇉;

	[CompilerGenerated]
	private bool 뇅뇍 = true;

	private const string 뇅놙 = "Line_";

	private const string 뇅녰 = "Level_";

	[CompilerGenerated]
	private IChart 뇅놚;

	private readonly List<LineSeries> 뇅놹;

	private readonly List<LineLevel> 뇅놘;

	private readonly object 뇅뇌;

	private readonly List<Indicator> 뇅녷;

	private readonly object 뇅녟;

	private readonly List<HistoricalDataCustom> 뇅놱;

	private readonly object 뇅놖;

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Obfuscation(Exclude = true)]
	private bool debugMode;

	private bool 뇅놝;

	private readonly IDictionary<IndicatorCloudKey, List<녴>> 뇅뇄;

	private readonly object 뇅녑;

	private readonly List<IndicatorBarAppearance> 뇅놈;

	/// <summary>
	/// Short name of indicator
	/// </summary>
	public virtual string ShortName
	{
		get
		{
			if (string.IsNullOrEmpty(뇅녥))
			{
				return base.Name;
			}
			return 뇅녥;
		}
		[Obsolete("Override getter")]
		protected set
		{
			뇅녥 = value;
		}
	}

	/// <summary>
	/// Access to current Symbol of indicator
	/// </summary>
	public Symbol Symbol => HistoricalData?.Symbol;

	/// <summary>
	/// Amount of items in internal buffers
	/// </summary>
	public int Count
	{
		[CompilerGenerated]
		get
		{
			return 뇅농;
		}
		[CompilerGenerated]
		private set
		{
			뇅농 = value;
		}
	}

	/// <summary>
	/// Represent access to current used historical data.
	/// </summary>
	public HistoricalData HistoricalData
	{
		[CompilerGenerated]
		get
		{
			return 뇅념;
		}
		[CompilerGenerated]
		internal set
		{
			뇅념 = value;
		}
	}

	/// <summary>
	/// Represent access indicator series
	/// </summary>
	public LineSeries[] LinesSeries => 뇅놹.ToArray();

	/// <summary>
	///
	/// </summary>
	public LineLevel[] LinesLevels => 뇅놘.ToArray();

	/// <summary>
	/// Specified, whether indicator should use main or additional window on the chart
	/// </summary>
	public bool SeparateWindow
	{
		[CompilerGenerated]
		get
		{
			return 뇅녨;
		}
		[CompilerGenerated]
		set
		{
			뇅녨 = value;
		}
	}

	/// <summary>
	/// Specified, whether indicator should draw on chart background by default.
	/// </summary>
	public bool OnBackGround
	{
		[CompilerGenerated]
		get
		{
			return 뇅녺;
		}
		[CompilerGenerated]
		set
		{
			뇅녺 = value;
		}
	}

	/// <summary>
	/// Specified, whether indicator should participate into price auto scale system.
	/// </summary>
	public bool AllowFitAuto
	{
		[CompilerGenerated]
		get
		{
			return 뇅놣;
		}
		[CompilerGenerated]
		set
		{
			뇅놣 = value;
		}
	}

	/// <summary>
	/// Precision amount for formatting price (the count of digits after decimal point); By default = -1, which means to use precision from indicator's symbol
	/// </summary>
	public int Digits
	{
		[CompilerGenerated]
		get
		{
			return 뇅녮;
		}
		[CompilerGenerated]
		set
		{
			뇅녮 = value;
		}
	}

	public TimeFrameConfig TFConfig
	{
		[CompilerGenerated]
		get
		{
			return 뇅뇆;
		}
		[CompilerGenerated]
		private set
		{
			뇅뇆 = value;
		}
	}

	public IndicatorUpdateType UpdateType
	{
		[CompilerGenerated]
		get
		{
			return 뇅뇉;
		}
		[CompilerGenerated]
		set
		{
			뇅뇉 = value;
		}
	}

	protected bool IsUpdateTypesSupported
	{
		[CompilerGenerated]
		get
		{
			return 뇅뇍;
		}
		[CompilerGenerated]
		set
		{
			뇅뇍 = value;
		}
	}

	/// <summary>
	/// Indicator's settings
	/// </summary>
	public override IList<SettingItem> Settings
	{
		get
		{
			IList<SettingItem> settings = base.Settings;
			if (뇅놹 != null)
			{
				for (int i = 0; i < 뇅놹.Count; i++)
				{
					int num = i + 1;
					LineSeries lineSeries = 뇅놹[i];
					string text = string.Format(loc._(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놑(), null, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놦()), num);
					SettingItemSeparatorGroup separatorGroup = new SettingItemSeparatorGroup((string.IsNullOrEmpty(lineSeries.Name) || lineSeries.Name.Contains(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놐())) ? text : string.Format(loc._(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿녚(), null, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놦()), lineSeries.Name), num);
					IList<SettingItem> settings2 = lineSeries.Settings;
					foreach (SettingItem item in settings2)
					{
						item.SeparatorGroup = separatorGroup;
					}
					settings.Add(new SettingItemGroup($"{_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놐()}{i}", settings2)
					{
						Text = text + _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿녳()
					});
				}
				if (뇅놘 != null)
				{
					for (int j = 0; j < 뇅놘.Count; j++)
					{
						int num2 = 뇅놹.Count + j;
						LineLevel lineLevel = 뇅놘[j];
						string text2 = string.Format(loc._(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놉(), null, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놦()), j + 1);
						SettingItemSeparatorGroup separatorGroup2 = new SettingItemSeparatorGroup((string.IsNullOrEmpty(lineLevel.Name) || lineLevel.Name.Contains(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놥())) ? text2 : string.Format(loc._(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿녚(), null, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놦()), lineLevel.Name), num2 + 1);
						IList<SettingItem> settings3 = lineLevel.Settings;
						foreach (SettingItem item2 in settings3)
						{
							item2.SeparatorGroup = separatorGroup2;
						}
						settings.Add(new SettingItemGroup($"{_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놐()}{num2}", settings3)
						{
							Text = text2 + _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿녳()
						});
					}
				}
			}
			if (HistoricalData != null && (TFConfig.DefaultAggregation == null || (HistoricalData.Aggregation != null && !HistoricalData.Aggregation.Equals(TFConfig.DefaultAggregation))))
			{
				TFConfig.DefaultAggregation = HistoricalData.Aggregation;
			}
			settings.Add(new SettingItemTimeFrameConfig(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녲놺(), TFConfig)
			{
				SeparatorGroup = new SettingItemSeparatorGroup(string.Empty, 1000)
			});
			List<SelectItem> list = new List<SelectItem>
			{
				new SelectItem(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놯(), 0),
				new SelectItem(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿녾(), 1)
			};
			if (IsUpdateTypesSupported)
			{
				settings.Add(new SettingItemSelectorLocalized(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿녬(), list.GetItemByValue((int)UpdateType), list)
				{
					SeparatorGroup = new SettingItemSeparatorGroup(string.Empty, 1100)
				});
			}
			return settings;
		}
		set
		{
			base.Settings = value;
			foreach (SettingItem item in value)
			{
				if (!(item is SettingItemGroup { Value: IList<SettingItem> value2 }) || !value2.Any() || value2[0].Group == null || !int.TryParse(value2[0].Group.Name.Replace(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놐(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놇()), out var result))
				{
					continue;
				}
				if (result < 뇅놹.Count)
				{
					뇅놹[result].Settings = value2;
					continue;
				}
				int num = result - 뇅놹.Count;
				if (num < 뇅놘.Count)
				{
					뇅놘[num].Settings = value2;
				}
			}
			bool flag = false;
			if (value.GetItemByName(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녲놺()) is SettingItemTimeFrameConfig settingItemTimeFrameConfig)
			{
				TFConfig = (TimeFrameConfig)settingItemTimeFrameConfig.Value;
			}
			if (IsUpdateTypesSupported && value.GetItemByName(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿녬()) is SettingItemSelectorLocalized settingItemSelectorLocalized)
			{
				UpdateType = (IndicatorUpdateType)(int)(object)((SelectItem)settingItemSelectorLocalized.Value).Value;
				flag = settingItemSelectorLocalized.ValueChangingReason == SettingItemValueChangingReason.Manually;
			}
			if (flag)
			{
				OnSettingsUpdated();
			}
		}
	}

	/// <summary>
	/// Represent access to the chart, that created indicator
	/// </summary>
	public IChart CurrentChart
	{
		[CompilerGenerated]
		get
		{
			return 뇅놚;
		}
		[CompilerGenerated]
		set
		{
			뇅놚 = value;
		}
	}

	public virtual string HelpLink => string.Empty;

	public virtual string SourceCodeLink => string.Empty;

	internal int ChildIndicatorsCount
	{
		get
		{
			lock (뇅녟)
			{
				return 뇅녷.Count;
			}
		}
	}

	protected virtual void OnInit()
	{
	}

	protected virtual void OnUpdate(UpdateArgs args)
	{
	}

	protected virtual void OnClear()
	{
	}

	public LineSeries AddLineSeries(string lineName = "", Color lineColor = default(Color), int lineWidth = 1, LineStyle lineStyle = LineStyle.Solid)
	{
		if (string.IsNullOrEmpty(lineName))
		{
			lineName = $"{_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놐()}{뇅놹.Count + 1}";
		}
		if (lineColor == default(Color))
		{
			lineColor = Color.Blue;
		}
		LineSeries lineSeries = new LineSeries(lineName, lineColor, lineWidth, lineStyle);
		AddLineSeries(lineSeries);
		return lineSeries;
	}

	public void AddLineSeries(LineSeries lineSeries)
	{
		if (lineSeries == null)
		{
			throw new ArgumentNullException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿녹());
		}
		lock (뇅뇌)
		{
			뇅놹.Add(lineSeries);
		}
	}

	public LineLevel AddLineLevel(double level, string lineName = "", Color lineColor = default(Color), int lineWidth = 1, LineStyle lineStyle = LineStyle.Solid)
	{
		if (string.IsNullOrEmpty(lineName))
		{
			lineName = $"{_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놥()}{level}";
		}
		if (lineColor == default(Color))
		{
			lineColor = Color.Blue;
		}
		LineLevel lineLevel = new LineLevel(level, lineName, lineColor, lineWidth, lineStyle);
		AddLineLevel(lineLevel);
		return lineLevel;
	}

	public void AddLineLevel(LineLevel lineLevel)
	{
		if (lineLevel == null)
		{
			throw new ArgumentNullException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿녔());
		}
		뇅놘.Add(lineLevel);
	}

	/// <summary>
	/// Recalculate indicator
	/// </summary>
	public void Refresh()
	{
		((놎)HistoricalData)?.녴(this);
	}

	/// <summary>
	///
	/// </summary>
	/// <param name="indicator"></param>
	public void AddIndicator(Indicator indicator)
	{
		if (indicator == null)
		{
			throw new ArgumentNullException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭놁());
		}
		lock (뇅녟)
		{
			if (뇅녷.Contains(indicator))
			{
				throw new InvalidOperationException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿녠());
			}
			indicator.HistoricalData = HistoricalData;
			indicator.Init();
			for (int i = 0; i < Count; i++)
			{
				indicator.Update(new UpdateArgs(UpdateReason.HistoricalBar));
			}
			뇅녷.Add(indicator);
		}
	}

	public void RemoveIndicator(Indicator indicator)
	{
		if (indicator == null)
		{
			throw new ArgumentNullException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭놁());
		}
		lock (뇅녟)
		{
			뇅녷.Remove(indicator);
		}
		indicator.Clear();
		indicator.Dispose();
	}

	/// <summary>
	/// Sets the value of indicator into internal buffer
	/// </summary>
	/// <param name="value">Value</param>
	/// <param name="lineIndex">Index of indicator line</param>
	/// <param name="offset">Offset value</param>
	public void SetValue(double value, int lineIndex = 0, int offset = 0)
	{
		뇅놹[lineIndex].SetValue(value, offset);
	}

	/// <summary>
	/// Gets the value of indicator from internal buffer
	/// </summary>
	/// <param name="offset">Offset value</param>
	/// <param name="lineIndex">Index of indicator line</param>
	/// <param name="origin">Offset start point</param>
	/// <returns></returns>
	public double GetValue(int offset = 0, int lineIndex = 0, SeekOriginHistory origin = SeekOriginHistory.End)
	{
		double result = double.NaN;
		if (lineIndex < 0 || lineIndex >= 뇅놹.Count)
		{
			return result;
		}
		return 뇅놹[lineIndex].GetValue(offset, origin);
	}

	/// <summary>
	/// Set line break point.
	/// </summary>
	/// <param name="offset">Offset value</param>
	/// <param name="lineIndex">Index of indicator line</param>
	/// <param name="origin">Offset start point</param>
	public void SetLineBreak(int offset = 0, int lineIndex = 0, SeekOriginHistory origin = SeekOriginHistory.End)
	{
		if (lineIndex < 0 || lineIndex >= 뇅놹.Count)
		{
			throw new ArgumentOutOfRangeException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놠());
		}
		int lineBreak = ((origin == SeekOriginHistory.End) ? offset : (Count - offset - 1));
		LinesSeries[lineIndex].SetLineBreak(lineBreak);
	}

	/// <summary>
	/// Remove line break point.
	/// </summary>
	/// <param name="offset">Offset value</param>
	/// <param name="lineIndex">Index of indicator line</param>
	/// <param name="origin">Offset start point</param>
	public void RemoveLineBreak(int offset = 0, int lineIndex = 0, SeekOriginHistory origin = SeekOriginHistory.End)
	{
		if (lineIndex < 0 || lineIndex >= 뇅놹.Count)
		{
			throw new ArgumentOutOfRangeException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놠());
		}
		int offset2 = ((origin == SeekOriginHistory.End) ? offset : (Count - offset - 1));
		LinesSeries[lineIndex].RemoveLineBreak(offset2);
	}

	/// <summary>
	/// Check if the point is a break point.
	/// </summary>
	/// <param name="offset">Offset value</param>
	/// <param name="lineIndex">Index of indicator line</param>
	/// <param name="origin">Offset start point</param>
	public bool GetLineBreak(int offset = 0, int lineIndex = 0, SeekOriginHistory origin = SeekOriginHistory.End)
	{
		if (lineIndex < 0 || lineIndex >= 뇅놹.Count)
		{
			throw new ArgumentOutOfRangeException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놠());
		}
		int offset2 = ((origin == SeekOriginHistory.End) ? offset : (Count - offset - 1));
		return LinesSeries[lineIndex].GetLineBreak(offset2);
	}

	/// <summary>
	/// Gets the price from historical data
	/// </summary>
	/// <param name="priceType"></param>
	/// <param name="offset"></param>
	/// <returns></returns>
	protected double GetPrice(PriceType priceType, int offset = 0)
	{
		return HistoricalData[Count - 1 - offset, SeekOriginHistory.Begin][priceType];
	}

	protected VolumeAnalysisData GetVolumeAnalysisData(int offset = 0)
	{
		return HistoricalData[Count - 1 - offset, SeekOriginHistory.Begin].VolumeAnalysisData;
	}

	/// <summary>
	/// Get Bid price
	/// </summary>
	/// <param name="offset">Offset value</param>
	/// <returns></returns>
	protected double Bid(int offset = 0)
	{
		return GetPrice(PriceType.Bid, offset);
	}

	/// <summary>
	/// Get Ask price
	/// </summary>
	/// <param name="offset">Offset value</param>
	/// <returns></returns>
	protected double Ask(int offset = 0)
	{
		return GetPrice(PriceType.Ask, offset);
	}

	/// <summary>
	/// Get Last price
	/// </summary>
	/// <param name="offset">Offset value</param>
	/// <returns></returns>
	protected double Last(int offset = 0)
	{
		return GetPrice(PriceType.Last, offset);
	}

	/// <summary>
	/// Get Open price
	/// </summary>
	/// <param name="offset">Offset value</param>
	/// <returns></returns>
	protected double Open(int offset = 0)
	{
		return GetPrice(PriceType.Open, offset);
	}

	/// <summary>
	/// Get High price
	/// </summary>
	/// <param name="offset">Offset value</param>
	/// <returns></returns>
	protected double High(int offset = 0)
	{
		return GetPrice(PriceType.High, offset);
	}

	/// <summary>
	/// Get Low price
	/// </summary>
	/// <param name="offset">Offset value</param>
	/// <returns></returns>
	protected double Low(int offset = 0)
	{
		return GetPrice(PriceType.Low, offset);
	}

	/// <summary>
	/// Get Close price
	/// </summary>
	/// <param name="offset">Offset value</param>
	/// <returns></returns>
	protected double Close(int offset = 0)
	{
		return GetPrice(PriceType.Close, offset);
	}

	/// <summary>
	/// Get Median price
	/// </summary>
	/// <param name="offset">Offset value</param>
	/// <returns></returns>
	protected double Median(int offset = 0)
	{
		return GetPrice(PriceType.Median, offset);
	}

	/// <summary>
	/// Get Typical price
	/// </summary>
	/// <param name="offset">Offset value</param>
	/// <returns></returns>
	protected double Typical(int offset = 0)
	{
		return GetPrice(PriceType.Typical, offset);
	}

	/// <summary>
	/// Get Weighted price
	/// </summary>
	/// <param name="offset">Offset value</param>
	/// <returns></returns>
	protected double Weighted(int offset = 0)
	{
		return GetPrice(PriceType.Weighted, offset);
	}

	/// <summary>
	/// Get Volume
	/// </summary>
	/// <param name="offset">Offset value</param>
	/// <returns></returns>
	protected double Volume(int offset = 0)
	{
		return GetPrice(PriceType.Volume, offset);
	}

	/// <summary>
	/// Get Volume in quoting asset
	/// </summary>
	/// <param name="offset">Offset value</param>
	/// <returns></returns>
	protected double QuoteAssetVolume(int offset = 0)
	{
		return GetPrice(PriceType.QuoteAssetVolume, offset);
	}

	/// <summary>
	/// Get Ticks
	/// </summary>
	/// <param name="offset">Offset value</param>
	/// <returns></returns>
	protected double Ticks(int offset = 0)
	{
		return GetPrice(PriceType.Ticks, offset);
	}

	/// <summary>
	/// Get Open interest
	/// </summary>
	/// <param name="offset">Offset value</param>
	/// <returns></returns>
	protected double OpenInterest(int offset = 0)
	{
		return GetPrice(PriceType.OpenInterest, offset);
	}

	/// <summary>
	/// Get Funding rate
	/// </summary>
	/// <param name="offset">Offset value</param>
	/// <returns></returns>
	protected double FundingRate(int offset = 0)
	{
		return GetPrice(PriceType.FundingRate, offset);
	}

	/// <summary>
	/// Get Time
	/// </summary>
	/// <param name="offset">Offset value</param>
	/// <returns></returns>
	protected DateTime Time(int offset = 0)
	{
		return new DateTime(HistoricalData[Count - 1 - offset, SeekOriginHistory.Begin].TicksLeft, DateTimeKind.Utc);
	}

	/// <summary>
	/// Formatting price, using precision from assigned symbol or Digits value if specified
	/// </summary>
	/// <param name="price">Price value</param>
	/// <returns></returns>
	public string FormatPrice(double price)
	{
		if (Digits != -1)
		{
			return price.Format(Digits);
		}
		if (Symbol != null)
		{
			return Symbol.FormatPrice(price);
		}
		return price.ToString();
	}

	[NotPublished]
	public override void Dispose()
	{
		base.Dispose();
		HistoricalData = null;
	}

	public virtual void OnPaintChart(PaintChartEventArgs args)
	{
	}

	public void Calculate(HistoricalData historicalData)
	{
		if (historicalData == null)
		{
			throw new ArgumentNullException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놟());
		}
		HistoricalData?.RemoveIndicator(this);
		historicalData.AddIndicator(this);
	}

	/// <summary>
	/// Marks cloud begin between two line series with specific color
	/// </summary>
	/// <param name="line1Index">First line series index</param>
	/// <param name="line2Index">Second line series index</param>
	/// <param name="color">Cloud color</param>
	/// <param name="offset">Offset</param>
	protected void BeginCloud(int line1Index, int line2Index, Color color, int offset = 0)
	{
		IndicatorCloudKey indicatorCloudKey = new IndicatorCloudKey(line1Index, line2Index);
		int num = Count - 1 - offset;
		녴 녴 = this.녴(indicatorCloudKey, num);
		if (녴.EndColor == color)
		{
			녴.EndColor = null;
		}
		else
		{
			녴.BeginColor = color;
		}
	}

	/// <summary>
	/// Marks cloud end between two line series with specific color
	/// </summary>
	/// <param name="line1Index">First line series index</param>
	/// <param name="line2Index">Second line series index</param>
	/// <param name="color">Cloud color</param>
	/// <param name="offset">Offset</param>
	protected void EndCloud(int line1Index, int line2Index, Color color, int offset = 0)
	{
		IndicatorCloudKey indicatorCloudKey = new IndicatorCloudKey(line1Index, line2Index);
		int num = Count - 1 - offset;
		녴 녴 = this.녴(indicatorCloudKey, num);
		if (녴.BeginColor == color)
		{
			녴.BeginColor = null;
		}
		else
		{
			녴.EndColor = color;
		}
	}

	private 녴 녴(IndicatorCloudKey P_0, int P_1)
	{
		lock (뇅녑)
		{
			if (!뇅뇄.TryGetValue(P_0, out var value))
			{
				value = (뇅뇄[P_0] = new List<녴>());
				for (int i = 0; i < Count; i++)
				{
					value.Add(new 녴());
				}
			}
			녴 녴 = value[P_1];
			if (녴 == null)
			{
				녴 = (value[P_1] = new 녴());
			}
			return 녴;
		}
	}

	[NotPublished]
	public IDictionary<IndicatorCloudKey, IndicatorCloud[]> AnalyzeClouds()
	{
		IDictionary<IndicatorCloudKey, List<녴>> dictionary;
		lock (뇅녑)
		{
			if (뇅뇄.Count == 0)
			{
				return null;
			}
			dictionary = new Dictionary<IndicatorCloudKey, List<녴>>(뇅뇄);
		}
		Dictionary<IndicatorCloudKey, IndicatorCloud[]> dictionary2 = new Dictionary<IndicatorCloudKey, IndicatorCloud[]>();
		foreach (KeyValuePair<IndicatorCloudKey, List<녴>> item in dictionary)
		{
			IndicatorCloudKey key = item.Key;
			List<녴> value = item.Value;
			List<IndicatorCloud> list = new List<IndicatorCloud>();
			IndicatorCloud indicatorCloud = null;
			for (int i = 0; i < value.Count; i++)
			{
				녴 녴 = value[i];
				if (녴.EndColor.HasValue && indicatorCloud != null)
				{
					indicatorCloud.ToIndex = i;
					if (indicatorCloud.ToIndex - indicatorCloud.FromIndex > 0)
					{
						indicatorCloud.ToIndex--;
					}
					list.Add(indicatorCloud);
					indicatorCloud = null;
				}
				if (녴.BeginColor.HasValue)
				{
					indicatorCloud = new IndicatorCloud
					{
						Color = 녴.BeginColor.Value,
						FromIndex = i
					};
				}
			}
			if (indicatorCloud != null)
			{
				if (indicatorCloud.ToIndex == -1)
				{
					indicatorCloud.ToIndex = Count - 1;
				}
				list.Add(indicatorCloud);
			}
			dictionary2.Add(key, list.ToArray());
		}
		return dictionary2;
	}

	public void SetBarColor(Color? color = null, int offset = 0)
	{
		int index = 뇅놈.Count - 1 - offset;
		if (!color.HasValue)
		{
			뇅놈[index] = null;
			return;
		}
		뇅놈[index] = new IndicatorBarAppearance
		{
			BarColor = color.Value
		};
	}

	public IndicatorBarAppearance GetBarAppearance(int offset = 0)
	{
		int num = 뇅놈.Count - 1 - offset;
		if (num < 0)
		{
			return null;
		}
		return 뇅놈[num];
	}

	public void SetBarAppearance(IndicatorBarAppearance barAppearance, int offset = 0)
	{
		int index = 뇅놈.Count - 1 - offset;
		뇅놈[index] = barAppearance;
	}

	protected virtual bool OnTryGetMinMax(int fromOffset, int toOffset, out double min, out double max)
	{
		min = double.NaN;
		max = double.NaN;
		return false;
	}

	protected Indicator()
	{
		뇅뇌 = new object();
		뇅놹 = new List<LineSeries>();
		뇅놘 = new List<LineLevel>();
		뇅녷 = new List<Indicator>();
		뇅녟 = new object();
		뇅놱 = new List<HistoricalDataCustom>();
		뇅놖 = new object();
		뇅뇄 = new Dictionary<IndicatorCloudKey, List<녴>>();
		뇅녑 = new object();
		뇅놈 = new List<IndicatorBarAppearance>();
	}

	public void Init()
	{
		try
		{
			OnInit();
		}
		catch (Exception ex)
		{
			Core.Instance.Loggers.Log(ex, base.Name + _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿녓());
		}
	}

	public void Update(UpdateArgs args)
	{
		if (debugMode)
		{
			while (!base.Disposed)
			{
				Thread.Sleep(100);
				if (뇅놝)
				{
					break;
				}
			}
		}
		bool num = 녴(args.Reason);
		녴(args);
		if (num)
		{
			Count++;
			놴();
			놎();
		}
		try
		{
			OnUpdate(args);
		}
		catch (Exception ex)
		{
			Core.Instance.Loggers.Log(ex, base.Name + _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿녛());
		}
		뇅놝 = false;
	}

	public void Clear()
	{
		놂();
		녞();
		Count = 0;
		if (뇅놹 == null)
		{
			return;
		}
		lock (뇅뇌)
		{
			foreach (LineSeries item in 뇅놹)
			{
				item.Clear();
			}
		}
		lock (뇅녑)
		{
			뇅뇄.Clear();
		}
		뇅놈.Clear();
		try
		{
			OnClear();
		}
		catch (Exception ex)
		{
			Core.Instance.Loggers.Log(ex, base.Name + _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿녽());
		}
	}

	public bool TryGetMinMax(int fromOffset, int toOffset, out double min, out double max)
	{
		min = double.NaN;
		max = double.NaN;
		try
		{
			return OnTryGetMinMax(fromOffset, toOffset, out min, out max);
		}
		catch (Exception ex)
		{
			Core.Instance.Loggers.Log(ex, base.Name + _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놏());
		}
		return false;
	}

	public void PaintChart(PaintChartEventArgs ev)
	{
		try
		{
			OnPaintChart(ev);
		}
		catch (Exception ex)
		{
			Core.Instance.Loggers.Log(ex);
		}
		뇅놝 = true;
	}

	private bool 녴(UpdateReason P_0)
	{
		switch (P_0)
		{
		case UpdateReason.HistoricalBar:
			return true;
		case UpdateReason.NewBar:
			return true;
		case UpdateReason.NewTick:
			if (HistoricalData.Aggregation == null)
			{
				return false;
			}
			if (HistoricalData.Aggregation.Name == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭놀() && HistoricalData.Aggregation.GetPeriod == Period.TICK1)
			{
				return true;
			}
			break;
		}
		return false;
	}

	private void 놴()
	{
		lock (뇅뇌)
		{
			foreach (LineSeries item in 뇅놹)
			{
				item.녴();
			}
		}
		lock (뇅뇄)
		{
			foreach (KeyValuePair<IndicatorCloudKey, List<녴>> item2 in 뇅뇄)
			{
				item2.Value.Add(new 녴());
			}
		}
		뇅놈.Add(null);
	}

	private void 녴(UpdateArgs P_0)
	{
		lock (뇅녟)
		{
			foreach (Indicator item in 뇅녷)
			{
				item.Update(P_0);
			}
		}
	}

	private void 놂()
	{
		lock (뇅녟)
		{
			foreach (Indicator item in 뇅녷)
			{
				item.Clear();
				item.Dispose();
			}
			뇅녷.Clear();
		}
	}

	internal void 녴(HistoricalDataCustom P_0)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿녥());
		}
		lock (뇅놖)
		{
			if (뇅놱.Contains(P_0))
			{
				throw new InvalidOperationException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿농());
			}
			for (int i = 0; i < Count; i++)
			{
				P_0.놴();
			}
			뇅놱.Add(P_0);
		}
	}

	private void 놎()
	{
		lock (뇅놖)
		{
			foreach (HistoricalDataCustom item in 뇅놱)
			{
				item.놴();
			}
		}
	}

	private void 녞()
	{
		lock (뇅놖)
		{
			foreach (HistoricalDataCustom item in 뇅놱)
			{
				item.Dispose();
			}
			뇅놱.Clear();
		}
	}

	protected override void OnSettingsUpdated()
	{
		Refresh();
	}
}
