using System.Runtime.CompilerServices;
using TradingPlatform.BusinessLayer;

namespace CancelAllOpenOrdersRequests;

public class CancelAllOpenOrdersOnSymbolRequest : RequestParameters, ISubTradingOperation
{
	[CompilerGenerated]
	private readonly SymbolComplexIdentifier 녞놙;

	[CompilerGenerated]
	private readonly string[] 녞녰;

	[CompilerGenerated]
	private readonly GroupTradingOperation 녞놚;

	public override RequestType Type => RequestType.Custom;

	public SymbolComplexIdentifier SymbolComplexIdentifier
	{
		[CompilerGenerated]
		get
		{
			return 녞놙;
		}
	}

	public string[] OrderIdArray
	{
		[CompilerGenerated]
		get
		{
			return 녞녰;
		}
	}

	public GroupTradingOperation ParentOperation
	{
		[CompilerGenerated]
		get
		{
			return 녞놚;
		}
		[CompilerGenerated]
		init
		{
			녞놚 = value;
		}
	}

	public CancelAllOpenOrdersOnSymbolRequest(SymbolComplexIdentifier symbolComplexIdentifier, params string[] orderIdArray)
	{
		녞놙 = symbolComplexIdentifier;
		녞녰 = orderIdArray;
	}
}
