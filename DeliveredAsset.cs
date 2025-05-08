using System;
using System.Runtime.CompilerServices;
using System.Threading;
using TradingPlatform.BusinessLayer.Integration;

namespace TradingPlatform.BusinessLayer;

public sealed class DeliveredAsset : TradingObject, IMessageBuilder<MessageOpenDeliveredAsset>
{
	[CompilerGenerated]
	private double 놻놓;

	[CompilerGenerated]
	private string 놻놇;

	[CompilerGenerated]
	private DateTime 놻뇅;

	[CompilerGenerated]
	private Action<DeliveredAsset> 놻놵;

	public double Quantity
	{
		[CompilerGenerated]
		get
		{
			return 놻놓;
		}
		[CompilerGenerated]
		private set
		{
			놻놓 = value;
		}
	}

	public string Status
	{
		[CompilerGenerated]
		get
		{
			return 놻놇;
		}
		[CompilerGenerated]
		private set
		{
			놻놇 = value;
		}
	}

	public DateTime CreationTime
	{
		[CompilerGenerated]
		get
		{
			return 놻뇅;
		}
		[CompilerGenerated]
		private set
		{
			놻뇅 = value;
		}
	}

	/// <summary>
	/// Will be triggered on each <see cref="M:TradingPlatform.BusinessLayer.DeliveredAsset.UpdateByMessage(TradingPlatform.BusinessLayer.Integration.MessageOpenDeliveredAsset)" /> invocation 
	/// </summary>
	public event Action<DeliveredAsset> Updated
	{
		[CompilerGenerated]
		add
		{
			Action<DeliveredAsset> action = 놻놵;
			Action<DeliveredAsset> action2;
			do
			{
				action2 = action;
				Action<DeliveredAsset> value2 = (Action<DeliveredAsset>)Delegate.Combine(action2, value);
				action = Interlocked.CompareExchange(ref 놻놵, value2, action2);
			}
			while ((object)action != action2);
		}
		[CompilerGenerated]
		remove
		{
			Action<DeliveredAsset> action = 놻놵;
			Action<DeliveredAsset> action2;
			do
			{
				action2 = action;
				Action<DeliveredAsset> value2 = (Action<DeliveredAsset>)Delegate.Remove(action2, value);
				action = Interlocked.CompareExchange(ref 놻놵, value2, action2);
			}
			while ((object)action != action2);
		}
	}

	internal DeliveredAsset(string P_0)
		: base(P_0)
	{
	}

	internal void 녴(MessageOpenDeliveredAsset P_0)
	{
		base.Id = P_0.Id;
		if (ConnectionCache != null && ConnectionCache.SymbolsCache.녴(P_0.SymbolId, out var symbol))
		{
			base.Symbol = symbol;
		}
		if (ConnectionCache != null && ConnectionCache.AccountsCache.녴(P_0.AccountId, out var account))
		{
			base.Account = account;
		}
		Quantity = P_0.Quantity;
		Status = P_0.Status;
		CreationTime = P_0.CreationTime;
		ProcessAdditionalItems(P_0.AdditionalInfoItems);
		놻놵?.Invoke(this);
	}

	public MessageOpenDeliveredAsset BuildMessage()
	{
		return new MessageOpenDeliveredAsset
		{
			Id = base.Id,
			AccountId = base.Account?.Id,
			SymbolId = base.Symbol?.Id,
			Quantity = Quantity,
			Status = Status,
			CreationTime = CreationTime
		};
	}
}
