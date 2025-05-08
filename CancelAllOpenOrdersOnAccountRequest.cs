using System.Runtime.CompilerServices;
using TradingPlatform.BusinessLayer;

namespace CancelAllOpenOrdersRequests;

public class CancelAllOpenOrdersOnAccountRequest : RequestParameters, ISubTradingOperation
{
	[CompilerGenerated]
	private readonly string 녞놹;

	[CompilerGenerated]
	private readonly GroupTradingOperation 녞놘;

	public override RequestType Type => RequestType.Custom;

	public string AccountId
	{
		[CompilerGenerated]
		get
		{
			return 녞놹;
		}
	}

	public GroupTradingOperation ParentOperation
	{
		[CompilerGenerated]
		get
		{
			return 녞놘;
		}
		[CompilerGenerated]
		init
		{
			녞놘 = value;
		}
	}

	public CancelAllOpenOrdersOnAccountRequest(string accountId)
	{
		녞놹 = accountId;
	}
}
