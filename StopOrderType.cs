using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using TradingPlatform.BusinessLayer.Utils;

namespace TradingPlatform.BusinessLayer;

public class StopOrderType : OrderType
{
	public override string Id => _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵놌();

	public override string Name => loc.key(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵놌());

	public override string Abbreviation => _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰놓();

	public override OrderTypeBehavior Behavior => OrderTypeBehavior.Stop;

	public override string PriceItemId => _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇋녘();

	public StopOrderType(params TimeInForce[] allowedTimeInForce)
		: base(allowedTimeInForce)
	{
		base.Usage = OrderTypeUsage.All;
	}

	public override IList<SettingItem> GetOrderSettings(OrderRequestParameters parameters, FormatSettings formatSettings)
	{
		IList<SettingItem> orderSettings = base.GetOrderSettings(parameters, formatSettings);
		double num = 0.0;
		double num2 = 1E-05;
		int decimalPlaces = 5;
		Symbol symbol = parameters.Symbol;
		bool enabled = true;
		if (symbol != null)
		{
			if (parameters.Type == RequestType.PlaceOrder)
			{
				num = ((parameters.Side == Side.Buy) ? symbol.Bid : symbol.Ask);
				num = CoreMath.ProcessNaN(num);
			}
			else if (parameters.Type == RequestType.ModifyOrder)
			{
				num = parameters.TriggerPrice;
				if (double.IsNaN(num))
				{
					num = parameters.Price;
				}
				enabled = Core.Instance.RulesManager.IsAllowed(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녲(), parameters.Account, parameters.Symbol, this).Status == TradingOperationStatus.Allowed;
			}
			VariableTick obj = symbol.FindVariableTick(num) ?? symbol.VariableTickList.FirstOrDefault();
			num2 = obj.TickSize;
			decimalPlaces = obj.Precision;
		}
		SettingItemDouble item = new SettingItemDouble(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇋녘(), num)
		{
			Text = loc._(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰놇(), null, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰뇅()),
			SortIndex = 0,
			Minimum = num2,
			Maximum = 2147483647.0,
			Increment = num2,
			DecimalPlaces = decimalPlaces,
			Enabled = enabled
		};
		orderSettings.Add(item);
		return orderSettings;
	}

