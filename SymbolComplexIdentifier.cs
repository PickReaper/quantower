using System;
using System.Runtime.CompilerServices;

namespace TradingPlatform.BusinessLayer;

public readonly struct SymbolComplexIdentifier : IEquatable<SymbolComplexIdentifier>
{
	[CompilerGenerated]
	private readonly string 놑;

	private readonly ExchangeComplexIdentifier 놦;

	public string ConnectionId => 놦.ConnectionId;

	public string ExchangeId => 놦.ExchangeId;

	public string SymbolId
	{
		[CompilerGenerated]
		get
		{
			return 놑;
		}
	}

	public SymbolComplexIdentifier(string connectionId, string exchangeId, string symbolId)
	{
		놦 = new ExchangeComplexIdentifier(connectionId, exchangeId);
		놑 = symbolId;
	}

	public bool Equals(SymbolComplexIdentifier other)
	{
		if (놦.Equals(other.놦))
		{
			return SymbolId == other.SymbolId;
		}
		return false;
	}

	public override bool Equals(object obj)
	{
		if (obj is SymbolComplexIdentifier other)
		{
			return Equals(other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return (놦.GetHashCode() * 397) ^ SymbolId.GetHashCode();
	}

	public static bool operator ==(SymbolComplexIdentifier left, SymbolComplexIdentifier right)
	{
		return left.Equals(right);
	}

	public static bool operator !=(SymbolComplexIdentifier left, SymbolComplexIdentifier right)
	{
		return !left.Equals(right);
	}
}
