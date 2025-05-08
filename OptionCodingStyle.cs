using System.Runtime.Serialization;

namespace TradingPlatform.BusinessLayer;

[DataContract(Name = "OptionCodingStyle", Namespace = "TradingPlatform")]
public enum OptionCodingStyle
{
	[EnumMember]
	Unspecified,
	[EnumMember]
	European,
	[EnumMember]
	American
}
