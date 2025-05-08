using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using TradingPlatform.BusinessLayer.Integration;

namespace TradingPlatform.BusinessLayer;

/// <summary>
/// Represents trading information about pending order
/// </summary>
[DataContract(Name = "Order", Namespace = "TradingPlatform")]
[Published]
public class Order : TradingObject, IMessageBuilder<MessageOpenOrder>, IOrder, ITradingObject, IUniqueID, IEquatable<Order>
{
	[CompilerGenerated]
	private string 놻놃;

	[CompilerGenerated]
	private string 놻뇇;

	[CompilerGenerated]
	private double 놻놛;

	[CompilerGenerated]
	private double 놻놼;

	[CompilerGenerated]
	private string 놻놗;

	[CompilerGenerated]
	private double 놻뇂;

	[CompilerGenerated]
	private double 놻놩;

	[CompilerGenerated]
	private double 놻녡;

	[CompilerGenerated]
	private OrderStatus 놻녦;

	[CompilerGenerated]
	private string 놻놀;

	[CompilerGenerated]
	private TimeInForce 놻놔;

	[CompilerGenerated]
	private DateTime 놻놾;

	[CompilerGenerated]
	private DateTime 놻뇀;

	[CompilerGenerated]
	private double 놻놽;

	[CompilerGenerated]
	private SlTpHolder[] 놻녿;

	[CompilerGenerated]
	private SlTpHolder[] 놻놁;

	[CompilerGenerated]
	private Action<IOrder> 놻녭;

	/// <summary>
	/// The ID of the order group. This group created when trades done by the MAM account.
	/// </summary>
	[DataMember(Name = "GroupId")]
	public string GroupId
	{
		[CompilerGenerated]
		get
		{
			return 놻놃;
		}
		[CompilerGenerated]
		private set
		{
			놻놃 = value;
		}
	}

	/// <summary>
	/// Gets Position Id.
	/// </summary>
	[DataMember(Name = "PositionId")]
	public string PositionId
	{
		[CompilerGenerated]
		get
		{
			return 놻뇇;
		}
		[CompilerGenerated]
		private set
		{
			놻뇇 = value;
		}
	}

	/// <summary>
	/// Total quantity of the order
	/// </summary>
	[DataMember(Name = "TotalQuantity")]
	public double TotalQuantity
	{
		[CompilerGenerated]
		get
		{
			return 놻놛;
		}
		[CompilerGenerated]
		private set
		{
			놻놛 = value;
		}
	}

	/// <summary>
	/// Filled quantity of the order
	/// </summary>
	[DataMember(Name = "FilledQuantity")]
	public double FilledQuantity
	{
		[CompilerGenerated]
		get
		{
			return 놻놼;
		}
		[CompilerGenerated]
		private set
		{
			놻놼 = value;
		}
	}

	/// <summary>
	/// Remaining quantity of the order
	/// </summary>
	public double RemainingQuantity => TotalQuantity - FilledQuantity;

	/// <summary>
	/// Orders Type Id. It is used for the orders type comparing.
	/// </summary>
	[DataMember(Name = "OrderTypeId")]
	public string OrderTypeId
	{
		[CompilerGenerated]
		get
		{
			return 놻놗;
		}
		[CompilerGenerated]
		private set
		{
			놻놗 = value;
		}
	}

	/// <summary>
	/// Gets OrderType
	/// </summary>
	public OrderType OrderType => ConnectionCache.OrderTypes.FirstOrDefault((OrderType P_0) => P_0.Id == OrderTypeId);

	/// <summary>
	/// Gets order price value
	/// </summary>
	[DataMember(Name = "Price")]
	public double Price
	{
		[CompilerGenerated]
		get
		{
			return 놻뇂;
		}
		[CompilerGenerated]
		private set
		{
			놻뇂 = value;
		}
	}

	/// <summary>
	/// Gets order trigger price value
	/// </summary>
	[DataMember(Name = "TriggerPrice")]
	public double TriggerPrice
	{
		[CompilerGenerated]
		get
		{
			return 놻놩;
		}
		[CompilerGenerated]
		private set
		{
			놻놩 = value;
		}
	}

	/// <summary>
	/// Gets order trailing offset value
	/// </summary>
	[DataMember(Name = "TrailOffset")]
	public double TrailOffset
	{
		[CompilerGenerated]
		get
		{
			return 놻녡;
		}
		[CompilerGenerated]
		private set
		{
			놻녡 = value;
		}
	}

	/// <summary>
	/// Gets orders current status
	/// </summary>
	[DataMember(Name = "Status")]
	public OrderStatus Status
	{
		[CompilerGenerated]
		get
		{
			return 놻녦;
		}
		[CompilerGenerated]
		internal set
		{
			놻녦 = value;
		}
	}

	/// <summary>
	/// Gets open order original status
	/// </summary>
	[DataMember(Name = "OriginalStatus")]
	public string OriginalStatus
	{
		[CompilerGenerated]
		get
		{
			return 놻놀;
		}
		[CompilerGenerated]
		private set
		{
			놻놀 = value;
		}
	}

