using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Xml.Linq;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using TradingPlatform.BusinessLayer.LocalOrders;
using TradingPlatform.BusinessLayer.Serialization;
using TradingPlatform.BusinessLayer.Utils;
using TradingPlatform.BusinessLayer.Utils.EqualityComparers;
using 녴;

namespace TradingPlatform.BusinessLayer;

[Published]
public abstract class OrderRequestParameters : TradingRequestParameters, ICloneable, IXElementSerialization, IEquatable<OrderRequestParameters>
{
	[Serializable]
	[CompilerGenerated]
	private sealed class 녴
	{
		public static readonly 녴 놻놤 = new 녴();

		public static Func<DealTicketItem, int> 놻논;

		internal int 녴(DealTicketItem P_0)
		{
			return P_0.SortIndex;
		}
	}

	private string 놵녦;

	private Symbol 놵놀;

	private string 놵놔;

	[CompilerGenerated]
	private Account 놵놾;

	[CompilerGenerated]
	private Side 놵뇀;

	[CompilerGenerated]
	private double 놵놽;

	[CompilerGenerated]
	private double 놵녿;

	[CompilerGenerated]
	private string 놵놁;

	private string 놵녭;

	private OrderType 놵녱;

	[CompilerGenerated]
	private double 놵놲;

	[CompilerGenerated]
	private double 놵높;

	[CompilerGenerated]
	private double 놵놶;

	[CompilerGenerated]
	private TimeInForce 놵뇏;

	[CompilerGenerated]
	private DateTime 놵녻;

	[CompilerGenerated]
	private int 놵녙;

	[CompilerGenerated]
	private string 놵놢;

	[CompilerGenerated]
	private List<SlTpHolder> 놵녧;

	[CompilerGenerated]
	private List<SlTpHolder> 놵녤;

	[CompilerGenerated]
	private string 놵놆;

	[CompilerGenerated]
	private string 놵뇎;

	private List<SettingItem> 놵놷;

	private readonly LocalOrder 놵녗;

	private static readonly ListEqualityComparer<SlTpHolder> 놵놜 = new ListEqualityComparer<SlTpHolder>(EqualityComparer<SlTpHolder>.Default);

	private static readonly ListEqualityComparer<SettingItem> 놵놨 = new ListEqualityComparer<SettingItem>(EqualityComparer<SettingItem>.Default);

	public override string ConnectionId => Symbol?.ConnectionId;

	public string SymbolId
	{
		get
		{
			return Symbol?.Id ?? 놵녦;
		}
		set
		{
			놵녦 = value;
		}
	}

	public Symbol Symbol
	{
		get
		{
			return 놵놀;
		}
		set
		{
			놵놀 = value;
			놵녱 = null;
		}
	}

	public string AccountId
	{
		get
		{
			return Account?.Id ?? 놵놔;
		}
		set
		{
			놵놔 = value;
		}
	}

	public Account Account
	{
		[CompilerGenerated]
		get
		{
			return 놵놾;
		}
		[CompilerGenerated]
		set
		{
			놵놾 = value;
		}
	}

	public Side Side
	{
		[CompilerGenerated]
		get
		{
			return 놵뇀;
		}
		[CompilerGenerated]
		set
		{
			놵뇀 = value;
		}
	}

	public double Quantity
	{
		[CompilerGenerated]
		get
		{
			return 놵놽;
		}
		[CompilerGenerated]
		set
		{
			놵놽 = value;
		}
	}

	public double Total
	{
		[CompilerGenerated]
		get
		{
			return 놵녿;
		}
		[CompilerGenerated]
		set
		{
			놵녿 = value;
		}
	}

	public string QuantityDefinitionSettingName
	{
		[CompilerGenerated]
		get
		{
			return 놵놁;
		}
		[CompilerGenerated]
		set
		{
			놵놁 = value;
		}
	}

	public string OrderTypeId
	{
		get
		{
			return 놵녭;
		}
		set
		{
			놵녭 = value;
			놵녱 = null;
		}
	}

