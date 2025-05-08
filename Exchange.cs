using System;
using System.Runtime.CompilerServices;
using TradingPlatform.BusinessLayer.Integration;

namespace TradingPlatform.BusinessLayer;

/// <summary>
/// Contains all information which belong to the given exchange
/// </summary>
[Published]
public sealed class Exchange : BusinessObject, IComparable, IMessageBuilder<MessageExchange>
{
	[CompilerGenerated]
	private string 놄노;

	[CompilerGenerated]
	private string 놄녒;

	[CompilerGenerated]
	private int 놄녕;

	private string 놄녖;

	/// <summary>
	/// Gets Exchange Id
	/// </summary>
	public string Id
	{
		[CompilerGenerated]
		get
		{
			return 놄노;
		}
		[CompilerGenerated]
		private set
		{
			놄노 = value;
		}
	}

	/// <summary>
	/// Gets Exchange name
	/// </summary>
	public string ExchangeName
	{
		[CompilerGenerated]
		get
		{
			return 놄녒;
		}
		[CompilerGenerated]
		private set
		{
			놄녒 = value;
		}
	}

	/// <summary>
	/// Used for the Exchanges comparing
	/// </summary>
	public int SortIndex
	{
		[CompilerGenerated]
		get
		{
			return 놄녕;
		}
		[CompilerGenerated]
		private set
		{
			놄녕 = value;
		}
	}

	internal SessionsContainer CurrentSessionsInfo
	{
		get
		{
			if (string.IsNullOrEmpty(놄녖))
			{
				return null;
			}
			ConnectionCache.TradingSessions.TryGetValue(놄녖, out var value);
			return value;
		}
	}

	public ExchangeComplexIdentifier ComplexId => new ExchangeComplexIdentifier(base.ConnectionId, Id);

	internal Exchange(string P_0)
		: base(P_0)
	{
	}

	internal void 녴(MessageExchange P_0)
	{
		Id = P_0.Id;
		ExchangeName = P_0.ExchangeName;
		SortIndex = P_0.SortIndex;
		놄녖 = P_0.SessionsContainerId;
	}

	private MessageExchange 녴()
	{
		return new MessageExchange
		{
			Id = Id,
			ExchangeName = ExchangeName,
			SortIndex = SortIndex,
			SessionsContainerId = 놄녖
		};
	}

	MessageExchange IMessageBuilder<MessageExchange>.BuildMessage()
	{
		//ILSpy generated this explicit interface implementation from .override directive in 녴
		return this.녴();
	}

	/// <summary>
	/// Compares Exchnges in order by next - SortIndex, Exchange name, Connection Id, Exchange Id.
	/// </summary>
	/// <param name="obj"></param>
	/// <returns></returns>
	[NotPublished]
	public int CompareTo(object obj)
	{
		if (!(obj is Exchange exchange))
		{
			return 1;
		}
		int num = SortIndex.CompareTo(exchange.SortIndex);
		if (num != 0)
		{
			return num;
		}
		num = ExchangeName.CompareTo(exchange.ExchangeName);
		if (num != 0)
		{
			return num;
		}
		num = base.ConnectionId.CompareTo(exchange.ConnectionId);
		if (num != 0)
		{
			return num;
		}
		return Id.CompareTo(exchange.Id);
	}

	public override string ToString()
	{
		return ExchangeName ?? Id.ToString() ?? base.ToString();
	}
}
