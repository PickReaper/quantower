using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Threading;
using TradingPlatform.BusinessLayer.Integration;
using 녴;

namespace TradingPlatform.BusinessLayer;

[Published]
[DataContract(Name = "CryptoAccount", Namespace = "TradingPlatform")]
public class CryptoAccount : Account, IMessageBuilder<MessageCryptoAccount>
{
	private readonly Dictionary<string, CryptoAssetBalances> 놻놸;

	[CompilerGenerated]
	private EventHandler<CryptoAccountEventArgs> 놻놿;

	public CryptoAssetBalances[] Balances => 놻놸.Values.ToArray();

	public event EventHandler<CryptoAccountEventArgs> BalanceUpdated
	{
		[CompilerGenerated]
		add
		{
			EventHandler<CryptoAccountEventArgs> eventHandler = 놻놿;
			EventHandler<CryptoAccountEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<CryptoAccountEventArgs> value2 = (EventHandler<CryptoAccountEventArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref 놻놿, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<CryptoAccountEventArgs> eventHandler = 놻놿;
			EventHandler<CryptoAccountEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<CryptoAccountEventArgs> value2 = (EventHandler<CryptoAccountEventArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref 놻놿, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	internal CryptoAccount(string P_0)
		: base(P_0)
	{
		놻놸 = new Dictionary<string, CryptoAssetBalances>();
	}

	internal CryptoAccount(BusinessObjectInfo P_0)
		: base(P_0)
	{
		놻놸 = new Dictionary<string, CryptoAssetBalances>();
	}

	public bool TryGetAssetBalances(string assetId, out CryptoAssetBalances cryptoAssetBalances)
	{
		return 놻놸.TryGetValue(assetId, out cryptoAssetBalances);
	}

	internal void 녴(MessageCryptoAssetBalances P_0)
	{
		AccountBalanceEventReason reason = AccountBalanceEventReason.Update;
		if (!놻놸.TryGetValue(P_0.AssetId, out var value))
		{
			value = (놻놸[P_0.AssetId] = new CryptoAssetBalances(base.ConnectionId));
			reason = AccountBalanceEventReason.New;
		}
		value.녴(P_0);
		놻놿.InvokeSafely(this, new CryptoAccountEventArgs(reason, value));
	}

	public override BusinessObjectInfo CreateInfo()
	{
		놅 obj = base.CreateInfo() as 놅;
		obj.IsCrypto = true;
		return obj;
	}

	private MessageCryptoAccount 녴()
	{
		return new MessageCryptoAccount
		{
			AccountId = base.Id,
			AccountName = base.Name,
			AssetId = base.AccountCurrency?.Id,
			Balance = base.Balance,
			AccountAdditionalInfo = base.AdditionalInfo?.Items.ToList()
		};
	}

	MessageCryptoAccount IMessageBuilder<MessageCryptoAccount>.BuildMessage()
	{
		//ILSpy generated this explicit interface implementation from .override directive in 녴
		return this.녴();
	}
}
