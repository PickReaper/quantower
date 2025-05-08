using System.Drawing;
using System.Runtime.CompilerServices;

namespace TradingPlatform.BusinessLayer;

[Published]
public class PaintChartEventArgs
{
	[CompilerGenerated]
	private Graphics 놌;

	[CompilerGenerated]
	private bool 놕;

	[CompilerGenerated]
	private Rectangle 뇊;

	[CompilerGenerated]
	private Point 놋;

	[CompilerGenerated]
	private int 녣;

	public Graphics Graphics
	{
		[CompilerGenerated]
		get
		{
			return 놌;
		}
		[CompilerGenerated]
		set
		{
			놌 = value;
		}
	}

	public bool DrawBackground
	{
		[CompilerGenerated]
		get
		{
			return 놕;
		}
		[CompilerGenerated]
		set
		{
			놕 = value;
		}
	}

	public Rectangle Rectangle
	{
		[CompilerGenerated]
		get
		{
			return 뇊;
		}
		[CompilerGenerated]
		set
		{
			뇊 = value;
		}
	}

	public Point MousePosition
	{
		[CompilerGenerated]
		get
		{
			return 놋;
		}
		[CompilerGenerated]
		set
		{
			놋 = value;
		}
	}

	public int WindowIndex
	{
		[CompilerGenerated]
		get
		{
			return 녣;
		}
		[CompilerGenerated]
		set
		{
			녣 = value;
		}
	}

	public PaintChartEventArgs(Graphics graphics, Rectangle rectangle, Point mousePosition, int windowIndex)
	{
		Graphics = graphics;
		Rectangle = rectangle;
		MousePosition = mousePosition;
		WindowIndex = windowIndex;
	}
}
