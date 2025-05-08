using System.Runtime.CompilerServices;

namespace TradingPlatform.BusinessLayer;

public class UpdateArgs
{
	[CompilerGenerated]
	private UpdateReason 놴놀;

	[CompilerGenerated]
	private MessageQuote 놴놔;

	public UpdateReason Reason
	{
		[CompilerGenerated]
		get
		{
			return 놴놀;
		}
		[CompilerGenerated]
		private set
		{
			놴놀 = value;
		}
	}

	public MessageQuote MessageQuote
	{
		[CompilerGenerated]
		get
		{
			return 놴놔;
		}
		[CompilerGenerated]
		private set
		{
			놴놔 = value;
		}
	}

	internal UpdateArgs(UpdateReason P_0, MessageQuote P_1 = null)
	{
		Reason = P_0;
		MessageQuote = P_1;
	}

	internal UpdateArgs 녴()
	{
		return new UpdateArgs(Reason, MessageQuote);
	}
}
