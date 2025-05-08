using System.Collections.Generic;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using TradingPlatform.BusinessLayer.Utils;

namespace TradingPlatform.BusinessLayer;

public class StopLimitOrderType : LimitOrderType
{
	public override string Id => _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵놕();

	public override string Name => loc.key(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놓놫());

	public override string Abbreviation => _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놓녪();

	public override OrderTypeBehavior Behavior => OrderTypeBehavior.StopLimit;

	public StopLimitOrderType(params TimeInForce[] allowedTimeInForce)
		: base(allowedTimeInForce)
	{
	}

	public override IList<SettingItem> GetOrderSettings(OrderRequestParameters parameters, FormatSettings formatSettings)
	{
		IList<SettingItem> orderSettings = base.GetOrderSettings(parameters, formatSettings);
		double price = 0.0;
		double num = 0.0;
		double minimum = 1E-05;
		double increment = 1E-05;
		int decimalPlaces = 5;
		Symbol symbol = parameters.Symbol;
		bool enabled = true;
		if (symbol != null)
		{
			if (parameters.Type == RequestType.PlaceOrder)
			{
				num = ((parameters.Side == Side.Buy) ? symbol.Ask : symbol.Bid);
				num = CoreMath.ProcessNaN(num);
				price = symbol.CalculatePrice(num, (parameters.Side != 0) ? 1 : (-1));
			}
			else if (parameters.Type == RequestType.ModifyOrder)
			{
				price = parameters.Price;
				num = parameters.TriggerPrice;
				enabled = Core.Instance.RulesManager.IsAllowed(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녲(), parameters.Account, parameters.Symbol, this).Status == TradingOperationStatus.Allowed;
			}
			VariableTick variableTick = symbol.FindVariableTick(price);
			if (variableTick != null)
			{
				minimum = variableTick.TickSize;
			}
			variableTick = symbol.FindVariableTick(num);
			if (variableTick != null)
			{
				increment = variableTick.TickSize;
				decimalPlaces = variableTick.Precision;
			}
		}
		SettingItemDouble item = new SettingItemDouble(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇋녘(), num)
		{
			Text = loc._(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰놇(), null, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놓녶()),
			SortIndex = 0,
			Minimum = minimum,
			Maximum = 2147483647.0,
			Increment = increment,
			DecimalPlaces = decimalPlaces,
			Enabled = enabled
		};
		orderSettings.Add(item);
		return orderSettings;
	}

	protected override string GetPlaceConfirmMessage(PlaceOrderRequestParameters placeRequest, FormatSettings formatSettings)
	{
		string value = placeRequest.TimeInForce.Format(placeRequest.ExpirationTime);
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(38, 9);
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
		defaultInterpolatedStringHandler.AppendFormatted(placeRequest.Symbol.FormatPrice(placeRequest.Price));
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놀());
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놓놴());
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
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(54, 10);
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
		defaultInterpolatedStringHandler.AppendFormatted(modifyRequest.Symbol.FormatPrice(modifyRequest.Price));
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놀());
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놓놴());
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
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(54, 9);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿녘());
		defaultInterpolatedStringHandler.AppendFormatted(order.Id);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놀());
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸녺());
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
		defaultInterpolatedStringHandler.AppendFormatted(order.Symbol.FormatPrice(order.Price));
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놄녨());
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놓놴());
		defaultInterpolatedStringHandler.AppendFormatted(order.Symbol.FormatPrice(order.TriggerPrice));
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸놣());
		defaultInterpolatedStringHandler.AppendFormatted(cancelRequest.Order.Account.GetCurrentName());
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸녢());
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	public override IList<DealTicketItem> GetDealTicketItems(OrderRequestParameters request)
	{
		IList<DealTicketItem> dealTicketItems = base.GetDealTicketItems(request);
		dealTicketItems.Add(new DealTicketItem(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰놇(), request.Symbol.FormatPrice(request.TriggerPrice), 5550));
		return dealTicketItems;
	}

	public override void SetDefaultPrices(SettingItem[] settings, OrderRequestParameters parameters)
	{
		if (parameters.Symbol != null)
		{
			double num = ((parameters.Side == Side.Buy) ? parameters.Symbol.Ask : parameters.Symbol.Bid);
			if (!double.IsNaN(num))
			{
				double num2 = parameters.Symbol.CalculatePrice(num, (parameters.Side != 0) ? 1 : (-1));
				settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇋녘(), num);
				settings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶녰(), num2);
			}
		}
	}
}
