using System.Runtime.CompilerServices;

namespace TradingPlatform.BusinessLayer;

/// <summary>
/// The allowed result.
/// </summary>
public sealed class AllowedResult
{
	[CompilerGenerated]
	private TradingOperationStatus 놴녠;

	[CompilerGenerated]
	private string 놴놠;

	/// <summary>
	/// Gets the status.
	/// </summary>
	public TradingOperationStatus Status
	{
		[CompilerGenerated]
		get
		{
			return 놴녠;
		}
		[CompilerGenerated]
		private set
		{
			놴녠 = value;
		}
	}

	/// <summary>
	/// Gets the reason.
	/// </summary>
	public string Reason
	{
		[CompilerGenerated]
		get
		{
			return 놴놠;
		}
		[CompilerGenerated]
		private set
		{
			놴놠 = value;
		}
	}

	/// <summary>
	/// Get the allowed result.
	/// </summary>
	/// <returns>An AllowedResult.</returns>
	public static AllowedResult GetAllowedResult()
	{
		return new AllowedResult
		{
			Status = TradingOperationStatus.Allowed
		};
	}

	/// <summary>
	/// Gets the not allowed result.
	/// </summary>
	/// <param name="reason">The reason.</param>
	/// <returns>An AllowedResult.</returns>
	public static AllowedResult GetNotAllowedResult(string reason = "")
	{
		return new AllowedResult
		{
			Status = TradingOperationStatus.NotAllowed,
			Reason = reason
		};
	}
}
