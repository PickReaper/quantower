using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using TradingPlatform.BusinessLayer.Integration;
using 녴;

namespace TradingPlatform.BusinessLayer;

/// <summary>
/// Contains all user's account information
/// </summary>
[Published]
public class Account : BusinessObject, 녪, IMessageBuilder<MessageAccount>, IComparable, IComparable<Account>, IEquatable<Account>
{
	[CompilerGenerated]
	private string 놄녠;

	[CompilerGenerated]
	private string 놄놠;

	[CompilerGenerated]
	private Asset 놄놟;

	[CompilerGenerated]
	private double 놄녓;

	[CompilerGenerated]
	private NettingType 놄녛;

	[CompilerGenerated]
	private AdditionalInfoCollection 놄녽;

	private readonly 뇇<string, Rule> 놄놏;

	[CompilerGenerated]
	private Action<Account> 놄녥;

	/// <summary>
	/// Gets account unique code.
	/// </summary>
	public string Id
	{
		[CompilerGenerated]
		get
		{
			return 놄녠;
		}
		[CompilerGenerated]
		private set
		{
			놄녠 = value;
		}
	}

	/// <summary>
	/// Obtaining account name.
	/// </summary>
	public string Name
	{
		[CompilerGenerated]
		get
		{
			return 놄놠;
		}
		[CompilerGenerated]
		private set
		{
			놄놠 = value;
		}
	}

	/// <summary>
	/// Gets base currency of account. Account CCY is always equal to the server CCY in AlgoStudio
	/// </summary>
	public Asset AccountCurrency
	{
		[CompilerGenerated]
		get
		{
			return 놄놟;
		}
		[CompilerGenerated]
		private set
		{
			놄놟 = value;
		}
	}

	/// <summary>
	/// Gets current balance of the account.
	/// </summary>
	public double Balance
	{
		[CompilerGenerated]
		get
		{
			return 놄녓;
		}
		[CompilerGenerated]
		private set
		{
			놄녓 = value;
		}
	}

	public NettingType NettingType
	{
		[CompilerGenerated]
		get
		{
			return 놄녛;
		}
		[CompilerGenerated]
		set
		{
			놄녛 = value;
		}
	}

	/// <summary>
	/// Gets additional account information
	/// </summary>
	[NotPublished]
	public AdditionalInfoCollection AdditionalInfo
	{
		[CompilerGenerated]
		get
		{
			return 놄녽;
		}
		[CompilerGenerated]
		private set
		{
			놄녽 = value;
		}
	}

	int 녪.PriorityIndex => 10;

	뇇<string, Rule> 녪.Rules => 놄놏;

	/// <summary>
	/// Will be triggered on each account information updating
	/// </summary>
	public event Action<Account> Updated
	{
		[CompilerGenerated]
		add
		{
			Action<Account> action = 놄녥;
			Action<Account> action2;
			do
			{
				action2 = action;
				Action<Account> value2 = (Action<Account>)Delegate.Combine(action2, value);
				action = Interlocked.CompareExchange(ref 놄녥, value2, action2);
			}
			while ((object)action != action2);
		}
		[CompilerGenerated]
		remove
		{
			Action<Account> action = 놄녥;
			Action<Account> action2;
			do
			{
				action2 = action;
				Action<Account> value2 = (Action<Account>)Delegate.Remove(action2, value);
				action = Interlocked.CompareExchange(ref 놄녥, value2, action2);
			}
			while ((object)action != action2);
		}
	}

	[NotPublished]
	protected internal Account(string connectionId)
		: base(connectionId)
	{
		놄놏 = new 뇇<string, Rule>();
		Core.Instance.RulesManager.Defaults.ForEach(delegate(Rule P_0)
		{
			놄놏.녴(P_0.Name, P_0);
		});
	}

	[NotPublished]
	protected internal Account(BusinessObjectInfo accountInfo)
		: base(accountInfo.ConnectionId)
	{
		Id = accountInfo.Id;
		Name = accountInfo.Name;
		State = BusinessObjectState.Fake;
	}

	internal void 녴(MessageAccount P_0)
	{
		Id = P_0.AccountId;
		Name = P_0.AccountName;
		if (P_0.AssetId != null && ConnectionCache != null && ConnectionCache.녪뇋.TryGetValue(P_0.AssetId, out var value))
		{
			AccountCurrency = value;
		}
		Balance = P_0.Balance;
		NettingType = P_0.NettingType;
		if (P_0.AccountAdditionalInfo != null)
		{
			if (AdditionalInfo == null)
			{
				AdditionalInfoCollection additionalInfoCollection2 = (AdditionalInfo = new AdditionalInfoCollection());
			}
			foreach (AdditionalInfoItem item in P_0.AccountAdditionalInfo)
			{
				AdditionalInfo.녴(item);
			}
		}
		놄녥?.Invoke(this);
	}

	private MessageAccount 녴()
	{
		return new MessageAccount
		{
			AccountId = Id,
			AccountName = Name,
			AssetId = AccountCurrency.Id,
			Balance = Balance,
			AccountAdditionalInfo = AdditionalInfo?.Items.ToList()
		};
	}

	MessageAccount IMessageBuilder<MessageAccount>.BuildMessage()
	{
		//ILSpy generated this explicit interface implementation from .override directive in 녴
		return this.녴();
	}

	/// <summary>
	/// Gets Account name
	/// </summary>
	/// <returns></returns>
	[NotPublished]
	public override string ToString()
	{
		return Name;
	}

	/// <summary>
	/// Creates a business object info with an Account data which can be used for the restoring/serialization process.
	/// </summary>
	/// <returns></returns>
	[NotPublished]
	public override BusinessObjectInfo CreateInfo()
	{
		return new 놅
		{
			ConnectionId = base.ConnectionId,
			Id = Id,
			Name = Name,
			IsCrypto = false
		};
	}

	public int CompareTo(object obj)
	{
		return CompareTo(obj as Account);
	}

	public int CompareTo(Account other)
	{
		if (this == other)
		{
			return 0;
		}
		if (other == null)
		{
			return 1;
		}
		return string.Compare(Id, other.Id, StringComparison.Ordinal);
	}

	public bool Equals(Account other)
	{
		if (other == null)
		{
			return false;
		}
		if (this == other)
		{
			return true;
		}
		if (Id == other.Id)
		{
			return base.ConnectionId == other.ConnectionId;
		}
		return false;
	}

	public override bool Equals(object obj)
	{
		if (obj == null)
		{
			return false;
		}
		if (this == obj)
		{
			return true;
		}
		if (obj.GetType() != GetType())
		{
			return false;
		}
		return Equals((Account)obj);
	}

	public override int GetHashCode()
	{
		return HashCode.Combine(Id, base.ConnectionId);
	}

	[CompilerGenerated]
	private void 녴(Rule P_0)
	{
		놄놏.녴(P_0.Name, P_0);
	}
}
