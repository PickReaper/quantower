using System.Runtime.CompilerServices;

namespace TradingPlatform.BusinessLayer;

public class Loggable : ILoggable
{
	[CompilerGenerated]
	private readonly string 녲녡;

	[CompilerGenerated]
	private readonly string 녲녦;

	public string Event
	{
		[CompilerGenerated]
		get
		{
			return 녲녡;
		}
	}

	public string Message
	{
		[CompilerGenerated]
		get
		{
			return 녲녦;
		}
	}

	public Loggable(string @event, string message)
	{
		녲녡 = @event;
		녲녦 = message;
	}
}
