using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using TradingPlatform.BusinessLayer.Utils;

namespace TradingPlatform.BusinessLayer;

public class BasicBalanceCalculator : IBalanceCalculator, IDisposable
{
	[Serializable]
	[CompilerGenerated]
	private sealed class 녴
	{
		public static readonly 녴 놰뇋 = new 녴();

		public static Func<SlTpHolder, bool> 놰놸;

		public static Func<SlTpHolder, double> 놰놿;

		internal bool 녴(SlTpHolder P_0)
		{
			return !double.IsNaN(P_0.QuantityPercentage);
		}

		internal double 놴(SlTpHolder P_0)
		{
			return P_0.Quantity;
		}
	}

	[CompilerGenerated]
	private sealed class 놴
	{
		public BasicBalanceCalculator 놰놄;

		public SettingItem[] 놰놰;

		public OrderRequestParameters 놰놓;

		internal void 녴()
		{
			놰놄.PopulateAction(놰놰, 놰놓);
		}
	}

	[CompilerGenerated]
	private sealed class 놂
	{
		public BasicBalanceCalculator 놰놇;

		public OrderRequestParameters 놰뇅;

		public string 놰놵;

		internal void 녴()
		{
			try
			{
				놰놇.RequestParameters = 놰뇅;
				놰놇.놫녧 = 놰놵;
				놰놇.OnOrderSettingChanged(놰놵);
			}
			catch (Exception ex)
			{
				Core.Instance.Loggers.Log(ex);
			}
			finally
			{
				놰놇.놫녧 = null;
			}
		}
	}

	[CompilerGenerated]
	private sealed class 놎
	{
		public BasicBalanceCalculator 놰놡;

		public Symbol 놰놻;

		public double 놰놃;

		internal double 녴(SlTpHolder P_0)
		{
			return 놰놡.녴(놰놻, P_0, P_0.QuantityPercentage / 100.0, 놰놃);
		}

		internal double 놴(SlTpHolder P_0)
		{
			return 놰놡.녴(놰놻, P_0, P_0.Quantity, 놰놃);
		}
	}

	[CompilerGenerated]
	private bool 놫놶;

	[CompilerGenerated]
	private double? 놫뇏;

	[CompilerGenerated]
	private string 놫녻;

	[CompilerGenerated]
	private readonly bool 놫녙;

	[CompilerGenerated]
	private bool 놫놢;

	protected OrderRequestParameters RequestParameters;

	private string 놫녧;

	private Task 놫녤;

	private Task 놫놆;

	protected SettingItem QuantityItem;

	private SettingItem 놫뇎;

	private SettingItem 놫놷;

	public bool DisplayQuantityInLots
	{
		[CompilerGenerated]
		get
		{
			return 놫놶;
		}
		[CompilerGenerated]
		set
		{
			놫놶 = value;
		}
	}

	public double? CurrentFillPrice
	{
		[CompilerGenerated]
		get
		{
			return 놫뇏;
		}
		[CompilerGenerated]
		set
		{
			놫뇏 = value;
		}
	}

	public string QuantityDefiningSettingName
	{
		[CompilerGenerated]
		get
		{
			return 놫녻;
		}
		[CompilerGenerated]
		set
		{
			놫녻 = value;
		}
	}

	public bool AsyncBehavior
	{
		[CompilerGenerated]
		get
		{
			return 놫녙;
		}
		[CompilerGenerated]
		init
		{
			놫녙 = value;
		}
	}

	protected bool SkipChanges
	{
		[CompilerGenerated]
		get
		{
			return 놫놢;
		}
		[CompilerGenerated]
		set
		{
			놫놢 = value;
		}
	}

	public BasicBalanceCalculator()
	{
		AsyncBehavior = false;
	}

	public void Populate(SettingItem[] orderSettings, OrderRequestParameters requestParameters)
	{
		if (AsyncBehavior)
		{
			놫녤 = Task.Run(delegate
			{
				PopulateAction(orderSettings, requestParameters);
			});
		}
		else
		{
			PopulateAction(orderSettings, requestParameters);
		}
	}

	protected virtual void PopulateAction(SettingItem[] orderSettings, OrderRequestParameters requestParameters)
	{
		RequestParameters = requestParameters;
		QuantityItem = orderSettings?.GetItemByName(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶녯());
		놫뇎 = orderSettings?.GetItemByName(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶놮());
		놫놷 = orderSettings?.GetItemByName(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶녫());
		놴();
		Recalculate();
	}

