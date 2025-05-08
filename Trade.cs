using System;
using System.Runtime.CompilerServices;
using System.Threading;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using TradingPlatform.BusinessLayer.Integration;

namespace TradingPlatform.BusinessLayer;

/// <summary>
/// Represents information about trade.
/// </summary>
[Published]
public class Trade : TradingObject, IMessageBuilder<MessageTrade>
{
	[CompilerGenerated]
	private string 놻녹;

	[CompilerGenerated]
	private string 놻녔;

	[CompilerGenerated]
	private double 놻녠;

	[CompilerGenerated]
	private double 놻놠;

	[CompilerGenerated]
	private DateTime 놻놟;

	[CompilerGenerated]
	private PnLItem 놻녓;

	[CompilerGenerated]
	private PnLItem 놻녛;

	[CompilerGenerated]
	private PnLItem 놻녽;

	[CompilerGenerated]
	private string 놻놏;

	[CompilerGenerated]
	private PositionImpactType 놻녥;

	[CompilerGenerated]
	private Action 놻농;

	/// <summary>
	/// Gets the unique identifier of the order initiating the trade.
	/// </summary>
	public string OrderId
	{
		[CompilerGenerated]
		get
		{
			return 놻녹;
		}
		[CompilerGenerated]
		private set
		{
			놻녹 = value;
		}
	}

	/// <summary>
	/// Gets a unique identifier of the position, which is related to this trade.
	/// </summary>
	public string PositionId
	{
		[CompilerGenerated]
		get
		{
			return 놻녔;
		}
		[CompilerGenerated]
		private set
		{
			놻녔 = value;
		}
	}

	/// <summary>
	/// Get the price where trade was executed
	/// </summary>
	public double Price
	{
		[CompilerGenerated]
		get
		{
			return 놻녠;
		}
		[CompilerGenerated]
		private set
		{
			놻녠 = value;
		}
	}

	/// <summary>
	/// Get the trade quantity
	/// </summary>
	public double Quantity
	{
		[CompilerGenerated]
		get
		{
			return 놻놠;
		}
		[CompilerGenerated]
		private set
		{
			놻놠 = value;
		}
	}

	/// <summary>
	/// Get the date and time when trade was executed
	/// </summary>
	public DateTime DateTime
	{
		[CompilerGenerated]
		get
		{
			return 놻놟;
		}
		[CompilerGenerated]
		private set
		{
			놻놟 = value;
		}
	}

	/// <summary>
	/// Get the trade Gross P&amp;L
	/// </summary>
	public PnLItem GrossPnl
	{
		[CompilerGenerated]
		get
		{
			return 놻녓;
		}
		[CompilerGenerated]
		internal set
		{
			놻녓 = value;
		}
	}

	/// <summary>
	/// Get the trade Net P&amp;L
	/// </summary>
	public PnLItem NetPnl
	{
		[CompilerGenerated]
		get
		{
			return 놻녛;
		}
		[CompilerGenerated]
		internal set
		{
			놻녛 = value;
		}
	}

	/// <summary>
	/// Get the fee value that was charged for this trade
	/// </summary>
	public PnLItem Fee
	{
		[CompilerGenerated]
		get
		{
			return 놻녽;
		}
		[CompilerGenerated]
		internal set
		{
			놻녽 = value;
		}
	}

	/// <summary>
	/// Get the trade order type
	/// </summary>
	public string OrderTypeId
	{
		[CompilerGenerated]
		get
		{
			return 놻놏;
		}
		[CompilerGenerated]
		internal set
		{
			놻놏 = value;
		}
	}

	public PositionImpactType PositionImpactType
	{
		[CompilerGenerated]
		get
		{
			return 놻녥;
		}
		[CompilerGenerated]
		private set
		{
			놻녥 = value;
		}
	}

	/// <summary>
	/// Will be triggered on trade updating
	/// </summary>
	public event Action Updated
	{
		[CompilerGenerated]
		add
		{
			Action action = 놻농;
			Action action2;
			do
			{
				action2 = action;
				Action value2 = (Action)Delegate.Combine(action2, value);
				action = Interlocked.CompareExchange(ref 놻농, value2, action2);
			}
			while ((object)action != action2);
		}
		[CompilerGenerated]
		remove
		{
			Action action = 놻농;
			Action action2;
			do
			{
				action2 = action;
				Action value2 = (Action)Delegate.Remove(action2, value);
				action = Interlocked.CompareExchange(ref 놻농, value2, action2);
			}
			while ((object)action != action2);
		}
	}

	public Trade(string connectionId)
		: base(connectionId)
	{
	}

	internal void 녴(MessageTrade P_0)
	{
		base.Id = P_0.TradeId;
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
		if (ConnectionCache != null && ConnectionCache.AccountsCache.녴(P_0.AccountId, out var account))
		{
			base.Account = account;
		}
		else if (!string.IsNullOrEmpty(P_0.AccountId))
		{
			base.Account = new Account(new BusinessObjectInfo
			{
				Id = P_0.AccountId,
				Name = P_0.AccountId
			});
		}
		OrderId = P_0.OrderId;
		PositionId = P_0.PositionId;
		Price = P_0.Price;
		Quantity = P_0.Quantity;
		base.Side = P_0.Side;
		base.Comment = P_0.Comment;
		DateTime = P_0.DateTime;
		OrderTypeId = P_0.OrderTypeId;
		PositionImpactType = P_0.PositionImpactType;
		GrossPnl = P_0.GrossPnl;
		if (GrossPnl != null)
		{
			GrossPnl.ConnectionId = base.ConnectionId;
		}
		NetPnl = P_0.NetPnl;
		if (NetPnl != null)
		{
			NetPnl.ConnectionId = base.ConnectionId;
		}
		Fee = P_0.Fee;
		if (Fee != null)
		{
			Fee.ConnectionId = base.ConnectionId;
		}
		놻농?.Invoke();
	}

	public MessageTrade BuildMessage()
	{
		return new MessageTrade
		{
			TradeId = base.Id,
			SymbolId = base.Symbol?.Id,
			AccountId = base.Account?.Id,
			OrderId = OrderId,
			PositionId = PositionId,
			Price = Price,
			Quantity = Quantity,
			Side = base.Side,
			Comment = base.Comment,
			DateTime = DateTime,
			OrderTypeId = OrderTypeId,
			PositionImpactType = PositionImpactType,
			GrossPnl = GrossPnl,
			NetPnl = NetPnl,
			Fee = Fee
		};
	}

	public override string ToString()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(50, 7);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸놼());
		defaultInterpolatedStringHandler.AppendFormatted(base.Symbol);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂녹());
		defaultInterpolatedStringHandler.AppendFormatted(base.Account);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂녹());
		defaultInterpolatedStringHandler.AppendFormatted(base.Side);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸놗());
		defaultInterpolatedStringHandler.AppendFormatted(Quantity);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇋놝());
		defaultInterpolatedStringHandler.AppendFormatted(Price);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸뇂());
		defaultInterpolatedStringHandler.AppendFormatted(OrderId);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놄노());
		defaultInterpolatedStringHandler.AppendFormatted(base.Comment);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}
}
