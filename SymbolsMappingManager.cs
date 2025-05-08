using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;

namespace TradingPlatform.BusinessLayer;

public class SymbolsMappingManager : ICustomizable
{
	[Serializable]
	[CompilerGenerated]
	private sealed class 녴
	{
		public static readonly 녴 놵뇉 = new 녴();

		public static Func<SymbolMapState, Symbol> 놵뇍;

		public static Func<SymbolMapState, Symbol> 놵놙;

		public static Func<SymbolMapState, Symbol> 놵녰;

		public static Func<SymbolMapState, Symbol> 놵놚;

		public static Func<SymbolMapState, Symbol> 놵놹;

		internal Symbol 녴(SymbolMapState P_0)
		{
			return P_0.QuotesSymbol;
		}

		internal Symbol 놴(SymbolMapState P_0)
		{
			return P_0.TickHistorySymbol;
		}

		internal Symbol 놂(SymbolMapState P_0)
		{
			return P_0.MinuteHistorySymbol;
		}

		internal Symbol 놎(SymbolMapState P_0)
		{
			return P_0.DayHistorySymbol;
		}

		internal Symbol 녞(SymbolMapState P_0)
		{
			return P_0.VolumeAnalysisSymbol;
		}
	}

	[CompilerGenerated]
	private sealed class 놴
	{
		public Symbol 놵놘;

		internal bool 녴(SymbolMap P_0)
		{
			return P_0.TradableSymbol.Equals(놵놘);
		}
	}

	[CompilerGenerated]
	private sealed class 놂
	{
		public Symbol 놵뇌;

		internal bool 녴(Symbol P_0)
		{
			return P_0.Equals(놵뇌);
		}
	}

	[CompilerGenerated]
	private sealed class 놎 : IEnumerable<Symbol>, IEnumerable, IEnumerator<Symbol>, IEnumerator, IDisposable
	{
		private int 놵녷;

		private Symbol 놵녟;

		private int 놵놱;

		private Symbol 놵놖;

		public Symbol 놵놝;

		public SymbolsMappingManager 놵뇄;

		private Func<SymbolMapState, Symbol> 놵녑;

		public Func<SymbolMapState, Symbol> 놵놈;

		private IEnumerator<Symbol> 놵놬;

		Symbol IEnumerator<Symbol>.Current
		{
			[DebuggerHidden]
			get
			{
				return 놵녟;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return 놵녟;
			}
		}

		[DebuggerHidden]
		public 놎(int P_0)
		{
			놵녷 = P_0;
			놵놱 = Environment.CurrentManagedThreadId;
		}