	public OrderType OrderType
	{
		get
		{
			if (놵녗 != null)
			{
				return 놵녗.OrderType;
			}
			if (놵녱 == null && Symbol != null && !string.IsNullOrEmpty(OrderTypeId))
			{
				놵녱 = Symbol.GetAlowedOrderTypes(null)?.FirstOrDefault((OrderType P_0) => P_0.Id == OrderTypeId);
			}
			return 놵녱;
		}
	}

	public double Price
	{
		[CompilerGenerated]
		get
		{
			return 놵놲;
		}
		[CompilerGenerated]
		set
		{
			놵놲 = value;
		}
	}

	public double TriggerPrice
	{
		[CompilerGenerated]
		get
		{
			return 놵높;
		}
		[CompilerGenerated]
		set
		{
			놵높 = value;
		}
	}

	public double TrailOffset
	{
		[CompilerGenerated]
		get
		{
			return 놵놶;
		}
		[CompilerGenerated]
		set
		{
			놵놶 = value;
		}
	}

	public TimeInForce TimeInForce
	{
		[CompilerGenerated]
		get
		{
			return 놵뇏;
		}
		[CompilerGenerated]
		set
		{
			놵뇏 = value;
		}
	}

	public DateTime ExpirationTime
	{
		[CompilerGenerated]
		get
		{
			return 놵녻;
		}
		[CompilerGenerated]
		set
		{
			놵녻 = value;
		}
	}

	public int Slippage
	{
		[CompilerGenerated]
		get
		{
			return 놵녙;
		}
		[CompilerGenerated]
		set
		{
			놵녙 = value;
		}
	}

	public string PositionId
	{
		[CompilerGenerated]
		get
		{
			return 놵놢;
		}
		[CompilerGenerated]
		set
		{
			놵놢 = value;
		}
	}

	public SlTpHolder StopLoss
	{
		get
		{
			return StopLossItems.FirstOrDefault();
		}
		set
		{
			StopLossItems.Clear();
			if (value != null)
			{
				StopLossItems.Add(value);
			}
		}
	}

	public SlTpHolder TakeProfit
	{
		get
		{
			return TakeProfitItems.FirstOrDefault();
		}
		set
		{
			TakeProfitItems.Clear();
			if (value != null)
			{
				TakeProfitItems.Add(value);
			}
		}
	}

	public List<SlTpHolder> StopLossItems
	{
		[CompilerGenerated]
		get
		{
			return 놵녧;
		}
		[CompilerGenerated]
		private set
		{
			놵녧 = value;
		}
	}

	public List<SlTpHolder> TakeProfitItems
	{
		[CompilerGenerated]
		get
		{
			return 놵녤;
		}
		[CompilerGenerated]
		private set
		{
			놵녤 = value;
		}
	}

	public string GroupId
	{
		[CompilerGenerated]
		get
		{
			return 놵놆;
		}
		[CompilerGenerated]
		set
		{
			놵놆 = value;
		}
	}

	public string Comment
	{
		[CompilerGenerated]
		get
		{
			return 놵뇎;
		}
		[CompilerGenerated]
		set
		{
			놵뇎 = value;
		}
	}

