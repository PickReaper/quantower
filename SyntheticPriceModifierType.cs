using System.ComponentModel;

namespace TradingPlatform.BusinessLayer;

public enum SyntheticPriceModifierType
{
	Undefined,
	[Description("Basic")]
	Basic,
	[Description("Ln")]
	Ln
}
