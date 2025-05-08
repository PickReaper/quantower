using System.ComponentModel;
using System.Reflection;

namespace TradingPlatform.BusinessLayer;

[Obfuscation(Exclude = true)]
public enum TickDirection
{
	[Description("Not set")]
	NotSet,
	[Description("None")]
	None,
	[Description("Up")]
	Up,
	[Description("Down")]
	Down
}
