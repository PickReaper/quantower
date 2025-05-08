using System.Runtime.Serialization;

namespace TradingPlatform.BusinessLayer;

[DataContract(Name = "InstrumentQuotingType", Namespace = "TradingPlatform")]
public enum SymbolQuotingType
{
	[EnumMember]
	LotSize,
	[EnumMember]
	TickSizeTickCost,
	[EnumMember]
	Undefined
}
