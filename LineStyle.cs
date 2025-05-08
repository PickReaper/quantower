using System.ComponentModel;

namespace TradingPlatform.BusinessLayer;

/// <summary>
/// Specifies the style of indicator line.
/// </summary>
[Published]
public enum LineStyle
{
	[Description("Solid")]
	Solid,
	[Description("Dash")]
	Dash,
	[Description("Dot")]
	Dot,
	[Description("Dash dot")]
	DashDot,
	[Description("Histogramm")]
	Histogramm,
	[Description("Points")]
	Points,
	[Description("Columns")]
	Columns,
	[Description("Step line")]
	StepLine
}
