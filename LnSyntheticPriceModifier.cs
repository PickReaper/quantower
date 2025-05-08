using System;

namespace TradingPlatform.BusinessLayer;

public class LnSyntheticPriceModifier : SyntheticPriceModifier
{
	public override SyntheticPriceModifierType Type => SyntheticPriceModifierType.Ln;

	public override double CalculatePrice(double coefficient, double price)
	{
		return coefficient * Math.Log(price);
	}
}
