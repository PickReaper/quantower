using System.ComponentModel;

namespace TradingPlatform.BusinessLayer;

public enum ColouringModes
{
	[Description("None")]
	None,
	[Description("Compare to previous")]
	Previous,
	[Description("By sign")]
	Signed
}
