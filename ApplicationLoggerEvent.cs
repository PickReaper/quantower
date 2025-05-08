using System.Runtime.CompilerServices;

namespace TradingPlatform.BusinessLayer;

/// <summary>
/// The application logger event.
/// </summary>
public class ApplicationLoggerEvent : LoggerEvent
{
	[CompilerGenerated]
	private string 녲놼;

	[CompilerGenerated]
	private string 녲놗;

	public string Message
	{
		[CompilerGenerated]
		get
		{
			return 녲놼;
		}
		[CompilerGenerated]
		set
		{
			녲놼 = value;
		}
	}

	public string ConnectionName
	{
		[CompilerGenerated]
		get
		{
			return 녲놗;
		}
		[CompilerGenerated]
		set
		{
			녲놗 = value;
		}
	}
}
