using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Threading;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using TradingPlatform.BusinessLayer.Integration;

namespace TradingPlatform.BusinessLayer;

/// <summary>
/// Represents trading information about related position
/// </summary>
[DataContract(Name = "Position", Namespace = "TradingPlatform")]
[Published]
public class Position : TradingObject, IMessageBuilder<MessageOpenPosition>
{
	[CompilerGenerated]
	private Action<Position> 놻녗;

	[CompilerGenerated]
	private double 놻놜;

	[CompilerGenerated]
	private double 놻놨;

	[CompilerGenerated]
	private DateTime 놻녢;

	private PnLItem 놻놞;

	private PnLItem 놻놳;

	private PnLItem 놻놺;

	private PnLItem 놻놅;

	[CompilerGenerated]
	private double 놻녜;

	/// <summary>
	/// Gets position quantity value
	/// </summary>
	[DataMember(Name = "Quantity")]
	public double Quantity
	{
		[CompilerGenerated]
		get
		{
			return 놻놜;
		}
		[CompilerGenerated]
		private set
		{
			놻놜 = value;
		}
	}

	/// <summary>
	/// Gets position open order price
	/// </summary>
	[DataMember(Name = "OpenPrice")]
	public double OpenPrice
	{
		[CompilerGenerated]
		get
		{
			return 놻놨;
		}
		[CompilerGenerated]
		private set
		{
			놻놨 = value;
		}
	}

	/// <summary>
	/// Gets position openning time
	/// </summary>
	[DataMember(Name = "OpenTime")]
	public DateTime OpenTime
	{
		[CompilerGenerated]
		get
		{
			return 놻녢;
		}
		[CompilerGenerated]
		private set
		{
			놻녢 = value;
		}
	}

	/// <summary>
	/// Gets Profit/loss (without swaps or commissions) all calculated based on the current broker's price. For open position it shows the profit/loss you would make if you close the position at the current price. If position closed, this parameter show profit/loss what trader have after closing this position.
	/// </summary>
	public PnLItem GrossPnL
	{
		get
		{
			return 놻놞;
		}
		internal set
		{
			놻놞 = value;
		}
	}

	/// <summary>
	/// Gets Profit/loss calculated based on the current broker's price. For open position it shows the profit/loss you would make if you close the position at the current price. If position closed, this parameter show profit/loss what trader have after closing this position.
	/// </summary>
	public PnLItem NetPnL
	{
		get
		{
			return 놻놳;
		}
		internal set
		{
			놻놳 = value;
		}
	}

	/// <summary>
	/// Gets fee amount for the position.
	/// </summary>
	public PnLItem Fee
	{
		get
		{
			return 놻놺;
		}
		internal set
		{
			놻놺 = value;
		}
	}

	/// <summary>
	/// Gets PnL swaps
	/// </summary>
	public PnLItem Swaps
	{
		get
		{
			return 놻놅;
		}
		internal set
		{
			놻놅 = value;
		}
	}

	/// <summary>
	/// The market price obtainable from your broker.
	/// </summary>
	public double CurrentPrice => ((base.Side != 0) ? base.Symbol?.Ask : base.Symbol?.Bid) ?? double.NaN;

	public double LiquidationPrice
	{
		[CompilerGenerated]
		get
		{
			return 놻녜;
		}
		[CompilerGenerated]
		private set
		{
			놻녜 = value;
		}
	}

	/// <summary>
	/// Gets StopLoss order which belongs to the position
	/// </summary>
	public Order StopLoss => ConnectionCache.Orders.FirstOrDefault((Order P_0) => P_0.PositionId == base.Id && (P_0.OrderType.Behavior == OrderTypeBehavior.Stop || P_0.OrderType.Behavior == OrderTypeBehavior.TrailingStop) && P_0.OrderType.Usage.HasFlag(OrderTypeUsage.CloseOrder));

	/// <summary>
	/// Gets TakeProfit order which belongs to the position
	/// </summary>
	public Order TakeProfit => ConnectionCache.Orders.FirstOrDefault((Order P_0) => P_0.PositionId == base.Id && P_0.OrderType.Behavior == OrderTypeBehavior.Limit && P_0.OrderType.Usage.HasFlag(OrderTypeUsage.CloseOrder));

	/// <summary>
	/// Returns ticks amount between open and current price.
	/// </summary>
	public double GrossPnLTicks
	{
		get
		{
			if (base.Symbol == null || OpenPrice.IsNanOrDefault() || CurrentPrice.IsNanOrDefault())
			{
				return 0.0;
			}
			if (base.Side == Side.Buy)
			{
				return base.Symbol.CalculateTicks(OpenPrice, CurrentPrice);
			}
			return base.Symbol.CalculateTicks(CurrentPrice, OpenPrice);
		}
	}

