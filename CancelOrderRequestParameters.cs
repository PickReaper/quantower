using System;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;

namespace TradingPlatform.BusinessLayer;

[Published]
public sealed class CancelOrderRequestParameters : TradingRequestParameters, ILoggable
{
	[CompilerGenerated]
	private IOrder 놵놼;

	private string 놵놗;

	public override RequestType Type => RequestType.CancelOrder;

	public IOrder Order
	{
		[CompilerGenerated]
		get
		{
			return 놵놼;
		}
		[CompilerGenerated]
		set
		{
			놵놼 = value;
		}
	}

	public string OrderId
	{
		get
		{
			string id = 놵놗;
			if (id == null)
			{
				IOrder order = Order;
				if (order == null)
				{
					return null;
				}
				id = order.Id;
			}
			return id;
		}
		set
		{
			놵놗 = value;
		}
	}

	public override string ConnectionId => Order.Symbol?.ConnectionId;

	public override string Event
	{
		get
		{
			try
			{
				return OrderType.Format(Order) + _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿논();
			}
			catch (Exception ex)
			{
				Core.Instance.Loggers.Log(ex);
			}
			return _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿녘() + Order.OrderTypeId;
		}
	}

	public override string Message
	{
		get
		{
			StringBuilder stringBuilder = new StringBuilder();
			StringBuilder stringBuilder2;
			StringBuilder.AppendInterpolatedStringHandler handler;
			if (Order is Order order)
			{
				stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder3 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(14, 1, stringBuilder2);
				handler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿노());
				handler.AppendFormatted(order.Connection.Name);
				handler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴());
				stringBuilder3.Append(ref handler);
			}
			stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder4 = stringBuilder2;
			handler = new StringBuilder.AppendInterpolatedStringHandler(10, 1, stringBuilder2);
			handler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸녞());
			handler.AppendFormatted(Order.Symbol.Name);
			handler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴());
			stringBuilder4.Append(ref handler);
			string text = Core.Instance.CustomAccountPropertiesProvider.GetProperty(Order.Account, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놛()) as string;
			string value = (string.IsNullOrEmpty(text) ? Order.Account.Name : (Order.Account.Name + _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂녙() + text + _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놢()));
			stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder5 = stringBuilder2;
			handler = new StringBuilder.AppendInterpolatedStringHandler(11, 1, stringBuilder2);
			handler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿녒());
			handler.AppendFormatted(value);
			handler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴());
			stringBuilder5.Append(ref handler);
			stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder6 = stringBuilder2;
			handler = new StringBuilder.AppendInterpolatedStringHandler(12, 1, stringBuilder2);
			handler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿녕());
			handler.AppendFormatted(Order.Symbol.FormatQuantity(Order.RemainingQuantity));
			handler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴());
			stringBuilder6.Append(ref handler);
			stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder7 = stringBuilder2;
			handler = new StringBuilder.AppendInterpolatedStringHandler(12, 1, stringBuilder2);
			handler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿녖());
			handler.AppendFormatted(Order.Id);
			handler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴());
			stringBuilder7.Append(ref handler);
			stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder8 = stringBuilder2;
			handler = new StringBuilder.AppendInterpolatedStringHandler(8, 1, stringBuilder2);
			handler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놄녴());
			handler.AppendFormatted(Order.Side);
			handler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴());
			stringBuilder8.Append(ref handler);
			stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder9 = stringBuilder2;
			handler = new StringBuilder.AppendInterpolatedStringHandler(14, 1, stringBuilder2);
			handler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놄놴());
			handler.AppendFormatted(OrderType.Format(Order));
			handler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴());
			stringBuilder9.Append(ref handler);
			string orderTypeId = Order.OrderTypeId;
			if (!(orderTypeId == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵놋()) && !(orderTypeId == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶놵()))
			{
				if (!(orderTypeId == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵놌()))
				{
					if (orderTypeId == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵뇊())
					{
						stringBuilder2 = stringBuilder;
						StringBuilder stringBuilder10 = stringBuilder2;
						handler = new StringBuilder.AppendInterpolatedStringHandler(17, 1, stringBuilder2);
						handler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놄놎());
						handler.AppendFormatted(Order.Symbol.FormatOffset(Order.TrailOffset, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놎놊()));
						stringBuilder10.Append(ref handler);
					}
				}
				else
				{
					stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder11 = stringBuilder2;
					handler = new StringBuilder.AppendInterpolatedStringHandler(17, 1, stringBuilder2);
					handler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놄놂());
					handler.AppendFormatted(Order.Symbol.FormatPrice(Order.TriggerPrice));
					handler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴());
					stringBuilder11.Append(ref handler);
				}
			}
			else
			{
				stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder12 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(9, 1, stringBuilder2);
				handler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놼());
				handler.AppendFormatted(Order.Symbol.FormatPrice(Order.Price));
				handler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴());
				stringBuilder12.Append(ref handler);
			}
			if (Order.StopLoss != null)
			{
				stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder13 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(11, 1, stringBuilder2);
				handler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놄녞());
				handler.AppendFormatted(Order.StopLoss.Format(Order.Symbol));
				stringBuilder13.Append(ref handler);
			}
			if (Order.TakeProfit != null)
			{
				stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder14 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(13, 1, stringBuilder2);
				handler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놄놫());
				handler.AppendFormatted(Order.TakeProfit.Format(Order.Symbol));
				stringBuilder14.Append(ref handler);
			}
			stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder15 = stringBuilder2;
			handler = new StringBuilder.AppendInterpolatedStringHandler(13, 1, stringBuilder2);
			handler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놄녪());
			handler.AppendFormatted(Core.Instance.TimeUtils.DateTimeUtcNow);
			handler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴());
			stringBuilder15.Append(ref handler);
			if (!string.IsNullOrEmpty(base.SendingSource))
			{
				stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder16 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(8, 1, stringBuilder2);
				handler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놄녶());
				handler.AppendFormatted(base.SendingSource);
				stringBuilder16.Append(ref handler);
			}
			stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder17 = stringBuilder2;
			handler = new StringBuilder.AppendInterpolatedStringHandler(13, 1, stringBuilder2);
			handler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놄녵());
			handler.AppendFormatted(base.RequestId);
			handler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴());
			stringBuilder17.Append(ref handler);
			return stringBuilder.ToString();
		}
	}

	public CancelOrderRequestParameters()
	{
	}

	public CancelOrderRequestParameters(CancelOrderRequestParameters original)
		: base(original)
	{
		OrderId = original.OrderId;
		Order = original.Order;
	}

	public override string ToString()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(8, 2);
		defaultInterpolatedStringHandler.AppendFormatted(base.ToString());
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놤());
		defaultInterpolatedStringHandler.AppendFormatted(Order);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	protected override Account GetAccount()
	{
		return Order?.Account;
	}
}
