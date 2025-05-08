using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using TradingPlatform.BusinessLayer.LocalOrders;
using TradingPlatform.BusinessLayer.Utils;
using TradingPlatform.BusinessLayer.Utils.Comparers;
using 녴;

namespace TradingPlatform.BusinessLayer;

public abstract class OrderType : BusinessObject, IComparable, 녪, IEquatable<OrderType>
{
	[CompilerGenerated]
	private static class 녴
	{
		public static Func<TimeInForce, SelectItem> 놻녧;
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class 놴
	{
		public static readonly 놴 놻녤 = new 놴();

		public static Func<OrderType, IEnumerable<TimeInForce>> 놻놆;

		internal IEnumerable<TimeInForce> 녴(OrderType P_0)
		{
			return P_0.AllowedTifs;
		}
	}

	[CompilerGenerated]
	private sealed class 놂
	{
		public TimeInForce? 놻뇎;

		internal bool 녴(SelectItem P_0)
		{
			if (놻뇎.HasValue)
			{
				return P_0.Value.Equals((int)놻뇎.Value);
			}
			return true;
		}
	}

	[CompilerGenerated]
	private sealed class 놎
	{
		public OrderRequestParameters 놻놷;

		internal bool 녴(SelectItem P_0)
		{
			return (int)(object)P_0.Value == (int)놻놷.Side;
		}
	}

	public const string Market = "Market";

	public const string Limit = "Limit";

	public const string Stop = "Stop";

	public const string TrailingStop = "Tr.stop";

	public const string StopLimit = "StopLimit";

	public const string MarketIfTouched = "MarketIfTouched";

	public const string LimitIfTouched = "LimitIfTouched";

	public const string Custom = "Custom";

	public const string TIME_IF_FORCE = "Time in force";

	public const string EXPIRATION = "Expiration";

	public const string SIDE = "Side";

	public const string QUANTITY = "Quantity";

	public const string PRICE = "Price";

	public const string TRIGGER_PRICE = "TriggerPrice";

	public const string TRAIL_OFFSET = "TrailOffset";

	public const string COMMENT = "Comment";

	public const string TOTAL = "Total";

	public const string BALANCE_PERCENT = "Balance percent";

	public const string RISK = "Risk";

	public const string RISK_PERCENT = "Risk percent";

	public const string REDUCE_ONLY = "Reduce-Only";

	public const string POST_ONLY = "Post-Only";

	public const string PARENT_ORDER_ID = "Parent Order ID";

	public const int BALANCE_PERCENT_STEPS_COUNT_MULTIPLIER = 100;

	[CompilerGenerated]
	private readonly OrderTypeUsage 놰놼;

	[CompilerGenerated]
	private readonly TimeInForce[] 놰놗;

	[CompilerGenerated]
	private readonly PriceMeasurement 놰뇂;

	[CompilerGenerated]
	private readonly BalanceCalculatorFactory 놰놩;

	private readonly 뇇<string, Rule> 놰녡;

	public abstract string Id { get; }

	public virtual string Name => Id;

	public abstract string Abbreviation { get; }

	public virtual OrderTypeBehavior Behavior => OrderTypeBehavior.Unspecified;

	public OrderTypeUsage Usage
	{
		[CompilerGenerated]
		get
		{
			return 놰놼;
		}
		[CompilerGenerated]
		init
		{
			놰놼 = value;
		}
	}

	public TimeInForce[] AllowedTifs
	{
		[CompilerGenerated]
		get
		{
			return 놰놗;
		}
		[CompilerGenerated]
		init
		{
			놰놗 = value;
		}
	}

	public PriceMeasurement SLTPPriceMeasurement
	{
		[CompilerGenerated]
		get
		{
			return 놰뇂;
		}
		[CompilerGenerated]
		init
		{
			놰뇂 = value;
		}
	}

	public BalanceCalculatorFactory BalanceCalculatorFactory
	{
		[CompilerGenerated]
		get
		{
			return 놰놩;
		}
		[CompilerGenerated]
		init
		{
			놰놩 = value;
		}
	}

