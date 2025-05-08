using System;
using System.Runtime.CompilerServices;

namespace TradingPlatform.BusinessLayer;

public readonly struct ExchangeComplexIdentifier : IEquatable<ExchangeComplexIdentifier>
{
	[CompilerGenerated]
	private readonly string 놀;

	[CompilerGenerated]
	private readonly string 놔;

	public string ConnectionId
	{
		[CompilerGenerated]
		get
		{
			return 놀;
		}
	}

	public string ExchangeId
	{
		[CompilerGenerated]
		get
		{
			return 놔;
		}
	}

	public ExchangeComplexIdentifier(string connectionId, string exchangeId)
	{
		놀 = connectionId;
		놔 = exchangeId;
	}

	public bool Equals(ExchangeComplexIdentifier other)
	{
		if (ConnectionId == other.ConnectionId)
		{
			return ExchangeId == other.ExchangeId;
		}
		return false;
	}

	public override bool Equals(object obj)
	{
		if (obj is ExchangeComplexIdentifier other)
		{
			return Equals(other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return (ConnectionId.GetHashCode() * 397) ^ ExchangeId.GetHashCode();
	}

	public static bool operator ==(ExchangeComplexIdentifier left, ExchangeComplexIdentifier right)
	{
		return left.Equals(right);
	}

	public static bool operator !=(ExchangeComplexIdentifier left, ExchangeComplexIdentifier right)
	{
		return !left.Equals(right);
	}
}