		[DebuggerHidden]
		private void 녴()
		{
			int num = 놵녷;
			if (num == -3 || num == 2)
			{
				try
				{
				}
				finally
				{
					놴();
				}
			}
			놵놬 = null;
			놵녷 = -2;
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
				int num = 놵녷;
				SymbolsMappingManager symbolsMappingManager = 놵뇄;
				switch (num)
				{
				default:
					return false;
				case 0:
					놵녷 = -1;
					놵녟 = 놵놖;
					놵녷 = 1;
					return true;
				case 1:
				{
					놵녷 = -1;
					SymbolMap symbolMap = symbolsMappingManager.녴(놵놖);
					if (symbolMap == null)
					{
						return false;
					}
					Symbol symbol = 놵녑(symbolMap.GetState());
					if (놵놖.Equals(symbol))
					{
						return false;
					}
					놵놬 = symbolsMappingManager.GetSymbolsChainRecursive(symbol, 놵녑).GetEnumerator();
					놵녷 = -3;
					break;
				}
				case 2:
					놵녷 = -3;
					break;
				}
				if (놵놬.MoveNext())
				{
					Symbol current = 놵놬.Current;
					놵녟 = current;
					놵녷 = 2;
					return true;
				}
				놴();
				놵놬 = null;
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
			놵녷 = -1;
			if (놵놬 != null)
			{
				놵놬.Dispose();
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
		private IEnumerator<Symbol> 놎()
		{
			놎 놎;
			if (놵녷 == -2 && 놵놱 == Environment.CurrentManagedThreadId)
			{
				놵녷 = 0;
				놎 = this;
			}
			else
			{
				놎 = new 놎(0)
				{
					놵뇄 = 놵뇄
				};
			}
			놎.놵놖 = 놵놝;
			놎.놵녑 = 놵놈;
			return 놎;
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
	private EventHandler<SymbolsMappingEventArgs> 녵녻;

	[CompilerGenerated]
	private EventHandler<SymbolsMappingEventArgs> 녵녙;

	[CompilerGenerated]
	private EventHandler<SymbolsMappingEventArgs> 녵놢;

	[CompilerGenerated]
	private EventHandler<SymbolsMappingEventArgs> 녵녧;

	[CompilerGenerated]
	private EventHandler<SymbolsMappingEventArgs> 녵녤;

	private readonly Dictionary<string, SymbolMap> 녵놆;

	private readonly object 녵뇎;

	public IList<SettingItem> Settings
	{
		get
		{
			List<SettingItem> list = new List<SettingItem>();
			lock (녵뇎)
			{
				foreach (KeyValuePair<string, SymbolMap> item in 녵놆)
				{
					list.Add(new SettingItemGroup(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭녺(), item.Value.Settings));
				}
				return list;
			}
		}
		set
		{
			foreach (SettingItem item in value)
			{
				if (!(item.Name != _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭녺()) && item.Value is IList<SettingItem> settings)
				{
					SymbolMap symbolMap = new SymbolMap
					{
						Settings = settings
					};
					lock (녵뇎)
					{
						녵놆.Add(symbolMap.Id, symbolMap);
					}
				}
			}
		}
	}

	public SymbolMap[] AllMaps
	{
		get
		{
			lock (녵뇎)
			{
				return 녵놆.Values.ToArray();
			}
		}
	}

	public event EventHandler<SymbolsMappingEventArgs> MapAdded
	{
		[CompilerGenerated]
		add
		{
			EventHandler<SymbolsMappingEventArgs> eventHandler = 녵녻;
			EventHandler<SymbolsMappingEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<SymbolsMappingEventArgs> value2 = (EventHandler<SymbolsMappingEventArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref 녵녻, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<SymbolsMappingEventArgs> eventHandler = 녵녻;
			EventHandler<SymbolsMappingEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<SymbolsMappingEventArgs> value2 = (EventHandler<SymbolsMappingEventArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref 녵녻, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler<SymbolsMappingEventArgs> MapUpdating
	{
		[CompilerGenerated]
		add
		{
			EventHandler<SymbolsMappingEventArgs> eventHandler = 녵녙;
			EventHandler<SymbolsMappingEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<SymbolsMappingEventArgs> value2 = (EventHandler<SymbolsMappingEventArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref 녵녙, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<SymbolsMappingEventArgs> eventHandler = 녵녙;
			EventHandler<SymbolsMappingEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<SymbolsMappingEventArgs> value2 = (EventHandler<SymbolsMappingEventArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref 녵녙, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler<SymbolsMappingEventArgs> MapUpdated
	{
		[CompilerGenerated]
		add
		{
			EventHandler<SymbolsMappingEventArgs> eventHandler = 녵놢;
			EventHandler<SymbolsMappingEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<SymbolsMappingEventArgs> value2 = (EventHandler<SymbolsMappingEventArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref 녵놢, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<SymbolsMappingEventArgs> eventHandler = 녵놢;
			EventHandler<SymbolsMappingEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<SymbolsMappingEventArgs> value2 = (EventHandler<SymbolsMappingEventArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref 녵놢, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler<SymbolsMappingEventArgs> MapDeleting
	{
		[CompilerGenerated]
		add
		{
			EventHandler<SymbolsMappingEventArgs> eventHandler = 녵녧;
			EventHandler<SymbolsMappingEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<SymbolsMappingEventArgs> value2 = (EventHandler<SymbolsMappingEventArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref 녵녧, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<SymbolsMappingEventArgs> eventHandler = 녵녧;
			EventHandler<SymbolsMappingEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<SymbolsMappingEventArgs> value2 = (EventHandler<SymbolsMappingEventArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref 녵녧, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler<SymbolsMappingEventArgs> MapDeleted
	{
		[CompilerGenerated]
		add
		{
			EventHandler<SymbolsMappingEventArgs> eventHandler = 녵녤;
			EventHandler<SymbolsMappingEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<SymbolsMappingEventArgs> value2 = (EventHandler<SymbolsMappingEventArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref 녵녤, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<SymbolsMappingEventArgs> eventHandler = 녵녤;
			EventHandler<SymbolsMappingEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<SymbolsMappingEventArgs> value2 = (EventHandler<SymbolsMappingEventArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref 녵녤, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	internal SymbolsMappingManager()
	{
		녵놆 = new Dictionary<string, SymbolMap>();
		녵뇎 = new object();
	}

	internal void 녴()
	{
	}

	public string AddSymbolMap(SymbolMappingParameters parameters)
	{
		SymbolMap symbolMap;
		lock (녵뇎)
		{
			녴(parameters, null);
			symbolMap = new SymbolMap(parameters.TradableSymbol);
			녵놆.Add(symbolMap.Id, symbolMap);
			symbolMap.녴(parameters);
		}
		녴(symbolMap);
		return symbolMap.Id;
	}

	public void UpdateSymbolMap(string symbolMapId, SymbolMappingParameters parameters)
	{
		if (string.IsNullOrEmpty(symbolMapId))
		{
			throw new ArgumentNullException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭놣());
		}
		SymbolMap symbolMap;
		SymbolMapState state;
		lock (녵뇎)
		{
			symbolMap = 녵놆[symbolMapId];
			녴(parameters, symbolMapId);
			놴(symbolMap);
			state = symbolMap.GetState();
			symbolMap.녴(parameters, parameters.IsActive && state.IsActive == parameters.IsActive);
		}
		녴(symbolMap, state);
	}

	public void DeleteSymbolMap(string symbolMapId)
	{
		if (string.IsNullOrEmpty(symbolMapId))
		{
			throw new ArgumentNullException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭놣());
		}
		SymbolMap symbolMap;
		lock (녵뇎)
		{
			symbolMap = 녵놆[symbolMapId];
			놂(symbolMap);
			symbolMap.녴();
			녵놆.Remove(symbolMapId);
		}
		symbolMap.Dispose();
		놎(symbolMap);
	}

	public void DeleteAllMaps()
	{
		SymbolMap[] allMaps = AllMaps;
		foreach (SymbolMap symbolMap in allMaps)
		{
			놂(symbolMap);
			symbolMap.녴();
			lock (녵뇎)
			{
				녵놆.Remove(symbolMap.Id);
			}
			놎(symbolMap);
		}
	}

	public bool TryGetSymbolMapState(Symbol symbol, out SymbolMapState mapState)
	{
		SymbolMap symbolMap = 녴(symbol);
		if (symbolMap != null)
		{
			mapState = new SymbolMapState(symbolMap);
		}
		else
		{
			mapState = null;
		}
		return mapState != null;
	}

	public bool TryGetQuotesSymbol(Symbol tradableSymbol, out Symbol quotesSymbol)
	{
		quotesSymbol = null;
		lock (녵뇎)
		{
			SymbolMap symbolMap = 녴(tradableSymbol);
			if (symbolMap == null || !symbolMap.IsActive)
			{
				return false;
			}
			quotesSymbol = symbolMap.QuotesSymbol;
		}
		return quotesSymbol != null;
	}

	public bool TryGetHistorySymbol(Symbol tradableSymbol, Period period, out Symbol historySymbol)
	{
		lock (녵뇎)
		{
			int num = 0;
			Symbol symbol = null;
			while (녴(tradableSymbol, period, out historySymbol))
			{
				symbol = historySymbol;
				num++;
				if (historySymbol.Id == tradableSymbol.Id)
				{
					break;
				}
				tradableSymbol = historySymbol;
			}
			historySymbol = symbol;
			return num > 0;
		}
	}

	public bool TryGetVolumeAnalysisSymbol(Symbol tradableSymbol, out Symbol volumeAnalysisSymbol)
	{
		lock (녵뇎)
		{
			int num = 0;
			Symbol symbol = null;
			while (녴(tradableSymbol, out volumeAnalysisSymbol))
			{
				symbol = volumeAnalysisSymbol;
				num++;
				if (volumeAnalysisSymbol.Id == tradableSymbol.Id)
				{
					break;
				}
				tradableSymbol = volumeAnalysisSymbol;
			}
			volumeAnalysisSymbol = symbol;
			return num > 0;
		}
	}

	private bool 녴(Symbol P_0, Period P_1, out Symbol P_2)
	{
		P_2 = null;
		SymbolMap symbolMap = 녴(P_0);
		if (symbolMap == null || !symbolMap.IsActive)
		{
			return false;
		}
		return symbolMap.녴(P_1, out P_2);
	}

	private bool 녴(Symbol P_0, out Symbol P_1)
	{
		P_1 = null;
		SymbolMap symbolMap = 녴(P_0);
		if (symbolMap == null || !symbolMap.IsActive)
		{
			return false;
		}
		P_1 = symbolMap.VolumeAnalysisSymbol;
		return true;
	}

	private SymbolMap 녴(Symbol P_0)
	{
		return 녵놆.Values.SingleOrDefault((SymbolMap P_0) => P_0.TradableSymbol.Equals(P_0));
	}

	private void 녴(SymbolMappingParameters P_0, string P_1 = null)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂녪());
		}
		if (P_0.TradableSymbol == null)
		{
			throw new ArgumentNullException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭녮());
		}
		놴(P_0, P_1);
		놴(P_0);
	}

	private void 놴(SymbolMappingParameters P_0, string P_1 = null)
	{
		SymbolMap symbolMap = 녴(P_0.TradableSymbol);
		bool num;
		if (!string.IsNullOrEmpty(P_1))
		{
			if (symbolMap == null)
			{
				return;
			}
			num = symbolMap.Id != P_1;
		}
		else
		{
			num = symbolMap != null;
		}
		if (num)
		{
			throw new InvalidOperationException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭뇆() + P_0.TradableSymbol.Name + _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭뇉());
		}
	}

	private void 녴(SymbolMappingParameters P_0)
	{
		if (P_0.TradableSymbol.Equals(P_0.QuotesSymbol))
		{
			throw new InvalidOperationException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭뇍());
		}
		if (P_0.TradableSymbol.Equals(P_0.TickHistorySymbol))
		{
			throw new InvalidOperationException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭놙());
		}
		if (P_0.TradableSymbol.Equals(P_0.MinuteHistorySymbol))
		{
			throw new InvalidOperationException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭녰());
		}
		if (P_0.TradableSymbol.Equals(P_0.DayHistorySymbol))
		{
			throw new InvalidOperationException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭놚());
		}
		if (P_0.TradableSymbol.Equals(P_0.VolumeAnalysisSymbol))
		{
			throw new InvalidOperationException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭놹());
		}
	}

	private void 놴(SymbolMappingParameters P_0)
	{
		녴(P_0.TradableSymbol, P_0.QuotesSymbol, (SymbolMapState P_0) => P_0.QuotesSymbol);
		녴(P_0.TradableSymbol, P_0.TickHistorySymbol, (SymbolMapState P_0) => P_0.TickHistorySymbol);
		녴(P_0.TradableSymbol, P_0.MinuteHistorySymbol, (SymbolMapState P_0) => P_0.MinuteHistorySymbol);
		녴(P_0.TradableSymbol, P_0.DayHistorySymbol, (SymbolMapState P_0) => P_0.DayHistorySymbol);
		녴(P_0.TradableSymbol, P_0.VolumeAnalysisSymbol, (SymbolMapState P_0) => P_0.VolumeAnalysisSymbol);
	}

	private void 녴(Symbol P_0, Symbol P_1, Func<SymbolMapState, Symbol> P_2)
	{
		if (P_0.Equals(P_1))
		{
			return;
		}
		Symbol[] array = GetSymbolsChainRecursive(P_1, P_2).ToArray();
		if (!array.Any((Symbol P_0) => P_0.Equals(P_0)))
		{
			return;
		}
		StringBuilder stringBuilder = new StringBuilder(P_0.Name);
		Symbol[] array2 = array;
		foreach (Symbol symbol in array2)
		{
			stringBuilder.Append(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭놘());
			stringBuilder.Append(symbol.Name);
			if (symbol.Equals(P_0))
			{
				break;
			}
		}
		string text = stringBuilder.ToString();
		throw new InvalidOperationException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭뇌() + text + _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놢());
	}

	[IteratorStateMachine(typeof(놎))]
	public IEnumerable<Symbol> GetSymbolsChainRecursive(Symbol mappedSymbol, Func<SymbolMapState, Symbol> getMappedSymbolFromMap)
	{
		//yield-return decompiler failed: Unexpected instruction in Iterator.Dispose()
		return new 놎(-2)
		{
			놵뇄 = this,
			놵놝 = mappedSymbol,
			놵놈 = getMappedSymbolFromMap
		};
	}

	private void 녴(SymbolMap P_0)
	{
		녵녻?.Invoke(this, new SymbolsMappingEventArgs(P_0));
	}

	private void 놴(SymbolMap P_0)
	{
		녵녙?.Invoke(this, new SymbolsMappingEventArgs(P_0));
	}

	private void 녴(SymbolMap P_0, SymbolMapState P_1)
	{
		녵놢?.Invoke(this, new SymbolsMappingEventArgs(P_0, P_1));
	}

	private void 놂(SymbolMap P_0)
	{
		녵녧?.Invoke(this, new SymbolsMappingEventArgs(P_0));
	}

	private void 놎(SymbolMap P_0)
	{
		녵녤?.Invoke(this, new SymbolsMappingEventArgs(P_0));
	}
}
