using System;
using System.Runtime.CompilerServices;

namespace TradingPlatform.BusinessLayer;

public class GroupActionInfo
{
	[CompilerGenerated]
	private Func<object, string> 놴놶;

	[CompilerGenerated]
	private IconType 놴뇏;

	[CompilerGenerated]
	private object 놴녻 = new object();

	[CompilerGenerated]
	private bool 놴녙;

	[CompilerGenerated]
	private ManualChangesApplyingType 놴놢;

	[CompilerGenerated]
	private string 놴녧;

	[CompilerGenerated]
	private string 놴녤;

	[CompilerGenerated]
	private string 놴놆;

	public Func<object, string> Action
	{
		[CompilerGenerated]
		get
		{
			return 놴놶;
		}
		[CompilerGenerated]
		private set
		{
			놴놶 = value;
		}
	}

	public IconType IconType
	{
		[CompilerGenerated]
		get
		{
			return 놴뇏;
		}
		[CompilerGenerated]
		set
		{
			놴뇏 = value;
		}
	}

	public object Tag
	{
		[CompilerGenerated]
		get
		{
			return 놴녻;
		}
		[CompilerGenerated]
		set
		{
			놴녻 = value;
		}
	}

	public bool NeedActionConfirmation
	{
		[CompilerGenerated]
		get
		{
			return 놴녙;
		}
		[CompilerGenerated]
		set
		{
			놴녙 = value;
		}
	}

	public ManualChangesApplyingType ManualChangesApplyingType
	{
		[CompilerGenerated]
		get
		{
			return 놴놢;
		}
		[CompilerGenerated]
		set
		{
			놴놢 = value;
		}
	}

	public string ConfirmationText
	{
		[CompilerGenerated]
		get
		{
			return 놴녧;
		}
		[CompilerGenerated]
		set
		{
			놴녧 = value;
		}
	}

	public string Marker
	{
		[CompilerGenerated]
		get
		{
			return 놴녤;
		}
		[CompilerGenerated]
		set
		{
			놴녤 = value;
		}
	}

	public string Tooltip
	{
		[CompilerGenerated]
		get
		{
			return 놴놆;
		}
		[CompilerGenerated]
		set
		{
			놴놆 = value;
		}
	}

	public GroupActionInfo(Func<object, string> action)
	{
		Action = action;
	}
}
