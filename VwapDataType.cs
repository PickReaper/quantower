using System.ComponentModel;

namespace TradingPlatform.BusinessLayer;

public enum VwapDataType
{
	[Description("Tick")]
	Tick,
	[Description("Current TF")]
	CurrentTF
}
