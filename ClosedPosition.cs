using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using TradingPlatform.BusinessLayer.Integration;

namespace TradingPlatform.BusinessLayer;

public class ClosedPosition : Position
{
	[CompilerGenerated]
	private double 뇇놸;

	public double LastTradedPrice
	{
		[CompilerGenerated]
		get
		{
			return 뇇놸;
		}
		[CompilerGenerated]
		private set
		{
			뇇놸 = value;
		}
	}

	internal ClosedPosition(string P_0)
		: base(P_0)
	{
	}

	public override TradingOperationResult Close(double closeQuantity = -1.0)
	{
		return TradingOperationResult.CreateError(new ClosePositionRequestParameters().RequestId, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰놈());
	}

	internal override void 녴(MessageOpenPosition P_0)
	{
		base.녴(P_0);
		if (P_0 is MessageClosedPosition messageClosedPosition)
		{
			LastTradedPrice = messageClosedPosition.LastTradedPrice;
		}
	}
}