	protected override string GetPlaceConfirmMessage(PlaceOrderRequestParameters placeRequest, FormatSettings formatSettings)
	{
		string value = placeRequest.TimeInForce.Format(placeRequest.ExpirationTime);
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(15, 8);
		defaultInterpolatedStringHandler.AppendFormatted(placeRequest.Side);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놀());
		defaultInterpolatedStringHandler.AppendFormatted(Name);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸녺());
		defaultInterpolatedStringHandler.AppendFormatted(value);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놄녨());
		defaultInterpolatedStringHandler.AppendFormatted(placeRequest.Symbol.FormatQuantity(placeRequest.Quantity, formatSettings.DisplayQuantityInLots));
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놀());
		defaultInterpolatedStringHandler.AppendFormatted(placeRequest.Symbol);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놄녺());
		defaultInterpolatedStringHandler.AppendFormatted(placeRequest.Symbol.FormatPrice(placeRequest.TriggerPrice));
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놀());
		defaultInterpolatedStringHandler.AppendFormatted(OrderType.GetSLTPComfirmMessage(placeRequest));
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸놣());
		defaultInterpolatedStringHandler.AppendFormatted(placeRequest.Account.GetCurrentName());
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	protected override string GetModifyConfirmMessage(ModifyOrderRequestParameters modifyRequest, FormatSettings formatSettings)
	{
		string value = modifyRequest.TimeInForce.Format(modifyRequest.ExpirationTime);
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(31, 9);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰놫());
		defaultInterpolatedStringHandler.AppendFormatted(modifyRequest.OrderId);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂녹());
		defaultInterpolatedStringHandler.AppendFormatted(modifyRequest.Side);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놀());
		defaultInterpolatedStringHandler.AppendFormatted(Name);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸녺());
		defaultInterpolatedStringHandler.AppendFormatted(value);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놄녨());
		defaultInterpolatedStringHandler.AppendFormatted(modifyRequest.Symbol.FormatQuantity(modifyRequest.Quantity, formatSettings.DisplayQuantityInLots));
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놀());
		defaultInterpolatedStringHandler.AppendFormatted(modifyRequest.Symbol);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놄녺());
		defaultInterpolatedStringHandler.AppendFormatted(modifyRequest.Symbol.FormatPrice(modifyRequest.TriggerPrice));
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놀());
		defaultInterpolatedStringHandler.AppendFormatted(OrderType.GetSLTPComfirmMessage(modifyRequest));
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸놣());
		defaultInterpolatedStringHandler.AppendFormatted(modifyRequest.Account.GetCurrentName());
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	public override string GetCancelConfirmMessage(CancelOrderRequestParameters cancelRequest, FormatSettings formatSettings)
	{
		IOrder order = cancelRequest?.Order;
		if (order == null)
		{
			return string.Empty;
		}
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(31, 8);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿녘());
		defaultInterpolatedStringHandler.AppendFormatted(order.Id);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂녙());
		defaultInterpolatedStringHandler.AppendFormatted(order.Side);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놀());
		defaultInterpolatedStringHandler.AppendFormatted(Format(order.PositionId, order.GroupId));
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸녺());
		defaultInterpolatedStringHandler.AppendFormatted(order.TimeInForce);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놄녨());
		defaultInterpolatedStringHandler.AppendFormatted(order.Symbol.FormatQuantity(order.TotalQuantity, formatSettings.DisplayQuantityInLots));
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놀());
		defaultInterpolatedStringHandler.AppendFormatted(order.Symbol.Name);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놄녺());
		defaultInterpolatedStringHandler.AppendFormatted(order.Symbol.FormatPrice(order.TriggerPrice));
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놢());
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸놣());
		defaultInterpolatedStringHandler.AppendFormatted(cancelRequest.Order.Account.GetCurrentName());
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸녢());
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	public override ValidateResult ValidateOrderRequestParameters(OrderRequestParameters parameters)
	{
		ValidateResult result = base.ValidateOrderRequestParameters(parameters);
		if (result.State == ValidateState.NotValid)
		{
			return result;
		}
		double triggerPrice = parameters.TriggerPrice;
		if (parameters.Side == Side.Buy)
		{
			SlTpHolder stopLoss = parameters.StopLoss;
			if (stopLoss != null && stopLoss.PriceMeasurement == PriceMeasurement.Absolute && stopLoss.Price >= triggerPrice)
			{
				return ValidateResult.NotValid(loc._(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰놵(), null, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰뇅()));
			}
			SlTpHolder takeProfit = parameters.TakeProfit;
			if (takeProfit != null && takeProfit.PriceMeasurement == PriceMeasurement.Absolute && takeProfit.Price <= triggerPrice)
			{
				return ValidateResult.NotValid(loc._(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰놡(), null, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰뇅()));
			}
		}
		if (parameters.Side == Side.Sell)
		{
			SlTpHolder stopLoss2 = parameters.StopLoss;
			if (stopLoss2 != null && stopLoss2.PriceMeasurement == PriceMeasurement.Absolute && stopLoss2.Price <= triggerPrice)
			{
				return ValidateResult.NotValid(loc._(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰놻(), null, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰뇅()));
			}
			SlTpHolder takeProfit2 = parameters.TakeProfit;
			if (takeProfit2 != null && takeProfit2.PriceMeasurement == PriceMeasurement.Absolute && takeProfit2.Price >= triggerPrice)
			{
				return ValidateResult.NotValid(loc._(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰놃(), null, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰뇅()));
			}
		}
		return ValidateResult.Valid;
	}

	public override IList<DealTicketItem> GetDealTicketItems(OrderRequestParameters request)
	{
		IList<DealTicketItem> dealTicketItems = base.GetDealTicketItems(request);
		dealTicketItems.Add(new DealTicketItem(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰놇(), request.Symbol.FormatPrice(request.TriggerPrice), 5500));
		return dealTicketItems;
	}

	public override double GetFillPrice(OrderRequestParameters parameters)
	{
		SettingItem itemByPath = parameters.AdditionalParameters.GetItemByPath(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇋녘());
		if (itemByPath != null)
		{
			return (double)itemByPath.Value;
		}
		return parameters.TriggerPrice;
	}

	public override void SetDefaultPrices(SettingItem[] settings, OrderRequestParameters parameters)
	{
		if (parameters.Symbol != null)
		{
			double num = ((parameters.Side == Side.Buy) ? parameters.Symbol.Bid : parameters.Symbol.Ask);
			if (!double.IsNaN(num))
			{
				settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇋녘(), num);
			}
		}
	}
}
