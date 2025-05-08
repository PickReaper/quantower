using System.ComponentModel;
using System.Runtime.Serialization;

namespace TradingPlatform.BusinessLayer;

public enum ScriptCreationType
{
	[Description("Default")]
	[EnumMember(Value = "Default")]
	Default,
	[Description("Custom")]
	[EnumMember(Value = "Custom")]
	Custom
}
