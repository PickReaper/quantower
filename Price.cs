using System.Runtime.CompilerServices;

namespace TradingPlatform.BusinessLayer;

public class Price
{
	[CompilerGenerated]
	private PriceType 녺;

	[CompilerGenerated]
	private double 놣;

	public PriceType Type
	{
		[CompilerGenerated]
		get
		{
			return 녺;
		}
		[CompilerGenerated]
		private set
		{
			녺 = value;
		}
	}

	public double Value
	{
		[CompilerGenerated]
		get
		{
			return 놣;
		}
		[CompilerGenerated]
		private set
		{
			놣 = value;
		}
	}

	public Price(PriceType priceType)
	{
		Type = priceType;
		Value = double.NaN;
	}

	public Price(PriceType priceType, double value)
	{
		Type = priceType;
		Value = value;
	}
}
