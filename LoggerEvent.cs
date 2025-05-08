using System;
using System.Runtime.CompilerServices;

namespace TradingPlatform.BusinessLayer;

public class LoggerEvent
{
	[CompilerGenerated]
	private LoggingLevel 놂녞;

	[CompilerGenerated]
	private DateTime 놂놫;

	[CompilerGenerated]
	private string 놂녪;

	public LoggingLevel Type
	{
		[CompilerGenerated]
		get
		{
			return 놂녞;
		}
		[CompilerGenerated]
		set
		{
			놂녞 = value;
		}
	}

	public DateTime Date
	{
		[CompilerGenerated]
		get
		{
			return 놂놫;
		}
		[CompilerGenerated]
		set
		{
			놂놫 = value;
		}
	}

	public string Event
	{
		[CompilerGenerated]
		get
		{
			return 놂녪;
		}
		[CompilerGenerated]
		set
		{
			놂녪 = value;
		}
	}
}
