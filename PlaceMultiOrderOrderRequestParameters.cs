using System.Linq;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;

namespace TradingPlatform.BusinessLayer;

public class PlaceMultiOrderOrderRequestParameters : TradingRequestParameters
{
	[CompilerGenerated]
	private PlaceOrderRequestParameters[] 놵녢;

	[CompilerGenerated]
	private GroupOrderType 놵놞;

	public override string ConnectionId => OrderParameters?.FirstOrDefault()?.Symbol?.ConnectionId;

	public override string Event => _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놄놡();

	public override string Message
	{
		get
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(25, 1);
			defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놄놻());
			defaultInterpolatedStringHandler.AppendFormatted(base.RequestId);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}
	}

	public override RequestType Type => RequestType.PlaceMultiOrderOrder;

	public PlaceOrderRequestParameters[] OrderParameters
	{
		[CompilerGenerated]
		get
		{
			return 놵녢;
		}
		[CompilerGenerated]
		set
		{
			놵녢 = value;
		}
	}

	public GroupOrderType GroupOrderType
	{
		[CompilerGenerated]
		get
		{
			return 놵놞;
		}
		[CompilerGenerated]
		set
		{
			놵놞 = value;
		}
	}

	protected override Account GetAccount()
	{
		return null;
	}

	public PlaceMultiOrderOrderRequestParameters()
	{
	}

	public PlaceMultiOrderOrderRequestParameters(PlaceMultiOrderOrderRequestParameters original)
		: base(original)
	{
		OrderParameters = original.OrderParameters;
		GroupOrderType = original.GroupOrderType;
	}
}
