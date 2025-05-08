using System.Runtime.CompilerServices;

namespace TradingPlatform.BusinessLayer;

[Published]
public abstract class TradingRequestParameters : RequestParameters, IConnectionBindedObject, ILoggable, ICurrentAccount, ISubTradingOperation
{
	[CompilerGenerated]
	private readonly GroupTradingOperation 녵놸;

	public abstract string ConnectionId { get; }

	public abstract string Event { get; }

	public abstract string Message { get; }

	public GroupTradingOperation ParentOperation
	{
		[CompilerGenerated]
		get
		{
			return 녵놸;
		}
		[CompilerGenerated]
		init
		{
			녵놸 = value;
		}
	}

	Account ICurrentAccount.CurrentAccount
	{
		get
		{
			return GetAccount();
		}
		set
		{
		}
	}

	protected abstract Account GetAccount();

	public TradingRequestParameters()
	{
	}

	public TradingRequestParameters(TradingRequestParameters origin)
		: base(origin)
	{
		ParentOperation = origin.ParentOperation;
	}
}
