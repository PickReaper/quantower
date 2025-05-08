using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Threading;
using TradingPlatform.BusinessLayer.Integration;

namespace TradingPlatform.BusinessLayer;

/// <summary>
/// Represents information about corporate action.
/// </summary>
[Published]
public class CorporateAction : BusinessObject
{
	[CompilerGenerated]
	private DateTime 놄놹;

	[CompilerGenerated]
	private string 놄놘;

	[CompilerGenerated]
	private Symbol 놄뇌;

	[CompilerGenerated]
	private string 놄녷;

	[CompilerGenerated]
	private CorporateActionType 놄녟;

	[CompilerGenerated]
	private Action 놄놱;

	/// <summary>
	/// Get the date and time when trade was executed
	/// </summary>
	public DateTime DateTime
	{
		[CompilerGenerated]
		get
		{
			return 놄놹;
		}
		[CompilerGenerated]
		private set
		{
			놄놹 = value;
		}
	}

	[DataMember(Name = "ID")]
	public string Id
	{
		[CompilerGenerated]
		get
		{
			return 놄놘;
		}
		[CompilerGenerated]
		protected set
		{
			놄놘 = value;
		}
	}

	[DataMember(Name = "Instrument")]
	public Symbol Symbol
	{
		[CompilerGenerated]
		get
		{
			return 놄뇌;
		}
		[CompilerGenerated]
		protected set
		{
			놄뇌 = value;
		}
	}

	public string Details
	{
		[CompilerGenerated]
		get
		{
			return 놄녷;
		}
		[CompilerGenerated]
		set
		{
			놄녷 = value;
		}
	}

	public CorporateActionType CorporateActionType
	{
		[CompilerGenerated]
		get
		{
			return 놄녟;
		}
		[CompilerGenerated]
		set
		{
			놄녟 = value;
		}
	}

	/// <summary>
	/// Will be triggered on corporate action updating
	/// </summary>
	public event Action Updated
	{
		[CompilerGenerated]
		add
		{
			Action action = 놄놱;
			Action action2;
			do
			{
				action2 = action;
				Action value2 = (Action)Delegate.Combine(action2, value);
				action = Interlocked.CompareExchange(ref 놄놱, value2, action2);
			}
			while ((object)action != action2);
		}
		[CompilerGenerated]
		remove
		{
			Action action = 놄놱;
			Action action2;
			do
			{
				action2 = action;
				Action value2 = (Action)Delegate.Remove(action2, value);
				action = Interlocked.CompareExchange(ref 놄놱, value2, action2);
			}
			while ((object)action != action2);
		}
	}

	public CorporateAction(string connectionId)
		: base(connectionId)
	{
	}

	internal void 녴(MessageCorporateAction P_0)
	{
		Id = P_0.CorporateActionId;
		if (!string.IsNullOrEmpty(P_0.SymbolId) && ConnectionCache != null && ConnectionCache.SymbolsCache.녴(P_0.SymbolId, out var symbol))
		{
			Symbol = symbol;
		}
		DateTime = P_0.DateTime;
		Details = P_0.Details;
		CorporateActionType = P_0.CorporateActionType;
		놄놱?.Invoke();
	}
}
