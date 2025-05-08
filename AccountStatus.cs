using System.Runtime.Serialization;

namespace TradingPlatform.BusinessLayer;

[DataContract(Name = "AccountStatus", Namespace = "TradingPlatform")]
public enum AccountStatus
{
	[EnumMember]
	Active,
	[EnumMember]
	Closed,
	[EnumMember]
	Halted
}
