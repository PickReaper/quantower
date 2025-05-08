using System.Linq;
using System.Runtime.CompilerServices;

namespace TradingPlatform.BusinessLayer;

public abstract class MarginBasedBalanceCalculator : CryptoBalanceCalculator
{
	private Symbol 놻녱;

	private Account 놻놲;

	private Asset 놻높;

	protected Symbol CurrentSymbol
	{
		get
		{
			return 놻녱;
		}
		set
		{
			if (놻녱 == value)
			{
				return;
			}
			놻높 = null;
			if (놻녱 != null)
			{
				놻녱.Updated -= 녴;
			}
			놻녱 = value;
			if (놻녱 != null)
			{
				놻녱.Updated += 녴;
				놻높 = CurrentSymbol.Connection?.BusinessObjects.Assets.FirstOrDefault((Asset P_0) => P_0.Id == BalanceCurrency);
			}
		}
	}

	protected Account CurrentAccount
	{
		get
		{
			return 놻놲;
		}
		set
		{
			if (놻놲 != value)
			{
				if (놻놲 != null)
				{
					놻놲.Updated -= 녴;
				}
				놻놲 = value;
				if (놻놲 != null)
				{
					놻놲.Updated += 녴;
				}
			}
		}
	}

	protected virtual string BalanceCurrency => CurrentSymbol?.QuotingCurrency?.Id;

	protected override void PopulateAction(SettingItem[] orderSettings, OrderRequestParameters requestParameters)
	{
		base.PopulateAction(orderSettings, requestParameters);
		CurrentSymbol = requestParameters.Symbol;
		CurrentAccount = requestParameters.Account;
		PopulateTotal();
		UpdateTotalLink();
		Recalculate();
	}

	protected override void DisposeAction()
	{
		base.DisposeAction();
		CurrentAccount = null;
	}

	protected override string GetTotalLinkText()
	{
		double? availableBalance = GetAvailableBalance();
		if (!availableBalance.HasValue)
		{
			return base.GetTotalLinkText();
		}
		return 놻높?.FormatPriceWithCurrency(availableBalance.Value);
	}

	protected override ulong CalculateSliderStep()
	{
		double? total = GetTotal();
		if (!total.HasValue)
		{
			return base.CalculateSliderStep();
		}
		double? num = GetAvailableBalance();
		if (!num.HasValue)
		{
			return base.CalculateSliderStep();
		}
		if (num == 0.0)
		{
			num = 1.0;
		}
		return (ulong)(total.Value * 100.0 * 100.0 / num).Value;
	}

	protected override Asset GetTotalAsset()
	{
		return 놻높;
	}

	protected abstract double? GetAvailableForOrder();

	protected abstract int? GetLeverage();

	protected override void OnLinkAction(object obj)
	{
		UpdateTotal(GetAvailableBalance(), SettingItemValueChangingReason.Manually);
	}

	protected override void OnPercentChanged()
	{
		double? sliderPercent = GetSliderPercent();
		if (sliderPercent.HasValue)
		{
			double? availableBalance = GetAvailableBalance();
			if (availableBalance.HasValue)
			{
				double value = availableBalance.Value * sliderPercent.Value / 100.0;
				UpdateQuantity(value);
				UpdateTotal(GetQuantity());
				UpdateRisk(GetQuantity());
				UpdateRiskPercent(GetRisk());
			}
		}
	}

	private void 녴(Symbol P_0)
	{
		try
		{
			base.SkipChanges = true;
			UpdateTotalLink();
			Recalculate();
		}
		finally
		{
			base.SkipChanges = false;
		}
	}

	private void 녴(Account P_0)
	{
		try
		{
			base.SkipChanges = true;
			UpdateTotalLink();
			Recalculate();
		}
		finally
		{
			base.SkipChanges = false;
		}
	}

	protected override double? GetAvailableBalance()
	{
		double? availableForOrder = GetAvailableForOrder();
		if (!availableForOrder.HasValue)
		{
			return null;
		}
		int? leverage = GetLeverage();
		if (!leverage.HasValue)
		{
			return null;
		}
		return availableForOrder * (double?)leverage;
	}

	[CompilerGenerated]
	private bool 녴(Asset P_0)
	{
		return P_0.Id == BalanceCurrency;
	}
}
