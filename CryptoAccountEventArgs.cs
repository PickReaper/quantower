using System;
using System.Runtime.CompilerServices;

namespace TradingPlatform.BusinessLayer;

public class CryptoAccountEventArgs : EventArgs
{
	[CompilerGenerated]
	private readonly AccountBalanceEventReason 놻;

	[CompilerGenerated]
	private readonly CryptoAssetBalances 놃;

	public AccountBalanceEventReason Reason
	{
		[CompilerGenerated]
		get
		{
			return 놻;
		}
	}

	public CryptoAssetBalances Balances
	{
		[CompilerGenerated]
		get
		{
			return 놃;
		}
	}

	public CryptoAccountEventArgs(AccountBalanceEventReason reason, CryptoAssetBalances balances)
	{
		놻 = reason;
		놃 = balances;
	}
}
