namespace TradingPlatform.BusinessLayer;

public class PaperRequest : PlaceOrderRequestParameters
{
	public PaperRequest()
	{
	}

	public PaperRequest(PaperRequest request)
		: base(request)
	{
	}
}