	/// <summary>
	/// Will be triggered on each <see cref="M:TradingPlatform.BusinessLayer.Position.UpdateByMessage(TradingPlatform.BusinessLayer.Integration.MessageOpenPosition)" /> and <see cref="M:TradingPlatform.BusinessLayer.Position.UpdatePnl(TradingPlatform.BusinessLayer.PnL)" /> invocation
	/// </summary>
	public event Action<Position> Updated
	{
		[CompilerGenerated]
		add
		{
			Action<Position> action = 놻녗;
			Action<Position> action2;
			do
			{
				action2 = action;
				Action<Position> value2 = (Action<Position>)Delegate.Combine(action2, value);
				action = Interlocked.CompareExchange(ref 놻녗, value2, action2);
			}
			while ((object)action != action2);
		}
		[CompilerGenerated]
		remove
		{
			Action<Position> action = 놻녗;
			Action<Position> action2;
			do
			{
				action2 = action;
				Action<Position> value2 = (Action<Position>)Delegate.Remove(action2, value);
				action = Interlocked.CompareExchange(ref 놻녗, value2, action2);
			}
			while ((object)action != action2);
		}
	}

	internal Position(string P_0)
		: base(P_0)
	{
		LiquidationPrice = double.NaN;
	}

	/// <summary>
	/// Closes position if quantity is not specified else - uses partial closing operation.
	/// </summary>
	/// <param name="closeQuantity"></param>
	/// <returns></returns>
	public virtual TradingOperationResult Close(double closeQuantity = -1.0)
	{
		return Core.Instance.ClosePosition(new ClosePositionRequestParameters
		{
			Position = this,
			CloseQuantity = ((closeQuantity != -1.0) ? closeQuantity : Quantity)
		});
	}

	public void ForceRecalculatePnl()
	{
		PnL pnL = Connection.녴(new PnLRequestParameters
		{
			Symbol = base.Symbol,
			Account = base.Account,
			OpenPrice = OpenPrice,
			ClosePrice = CurrentPrice,
			Side = base.Side,
			Quantity = Quantity,
			PositionId = base.Id
		});
		if (pnL != null)
		{
			녴(pnL);
		}
	}

	public override string ToString()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(18, 6);
		defaultInterpolatedStringHandler.AppendFormatted(base.Side);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놀());
		defaultInterpolatedStringHandler.AppendFormatted(Quantity);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놀());
		defaultInterpolatedStringHandler.AppendFormatted(base.Symbol);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놄녺());
		defaultInterpolatedStringHandler.AppendFormatted(base.Symbol.FormatPrice(OpenPrice));
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸놣());
		defaultInterpolatedStringHandler.AppendFormatted(base.Account);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰놩());
		defaultInterpolatedStringHandler.AppendFormatted(base.Id);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	internal virtual void 녴(MessageOpenPosition P_0)
	{
		base.Id = P_0.PositionId;
		if (ConnectionCache != null && ConnectionCache.SymbolsCache.녴(P_0.SymbolId, out var symbol))
		{
			base.Symbol = symbol;
		}
		if (ConnectionCache != null && ConnectionCache.AccountsCache.녴(P_0.AccountId, out var account))
		{
			base.Account = account;
		}
		OpenPrice = P_0.OpenPrice;
		OpenTime = P_0.OpenTime;
		Quantity = P_0.Quantity;
		base.Side = P_0.Side;
		base.Comment = P_0.Comment;
		LiquidationPrice = P_0.LiquidationPrice;
		ProcessAdditionalItems(P_0.AdditionalInfoItems);
		놻녗?.Invoke(this);
	}

	public MessageOpenPosition BuildMessage()
	{
		return new MessageOpenPosition(base.Symbol?.Id)
		{
			PositionId = base.Id,
			AccountId = base.Account?.Id,
			OpenPrice = OpenPrice,
			OpenTime = OpenTime,
			Quantity = Quantity,
			Side = base.Side,
			Comment = base.Comment,
			LiquidationPrice = LiquidationPrice,
			AdditionalInfoItems = base.AdditionalInfo?.ToList()
		};
	}

	internal void 녴(PnL P_0)
	{
		if ((0u | (녴(ref 놻놞, P_0.GrossPnL) ? 1u : 0u) | (녴(ref 놻놳, P_0.NetPnL) ? 1u : 0u) | (녴(ref 놻놺, P_0.Fee) ? 1u : 0u) | (녴(ref 놻놅, P_0.Swaps) ? 1u : 0u)) != 0)
		{
			놻녗?.Invoke(this);
		}
	}

	private bool 녴(ref PnLItem P_0, PnLItem P_1)
	{
		if (P_1 != null)
		{
			PnLItem obj = P_0;
			if (obj == null || !obj.Equals(P_1))
			{
				P_0 = P_1;
				P_0.ConnectionId = base.ConnectionId;
				return true;
			}
		}
		return false;
	}

	[CompilerGenerated]
	private bool 녴(Order P_0)
	{
		if (P_0.PositionId == base.Id && (P_0.OrderType.Behavior == OrderTypeBehavior.Stop || P_0.OrderType.Behavior == OrderTypeBehavior.TrailingStop))
		{
			return P_0.OrderType.Usage.HasFlag(OrderTypeUsage.CloseOrder);
		}
		return false;
	}

	[CompilerGenerated]
	private bool 놴(Order P_0)
	{
		if (P_0.PositionId == base.Id && P_0.OrderType.Behavior == OrderTypeBehavior.Limit)
		{
			return P_0.OrderType.Usage.HasFlag(OrderTypeUsage.CloseOrder);
		}
		return false;
	}
}
