using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using TradingPlatform.BusinessLayer.Licence;
using 녴;

namespace TradingPlatform.BusinessLayer;

/// <summary>
/// Represents a permisions checking tool which use next priority order <see cref="T:TradingPlatform.BusinessLayer.Connection" />, <see cref="T:TradingPlatform.BusinessLayer.Account" />, <see cref="T:TradingPlatform.BusinessLayer.Symbol" /> and <see cref="T:TradingPlatform.BusinessLayer.OrderType" />
/// </summary>
public sealed class RulesManager
{
	[Serializable]
	[CompilerGenerated]
	private sealed class 녴
	{
		public static readonly 녴 놫놜 = new 녴();

		public static Func<SyntheticItem, Symbol> 놫놨;

		internal bool 녴(FieldInfo P_0)
		{
			if (P_0.IsLiteral)
			{
				return !P_0.IsInitOnly;
			}
			return false;
		}

		internal bool 놴(FieldInfo P_0)
		{
			return P_0.FieldType == typeof(string);
		}

		internal string 놂(FieldInfo P_0)
		{
			return P_0.GetValue(null) as string;
		}

		internal Symbol 녴(SyntheticItem P_0)
		{
			return P_0.Symbol;
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class 놴<녴> where 녴 : Rule
	{
		public static readonly 놴<녴> 놫녢 = new 놴<녴>();

		public static Func<녪, bool> 놫놞;

		public static Func<녪, int> 놫놳;

		internal bool 녴(녪 P_0)
		{
			return P_0 != null;
		}

		internal int 놴(녪 P_0)
		{
			return P_0.PriorityIndex;
		}
	}

	[CompilerGenerated]
	private sealed class 놂<녴> : IEnumerable<녴>, IEnumerable, IEnumerator<녴>, IEnumerator, IDisposable where 녴 : Rule
	{
		private int 놫놺;

		private 녴 놫놅;

		private int 놫녜;

		private 녪[] 놫뇃;

		public 녪[] 놫녯;

		private string 놫놮;

		public string 놫녫;

		private IEnumerator<녪> 놫뇁;

		녴 IEnumerator<녴>.Current
		{
			[DebuggerHidden]
			get
			{
				return 놫놅;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return 놫놅;
			}
		}

		[DebuggerHidden]
		public 놂(int P_0)
		{
			놫놺 = P_0;
			놫녜 = Environment.CurrentManagedThreadId;
		}

		[DebuggerHidden]
		private void 녴()
		{
			int num = 놫놺;
			if (num == -3 || num == 1)
			{
				try
				{
				}
				finally
				{
					놴();
				}
			}
			놫뇁 = null;
			놫놺 = -2;
		}

		void IDisposable.Dispose()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 녴
			this.녴();
		}

		private bool MoveNext()
		{
			try
			{
				switch (놫놺)
				{
				default:
					return false;
				case 0:
				{
					놫놺 = -1;
					IOrderedEnumerable<녪> orderedEnumerable = from P_0 in 놫뇃
						where P_0 != null
						orderby P_0.PriorityIndex
						select P_0;
					놫뇁 = orderedEnumerable.GetEnumerator();
					놫놺 = -3;
					break;
				}
				case 1:
					놫놺 = -3;
					break;
				}
				while (놫뇁.MoveNext())
				{
					녪 current = 놫뇁.Current;
					if (current.Rules != null && current.Rules.녴(놫놮, out var rule) && rule is 녴 val)
					{
						놫놅 = val;
						놫놺 = 1;
						return true;
					}
				}
				놴();
				놫뇁 = null;
				return false;
			}
			catch
			{
				//try-fault
				this.녴();
				throw;
			}
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void 놴()
		{
			놫놺 = -1;
			if (놫뇁 != null)
			{
				놫뇁.Dispose();
			}
		}

		[DebuggerHidden]
		private void 놂()
		{
			throw new NotSupportedException();
		}

		void IEnumerator.Reset()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 놂
			this.놂();
		}

		[DebuggerHidden]
		private IEnumerator<녴> 놎()
		{
			놂<녴> 놂;
			if (놫놺 == -2 && 놫녜 == Environment.CurrentManagedThreadId)
			{
				놫놺 = 0;
				놂 = this;
			}
			else
			{
				놂 = new 놂<녴>(0);
			}
			놂.놫놮 = 놫녫;
			놂.놫뇃 = 놫녯;
			return 놂;
		}

		IEnumerator<녴> IEnumerable<녴>.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 놎
			return this.놎();
		}

		[DebuggerHidden]
		private IEnumerator 녞()
		{
			return 놎();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 녞
			return this.녞();
		}
	}

	internal static HashSet<string> 놄;

	internal const int 놰 = 0;

	internal const int 놓 = 10;

	internal const int 놇 = 20;

	internal const int 뇅 = 30;

	internal List<Rule> Defaults => new List<Rule>
	{
		new 높<bool>(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녞(), true),
		new 높<bool>(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놫(), true),
		new 높<bool>(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녪(), true),
		new 높<bool>(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶(), true),
		new 높<bool>(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵(), true),
		new 높<bool>(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭(), true),
		new 높<bool>(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녲(), true),
		new 높<bool>(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇋(), true),
		new 높<bool>(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸(), true),
		new 높<bool>(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿(), true),
		new 높<bool>(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놄(), true),
		new 높<bool>(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰(), true)
	};

	static RulesManager()
	{
		놄 = new HashSet<string>(from P_0 in typeof(CoreLicenceKeys).GetFields(BindingFlags.Static | BindingFlags.Public | BindingFlags.FlattenHierarchy)
			where P_0.IsLiteral && !P_0.IsInitOnly
			where P_0.FieldType == typeof(string)
			select P_0.GetValue(null) as string);
	}

