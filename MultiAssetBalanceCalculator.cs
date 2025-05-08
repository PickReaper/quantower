using System.Runtime.CompilerServices;

namespace TradingPlatform.BusinessLayer;

public class MultiAssetBalanceCalculator : CryptoBalanceCalculator
{
	private CryptoAssetBalances 놻놶;

	private CryptoAccount 놻뇏;

	protected CryptoAssetBalances CurrentBalance
	{
		get
		{
			return 놻놶;
		}
		set
		{
			if (놻놶 != value)
			{
				놻놶 = value;
				UpdateTotalLink();
				Recalculate();
			}
		}
	}

	private CryptoAccount CurrentAccount
	{
		get
		{
			return 놻뇏;
		}
		set
		{
			if (놻뇏 == value)
			{
				녴();
				return;
			}
			if (놻뇏 != null)
			{
				놻뇏.BalanceUpdated -= 녴;
			}
			놻뇏 = value;
			if (놻뇏 != null)
			{
				놻뇏.BalanceUpdated += 녴;
			}
			녴();
		}
	}

	protected override void PopulateAction(SettingItem[] orderSettings, OrderRequestParameters requestParameters)
	{
		base.PopulateAction(orderSettings, requestParameters);
		CurrentAccount = requestParameters.Account as CryptoAccount;
	}

	protected override void DisposeAction()
	{
		base.DisposeAction();
		CurrentAccount = null;
		CurrentBalance = null;
	}

	protected override string GetTotalLinkText()
	{
		if (CurrentBalance == null)
		{
			return base.GetTotalLinkText();
		}
		return CurrentBalance.Asset.FormatPriceWithCurrency(GetAvailableBalance().GetValueOrDefault());
	}

	protected override ulong CalculateSliderStep()
	{
		if (RequestParameters == null || CurrentBalance == null)
		{
			return base.CalculateSliderStep();
		}
		double? num = ((RequestParameters.Side != 0) ? GetQuantity() : GetTotal());
		if (!num.HasValue)
		{
			return base.CalculateSliderStep();
		}
		double? num2 = GetAvailableBalance();
		if ((!num2.HasValue || num2.GetValueOrDefault() == 0.0) ? true : false)
		{
			num2 = 1.0;
		}
		return (ulong)(num.Value * 100.0 * 100.0 / num2).Value;
	}

	protected override double? GetAvailableBalance()
	{
		return CurrentBalance?.AvailableBalance ?? 0.0;
	}

	protected override void OnSideChanged()
	{
		녴();
		UpdateSlider();
	}

	protected override void OnLinkAction(object obj)
	{
		if (CurrentBalance != null && RequestParameters != null)
		{
			double valueOrDefault = GetAvailableBalance().GetValueOrDefault();
			if (RequestParameters.Side == Side.Buy)
			{
				UpdateTotal(valueOrDefault, SettingItemValueChangingReason.Manually);
			}
			else
			{
				UpdateQuantity(valueOrDefault, SettingItemValueChangingReason.Manually);
			}
		}
	}

	protected override void OnPercentChanged()
	{
		double? sliderPercent = GetSliderPercent();
		if (sliderPercent.HasValue && CurrentBalance != null && RequestParameters != null)
		{
			double valueOrDefault = GetAvailableBalance().GetValueOrDefault();
			if (RequestParameters.Side == Side.Buy)
			{
				double value = valueOrDefault * sliderPercent.Value / 100.0;
				UpdateQuantity(value);
				UpdateTotal(value, SettingItemValueChangingReason.Programmatically);
				UpdateRisk(GetQuantity());
				UpdateRiskPercent(GetRisk());
			}
			else
			{
				double value2 = valueOrDefault * sliderPercent.Value / 100.0;
				UpdateTotal(value2);
				UpdateQuantity(value2, SettingItemValueChangingReason.Programmatically);
				UpdateRisk(GetQuantity());
				UpdateRiskPercent(GetRisk());
			}
		}
	}

	private void 녴(object P_0, CryptoAccountEventArgs P_1)
	{
		if (CurrentBalance != null && !(P_1.Balances.AssetId != CurrentBalance.AssetId))
		{
			UpdateTotalLink();
			Recalculate();
		}
	}

	private void 녴()
	{
		try
		{
			CurrentBalance = 놴();
		}
		finally
		{
			UpdateTotalLink();
			Recalculate();
		}
	}

	[CompilerGenerated]
	private CryptoAssetBalances 놴()
	{
		CryptoAccount currentAccount = CurrentAccount;
		if (currentAccount == null || currentAccount.State != 0)
		{
			return null;
		}
		string text = ((RequestParameters.Side != 0) ? RequestParameters.Symbol?.Product?.Id : RequestParameters.Symbol?.QuotingCurrency?.Id);
		if (string.IsNullOrEmpty(text))
		{
			return null;
		}
		if (!CurrentAccount.TryGetAssetBalances(text, out var cryptoAssetBalances))
		{
			return null;
		}
		return cryptoAssetBalances;
	}
}
