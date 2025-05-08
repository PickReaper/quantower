using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;

namespace TradingPlatform.BusinessLayer;

/// <summary>
/// Defines a trading operation respond bundle
/// </summary>
public sealed class TradingOperationResult : ILoggable
{
	[CompilerGenerated]
	private TradingOperationResultStatus 녲놐;

	[CompilerGenerated]
	private string 녲녚;

	[CompilerGenerated]
	private string 녲녳;

	[CompilerGenerated]
	private long 녲놉;

	/// <summary>
	/// Respond operation state
	/// </summary>
	public TradingOperationResultStatus Status
	{
		[CompilerGenerated]
		get
		{
			return 녲놐;
		}
		[CompilerGenerated]
		private set
		{
			녲놐 = value;
		}
	}

	/// <summary>
	/// Respond message
	/// </summary>
	public string Message
	{
		[CompilerGenerated]
		get
		{
			return 녲녚;
		}
		[CompilerGenerated]
		private set
		{
			녲녚 = value;
		}
	}

	/// <summary>
	/// Respond order id
	/// </summary>
	public string OrderId
	{
		[CompilerGenerated]
		get
		{
			return 녲녳;
		}
		[CompilerGenerated]
		private set
		{
			녲녳 = value;
		}
	}

	public long RequestId
	{
		[CompilerGenerated]
		get
		{
			return 녲놉;
		}
		[CompilerGenerated]
		private set
		{
			녲놉 = value;
		}
	}

	string ILoggable.Event => _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녲놗();

	string ILoggable.Message => ToString();

	private TradingOperationResult()
	{
	}

	public static TradingOperationResult CreateSuccess(long requestId, string orderId = null)
	{
		return new TradingOperationResult
		{
			RequestId = requestId,
			Status = TradingOperationResultStatus.Success,
			OrderId = orderId
		};
	}

	public static TradingOperationResult CreateError(long requestId, string message)
	{
		return new TradingOperationResult
		{
			RequestId = requestId,
			Status = TradingOperationResultStatus.Failure,
			Message = message
		};
	}

	[NotPublished]
	public void SetOrderId(string orderId)
	{
		OrderId = orderId;
	}

	public override string ToString()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(14, 3);
		defaultInterpolatedStringHandler.AppendFormatted(Status);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녲뇇());
		defaultInterpolatedStringHandler.AppendFormatted((Status == TradingOperationResultStatus.Success) ? (_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녲놛() + OrderId) : Message);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녲놼());
		defaultInterpolatedStringHandler.AppendFormatted(RequestId);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}
}
