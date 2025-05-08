using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;

namespace TradingPlatform.BusinessLayer;

public class MarketIfTouchedOrderType : StopOrderType
{
	public override string Id => _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놓놂();

	public override string Name => loc.key(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놓놎());

	public override string Abbreviation => _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놓녞();

	public MarketIfTouchedOrderType(params TimeInForce[] allowedTimeInForce)
		: base(allowedTimeInForce)
	{
		base.Usage = OrderTypeUsage.All;
	}
}
