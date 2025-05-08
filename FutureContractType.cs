using System.Runtime.Serialization;

namespace TradingPlatform.BusinessLayer;

[DataContract(Name = "FutureContractType", Namespace = "TradingPlatform")]
public enum FutureContractType
{
	[EnumMember]
	Contract,
	[EnumMember]
	Continuous,
	[EnumMember]
	Spread
}
