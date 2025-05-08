using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace TradingPlatform.BusinessLayer;

/// <summary>
/// Defines advanced trading operation respond bundle
/// </summary>
public sealed class AdvancedTradingOperationResult
{
	[CompilerGenerated]
	private AdvancedTradingOperationResultStatus 놴놟;

	[CompilerGenerated]
	private string 놴녓;

	[CompilerGenerated]
	private object 놴녛;

	[CompilerGenerated]
	private IDictionary<RequestParameters, TradingOperationResult> 놴녽;

	/// <summary>
	/// Respond operation state <see cref="T:TradingPlatform.BusinessLayer.AdvancedTradingOperationResultStatus" />
	/// </summary>
	public AdvancedTradingOperationResultStatus Status
	{
		[CompilerGenerated]
		get
		{
			return 놴놟;
		}
		[CompilerGenerated]
		private set
		{
			놴놟 = value;
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
			return 놴녓;
		}
		[CompilerGenerated]
		private set
		{
			놴녓 = value;
		}
	}

	/// <summary>
	/// Respond value (optional)
	/// </summary>
	public object Value
	{
		[CompilerGenerated]
		get
		{
			return 놴녛;
		}
		[CompilerGenerated]
		internal set
		{
			놴녛 = value;
		}
	}

	/// <summary>
	/// Details of sub-operations
	/// </summary>
	public IDictionary<RequestParameters, TradingOperationResult> Details
	{
		[CompilerGenerated]
		get
		{
			return 놴녽;
		}
		[CompilerGenerated]
		private set
		{
			놴녽 = value;
		}
	}

	internal AdvancedTradingOperationResult()
	{
		Status = AdvancedTradingOperationResultStatus.Success;
		Details = new Dictionary<RequestParameters, TradingOperationResult>();
	}

	internal AdvancedTradingOperationResult(RequestParameters P_0, TradingOperationResult P_1)
		: this()
	{
		녴(P_0, P_1);
	}

	internal static AdvancedTradingOperationResult 녴()
	{
		return new AdvancedTradingOperationResult();
	}

	internal static AdvancedTradingOperationResult 녴(string P_0)
	{
		return new AdvancedTradingOperationResult
		{
			Status = AdvancedTradingOperationResultStatus.Failure,
			Message = P_0
		};
	}

	internal void 녴(RequestParameters P_0, TradingOperationResult P_1)
	{
		Details.Add(P_0, P_1);
		놴();
	}

	internal AdvancedTradingOperationResult 녴(AdvancedTradingOperationResult P_0)
	{
		foreach (var (key, value) in P_0.Details)
		{
			Details.Add(key, value);
		}
		놴();
		return this;
	}

	private void 놴()
	{
		int num = 0;
		string text = null;
		foreach (TradingOperationResult value in Details.Values)
		{
			switch (value.Status)
			{
			case TradingOperationResultStatus.Success:
				num++;
				break;
			case TradingOperationResultStatus.Failure:
				if (text == null)
				{
					text = value.Message;
				}
				break;
			}
		}
		if (num == Details.Count)
		{
			Status = AdvancedTradingOperationResultStatus.Success;
			return;
		}
		Message = text;
		Status = ((num > 0) ? AdvancedTradingOperationResultStatus.PartiallySuccess : AdvancedTradingOperationResultStatus.Failure);
	}
}