	public virtual string PriceItemId => null;

	int 녪.PriorityIndex => 30;

	뇇<string, Rule> 녪.Rules => 놰녡;

	protected OrderType(params TimeInForce[] allowedTimeInForce)
		: base(string.Empty)
	{
		if (allowedTimeInForce.Length == 0)
		{
			allowedTimeInForce = Enum.GetValues(typeof(TimeInForce)).Cast<TimeInForce>().ToArray();
		}
		AllowedTifs = allowedTimeInForce;
		Usage = OrderTypeUsage.Order;
		SLTPPriceMeasurement = PriceMeasurement.Absolute;
		놰녡 = new 뇇<string, Rule>();
		Core.Instance.RulesManager.Defaults.ForEach(delegate(Rule P_0)
		{
			놰녡.녴(P_0.Name, P_0);
		});
	}

	public virtual IList<SettingItem> GetOrderSettings(OrderRequestParameters parameters, FormatSettings formatSettings)
	{
		List<SettingItem> list = new List<SettingItem>();
		녴(list, parameters, -100, (parameters.Type == RequestType.ModifyOrder) ? new TimeInForce?(parameters.TimeInForce) : ((TimeInForce?)null));
		녴((ICollection<SettingItem>)list, parameters, -90, (DateTime?)null);
		녴(list, parameters, -80, (parameters.Type == RequestType.ModifyOrder) ? VisibilityMode.Hidden : VisibilityMode.Visible);
		녴(list, parameters, formatSettings.DisplayQuantityInLots, -70, (parameters.Type == RequestType.ModifyOrder) ? new double?(parameters.Quantity) : ((double?)null));
		if (BalanceCalculatorFactory != null)
		{
			if (BalanceCalculatorFactory(parameters.Symbol, parameters.Account) is CryptoBalanceCalculator)
			{
				녴(list, -60);
				놴(list, -50);
			}
			녴(list, parameters.Symbol?.QuotingCurrency, -40);
			놂(list, -30);
		}
		return list;
	}

	public abstract double GetFillPrice(OrderRequestParameters parameters);

	public virtual void SetDefaultPrices(SettingItem[] settings, OrderRequestParameters parameters)
	{
	}

	public virtual string GetConfirmMessage(OrderRequestParameters parameters, FormatSettings formatSettings)
	{
		string text = string.Empty;
		if (!(parameters is PlaceOrderRequestParameters placeRequest))
		{
			if (parameters is ModifyOrderRequestParameters modifyRequest)
			{
				text = GetModifyConfirmMessage(modifyRequest, formatSettings);
			}
		}
		else
		{
			text = GetPlaceConfirmMessage(placeRequest, formatSettings);
		}
		string additionalPartConfirmMessage = GetAdditionalPartConfirmMessage(parameters, formatSettings);
		if (string.IsNullOrEmpty(additionalPartConfirmMessage))
		{
			return text + _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸녢();
		}
		return text + _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂녙() + additionalPartConfirmMessage + _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸놞();
	}

	protected abstract string GetPlaceConfirmMessage(PlaceOrderRequestParameters placeRequest, FormatSettings formatSettings);

	protected abstract string GetModifyConfirmMessage(ModifyOrderRequestParameters modifyRequest, FormatSettings formatSettings);

	protected virtual string GetAdditionalPartConfirmMessage(OrderRequestParameters parameters, FormatSettings formatSettings)
	{
		return null;
	}

	public abstract string GetCancelConfirmMessage(CancelOrderRequestParameters cancelRequest, FormatSettings formatSettings);

