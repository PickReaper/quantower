using System.Collections.Generic;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using TradingPlatform.BusinessLayer.Utils;

namespace TradingPlatform.BusinessLayer;

public class CustomOrderType : OrderType
{
	private readonly string 놻녻;

	private readonly OrderTypeBehavior 놻녙;

	private readonly OrderType 놻놢;

	public override string Id
	{
		get
		{
			if (!string.IsNullOrEmpty(놻녻))
			{
				return 놻녻;
			}
			return _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰녴();
		}
	}

	public override string Name
	{
		get
		{
			if (!string.IsNullOrEmpty(놻녻))
			{
				return 놻녻;
			}
			return 놻놢?.Name ?? _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰녴();
		}
	}

	public override string Abbreviation => 놻놢?.Abbreviation ?? _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰놴();

	public override OrderTypeBehavior Behavior => 놻놢?.Behavior ?? 놻녙;

	public override string PriceItemId => 놻놢?.PriceItemId ?? base.PriceItemId;

	public CustomOrderType(string name, OrderTypeBehavior behavior, params TimeInForce[] allowedTifs)
		: this(name, behavior, null, allowedTifs)
	{
	}

	public CustomOrderType(string name, OrderType baseOrderType)
		: this(name, baseOrderType?.Behavior, baseOrderType, baseOrderType?.AllowedTifs ?? new TimeInForce[1])
	{
	}

	public CustomOrderType(OrderType baseOrderType)
		: this(baseOrderType?.Name, baseOrderType?.Behavior, baseOrderType, baseOrderType?.AllowedTifs ?? new TimeInForce[1])
	{
	}

	private CustomOrderType(string P_0, OrderTypeBehavior? P_1, OrderType P_2, params TimeInForce[] allowedTifs)
		: base(allowedTifs)
	{
		놻녻 = P_0;
		놻녙 = P_1.GetValueOrDefault();
		놻놢 = P_2;
	}

	public override IList<SettingItem> GetOrderSettings(OrderRequestParameters parameters, FormatSettings formatSettings)
	{
		return 놻놢?.GetOrderSettings(parameters, formatSettings) ?? base.GetOrderSettings(parameters, formatSettings);
	}

	public override IList<DealTicketItem> GetDealTicketItems(OrderRequestParameters request)
	{
		return 놻놢?.GetDealTicketItems(request) ?? base.GetDealTicketItems(request);
	}

	public override void SetDefaultPrices(SettingItem[] settings, OrderRequestParameters parameters)
	{
		if (놻놢 != null)
		{
			놻놢.SetDefaultPrices(settings, parameters);
		}
		else
		{
			base.SetDefaultPrices(settings, parameters);
		}
	}

	public override double GetFillPrice(OrderRequestParameters parameters)
	{
		return 놻놢?.GetFillPrice(parameters) ?? double.NaN;
	}

	protected override string GetPlaceConfirmMessage(PlaceOrderRequestParameters placeRequest, FormatSettings formatSettings)
	{
		return 놻놢?.GetConfirmMessage(placeRequest, formatSettings);
	}

	protected override string GetModifyConfirmMessage(ModifyOrderRequestParameters modifyRequest, FormatSettings formatSettings)
	{
		return 놻놢?.GetConfirmMessage(modifyRequest, formatSettings);
	}

	public override string GetCancelConfirmMessage(CancelOrderRequestParameters cancelRequest, FormatSettings formatSettings)
	{
		return 놻놢?.GetCancelConfirmMessage(cancelRequest, formatSettings);
	}

	public override ValidateResult ValidateOrderRequestParameters(OrderRequestParameters parameters)
	{
		return 놻놢?.ValidateOrderRequestParameters(parameters) ?? base.ValidateOrderRequestParameters(parameters);
	}
}
