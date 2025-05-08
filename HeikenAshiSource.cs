using System.Runtime.Serialization;

namespace TradingPlatform.BusinessLayer;

public enum HeikenAshiSource
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
	Year,
	[EnumMember]
	Volume
}
