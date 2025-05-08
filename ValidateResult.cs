using System.Runtime.CompilerServices;

namespace TradingPlatform.BusinessLayer;

public struct ValidateResult
{
	[CompilerGenerated]
	private ValidateState 놂뇀;

	[CompilerGenerated]
	private string 놂놽;

	public ValidateState State
	{
		[CompilerGenerated]
		readonly get
		{
			return 놂뇀;
		}
		[CompilerGenerated]
		set
		{
			놂뇀 = value;
		}
	}

	public string Reason
	{
		[CompilerGenerated]
		readonly get
		{
			return 놂놽;
		}
		[CompilerGenerated]
		set
		{
			놂놽 = value;
		}
	}

	public static ValidateResult Valid
	{
		get
		{
			ValidateResult result = default(ValidateResult);
			result.State = ValidateState.Valid;
			return result;
		}
	}

	public static ValidateResult NotValid(string reason)
	{
		ValidateResult result = default(ValidateResult);
		result.State = ValidateState.NotValid;
		result.Reason = reason;
		return result;
	}
}
