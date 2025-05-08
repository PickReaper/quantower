using System.Collections.Generic;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using TradingPlatform.BusinessLayer.Utils;

namespace TradingPlatform.BusinessLayer;

public class LimitIfTouchedOrderType : LimitOrderType
{
	public override string Id => _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰녒();

	public override string Name => loc.key(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰녕());

	public override string Abbreviation => _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰녖();

	public override OrderTypeBehavior Behavior => OrderTypeBehavior.StopLimit;

	public LimitIfTouchedOrderType(params TimeInForce[] allowedTimeInForce)
		: base(allowedTimeInForce)
	{
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
				num = ((parameters.Side == Side.Buy) ? symbol.Ask : symbol.Bid);
				num = CoreMath.ProcessNaN(num);
			}
			else if (parameters.Type == RequestType.ModifyOrder)
			{
				num = parameters.TriggerPrice;
				enabled = Core.Instance.RulesManager.IsAllowed(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녲(), parameters.Account, parameters.Symbol, this).Status == TradingOperationStatus.Allowed;
			}
			VariableTick variableTick = symbol.FindVariableTick(num);
			if (variableTick != null)
			{
				num2 = variableTick.TickSize;
				decimalPlaces = variableTick.Precision;
			}
		}
		SettingItemDouble item = new SettingItemDouble(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇋녘(), num)
		{
			Text = loc._(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰놇(), null, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놓녴()),
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
		defaultInterpolatedStringHandler.AppendFormatted(order.Account.GetCurrentName());
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸녢());
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	public override ValidateResult ValidateOrderRequestParameters(OrderRequestParameters parameters)
	{
		return base.ValidateOrderRequestParameters(parameters);
	}

	public override IList<DealTicketItem> GetDealTicketItems(OrderRequestParameters request)
	{
		IList<DealTicketItem> dealTicketItems = base.GetDealTicketItems(request);
		dealTicketItems.Add(new DealTicketItem(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰놇(), request.Symbol.FormatPrice(request.TriggerPrice), 5550));
		return dealTicketItems;
	}
}
