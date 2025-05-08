using System;

namespace TradingPlatform.BusinessLayer;

public abstract class SyntheticPriceModifier
{
	public abstract SyntheticPriceModifierType Type { get; }

	public abstract double CalculatePrice(double coefficient, double price);

	public static SyntheticPriceModifier Create(SyntheticPriceModifierType type)
	{
		return type switch
		{
			SyntheticPriceModifierType.Undefined => new BasicSyntheticPriceModifier(), 
			SyntheticPriceModifierType.Basic => new BasicSyntheticPriceModifier(), 
			SyntheticPriceModifierType.Ln => new LnSyntheticPriceModifier(), 
			_ => throw new ArgumentOutOfRangeException(), 
		};
	}
}