	public void OnOrderSettingChanged(string settingName, OrderRequestParameters requestParameters)
	{
		놂 CS_0024_003C_003E8__locals11 = new 놂();
		CS_0024_003C_003E8__locals11.놰놇 = this;
		CS_0024_003C_003E8__locals11.놰뇅 = requestParameters;
		CS_0024_003C_003E8__locals11.놰놵 = settingName;
		if (SkipChanges || 놫녧 != null)
		{
			return;
		}
		if (AsyncBehavior)
		{
			놫놆 = Task.Run(delegate
			{
				try
				{
					CS_0024_003C_003E8__locals11.놰놇.RequestParameters = CS_0024_003C_003E8__locals11.놰뇅;
					CS_0024_003C_003E8__locals11.놰놇.놫녧 = CS_0024_003C_003E8__locals11.놰놵;
					CS_0024_003C_003E8__locals11.놰놇.OnOrderSettingChanged(CS_0024_003C_003E8__locals11.놰놵);
				}
				catch (Exception ex)
				{
					Core.Instance.Loggers.Log(ex);
				}
				finally
				{
					CS_0024_003C_003E8__locals11.놰놇.놫녧 = null;
				}
			});
		}
		else
		{
			CS_0024_003C_003E8__locals11.녴();
		}
	}

	protected virtual void OnOrderSettingChanged(string settingName)
	{
		if (!(settingName == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶녯()))
		{
			if (!(settingName == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶놮()))
			{
				if (settingName == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶녫())
				{
					QuantityDefiningSettingName = settingName;
					OnRiskPercentChanged();
				}
				else
				{
					Recalculate();
				}
			}
			else
			{
				QuantityDefiningSettingName = settingName;
				OnRiskChanged();
			}
		}
		else
		{
			QuantityDefiningSettingName = settingName;
			OnQuantityChanged();
		}
	}

	public void OnTimerTick()
	{
		OrderRequestParameters requestParameters = RequestParameters;
		if (requestParameters != null && requestParameters.OrderType?.Behavior == OrderTypeBehavior.Market && 놫녧 == null)
		{
			Recalculate();
		}
	}

	protected void Recalculate()
	{
		string text = 놫녧;
		try
		{
			놫녧 = QuantityDefiningSettingName ?? _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶녯();
			놴();
			RecalculateAction(놫녧);
		}
		catch (Exception ex)
		{
			Core.Instance.Loggers.Log(ex);
		}
		finally
		{
			놫녧 = text;
		}
	}

	protected virtual void RecalculateAction(string processingSettingName)
	{
		if (!(processingSettingName == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶녯()))
		{
			if (!(processingSettingName == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶놮()))
			{
				if (processingSettingName == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶녫())
				{
					OnRiskPercentChanged();
				}
			}
			else
			{
				OnRiskChanged();
			}
		}
		else
		{
			OnQuantityChanged();
		}
	}

	public void Dispose()
	{
		if (AsyncBehavior)
		{
			Task.WhenAll(놫녤 ?? Task.CompletedTask, 놫놆 ?? Task.CompletedTask).ContinueWith(delegate
			{
				DisposeAction();
			});
		}
		else
		{
			DisposeAction();
		}
	}

	protected virtual void DisposeAction()
	{
		QuantityItem = null;
	}

	protected virtual void OnQuantityChanged()
	{
		if (QuantityItem != null)
		{
			UpdateRisk(GetQuantity());
			UpdateRiskPercent(GetRisk());
		}
	}

	protected virtual void OnRiskChanged()
	{
		if (놫뇎 != null)
		{
			double? risk = GetRisk();
			녴(risk);
			UpdateRiskPercent(risk);
		}
	}

	protected virtual void OnRiskPercentChanged()
	{
		double? num = 녴();
		double? availableBalance = GetAvailableBalance();
		if (num.HasValue && availableBalance.HasValue)
		{
			double value = availableBalance.Value * num.Value / 100.0;
			녴(value, SettingItemValueChangingReason.Programmatically);
			녴(value);
		}
	}

	protected void UpdateQuantity(double? quantity, SettingItemValueChangingReason reason)
	{
		if (quantity.HasValue)
		{
			QuantityItem.SetValueWithReason(CoreMath.FloorToIncrement(quantity.Value, RequestParameters.Symbol.LotStep), reason);
		}
	}

