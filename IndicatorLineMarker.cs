using System.Drawing;
using System.Runtime.CompilerServices;

namespace TradingPlatform.BusinessLayer;

/// <summary>
/// Using IndicatorLineMarker class you can mark by color or icon any point of your indicator's line.
/// </summary>
public class IndicatorLineMarker
{
	[CompilerGenerated]
	private Color 놬 = Color.Empty;

	[CompilerGenerated]
	private IndicatorLineMarkerIconType 놊;

	[CompilerGenerated]
	private IndicatorLineMarkerIconType 놪;

	/// <summary>
	/// Color of the marker
	/// </summary>
	public Color Color
	{
		[CompilerGenerated]
		get
		{
			return 놬;
		}
		[CompilerGenerated]
		set
		{
			놬 = value;
		}
	}

	/// <summary>
	/// Icon that will be drawn above the indicator line
	/// </summary>
	public IndicatorLineMarkerIconType UpperIcon
	{
		[CompilerGenerated]
		get
		{
			return 놊;
		}
		[CompilerGenerated]
		set
		{
			놊 = value;
		}
	}

	/// <summary>
	/// Icon that will be drawn beyond the indicator line
	/// </summary>
	public IndicatorLineMarkerIconType BottomIcon
	{
		[CompilerGenerated]
		get
		{
			return 놪;
		}
		[CompilerGenerated]
		set
		{
			놪 = value;
		}
	}

	/// <summary>
	/// Constructor for IndicatorLineMarker
	/// </summary>
	/// <param name="color"></param>
	/// <param name="upperIcon"></param>
	/// <param name="bottomIcon"></param>
	public IndicatorLineMarker(Color color, IndicatorLineMarkerIconType upperIcon = IndicatorLineMarkerIconType.None, IndicatorLineMarkerIconType bottomIcon = IndicatorLineMarkerIconType.None)
	{
		Color = color;
		UpperIcon = upperIcon;
		BottomIcon = bottomIcon;
	}

	/// <summary>
	/// Constructor for IndicatorLineMarker
	/// </summary>       
	public IndicatorLineMarker()
	{
	}
}
