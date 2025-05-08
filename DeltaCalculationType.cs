using System.ComponentModel;
using System.Runtime.Serialization;

namespace TradingPlatform.BusinessLayer;

[DataContract(Name = "DeltaCalculationType", Namespace = "TradingPlatform")]
public enum DeltaCalculationType
{
	[Description("Aggressor flag")]
	[EnumMember(Value = "Aggressor flag")]
	AggressorFlag,
	[Description("Tick direction")]
	[EnumMember(Value = "Tick direction")]
	TickDirection
}
