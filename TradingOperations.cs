using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;

namespace TradingPlatform.BusinessLayer;

public static class TradingOperations
{
	[Serializable]
	[CompilerGenerated]
	private sealed class 녴
	{
		public static readonly 녴 놭놵 = new 녴();

		public static Func<OrderType, bool> 놭놡;

		public static Func<OrderType, bool> 놭놻;

		public static Func<OrderType, bool> 놭놃;

		internal bool 녴(OrderType P_0)
		{
			if (P_0.Behavior == OrderTypeBehavior.Limit)
			{
				return (P_0.Usage & OrderTypeUsage.CloseOrder) == OrderTypeUsage.CloseOrder;
			}
			return false;
		}

		internal bool 놴(OrderType P_0)
		{
			if (P_0.Behavior == OrderTypeBehavior.Stop)
			{
				return (P_0.Usage & OrderTypeUsage.CloseOrder) == OrderTypeUsage.CloseOrder;
			}
			return false;
		}

		internal bool 놂(OrderType P_0)
		{
			if (P_0.Behavior == OrderTypeBehavior.TrailingStop)
			{
				return (P_0.Usage & OrderTypeUsage.CloseOrder) == OrderTypeUsage.CloseOrder;
			}
			return false;
		}
	}

	public static AllowedResult IsAllowed(TradingOperation operation, TradingOperationParameters parameters)
	{
		if (parameters == null)
		{
			throw new ArgumentNullException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂녪());
		}
		if (Core.Instance.TradingStatus == TradingStatus.Locked)
		{
			return AllowedResult.GetNotAllowedResult(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂녶());
		}
		Symbol symbol = parameters.Symbol;
		if (symbol != null && symbol.State == BusinessObjectState.Fake)
		{
			return AllowedResult.GetNotAllowedResult(string.Empty);
		}
		if (parameters.Account.IsLocked())
		{
			return AllowedResult.GetNotAllowedResult(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂녵());
		}
		return operation switch
		{
			TradingOperation.PlaceOrder => 녴(parameters), 
			TradingOperation.ModifyOrder => 놴(parameters), 
			TradingOperation.CancelOrder => 놂(parameters), 
			TradingOperation.ClosePosition => 놎(parameters), 
			_ => throw new InvalidOperationException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놭()), 
		};
	}

	public static AllowedResult IsAllowed(TradingOperation operation, IList<TradingOperationParameters> parametersList)
	{
		if (parametersList == null)
		{
			throw new ArgumentNullException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂녲());
		}
		foreach (TradingOperationParameters parameters in parametersList)
		{
			AllowedResult allowedResult = IsAllowed(operation, parameters);
			if (allowedResult.Status == TradingOperationStatus.NotAllowed)
			{
				return allowedResult;
			}
		}
		return AllowedResult.GetAllowedResult();
	}

	public static AllowedResult IsOrderTpAllowed(TradingOperationParameters parameters)
	{
		TradingObject tradingObject = (parameters.Order as TradingObject) ?? parameters.Position;
		if (tradingObject == null)
		{
			return AllowedResult.GetNotAllowedResult(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂뇋());
		}
		AllowedResult allowedResult = AllowedResult.GetAllowedResult();
		OrderType orderType = parameters.Order?.OrderType;
		if (orderType != null)
		{
			allowedResult = Core.Instance.RulesManager.IsAllowed(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵(), tradingObject.Account, tradingObject.Symbol, orderType);
			if (allowedResult.Status == TradingOperationStatus.NotAllowed)
			{
				return allowedResult;
			}
			allowedResult = Core.Instance.RulesManager.IsAllowed(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녪(), tradingObject.Account, tradingObject.Symbol, orderType);
		}
		else
		{
			allowedResult = Core.Instance.RulesManager.IsAllowed(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녪(), tradingObject.Account, tradingObject.Symbol);
		}
		if (allowedResult.Status == TradingOperationStatus.NotAllowed)
		{
			return allowedResult;
		}
		if ((Core.Instance.Connections[tradingObject.ConnectionId]?.BusinessObjects?.OrderTypes)?.FirstOrDefault((OrderType P_0) => P_0.Behavior == OrderTypeBehavior.Limit && (P_0.Usage & OrderTypeUsage.CloseOrder) == OrderTypeUsage.CloseOrder) == null)
		{
			return AllowedResult.GetNotAllowedResult(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놸());
		}
		return AllowedResult.GetAllowedResult();
	}

	public static AllowedResult IsOrderSlAllowed(TradingOperationParameters parameters)
	{
		TradingObject tradingObject = (parameters.Order as TradingObject) ?? parameters.Position;
		if (tradingObject == null)
		{
			return AllowedResult.GetNotAllowedResult(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂뇋());
		}
		AllowedResult allowedResult = AllowedResult.GetAllowedResult();
		OrderType orderType = parameters.Order?.OrderType;
		if (orderType != null)
		{
			allowedResult = Core.Instance.RulesManager.IsAllowed(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵(), tradingObject.Account, tradingObject.Symbol, orderType);
			if (allowedResult.Status == TradingOperationStatus.NotAllowed)
			{
				return allowedResult;
			}
			allowedResult = Core.Instance.RulesManager.IsAllowed(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놫(), tradingObject.Account, tradingObject.Symbol, orderType);
		}
		else
		{
			allowedResult = Core.Instance.RulesManager.IsAllowed(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놫(), tradingObject.Account, tradingObject.Symbol);
		}
		if (allowedResult.Status == TradingOperationStatus.NotAllowed)
		{
			return allowedResult;
		}
		if ((Core.Instance.Connections[tradingObject.ConnectionId]?.BusinessObjects?.OrderTypes)?.FirstOrDefault((OrderType P_0) => P_0.Behavior == OrderTypeBehavior.Stop && (P_0.Usage & OrderTypeUsage.CloseOrder) == OrderTypeUsage.CloseOrder) == null)
		{
			return AllowedResult.GetNotAllowedResult(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놸());
		}
		return AllowedResult.GetAllowedResult();
	}

	public static AllowedResult IsOrderSLTrailAllowed(TradingOperationParameters parameters)
	{
		TradingObject tradingObject = (parameters.Order as TradingObject) ?? parameters.Position;
		if (tradingObject == null)
		{
			return AllowedResult.GetNotAllowedResult(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂뇋());
		}
		AllowedResult allowedResult = AllowedResult.GetAllowedResult();
		OrderType orderType = parameters.Order?.OrderType;
		allowedResult = ((orderType == null) ? Core.Instance.RulesManager.IsAllowed(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶(), tradingObject.Account, tradingObject.Symbol) : Core.Instance.RulesManager.IsAllowed(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶(), tradingObject.Account, tradingObject.Symbol, orderType));
		if (allowedResult.Status == TradingOperationStatus.NotAllowed)
		{
			return allowedResult;
		}
		if ((Core.Instance.Connections[tradingObject.ConnectionId]?.BusinessObjects?.OrderTypes)?.FirstOrDefault((OrderType P_0) => P_0.Behavior == OrderTypeBehavior.TrailingStop && (P_0.Usage & OrderTypeUsage.CloseOrder) == OrderTypeUsage.CloseOrder) == null)
		{
			return AllowedResult.GetNotAllowedResult(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놸());
		}
		return AllowedResult.GetAllowedResult();
	}

	private static AllowedResult 녴(TradingOperationParameters P_0)
	{
		if (P_0.Account != null && P_0.Symbol != null)
		{
			return Core.Instance.RulesManager.IsAllowed(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녞(), P_0.Account, P_0.Symbol);
		}
		if (P_0.Symbol != null)
		{
			return Core.Instance.RulesManager.IsAllowed(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녞(), P_0.Symbol);
		}
		return AllowedResult.GetNotAllowedResult(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놿());
	}

	private static AllowedResult 놴(TradingOperationParameters P_0)
	{
		return AllowedResult.GetAllowedResult();
	}

	private static AllowedResult 놂(TradingOperationParameters P_0)
	{
		if (P_0.Order == null || P_0.Order.State == BusinessObjectState.Fake)
		{
			return AllowedResult.GetNotAllowedResult(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놄());
		}
		return AllowedResult.GetAllowedResult();
	}

	private static AllowedResult 놎(TradingOperationParameters P_0)
	{
		if (P_0.Position == null || P_0.Position.State == BusinessObjectState.Fake)
		{
			return AllowedResult.GetNotAllowedResult(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놰());
		}
		return AllowedResult.GetAllowedResult();
	}
}
