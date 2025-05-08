using System.Runtime.Serialization;

namespace TradingPlatform.BusinessLayer;

[DataContract(Name = "InstrumentVolumeType", Namespace = "TradingPlatform")]
public enum SymbolVolumeType
{
	[EnumMember]
	Volume,
	[EnumMember]
	Ticks,
	[EnumMember]
	Disable
}
