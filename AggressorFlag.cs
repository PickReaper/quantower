using System.ComponentModel;
using System.Reflection;

namespace TradingPlatform.BusinessLayer;

[Obfuscation(Exclude = true)]
public enum AggressorFlag
{
	[Description("None")]
	None,
	[Description("Buy")]
	Buy,
	[Description("Sell")]
	Sell,
	[Description("Not set")]
	NotSet
}
