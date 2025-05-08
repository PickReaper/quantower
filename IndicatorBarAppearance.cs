using System.Drawing;
using System.Runtime.CompilerServices;

namespace TradingPlatform.BusinessLayer;

public class IndicatorBarAppearance
{
	[CompilerGenerated]
	private Color 놹;

	[CompilerGenerated]
	private Color 놘;

	[CompilerGenerated]
	private Color 뇌;

	public Color BarColor
	{
		[CompilerGenerated]
		get
		{
			return 놹;
		}
		[CompilerGenerated]
		set
		{
			놹 = value;
		}
	}

	public Color BorderColor
	{
		[CompilerGenerated]
		get
		{
			return 놘;
		}
		[CompilerGenerated]
		set
		{
			놘 = value;
		}
	}

	public Color WickColor
	{
		[CompilerGenerated]
		get
		{
			return 뇌;
		}
		[CompilerGenerated]
		set
		{
			뇌 = value;
		}
	}
}
