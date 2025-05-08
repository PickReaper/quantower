using System.Runtime.Serialization;

namespace TradingPlatform.BusinessLayer;

/// <summary>
/// The comparing type.
/// </summary>
[DataContract(Name = "ComparingType", Namespace = "TradingPlatform")]
public enum ComparingType
{
	[EnumMember]
	String,
	[EnumMember]
	Int,
	[EnumMember]
	Double,
	[EnumMember]
	Long,
	[EnumMember]
	DateTime,
	[EnumMember]
	Boolean
}