	public virtual ValidateResult ValidateOrderRequestParameters(OrderRequestParameters parameters)
	{
		if (!AllowedTifs.Contains(parameters.TimeInForce))
		{
			return ValidateResult.NotValid(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸놳() + Name + _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸놺());
		}
		if (parameters.StopLossItems != null)
		{
			foreach (SlTpHolder stopLossItem in parameters.StopLossItems)
			{
				if (stopLossItem.PriceMeasurement != 0 && stopLossItem.PriceMeasurement != SLTPPriceMeasurement)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(120, 2);
					defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸놅());
					defaultInterpolatedStringHandler.AppendFormatted(SLTPPriceMeasurement);
					defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸녜());
					defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸뇃());
					defaultInterpolatedStringHandler.AppendFormatted(stopLossItem.PriceMeasurement);
					defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸녯());
					return ValidateResult.NotValid(defaultInterpolatedStringHandler.ToStringAndClear());
				}
			}
		}
		if (parameters.TakeProfitItems != null)
		{
			foreach (SlTpHolder takeProfitItem in parameters.TakeProfitItems)
			{
				if (takeProfitItem.PriceMeasurement != 0 && takeProfitItem.PriceMeasurement != SLTPPriceMeasurement)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(120, 2);
					defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸놅());
					defaultInterpolatedStringHandler.AppendFormatted(SLTPPriceMeasurement);
					defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸녜());
					defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸뇃());
					defaultInterpolatedStringHandler.AppendFormatted(takeProfitItem.PriceMeasurement);
					defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸녯());
					return ValidateResult.NotValid(defaultInterpolatedStringHandler.ToStringAndClear());
				}
			}
		}
		return ValidateResult.Valid;
	}

	public virtual IList<DealTicketItem> GetDealTicketItems(OrderRequestParameters request)
	{
		List<DealTicketItem> list = new List<DealTicketItem>();
		list.Add(new DealTicketItem(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸놮(), request.Symbol.Connection?.Name));
		list.Add(new DealTicketItem(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶놅(), request.Symbol.Name, 1000));
		string text = Core.Instance.CustomAccountPropertiesProvider.GetProperty(request.Account, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놛()) as string;
		list.Add(new DealTicketItem(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶녹(), string.IsNullOrEmpty(text) ? request.Account.Name : (request.Account.Name + _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂녙() + text + _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놢()), 2000));
		list.Add(new DealTicketItem(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶녯(), request.Symbol.FormatQuantity(request.Quantity), 3000));
		if (request.Type == RequestType.ModifyOrder && request is ModifyOrderRequestParameters modifyOrderRequestParameters)
		{
			list.Add(new DealTicketItem(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸녫(), modifyOrderRequestParameters.OrderId, 3500));
		}
		list.Add(new DealTicketItem(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇋뇊(), request.Side.ToString(), 4000));
		list.Add(new DealTicketItem(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸뇁(), Format(request.PositionId, request.GroupId), 5000));
		list.Add(new DealTicketItem(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸놧(), request.TimeInForce.Format(request.ExpirationTime), 6000));
		if (request.StopLossItems != null && request.StopLossItems.Count > 1)
		{
			for (int i = 0; i < request.StopLossItems.Count; i++)
			{
				string key;
				if (!request.StopLoss.IsTrailing)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(12, 1);
					defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸녝());
					defaultInterpolatedStringHandler.AppendFormatted(i + 1);
					defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶놩());
					key = defaultInterpolatedStringHandler.ToStringAndClear();
				}
				else
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(16, 1);
					defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸뇈());
					defaultInterpolatedStringHandler.AppendFormatted(i + 1);
					defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶놩());
					key = defaultInterpolatedStringHandler.ToStringAndClear();
				}
				list.Add(new DealTicketItem(key, request.StopLossItems[i].Format(request.Symbol), 6500 + i));
			}
		}
		else if (request.StopLoss != null)
		{
			list.Add(new DealTicketItem(request.StopLoss.IsTrailing ? _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸놦() : _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸놑(), request.StopLoss.Format(request.Symbol), 6500));
		}
		if (request.TakeProfitItems != null && request.TakeProfitItems.Count > 1)
		{
			for (int j = 0; j < request.TakeProfitItems.Count; j++)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(14, 1);
				defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸놐());
				defaultInterpolatedStringHandler.AppendFormatted(j + 1);
				defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶놩());
				list.Add(new DealTicketItem(defaultInterpolatedStringHandler.ToStringAndClear(), request.TakeProfitItems[j].Format(request.Symbol), 6510 + j));
			}
		}
		else if (request.TakeProfit != null)
		{
			list.Add(new DealTicketItem(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸녚(), request.TakeProfit.Format(request.Symbol), 6510));
		}
		list.Add(new DealTicketItem(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸녳(), Core.Instance.TimeUtils.DateTimeUtcNow.ToString(), 7000));
		if (!string.IsNullOrEmpty(request.Comment))
		{
			list.Add(new DealTicketItem(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇋놋(), request.Comment, 8000));
		}
		if (!string.IsNullOrEmpty(request.SendingSource))
		{
			list.Add(new DealTicketItem(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸놉(), request.SendingSource, 9000));
		}
		return list;
	}

	private void 녴(ICollection<SettingItem> P_0, OrderRequestParameters P_1, int P_2, TimeInForce? P_3 = null)
	{
		List<TimeInForce> obj = P_1?.OrderType?.AllowedTifs?.ToList() ?? P_1?.Symbol?.GetAlowedOrderTypes(OrderTypeUsage.Order)?.SelectMany((OrderType P_0) => P_0.AllowedTifs).Distinct().ToList();
		obj?.Sort(new TimeInForceComparer());
		List<SelectItem> list = obj?.Select(녴).ToList();
		if (list != null && list.Any())
		{
			SelectItem value = list.FirstOrDefault((SelectItem P_0) => !P_3.HasValue || P_0.Value.Equals((int)P_3.Value));
			P_0.Add(new SettingItemSelectorLocalized(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸놥(), value, list, P_2)
			{
				Text = loc._(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸놥(), null, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸놯())
			});
		}
	}

	private void 녴(ICollection<SettingItem> P_0, OrderRequestParameters P_1, int P_2, DateTime? P_3 = null)
	{
		TimeInForce[] array = P_1?.OrderType?.AllowedTifs;
		if (array != null && (array.Contains(TimeInForce.GTD) || array.Contains(TimeInForce.GTT)))
		{
			DateTime minDate = Core.Instance.TimeUtils.DateTimeUtcNow.ToSelectedTimeZone();
			DateTime value = P_3 ?? minDate.AddDays(1.0);
			P_0.Add(new SettingItemDateTime(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸녾(), value, P_2)
			{
				Text = loc._(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸녾(), null, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸놯()),
				MinDate = minDate,
				MaxDate = (P_1.Symbol?.ExpirationDate ?? DateTime.MaxValue),
				Relation = new 놲(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸놥(), 녴(TimeInForce.GTD), 녴(TimeInForce.GTT))
			});
		}
	}

	private void 녴(ICollection<SettingItem> P_0, OrderRequestParameters P_1, int P_2, VisibilityMode P_3 = VisibilityMode.Visible)
	{
		List<SelectItem> list = new List<SelectItem>
		{
			new SelectItem(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸녬(), 0),
			new SelectItem(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸녹(), 1)
		};
		SelectItem value = list.First();
		if (P_1 != null && P_1.Type == RequestType.ModifyOrder)
		{
			value = list.FirstOrDefault((SelectItem P_0) => (int)(object)P_0.Value == (int)P_1.Side);
		}
		P_0.Add(new SettingItemRadioLocalized(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇋뇊(), value, list, P_2)
		{
			Text = loc._(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇋뇊(), null, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸놯()),
			VisibilityMode = P_3
		});
	}

	private void 녴(ICollection<SettingItem> P_0, OrderRequestParameters P_1, bool P_2, int P_3, double? P_4 = null)
	{
		double num = 0.0;
		double maximum = 0.0;
		double num2 = 1.0;
		int decimalPlaces = 1;
		double value = 1.0;
		string dimension = null;
		if (P_1 != null && P_1.Symbol?.State == BusinessObjectState.Normal)
		{
			double num3 = (P_2 ? 1.0 : P_1.Symbol.LotSize);
			num = P_1.Symbol.MinLot * num3;
			maximum = P_1.Symbol.MaxLot * num3;
			num2 = (P_2 ? P_1.Symbol.LotStep : P_1.Symbol.NotionalValueStep);
			decimalPlaces = CoreMath.GetValuePrecision((decimal)num2);
			value = (P_4 * num3) ?? num;
			dimension = P_1.Symbol.Product?.Name;
		}
		if (P_2)
		{
			dimension = loc._(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸녔(), null, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸놯());
		}
		P_0.Add(new SettingItemDouble(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶녯(), value, P_3)
		{
			Text = loc._(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶녯(), null, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸놯()),
			Minimum = num,
			Maximum = maximum,
			Increment = num2,
			DecimalPlaces = decimalPlaces,
			UseTradingNumeric = true,
			Dimension = dimension
		});
	}

	private void 녴(ICollection<SettingItem> P_0, int P_1)
	{
		double num = 1.0;
		int decimalPlaces = 0;
		double maximum = double.MaxValue;
		string empty = string.Empty;
		P_0.Add(new SettingItemDoubleWithLink(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸놜(), num, null, P_1)
		{
			Text = loc._(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸놜(), null, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸놯()),
			Minimum = num,
			Maximum = maximum,
			Increment = num,
			DecimalPlaces = decimalPlaces,
			UseTradingNumeric = true,
			Dimension = empty
		});
	}

	private void 놴(ICollection<SettingItem> P_0, int P_1)
	{
		P_0.Add(new SettingItemSlider(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸놨(), 0uL, P_1)
		{
			StepsCount = 10000uL
		});
	}

	private void 녴(ICollection<SettingItem> P_0, Asset P_1, int P_2)
	{
		P_0.Add(new SettingItemDouble(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶놮(), 0.01, P_2)
		{
			Text = loc._(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸녠(), null, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸놯()),
			Minimum = 0.01,
			Maximum = double.MaxValue,
			Increment = 0.01,
			DecimalPlaces = 2,
			UseTradingNumeric = true,
			Dimension = P_1?.Name
		});
	}

	private void 놂(ICollection<SettingItem> P_0, int P_1)
	{
		P_0.Add(new SettingItemDouble(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶녫(), 0.1, P_1)
		{
			Text = loc._(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸놠(), null, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸놯()),
			Minimum = 0.1,
			Maximum = double.MaxValue,
			Increment = 0.1,
			DecimalPlaces = 1,
			UseTradingNumeric = true,
			Dimension = _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸놟()
		});
	}

	private static SelectItem 녴(TimeInForce P_0)
	{
		return new SelectItem(P_0.GetDescription(), (int)P_0);
	}

	public int CompareTo(object obj)
	{
		return Id.CompareTo((obj as OrderType).Id);
	}

	public static string GetSLTPComfirmMessage(OrderRequestParameters requestParameters)
	{
		string text = string.Empty;
		try
		{
			bool flag = requestParameters.StopLossItems.Count > 1 || requestParameters.TakeProfitItems.Count > 1;
			if (requestParameters.StopLoss != null)
			{
				for (int i = 0; i < requestParameters.StopLossItems.Count; i++)
				{
					SlTpHolder slTpHolder = requestParameters.StopLossItems[i];
					string text2 = slTpHolder.Format(requestParameters.Symbol);
					string value = (flag ? (i + 1).ToString() : string.Empty);
					string value2 = (flag ? (_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸녓() + requestParameters.Symbol.FormatQuantity(slTpHolder.Quantity)) : string.Empty);
					if (slTpHolder.IsTrailing)
					{
						text = text + _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸녛() + text2;
					}
					else
					{
						string text3 = text;
						string text4;
						if (slTpHolder.PriceMeasurement != 0)
						{
							DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(12, 3);
							defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸녽());
							defaultInterpolatedStringHandler.AppendFormatted(value);
							defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸놏());
							defaultInterpolatedStringHandler.AppendFormatted(text2);
							defaultInterpolatedStringHandler.AppendFormatted(value2);
							text4 = defaultInterpolatedStringHandler.ToStringAndClear();
						}
						else
						{
							DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(11, 3);
							defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸녽());
							defaultInterpolatedStringHandler.AppendFormatted(value);
							defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸녥());
							defaultInterpolatedStringHandler.AppendFormatted(text2);
							defaultInterpolatedStringHandler.AppendFormatted(value2);
							text4 = defaultInterpolatedStringHandler.ToStringAndClear();
						}
						text = text3 + text4;
					}
					if (i != requestParameters.StopLossItems.Count - 1)
					{
						text += _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂녹();
					}
				}
			}
			if (requestParameters.TakeProfit != null)
			{
				if (!string.IsNullOrEmpty(text))
				{
					text += _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂녹();
				}
				for (int j = 0; j < requestParameters.TakeProfitItems.Count; j++)
				{
					SlTpHolder slTpHolder2 = requestParameters.TakeProfitItems[j];
					string value3 = slTpHolder2.Format(requestParameters.Symbol);
					string value4 = (flag ? (j + 1).ToString() : string.Empty);
					string value5 = (flag ? (_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸녓() + requestParameters.Symbol.FormatQuantity(slTpHolder2.Quantity)) : string.Empty);
					string text5 = text;
					string text6 = _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놀();
					string text7;
					if (slTpHolder2.PriceMeasurement != 0)
					{
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(11, 3);
						defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶녨());
						defaultInterpolatedStringHandler.AppendFormatted(value4);
						defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸농());
						defaultInterpolatedStringHandler.AppendFormatted(value3);
						defaultInterpolatedStringHandler.AppendFormatted(value5);
						text7 = defaultInterpolatedStringHandler.ToStringAndClear();
					}
					else
					{
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(11, 3);
						defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸념());
						defaultInterpolatedStringHandler.AppendFormatted(value4);
						defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸녨());
						defaultInterpolatedStringHandler.AppendFormatted(value3);
						defaultInterpolatedStringHandler.AppendFormatted(value5);
						text7 = defaultInterpolatedStringHandler.ToStringAndClear();
					}
					text = text5 + text6 + text7;
					if (j != requestParameters.TakeProfitItems.Count - 1)
					{
						text += _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂녹();
					}
				}
			}
		}
		catch (Exception ex)
		{
			Core.Instance.Loggers.Log(ex);
		}
		return text;
	}

	public string Format(string positionId = null, string groupId = null)
	{
		if (!string.IsNullOrEmpty(positionId))
		{
			string value = Behavior switch
			{
				OrderTypeBehavior.Limit => _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶녨(), 
				OrderTypeBehavior.Stop => _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶념(), 
				OrderTypeBehavior.TrailingStop => _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵뇊(), 
				_ => _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놇(), 
			};
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(7, 3);
			defaultInterpolatedStringHandler.AppendFormatted(Name);
			defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸녺());
			defaultInterpolatedStringHandler.AppendFormatted(value);
			defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸놣());
			defaultInterpolatedStringHandler.AppendFormatted(positionId);
			defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놢());
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}
		if (!string.IsNullOrEmpty(groupId))
		{
			return Name + _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸녮();
		}
		return Name;
	}

	public static string Format(IOrder order)
	{
		if (order is LocalOrder)
		{
			return order.OrderType.Name + _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸뇆();
		}
		return Format(order.OrderTypeId, order.ConnectionId, order.PositionId, order.GroupId);
	}

	public static string Format(string orderTypeId, string connectionId = null, string positionId = null, string groupId = null)
	{
		return Core.Instance.GetOrderType(orderTypeId, connectionId)?.Format(positionId, groupId) ?? orderTypeId;
	}

	public bool Equals(OrderType other)
	{
		if (other == null)
		{
			return false;
		}
		if (this == other)
		{
			return true;
		}
		if (Id == other.Id)
		{
			return base.ConnectionId == other.ConnectionId;
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
		return Equals((OrderType)obj);
	}

	public override int GetHashCode()
	{
		return HashCode.Combine(Id, base.ConnectionId);
	}

	[CompilerGenerated]
	private void 녴(Rule P_0)
	{
		놰녡.녴(P_0.Name, P_0);
	}
}
