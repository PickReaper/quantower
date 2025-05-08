using System.ComponentModel;
using System.Runtime.Serialization;

namespace TradingPlatform.BusinessLayer;

[DataContract(Name = "HistoryType", Namespace = "TradingPlatform")]
public enum HistoryType
{
	[Description("Bid")]
	[EnumMember]
	Bid,
	[Description("Ask")]
	[EnumMember]
	Ask,
	[Description("Midpoint")]
	[EnumMember]
	Midpoint,
	[Description("Last")]
	[EnumMember]
	Last,
	[Description("Bid/Ask")]
	[EnumMember]
	BidAsk,
	[Description("Mark")]
	[EnumMember]
	Mark
}
