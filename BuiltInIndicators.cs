using System.Collections.Generic;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;

namespace TradingPlatform.BusinessLayer;

[Published]
public sealed class BuiltInIndicators
{
	private readonly IIndicatorsCollection 놚;

	internal BuiltInIndicators(IIndicatorsCollection P_0 = null)
	{
		놚 = P_0;
	}

	private void 녴(Indicator P_0)
	{
		놚?.AddIndicator(P_0);
	}

	/// <summary>
	/// Returns an instance of the Exponential Moving Average (EMA) indicator.
	/// <para>EMA provides a weighted price calculation for the last N periods.</para>
	/// </summary>
	/// <param name="maPeriod">Period of Exponential Moving Average</param>
	/// <param name="priceType">Sources prices for MA</param>
	///  <param name="calculationType">Calculation type</param>
	public Indicator EMA(int maPeriod, PriceType priceType, IndicatorCalculationType calculationType = IndicatorCalculationType.AllAvailableData)
	{
		Indicator indicator = Core.Instance.Indicators.CreateIndicator(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녱(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놲(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놲(), ScriptCreationType.Default);
		IList<SettingItem> settings = indicator.Settings;
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.높(), maPeriod);
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놶(), new SelectItem(priceType.ToString(), (int)priceType));
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇏(), new SelectItem(calculationType.ToString(), (int)calculationType));
		indicator.Settings = settings;
		녴(indicator);
		return indicator;
	}

	/// <summary>
	/// Gets the Linearly Weighted Moving Average
	/// <para> Linear Weighted Moving Average makes the most recent bar more important unlike SMA.</para>
	/// </summary>
	/// <param name="maPeriod">Moving average period</param>
	/// <param name="priceType">Type of the price</param>
	/// <exception cref="T:System.ArgumentOutOfRangeException"></exception>
	public Indicator LWMA(int maPeriod, PriceType priceType)
	{
		Indicator indicator = Core.Instance.Indicators.CreateIndicator(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녻(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놲(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놲(), ScriptCreationType.Default);
		IList<SettingItem> settings = indicator.Settings;
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녙(), maPeriod);
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놢(), new SelectItem(priceType.ToString(), (int)priceType));
		indicator.Settings = settings;
		녴(indicator);
		return indicator;
	}

	/// <summary>
	///  Gets the SMA(Simple Moving Average) indicator.
	///  <para> The 'SMA' indicator provides an average price for the last N periods. </para>
	/// </summary>
	/// <param name="period">Period of simple moving average.</param>
	/// <param name="priceType">Sources prices for MA.</param>
	/// <exception cref="T:System.ArgumentOutOfRangeException"></exception>
	public Indicator SMA(int period, PriceType priceType)
	{
		Indicator indicator = Core.Instance.Indicators.CreateIndicator(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녧(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놲(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놲(), ScriptCreationType.Default);
		IList<SettingItem> settings = indicator.Settings;
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녤(), period);
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놶(), new SelectItem(priceType.ToString(), (int)priceType));
		indicator.Settings = settings;
		녴(indicator);
		return indicator;
	}

	/// <summary>
	/// Returns an instance of the Smoothed Moving Average (SMMA) indicator.
	/// <para>SMMA indicator provides a smoothed average price for the last N periods.</para>
	/// </summary>
	/// <param name="period">Moving average period</param>
	/// <param name="priceType">Type of the price</param>
	///  <param name="calculationType">Calculation type</param>
	/// <exception cref="T:System.ArgumentOutOfRangeException"></exception>
	public Indicator SMMA(int period, PriceType priceType, IndicatorCalculationType calculationType = IndicatorCalculationType.AllAvailableData)
	{
		Indicator indicator = Core.Instance.Indicators.CreateIndicator(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놆(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놲(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놲(), ScriptCreationType.Default);
		IList<SettingItem> settings = indicator.Settings;
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇎(), period);
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놶(), new SelectItem(priceType.ToString(), (int)priceType));
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇏(), new SelectItem(calculationType.ToString(), (int)calculationType));
		indicator.Settings = settings;
		녴(indicator);
		return indicator;
	}

	/// <summary>
	/// Gets the PPMA(Pivot Point Moving Average) indicator.
	/// <para> The 'PPMA' indicator uses the pivot point calculation as the input a simple moving average.</para>
	/// </summary>
	/// <param name="period">Period of PPMA indicator</param>
	/// <returns></returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException"></exception>
	public Indicator PPMA(int period)
	{
		Indicator indicator = Core.Instance.Indicators.CreateIndicator(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놷(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놲(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놲(), ScriptCreationType.Default);
		IList<SettingItem> settings = indicator.Settings;
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녗(), period);
		indicator.Settings = settings;
		녴(indicator);
		return indicator;
	}

	/// <summary>
	///  Gets the MAS3 (3MASignal) indicator.
	/// <para>The 'MAS3' indicator offers buy and sell signals according to intersections of three moving averages.</para>
	/// </summary>
	/// <param name="shortPeriod">Short moving average period.</param>
	/// <param name="middlePeriod">Middle moving average period.</param>
	/// <param name="longPeriod">Long moving average period.</param>
	/// <param name="barsInterval">The count of bars. The trend will be determined on this interval.</param>
	/// <returns></returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException"></exception>
	public Indicator MAS3(int shortPeriod, int middlePeriod, int longPeriod, int barsInterval)
	{
		Indicator indicator = Core.Instance.Indicators.CreateIndicator(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놜(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놲(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놲(), ScriptCreationType.Default);
		IList<SettingItem> settings = indicator.Settings;
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놨(), shortPeriod);
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녢(), middlePeriod);
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놞(), longPeriod);
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놳(), barsInterval);
		indicator.Settings = settings;
		녴(indicator);
		return indicator;
	}

	/// <summary>
	/// Gets the specific MA indicator, according to selected 'MaMode'.
	/// </summary>
	/// <param name="period">Period of moving average.</param>
	/// <param name="priceType">Type of price.</param>
	/// <param name="maMode">MA mode.</param>
	/// <param name="calculationType">Calculation type</param>
	/// <returns></returns>
	///             <exception cref="T:System.ArgumentOutOfRangeException"></exception>
	public Indicator MA(int period, PriceType priceType, MaMode maMode, IndicatorCalculationType calculationType = IndicatorCalculationType.AllAvailableData)
	{
		return maMode switch
		{
			MaMode.SMA => SMA(period, priceType), 
			MaMode.EMA => EMA(period, priceType, calculationType), 
			MaMode.SMMA => SMMA(period, priceType, calculationType), 
			MaMode.LWMA => LWMA(period, priceType), 
			_ => null, 
		};
	}

	/// <summary>
	/// Gets the BB(Bollinger Bands) indicator.
	/// <para>The 'BB' indicator provides a relative definition of high and low based on standard deviation and a simple moving average.</para>
	/// </summary>
	/// <param name="period">Period of MA for envelopes.</param>
	/// <param name="coefficient">Value of confidence interval.</param>
	/// <param name="priceType">Sources prices for MA.</param>
	/// <param name="maMode">Type of moving average.</param>
	///  <param name="calculationType">Calculation type</param>
	/// <exception cref="T:System.ArgumentOutOfRangeException"></exception>
	public Indicator BB(int period, double coefficient, PriceType priceType, MaMode maMode, IndicatorCalculationType calculationType = IndicatorCalculationType.AllAvailableData)
	{
		Indicator indicator = Core.Instance.Indicators.CreateIndicator(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놺(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놅(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놅(), ScriptCreationType.Default);
		IList<SettingItem> settings = indicator.Settings;
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녜(), period);
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇃(), coefficient);
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놶(), new SelectItem(priceType.ToString(), (int)priceType));
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녯(), new SelectItem(maMode.ToString(), (int)maMode));
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇏(), new SelectItem(calculationType.ToString(), (int)calculationType));
		indicator.Settings = settings;
		녴(indicator);
		return indicator;
	}

	/// <summary>
	/// Gets the Commodity Channel Index.
	/// <para>Measures the position of price in relation to its moving average.</para>
	/// </summary>
	/// <param name="maPeriod">Period for CCI MA</param>
	/// <param name="priceType">Sources prices for CCI</param>
	/// <param name="maMode">MA mode for CCI</param>
	/// <param name="calculationType">Calculation type</param>
	/// <exception cref="T:System.ArgumentOutOfRangeException"></exception>
	public Indicator CCI(int maPeriod, PriceType priceType, MaMode maMode, IndicatorCalculationType calculationType = IndicatorCalculationType.AllAvailableData)
	{
		Indicator indicator = Core.Instance.Indicators.CreateIndicator(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놮(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녫(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녫(), ScriptCreationType.Default);
		IList<SettingItem> settings = indicator.Settings;
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇁(), maPeriod);
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놶(), new SelectItem(priceType.ToString(), (int)priceType));
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놧(), new SelectItem(maMode.ToString(), (int)maMode));
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇏(), new SelectItem(calculationType.ToString(), (int)calculationType));
		indicator.Settings = settings;
		녴(indicator);
		return indicator;
	}

	/// <summary>
	/// Returns an instance of the Modified Moving Average (MMA) indicator.
	/// <para>MMA comprises a sloping factor to help it overtake with the growing or declining value of the trading price of the currency.</para>
	/// </summary>
	/// <param name="maPeriod">Period of Modified Moving Average</param>
	/// <param name="priceType">Sources prices for MA</param>
	/// <exception cref="T:System.ArgumentOutOfRangeException"></exception>
	public Indicator MMA(int maPeriod, PriceType priceType)
	{
		Indicator indicator = Core.Instance.Indicators.CreateIndicator(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녝(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놲(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놲(), ScriptCreationType.Default);
		IList<SettingItem> settings = indicator.Settings;
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇈(), maPeriod);
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놶(), new SelectItem(priceType.ToString(), (int)priceType));
		indicator.Settings = settings;
		녴(indicator);
		return indicator;
	}

	/// <summary>
	/// Gets the Regression indicator
	/// <para>The Linear Regression Indicator plots the ending value of a Linear Regression Line for a specified number of bars; showing, statistically, where the price is expected to be.</para>
	/// </summary>
	/// <param name="period">Moving average period</param>
	/// <param name="priceType">Type of the price</param>
	/// <exception cref="T:System.ArgumentOutOfRangeException"></exception>
	public Indicator Regression(int period, PriceType priceType)
	{
		Indicator indicator = Core.Instance.Indicators.CreateIndicator(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놑(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놲(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놲(), ScriptCreationType.Default);
		IList<SettingItem> settings = indicator.Settings;
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놦(), period);
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놐(), new SelectItem(priceType.ToString(), (int)priceType));
		indicator.Settings = settings;
		녴(indicator);
		return indicator;
	}

	/// <summary>
	/// Gets the Channel (Price Channel) indicator.
	/// <para>The 'Channel' indicator is based on measurement of min and max prices for the definite number of periods.</para>
	/// </summary>
	/// <param name="period">Period of price channel</param>
	/// <returns></returns>
	///             <exception cref="T:System.ArgumentOutOfRangeException"></exception>
	public Indicator Channel(int period)
	{
		Indicator indicator = Core.Instance.Indicators.CreateIndicator(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녚(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놅(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놅(), ScriptCreationType.Default);
		IList<SettingItem> settings = indicator.Settings;
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녳(), period);
		indicator.Settings = settings;
		녴(indicator);
		return indicator;
	}

	/// <summary>
	/// Gets the AFIRMA indicator
	/// <para> Autoregressive finite impulse response moving average. A digital filter accurately shows the price movement as powered with least square method to minimise time lag</para>
	/// </summary>
	/// <param name="period">Moving average period</param>
	/// <param name="priceType">Type of the price</param>
	/// <param name="afirmaMode">Afirma mode</param>
	/// <param name="least_squares_method">with least squares method overlapping if true</param>
	/// <exception cref="T:System.ArgumentOutOfRangeException"></exception>
	public Indicator AFIRMA(int period, PriceType priceType, AfirmaMode afirmaMode, bool least_squares_method)
	{
		Indicator indicator = Core.Instance.Indicators.CreateIndicator(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놉(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놥(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놥(), ScriptCreationType.Default);
		IList<SettingItem> settings = indicator.Settings;
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놯(), period);
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녾(), new SelectItem(priceType.ToString(), (int)priceType));
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녬(), new SelectItem(afirmaMode.ToString(), (int)afirmaMode));
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녹(), least_squares_method);
		indicator.Settings = settings;
		녴(indicator);
		return indicator;
	}

	/// <summary>
	/// Gets the RSI indicator.
	/// <para> Relative Strength Index (RSI) is a momentum oscillator that measures the speed and change of price movements.</para>
	/// </summary>
	/// <param name="period">RSI Period</param>
	/// <param name="priceType">Price Type</param>
	/// <param name="rsiMode">RSI Mode (Simple or Exponential)</param>
	/// <param name="maMode">MA Mode for smooth data</param>
	/// <param name="maperiod">MA period for smooth data</param>
	/// <param name="calculationType">Calculation type</param>
	///             <exception cref="T:System.ArgumentOutOfRangeException"></exception>
	public Indicator RSI(int period, PriceType priceType, RSIMode rsiMode, MaMode maMode, int maperiod, IndicatorCalculationType calculationType = IndicatorCalculationType.AllAvailableData)
	{
		Indicator indicator = Core.Instance.Indicators.CreateIndicator(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녔(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녫(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녫(), ScriptCreationType.Default);
		IList<SettingItem> settings = indicator.Settings;
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녠(), period);
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놠(), new SelectItem(priceType.ToString(), (int)priceType));
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놟(), new SelectItem(rsiMode.ToString(), (int)rsiMode));
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놧(), new SelectItem(maMode.ToString(), (int)maMode));
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녓(), maperiod);
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇏(), new SelectItem(calculationType.ToString(), (int)calculationType));
		indicator.Settings = settings;
		녴(indicator);
		return indicator;
	}

	/// <summary>
	/// Returns an instance of the McGinley Dynamic indicator.
	/// <para>McGinley Dynamic avoids of most whipsaws and it rapidly moves up or down according to a quickly changing market. It needs no adjusting because it is dynamic and it adjusts itself.</para>
	/// </summary>
	/// <param name="period">Period of exponential moving average</param>
	/// <param name="trackingFactor">Dynamic tracking factor</param>
	/// <param name="priceType">Source price type</param>
	/// <param name="calculationType">Calculation type</param>
	/// <exception cref="T:System.ArgumentOutOfRangeException"></exception>
	public Indicator MD(int period, int trackingFactor, PriceType priceType, IndicatorCalculationType calculationType = IndicatorCalculationType.AllAvailableData)
	{
		Indicator indicator = Core.Instance.Indicators.CreateIndicator(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녛(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놲(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놲(), ScriptCreationType.Default);
		IList<SettingItem> settings = indicator.Settings;
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇁(), period);
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녽(), trackingFactor);
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놏(), new SelectItem(priceType.ToString(), (int)priceType));
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇏(), new SelectItem(calculationType.ToString(), (int)calculationType));
		indicator.Settings = settings;
		녴(indicator);
		return indicator;
	}

	/// <summary>
	/// Gets the MAE (Moving Average Envelope) indicator.
	/// <para> The 'MAE' indicator demonstrates a range of the prices discrepancy from a Moving Average.</para>
	/// </summary>
	/// <param name="period">Period of MA for envelopes.</param>
	/// <param name="priceType">Sources prices for MA.</param>
	/// <param name="maMode">Type of moving average.</param>
	/// <param name="upShift">Upband deviation in %.</param>
	/// <param name="downShift">Downband deviation in %.</param>
	///  <param name="calculationType">Calculation type</param>
	/// <exception cref="T:System.ArgumentOutOfRangeException"></exception>
	public Indicator MAE(int period, PriceType priceType, MaMode maMode, double upShift, double downShift, IndicatorCalculationType calculationType = IndicatorCalculationType.AllAvailableData)
	{
		Indicator indicator = Core.Instance.Indicators.CreateIndicator(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녥(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놅(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놅(), ScriptCreationType.Default);
		IList<SettingItem> settings = indicator.Settings;
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녜(), period);
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놶(), new SelectItem(priceType.ToString(), (int)priceType));
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녯(), new SelectItem(maMode.ToString(), (int)maMode));
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.농(), upShift);
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.념(), downShift);
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇏(), new SelectItem(calculationType.ToString(), (int)calculationType));
		indicator.Settings = settings;
		녴(indicator);
		return indicator;
	}

	/// <summary>
	/// Returns an instance of the Parabolic Time/Price System (SAR) indicator.
	/// <para>SAR indicator helps to define the direction of the prevailing trend and the moment to close positions opened during the reversal.</para>
	/// </summary>
	/// <param name="step">Step of parabolic SAR system</param>
	/// <param name="maximum">Maximum value for the acceleration factor</param>
	/// <returns></returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException"></exception>
	public Indicator SAR(double step, double maximum)
	{
		Indicator indicator = Core.Instance.Indicators.CreateIndicator(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녨(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녺(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녺(), ScriptCreationType.Default);
		IList<SettingItem> settings = indicator.Settings;
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놣(), step);
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녮(), maximum);
		indicator.Settings = settings;
		녴(indicator);
		return indicator;
	}

	/// <summary>
	/// Gets the AO (Awesome Oscillator) indicator.
	/// <para> The 'AO' indicator determines market momentum.</para>
	/// </summary>
	/// <returns></returns>
	public Indicator AO()
	{
		Indicator indicator = Core.Instance.Indicators.CreateIndicator(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇆(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녫(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녫(), ScriptCreationType.Default);
		녴(indicator);
		return indicator;
	}

	/// <summary>
	/// Gets the CMO (Chande Momentum Oscillator) indicator.
	/// <para>The CMO calculates the dividing of difference between the sum of all recent gains and the sum of all recent losses by the sum of all price movement over the period.</para>
	/// </summary>
	/// <param name="period">Period of MA for envelopes.</param>
	/// <param name="priceType">Sources prices for MA.</param>
	/// <returns></returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException"></exception>
	public Indicator CMO(int period, PriceType priceType)
	{
		Indicator indicator = Core.Instance.Indicators.CreateIndicator(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇉(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇍(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇍(), ScriptCreationType.Default);
		IList<SettingItem> settings = indicator.Settings;
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녜(), period);
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놶(), new SelectItem(priceType.ToString(), (int)priceType));
		indicator.Settings = settings;
		녴(indicator);
		return indicator;
	}

	/// <summary>
	/// Returns an instance of the ZigZag indicator.
	/// <para>ZigZag is a trend following indicator that is used to predict when a given symbol's momentum is reversing.</para>
	/// </summary>
	/// <param name="deviation">Percent Deviation</param>
	/// <returns></returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException"></exception>
	public Indicator ZZ(double deviation)
	{
		Indicator indicator = Core.Instance.Indicators.CreateIndicator(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놙(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녺(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녺(), ScriptCreationType.Default);
		IList<SettingItem> settings = indicator.Settings;
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녰(), deviation);
		indicator.Settings = settings;
		녴(indicator);
		return indicator;
	}

	/// <summary>
	/// Gets the Aroon indicator.
	/// <para>Reveals the beginning of a new trend and determines how strong it is</para>
	/// </summary>
	/// <param name="period">Aroons period</param>
	/// <returns></returns>
	///             <exception cref="T:System.ArgumentOutOfRangeException"></exception>
	public Indicator AROON(int period)
	{
		Indicator indicator = Core.Instance.Indicators.CreateIndicator(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놚(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녫(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녫(), ScriptCreationType.Default);
		IList<SettingItem> settings = indicator.Settings;
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놹(), period);
		indicator.Settings = settings;
		녴(indicator);
		return indicator;
	}

	/// <summary>
	/// Returns an instance of the Standart Deviation (SD) indicator.
	/// <para>The SD shows the difference of the volatility value from the average one.</para>
	/// </summary>
	/// <param name="period">Period of indicator</param>
	/// <param name="priceType">Sources prices for MA</param>
	/// <param name="mode">Type of Moving Average</param>
	///  <param name="calculationType">Calculation type</param>
	/// <exception cref="T:System.ArgumentOutOfRangeException"></exception>
	public Indicator SD(int period, PriceType priceType, MaMode mode, IndicatorCalculationType calculationType = IndicatorCalculationType.AllAvailableData)
	{
		Indicator indicator = Core.Instance.Indicators.CreateIndicator(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놘(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇍(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇍(), ScriptCreationType.Default);
		IList<SettingItem> settings = indicator.Settings;
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇁(), period);
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놶(), new SelectItem(priceType.ToString(), (int)priceType));
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놧(), new SelectItem(mode.ToString(), (int)mode));
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇏(), new SelectItem(calculationType.ToString(), (int)calculationType));
		indicator.Settings = settings;
		녴(indicator);
		return indicator;
	}

	/// <summary>
	///  Gets the MACD (Moving Average Convergence/Divergence) indicator.
	///  <para> The MACD is a trend-following momentum indicator that shows the relationship between two moving averages of prices.</para>
	/// </summary>
	/// <param name="fastEMA">Period of fast EMA.</param>
	/// <param name="slowEMA">Period of slow EMA.</param>
	/// <param name="signalEMA">Period of signal EMA.</param>
	///  <param name="calculationType">Calculation type</param>
	/// <exception cref="T:System.ArgumentOutOfRangeException"></exception>
	public Indicator MACD(int fastEMA, int slowEMA, int signalEMA, IndicatorCalculationType calculationType = IndicatorCalculationType.AllAvailableData)
	{
		Indicator indicator = Core.Instance.Indicators.CreateIndicator(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇌(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녫(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녫(), ScriptCreationType.Default);
		IList<SettingItem> settings = indicator.Settings;
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녷(), fastEMA);
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녟(), slowEMA);
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놱(), signalEMA);
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇏(), new SelectItem(calculationType.ToString(), (int)calculationType));
		indicator.Settings = settings;
		녴(indicator);
		return indicator;
	}

	/// <summary>
	/// Returns an instance of the Kairi Relative Index (KRI) indicator.
	/// <para>KRI calculates deviation of the current price from its simple moving average as a percent of the moving average.</para>
	/// </summary>
	/// <param name="period"></param>
	/// <returns></returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException"></exception>
	public Indicator KRI(int period)
	{
		Indicator indicator = Core.Instance.Indicators.CreateIndicator(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놖(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녫(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녫(), ScriptCreationType.Default);
		IList<SettingItem> settings = indicator.Settings;
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇁(), period);
		indicator.Settings = settings;
		녴(indicator);
		return indicator;
	}

	/// <summary>
	/// Returns an instance of the Bollinger Bands Flat (BBF) indicator.
	/// <para>The BBF provides the same data as BB, but drawn in separate field and easier to recognize whether price is in or out of the band.</para>
	/// </summary>
	/// <param name="period">Period</param>
	/// <param name="deviation">Deviation</param>
	/// <param name="priceType">Sources prices for MA</param>
	/// <param name="mode">Type of Moving Average</param>
	/// <param name="calculationType">Calculation type</param>
	/// <exception cref="T:System.ArgumentOutOfRangeException"></exception>
	public Indicator BBF(int period, double deviation, PriceType priceType, MaMode mode, IndicatorCalculationType calculationType = IndicatorCalculationType.AllAvailableData)
	{
		Indicator indicator = Core.Instance.Indicators.CreateIndicator(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놝(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놅(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놅(), ScriptCreationType.Default);
		IList<SettingItem> settings = indicator.Settings;
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇁(), period);
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇄(), deviation);
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놶(), new SelectItem(priceType.ToString(), (int)priceType));
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놧(), new SelectItem(mode.ToString(), (int)mode));
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇏(), new SelectItem(calculationType.ToString(), (int)calculationType));
		indicator.Settings = settings;
		녴(indicator);
		return indicator;
	}

	/// <summary>
	///  Gets the ROC (Rate of Change) indicator.
	///  <para>The ROC shows the speed at which price is changing.</para>
	/// </summary>
	/// <param name="period">Period of momentum.</param>
	/// <returns></returns>
	///  <exception cref="T:System.ArgumentOutOfRangeException"></exception>
	public Indicator ROC(int period)
	{
		Indicator indicator = Core.Instance.Indicators.CreateIndicator(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녑(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녫(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녫(), ScriptCreationType.Default);
		IList<SettingItem> settings = indicator.Settings;
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놈(), period);
		indicator.Settings = settings;
		녴(indicator);
		return indicator;
	}

	/// <summary>
	/// Gets the Momentum indicator.
	/// <para>Momentum compares where the current price is in relation to where the price was in the past.</para>
	/// </summary>
	/// <param name="period">Period for Momentum</param>
	/// <param name="priceType">Sources prices for Momentum</param>
	/// <returns></returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException"></exception>
	public Indicator Momentum(int period, PriceType priceType)
	{
		Indicator indicator = Core.Instance.Indicators.CreateIndicator(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놬(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녫(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녫(), ScriptCreationType.Default);
		IList<SettingItem> settings = indicator.Settings;
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놊(), period);
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놪(), new SelectItem(priceType.ToString(), (int)priceType));
		indicator.Settings = settings;
		녴(indicator);
		return indicator;
	}

	/// <summary>
	/// Gets the %R Larry Williams.
	/// <para>Uses Stochastic to determine overbought and oversold levels.</para>
	/// </summary>
	/// <param name="period">Period for Momentum</param>
	/// <returns></returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException"></exception>
	public Indicator RLW(int period)
	{
		Indicator indicator = Core.Instance.Indicators.CreateIndicator(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놌(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녫(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녫(), ScriptCreationType.Default);
		IList<SettingItem> settings = indicator.Settings;
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇁(), period);
		indicator.Settings = settings;
		녴(indicator);
		return indicator;
	}

	/// <summary>
	/// Returns an instance of the Price Oscillator (PO) indicator.
	/// <para>PO calculates the variation between price moving averages.</para>
	/// </summary>
	/// <param name="period1">Period of MA1</param>
	/// <param name="period2">Period of MA2</param>
	/// <param name="priceType">Sources prices for MA</param>
	/// <param name="mode">Type of Moving Average</param>
	///  <param name="calculationType">Calculation type</param>
	/// <exception cref="T:System.ArgumentOutOfRangeException"></exception>
	public Indicator PO(int period1, int period2, PriceType priceType, MaMode mode, IndicatorCalculationType calculationType = IndicatorCalculationType.AllAvailableData)
	{
		Indicator indicator = Core.Instance.Indicators.CreateIndicator(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놕(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녫(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녫(), ScriptCreationType.Default);
		IList<SettingItem> settings = indicator.Settings;
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇊(), period1);
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놋(), period2);
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놶(), new SelectItem(priceType.ToString(), (int)priceType));
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놧(), new SelectItem(mode.ToString(), (int)mode));
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇏(), new SelectItem(calculationType.ToString(), (int)calculationType));
		indicator.Settings = settings;
		녴(indicator);
		return indicator;
	}

	/// <summary>
	///  Gets the OsMA (Moving Average of Oscillator) indicator.
	///  <para> The OsMA reflects the difference between an oscillator (MACD) and its moving average (signal line).</para>
	/// </summary>
	/// <param name="fastEMA">Period of fast EMA.</param>
	/// <param name="slowEMA">Period of slow EMA.</param>
	/// <param name="signalEMA">Period of signal EMA.</param>
	///  <param name="calculationType">Calculation type</param>
	/// <exception cref="T:System.ArgumentOutOfRangeException"></exception>
	public Indicator OsMA(int fastEMA, int slowEMA, int signalEMA, IndicatorCalculationType calculationType = IndicatorCalculationType.AllAvailableData)
	{
		Indicator indicator = Core.Instance.Indicators.CreateIndicator(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녣(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녫(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녫(), ScriptCreationType.Default);
		IList<SettingItem> settings = indicator.Settings;
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녷(), fastEMA);
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녟(), slowEMA);
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놱(), signalEMA);
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇏(), new SelectItem(calculationType.ToString(), (int)calculationType));
		indicator.Settings = settings;
		녴(indicator);
		return indicator;
	}

	/// <summary>
	/// Gets On Balance Volume.
	/// <para>On Balance Volume (OBV) measures buying and selling pressure as a cumulative indicator that adds volume on up days and subtracts volume on down days.</para>
	/// </summary>
	///             <param name="priceType">Sources prices for OBV</param>
	///             <returns></returns>
	///             <exception cref="T:System.ArgumentOutOfRangeException"></exception>
	public Indicator OBV(PriceType priceType)
	{
		Indicator indicator = Core.Instance.Indicators.CreateIndicator(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녩(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놤(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놤(), ScriptCreationType.Default);
		IList<SettingItem> settings = indicator.Settings;
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놶(), new SelectItem(priceType.ToString(), (int)priceType));
		indicator.Settings = settings;
		녴(indicator);
		return indicator;
	}

	/// <summary>
	/// Returns an instance of the Positive Volume Index (PVI) indicator.
	/// <para>The PVI value changes on the periods in which value of volume has increased in comparison with the previous period.</para>
	/// </summary>
	/// <param name="priceType"></param>
	/// <returns></returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException"></exception>
	public Indicator PVI(PriceType priceType)
	{
		Indicator indicator = Core.Instance.Indicators.CreateIndicator(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.논(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놤(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놤(), ScriptCreationType.Default);
		IList<SettingItem> settings = indicator.Settings;
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놏(), new SelectItem(priceType.ToString(), (int)priceType));
		indicator.Settings = settings;
		녴(indicator);
		return indicator;
	}

	/// <summary>
	/// Returns an instance of the Volume indicator.
	/// <para>Volume allows to confirm the strength of a trend or to suggest about it's weakness.</para>
	/// </summary>
	/// <returns></returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException"></exception>
	public Indicator Volume()
	{
		Indicator indicator = Core.Instance.Indicators.CreateIndicator(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놤(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놤(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놤(), ScriptCreationType.Default);
		녴(indicator);
		return indicator;
	}

	/// <summary>
	///  Gets the MFI(Money Flow Index) indicator.
	///  <para>The MFI(Money Flow Index) is an oscillator that uses both price and volume to measure buying and selling pressure.</para>
	/// </summary>
	/// <param name="period">Period of MFI.</param>
	/// <returns></returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException"></exception>
	public Indicator MFI(int period)
	{
		Indicator indicator = Core.Instance.Indicators.CreateIndicator(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녘(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놤(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놤(), ScriptCreationType.Default);
		IList<SettingItem> settings = indicator.Settings;
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.노(), period);
		indicator.Settings = settings;
		녴(indicator);
		return indicator;
	}

	/// <summary>
	/// Returns an instance of the Acceleration/Deceleration Oscillator (AC).
	/// <para>AC measures the acceleration and deceleration of the current momentum.</para>
	/// </summary>
	/// <returns></returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException"></exception>
	public Indicator AC()
	{
		Indicator indicator = Core.Instance.Indicators.CreateIndicator(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녒(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녫(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녫(), ScriptCreationType.Default);
		녴(indicator);
		return indicator;
	}

	/// <summary>
	/// Gets the Average True Range (ATR) indicator.
	/// <para>The ATR measures of market volatility.</para>
	/// </summary>
	/// <returns></returns>
	/// <param name="period">Period of Moving Average.</param>
	/// <param name="mode">Type of Moving Average</param>
	/// <param name="calculationType">Calculation type</param>
	/// <exception cref="T:System.ArgumentOutOfRangeException"></exception>
	public Indicator ATR(int period, MaMode mode, IndicatorCalculationType calculationType = IndicatorCalculationType.AllAvailableData)
	{
		Indicator indicator = Core.Instance.Indicators.CreateIndicator(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녕(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇍(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇍(), ScriptCreationType.Default);
		IList<SettingItem> settings = indicator.Settings;
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녖(), period);
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놧(), new SelectItem(mode.ToString(), (int)mode));
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇏(), new SelectItem(calculationType.ToString(), (int)calculationType));
		indicator.Settings = settings;
		녴(indicator);
		return indicator;
	}

	/// <summary>
	/// Returns an instance of the Kaufman Adaptive Moving Average (KAMA) indicator.
	/// <para>KAMA is an exponential style average with a smoothing that varies according to recent data.</para>
	/// </summary>
	/// <param name="period">Period</param>
	/// <param name="fast">Fast factor</param>
	/// <param name="slow">Slow factor</param>
	/// <param name="priceType">Sources prices for MA</param>
	/// <returns></returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException"></exception>
	public Indicator KAMA(int period, double fast, double slow, PriceType priceType)
	{
		Indicator indicator = Core.Instance.Indicators.CreateIndicator(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴녴(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놲(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놲(), ScriptCreationType.Default);
		IList<SettingItem> settings = indicator.Settings;
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇁(), period);
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴놴(), fast);
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴놂(), slow);
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놶(), new SelectItem(priceType.ToString(), (int)priceType));
		indicator.Settings = settings;
		녴(indicator);
		return indicator;
	}

	/// <summary>
	/// Returns an instance of the Qstick indicator.
	/// <para>The Qstick is a moving average that shows the difference between the prices at which an issue opens and closes.</para>
	/// </summary>
	/// <param name="period"></param>
	/// <param name="mode"></param>
	///  <param name="calculationType">Calculation type</param>
	/// <exception cref="T:System.ArgumentOutOfRangeException"></exception>
	public Indicator Qstick(int period, MaMode mode, IndicatorCalculationType calculationType = IndicatorCalculationType.AllAvailableData)
	{
		Indicator indicator = Core.Instance.Indicators.CreateIndicator(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴놎(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녫(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녫(), ScriptCreationType.Default);
		IList<SettingItem> settings = indicator.Settings;
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇁(), period);
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놧(), new SelectItem(mode.ToString(), (int)mode));
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇏(), new SelectItem(calculationType.ToString(), (int)calculationType));
		indicator.Settings = settings;
		녴(indicator);
		return indicator;
	}

	/// <summary>
	/// Get the Swing Index (SI) indicator.
	/// <para> The SI is used to confirm trend line breakouts on price charts.</para>
	/// </summary>
	/// <param name="divider">The divider.</param>
	/// <returns></returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException"></exception>
	public Indicator SI(double divider)
	{
		Indicator indicator = Core.Instance.Indicators.CreateIndicator(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴녞(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녺(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녺(), ScriptCreationType.Default);
		IList<SettingItem> settings = indicator.Settings;
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴놫(), divider);
		indicator.Settings = settings;
		녴(indicator);
		return indicator;
	}

	/// <summary>
	/// Get the True Strength Index (TSI) indicator.
	/// <para>
	/// The TSI is a variation of the Relative Strength Indicator which uses a doubly-smoothed
	/// EMA of price momentum to eliminate choppy price changes and spot trend changes.
	///  </para>
	/// </summary>
	/// <param name="firstPeriod">First MA period.</param>
	/// <param name="secondPeriod">Second MA period.</param>
	///  <param name="calculationType">Calculation type</param>
	/// <exception cref="T:System.ArgumentOutOfRangeException"></exception>
	public Indicator TSI(int firstPeriod, int secondPeriod, IndicatorCalculationType calculationType = IndicatorCalculationType.AllAvailableData)
	{
		Indicator indicator = Core.Instance.Indicators.CreateIndicator(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴녪(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녫(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녫(), ScriptCreationType.Default);
		IList<SettingItem> settings = indicator.Settings;
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴녶(), firstPeriod);
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴녵(), secondPeriod);
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇏(), new SelectItem(calculationType.ToString(), (int)calculationType));
		indicator.Settings = settings;
		녴(indicator);
		return indicator;
	}

	/// <summary>
	/// Returns an instance of the Average Directional Index (ADX) indicator.
	/// <para>The ADX determines the strength of a prevailing trend.</para>
	/// </summary>
	/// <param name="period">Period</param>
	/// <param name="mode">Type of Moving Average</param>
	/// <param name="calculationType">Calculation type</param>
	/// <exception cref="T:System.ArgumentOutOfRangeException"></exception>
	public Indicator ADX(int period, MaMode mode, IndicatorCalculationType calculationType = IndicatorCalculationType.AllAvailableData)
	{
		Indicator indicator = Core.Instance.Indicators.CreateIndicator(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴놭(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녺(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녺(), ScriptCreationType.Default);
		IList<SettingItem> settings = indicator.Settings;
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇁(), period);
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놧(), new SelectItem(mode.ToString(), (int)mode));
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇏(), new SelectItem(calculationType.ToString(), (int)calculationType));
		indicator.Settings = settings;
		녴(indicator);
		return indicator;
	}

	/// <summary>
	/// Returns an instance of the Keltner Channel indicator.
	/// <para>Keltner Channels are volatility-based envelopes set above and below an exponential moving average.</para>
	/// </summary>
	/// <param name="period">Period of MA for Keltner's Channel</param>
	/// <param name="offset">Coefficient of channel's width</param>
	/// <param name="priceType">Sources prices for MA</param>
	/// <param name="mode">Type of Moving Average</param>
	///  <param name="calculationType">Calculation type</param>
	/// <exception cref="T:System.ArgumentOutOfRangeException"></exception>
	public Indicator Keltner(int period, double offset, PriceType priceType, MaMode mode, IndicatorCalculationType calculationType = IndicatorCalculationType.AllAvailableData)
	{
		Indicator indicator = Core.Instance.Indicators.CreateIndicator(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴녲(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놅(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놅(), ScriptCreationType.Default);
		IList<SettingItem> settings = indicator.Settings;
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴뇋(), period);
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴놸(), offset);
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놶(), new SelectItem(priceType.ToString(), (int)priceType));
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놧(), new SelectItem(mode.ToString(), (int)mode));
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇏(), new SelectItem(calculationType.ToString(), (int)calculationType));
		indicator.Settings = settings;
		녴(indicator);
		return indicator;
	}

	/// <summary>
	/// Returns an instance of the Percentage Price Oscillator (PPO).
	/// <para>Percentage Price Oscillator is a momentum indicator. Signal line is EMA of PPO. Formula: (FastEMA-SlowEMA)/SlowEMA.</para>
	/// </summary>
	/// <param name="fastPeriod">Fast EMA Period</param>
	/// <param name="slowPeriod">Slow EMA Period</param>
	/// <param name="signalPeriod">Signal EMA Period</param>
	///  <param name="calculationType">Calculation type</param>
	/// <exception cref="T:System.ArgumentOutOfRangeException"></exception>
	public Indicator PPO(int fastPeriod, int slowPeriod, int signalPeriod, IndicatorCalculationType calculationType = IndicatorCalculationType.AllAvailableData)
	{
		Indicator indicator = Core.Instance.Indicators.CreateIndicator(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴놿(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녫(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녫(), ScriptCreationType.Default);
		IList<SettingItem> settings = indicator.Settings;
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴놄(), fastPeriod);
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴놰(), slowPeriod);
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴놓(), signalPeriod);
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇏(), new SelectItem(calculationType.ToString(), (int)calculationType));
		indicator.Settings = settings;
		녴(indicator);
		return indicator;
	}

	/// <summary>
	/// Gets the Stochastic Slow.
	/// <para>Shows the location of the current close relative to the high/low range over a set number of periods (Slow).</para>
	/// </summary>
	/// <param name="period">Period</param>
	/// <param name="smooth">Smoothing</param>
	/// <param name="doubleSmooth">Double smoothing</param>
	/// <param name="MaType">Moving type</param>
	/// <param name="calculationType">Calculation type</param>
	/// <exception cref="T:System.ArgumentOutOfRangeException"></exception>
	public Indicator Stochastic(int period, int smooth, int doubleSmooth, MaMode MaType, IndicatorCalculationType calculationType = IndicatorCalculationType.AllAvailableData)
	{
		Indicator indicator = Core.Instance.Indicators.CreateIndicator(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴놇(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녫(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녫(), ScriptCreationType.Default);
		IList<SettingItem> settings = indicator.Settings;
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇁(), period);
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴뇅(), smooth);
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴놵(), doubleSmooth);
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴놡(), new SelectItem(MaType.ToString(), (int)MaType));
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇏(), new SelectItem(calculationType.ToString(), (int)calculationType));
		indicator.Settings = settings;
		녴(indicator);
		return indicator;
	}

	/// <summary>
	/// Gets the Stochastic x Relative Strength Index.
	/// <para>StochRSI is an oscillator that measures the level of RSI relative to its range.</para>
	/// </summary>
	/// <param name="rsiPeriod">Period</param>
	/// <param name="kPeriod">Smoothing</param>
	/// <param name="dPeriod">Double smoothing</param>
	/// <returns></returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException"></exception>
	public Indicator StochasticxRSI(int rsiPeriod, int kPeriod, int dPeriod)
	{
		Indicator indicator = Core.Instance.Indicators.CreateIndicator(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴놻(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녫(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녫(), ScriptCreationType.Default);
		IList<SettingItem> settings = indicator.Settings;
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴놃(), rsiPeriod);
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴뇇(), kPeriod);
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴놛(), dPeriod);
		indicator.Settings = settings;
		녴(indicator);
		return indicator;
	}

	/// <summary>
	/// Gets the Ichimoku.
	/// <para>Enables to quickly discern and filter 'at a glance' the low-probability trading setups from those of higher probability.</para>
	/// </summary>
	/// <param name="TenkanPeriod">Tenkan Period</param>
	/// <param name="KijunPeriod">Kijun Period</param>
	/// <param name="SenkouSpanB">Senkou Span B</param>
	/// <returns></returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException"></exception>
	public Indicator ICH(int TenkanPeriod, int KijunPeriod, int SenkouSpanB)
	{
		Indicator indicator = Core.Instance.Indicators.CreateIndicator(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴놼(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녺(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녺(), ScriptCreationType.Default);
		IList<SettingItem> settings = indicator.Settings;
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴놗(), TenkanPeriod);
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴뇂(), KijunPeriod);
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴놩(), SenkouSpanB);
		indicator.Settings = settings;
		녴(indicator);
		return indicator;
	}

	/// <summary>
	/// Gets the Directional Movement Index(DMI) indicator.
	/// <para>The DMI іdentifies whether there is a definable trend in the market.</para>
	/// </summary>
	/// <param name="period">Period of Moving Average.</param>
	/// <param name="mode">Type of Moving Average.</param>
	/// <param name="calculationType">Calculation type</param>
	/// <exception cref="T:System.ArgumentOutOfRangeException"></exception>
	public Indicator DMI(int period, MaMode mode, IndicatorCalculationType calculationType = IndicatorCalculationType.AllAvailableData)
	{
		Indicator indicator = Core.Instance.Indicators.CreateIndicator(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴녡(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녺(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녺(), ScriptCreationType.Default);
		IList<SettingItem> settings = indicator.Settings;
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녖(), period);
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놧(), new SelectItem(mode.ToString(), (int)mode));
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇏(), new SelectItem(calculationType.ToString(), (int)calculationType));
		indicator.Settings = settings;
		녴(indicator);
		return indicator;
	}

	/// <summary>
	/// Gets the Alligator.
	/// <para>Three moving averages with different colors, periods and calculation methods.</para>
	/// </summary>
	/// <param name="JawMAType">Type of Jaw Moving Average.</param>
	/// <param name="JawSourcePrice">SourcePrice of Jaw Moving Average.</param>
	/// <param name="JawMAPeiod">Period of Jaw Moving Average.</param>
	/// <param name="JawMAShift">Shift of Jaw Moving Average.</param>
	/// <param name="TeethMAType">Period of Moving Average.</param>
	/// <param name="TeethSourcePrice">Type of Moving Average.</param>
	/// <param name="TeethMAPeiod">Period of Moving Average.</param>
	/// <param name="TeethMAShift">Type of Moving Average.</param>
	/// <param name="LipsMAType">Period of Moving Average.</param>
	/// <param name="LipsSourcePrice">Type of Moving Average.</param>
	/// <param name="LipsMAPeiod">Period of Moving Average.</param>
	/// <param name="LipsMAShift">Type of Moving Average.</param>
	/// <returns></returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException"></exception>
	public Indicator Alligator(MaMode JawMAType, PriceType JawSourcePrice, int JawMAPeiod, int JawMAShift, MaMode TeethMAType, PriceType TeethSourcePrice, int TeethMAPeiod, int TeethMAShift, MaMode LipsMAType, PriceType LipsSourcePrice, int LipsMAPeiod, int LipsMAShift)
	{
		Indicator indicator = Core.Instance.Indicators.CreateIndicator(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴녦(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놥(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놥(), ScriptCreationType.Default);
		IList<SettingItem> settings = indicator.Settings;
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴놀(), new SelectItem(JawMAType.ToString(), (int)JawMAType));
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴놔(), new SelectItem(JawSourcePrice.ToString(), (int)JawSourcePrice));
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴놾(), JawMAPeiod);
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴뇀(), JawMAShift);
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴놽(), new SelectItem(TeethMAType.ToString(), (int)TeethMAType));
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴녿(), new SelectItem(TeethSourcePrice.ToString(), (int)TeethSourcePrice));
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴놁(), TeethMAPeiod);
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴녭(), TeethMAShift);
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴녱(), new SelectItem(LipsMAType.ToString(), (int)LipsMAType));
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴놲(), new SelectItem(LipsSourcePrice.ToString(), (int)LipsSourcePrice));
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴높(), LipsMAPeiod);
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴놶(), LipsMAShift);
		indicator.Settings = settings;
		녴(indicator);
		return indicator;
	}

	public Indicator HV(int stdPeriod, int volatilityPeriod, PriceType priceType, HVSheduleMode hvMode)
	{
		return 녴(stdPeriod, volatilityPeriod, priceType, hvMode, true, 0);
	}

	public Indicator HV(int stdPeriod, int volatilityPeriod, PriceType priceType, HVSheduleMode hvMode, int percentilePeriod)
	{
		return 녴(stdPeriod, volatilityPeriod, priceType, hvMode, false, percentilePeriod);
	}

	private Indicator 녴(int P_0, int P_1, PriceType P_2, HVSheduleMode P_3, bool P_4, int P_5)
	{
		Indicator indicator = Core.Instance.Indicators.CreateIndicator(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴뇏(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇍(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇍(), ScriptCreationType.Default);
		IList<SettingItem> settings = indicator.Settings;
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴녻(), P_0);
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴녙(), P_1);
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴놢(), new SelectItem(P_2.ToString(), (int)P_2));
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴녧(), P_4);
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴녤(), P_5);
		settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴놆(), new SelectItem(P_3.ToString(), (int)P_3));
		indicator.Settings = settings;
		녴(indicator);
		return indicator;
	}
}
