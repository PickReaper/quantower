using System.Runtime.CompilerServices;

namespace TradingPlatform.BusinessLayer;

public class NativeKeyEventArgs
{
	[CompilerGenerated]
	private readonly NativeKey 놴놕;

	[CompilerGenerated]
	private readonly NativeModifierKeys 놴뇊;

	[CompilerGenerated]
	private bool 놴놋;

	[CompilerGenerated]
	private bool 놴녣;

	public NativeKey Key
	{
		[CompilerGenerated]
		get
		{
			return 놴놕;
		}
	}

	public NativeModifierKeys Modifiers
	{
		[CompilerGenerated]
		get
		{
			return 놴뇊;
		}
	}

	public bool Handled
	{
		[CompilerGenerated]
		get
		{
			return 놴놋;
		}
		[CompilerGenerated]
		set
		{
			놴놋 = value;
		}
	}

	public bool IsRepeated
	{
		[CompilerGenerated]
		get
		{
			return 놴녣;
		}
		[CompilerGenerated]
		set
		{
			놴녣 = value;
		}
	}

	public NativeKeyEventArgs(NativeKey key, NativeModifierKeys modifiers)
	{
		놴놕 = key;
		놴뇊 = modifiers;
	}
}
