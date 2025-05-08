using System.Runtime.CompilerServices;
using TradingPlatform.BusinessLayer;

namespace CancelAllOpenOrdersRequests;

public class CancelAllOpenOrdersOnSymbolAndAccountRequest : RequestParameters, ISubTradingOperation
{
	[CompilerGenerated]
	private readonly SymbolComplexIdentifier 녞뇌;

	[CompilerGenerated]
	private readonly string 녞녷;

	[CompilerGenerated]
	private readonly GroupTradingOperation 녞녟;

	public override RequestType Type => RequestType.Custom;

	public SymbolComplexIdentifier SymbolComplexIdentifier
	{
		[CompilerGenerated]
		get
		{
			return 녞뇌;
		}
	}

	public string AccountId
	{
		[CompilerGenerated]
		get
		{
			return 녞녷;
		}
	}

	public GroupTradingOperation ParentOperation
	{
		[CompilerGenerated]
		get
		{
			return 녞녟;
		}
		[CompilerGenerated]
		init
		{
			녞녟 = value;
		}
	}

	public CancelAllOpenOrdersOnSymbolAndAccountRequest(SymbolComplexIdentifier symbolComplexIdentifier, string accountId)
	{
		녞뇌 = symbolComplexIdentifier;
		녞녷 = accountId;
	}
}
