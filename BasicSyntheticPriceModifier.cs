namespace TradingPlatform.BusinessLayer;

public class BasicSyntheticPriceModifier : SyntheticPriceModifier
{
	public override SyntheticPriceModifierType Type => SyntheticPriceModifierType.Basic;

	public override double CalculatePrice(double coefficient, double price)
	{
		return coefficient * price;
	}
}
