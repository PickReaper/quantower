using System.ComponentModel;
using System.Runtime.Serialization;

namespace TradingPlatform.BusinessLayer;

[DataContract(Name = "NettingType", Namespace = "TradingPlatform")]
public enum NettingType
{
	[Description("Undefined")]
	[EnumMember]
	Undefined,
	[Description("Multiple positions")]
	[EnumMember]
	MultiPosition,
	[Description("Multiple positions per side")]
	[EnumMember]
	MultiPerSide,
	[Description("One position")]
	[EnumMember]
	OnePosition,
	[Description("One position per side")]
	[EnumMember]
	OnePositionPerSide
}
