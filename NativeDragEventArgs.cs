using System.Drawing;
using System.Runtime.CompilerServices;

namespace TradingPlatform.BusinessLayer;

public class NativeDragEventArgs
{
	[CompilerGenerated]
	private NativeDragDropEffects 놴녩;

	[CompilerGenerated]
	private bool 놴놤;

	[CompilerGenerated]
	private readonly object[] 놴논;

	[CompilerGenerated]
	private object 놴녘;

	[CompilerGenerated]
	private readonly Point 놴노;

	public NativeDragDropEffects Effects
	{
		[CompilerGenerated]
		get
		{
			return 놴녩;
		}
		[CompilerGenerated]
		set
		{
			놴녩 = value;
		}
	}

	public bool Handled
	{
		[CompilerGenerated]
		get
		{
			return 놴놤;
		}
		[CompilerGenerated]
		set
		{
			놴놤 = value;
		}
	}

	public object[] Data
	{
		[CompilerGenerated]
		get
		{
			return 놴논;
		}
	}

	public object Source
	{
		[CompilerGenerated]
		get
		{
			return 놴녘;
		}
		[CompilerGenerated]
		set
		{
			놴녘 = value;
		}
	}

	public Point MousePosition
	{
		[CompilerGenerated]
		get
		{
			return 놴노;
		}
	}

	public NativeDragEventArgs(NativeDragDropEffects effects, object source, object[] data, Point mousePosition)
	{
		Effects = effects;
		Source = source;
		놴논 = data;
		놴노 = mousePosition;
	}

	public NativeDragEventArgs(object source, object[] data, Point mousePosition)
	{
		Source = source;
		놴논 = data;
		놴노 = mousePosition;
	}
}