	/// <summary>
	/// Gets order TIF(Time-In-Force) type
	/// </summary>
	[DataMember(Name = "Tif")]
	public TimeInForce TimeInForce
	{
		[CompilerGenerated]
		get
		{
			return 놻놔;
		}
		[CompilerGenerated]
		private set
		{
			놻놔 = value;
		}
	}

	/// <summary>
	/// Gets orders expiration time
	/// </summary>
	[DataMember(Name = "ExpirationTime")]
	public DateTime ExpirationTime
	{
		[CompilerGenerated]
		get
		{
			return 놻놾;
		}
		[CompilerGenerated]
		private set
		{
			놻놾 = value;
		}
	}

	/// <summary>
	/// Gets orders last update time
	/// </summary>
	public DateTime LastUpdateTime
	{
		[CompilerGenerated]
		get
		{
			return 놻뇀;
		}
		[CompilerGenerated]
		private set
		{
			놻뇀 = value;
		}
	}

	public double AverageFillPrice
	{
		[CompilerGenerated]
		get
		{
			return 놻놽;
		}
		[CompilerGenerated]
		private set
		{
			놻놽 = value;
		}
	}

	/// <summary>
	/// Gets StopLoss holder for given order
	/// </summary>
	public SlTpHolder StopLoss => StopLossItems.FirstOrDefault();

	/// <summary>
	/// Gets TakeProfit holder for given order
	/// </summary>
	public SlTpHolder TakeProfit => TakeProfitItems.FirstOrDefault();

	public SlTpHolder[] StopLossItems
	{
		[CompilerGenerated]
		get
		{
			return 놻녿;
		}
		[CompilerGenerated]
		private set
		{
			놻녿 = value;
		}
	}

	public SlTpHolder[] TakeProfitItems
	{
		[CompilerGenerated]
		get
		{
			return 놻놁;
		}
		[CompilerGenerated]
		private set
		{
			놻놁 = value;
		}
	}

	/// <summary>
	/// Will be triggered on each <see cref="M:TradingPlatform.BusinessLayer.Order.UpdateByMessage(TradingPlatform.BusinessLayer.Integration.MessageOpenOrder)" /> invocation
	/// </summary>
	public event Action<IOrder> Updated
	{
		[CompilerGenerated]
		add
		{
			Action<IOrder> action = 놻녭;
			Action<IOrder> action2;
			do
			{
				action2 = action;
				Action<IOrder> value2 = (Action<IOrder>)Delegate.Combine(action2, value);
				action = Interlocked.CompareExchange(ref 놻녭, value2, action2);
			}
			while ((object)action != action2);
		}
		[CompilerGenerated]
		remove
		{
			Action<IOrder> action = 놻녭;
			Action<IOrder> action2;
			do
			{
				action2 = action;
				Action<IOrder> value2 = (Action<IOrder>)Delegate.Remove(action2, value);
				action = Interlocked.CompareExchange(ref 놻녭, value2, action2);
			}
			while ((object)action != action2);
		}
	}

	/// <summary>
	/// Creates Order instance
	/// </summary>
	/// <param name="connectionId"></param>
	internal Order(string P_0)
		: base(P_0)
	{
		StopLossItems = new SlTpHolder[0];
		TakeProfitItems = new SlTpHolder[0];
	}

	internal void 녴(MessageOpenOrder P_0)
	{
		base.Id = P_0.OrderId;
		GroupId = P_0.GroupId;
		PositionId = P_0.PositionId;
		LastUpdateTime = P_0.LastUpdateTime;
		if (ConnectionCache != null && ConnectionCache.SymbolsCache.녴(P_0.SymbolId, out var symbol))
		{
			base.Symbol = symbol;
		}
		else if (!string.IsNullOrEmpty(P_0.SymbolId))
		{
			base.Symbol = new Symbol(new BusinessObjectInfo
			{
				Id = P_0.SymbolId,
				Name = P_0.SymbolId
			});
		}
		if (!string.IsNullOrEmpty(P_0.AccountId) && ConnectionCache != null && ConnectionCache.AccountsCache.녴(P_0.AccountId, out var account))
		{
			base.Account = account;
		}
		TotalQuantity = P_0.TotalQuantity;
		FilledQuantity = P_0.FilledQuantity;
		base.Side = P_0.Side;
		OrderTypeId = P_0.OrderTypeId;
		Price = P_0.Price;
		TriggerPrice = P_0.TriggerPrice;
		TrailOffset = P_0.TrailOffset;
		TimeInForce = P_0.TimeInForce;
		ExpirationTime = P_0.ExpirationTime;
		Status = P_0.Status;
		OriginalStatus = P_0.OriginalStatus;
		AverageFillPrice = P_0.AverageFillPrice;
		StopLossItems = P_0.StopLossItems.ToArray();
		TakeProfitItems = P_0.TakeProfitItems.ToArray();
		base.Comment = P_0.Comment;
		ProcessAdditionalItems(P_0.AdditionalInfoItems);
		놻녭?.Invoke(this);
	}

