using System.Runtime.Serialization;

namespace TradingPlatform.BusinessLayer;

/// <summary>
/// Period that can be used as a basis for history aggregations
/// </summary>
[DataContract(Name = "BasePeriod", Namespace = "TradingPlatform")]
[Published]
public enum BasePeriod
{
	[EnumMember]
	Tick,
	[EnumMember]
	Second,
	[EnumMember]
	Minute,
	[EnumMember]
	Hour,
	[EnumMember]
	Day,
	[EnumMember]
	Week,
	[EnumMember]
	Month,
	[EnumMember]
	Year
}