	public IList<SettingItem> AdditionalParameters
	{
		get
		{
			List<SettingItem> list = new List<SettingItem>(놵놷);
			if (TimeInForce != 0)
			{
				list.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸놥(), (int)TimeInForce, force: true);
			}
			if (ExpirationTime != default(DateTime))
			{
				list.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸녾(), ExpirationTime, force: true);
			}
			list.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇋뇊(), (int)Side, force: true);
			if (!double.IsNaN(Quantity))
			{
				list.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶녯(), Quantity, force: true);
			}
			if (!double.IsNaN(Total))
			{
				list.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸놜(), Total, force: true);
			}
			if (!double.IsNaN(Price))
			{
				list.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶녰(), Price, force: true);
			}
			if (!double.IsNaN(TriggerPrice))
			{
				list.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇋녘(), TriggerPrice, force: true);
			}
			if (!double.IsNaN(TrailOffset))
			{
				list.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇋노(), (int)TrailOffset, force: true);
			}
			if (!string.IsNullOrEmpty(Comment))
			{
				list.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇋놋(), Comment, force: true);
			}
			return list;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂뇄());
			}
			놵놷.Clear();
			foreach (SettingItem item in value)
			{
				string name = item.Name;
				if (name != null)
				{
					switch (name.Length)
					{
					case 5:
						switch (name[0])
						{
						case 'T':
							if (name == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸놜())
							{
								Total = (double)item.Value;
							}
							break;
						case 'P':
							if (name == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶녰())
							{
								Price = (double)item.Value;
							}
							break;
						}
						break;
					case 13:
						if (name == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸놥() && item.Value is SelectItem selectItem)
						{
							TimeInForce = (TimeInForce)(object)selectItem.Value;
						}
						break;
					case 10:
						if (name == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸녾())
						{
							ExpirationTime = (DateTime)item.Value;
						}
						break;
					case 4:
						if (name == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇋뇊() && item.Value is SelectItem selectItem2)
						{
							Side = (Side)(object)selectItem2.Value;
						}
						break;
					case 8:
						if (name == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶녯())
						{
							Quantity = (double)item.Value;
						}
						break;
					case 12:
						if (name == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇋녘())
						{
							TriggerPrice = (double)item.Value;
						}
						break;
					case 11:
						if (name == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇋노())
						{
							TrailOffset = (int)item.Value;
						}
						break;
					case 7:
						if (name == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇋놋())
						{
							Comment = item.Value?.ToString();
						}
						break;
					}
				}
				놵놷.Add(item.GetCopy());
			}
		}
	}

	public override string Message
	{
		get
		{
			IOrderedEnumerable<DealTicketItem> orderedEnumerable = OrderType?.GetDealTicketItems(this)?.OrderBy((DealTicketItem P_0) => P_0.SortIndex);
			if (orderedEnumerable == null)
			{
				return string.Empty;
			}
			StringBuilder stringBuilder = new StringBuilder();
			StringBuilder stringBuilder2;
			StringBuilder.AppendInterpolatedStringHandler handler;
			foreach (DealTicketItem item in orderedEnumerable)
			{
				stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder3 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(4, 2, stringBuilder2);
				handler.AppendFormatted(item.Key);
				handler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇋녯());
				handler.AppendFormatted(item.FormattedValue);
				handler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴());
				stringBuilder3.Append(ref handler);
			}
			stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder4 = stringBuilder2;
			handler = new StringBuilder.AppendInterpolatedStringHandler(13, 1, stringBuilder2);
			handler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놄녵());
			handler.AppendFormatted(base.RequestId);
			handler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴());
			stringBuilder4.Append(ref handler);
			return stringBuilder.ToString();
		}
	}

	protected OrderRequestParameters()
	{
		녴();
	}

	protected OrderRequestParameters(IOrder order)
		: this()
	{
		Symbol = order.Symbol;
		Account = order.Account;
		Side = order.Side;
		Quantity = order.TotalQuantity;
		OrderTypeId = order.OrderTypeId;
		놵녗 = order as LocalOrder;
		Price = order.Price;
		TriggerPrice = order.TriggerPrice;
		TrailOffset = order.TrailOffset;
		TimeInForce = order.TimeInForce;
		ExpirationTime = order.ExpirationTime;
		PositionId = order.PositionId;
		GroupId = order.GroupId;
		Comment = order.Comment;
		SlTpHolder[] stopLossItems = order.StopLossItems;
		foreach (SlTpHolder slTpHolder in stopLossItems)
		{
			StopLossItems.Add(slTpHolder.Clone() as SlTpHolder);
		}
		stopLossItems = order.TakeProfitItems;
		foreach (SlTpHolder slTpHolder2 in stopLossItems)
		{
			TakeProfitItems.Add(slTpHolder2.Clone() as SlTpHolder);
		}
		try
		{
			if (OrderType == null)
			{
				return;
			}
			IList<SettingItem> orderSettings = OrderType.GetOrderSettings(this, new FormatSettings
			{
				DisplayQuantityInLots = true
			});
			orderSettings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸놥(), (int)TimeInForce);
			orderSettings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸녾(), ExpirationTime);
			orderSettings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇋뇊(), (int)Side);
			orderSettings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶녯(), Quantity);
			orderSettings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶녰(), Price);
			orderSettings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇋녘(), TriggerPrice);
			if (!double.IsNaN(TrailOffset))
			{
				orderSettings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇋노(), (int)TrailOffset);
			}
			orderSettings.UpdateItemValue(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇋놋(), Comment);
			if (order.AdditionalInfo != null)
			{
				foreach (AdditionalInfoItem item in order.AdditionalInfo)
				{
					orderSettings.UpdateItemValue(item.Id, item.Value);
				}
			}
			AdditionalParameters = orderSettings;
		}
		catch (Exception ex)
		{
			Core.Instance.Loggers.Log(ex);
		}
	}

	protected OrderRequestParameters(OrderRequestParameters origin)
		: base(origin)
	{
		녴();
		UpdateFrom(origin);
	}

	private void 녴()
	{
		놵놷 = new List<SettingItem>();
		Price = double.NaN;
		TriggerPrice = double.NaN;
		TrailOffset = double.NaN;
		StopLossItems = new List<SlTpHolder>();
		TakeProfitItems = new List<SlTpHolder>();
	}

	protected override Account GetAccount()
	{
		return Account;
	}

	public abstract object Clone();

	public void UpdateFrom(OrderRequestParameters origin)
	{
		if (origin == null)
		{
			return;
		}
		Symbol = origin.Symbol;
		Account = origin.Account;
		Side = origin.Side;
		Quantity = origin.Quantity;
		Total = origin.Total;
		OrderTypeId = origin.OrderTypeId;
		Price = origin.Price;
		TriggerPrice = origin.TriggerPrice;
		TrailOffset = origin.TrailOffset;
		TimeInForce = origin.TimeInForce;
		ExpirationTime = origin.ExpirationTime;
		Slippage = origin.Slippage;
		PositionId = origin.PositionId;
		GroupId = origin.GroupId;
		Comment = origin.Comment;
		AdditionalParameters = origin.AdditionalParameters;
		base.SendingSource = origin.SendingSource;
		QuantityDefinitionSettingName = origin.QuantityDefinitionSettingName;
		base.CancellationToken = origin.CancellationToken;
		foreach (SlTpHolder stopLossItem in origin.StopLossItems)
		{
			StopLossItems.Add(stopLossItem.Clone() as SlTpHolder);
		}
		foreach (SlTpHolder takeProfitItem in origin.TakeProfitItems)
		{
			TakeProfitItems.Add(takeProfitItem.Clone() as SlTpHolder);
		}
	}

	public void ApplyValuesFrom(OrderRequestParameters other)
	{
		if (other != null)
		{
			if (other.Symbol != null)
			{
				Symbol = other.Symbol;
			}
			if (other.Account != null)
			{
				Account = other.Account;
			}
			if (!string.IsNullOrEmpty(other.OrderTypeId))
			{
				OrderTypeId = other.OrderTypeId;
			}
			if (other.Slippage != 0)
			{
				Slippage = other.Slippage;
			}
			if (!string.IsNullOrEmpty(other.PositionId))
			{
				PositionId = other.PositionId;
			}
			if (!string.IsNullOrEmpty(other.GroupId))
			{
				GroupId = other.GroupId;
			}
			if (!string.IsNullOrEmpty(other.SendingSource))
			{
				base.SendingSource = other.SendingSource;
			}
			if (!string.IsNullOrEmpty(other.QuantityDefinitionSettingName))
			{
				QuantityDefinitionSettingName = other.QuantityDefinitionSettingName;
			}
			if (other.CancellationToken != CancellationToken.None)
			{
				base.CancellationToken = other.CancellationToken;
			}
			if (other.StopLossItems.Any())
			{
				StopLossItems = other.StopLossItems;
			}
			if (other.TakeProfitItems.Any())
			{
				TakeProfitItems = other.TakeProfitItems;
			}
			IList<SettingItem> additionalParameters = AdditionalParameters;
			IList<SettingItem> additionalParameters2 = other.AdditionalParameters;
			additionalParameters.MergeWith(additionalParameters2);
			AdditionalParameters = additionalParameters;
		}
	}

	public override string ToString()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(6, 7);
		defaultInterpolatedStringHandler.AppendFormatted(base.ToString());
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놀());
		defaultInterpolatedStringHandler.AppendFormatted(Side);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놀());
		defaultInterpolatedStringHandler.AppendFormatted(OrderTypeId);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놀());
		defaultInterpolatedStringHandler.AppendFormatted(Quantity);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놀());
		defaultInterpolatedStringHandler.AppendFormatted(Symbol);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놀());
		defaultInterpolatedStringHandler.AppendFormatted(Account);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놀());
		defaultInterpolatedStringHandler.AppendFormatted(OrderType?.GetFillPrice(this));
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	public XElement ToXElement()
	{
		XElement xElement = new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놄놄());
		if (Symbol != null)
		{
			xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶놅(), Symbol.CreateInfo().ToXElement()));
		}
		if (Account != null)
		{
			xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶녹(), Account.CreateInfo().ToXElement()));
		}
		xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇋뇊(), ((int)Side).ToString()));
		xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶녯(), Quantity));
		xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸놜(), Total));
		xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놄놰(), QuantityDefinitionSettingName));
		xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇋녩(), OrderTypeId));
		xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶녰(), Price));
		xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇋녘(), TriggerPrice));
		xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇋노(), TrailOffset));
		xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇋놤(), ((int)TimeInForce).ToString()));
		xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇋논(), ExpirationTime));
		xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놄놓(), Slippage));
		xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇋놪(), PositionId));
		if (StopLossItems.Count > 0)
		{
			XElement xElement2 = new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놄놇());
			foreach (SlTpHolder stopLossItem in StopLossItems)
			{
				xElement2.Add(stopLossItem.ToXElement());
			}
			xElement.Add(xElement2);
		}
		if (TakeProfitItems.Count > 0)
		{
			XElement xElement3 = new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놄뇅());
			foreach (SlTpHolder takeProfitItem in TakeProfitItems)
			{
				xElement3.Add(takeProfitItem.ToXElement());
			}
			xElement.Add(xElement3);
		}
		xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇋놊(), GroupId));
		xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇋놋(), Comment));
		if (AdditionalParameters != null)
		{
			XElement xElement4 = new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놄놵());
			foreach (SettingItem additionalParameter in AdditionalParameters)
			{
				xElement4.Add(additionalParameter.ToXElement());
			}
			xElement.Add(xElement4);
		}
		return xElement;
	}

	public void FromXElement(XElement element, DeserializationInfo deserializationInfo)
	{
		XElement xElement = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놄놄());
		if (xElement == null)
		{
			return;
		}
		XElement xElement2 = xElement.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶놅());
		if (xElement2 != null)
		{
			XElement xElement3 = xElement2.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶녬());
			if (xElement3 != null)
			{
				SymbolInfo symbolInfo = new SymbolInfo();
				symbolInfo.FromXElement(xElement3, deserializationInfo);
				Symbol = Core.Instance.GetSymbol(symbolInfo);
			}
		}
		XElement xElement4 = xElement.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶녹());
		if (xElement4 != null)
		{
			XElement xElement5 = xElement4.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶녬());
			if (xElement5 != null)
			{
				놅 놅 = new 놅();
				놅.FromXElement(xElement5, deserializationInfo);
				Account = Core.Instance.GetAccount(놅);
			}
		}
		XElement xElement6 = xElement.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇋뇊());
		if (xElement6 != null)
		{
			Side = (Side)xElement6.ToInt();
		}
		XElement xElement7 = xElement.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶녯());
		if (xElement7 != null)
		{
			Quantity = xElement7.ToDouble();
		}
		XElement xElement8 = xElement.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸놜());
		if (xElement8 != null)
		{
			Total = xElement8.ToDouble();
		}
		XElement xElement9 = xElement.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놄놰());
		if (xElement9 != null)
		{
			QuantityDefinitionSettingName = xElement9.ToString();
		}
		XElement xElement10 = xElement.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇋녩());
		if (xElement10 != null)
		{
			OrderTypeId = xElement10.Value;
		}
		XElement xElement11 = xElement.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶녰());
		if (xElement11 != null)
		{
			Price = xElement11.ToDouble();
		}
		XElement xElement12 = xElement.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇋녘());
		if (xElement12 != null)
		{
			TriggerPrice = xElement12.ToDouble();
		}
		XElement xElement13 = xElement.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇋노());
		if (xElement13 != null)
		{
			TrailOffset = xElement13.ToDouble();
		}
		XElement xElement14 = xElement.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇋놤());
		if (xElement14 != null)
		{
			TimeInForce = (TimeInForce)xElement14.ToInt();
		}
		XElement xElement15 = xElement.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇋논());
		if (xElement15 != null)
		{
			ExpirationTime = xElement15.ToDateTime();
		}
		XElement xElement16 = xElement.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놄놓());
		if (xElement16 != null)
		{
			Slippage = xElement16.ToInt();
		}
		XElement xElement17 = xElement.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇋놪());
		if (xElement17 != null)
		{
			PositionId = xElement17.Value;
		}
		XElement xElement18 = xElement.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놄놇());
		if (xElement18 != null)
		{
			foreach (XElement item2 in xElement18.Elements())
			{
				SlTpHolder slTpHolder = new SlTpHolder();
				slTpHolder.FromXElement(item2, deserializationInfo);
				StopLossItems.Add(slTpHolder);
			}
		}
		XElement xElement19 = xElement.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놄뇅());
		if (xElement19 != null)
		{
			foreach (XElement item3 in xElement19.Elements())
			{
				SlTpHolder slTpHolder2 = new SlTpHolder();
				slTpHolder2.FromXElement(item3, deserializationInfo);
				TakeProfitItems.Add(slTpHolder2);
			}
		}
		XElement xElement20 = xElement.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놄놵());
		if (xElement20 == null)
		{
			return;
		}
		List<SettingItem> list = new List<SettingItem>();
		foreach (XElement item4 in xElement20.Elements())
		{
			if (Serializer.DeserializeNode(item4, deserializationInfo) is SettingItem item)
			{
				list.Add(item);
			}
		}
		AdditionalParameters = list;
	}

	public bool Equals(OrderRequestParameters other)
	{
		if (other == null)
		{
			return false;
		}
		if (this == other)
		{
			return true;
		}
		if (놵녭 == other.놵녭 && object.Equals(놵녗, other.놵녗) && object.Equals(Account, other.Account) && Side == other.Side && Quantity.Equals(other.Quantity) && Total.Equals(other.Total) && QuantityDefinitionSettingName == other.QuantityDefinitionSettingName && Price.Equals(other.Price) && TriggerPrice.Equals(other.TriggerPrice) && TrailOffset.Equals(other.TrailOffset) && TimeInForce == other.TimeInForce && ExpirationTime.Equals(other.ExpirationTime) && Slippage == other.Slippage && PositionId == other.PositionId && GroupId == other.GroupId && Comment == other.Comment && 놵놜.Equals(StopLossItems, other.StopLossItems) && 놵놜.Equals(TakeProfitItems, other.TakeProfitItems))
		{
			return 놵놨.Equals(놵놷, other.놵놷);
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
		return Equals((OrderRequestParameters)obj);
	}

	public override int GetHashCode()
	{
		HashCode hashCode = default(HashCode);
		hashCode.Add(놵녭);
		hashCode.Add(놵놷);
		hashCode.Add(놵녗);
		hashCode.Add(Account);
		hashCode.Add((int)Side);
		hashCode.Add(Quantity);
		hashCode.Add(Total);
		hashCode.Add(QuantityDefinitionSettingName);
		hashCode.Add(Price);
		hashCode.Add(TriggerPrice);
		hashCode.Add(TrailOffset);
		hashCode.Add((int)TimeInForce);
		hashCode.Add(ExpirationTime);
		hashCode.Add(Slippage);
		hashCode.Add(PositionId);
		hashCode.Add(StopLossItems);
		hashCode.Add(TakeProfitItems);
		hashCode.Add(GroupId);
		hashCode.Add(Comment);
		return hashCode.ToHashCode();
	}

	[CompilerGenerated]
	private bool 녴(OrderType P_0)
	{
		return P_0.Id == OrderTypeId;
	}
}
