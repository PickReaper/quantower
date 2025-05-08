using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;

namespace TradingPlatform.BusinessLayer;

/// <summary>
/// Allows to save Symbols into named lists
/// </summary>
public class SymbolList : IComparable, ICustomizable, IRenamable
{
	[CompilerGenerated]
	private sealed class 녴
	{
		public string 놵뇊;

		internal bool 녴(SymbolList P_0)
		{
			return P_0.Name == 놵뇊;
		}
	}

	[CompilerGenerated]
	private sealed class 놴 : IEnumerable<Symbol>, IEnumerable, IEnumerator<Symbol>, IEnumerator, IDisposable
	{
		private int 놵놋;

		private Symbol 놵녣;

		private int 놵녩;

		public SymbolList 놵놤;

		private List<BusinessObjectInfo>.Enumerator 놵논;

		Symbol IEnumerator<Symbol>.Current
		{
			[DebuggerHidden]
			get
			{
				return 놵녣;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return 놵녣;
			}
		}

		[DebuggerHidden]
		public 놴(int P_0)
		{
			놵놋 = P_0;
			놵녩 = Environment.CurrentManagedThreadId;
		}

		[DebuggerHidden]
		private void 녴()
		{
			int num = 놵놋;
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
			놵논 = default(List<BusinessObjectInfo>.Enumerator);
			놵놋 = -2;
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
				int num = 놵놋;
				SymbolList symbolList = 놵놤;
				switch (num)
				{
				default:
					return false;
				case 0:
					놵놋 = -1;
					놵논 = symbolList.녲놦.GetEnumerator();
					놵놋 = -3;
					break;
				case 1:
					놵놋 = -3;
					break;
				}
				if (놵논.MoveNext())
				{
					BusinessObjectInfo current = 놵논.Current;
					놵녣 = Core.Instance.GetSymbol(current);
					놵놋 = 1;
					return true;
				}
				놴();
				놵논 = default(List<BusinessObjectInfo>.Enumerator);
				return false;
			}
			catch
			{
				//try-fault
				녴();
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
			놵놋 = -1;
			((IDisposable)놵논/*cast due to .constrained prefix*/).Dispose();
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
		private IEnumerator<Symbol> 놎()
		{
			놴 result;
			if (놵놋 == -2 && 놵녩 == Environment.CurrentManagedThreadId)
			{
				놵놋 = 0;
				result = this;
			}
			else
			{
				result = new 놴(0)
				{
					놵놤 = 놵놤
				};
			}
			return result;
		}

		IEnumerator<Symbol> IEnumerable<Symbol>.GetEnumerator()
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

	[CompilerGenerated]
	private sealed class 놂 : IEnumerable<Symbol>, IEnumerable, IEnumerator<Symbol>, IEnumerator, IDisposable
	{
		private int 놵녘;

		private Symbol 놵노;

		private int 놵녒;

		public SymbolList 놵녕;

		private List<BusinessObjectInfo>.Enumerator 놵녖;

		Symbol IEnumerator<Symbol>.Current
		{
			[DebuggerHidden]
			get
			{
				return 놵노;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return 놵노;
			}
		}

		[DebuggerHidden]
		public 놂(int P_0)
		{
			놵녘 = P_0;
			놵녒 = Environment.CurrentManagedThreadId;
		}

		[DebuggerHidden]
		private void 녴()
		{
			int num = 놵녘;
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
			놵녖 = default(List<BusinessObjectInfo>.Enumerator);
			놵녘 = -2;
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
				int num = 놵녘;
				SymbolList symbolList = 놵녕;
				switch (num)
				{
				default:
					return false;
				case 0:
					놵녘 = -1;
					놵녖 = symbolList.녲놦.GetEnumerator();
					놵녘 = -3;
					break;
				case 1:
					놵녘 = -3;
					break;
				}
				if (놵녖.MoveNext())
				{
					BusinessObjectInfo current = 놵녖.Current;
					놵노 = new Symbol(current);
					놵녘 = 1;
					return true;
				}
				놴();
				놵녖 = default(List<BusinessObjectInfo>.Enumerator);
				return false;
			}
			catch
			{
				//try-fault
				녴();
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
			놵녘 = -1;
			((IDisposable)놵녖/*cast due to .constrained prefix*/).Dispose();
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
		private IEnumerator<Symbol> 놎()
		{
			놂 result;
			if (놵녘 == -2 && 놵녒 == Environment.CurrentManagedThreadId)
			{
				놵녘 = 0;
				result = this;
			}
			else
			{
				result = new 놂(0)
				{
					놵녕 = 놵녕
				};
			}
			return result;
		}

		IEnumerator<Symbol> IEnumerable<Symbol>.GetEnumerator()
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

	[CompilerGenerated]
	private bool 녲녝;

	private string 녲뇈;

	[CompilerGenerated]
	private string 녲놑;

	private List<BusinessObjectInfo> 녲놦;

	public bool AllowToModify
	{
		[CompilerGenerated]
		get
		{
			return 녲녝;
		}
		[CompilerGenerated]
		private set
		{
			녲녝 = value;
		}
	}

	public string Name
	{
		get
		{
			return 녲뇈;
		}
		set
		{
			if (AllowToModify)
			{
				if (Core.Instance.SymbolList.FirstOrDefault((SymbolList P_0) => P_0.Name == 녲뇈) != null)
				{
					Core.Instance.RenameSymbolList(녲뇈, value);
				}
				else
				{
					Core.Instance.AddSymbolList(value, Symbols);
				}
			}
		}
	}

	public string Group
	{
		[CompilerGenerated]
		get
		{
			return 녲놑;
		}
		[CompilerGenerated]
		set
		{
			녲놑 = value;
		}
	}

	public IEnumerable<Symbol> Symbols
	{
		[IteratorStateMachine(typeof(놂))]
		get
		{
			//yield-return decompiler failed: Unexpected instruction in Iterator.Dispose()
			return new 놂(-2)
			{
				놵녕 = this
			};
		}
		set
		{
			녲놦.Clear();
			foreach (Symbol item in value)
			{
				녲놦.Add(item.CreateInfo());
			}
		}
	}

	public IList<SettingItem> Settings
	{
		get
		{
			List<SettingItem> list = new List<SettingItem>
			{
				new SettingItemString(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놵(), Name)
			};
			foreach (Symbol symbol in Symbols)
			{
				list.Add(new SettingItemSymbol(symbol.Name, symbol));
			}
			return list;
		}
		set
		{
			List<Symbol> list = new List<Symbol>();
			foreach (SettingItem item in value)
			{
				if (item.Type == SettingItemType.Symbol)
				{
					list.Add(item.Value as Symbol);
				}
				else if (item.Name == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놵())
				{
					녴(item.Value as string);
				}
			}
			if (list.Count > 0)
			{
				Symbols = list;
			}
		}
	}

	public bool IsNameAllowed(string s, ref string error)
	{
		if (string.IsNullOrWhiteSpace(s))
		{
			error = _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녲놻();
			return false;
		}
		if (Name != s && Core.Instance.SymbolList.Any((SymbolList P_0) => P_0.Name == s))
		{
			error = _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녲놃();
			return false;
		}
		return true;
	}

	[IteratorStateMachine(typeof(놴))]
	public IEnumerable<Symbol> GetRealSymbols()
	{
		//yield-return decompiler failed: Unexpected instruction in Iterator.Dispose()
		return new 놴(-2)
		{
			놵놤 = this
		};
	}

	internal SymbolList()
	{
		녲놦 = new List<BusinessObjectInfo>();
		AllowToModify = true;
	}

	public SymbolList(string name, IEnumerable<Symbol> symbols)
		: this()
	{
		if (string.IsNullOrEmpty(name))
		{
			throw new ArgumentNullException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놝());
		}
		녴(name);
		Symbols = symbols ?? throw new ArgumentNullException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵노());
	}

	internal SymbolList(IList<SettingItem> P_0, bool P_1)
		: this()
	{
		Settings = P_0;
		AllowToModify = P_1;
	}

	public int CompareTo(object obj)
	{
		return Name.CompareTo((obj as SymbolList).Name);
	}

	internal void 녴(string P_0)
	{
		if (AllowToModify)
		{
			녲뇈 = P_0;
		}
	}

	[CompilerGenerated]
	private bool 녴(SymbolList P_0)
	{
		return P_0.Name == 녲뇈;
	}
}
