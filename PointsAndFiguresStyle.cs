using System.ComponentModel;

namespace TradingPlatform.BusinessLayer;

[Published]
public enum PointsAndFiguresStyle
{
	[Description("Classic")]
	Classic,
	[Description("High/Low")]
	HighLow
}
