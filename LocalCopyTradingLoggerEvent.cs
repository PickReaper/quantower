using System.Runtime.CompilerServices;

namespace TradingPlatform.BusinessLayer;

public class LocalCopyTradingLoggerEvent : LoggerEvent
{
	[CompilerGenerated]
	private string 녲뇂;

	[CompilerGenerated]
	private PlaceOrderRequestParameters 녲놩;

	public string ConnectionName
	{
		[CompilerGenerated]
		get
		{
			return 녲뇂;
		}
		[CompilerGenerated]
		set
		{
			녲뇂 = value;
		}
	}

	public PlaceOrderRequestParameters OrderRequestParameters
	{
		[CompilerGenerated]
		get
		{
			return 녲놩;
		}
		[CompilerGenerated]
		set
		{
			녲놩 = value;
		}
	}
}
