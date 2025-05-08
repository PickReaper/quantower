using System.Runtime.Serialization;

namespace TradingPlatform.BusinessLayer;

[DataContract(Name = "OptionType", Namespace = "TradingPlatform")]
public enum OptionType
{
	[EnumMember]
	Call,
	[EnumMember]
	Put
}
