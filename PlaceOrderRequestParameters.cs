using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;

namespace TradingPlatform.BusinessLayer;

[Published]
public class PlaceOrderRequestParameters : OrderRequestParameters
{
	public override RequestType Type => RequestType.PlaceOrder;

	public override string Event => (base.OrderType?.Name ?? _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂녥()) + _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰놺();

	public PlaceOrderRequestParameters()
	{
	}

	public PlaceOrderRequestParameters(IOrder order)
		: base(order)
	{
	}

	public PlaceOrderRequestParameters(OrderRequestParameters original)
		: base(original)
	{
	}

	public override object Clone()
	{
		return new PlaceOrderRequestParameters(this);
	}
}
