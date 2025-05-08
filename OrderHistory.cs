using System;
using TradingPlatform.BusinessLayer.Integration;

namespace TradingPlatform.BusinessLayer;

/// <summary>
/// Represents an <see cref="T:TradingPlatform.BusinessLayer.Order" /> wrapper
/// </summary>
public class OrderHistory : Order, IMessageBuilder<MessageOrderHistory>, IEquatable<OrderHistory>
{
	public OrderHistory(string connectionId)
		: base(connectionId)
	{
	}

	private MessageOrderHistory 녴()
	{
		return new MessageOrderHistory(BuildMessage());
	}

	MessageOrderHistory IMessageBuilder<MessageOrderHistory>.BuildMessage()
	{
		//ILSpy generated this explicit interface implementation from .override directive in 녴
		return this.녴();
	}

	public bool Equals(OrderHistory other)
	{
		if (other == null)
		{
			return false;
		}
		if (this == other)
		{
			return true;
		}
		if (base.ConnectionId == other.ConnectionId && base.Id == other.Id && base.UniqueId == other.UniqueId && object.Equals(base.Symbol, other.Symbol) && object.Equals(base.Account, other.Account) && object.Equals(base.OrderType, other.OrderType) && object.Equals(base.StopLoss, other.StopLoss) && object.Equals(base.TakeProfit, other.TakeProfit) && object.Equals(base.StopLossItems, other.StopLossItems) && object.Equals(base.TakeProfitItems, other.TakeProfitItems) && object.Equals(base.AdditionalInfo, other.AdditionalInfo) && base.Comment == other.Comment && base.Price == other.Price && base.TriggerPrice == other.TriggerPrice && base.TrailOffset == other.TrailOffset && base.AverageFillPrice == other.AverageFillPrice && base.TotalQuantity == other.TotalQuantity && base.FilledQuantity == other.FilledQuantity && base.RemainingQuantity == other.RemainingQuantity && base.Side == other.Side && State == other.State && base.Status == other.Status && base.ExpirationTime == other.ExpirationTime && base.GroupId == other.GroupId && base.OriginalStatus == other.OriginalStatus && base.PositionId == other.PositionId && base.LastUpdateTime == other.LastUpdateTime && base.OrderTypeId == other.OrderTypeId)
		{
			return base.TimeInForce == other.TimeInForce;
		}
		return false;
	}

	public override bool Equals(object obj)
	{
		if (obj == null)
		{
			return false;
		}
		if (this == obj)
		{
			return true;
		}
		if (obj.GetType() != GetType())
		{
			return false;
		}
		return Equals((OrderHistory)obj);
	}

	public override int GetHashCode()
	{
		HashCode hashCode = default(HashCode);
		hashCode.Add(base.ConnectionId);
		hashCode.Add(base.Id);
		hashCode.Add(base.UniqueId);
		hashCode.Add(base.Symbol);
		hashCode.Add(base.Account);
		hashCode.Add(base.OrderType);
		hashCode.Add(base.StopLoss);
		hashCode.Add(base.TakeProfit);
		hashCode.Add(base.StopLossItems);
		hashCode.Add(base.TakeProfitItems);
		hashCode.Add(base.AdditionalInfo);
		hashCode.Add(base.Comment);
		hashCode.Add(base.Price);
		hashCode.Add(base.TriggerPrice);
		hashCode.Add(base.TrailOffset);
		hashCode.Add(base.AverageFillPrice);
		hashCode.Add(base.TotalQuantity);
		hashCode.Add(base.FilledQuantity);
		hashCode.Add(base.RemainingQuantity);
		hashCode.Add(base.Side);
		hashCode.Add(State);
		hashCode.Add(base.Status);
		hashCode.Add(base.ExpirationTime);
		hashCode.Add(base.GroupId);
		hashCode.Add(base.OriginalStatus);
		hashCode.Add(base.PositionId);
		hashCode.Add(base.LastUpdateTime);
		hashCode.Add(base.OrderTypeId);
		hashCode.Add(base.TimeInForce);
		return hashCode.ToHashCode();
	}
}