	private void 녴(double? P_0)
	{
		Symbol 놰놻 = RequestParameters?.Symbol;
		List<SlTpHolder> list = RequestParameters?.StopLossItems;
		if (!P_0.HasValue || QuantityItem == null || !CurrentFillPrice.HasValue || list == null || list.Count == 0 || 놰놻 == null)
		{
			return;
		}
		double 놰놃 = CurrentFillPrice.Value;
		double value;
		if (list.Count == 1)
		{
			SlTpHolder slTpHolder = list[0];
			value = CoreMath.RoundToIncrement(P_0.Value / 녴(놰놻, slTpHolder, 1.0, 놰놃), 놰놻.LotStep);
		}
		else if (list.All((SlTpHolder P_0) => !double.IsNaN(P_0.QuantityPercentage)))
		{
			double num = list.Sum((SlTpHolder P_0) => 녴(놰놻, P_0, P_0.QuantityPercentage / 100.0, 놰놃));
			value = CoreMath.RoundToIncrement(P_0.Value / num, 놰놻.LotStep);
		}
		else
		{
			SlTpHolder[] array = list.Take(list.Count - 1).ToArray();
			SlTpHolder slTpHolder2 = list.Last();
			if (array.Length < 1)
			{
				return;
			}
			double num2 = array.Sum((SlTpHolder P_0) => 녴(놰놻, P_0, P_0.Quantity, 놰놃));
			double num3 = P_0.Value - num2;
			if (num3 <= 0.0)
			{
				value = 놰놻.MinLot;
			}
			else
			{
				double num4 = CoreMath.RoundToIncrement(num3 / 녴(놰놻, slTpHolder2, 1.0, 놰놃), 놰놻.LotStep);
				value = array.Sum((SlTpHolder P_0) => P_0.Quantity) + num4;
			}
		}
		UpdateQuantity(value, SettingItemValueChangingReason.Programmatically);
	}

	private void 녴(double? P_0, SettingItemValueChangingReason P_1)
	{
		if (P_0.HasValue)
		{
			놫뇎.SetValueWithReason(P_0.Value, P_1);
		}
	}

	protected void UpdateRisk(double? quantity)
	{
		Symbol symbol = RequestParameters?.Symbol;
		List<SlTpHolder> list = RequestParameters?.StopLossItems;
		if (!quantity.HasValue || 놫뇎 == null || !CurrentFillPrice.HasValue || list == null || list.Count == 0 || symbol == null || !RequestParameters.TryCorrectBracketsQuantity(out var _))
		{
			return;
		}
		double value = CurrentFillPrice.Value;
		double num = 0.0;
		foreach (SlTpHolder item in list)
		{
			double num2 = item.Quantity;
			if (double.IsNaN(num2))
			{
				num2 = quantity.Value;
			}
			num += 녴(symbol, item, num2, value);
		}
		놫뇎.SetValueWithReason(num, SettingItemValueChangingReason.Programmatically);
	}

	protected void UpdateRiskPercent(double? risk)
	{
		double? availableBalance = GetAvailableBalance();
		if (risk.HasValue && 놫놷 != null && availableBalance.HasValue && availableBalance != 0.0)
		{
			double num = risk.Value / availableBalance.Value * 100.0;
			놫놷.SetValueWithReason(num, SettingItemValueChangingReason.Programmatically);
		}
	}

	protected virtual double? GetAvailableBalance()
	{
		return RequestParameters?.Account?.Balance;
	}

	protected double? GetQuantity()
	{
		double? result = QuantityItem?.GetValue<double>();
		if (!result.HasValue)
		{
			return null;
		}
		if (!DisplayQuantityInLots && RequestParameters?.Symbol != null)
		{
			return result.Value / RequestParameters.Symbol.LotSize;
		}
		return result;
	}

	protected double? GetRisk()
	{
		return 놫뇎?.GetValue<double>();
	}

	private double? 녴()
	{
		return 놫놷?.GetValue<double>();
	}

	private void 놴()
	{
		CurrentFillPrice = RequestParameters.OrderType?.GetFillPrice(RequestParameters);
	}

	private double 녴(Symbol P_0, SlTpHolder P_1, double P_2, double P_3)
	{
		double num = P_1.Price;
		if (P_1.PriceMeasurement == PriceMeasurement.Offset)
		{
			num = RequestParameters.Symbol.CalculatePrice(P_3, (double)((RequestParameters.Side != 0) ? 1 : (-1)) * num);
		}
		double num2 = Math.Abs(P_0.CalculateValue(RequestParameters.Side, P_3, P_2));
		double num3 = Math.Abs(P_0.CalculateValue(RequestParameters.Side, num, P_2));
		return Math.Abs(num2 - num3);
	}

	[CompilerGenerated]
	private void 녴(Task P_0)
	{
		DisposeAction();
	}
}