	public AllowedResult IsAllowed(string ruleName, string connectionId)
	{
		놴(ruleName);
		return 녴(ruleName, 녴(connectionId));
	}

	public AllowedResult IsAllowed(string ruleName, Account account)
	{
		녴(ruleName, account);
		return 녴(ruleName, 녴(account.ConnectionId), account);
	}

	public AllowedResult IsAllowed(string ruleName, Symbol symbol)
	{
		녴(ruleName, symbol);
		if (ruleName != _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놓() || !(symbol is Synthetic synthetic))
		{
			return 녴(ruleName, 녴(symbol.ConnectionId), symbol);
		}
		녪[] rulesContainers = synthetic.LegsConnectionsIds.Select(녴).Cast<녪>().Concat(synthetic.Items.Select((SyntheticItem P_0) => P_0.Symbol))
			.ToArray();
		return 녴(ruleName, rulesContainers);
	}

	public AllowedResult IsAllowed(string ruleName, Account account, Symbol symbol)
	{
		녴(ruleName, account, symbol);
		return 녴(ruleName, 녴(account.ConnectionId), account, symbol);
	}

	public AllowedResult IsAllowed(string ruleName, Account account, Symbol symbol, OrderType orderType)
	{
		녴(ruleName, account, symbol, orderType);
		return 녴(ruleName, 녴(account.ConnectionId), account, symbol, orderType);
	}

	public int GetIntValue(string ruleName, string connectionId)
	{
		놴(ruleName);
		return 놴(ruleName, 녴(connectionId));
	}

	public int GetIntValue(string ruleName, Account account)
	{
		녴(ruleName, account);
		return 놴(ruleName, 녴(account.ConnectionId), account);
	}

	public int GetIntValue(string ruleName, Account account, Symbol symbol)
	{
		녴(ruleName, account, symbol);
		return 놴(ruleName, 녴(account.ConnectionId), account, symbol);
	}

	public int GetIntValue(string ruleName, Account account, Symbol symbol, OrderType orderType)
	{
		녴(ruleName, account, symbol, orderType);
		return 놴(ruleName, 녴(account.ConnectionId), account, symbol, orderType);
	}

	public string GetStringValue(string ruleName, string connectionId)
	{
		놴(ruleName);
		return 놂(ruleName, 녴(connectionId));
	}

	public string GetStringValue(string ruleName, Account account)
	{
		녴(ruleName, account);
		return 놂(ruleName, 녴(account.ConnectionId), account);
	}

	public string GetStringValue(string ruleName, Account account, Symbol symbol)
	{
		녴(ruleName, account, symbol);
		return 놂(ruleName, 녴(account.ConnectionId), account, symbol);
	}

	public string GetStringValue(string ruleName, Account account, Symbol symbol, OrderType orderType)
	{
		녴(ruleName, account, symbol, orderType);
		return 놂(ruleName, 녴(account.ConnectionId), account, symbol, orderType);
	}

	private AllowedResult 녴(string P_0, params 녪[] rulesContainers)
	{
		IEnumerable<높<bool>> enumerable = 놎<높<bool>>(P_0, rulesContainers);
		if (enumerable.Count() == 0)
		{
			return AllowedResult.GetNotAllowedResult(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놇());
		}
		foreach (높<bool> item in enumerable)
		{
			if (!item.Value)
			{
				return AllowedResult.GetNotAllowedResult(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놇());
			}
		}
		return AllowedResult.GetAllowedResult();
	}

	private int 놴(string P_0, params 녪[] rulesContainers)
	{
		return 놎<높<int>>(P_0, rulesContainers).LastOrDefault()?.Value ?? (-1);
	}

	private string 놂(string P_0, params 녪[] rulesContainers)
	{
		return 놎<높<string>>(P_0, rulesContainers).LastOrDefault()?.Value ?? _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇅();
	}

	[IteratorStateMachine(typeof(놂<>))]
	private IEnumerable<녴> 놎<녴>(string P_0, params 녪[] rulesContainers) where 녴 : Rule
	{
		//yield-return decompiler failed: Unexpected instruction in Iterator.Dispose()
		return new 놂<녴>(-2)
		{
			놫녫 = P_0,
			놫녯 = rulesContainers
		};
	}

	private 놶 녴(string P_0)
	{
		return Core.Instance.Connections[P_0]?.놫놪;
	}

	private void 놴(string P_0)
	{
		if (string.IsNullOrEmpty(P_0))
		{
			throw new ArgumentNullException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놵());
		}
	}

	private void 녴(string P_0, Account P_1)
	{
		놴(P_0);
		if (P_1 == null)
		{
			throw new ArgumentNullException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놡());
		}
	}

	private void 녴(string P_0, Symbol P_1)
	{
		놴(P_0);
		if (P_1 == null)
		{
			throw new ArgumentNullException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놻());
		}
	}

	private void 녴(string P_0, Account P_1, Symbol P_2)
	{
		녴(P_0, P_1);
		if (P_2 == null)
		{
			throw new ArgumentNullException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놻());
		}
		if (P_2.SymbolType == SymbolType.Synthetic || !(P_1.ConnectionId != P_2.ConnectionId))
		{
			return;
		}
		throw new ArgumentException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놃());
	}

	private void 녴(string P_0, Account P_1, Symbol P_2, OrderType P_3)
	{
		녴(P_0, P_1, P_2);
		if (P_3 == null)
		{
			throw new ArgumentNullException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇇());
		}
		if (P_2.SymbolType == SymbolType.Synthetic || !(P_1.ConnectionId != P_3.ConnectionId))
		{
			return;
		}
		throw new ArgumentException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놛());
	}
}
