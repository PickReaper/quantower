using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using TradingPlatform.BusinessLayer.Utils;

namespace TradingPlatform.BusinessLayer;

public static class OrderRequestParametersExtensions
{
	[Serializable]
	[CompilerGenerated]
	private sealed class 녴
	{
		public static readonly 녴 놭놐 = new 녴();

		public static Func<SlTpHolder, bool> 놭녚;

		public static Func<SlTpHolder, bool> 놭녳;

		internal bool 녴(SlTpHolder P_0)
		{
			if (double.IsNaN(P_0.QuantityPercentage))
			{
				return double.IsNaN(P_0.Quantity);
			}
			return false;
		}

		internal bool 놴(SlTpHolder P_0)
		{
			return P_0.Quantity == 0.0;
		}
	}

	public static double GetExecutionPrice(this OrderRequestParameters parameters)
	{
		if (parameters != null)
		{
			OrderType orderType = parameters.OrderType;
			if (orderType != null)
			{
				_ = orderType.Behavior;
				if (0 == 0)
				{
					return parameters.OrderType.Behavior switch
					{
						OrderTypeBehavior.Unspecified => double.NaN, 
						OrderTypeBehavior.Market => double.NaN, 
						OrderTypeBehavior.Limit => parameters.Price, 
						OrderTypeBehavior.Stop => parameters.TriggerPrice, 
						OrderTypeBehavior.TrailingStop => parameters.TriggerPrice, 
						OrderTypeBehavior.StopLimit => parameters.Price, 
						_ => throw new ArgumentOutOfRangeException(), 
					};
				}
			}
		}
		return double.NaN;
	}

	public static void SetExecutionPrice(this OrderRequestParameters parameters, double price)
	{
		if (parameters == null)
		{
			return;
		}
		OrderType orderType = parameters.OrderType;
		if (orderType == null)
		{
			return;
		}
		_ = orderType.Behavior;
		if (0 == 0)
		{
			switch (parameters.OrderType.Behavior)
			{
			case OrderTypeBehavior.Limit:
				parameters.Price = price;
				break;
			case OrderTypeBehavior.Stop:
			case OrderTypeBehavior.StopLimit:
				parameters.TriggerPrice = price;
				break;
			case OrderTypeBehavior.TrailingStop:
				break;
			}
		}
	}

	public static bool IsCorrespondingOrder(this OrderRequestParameters parameters, IOrder order)
	{
		if (parameters.Symbol.IsSameAs(order.Symbol) && parameters.Account.Equals(order.Account) && parameters.OrderTypeId == order.OrderTypeId && parameters.Side == order.Side && Math.Abs(parameters.Quantity - order.TotalQuantity) < double.Epsilon)
		{
			return Math.Abs(parameters.OrderType.GetFillPrice(parameters) - order.GetExecutionPrice()) < double.Epsilon;
		}
		return false;
	}

	public static bool TryCorrectBracketsQuantity(this OrderRequestParameters requestParameters, out string error)
	{
		error = null;
		if (!녴(requestParameters.Quantity, requestParameters.Symbol.LotStep, requestParameters.StopLossItems, out error))
		{
			return false;
		}
		if (!녴(requestParameters.Quantity, requestParameters.Symbol.LotStep, requestParameters.TakeProfitItems, out error))
		{
			return false;
		}
		return true;
	}

	private static bool 녴(double P_0, double P_1, List<SlTpHolder> P_2, out string P_3)
	{
		P_3 = null;
		if (P_2 == null || P_2.Count == 0 || P_2.All((SlTpHolder P_0) => double.IsNaN(P_0.QuantityPercentage) && double.IsNaN(P_0.Quantity)))
		{
			return true;
		}
		double num = 0.0;
		foreach (SlTpHolder item in P_2)
		{
			if (double.IsNaN(item.QuantityPercentage))
			{
				num += item.Quantity;
				continue;
			}
			double num3 = (item.Quantity = CoreMath.RoundToIncrement(item.QuantityPercentage / 100.0 * P_0, P_1));
			num += num3;
		}
		if (num != P_0)
		{
			if (num < P_0)
			{
				P_2.Last().Quantity += P_0 - num;
			}
			else
			{
				if (!(P_2.Last().Quantity > num - P_0))
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(93, 2);
					defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂녭());
					defaultInterpolatedStringHandler.AppendFormatted(num);
					defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂녱());
					defaultInterpolatedStringHandler.AppendFormatted(P_0);
					defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놲());
					P_3 = defaultInterpolatedStringHandler.ToStringAndClear();
					return false;
				}
				P_2.Last().Quantity -= num - P_0;
			}
		}
		if (P_2.Any((SlTpHolder P_0) => P_0.Quantity == 0.0))
		{
			P_3 = _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂높();
			return false;
		}
		return true;
	}
}
