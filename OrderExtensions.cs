using System;

namespace TradingPlatform.BusinessLayer;

public static class OrderExtensions
{
	public static double GetExecutionPrice(this IOrder order)
	{
		if (order != null)
		{
			OrderType orderType = order.OrderType;
			if (orderType != null)
			{
				_ = orderType.Behavior;
				if (0 == 0)
				{
					return order.OrderType.Behavior switch
					{
						OrderTypeBehavior.Unspecified => double.NaN, 
						OrderTypeBehavior.Market => double.NaN, 
						OrderTypeBehavior.Limit => order.Price, 
						OrderTypeBehavior.Stop => order.TriggerPrice, 
						OrderTypeBehavior.TrailingStop => order.TriggerPrice, 
						OrderTypeBehavior.StopLimit => order.Price, 
						_ => throw new ArgumentOutOfRangeException(), 
					};
				}
			}
		}
		return double.NaN;
	}
}
