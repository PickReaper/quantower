using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace TradingPlatform.BusinessLayer;

public static class TradingSignalExtensions
{
	[Serializable]
	[CompilerGenerated]
	private sealed class 녴
	{
		public static readonly 녴 놭놚 = new 녴();

		public static Func<Symbol, DateTime> 놭놹;

		internal DateTime 녴(Symbol P_0)
		{
			return P_0.ExpirationDate;
		}
	}

	[CompilerGenerated]
	private sealed class 놴
	{
		public TradingSignal 놭놘;

		public Func<Connection, bool> 놭뇌;

		public Func<Symbol, bool> 놭녷;

		internal bool 녴(Connection P_0)
		{
			return P_0.VendorName == 놭놘.VendorName;
		}

		internal bool 녴(Symbol P_0)
		{
			return P_0.Name == 놭놘.Ticker;
		}

		internal bool 놴(Connection P_0)
		{
			if (string.IsNullOrEmpty(놭놘.VendorName) || P_0.VendorName == 놭놘.VendorName)
			{
				return P_0.놫놪.SymbolTypes.Contains(SymbolType.Futures);
			}
			return false;
		}

		internal bool 놴(Symbol P_0)
		{
			return P_0.Root == 놭놘.Root;
		}
	}

	public static bool TryFindSymbol(this TradingSignal tradingSignal, out Symbol symbol)
	{
		symbol = null;
		if (!string.IsNullOrEmpty(tradingSignal.Ticker))
		{
			SearchSymbolsRequestParameters searchSymbolsRequestParameters = new SearchSymbolsRequestParameters
			{
				FilterName = tradingSignal.Ticker
			};
			IList<Symbol> list = ((!string.IsNullOrEmpty(tradingSignal.VendorName)) ? Core.Instance.Connections.Connected.FirstOrDefault((Connection P_0) => P_0.VendorName == tradingSignal.VendorName)?.녴(searchSymbolsRequestParameters) : Core.Instance.SearchSymbols(searchSymbolsRequestParameters));
			if (list == null || !list.Any())
			{
				return false;
			}
			symbol = list.FirstOrDefault((Symbol P_0) => P_0.Name == tradingSignal.Ticker);
		}
		else if (!string.IsNullOrEmpty(tradingSignal.Root))
		{
			foreach (Connection item in Core.Instance.Connections.Connected.Where((Connection P_0) => (string.IsNullOrEmpty(tradingSignal.VendorName) || P_0.VendorName == tradingSignal.VendorName) && P_0.놫놪.SymbolTypes.Contains(SymbolType.Futures)))
			{
				IList<Symbol> source = item.녴(new SearchSymbolsRequestParameters
				{
					FilterName = tradingSignal.Root,
					SymbolTypes = new SymbolType[1] { SymbolType.Futures }
				});
				if (!source.Any())
				{
					continue;
				}
				List<Symbol> source2 = source.Where((Symbol P_0) => P_0.Root == tradingSignal.Root).ToList();
				if (source2.Any())
				{
					symbol = source2.MinBy((Symbol P_0) => P_0.ExpirationDate);
					if (symbol != null)
					{
						break;
					}
				}
			}
		}
		if (symbol != null)
		{
			symbol = Core.Instance.GetSymbol(symbol.CreateInfo());
		}
		Symbol symbol2 = symbol;
		if (symbol2 != null)
		{
			return symbol2.State == BusinessObjectState.Normal;
		}
		return false;
	}
}