	public MessageOpenOrder BuildMessage()
	{
		MessageOpenOrder messageOpenOrder = new MessageOpenOrder(base.Symbol?.Id);
		messageOpenOrder.OrderId = base.Id;
		messageOpenOrder.GroupId = GroupId;
		messageOpenOrder.PositionId = PositionId;
		messageOpenOrder.LastUpdateTime = LastUpdateTime;
		messageOpenOrder.AccountId = base.Account?.Id;
		messageOpenOrder.TotalQuantity = TotalQuantity;
		messageOpenOrder.FilledQuantity = FilledQuantity;
		messageOpenOrder.Side = base.Side;
		messageOpenOrder.OrderTypeId = OrderTypeId;
		messageOpenOrder.Price = Price;
		messageOpenOrder.TriggerPrice = TriggerPrice;
		messageOpenOrder.TrailOffset = TrailOffset;
		messageOpenOrder.TimeInForce = TimeInForce;
		messageOpenOrder.ExpirationTime = ExpirationTime;
		messageOpenOrder.Status = Status;
		messageOpenOrder.OriginalStatus = OriginalStatus;
		messageOpenOrder.Comment = base.Comment;
		messageOpenOrder.AdditionalInfoItems = base.AdditionalInfo?.ToList();
		messageOpenOrder.StopLossItems.AddRange(StopLossItems);
		messageOpenOrder.TakeProfitItems.AddRange(TakeProfitItems);
		return messageOpenOrder;
	}

	/// <summary>
	/// Cancels pending order
	/// </summary>
	/// <returns></returns>
	public TradingOperationResult Cancel(string sendingSource = null)
	{
		return Core.Instance.CancelOrder(new CancelOrderRequestParameters
		{
			Order = this,
			SendingSource = sendingSource
		});
	}

	public override string ToString()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(46, 12);
		defaultInterpolatedStringHandler.AppendFormatted(base.Id);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂녹());
		defaultInterpolatedStringHandler.AppendFormatted(base.Symbol);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂녹());
		defaultInterpolatedStringHandler.AppendFormatted(base.Account);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂녹());
		defaultInterpolatedStringHandler.AppendFormatted(base.Side);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂녹());
		defaultInterpolatedStringHandler.AppendFormatted(OrderType?.Name);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂녹());
		defaultInterpolatedStringHandler.AppendFormatted(FilledQuantity);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶녢());
		defaultInterpolatedStringHandler.AppendFormatted(TotalQuantity);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂녹());
		defaultInterpolatedStringHandler.AppendFormatted(녴());
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂녹());
		defaultInterpolatedStringHandler.AppendFormatted(Status);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂녹());
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놄논());
		defaultInterpolatedStringHandler.AppendFormatted(PositionId);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놄녘());
		defaultInterpolatedStringHandler.AppendFormatted(GroupId);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놄노());
		defaultInterpolatedStringHandler.AppendFormatted(base.Comment);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	private string 녴()
	{
		StringBuilder stringBuilder = new StringBuilder();
		if (!double.IsNaN(Price))
		{
			StringBuilder stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder3 = stringBuilder2;
			StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(5, 1, stringBuilder2);
			handler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놄녒());
			handler.AppendFormatted(base.Symbol?.FormatPrice(Price) ?? Price.FormatPriceWithMaxPrecision());
			stringBuilder3.Append(ref handler);
		}
		if (!double.IsNaN(TriggerPrice))
		{
			StringBuilder stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder4 = stringBuilder2;
			StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(8, 1, stringBuilder2);
			handler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놄녕());
			handler.AppendFormatted(base.Symbol?.FormatPrice(TriggerPrice) ?? TriggerPrice.FormatPriceWithMaxPrecision());
			stringBuilder4.Append(ref handler);
		}
		if (!double.IsNaN(TrailOffset))
		{
			StringBuilder stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder5 = stringBuilder2;
			StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(12, 1, stringBuilder2);
			handler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놄녖());
			handler.AppendFormatted(base.Symbol?.FormatOffset(TrailOffset, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놎놊()) ?? TrailOffset.FormatPriceWithMaxPrecision());
			stringBuilder5.Append(ref handler);
		}
		return stringBuilder.ToString();
	}

	public bool Equals(Order other)
	{
		if (other == null)
		{
			return false;
		}
		if (this == other)
		{
			return true;
		}
		if (base.ConnectionId == other.ConnectionId)
		{
			return base.Id == other.Id;
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
		return Equals((Order)obj);
	}

	public override int GetHashCode()
	{
		return HashCode.Combine(base.ConnectionId, base.Id);
	}

	[CompilerGenerated]
	private bool 녴(OrderType P_0)
	{
		return P_0.Id == OrderTypeId;
	}
}
