using System.ComponentModel;
using System.Runtime.Serialization;

namespace TradingPlatform.BusinessLayer;

public enum HistoryTaskStateEnum
{
	[Description("Stopped")]
	[EnumMember]
	Stopped,
	[Description("Active")]
	[EnumMember]
	Active,
	[Description("Completed")]
	[EnumMember]
	Completed
}
