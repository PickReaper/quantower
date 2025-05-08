using System.Collections.Generic;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using TradingPlatform.BusinessLayer.Utils;

namespace TradingPlatform.BusinessLayer;

public class TrailingStopOrderType : OrderType
{
	public override string Id => _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵뇊();

	public override string Name => loc.key(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰뇇());

	public override string Abbreviation => _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰놛();

	public override OrderTypeBehavior Behavior => OrderTypeBehavior.TrailingStop;

	public TrailingStopOrderType(params TimeInForce[] allowedTimeInForce)
		: base(allowedTimeInForce)
	{
		base.Usage = OrderTypeUsage.All;
		base.SLTPPriceMeasurement = PriceMeasurement.Offset;
	}

	public override IList<SettingItem> GetOrderSettings(OrderRequestParameters parameters, FormatSettings formatSettings)
	{
		IList<SettingItem> orderSettings = base.GetOrderSettings(parameters, formatSettings);
		int value = 1;
		if (parameters.Type == RequestType.ModifyOrder)
		{
			value = (int)parameters.TrailOffset;
		}
		orderSettings.Add(new SettingItemInteger(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇋노(), value)
		{
			Text = loc._(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰놼(), null, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰놗()),
			Minimum = 1
		});
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
		defaultInterpolatedStringHandler.AppendFormatted(placeRequest.Symbol.FormatOffset(placeRequest.TrailOffset, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놎놊()));
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
		defaultInterpolatedStringHandler.AppendFormatted(modifyRequest.Symbol.FormatOffset(modifyRequest.TrailOffset, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놎놊()));
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
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(33, 9);
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
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸녺());
		defaultInterpolatedStringHandler.AppendFormatted(order.Symbol.FormatOffset(order.TrailOffset, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놎놊()));
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰뇂());
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸놣());
		defaultInterpolatedStringHandler.AppendFormatted(order.Account.GetCurrentName());
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸녢());
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	public override IList<DealTicketItem> GetDealTicketItems(OrderRequestParameters request)
	{
		IList<DealTicketItem> dealTicketItems = base.GetDealTicketItems(request);
		dealTicketItems.Add(new DealTicketItem(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰놼(), request.Symbol.FormatOffset(request.TrailOffset, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놎놊()), 5500));
		return dealTicketItems;
	}

	public override double GetFillPrice(OrderRequestParameters parameters)
	{
		double result = double.NaN;
		SettingItem itemByPath = parameters.AdditionalParameters.GetItemByPath(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇋노());
		int num = ((itemByPath == null) ? ((int)parameters.TrailOffset) : ((int)itemByPath.Value));
		if (parameters.Symbol != null)
		{
			result = ((parameters.Side != 0) ? parameters.Symbol.CalculatePrice(parameters.Symbol.Bid, -num) : parameters.Symbol.CalculatePrice(parameters.Symbol.Ask, num));
		}
		return result;
	}
}
