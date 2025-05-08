using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;

namespace TradingPlatform.BusinessLayer;

public abstract class CryptoBalanceCalculator : BasicBalanceCalculator
{
	private SettingItemDoubleWithLink 놰뇇;

	private SettingItemSlider 놰놛;

	protected override void PopulateAction(SettingItem[] orderSettings, OrderRequestParameters requestParameters)
	{
		RequestParameters = requestParameters;
		if (놰뇇 != null)
		{
			놰뇇.LinkAction = null;
		}
		놰뇇 = orderSettings?.GetItemByName(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸놜()) as SettingItemDoubleWithLink;
		놰놛 = orderSettings?.GetItemByName(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸놨()) as SettingItemSlider;
		if (놰뇇 != null)
		{
			놰뇇.LinkAction = OnLinkAction;
			PopulateTotal();
		}
		base.PopulateAction(orderSettings, requestParameters);
	}

	protected override void OnOrderSettingChanged(string settingName)
	{
		if (!(settingName == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇋뇊()))
		{
			if (!(settingName == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸놜()))
			{
				if (settingName == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸놨())
				{
					base.QuantityDefiningSettingName = settingName;
					OnPercentChanged();
				}
			}
			else
			{
				base.QuantityDefiningSettingName = settingName;
				OnTotalChanged();
			}
		}
		else
		{
			OnSideChanged();
		}
		base.OnOrderSettingChanged(settingName);
	}

	protected override void RecalculateAction(string processingSettingName)
	{
		if (!(processingSettingName == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸놜()))
		{
			if (processingSettingName == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸놨())
			{
				OnPercentChanged();
			}
			else
			{
				base.RecalculateAction(processingSettingName);
			}
		}
		else
		{
			OnTotalChanged();
		}
	}

	protected override void DisposeAction()
	{
		놰뇇 = null;
		놰놛 = null;
		base.DisposeAction();
	}

	protected virtual double CalculateQuantity(double total, double fillPrice)
	{
		return (double)((decimal)total / (decimal)fillPrice);
	}

	protected virtual double CalculateTotal(double quantity, double fillPrice)
	{
		return (double)((decimal)fillPrice * (decimal)quantity);
	}

	protected virtual string GetTotalLinkText()
	{
		return _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇅();
	}

	protected virtual ulong CalculateSliderStep()
	{
		return 0uL;
	}

	protected override void OnQuantityChanged()
	{
		base.OnQuantityChanged();
		if (QuantityItem != null)
		{
			UpdateTotal(GetQuantity());
			UpdateSlider();
		}
	}

	protected override void OnRiskChanged()
	{
		base.OnRiskChanged();
		if (QuantityItem != null)
		{
			UpdateTotal(GetQuantity());
			UpdateSlider();
		}
	}

	protected override void OnRiskPercentChanged()
	{
		base.OnRiskPercentChanged();
		if (QuantityItem != null)
		{
			UpdateTotal(GetQuantity());
			UpdateSlider();
		}
	}

	protected virtual void OnSideChanged()
	{
	}

	protected virtual void OnTotalChanged()
	{
		if (놰뇇 != null)
		{
			UpdateQuantity(GetTotal());
			UpdateSlider();
			UpdateRisk(GetQuantity());
			UpdateRiskPercent(GetRisk());
		}
	}

	protected abstract void OnLinkAction(object obj);

	protected abstract void OnPercentChanged();

	protected void UpdateQuantity(double? total)
	{
		if (total.HasValue && QuantityItem != null && base.CurrentFillPrice.HasValue)
		{
			double value = base.CurrentFillPrice.Value;
			if (!value.IsNanOrDefault())
			{
				double value2 = CalculateQuantity(total.Value, value);
				UpdateQuantity(value2, SettingItemValueChangingReason.Programmatically);
			}
		}
	}

	protected void UpdateTotal(double? quantity)
	{
		if (quantity.HasValue && 놰뇇 != null && base.CurrentFillPrice.HasValue)
		{
			double value = base.CurrentFillPrice.Value;
			if (!double.IsNaN(value))
			{
				UpdateTotal(CalculateTotal(quantity.Value, value), SettingItemValueChangingReason.Programmatically);
			}
		}
	}

	protected void UpdateTotal(double? total, SettingItemValueChangingReason reason)
	{
		if (total.HasValue)
		{
			놰뇇.SetValueWithReason(total, reason);
		}
	}

	protected void UpdateTotalLink()
	{
		if (놰뇇 != null)
		{
			놰뇇.LinkText = GetTotalLinkText();
		}
	}

	protected void UpdateSlider()
	{
		if (놰놛 != null)
		{
			ulong num = CalculateSliderStep();
			놰놛.SetValueWithReason(num, SettingItemValueChangingReason.Programmatically);
		}
	}

	protected void PopulateTotal()
	{
		if (놰뇇 != null)
		{
			double num = 1.0;
			int decimalPlaces = 0;
			string dimension = string.Empty;
			Asset totalAsset = GetTotalAsset();
			if (totalAsset != null)
			{
				num = totalAsset.MinimumChange;
				decimalPlaces = totalAsset.Precision;
				dimension = totalAsset.Name;
			}
			놰뇇.Minimum = num;
			놰뇇.Maximum = double.MaxValue;
			놰뇇.Increment = num;
			놰뇇.DecimalPlaces = decimalPlaces;
			놰뇇.Dimension = dimension;
		}
	}

	protected double? GetTotal()
	{
		return 놰뇇?.GetValue<double>();
	}

	protected double? GetSliderPercent()
	{
		return (double?)놰놛?.GetValue<ulong>() / 100.0;
	}

	protected virtual Asset GetTotalAsset()
	{
		return RequestParameters?.Symbol?.QuotingCurrency;
	}
}
