using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using CancelAllOpenOrdersRequests;
using TradingPlatform.BusinessLayer.Utils;

namespace TradingPlatform.BusinessLayer;

public class AdvancedTradingOperations
{
	private class 녴
	{
		[CompilerGenerated]
		private readonly Position 녵놷;

		[CompilerGenerated]
		private readonly IList<Order> 녵녗;

		[CompilerGenerated]
		private readonly SlTpHolder 녵놜;

		public Position Position
		{
			[CompilerGenerated]
			get
			{
				return 녵놷;
			}
			[CompilerGenerated]
			init
			{
				녵놷 = value;
			}
		}

		public IList<Order> Brackets
		{
			[CompilerGenerated]
			get
			{
				return 녵녗;
			}
			[CompilerGenerated]
			init
			{
				녵녗 = value;
			}
		}

		public SlTpHolder InitialBracketParameters
		{
			[CompilerGenerated]
			get
			{
				return 녵놜;
			}
			[CompilerGenerated]
			init
			{
				녵놜 = value;
			}
		}
	}

	private class 놴(Symbol, Account) : IEquatable<놴>
	{
		[CompilerGenerated]
		private readonly Symbol 녵놨;

		[CompilerGenerated]
		private readonly Account 녵녢;

		[CompilerGenerated]
		protected virtual Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(놴);
			}
		}

		public Symbol Symbol
		{
			[CompilerGenerated]
			get
			{
				return P_0;
			}
			[CompilerGenerated]
			init
			{
				P_0 = value;
			}
		}

		public Account Account
		{
			[CompilerGenerated]
			get
			{
				return 녵녢;
			}
			[CompilerGenerated]
			init
			{
				녵녢 = value;
			}
		}

		public 놴(Symbol P_0, Account P_1)
		{
			녵놨 = P_0;
			녵녢 = P_1;
			base._002Ector();
		}

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭녷());
			stringBuilder.Append(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놎());
			if (녴(stringBuilder))
			{
				stringBuilder.Append(' ');
			}
			stringBuilder.Append('}');
			return stringBuilder.ToString();
		}

		[CompilerGenerated]
		protected virtual bool 녴(StringBuilder P_0)
		{
			RuntimeHelpers.EnsureSufficientExecutionStack();
			P_0.Append(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭녟());
			P_0.Append(Symbol);
			P_0.Append(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭놱());
			P_0.Append(Account);
			return true;
		}

		[CompilerGenerated]
		public static bool operator !=(놴? P_0, 놴? P_1)
		{
			return !(P_0 == P_1);
		}

		[CompilerGenerated]
		public static bool operator ==(놴? P_0, 놴? P_1)
		{
			if ((object)P_0 != P_1)
			{
				return P_0?.Equals(P_1) ?? false;
			}
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (EqualityComparer<Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<Symbol>.Default.GetHashCode(P_0)) * -1521134295 + EqualityComparer<Account>.Default.GetHashCode(녵녢);
		}

		[CompilerGenerated]
		public override bool Equals(object? obj)
		{
			return Equals(obj as 놴);
		}

		[CompilerGenerated]
		public virtual bool Equals(놴? other)
		{
			if ((object)this != other)
			{
				if ((object)other != null && EqualityContract == other.EqualityContract && EqualityComparer<Symbol>.Default.Equals(P_0, other.P_0))
				{
					return EqualityComparer<Account>.Default.Equals(녵녢, other.녵녢);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		public virtual 놴 녴()
		{
			return new 놴(this);
		}

		[CompilerGenerated]
		protected 놴(놴 original)
		{
			녵놨 = original.녵놨;
			녵녢 = original.녵녢;
		}

		[CompilerGenerated]
		public void 녴(out Symbol P_0, out Account P_1)
		{
			P_0 = Symbol;
			P_1 = Account;
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class 놂
	{
		public static readonly 놂 녵놞 = new 놂();

		public static Func<IOrder, Symbol> 녵놳;

		public static Func<IOrder, IOrder> 녵놺;

		public static Func<IOrder, Connection> 녵놅;

		public static Func<IOrder, Symbol> 녵녜;

		public static Func<IOrder, Account> 녵뇃;

		public static Func<IOrder, 놴> 녵녯;

		public static Func<IOrder, string> 녵놮;

		public static Func<Position, bool> 녵녫;

		public static Func<Position, bool> 녵뇁;

		public static Func<Position, bool> 녵놧;

		public static Func<Position, bool> 녵녝;

		public static Func<OrderType, bool> 녵뇈;

		public static Func<Order, bool> 녵놑;

		public static Func<OrderType, bool> 녵놦;

		public static Func<Order, bool> 녵놐;

		public static Func<Order, string> 녵녚;

		public static Func<Order, bool> 녵녳;

		public static Func<Order, string> 녵놉;

		public static Func<Order, double> 녵놥;

		public static Func<Order, bool> 녵놯;

		public static Func<Order, Order, Order> 녵녾;

		public static Func<Order, bool> 녵녬;

		public static Func<Order, Order, Order> 녵녹;

		public static Func<Order, double> 녵녔;

		public static Func<Order, double> 녵녠;

		public static Func<Order, (double, double)> 녵놠;

		public static Func<Order, string> 녵놟;

		internal Symbol 녴(IOrder P_0)
		{
			return P_0.Symbol;
		}

		internal IOrder 놴(IOrder P_0)
		{
			return P_0;
		}

		internal Connection 놂(IOrder P_0)
		{
			return P_0.Symbol.Connection;
		}

		internal Symbol 놎(IOrder P_0)
		{
			return P_0.Symbol;
		}

		internal Account 녞(IOrder P_0)
		{
			return P_0.Account;
		}

		internal 놴 놫(IOrder P_0)
		{
			return new 놴(P_0.Symbol, P_0.Account);
		}

		internal string 녪(IOrder P_0)
		{
			return P_0.Id;
		}

		internal bool 녴(Position P_0)
		{
			return true;
		}

		internal bool 놴(Position P_0)
		{
			return true;
		}

		internal bool 놂(Position P_0)
		{
			return true;
		}

		internal bool 놎(Position P_0)
		{
			return true;
		}

		internal bool 녴(OrderType P_0)
		{
			if (P_0.Behavior == OrderTypeBehavior.Market)
			{
				return (P_0.Usage & OrderTypeUsage.Order) == OrderTypeUsage.Order;
			}
			return false;
		}

		internal bool 녴(Order P_0)
		{
			OrderTypeBehavior behavior = P_0.OrderType.Behavior;
			if ((uint)(behavior - 3) <= 1u)
			{
				return true;
			}
			return false;
		}

		internal bool 놴(OrderType P_0)
		{
			return P_0.Behavior == OrderTypeBehavior.Stop;
		}

		internal bool 놴(Order P_0)
		{
			return string.IsNullOrEmpty(P_0.GroupId);
		}

		internal string 놂(Order P_0)
		{
			return P_0.GroupId;
		}

		internal bool 놎(Order P_0)
		{
			return string.IsNullOrEmpty(P_0.GroupId);
		}

		internal string 녞(Order P_0)
		{
			return P_0.GroupId;
		}

		internal double 놫(Order P_0)
		{
			return P_0.GetExecutionPrice();
		}

		internal bool 녪(Order P_0)
		{
			return string.IsNullOrEmpty(P_0.GroupId);
		}

		internal Order 녴(Order P_0, Order P_1)
		{
			if (!(P_0.RemainingQuantity > P_1.RemainingQuantity))
			{
				return P_1;
			}
			return P_0;
		}

		internal bool 녶(Order P_0)
		{
			return string.IsNullOrEmpty(P_0.GroupId);
		}

		internal Order 놴(Order P_0, Order P_1)
		{
			if (!(P_0.RemainingQuantity > P_1.RemainingQuantity))
			{
				return P_1;
			}
			return P_0;
		}

		internal double 녵(Order P_0)
		{
			return P_0.GetExecutionPrice();
		}

		internal double 놭(Order P_0)
		{
			return P_0.GetExecutionPrice();
		}

		internal (double, double) 녲(Order P_0)
		{
			return (P_0.GetExecutionPrice(), P_0.RemainingQuantity);
		}

		internal string 뇋(Order P_0)
		{
			return P_0.Id;
		}
	}

	[CompilerGenerated]
	private sealed class 놎
	{
		public Symbol 녵녓;

		public Account 녵녛;

		public TimeInForce 녵녽;

		internal bool 녴(IOrder P_0)
		{
			if (녵녓.IsSameAs(P_0.Symbol) && P_0.Account.Equals(녵녛))
			{
				return P_0.TimeInForce == 녵녽;
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class 녞
	{
		public TimeInForce 녵놏;

		internal bool 녴(IOrder P_0)
		{
			return P_0.TimeInForce == 녵놏;
		}
	}

	[CompilerGenerated]
	private sealed class 놫
	{
		public Symbol 녵녥;

		public OrderTypeBehavior 녵농;

		internal bool 녴(IOrder P_0)
		{
			if (녵녥.IsSameAs(P_0.Symbol))
			{
				return P_0.OrderType.Behavior == 녵농;
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class 녪
	{
		public Symbol 녵념;

		public Account 녵녨;

		public OrderTypeBehavior 녵녺;

		internal bool 녴(IOrder P_0)
		{
			if (녵념.IsSameAs(P_0.Symbol) && P_0.Account.Equals(녵녨))
			{
				return P_0.OrderType.Behavior == 녵녺;
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class 녶
	{
		public OrderTypeBehavior 녵놣;

		internal bool 녴(IOrder P_0)
		{
			return P_0.OrderType.Behavior == 녵놣;
		}
	}

	[CompilerGenerated]
	private sealed class 녵
	{
		public Connection 녵녮;

		internal bool 녴(IOrder P_0)
		{
			return P_0.ConnectionId == 녵녮.Id;
		}

		internal bool 놴(IOrder P_0)
		{
			return P_0.ConnectionId == 녵녮.Id;
		}
	}

	[CompilerGenerated]
	private sealed class 놭
	{
		public Symbol 녵뇆;

		internal bool 녴(IOrder P_0)
		{
			return 녵뇆.IsSameAs(P_0.Symbol);
		}
	}

	[CompilerGenerated]
	private sealed class 녲
	{
		public Symbol 녵뇉;

		public Account 녵뇍;

		internal bool 녴(Order P_0)
		{
			if (P_0.Symbol.Equals(녵뇉))
			{
				return P_0.Account.Equals(녵뇍);
			}
			return false;
		}

		internal bool 녴(IOrder P_0)
		{
			if (녵뇉.IsSameAs(P_0.Symbol))
			{
				return P_0.Account.Equals(녵뇍);
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class 뇋
	{
		public Func<IOrder, bool> 녵놙;

		public Func<IOrder, bool> 녵녰;

		internal bool 녴(IOrder P_0)
		{
			if (녵놙 != null)
			{
				return 녵놙(P_0);
			}
			return true;
		}
	}

	[CompilerGenerated]
	private sealed class 놸
	{
		public Account 녵놚;

		internal bool 녴(Position P_0)
		{
			return P_0.Account.Equals(녵놚);
		}
	}

	[CompilerGenerated]
	private sealed class 놿
	{
		public Side 녵놹;

		internal bool 녴(Position P_0)
		{
			return P_0.Side == 녵놹;
		}
	}

	[CompilerGenerated]
	private sealed class 놄
	{
		public Symbol 녵놘;

		public Side 녵뇌;

		internal bool 녴(Position P_0)
		{
			if (녵놘.IsSameAs(P_0.Symbol))
			{
				return P_0.Side == 녵뇌;
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class 놰
	{
		public Symbol 녵녷;

		internal bool 녴(Position P_0)
		{
			return 녵녷.IsSameAs(P_0.Symbol);
		}
	}

	[CompilerGenerated]
	private sealed class 놓
	{
		public Symbol 녵녟;

		internal bool 녴(Position P_0)
		{
			return 녵녟.IsSameAs(P_0.Symbol);
		}
	}

	[CompilerGenerated]
	private sealed class 놇
	{
		public Symbol 녵놱;

		internal bool 녴(Position P_0)
		{
			return 녵놱.IsSameAs(P_0.Symbol);
		}
	}

	[CompilerGenerated]
	private sealed class 뇅
	{
		public Symbol 녵놖;

		public Account 녵놝;

		internal bool 녴(Position P_0)
		{
			if (녵놖.IsSameAs(P_0.Symbol))
			{
				return P_0.Account.Equals(녵놝);
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class 놵
	{
		public Func<Position, bool> 녵뇄;

		internal bool 녴(Position P_0)
		{
			PnLItem pnLItem = P_0.NetPnL ?? P_0.GrossPnL;
			if (pnLItem != null && pnLItem.Value > 0.0)
			{
				if (녵뇄 != null)
				{
					return 녵뇄(P_0);
				}
				return true;
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class 놡
	{
		public Func<Position, bool> 녵녑;

		internal bool 녴(Position P_0)
		{
			PnLItem pnLItem = P_0.NetPnL ?? P_0.GrossPnL;
			if (pnLItem != null && pnLItem.Value < 0.0)
			{
				if (녵녑 != null)
				{
					return 녵녑(P_0);
				}
				return true;
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class 놻
	{
		public Func<Position, bool> 녵놈;

		public Func<Position, bool> 녵놬;

		internal bool 녴(Position P_0)
		{
			if (녵놈 != null)
			{
				return 녵놈(P_0);
			}
			return true;
		}
	}

	[CompilerGenerated]
	private sealed class 놃
	{
		public Symbol 녵놊;

		internal bool 녴(Position P_0)
		{
			return P_0.Symbol.IsSameAs(녵놊);
		}
	}

	[CompilerGenerated]
	private sealed class 뇇
	{
		public Account 녵놪;

		internal bool 녴(Position P_0)
		{
			return P_0.Account.Equals(녵놪);
		}
	}

	[CompilerGenerated]
	private sealed class 놛
	{
		public Symbol 녵놌;

		public Account 녵놕;

		internal bool 녴(Position P_0)
		{
			if (P_0.Symbol.IsSameAs(녵놌))
			{
				return P_0.Account.Equals(녵놕);
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class 놼
	{
		public Symbol 녵뇊;

		public Account 녵놋;

		public Func<Order, bool> 녵녣;

		public Func<Order, bool> 녵녩;

		internal bool 녴(Order P_0)
		{
			if (P_0.Symbol.Equals(녵뇊))
			{
				return P_0.Account.Equals(녵놋);
			}
			return false;
		}

		internal bool 놴(Order P_0)
		{
			return P_0.Symbol.Equals(녵뇊);
		}
	}

	[CompilerGenerated]
	private sealed class 놗
	{
		public Position 녵놤;

		internal bool 녴(Order P_0)
		{
			return P_0.PositionId == 녵놤.Id;
		}
	}

	[CompilerGenerated]
	private sealed class 뇂
	{
		public Account 녵논;

		internal bool 녴(IOrder P_0)
		{
			return P_0.Account.Equals(녵논);
		}
	}

	[CompilerGenerated]
	private sealed class 놩
	{
		public Symbol 녵녘;

		public Account 녵노;

		public Position 녵녒;

		internal bool 녴(Position P_0)
		{
			if (P_0.ConnectionId == 녵녘.ConnectionId && 녵녘.IsSameAs(P_0.Symbol))
			{
				return P_0.Account.Id == 녵노.Id;
			}
			return false;
		}

		internal bool 녴(Order P_0)
		{
			if (P_0.ConnectionId == 녵녘.ConnectionId && 녵녘.IsSameAs(P_0.Symbol))
			{
				return P_0.Account.Id == 녵노.Id;
			}
			return false;
		}

		internal bool 놴(Order P_0)
		{
			if (P_0.OrderType.Behavior == OrderTypeBehavior.Stop)
			{
				return P_0.Side != 녵녒.Side;
			}
			return false;
		}

		internal bool 놂(Order P_0)
		{
			if (P_0.OrderType.Behavior == OrderTypeBehavior.Stop)
			{
				return P_0.Side != 녵녒.Side;
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class 녡
	{
		public TaskCompletionSource<OrderHistory> 녵녕;

		internal void 녴(OrderHistory P_0)
		{
			OrderStatus status = P_0.Status;
			if ((status == OrderStatus.Opened || status == OrderStatus.Refused) ? true : false)
			{
				녵녕.SetResult(P_0);
			}
		}

		internal void 녴()
		{
			녵녕.TrySetCanceled();
		}
	}

	[CompilerGenerated]
	private sealed class 녦
	{
		public Symbol 녵녖;

		public Position 놭녴;

		internal bool 녴(Order P_0)
		{
			if (녵녖.IsSameAs(P_0.Symbol) && P_0.Account.Equals(놭녴.Account) && P_0.Side != 놭녴.Side)
			{
				if (P_0.Side != 0)
				{
					return P_0.GetExecutionPrice() < 놭녴.OpenPrice;
				}
				return P_0.GetExecutionPrice() > 놭녴.OpenPrice;
			}
			return false;
		}

		internal bool 놴(Order P_0)
		{
			if (녵녖.IsSameAs(P_0.Symbol) && P_0.Account.Equals(놭녴.Account) && P_0.Side != 놭녴.Side)
			{
				if (P_0.Side != 0)
				{
					return P_0.GetExecutionPrice() > 놭녴.OpenPrice;
				}
				return P_0.GetExecutionPrice() < 놭녴.OpenPrice;
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class 놀
	{
		public Order 놭놴;

		internal bool 녴(Order P_0)
		{
			return P_0.OrderTypeId != 놭놴.OrderTypeId;
		}
	}

	[CompilerGenerated]
	private sealed class 놔
	{
		public Order 놭놂;

		internal bool 녴(Order P_0)
		{
			return P_0.Id != 놭놂.Id;
		}
	}

	[CompilerGenerated]
	private sealed class 놾
	{
		public Order 놭놎;

		internal bool 녴(Order P_0)
		{
			return P_0.Id != 놭놎.Id;
		}
	}

	[CompilerGenerated]
	private sealed class 뇀
	{
		public ManualResetEventSlim 놭녞;

		public string 놭놫;

		public PlaceOrderRequestParameters 놭녪;

		internal void 녴(Order P_0)
		{
			if (!놭녞.IsSet)
			{
				if (!string.IsNullOrEmpty(놭놫) && P_0.Id == 놭놫)
				{
					놭녞.Set();
				}
				else if (놭녪.IsCorrespondingOrder(P_0))
				{
					놭녞.Set();
				}
			}
		}
	}

	[CompilerGenerated]
	private sealed class 놽
	{
		public ManualResetEventSlim 놭녶;

		public ModifyOrderRequestParameters 놭녵;

		internal void 녴(Order P_0)
		{
			if (!놭녶.IsSet && 놭녵.IsCorrespondingOrder(P_0))
			{
				놭녶.Set();
			}
		}
	}

	[CompilerGenerated]
	private sealed class 녿
	{
		public HashSet<string> 놭놭;

		public ManualResetEvent 놭녲;

		internal void 녴(Order P_0)
		{
			놭놭.Remove(P_0.Id);
			if (놭놭.Count == 0)
			{
				놭녲.Set();
			}
		}
	}

	[CompilerGenerated]
	private sealed class 놁
	{
		public Symbol 놭뇋;

		public Side 놭놸;

		internal bool 녴(IOrder P_0)
		{
			if (놭뇋.IsSameAs(P_0.Symbol))
			{
				return P_0.Side == 놭놸;
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class 녭
	{
		public Symbol 놭놿;

		public Account 놭놄;

		public Side 놭놰;

		internal bool 녴(IOrder P_0)
		{
			if (놭놿.IsSameAs(P_0.Symbol) && P_0.Account.Equals(놭놄))
			{
				return P_0.Side == 놭놰;
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class 녱
	{
		public Side 놭놓;

		internal bool 녴(IOrder P_0)
		{
			return P_0.Side == 놭놓;
		}
	}

	[CompilerGenerated]
	private sealed class 놲
	{
		public Symbol 놭놇;

		public TimeInForce 놭뇅;

		internal bool 녴(IOrder P_0)
		{
			if (놭놇.IsSameAs(P_0.Symbol))
			{
				return P_0.TimeInForce == 놭뇅;
			}
			return false;
		}
	}

	internal AdvancedTradingOperations()
	{
	}

	/// <summary>
	/// Cancel all pending <see cref="T:TradingPlatform.BusinessLayer.Order" />s
	/// </summary>
	/// <param name="sendingSource">the name of the initiator of the call (optional)</param>
	public AdvancedTradingOperationResult CancelOrders([CallerMemberName] string sendingSource = null)
	{
		Core.Instance.Loggers.Log(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴녾() + sendingSource);
		GroupTradingOperation groupTradingOperation = new GroupTradingOperation(GroupTradingOperationType.CancelOrders, GroupTradingOperationFilters.None);
		return 녴(sendingSource, groupTradingOperation);
	}

	/// <summary>
	/// Cancel all pending <see cref="T:TradingPlatform.BusinessLayer.Order" />s
	/// </summary>
	/// <param name="orders"><see cref="T:TradingPlatform.BusinessLayer.Order" />s to cancel</param>
	/// <param name="sendingSource">the name of the initiator of the call (optional)</param>
	/// <returns></returns>
	public AdvancedTradingOperationResult CancelOrders(IOrder[] orders, [CallerMemberName] string sendingSource = null)
	{
		LoggerManager loggers = Core.Instance.Loggers;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(67, 2);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴녬());
		defaultInterpolatedStringHandler.AppendFormatted(orders.Length);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴녹());
		defaultInterpolatedStringHandler.AppendFormatted(sendingSource);
		loggers.Log(defaultInterpolatedStringHandler.ToStringAndClear());
		AdvancedTradingOperationResult advancedTradingOperationResult = new AdvancedTradingOperationResult();
		GroupTradingOperation groupTradingOperation = new GroupTradingOperation(GroupTradingOperationType.CancelOrders, GroupTradingOperationFilters.CertainOrders);
		foreach (IGrouping<Symbol, IOrder> item in from P_0 in orders
			group P_0 by P_0.Symbol)
		{
			Symbol key = item.Key;
			IOrder[] array = item.ToArray();
			advancedTradingOperationResult.녴(녴(key, array, sendingSource, groupTradingOperation));
		}
		return advancedTradingOperationResult;
	}

	/// <summary>
	/// Cancel all pending <see cref="T:TradingPlatform.BusinessLayer.Order" />s by <see cref="T:TradingPlatform.BusinessLayer.Symbol" />
	/// </summary>
	/// <param name="symbol"><see cref="T:TradingPlatform.BusinessLayer.Symbol" /></param>
	/// <param name="sendingSource">the name of the initiator of the call (optional)</param>
	public AdvancedTradingOperationResult CancelOrders(Symbol symbol, [CallerMemberName] string sendingSource = null)
	{
		LoggerManager loggers = Core.Instance.Loggers;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(62, 2);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴녔());
		defaultInterpolatedStringHandler.AppendFormatted(symbol);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴녠());
		defaultInterpolatedStringHandler.AppendFormatted(sendingSource);
		loggers.Log(defaultInterpolatedStringHandler.ToStringAndClear());
		GroupTradingOperation groupTradingOperation = new GroupTradingOperation(GroupTradingOperationType.CancelOrders, GroupTradingOperationFilters.Symbol);
		return 녴(symbol, Array.Empty<IOrder>(), sendingSource, groupTradingOperation);
	}

	/// <summary>
	/// Cancel all pending <see cref="T:TradingPlatform.BusinessLayer.Order" />s by <see cref="T:TradingPlatform.BusinessLayer.Account" />
	/// </summary>
	/// <param name="account"><see cref="T:TradingPlatform.BusinessLayer.Account" /></param>
	/// <param name="sendingSource">the name of the initiator of the call (optional)</param>
	public AdvancedTradingOperationResult CancelOrders(Account account, [CallerMemberName] string sendingSource = null)
	{
		LoggerManager loggers = Core.Instance.Loggers;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(63, 2);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴놠());
		defaultInterpolatedStringHandler.AppendFormatted(account);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴녠());
		defaultInterpolatedStringHandler.AppendFormatted(sendingSource);
		loggers.Log(defaultInterpolatedStringHandler.ToStringAndClear());
		GroupTradingOperation groupTradingOperation = new GroupTradingOperation(GroupTradingOperationType.CancelOrders, GroupTradingOperationFilters.Account);
		return 녴((IOrder P_0) => P_0.Account.Equals(account), sendingSource, groupTradingOperation);
	}

	/// <summary>
	/// Cancel all pending <see cref="T:TradingPlatform.BusinessLayer.Order" />s by <see cref="T:TradingPlatform.BusinessLayer.Symbol" /> and <see cref="T:TradingPlatform.BusinessLayer.Account" />
	/// </summary>
	/// <param name="symbol"><see cref="T:TradingPlatform.BusinessLayer.Symbol" /></param>
	/// <param name="account"><see cref="T:TradingPlatform.BusinessLayer.Account" /></param>
	/// <param name="sendingSource">the name of the initiator of the call (optional)</param>
	public AdvancedTradingOperationResult CancelOrders(Symbol symbol, Account account, [CallerMemberName] string sendingSource = null)
	{
		LoggerManager loggers = Core.Instance.Loggers;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(74, 3);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴녔());
		defaultInterpolatedStringHandler.AppendFormatted(symbol);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴놟());
		defaultInterpolatedStringHandler.AppendFormatted(account);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴녠());
		defaultInterpolatedStringHandler.AppendFormatted(sendingSource);
		loggers.Log(defaultInterpolatedStringHandler.ToStringAndClear());
		GroupTradingOperation groupTradingOperation = new GroupTradingOperation(GroupTradingOperationType.CancelOrders, GroupTradingOperationFilters.Symbol | GroupTradingOperationFilters.Account);
		return 녴(symbol, account, sendingSource, groupTradingOperation);
	}

	/// <summary>
	/// Cancel all pending <see cref="T:TradingPlatform.BusinessLayer.Order" />s by <see cref="T:TradingPlatform.BusinessLayer.Symbol" /> and <see cref="T:TradingPlatform.BusinessLayer.Side" />
	/// </summary>
	/// <param name="symbol"><see cref="T:TradingPlatform.BusinessLayer.Symbol" /></param>
	/// <param name="side"><see cref="T:TradingPlatform.BusinessLayer.Side" /></param>
	/// <param name="sendingSource">the name of the initiator of the call (optional)</param>
	public AdvancedTradingOperationResult CancelOrders(Symbol symbol, Side side, [CallerMemberName] string sendingSource = null)
	{
		LoggerManager loggers = Core.Instance.Loggers;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(71, 3);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴녔());
		defaultInterpolatedStringHandler.AppendFormatted(symbol);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴녓());
		defaultInterpolatedStringHandler.AppendFormatted(side);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴녠());
		defaultInterpolatedStringHandler.AppendFormatted(sendingSource);
		loggers.Log(defaultInterpolatedStringHandler.ToStringAndClear());
		GroupTradingOperation groupTradingOperation = new GroupTradingOperation(GroupTradingOperationType.CancelOrders, GroupTradingOperationFilters.Symbol | GroupTradingOperationFilters.Side);
		return 녴((IOrder P_0) => symbol.IsSameAs(P_0.Symbol) && P_0.Side == side, sendingSource, groupTradingOperation);
	}

	/// <summary>
	/// Cancel all pending <see cref="T:TradingPlatform.BusinessLayer.Order" />s by <see cref="T:TradingPlatform.BusinessLayer.Symbol" />, <see cref="T:TradingPlatform.BusinessLayer.Account" /> and <see cref="T:TradingPlatform.BusinessLayer.Side" />
	/// </summary>
	/// <param name="symbol"><see cref="T:TradingPlatform.BusinessLayer.Symbol" /></param>
	/// <param name="account"><see cref="T:TradingPlatform.BusinessLayer.Account" /></param>
	/// <param name="side"><see cref="T:TradingPlatform.BusinessLayer.Side" /></param>
	/// <param name="sendingSource">the name of the initiator of the call (optional)</param>
	public AdvancedTradingOperationResult CancelOrders(Symbol symbol, Account account, Side side, [CallerMemberName] string sendingSource = null)
	{
		LoggerManager loggers = Core.Instance.Loggers;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(83, 4);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴녔());
		defaultInterpolatedStringHandler.AppendFormatted(symbol);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴놟());
		defaultInterpolatedStringHandler.AppendFormatted(account);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴녓());
		defaultInterpolatedStringHandler.AppendFormatted(side);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴녠());
		defaultInterpolatedStringHandler.AppendFormatted(sendingSource);
		loggers.Log(defaultInterpolatedStringHandler.ToStringAndClear());
		GroupTradingOperation groupTradingOperation = new GroupTradingOperation(GroupTradingOperationType.CancelOrders, GroupTradingOperationFilters.Symbol | GroupTradingOperationFilters.Account | GroupTradingOperationFilters.Side);
		return 녴((IOrder P_0) => symbol.IsSameAs(P_0.Symbol) && P_0.Account.Equals(account) && P_0.Side == side, sendingSource, groupTradingOperation);
	}

	/// <summary>
	/// Cancel all pending <see cref="T:TradingPlatform.BusinessLayer.Order" />s by <see cref="T:TradingPlatform.BusinessLayer.Side" />
	/// </summary>
	/// <param name="side"><see cref="T:TradingPlatform.BusinessLayer.Side" /></param>
	/// <param name="sendingSource">the name of the initiator of the call (optional)</param>
	public AdvancedTradingOperationResult CancelOrders(Side side, [CallerMemberName] string sendingSource = null)
	{
		LoggerManager loggers = Core.Instance.Loggers;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(60, 2);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴녛());
		defaultInterpolatedStringHandler.AppendFormatted(side);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴녠());
		defaultInterpolatedStringHandler.AppendFormatted(sendingSource);
		loggers.Log(defaultInterpolatedStringHandler.ToStringAndClear());
		GroupTradingOperation groupTradingOperation = new GroupTradingOperation(GroupTradingOperationType.CancelOrders, GroupTradingOperationFilters.Side);
		return 녴((IOrder P_0) => P_0.Side == side, sendingSource, groupTradingOperation);
	}

	/// <summary>
	/// Cancel all pending <see cref="T:TradingPlatform.BusinessLayer.Order" />s by <see cref="T:TradingPlatform.BusinessLayer.Symbol" /> and <see cref="T:TradingPlatform.BusinessLayer.TimeInForce" />
	/// </summary>
	/// <param name="symbol"><see cref="T:TradingPlatform.BusinessLayer.Symbol" /></param>
	/// <param name="timeInForce"><see cref="T:TradingPlatform.BusinessLayer.TimeInForce" /></param>
	/// <param name="sendingSource">the name of the initiator of the call (optional)</param>
	public AdvancedTradingOperationResult CancelOrders(Symbol symbol, TimeInForce timeInForce, [CallerMemberName] string sendingSource = null)
	{
		LoggerManager loggers = Core.Instance.Loggers;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(80, 3);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴녔());
		defaultInterpolatedStringHandler.AppendFormatted(symbol);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴녽());
		defaultInterpolatedStringHandler.AppendFormatted(timeInForce);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴녠());
		defaultInterpolatedStringHandler.AppendFormatted(sendingSource);
		loggers.Log(defaultInterpolatedStringHandler.ToStringAndClear());
		GroupTradingOperation groupTradingOperation = new GroupTradingOperation(GroupTradingOperationType.CancelOrders, GroupTradingOperationFilters.Symbol | GroupTradingOperationFilters.TimeInForce);
		return 녴((IOrder P_0) => symbol.IsSameAs(P_0.Symbol) && P_0.TimeInForce == timeInForce, sendingSource, groupTradingOperation);
	}

	/// <summary>
	/// Cancel all pending <see cref="T:TradingPlatform.BusinessLayer.Order" />s by <see cref="T:TradingPlatform.BusinessLayer.Symbol" />, <see cref="T:TradingPlatform.BusinessLayer.Account" /> and <see cref="T:TradingPlatform.BusinessLayer.TimeInForce" />
	/// </summary>
	/// <param name="symbol"><see cref="T:TradingPlatform.BusinessLayer.Symbol" /></param>
	/// <param name="account"><see cref="T:TradingPlatform.BusinessLayer.Account" /></param>
	/// <param name="timeInForce"><see cref="T:TradingPlatform.BusinessLayer.TimeInForce" /></param>
	/// <param name="sendingSource">the name of the initiator of the call (optional)</param>
	public AdvancedTradingOperationResult CancelOrders(Symbol symbol, Account account, TimeInForce timeInForce, [CallerMemberName] string sendingSource = null)
	{
		LoggerManager loggers = Core.Instance.Loggers;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(92, 4);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴녔());
		defaultInterpolatedStringHandler.AppendFormatted(symbol);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴놟());
		defaultInterpolatedStringHandler.AppendFormatted(account);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴녽());
		defaultInterpolatedStringHandler.AppendFormatted(timeInForce);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴녠());
		defaultInterpolatedStringHandler.AppendFormatted(sendingSource);
		loggers.Log(defaultInterpolatedStringHandler.ToStringAndClear());
		GroupTradingOperation groupTradingOperation = new GroupTradingOperation(GroupTradingOperationType.CancelOrders, GroupTradingOperationFilters.Symbol | GroupTradingOperationFilters.Account | GroupTradingOperationFilters.TimeInForce);
		return 녴((IOrder P_0) => symbol.IsSameAs(P_0.Symbol) && P_0.Account.Equals(account) && P_0.TimeInForce == timeInForce, sendingSource, groupTradingOperation);
	}

	/// <summary>
	/// Cancel all pending <see cref="T:TradingPlatform.BusinessLayer.Order" />s by <see cref="T:TradingPlatform.BusinessLayer.TimeInForce" />
	/// </summary>
	/// <param name="timeInForce"><see cref="T:TradingPlatform.BusinessLayer.TimeInForce" /></param>
	/// <param name="sendingSource">the name of the initiator of the call (optional)</param>
	public AdvancedTradingOperationResult CancelOrders(TimeInForce timeInForce, [CallerMemberName] string sendingSource = null)
	{
		LoggerManager loggers = Core.Instance.Loggers;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(69, 2);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴놏());
		defaultInterpolatedStringHandler.AppendFormatted(timeInForce);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴녠());
		defaultInterpolatedStringHandler.AppendFormatted(sendingSource);
		loggers.Log(defaultInterpolatedStringHandler.ToStringAndClear());
		GroupTradingOperation groupTradingOperation = new GroupTradingOperation(GroupTradingOperationType.CancelOrders, GroupTradingOperationFilters.TimeInForce);
		return 녴((IOrder P_0) => P_0.TimeInForce == timeInForce, sendingSource, groupTradingOperation);
	}

	/// <summary>
	/// Cancel all pending <see cref="T:TradingPlatform.BusinessLayer.Order" />s by <see cref="T:TradingPlatform.BusinessLayer.Symbol" /> and <see cref="T:TradingPlatform.BusinessLayer.OrderTypeBehavior" />
	/// </summary>
	/// <param name="symbol"><see cref="T:TradingPlatform.BusinessLayer.Symbol" /></param>
	/// <param name="orderTypeBehavior"><see cref="T:TradingPlatform.BusinessLayer.OrderTypeBehavior" /></param>
	/// <param name="sendingSource">the name of the initiator of the call (optional)</param>
	public AdvancedTradingOperationResult CancelOrders(Symbol symbol, OrderTypeBehavior orderTypeBehavior, [CallerMemberName] string sendingSource = null)
	{
		LoggerManager loggers = Core.Instance.Loggers;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(77, 3);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴녔());
		defaultInterpolatedStringHandler.AppendFormatted(symbol);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴녥());
		defaultInterpolatedStringHandler.AppendFormatted(orderTypeBehavior);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴녠());
		defaultInterpolatedStringHandler.AppendFormatted(sendingSource);
		loggers.Log(defaultInterpolatedStringHandler.ToStringAndClear());
		GroupTradingOperation groupTradingOperation = new GroupTradingOperation(GroupTradingOperationType.CancelOrders, GroupTradingOperationFilters.Symbol | GroupTradingOperationFilters.OrderType);
		return 녴((IOrder P_0) => symbol.IsSameAs(P_0.Symbol) && P_0.OrderType.Behavior == orderTypeBehavior, sendingSource, groupTradingOperation);
	}

	/// <summary>
	/// Cancel all pending <see cref="T:TradingPlatform.BusinessLayer.Order" />s by <see cref="T:TradingPlatform.BusinessLayer.Symbol" />, <see cref="T:TradingPlatform.BusinessLayer.Account" /> and <see cref="T:TradingPlatform.BusinessLayer.OrderTypeBehavior" />
	/// </summary>
	/// <param name="symbol"><see cref="T:TradingPlatform.BusinessLayer.Symbol" /></param>
	/// <param name="account"><see cref="T:TradingPlatform.BusinessLayer.Account" /></param>
	/// <param name="orderTypeBehavior"><see cref="T:TradingPlatform.BusinessLayer.OrderTypeBehavior" /></param>
	/// <param name="sendingSource">the name of the initiator of the call (optional)</param>
	public AdvancedTradingOperationResult CancelOrders(Symbol symbol, Account account, OrderTypeBehavior orderTypeBehavior, [CallerMemberName] string sendingSource = null)
	{
		LoggerManager loggers = Core.Instance.Loggers;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(98, 4);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴녔());
		defaultInterpolatedStringHandler.AppendFormatted(symbol);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴놟());
		defaultInterpolatedStringHandler.AppendFormatted(account);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴농());
		defaultInterpolatedStringHandler.AppendFormatted(orderTypeBehavior);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴녠());
		defaultInterpolatedStringHandler.AppendFormatted(sendingSource);
		loggers.Log(defaultInterpolatedStringHandler.ToStringAndClear());
		GroupTradingOperation groupTradingOperation = new GroupTradingOperation(GroupTradingOperationType.CancelOrders, GroupTradingOperationFilters.Symbol | GroupTradingOperationFilters.Account | GroupTradingOperationFilters.OrderType);
		return 녴((IOrder P_0) => symbol.IsSameAs(P_0.Symbol) && P_0.Account.Equals(account) && P_0.OrderType.Behavior == orderTypeBehavior, sendingSource, groupTradingOperation);
	}

	/// <summary>
	/// Cancel all pending <see cref="T:TradingPlatform.BusinessLayer.Order" />s by <see cref="T:TradingPlatform.BusinessLayer.OrderTypeBehavior" />
	/// </summary>
	/// <param name="orderTypeBehavior"><see cref="T:TradingPlatform.BusinessLayer.OrderTypeBehavior" /></param>
	/// <param name="sendingSource">the name of the initiator of the call (optional)</param>
	public AdvancedTradingOperationResult CancelOrders(OrderTypeBehavior orderTypeBehavior, [CallerMemberName] string sendingSource = null)
	{
		LoggerManager loggers = Core.Instance.Loggers;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(75, 2);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴념());
		defaultInterpolatedStringHandler.AppendFormatted(orderTypeBehavior);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴녠());
		defaultInterpolatedStringHandler.AppendFormatted(sendingSource);
		loggers.Log(defaultInterpolatedStringHandler.ToStringAndClear());
		GroupTradingOperation groupTradingOperation = new GroupTradingOperation(GroupTradingOperationType.CancelOrders, GroupTradingOperationFilters.OrderType);
		return 녴((IOrder P_0) => P_0.OrderType.Behavior == orderTypeBehavior, sendingSource, groupTradingOperation);
	}

	private static AdvancedTradingOperationResult 녴(string P_0, GroupTradingOperation P_1)
	{
		Connection[] array = (from P_0 in 녴()
			select P_0.Symbol.Connection).Distinct().ToArray();
		AdvancedTradingOperationResult advancedTradingOperationResult = new AdvancedTradingOperationResult();
		Connection[] array2 = array;
		foreach (Connection connection in array2)
		{
			advancedTradingOperationResult.녴(녴(connection, P_0, P_1));
		}
		return advancedTradingOperationResult;
	}

	private static AdvancedTradingOperationResult 녴(Connection P_0, string P_1, GroupTradingOperation P_2 = null)
	{
		bool flag = Core.Instance.RulesManager.IsAllowed(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴녨(), P_0.Id).Status == TradingOperationStatus.Allowed;
		bool flag2 = Core.Instance.RulesManager.IsAllowed(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴녺(), P_0.Id).Status == TradingOperationStatus.Allowed;
		bool flag3 = Core.Instance.RulesManager.IsAllowed(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴놣(), P_0.Id).Status == TradingOperationStatus.Allowed;
		IOrder[] source = (from P_0 in 녴()
			where P_0.ConnectionId == P_0.Id
			select P_0).ToArray();
		Symbol[] array = source.Select((IOrder P_0) => P_0.Symbol).Distinct().ToArray();
		Account[] array2 = source.Select((IOrder P_0) => P_0.Account).Distinct().ToArray();
		if (flag && (!flag2 || array.Length <= array2.Length))
		{
			Symbol[] array3 = array;
			foreach (Symbol symbol in array3)
			{
				P_0.SendCustomRequest(new CancelAllOpenOrdersOnSymbolRequest(symbol.ComplexId)
				{
					ParentOperation = P_2,
					SendingSource = P_1
				});
			}
			return AdvancedTradingOperationResult.녴();
		}
		if (flag2 && (!flag || array.Length > array2.Length))
		{
			Account[] array4 = array2;
			foreach (Account account in array4)
			{
				P_0.SendCustomRequest(new CancelAllOpenOrdersOnAccountRequest(account.Id)
				{
					ParentOperation = P_2,
					SendingSource = P_1
				});
			}
			return AdvancedTradingOperationResult.녴();
		}
		if (flag3)
		{
			놴[] array5 = source.Select((IOrder P_0) => new 놴(P_0.Symbol, P_0.Account)).Distinct().ToArray();
			foreach (놴 놴 in array5)
			{
				P_0.SendCustomRequest(new CancelAllOpenOrdersOnSymbolAndAccountRequest(놴.Symbol.ComplexId, 놴.Account.Id)
				{
					ParentOperation = P_2,
					SendingSource = P_1
				});
			}
			return AdvancedTradingOperationResult.녴();
		}
		if ((object)P_2 == null)
		{
			P_2 = new GroupTradingOperation(GroupTradingOperationType.CancelOrders, GroupTradingOperationFilters.Connection);
		}
		return 녴((IOrder P_0) => P_0.ConnectionId == P_0.Id, P_1, P_2);
	}

	private static AdvancedTradingOperationResult 녴(Symbol P_0, IOrder[] P_1, string P_2, GroupTradingOperation P_3)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놻());
		}
		if (Core.Instance.RulesManager.IsAllowed(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴녨(), P_0).Status == TradingOperationStatus.Allowed)
		{
			P_0.Connection.SendCustomRequest(new CancelAllOpenOrdersOnSymbolRequest(P_0.ComplexId, P_1?.Select((IOrder P_0) => P_0.Id).ToArray())
			{
				ParentOperation = P_3,
				SendingSource = P_2
			});
			return AdvancedTradingOperationResult.녴();
		}
		if (P_1 == null || P_1.Length == 0)
		{
			return 녴((IOrder P_0) => P_0.IsSameAs(P_0.Symbol), P_2, P_3);
		}
		return 녴(((IEnumerable<IOrder>)P_1).Contains<IOrder>, P_2, P_3);
	}

	private static AdvancedTradingOperationResult 녴(Symbol P_0, Account P_1, string P_2, GroupTradingOperation P_3)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놻());
		}
		if (P_1 == null)
		{
			throw new ArgumentNullException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놡());
		}
		if (Core.Instance.RulesManager.IsAllowed(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴놣(), P_1, P_0).Status == TradingOperationStatus.Allowed && Core.Instance.Orders.Any((Order P_0) => P_0.Symbol.Equals(P_0) && P_0.Account.Equals(P_1)))
		{
			P_0.Connection.SendCustomRequest(new CancelAllOpenOrdersOnSymbolAndAccountRequest(P_0.ComplexId, P_1.Id)
			{
				ParentOperation = P_3,
				SendingSource = P_2
			});
			return AdvancedTradingOperationResult.녴();
		}
		return 녴((IOrder P_0) => P_0.IsSameAs(P_0.Symbol) && P_0.Account.Equals(P_1), P_2, P_3);
	}

	private static AdvancedTradingOperationResult 녴(Func<IOrder, bool> P_0, string P_1, GroupTradingOperation P_2)
	{
		AdvancedTradingOperationResult advancedTradingOperationResult = new AdvancedTradingOperationResult();
		foreach (IOrder item in from P_0 in 녴()
			where P_0 == null || P_0(P_0)
			select P_0)
		{
			CancelOrderRequestParameters cancelOrderRequestParameters = new CancelOrderRequestParameters
			{
				Order = item,
				SendingSource = P_1,
				ParentOperation = P_2
			};
			item.Symbol.Connection.Limitation?.Wait(cancelOrderRequestParameters.Type, cancelOrderRequestParameters.CancellationToken);
			TradingOperationResult tradingOperationResult = Core.Instance.CancelOrder(cancelOrderRequestParameters);
			advancedTradingOperationResult.녴(cancelOrderRequestParameters, tradingOperationResult);
		}
		return advancedTradingOperationResult;
	}

	private static IEnumerable<IOrder> 녴()
	{
		return Core.Instance.Orders.OfType<IOrder>().Concat(Core.Instance.LocalOrders);
	}

	/// <summary>
	/// Close all <see cref="T:TradingPlatform.BusinessLayer.Position" />s
	/// </summary>
	/// <param name="sendingSource">the name of the initiator of the call (optional)</param>
	/// <returns>List of <see cref="T:TradingPlatform.BusinessLayer.TradingOperationResult" /></returns>
	public AdvancedTradingOperationResult ClosePositions([CallerMemberName] string sendingSource = null)
	{
		Core.Instance.Loggers.Log(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴녮() + sendingSource);
		GroupTradingOperation groupTradingOperation = new GroupTradingOperation(GroupTradingOperationType.ClosePositions, GroupTradingOperationFilters.None);
		return 놴(sendingSource, groupTradingOperation);
	}

	/// <summary>
	/// Close all <see cref="T:TradingPlatform.BusinessLayer.Position" />s by <see cref="T:TradingPlatform.BusinessLayer.Symbol" />
	/// </summary>
	/// <param name="symbol"><see cref="T:TradingPlatform.BusinessLayer.Symbol" /></param>
	/// <param name="sendingSource">the name of the initiator of the call (optional)</param>
	/// <returns>List of <see cref="T:TradingPlatform.BusinessLayer.TradingOperationResult" /></returns>
	public AdvancedTradingOperationResult ClosePositions(Symbol symbol, [CallerMemberName] string sendingSource = null)
	{
		LoggerManager loggers = Core.Instance.Loggers;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(64, 2);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴뇆());
		defaultInterpolatedStringHandler.AppendFormatted(symbol);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴녠());
		defaultInterpolatedStringHandler.AppendFormatted(sendingSource);
		loggers.Log(defaultInterpolatedStringHandler.ToStringAndClear());
		GroupTradingOperation groupTradingOperation = new GroupTradingOperation(GroupTradingOperationType.ClosePositions, GroupTradingOperationFilters.Symbol);
		return 녴(symbol, sendingSource, groupTradingOperation);
	}

	/// <summary>
	/// Close all <see cref="T:TradingPlatform.BusinessLayer.Position" />s by <see cref="T:TradingPlatform.BusinessLayer.Account" />
	/// </summary>
	/// <param name="account"><see cref="T:TradingPlatform.BusinessLayer.Account" /></param>
	/// <param name="sendingSource">the name of the initiator of the call (optional)</param>
	/// <returns>List of <see cref="T:TradingPlatform.BusinessLayer.TradingOperationResult" /></returns>
	public AdvancedTradingOperationResult ClosePositions(Account account, [CallerMemberName] string sendingSource = null)
	{
		LoggerManager loggers = Core.Instance.Loggers;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(65, 2);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴뇉());
		defaultInterpolatedStringHandler.AppendFormatted(account);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴녠());
		defaultInterpolatedStringHandler.AppendFormatted(sendingSource);
		loggers.Log(defaultInterpolatedStringHandler.ToStringAndClear());
		GroupTradingOperation groupTradingOperation = new GroupTradingOperation(GroupTradingOperationType.ClosePositions, GroupTradingOperationFilters.Account);
		return 놂((Position P_0) => P_0.Account.Equals(account), sendingSource, groupTradingOperation);
	}

	/// <summary>
	/// Close all <see cref="T:TradingPlatform.BusinessLayer.Position" />s by <see cref="T:TradingPlatform.BusinessLayer.Symbol" /> and <see cref="T:TradingPlatform.BusinessLayer.Account" />
	/// </summary>
	/// <param name="symbol"><see cref="T:TradingPlatform.BusinessLayer.Symbol" /></param>
	/// <param name="account"><see cref="T:TradingPlatform.BusinessLayer.Account" /></param>
	/// <param name="sendingSource">the name of the initiator of the call (optional)</param>
	/// <returns>List of <see cref="T:TradingPlatform.BusinessLayer.TradingOperationResult" /></returns>
	public AdvancedTradingOperationResult ClosePositions(Symbol symbol, Account account, [CallerMemberName] string sendingSource = null)
	{
		LoggerManager loggers = Core.Instance.Loggers;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(76, 3);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴뇆());
		defaultInterpolatedStringHandler.AppendFormatted(symbol);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴놟());
		defaultInterpolatedStringHandler.AppendFormatted(account);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴녠());
		defaultInterpolatedStringHandler.AppendFormatted(sendingSource);
		loggers.Log(defaultInterpolatedStringHandler.ToStringAndClear());
		GroupTradingOperation groupTradingOperation = new GroupTradingOperation(GroupTradingOperationType.ClosePositions, GroupTradingOperationFilters.Symbol | GroupTradingOperationFilters.Account);
		return 놴(symbol, account, sendingSource, groupTradingOperation);
	}

	/// <summary>
	/// Close all <see cref="T:TradingPlatform.BusinessLayer.Position" />s by <see cref="T:TradingPlatform.BusinessLayer.Side" />
	/// </summary>
	/// <param name="side"><see cref="T:TradingPlatform.BusinessLayer.Side" /></param>
	/// <param name="sendingSource">the name of the initiator of the call (optional)</param>
	/// <returns>List of <see cref="T:TradingPlatform.BusinessLayer.TradingOperationResult" /></returns>
	public AdvancedTradingOperationResult ClosePositions(Side side, [CallerMemberName] string sendingSource = null)
	{
		LoggerManager loggers = Core.Instance.Loggers;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(62, 2);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴뇍());
		defaultInterpolatedStringHandler.AppendFormatted(side);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴녠());
		defaultInterpolatedStringHandler.AppendFormatted(sendingSource);
		loggers.Log(defaultInterpolatedStringHandler.ToStringAndClear());
		GroupTradingOperation groupTradingOperation = new GroupTradingOperation(GroupTradingOperationType.ClosePositions, GroupTradingOperationFilters.Side);
		return 놂((Position P_0) => P_0.Side == side, sendingSource, groupTradingOperation);
	}

	/// <summary>
	/// Close all <see cref="T:TradingPlatform.BusinessLayer.Position" />s by <see cref="T:TradingPlatform.BusinessLayer.Symbol" /> and <see cref="T:TradingPlatform.BusinessLayer.Side" />
	/// </summary>
	/// <param name="symbol"><see cref="T:TradingPlatform.BusinessLayer.Symbol" /></param>
	/// <param name="side"><see cref="T:TradingPlatform.BusinessLayer.Side" /></param>
	/// <param name="sendingSource">the name of the initiator of the call (optional)</param>
	/// <returns>List of <see cref="T:TradingPlatform.BusinessLayer.TradingOperationResult" /></returns>
	public AdvancedTradingOperationResult ClosePositions(Symbol symbol, Side side, [CallerMemberName] string sendingSource = null)
	{
		LoggerManager loggers = Core.Instance.Loggers;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(73, 3);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴뇆());
		defaultInterpolatedStringHandler.AppendFormatted(symbol);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴녓());
		defaultInterpolatedStringHandler.AppendFormatted(side);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴녠());
		defaultInterpolatedStringHandler.AppendFormatted(sendingSource);
		loggers.Log(defaultInterpolatedStringHandler.ToStringAndClear());
		GroupTradingOperation groupTradingOperation = new GroupTradingOperation(GroupTradingOperationType.ClosePositions, GroupTradingOperationFilters.Symbol | GroupTradingOperationFilters.Side);
		return 놂((Position P_0) => symbol.IsSameAs(P_0.Symbol) && P_0.Side == side, sendingSource, groupTradingOperation);
	}

	/// <summary>
	/// Close all positive <see cref="T:TradingPlatform.BusinessLayer.Position" />s
	/// </summary>
	/// <param name="sendingSource">the name of the initiator of the call (optional)</param>
	/// <returns>List of <see cref="T:TradingPlatform.BusinessLayer.TradingOperationResult" /></returns>
	public AdvancedTradingOperationResult ClosePositivePositions([CallerMemberName] string sendingSource = null)
	{
		Core.Instance.Loggers.Log(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴놙() + sendingSource);
		GroupTradingOperation groupTradingOperation = new GroupTradingOperation(GroupTradingOperationType.ClosePositions, GroupTradingOperationFilters.None);
		return 녴((Position P_0) => true, sendingSource, groupTradingOperation);
	}

	/// <summary>
	/// Close all positive <see cref="T:TradingPlatform.BusinessLayer.Position" />s by <see cref="T:TradingPlatform.BusinessLayer.Symbol" />
	/// </summary>
	/// <param name="symbol"><see cref="T:TradingPlatform.BusinessLayer.Symbol" /></param>
	/// <param name="sendingSource">the name of the initiator of the call (optional)</param>
	/// <returns>List of <see cref="T:TradingPlatform.BusinessLayer.TradingOperationResult" /></returns>
	public AdvancedTradingOperationResult ClosePositivePositions(Symbol symbol, [CallerMemberName] string sendingSource = null)
	{
		LoggerManager loggers = Core.Instance.Loggers;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(73, 2);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴녰());
		defaultInterpolatedStringHandler.AppendFormatted(symbol);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴녠());
		defaultInterpolatedStringHandler.AppendFormatted(sendingSource);
		loggers.Log(defaultInterpolatedStringHandler.ToStringAndClear());
		GroupTradingOperation groupTradingOperation = new GroupTradingOperation(GroupTradingOperationType.ClosePositions, GroupTradingOperationFilters.Symbol);
		return 녴((Position P_0) => symbol.IsSameAs(P_0.Symbol), sendingSource, groupTradingOperation);
	}

	/// <summary>
	/// Close all negative <see cref="T:TradingPlatform.BusinessLayer.Position" />s
	/// </summary>
	/// <param name="sendingSource">the name of the initiator of the call (optional)</param>
	/// <returns>List of <see cref="T:TradingPlatform.BusinessLayer.TradingOperationResult" /></returns>
	public AdvancedTradingOperationResult CloseNegativePositions([CallerMemberName] string sendingSource = null)
	{
		Core.Instance.Loggers.Log(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴놚() + sendingSource);
		GroupTradingOperation groupTradingOperation = new GroupTradingOperation(GroupTradingOperationType.ClosePositions, GroupTradingOperationFilters.None);
		return 놴((Position P_0) => true, sendingSource, groupTradingOperation);
	}

	/// <summary>
	/// Close all negative <see cref="T:TradingPlatform.BusinessLayer.Position" />s by <see cref="T:TradingPlatform.BusinessLayer.Symbol" />
	/// </summary>
	/// <param name="symbol"><see cref="T:TradingPlatform.BusinessLayer.Symbol" /></param>
	/// <param name="sendingSource">the name of the initiator of the call (optional)</param>
	/// <returns>List of <see cref="T:TradingPlatform.BusinessLayer.TradingOperationResult" /></returns>
	public AdvancedTradingOperationResult CloseNegativePositions(Symbol symbol, [CallerMemberName] string sendingSource = null)
	{
		LoggerManager loggers = Core.Instance.Loggers;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(73, 2);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴놹());
		defaultInterpolatedStringHandler.AppendFormatted(symbol);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴녠());
		defaultInterpolatedStringHandler.AppendFormatted(sendingSource);
		loggers.Log(defaultInterpolatedStringHandler.ToStringAndClear());
		GroupTradingOperation groupTradingOperation = new GroupTradingOperation(GroupTradingOperationType.ClosePositions, GroupTradingOperationFilters.Symbol);
		return 놴((Position P_0) => symbol.IsSameAs(P_0.Symbol), sendingSource, groupTradingOperation);
	}

	private static AdvancedTradingOperationResult 녴(Symbol P_0, string P_1, GroupTradingOperation P_2)
	{
		return 놂((Position P_0) => P_0.IsSameAs(P_0.Symbol), P_1, P_2);
	}

	private static AdvancedTradingOperationResult 놴(Symbol P_0, Account P_1, string P_2, GroupTradingOperation P_3)
	{
		return 놂((Position P_0) => P_0.IsSameAs(P_0.Symbol) && P_0.Account.Equals(P_1), P_2, P_3);
	}

	private static AdvancedTradingOperationResult 놴(string P_0, GroupTradingOperation P_1)
	{
		return 놂((Position P_0) => true, P_0, P_1);
	}

	private static AdvancedTradingOperationResult 녴(Func<Position, bool> P_0, string P_1, GroupTradingOperation P_2)
	{
		return 놂(delegate(Position P_0)
		{
			PnLItem pnLItem = P_0.NetPnL ?? P_0.GrossPnL;
			return pnLItem != null && pnLItem.Value > 0.0 && (P_0 == null || P_0(P_0));
		}, P_1, P_2);
	}

	private static AdvancedTradingOperationResult 놴(Func<Position, bool> P_0, string P_1, GroupTradingOperation P_2)
	{
		return 놂(delegate(Position P_0)
		{
			PnLItem pnLItem = P_0.NetPnL ?? P_0.GrossPnL;
			return pnLItem != null && pnLItem.Value < 0.0 && (P_0 == null || P_0(P_0));
		}, P_1, P_2);
	}

	private static AdvancedTradingOperationResult 놂(Func<Position, bool> P_0, string P_1, GroupTradingOperation P_2)
	{
		AdvancedTradingOperationResult advancedTradingOperationResult = new AdvancedTradingOperationResult();
		foreach (Position item in Core.Instance.Positions.Where((Position P_0) => P_0 == null || P_0(P_0)))
		{
			ClosePositionRequestParameters closePositionRequestParameters = new ClosePositionRequestParameters
			{
				Position = item,
				CloseQuantity = item.Quantity,
				SendingSource = P_1,
				ParentOperation = P_2
			};
			TradingOperationResult tradingOperationResult = Core.Instance.ClosePosition(closePositionRequestParameters);
			advancedTradingOperationResult.녴(closePositionRequestParameters, tradingOperationResult);
		}
		return advancedTradingOperationResult;
	}

	/// <summary>
	/// Reverse all <see cref="T:TradingPlatform.BusinessLayer.Position" />s
	/// </summary>
	/// <param name="sendingSource">the name of the initiator of the call (optional)</param>
	/// <returns>List of <see cref="T:TradingPlatform.BusinessLayer.TradingOperationResult" /></returns>
	public AdvancedTradingOperationResult ReversePositions([CallerMemberName] string sendingSource = null)
	{
		Core.Instance.Loggers.Log(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴놘() + sendingSource);
		GroupTradingOperation groupTradingOperation = new GroupTradingOperation(GroupTradingOperationType.ReversePositions, GroupTradingOperationFilters.None);
		return 놎((Position P_0) => true, sendingSource, groupTradingOperation);
	}

	/// <summary>
	/// Reverse all <see cref="T:TradingPlatform.BusinessLayer.Position" />s by <see cref="T:TradingPlatform.BusinessLayer.Symbol" />
	/// </summary>
	/// <param name="symbol"><see cref="T:TradingPlatform.BusinessLayer.Symbol" /></param>
	/// <param name="sendingSource">the name of the initiator of the call (optional)</param>
	/// <returns>List of <see cref="T:TradingPlatform.BusinessLayer.TradingOperationResult" /></returns>
	public AdvancedTradingOperationResult ReversePositions(Symbol symbol, [CallerMemberName] string sendingSource = null)
	{
		LoggerManager loggers = Core.Instance.Loggers;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(66, 2);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴뇌());
		defaultInterpolatedStringHandler.AppendFormatted(symbol);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴녠());
		defaultInterpolatedStringHandler.AppendFormatted(sendingSource);
		loggers.Log(defaultInterpolatedStringHandler.ToStringAndClear());
		GroupTradingOperation groupTradingOperation = new GroupTradingOperation(GroupTradingOperationType.ReversePositions, GroupTradingOperationFilters.Symbol);
		return 놎((Position P_0) => P_0.Symbol.IsSameAs(symbol), sendingSource, groupTradingOperation);
	}

	/// <summary>
	/// Reverse all <see cref="T:TradingPlatform.BusinessLayer.Position" />s by <see cref="T:TradingPlatform.BusinessLayer.Account" />
	/// </summary>
	/// <param name="account"><see cref="T:TradingPlatform.BusinessLayer.Account" /></param>
	/// <param name="sendingSource">the name of the initiator of the call (optional)</param>
	/// <returns>List of <see cref="T:TradingPlatform.BusinessLayer.TradingOperationResult" /></returns>
	public AdvancedTradingOperationResult ReversePositions(Account account, [CallerMemberName] string sendingSource = null)
	{
		LoggerManager loggers = Core.Instance.Loggers;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(67, 2);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴녷());
		defaultInterpolatedStringHandler.AppendFormatted(account);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴녠());
		defaultInterpolatedStringHandler.AppendFormatted(sendingSource);
		loggers.Log(defaultInterpolatedStringHandler.ToStringAndClear());
		GroupTradingOperation groupTradingOperation = new GroupTradingOperation(GroupTradingOperationType.ReversePositions, GroupTradingOperationFilters.Account);
		return 놎((Position P_0) => P_0.Account.Equals(account), sendingSource, groupTradingOperation);
	}

	/// <summary>
	/// Reverse <see cref="T:TradingPlatform.BusinessLayer.Position" /> by <see cref="T:TradingPlatform.BusinessLayer.Symbol" /> and <see cref="T:TradingPlatform.BusinessLayer.Account" />
	/// </summary>
	/// <param name="symbol"><see cref="T:TradingPlatform.BusinessLayer.Symbol" /></param>
	/// <param name="account"><see cref="T:TradingPlatform.BusinessLayer.Account" /></param>
	/// <param name="sendingSource">the name of the initiator of the call (optional)</param>
	/// <returns><see cref="T:TradingPlatform.BusinessLayer.TradingOperationResult" /></returns>
	public AdvancedTradingOperationResult ReversePosition(Symbol symbol, Account account, [CallerMemberName] string sendingSource = null)
	{
		LoggerManager loggers = Core.Instance.Loggers;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(78, 3);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴뇌());
		defaultInterpolatedStringHandler.AppendFormatted(symbol);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴놟());
		defaultInterpolatedStringHandler.AppendFormatted(account);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴녠());
		defaultInterpolatedStringHandler.AppendFormatted(sendingSource);
		loggers.Log(defaultInterpolatedStringHandler.ToStringAndClear());
		GroupTradingOperation groupTradingOperation = new GroupTradingOperation(GroupTradingOperationType.ReversePositions, GroupTradingOperationFilters.Symbol | GroupTradingOperationFilters.Account);
		return 놎((Position P_0) => P_0.Symbol.IsSameAs(symbol) && P_0.Account.Equals(account), sendingSource, groupTradingOperation);
	}

	private static AdvancedTradingOperationResult 놎(Func<Position, bool> P_0, string P_1, GroupTradingOperation P_2)
	{
		AdvancedTradingOperationResult advancedTradingOperationResult = new AdvancedTradingOperationResult();
		try
		{
			Position[] positions = Core.Instance.Positions;
			foreach (Position position in positions)
			{
				if ((position.Symbol.NettingType == NettingType.OnePosition || position.Symbol.NettingType == NettingType.Undefined || position.Account.NettingType == NettingType.OnePosition) && (P_0 == null || P_0(position)))
				{
					OrderType orderType = (Core.Instance.Connections[position.ConnectionId]?.BusinessObjects?.OrderTypes)?.FirstOrDefault((OrderType P_0) => P_0.Behavior == OrderTypeBehavior.Market && (P_0.Usage & OrderTypeUsage.Order) == OrderTypeUsage.Order);
					if (orderType != null)
					{
						PlaceOrderRequestParameters placeOrderRequestParameters = new PlaceOrderRequestParameters
						{
							Account = position.Account,
							Symbol = position.Symbol,
							OrderTypeId = orderType.Id,
							Quantity = position.Quantity * 2.0,
							TimeInForce = TimeInForce.Default,
							Side = ((position.Side == Side.Buy) ? Side.Sell : Side.Buy),
							SendingSource = P_1,
							ParentOperation = P_2
						};
						TradingOperationResult tradingOperationResult = Core.Instance.PlaceOrder(placeOrderRequestParameters);
						advancedTradingOperationResult.녴(placeOrderRequestParameters, tradingOperationResult);
					}
				}
			}
		}
		catch (Exception ex)
		{
			Core.Instance.Loggers.Log(ex);
		}
		return advancedTradingOperationResult;
	}

	/// <summary>
	/// Cancel all <see cref="T:TradingPlatform.BusinessLayer.Order" />s and close all <see cref="T:TradingPlatform.BusinessLayer.Position" />s
	/// </summary>
	/// <param name="sendingSource">the name of the initiator of the call (optional)</param>
	public AdvancedTradingOperationResult Flatten([CallerMemberName] string sendingSource = null)
	{
		Core.Instance.Loggers.Log(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴녟() + sendingSource);
		AdvancedTradingOperationResult advancedTradingOperationResult = new AdvancedTradingOperationResult();
		GroupTradingOperation groupTradingOperation = new GroupTradingOperation(GroupTradingOperationType.Flatten, GroupTradingOperationFilters.None);
		advancedTradingOperationResult.녴(녴(sendingSource, groupTradingOperation));
		녴((Symbol)null, (Account)null);
		advancedTradingOperationResult.녴(놴(sendingSource, groupTradingOperation));
		return advancedTradingOperationResult;
	}

	/// <summary>
	/// Cancel all <see cref="T:TradingPlatform.BusinessLayer.Order" />s and close all <see cref="T:TradingPlatform.BusinessLayer.Position" />s by <see cref="T:TradingPlatform.BusinessLayer.Symbol" />
	/// </summary>
	/// <param name="symbol"><see cref="T:TradingPlatform.BusinessLayer.Symbol" /></param>
	/// <param name="sendingSource">the name of the initiator of the call (optional)</param>
	public AdvancedTradingOperationResult Flatten(Symbol symbol, [CallerMemberName] string sendingSource = null)
	{
		LoggerManager loggers = Core.Instance.Loggers;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(56, 2);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴놱());
		defaultInterpolatedStringHandler.AppendFormatted(symbol);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴녠());
		defaultInterpolatedStringHandler.AppendFormatted(sendingSource);
		loggers.Log(defaultInterpolatedStringHandler.ToStringAndClear());
		AdvancedTradingOperationResult advancedTradingOperationResult = new AdvancedTradingOperationResult();
		GroupTradingOperation groupTradingOperation = new GroupTradingOperation(GroupTradingOperationType.Flatten, GroupTradingOperationFilters.Symbol);
		advancedTradingOperationResult.녴(녴(symbol, Array.Empty<IOrder>(), sendingSource, groupTradingOperation));
		녴(symbol);
		advancedTradingOperationResult.녴(녴(symbol, sendingSource, groupTradingOperation));
		return advancedTradingOperationResult;
	}

	/// <summary>
	/// Cancel all <see cref="T:TradingPlatform.BusinessLayer.Order" />s and close all <see cref="T:TradingPlatform.BusinessLayer.Position" />s by <see cref="T:TradingPlatform.BusinessLayer.Symbol" /> and <see cref="T:TradingPlatform.BusinessLayer.Account" />
	/// </summary>
	/// <param name="symbol"><see cref="T:TradingPlatform.BusinessLayer.Symbol" /></param>
	/// <param name="account"><see cref="T:TradingPlatform.BusinessLayer.Account" /></param>
	/// <param name="sendingSource">the name of the initiator of the call (optional)</param>
	public AdvancedTradingOperationResult Flatten(Symbol symbol, Account account, [CallerMemberName] string sendingSource = null)
	{
		LoggerManager loggers = Core.Instance.Loggers;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(68, 3);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴놱());
		defaultInterpolatedStringHandler.AppendFormatted(symbol);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴놟());
		defaultInterpolatedStringHandler.AppendFormatted(account);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴녠());
		defaultInterpolatedStringHandler.AppendFormatted(sendingSource);
		loggers.Log(defaultInterpolatedStringHandler.ToStringAndClear());
		AdvancedTradingOperationResult advancedTradingOperationResult = new AdvancedTradingOperationResult();
		GroupTradingOperation groupTradingOperation = new GroupTradingOperation(GroupTradingOperationType.Flatten, GroupTradingOperationFilters.Symbol | GroupTradingOperationFilters.Account);
		advancedTradingOperationResult.녴(녴(symbol, account, sendingSource, groupTradingOperation));
		녴(symbol, account);
		advancedTradingOperationResult.녴(놴(symbol, account, sendingSource, groupTradingOperation));
		return advancedTradingOperationResult;
	}

	private static void 녴(Symbol P_0 = null, Account P_1 = null)
	{
		try
		{
			CancellationTokenSource cancellationTokenSource = new CancellationTokenSource(TimeSpan.FromSeconds(5.0));
			while (!cancellationTokenSource.IsCancellationRequested && ((P_0 != null && P_1 != null) ? Core.Instance.Orders.Count((Order P_0) => P_0.Symbol.Equals(P_0) && P_0.Account.Equals(P_1)) : ((P_0 == null) ? Core.Instance.Orders.Length : Core.Instance.Orders.Count((Order P_0) => P_0.Symbol.Equals(P_0)))) != 0)
			{
				Task.Delay(50, cancellationTokenSource.Token).Wait(cancellationTokenSource.Token);
			}
			if (cancellationTokenSource.IsCancellationRequested)
			{
				Core.Instance.Loggers.Log(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴놖());
			}
		}
		catch (Exception ex)
		{
			Core.Instance.Loggers.Log(ex);
		}
	}

	/// <summary>
	/// Modify SL to breakeven price
	/// </summary>
	/// <param name="position"><see cref="T:TradingPlatform.BusinessLayer.Position" /></param>
	/// <param name="sendingSource">the name of the initiator of the call (optional)</param>
	public AdvancedTradingOperationResult BreakEven(Position position, [CallerMemberName] string sendingSource = null)
	{
		LoggerManager loggers = Core.Instance.Loggers;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(60, 2);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴놝());
		defaultInterpolatedStringHandler.AppendFormatted(position);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴녠());
		defaultInterpolatedStringHandler.AppendFormatted(sendingSource);
		loggers.Log(defaultInterpolatedStringHandler.ToStringAndClear());
		return 녴(position, 0, null, sendingSource);
	}

	/// <summary>
	/// Modify SL to breakeven price with certain additional offset
	/// </summary>
	/// <param name="position"><see cref="T:TradingPlatform.BusinessLayer.Position" /></param>
	/// <param name="offset">offset in ticks</param>
	/// <param name="sendingSource">the name of the initiator of the call (optional)</param>
	public AdvancedTradingOperationResult BreakEven(Position position, int offset, [CallerMemberName] string sendingSource = null)
	{
		LoggerManager loggers = Core.Instance.Loggers;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(71, 3);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴놝());
		defaultInterpolatedStringHandler.AppendFormatted(position);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴뇄());
		defaultInterpolatedStringHandler.AppendFormatted(offset);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴녠());
		defaultInterpolatedStringHandler.AppendFormatted(sendingSource);
		loggers.Log(defaultInterpolatedStringHandler.ToStringAndClear());
		return 녴(position, offset, null, sendingSource);
	}

	/// <summary>
	/// Modify SL to breakeven price
	/// </summary>
	/// <param name="position"><see cref="T:TradingPlatform.BusinessLayer.Position" /></param>
	/// <param name="additionalParameters">list of <see cref="T:TradingPlatform.BusinessLayer.SettingItem" />s that will be used for order placing</param>
	/// <param name="sendingSource">the name of the initiator of the call (optional)</param>
	public AdvancedTradingOperationResult BreakEven(Position position, IList<SettingItem> additionalParameters, [CallerMemberName] string sendingSource = null)
	{
		LoggerManager loggers = Core.Instance.Loggers;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(92, 3);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴놝());
		defaultInterpolatedStringHandler.AppendFormatted(position);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴녑());
		defaultInterpolatedStringHandler.AppendFormatted(additionalParameters?.Count);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴녠());
		defaultInterpolatedStringHandler.AppendFormatted(sendingSource);
		loggers.Log(defaultInterpolatedStringHandler.ToStringAndClear());
		return 녴(position, 0, additionalParameters, sendingSource);
	}

	private static AdvancedTradingOperationResult 녴(Position P_0, int P_1, IList<SettingItem> P_2, string P_3)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴놈());
		}
		if (P_0.Symbol.NettingType == NettingType.OnePosition || P_0.Account.NettingType == NettingType.OnePosition)
		{
			return 녴(P_0.Symbol, P_0.Account, P_1, P_2, P_3);
		}
		double num = 녴(P_0, P_1);
		double currentPrice = P_0.CurrentPrice;
		Order order = Core.Instance.Orders.Where((Order P_0) => P_0.PositionId == P_0.Id).FirstOrDefault(delegate(Order P_0)
		{
			OrderTypeBehavior behavior = P_0.OrderType.Behavior;
			return (uint)(behavior - 3) <= 1u;
		});
		if (order == null)
		{
			return AdvancedTradingOperationResult.녴(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴놬());
		}
		ModifyOrderRequestParameters modifyOrderRequestParameters = new ModifyOrderRequestParameters(order);
		if (order.OrderType.Behavior == OrderTypeBehavior.TrailingStop)
		{
			num = P_0.Symbol.CalculateTicks(currentPrice, num);
			modifyOrderRequestParameters.TrailOffset = num;
		}
		else
		{
			modifyOrderRequestParameters.TriggerPrice = num;
		}
		modifyOrderRequestParameters.SendingSource = P_3;
		TradingOperationResult tradingOperationResult = Core.Instance.ModifyOrder(modifyOrderRequestParameters);
		return new AdvancedTradingOperationResult(modifyOrderRequestParameters, tradingOperationResult);
	}

	private static AdvancedTradingOperationResult 녴(Symbol P_0, Account P_1, int P_2, IList<SettingItem> P_3, string P_4)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놻());
		}
		if (P_1 == null)
		{
			throw new ArgumentNullException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놡());
		}
		if (P_0.NettingType != NettingType.OnePosition && P_1.NettingType != NettingType.OnePosition)
		{
			return AdvancedTradingOperationResult.녴(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴놊());
		}
		OrderType orderType = P_0.Connection.BusinessObjects.OrderTypes.FirstOrDefault((OrderType P_0) => P_0.Behavior == OrderTypeBehavior.Stop);
		if (orderType == null)
		{
			return AdvancedTradingOperationResult.녴(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴놪());
		}
		Position 녵녒 = Core.Instance.Positions.FirstOrDefault((Position P_0) => P_0.ConnectionId == P_0.ConnectionId && P_0.IsSameAs(P_0.Symbol) && P_0.Account.Id == P_1.Id);
		if (녵녒 == null)
		{
			return AdvancedTradingOperationResult.녴(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴놌());
		}
		AdvancedTradingOperationResult advancedTradingOperationResult = new AdvancedTradingOperationResult();
		try
		{
			Order[] array = Core.Instance.Orders.Where((Order P_0) => P_0.ConnectionId == P_0.ConnectionId && P_0.IsSameAs(P_0.Symbol) && P_0.Account.Id == P_1.Id).ToArray();
			Order order = array.FirstOrDefault((Order P_0) => P_0.OrderType.Behavior == OrderTypeBehavior.Stop && P_0.Side != 녵녒.Side);
			if (order != null && !array.Any((Order P_0) => string.IsNullOrEmpty(P_0.GroupId)) && (from P_0 in array
				group P_0 by P_0.GroupId).Count() == 1)
			{
				ModifyOrderRequestParameters modifyOrderRequestParameters = new ModifyOrderRequestParameters(order)
				{
					TriggerPrice = 녴(녵녒, P_2),
					SendingSource = P_4
				};
				TradingOperationResult tradingOperationResult = Core.Instance.ModifyOrder(modifyOrderRequestParameters);
				advancedTradingOperationResult.녴(modifyOrderRequestParameters, tradingOperationResult);
			}
			else if (order != null && array.Count() % 2 == 0 && !array.Any((Order P_0) => string.IsNullOrEmpty(P_0.GroupId)) && (from P_0 in array
				group P_0 by P_0.GroupId).Count() * 2 == array.Count())
			{
				Order[] array2 = array.Where((Order P_0) => P_0.OrderType.Behavior == OrderTypeBehavior.Stop && P_0.Side != 녵녒.Side).ToArray();
				for (int i = 0; i < array2.Length; i++)
				{
					ModifyOrderRequestParameters modifyOrderRequestParameters2 = new ModifyOrderRequestParameters(array2[i])
					{
						TriggerPrice = 녴(녵녒, P_2),
						SendingSource = P_4
					};
					TradingOperationResult tradingOperationResult2 = Core.Instance.ModifyOrder(modifyOrderRequestParameters2);
					advancedTradingOperationResult.녴(modifyOrderRequestParameters2, tradingOperationResult2);
				}
			}
			else
			{
				TaskCompletionSource<OrderHistory> 녵녕 = new TaskCompletionSource<OrderHistory>();
				CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
				Action<OrderHistory> value = delegate(OrderHistory P_0)
				{
					OrderStatus status = P_0.Status;
					if ((status == OrderStatus.Opened || status == OrderStatus.Refused) ? true : false)
					{
						녵녕.SetResult(P_0);
					}
				};
				Core.Instance.OrdersHistoryAdded += value;
				cancellationTokenSource.CancelAfter(TimeSpan.FromSeconds(5.0));
				try
				{
					PlaceOrderRequestParameters placeOrderRequestParameters = new PlaceOrderRequestParameters
					{
						Account = 녵녒.Account,
						Symbol = 녵녒.Symbol,
						OrderTypeId = orderType.Id,
						TriggerPrice = 녴(녵녒, P_2),
						Side = ((녵녒.Side == Side.Buy) ? Side.Sell : Side.Buy),
						Quantity = 녵녒.Quantity,
						SendingSource = P_4
					};
					if (P_3 != null)
					{
						placeOrderRequestParameters.AdditionalParameters = P_3;
					}
					TradingOperationResult tradingOperationResult3 = Core.Instance.PlaceOrder(placeOrderRequestParameters);
					advancedTradingOperationResult.녴(placeOrderRequestParameters, tradingOperationResult3);
					if (tradingOperationResult3.Status == TradingOperationResultStatus.Failure)
					{
						return advancedTradingOperationResult;
					}
					CancellationToken token = cancellationTokenSource.Token;
					token.Register(delegate
					{
						녵녕.TrySetCanceled();
					});
					OrderHistory result = 녵녕.Task.Result;
					if (token.IsCancellationRequested)
					{
						return AdvancedTradingOperationResult.녴(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴놕());
					}
					if (result.Status == OrderStatus.Refused)
					{
						return AdvancedTradingOperationResult.녴(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴뇊());
					}
					Order[] array2 = array;
					foreach (Order order2 in array2)
					{
						CancelOrderRequestParameters cancelOrderRequestParameters = new CancelOrderRequestParameters
						{
							Order = order2,
							SendingSource = P_4
						};
						TradingOperationResult tradingOperationResult4 = Core.Instance.CancelOrder(cancelOrderRequestParameters);
						advancedTradingOperationResult.녴(cancelOrderRequestParameters, tradingOperationResult4);
					}
				}
				finally
				{
					Core.Instance.OrdersHistoryAdded -= value;
				}
			}
		}
		catch (Exception ex)
		{
			Core.Instance.Loggers.Log(ex);
		}
		return advancedTradingOperationResult;
	}

	private static double 녴(Position P_0, int P_1)
	{
		if (P_0 == null)
		{
			return double.NaN;
		}
		double num = P_0.OpenPrice;
		decimal num2 = (decimal)P_0.Symbol.RoundPriceToTickSize(P_0.OpenPrice);
		if ((decimal)P_0.OpenPrice != num2)
		{
			decimal num3 = ((!(num2 < (decimal)P_0.OpenPrice)) ? ((P_0.Side == Side.Buy) ? num2 : ((decimal)P_0.Symbol.CalculatePrice((double)num2, -1.0))) : ((P_0.Side == Side.Buy) ? ((decimal)P_0.Symbol.CalculatePrice((double)num2, 1.0)) : num2));
			num = (double)num3;
		}
		if (P_1 != 0)
		{
			num = P_0.Symbol.CalculatePrice(num, (P_0.Side == Side.Buy) ? P_1 : (-P_1));
		}
		return num;
	}

	/// <summary>
	/// Adjust SL/TP for given <see cref="T:TradingPlatform.BusinessLayer.Position" />
	/// </summary>
	/// <param name="position"><see cref="T:TradingPlatform.BusinessLayer.Position" /></param>
	/// <param name="cancellationToken"><see cref="T:System.Threading.CancellationToken" /></param>
	/// <param name="sendingSource">the name of the initiator of the call (optional)</param>
	public AdvancedTradingOperationResult AdjustSlTp(Position position, CancellationToken cancellationToken = default(CancellationToken), [CallerMemberName] string sendingSource = null)
	{
		if (position == null)
		{
			throw new ArgumentNullException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴놈());
		}
		Symbol 녵녖 = position.Symbol;
		List<Order> list = Core.Instance.Orders.Where((Order P_0) => 녵녖.IsSameAs(P_0.Symbol) && P_0.Account.Equals(position.Account) && P_0.Side != position.Side && ((P_0.Side != 0) ? (P_0.GetExecutionPrice() < position.OpenPrice) : (P_0.GetExecutionPrice() > position.OpenPrice))).ToList();
		List<Order> list2 = Core.Instance.Orders.Where((Order P_0) => 녵녖.IsSameAs(P_0.Symbol) && P_0.Account.Equals(position.Account) && P_0.Side != position.Side && ((P_0.Side != 0) ? (P_0.GetExecutionPrice() > position.OpenPrice) : (P_0.GetExecutionPrice() < position.OpenPrice))).ToList();
		if (!list.Any() && !list2.Any())
		{
			return AdvancedTradingOperationResult.녴(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴놋());
		}
		LoggerManager loggers = Core.Instance.Loggers;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(63, 2);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴녣());
		defaultInterpolatedStringHandler.AppendFormatted(position);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴녠());
		defaultInterpolatedStringHandler.AppendFormatted(sendingSource);
		loggers.Log(defaultInterpolatedStringHandler.ToStringAndClear());
		AdvancedTradingOperationResult advancedTradingOperationResult = null;
		AdvancedTradingOperationResult advancedTradingOperationResult2 = null;
		AdvancedTradingOperationResult advancedTradingOperationResult3 = new AdvancedTradingOperationResult();
		try
		{
			if (list.Any())
			{
				advancedTradingOperationResult = 녴(new 녴
				{
					Position = position,
					Brackets = list
				}, cancellationToken, sendingSource);
			}
			else if (list2.Count > 1)
			{
				List<Order> list3 = list2.OrderBy((Order P_0) => P_0.GetExecutionPrice()).ToList();
				Order 놭놴 = ((position.Side == Side.Buy) ? list3.First() : list3.Last());
				list3.Remove(놭놴);
				if (list3.All((Order P_0) => P_0.OrderTypeId != 놭놴.OrderTypeId))
				{
					list2.Remove(놭놴);
					advancedTradingOperationResult = 녴(new 녴
					{
						Position = position,
						Brackets = new List<Order> { 놭놴 }
					}, cancellationToken, sendingSource);
				}
			}
			if (list2.Any())
			{
				advancedTradingOperationResult2 = 놴(new 녴
				{
					Position = position,
					Brackets = list2
				}, cancellationToken, sendingSource);
			}
			if (advancedTradingOperationResult == null)
			{
				return AdvancedTradingOperationResult.녴(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴녩());
			}
			if (advancedTradingOperationResult2 == null)
			{
				return AdvancedTradingOperationResult.녴(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴놤());
			}
			advancedTradingOperationResult3.녴(advancedTradingOperationResult).녴(advancedTradingOperationResult2);
			if (!(advancedTradingOperationResult.Value is string orderId) || !(advancedTradingOperationResult2.Value is string orderId2) || Core.Instance.RulesManager.IsAllowed(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴논(), position.Account, position.Symbol).Status != 0)
			{
				return advancedTradingOperationResult3;
			}
			Order order = null;
			Order order2 = null;
			CancellationTokenSource cancellationTokenSource = new CancellationTokenSource(TimeSpan.FromSeconds(5.0));
			while ((order == null || order2 == null) && !cancellationTokenSource.IsCancellationRequested)
			{
				order = Core.Instance.GetOrderById(orderId, position.ConnectionId);
				order2 = Core.Instance.GetOrderById(orderId2, position.ConnectionId);
				Task.Delay(100, cancellationTokenSource.Token).Wait(cancellationTokenSource.Token);
			}
			if (order == null || order2 == null)
			{
				return advancedTradingOperationResult3;
			}
			Core instance = Core.Instance;
			string connectionId = position.ConnectionId;
			LinkOCORequestParameters linkOCORequestParameters = new LinkOCORequestParameters();
			int num = 2;
			List<IOrder> list4 = new List<IOrder>(num);
			CollectionsMarshal.SetCount(list4, num);
			Span<IOrder> span = CollectionsMarshal.AsSpan(list4);
			int num2 = 0;
			span[num2] = order;
			num2++;
			span[num2] = order2;
			linkOCORequestParameters.OrdersToLink = list4;
			linkOCORequestParameters.CancellationToken = cancellationToken;
			instance.SendCustomRequest(connectionId, linkOCORequestParameters);
		}
		catch (Exception ex)
		{
			Core.Instance.Loggers.Log(ex);
		}
		return advancedTradingOperationResult3;
	}

	/// <summary>
	/// Adjust stop loss for given <see cref="T:TradingPlatform.BusinessLayer.Position" />
	/// </summary>
	/// <param name="position"><see cref="T:TradingPlatform.BusinessLayer.Position" /></param>
	/// <param name="stops">list of <see cref="T:TradingPlatform.BusinessLayer.Order" />s</param>
	/// <param name="initialStopLoss">initial stop loss parameters (optional)</param>
	/// <param name="cancellationToken"><see cref="T:System.Threading.CancellationToken" /></param>
	/// <param name="sendingSource">the name of the initiator of the call (optional)</param>
	/// <returns></returns>
	public AdvancedTradingOperationResult AdjustStopLoss(Position position, IList<Order> stops, SlTpHolder initialStopLoss = null, CancellationToken cancellationToken = default(CancellationToken), [CallerMemberName] string sendingSource = null)
	{
		LoggerManager loggers = Core.Instance.Loggers;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(97, 4);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴녘());
		defaultInterpolatedStringHandler.AppendFormatted(position);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴노());
		defaultInterpolatedStringHandler.AppendFormatted(stops.Count);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴녒());
		defaultInterpolatedStringHandler.AppendFormatted(initialStopLoss);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴녠());
		defaultInterpolatedStringHandler.AppendFormatted(sendingSource);
		loggers.Log(defaultInterpolatedStringHandler.ToStringAndClear());
		return 녴(new 녴
		{
			Position = position,
			Brackets = stops,
			InitialBracketParameters = initialStopLoss
		}, cancellationToken, sendingSource);
	}

	/// <summary>
	/// Adjust take profit for given <see cref="T:TradingPlatform.BusinessLayer.Position" />
	/// </summary>
	/// <param name="position"><see cref="T:TradingPlatform.BusinessLayer.Position" /></param>
	/// <param name="takes">list of <see cref="T:TradingPlatform.BusinessLayer.Order" />s</param>
	/// <param name="initialTakeProfit">initial take profit parameters (optional)</param>
	/// <param name="cancellationToken"><see cref="T:System.Threading.CancellationToken" /></param>
	/// <param name="sendingSource">the name of the initiator of the call (optional)</param>
	/// <returns></returns>
	public AdvancedTradingOperationResult AdjustTakeProfit(Position position, IList<Order> takes, SlTpHolder initialTakeProfit, CancellationToken cancellationToken = default(CancellationToken), [CallerMemberName] string sendingSource = null)
	{
		LoggerManager loggers = Core.Instance.Loggers;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(101, 4);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴녕());
		defaultInterpolatedStringHandler.AppendFormatted(position);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴녖());
		defaultInterpolatedStringHandler.AppendFormatted(takes.Count);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂녴());
		defaultInterpolatedStringHandler.AppendFormatted(initialTakeProfit);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴녠());
		defaultInterpolatedStringHandler.AppendFormatted(sendingSource);
		loggers.Log(defaultInterpolatedStringHandler.ToStringAndClear());
		return 놴(new 녴
		{
			Position = position,
			Brackets = takes,
			InitialBracketParameters = initialTakeProfit
		}, cancellationToken, sendingSource);
	}

	private static AdvancedTradingOperationResult 녴(녴 P_0, CancellationToken P_1, string P_2)
	{
		AdvancedTradingOperationResult advancedTradingOperationResult = new AdvancedTradingOperationResult();
		Position position = P_0.Position;
		IList<Order> brackets = P_0.Brackets;
		SlTpHolder initialBracketParameters = P_0.InitialBracketParameters;
		double quantity = position.Quantity;
		double num = 녴(position, brackets, initialBracketParameters);
		List<Order> source = brackets.Where((Order P_0) => string.IsNullOrEmpty(P_0.GroupId)).ToList();
		if (source.Any())
		{
			Order 놭놂 = source.Aggregate((Order P_0, Order P_1) => (!(P_0.RemainingQuantity > P_1.RemainingQuantity)) ? P_1 : P_0);
			advancedTradingOperationResult.녴(녴(brackets.Where((Order P_0) => P_0.Id != 놭놂.Id).ToList(), P_1, P_2));
			if (Math.Abs(놭놂.RemainingQuantity - quantity) > double.Epsilon || Math.Abs(놭놂.GetExecutionPrice() - num) > double.Epsilon)
			{
				ModifyOrderRequestParameters modifyOrderRequestParameters = new ModifyOrderRequestParameters(놭놂)
				{
					Quantity = quantity,
					CancellationToken = P_1,
					SendingSource = P_2
				};
				modifyOrderRequestParameters.SetExecutionPrice(num);
				TradingOperationResult tradingOperationResult = 녴(modifyOrderRequestParameters);
				advancedTradingOperationResult.녴(modifyOrderRequestParameters, tradingOperationResult);
				if (tradingOperationResult.Status != 0)
				{
					return advancedTradingOperationResult;
				}
				advancedTradingOperationResult.Value = tradingOperationResult.OrderId;
			}
			else
			{
				advancedTradingOperationResult.Value = 놭놂.Id;
			}
		}
		else
		{
			PlaceOrderRequestParameters placeOrderRequestParameters = new PlaceOrderRequestParameters(brackets.FirstOrDefault())
			{
				Quantity = quantity,
				CancellationToken = P_1,
				GroupId = string.Empty,
				SendingSource = P_2
			};
			advancedTradingOperationResult.녴(녴(brackets, P_1, P_2));
			placeOrderRequestParameters.SetExecutionPrice(num);
			TradingOperationResult tradingOperationResult2 = 녴(placeOrderRequestParameters);
			if (tradingOperationResult2.Status != 0)
			{
				return advancedTradingOperationResult;
			}
			advancedTradingOperationResult.녴(placeOrderRequestParameters, tradingOperationResult2);
			advancedTradingOperationResult.Value = tradingOperationResult2.OrderId;
		}
		return advancedTradingOperationResult;
	}

	private static AdvancedTradingOperationResult 놴(녴 P_0, CancellationToken P_1, string P_2)
	{
		AdvancedTradingOperationResult advancedTradingOperationResult = new AdvancedTradingOperationResult();
		Position position = P_0.Position;
		IList<Order> brackets = P_0.Brackets;
		SlTpHolder initialBracketParameters = P_0.InitialBracketParameters;
		double quantity = position.Quantity;
		double num = 놴(position, brackets, initialBracketParameters);
		if (double.IsNaN(num))
		{
			return AdvancedTradingOperationResult.녴(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놴());
		}
		List<Order> source = brackets.Where((Order P_0) => string.IsNullOrEmpty(P_0.GroupId)).ToList();
		if (source.Any())
		{
			Order 놭놎 = source.Aggregate((Order P_0, Order P_1) => (!(P_0.RemainingQuantity > P_1.RemainingQuantity)) ? P_1 : P_0);
			advancedTradingOperationResult.녴(녴(brackets.Where((Order P_0) => P_0.Id != 놭놎.Id).ToList(), P_1, P_2));
			if (Math.Abs(놭놎.RemainingQuantity - quantity) > double.Epsilon || Math.Abs(놭놎.GetExecutionPrice() - num) > double.Epsilon)
			{
				ModifyOrderRequestParameters modifyOrderRequestParameters = new ModifyOrderRequestParameters(놭놎)
				{
					Quantity = quantity,
					CancellationToken = P_1,
					SendingSource = P_2
				};
				modifyOrderRequestParameters.SetExecutionPrice(num);
				TradingOperationResult tradingOperationResult = 녴(modifyOrderRequestParameters);
				advancedTradingOperationResult.녴(modifyOrderRequestParameters, tradingOperationResult);
				if (tradingOperationResult.Status != 0)
				{
					return advancedTradingOperationResult;
				}
				advancedTradingOperationResult.Value = tradingOperationResult.OrderId;
			}
			else
			{
				advancedTradingOperationResult.Value = 놭놎.Id;
			}
		}
		else
		{
			PlaceOrderRequestParameters placeOrderRequestParameters = new PlaceOrderRequestParameters(brackets.FirstOrDefault())
			{
				Quantity = quantity,
				CancellationToken = P_1,
				GroupId = string.Empty,
				SendingSource = P_2
			};
			advancedTradingOperationResult.녴(녴(brackets, P_1, P_2));
			placeOrderRequestParameters.SetExecutionPrice(num);
			TradingOperationResult tradingOperationResult2 = 녴(placeOrderRequestParameters);
			advancedTradingOperationResult.녴(placeOrderRequestParameters, tradingOperationResult2);
			if (tradingOperationResult2.Status != 0)
			{
				return advancedTradingOperationResult;
			}
			advancedTradingOperationResult.Value = tradingOperationResult2.OrderId;
		}
		return advancedTradingOperationResult;
	}

	private static double 녴(Position P_0, IEnumerable<Order> P_1, SlTpHolder P_2 = null)
	{
		if (P_2 != null)
		{
			if (P_2.PriceMeasurement != 0)
			{
				return P_0.Symbol.RoundPriceToTickSize(P_0.Symbol.CalculatePrice(P_0.OpenPrice, (double)((P_0.Side != 0) ? 1 : (-1)) * P_2.Price));
			}
			return P_2.Price;
		}
		if (P_0.Side != 0)
		{
			return P_1.Min((Order P_0) => P_0.GetExecutionPrice());
		}
		return P_1.Max((Order P_0) => P_0.GetExecutionPrice());
	}

	private static double 놴(Position P_0, IEnumerable<Order> P_1, SlTpHolder P_2 = null)
	{
		if (P_2 != null)
		{
			if (P_2.PriceMeasurement != 0)
			{
				return P_0.Symbol.RoundPriceToTickSize(P_0.Symbol.CalculatePrice(P_0.OpenPrice, (double)((P_0.Side == Side.Buy) ? 1 : (-1)) * P_2.Price));
			}
			return P_2.Price;
		}
		return CoreMath.GetWeightedAverage(P_1.Select((Order P_0) => (P_0.GetExecutionPrice(), P_0.RemainingQuantity)), P_0.Symbol);
	}

	private static TradingOperationResult 녴(PlaceOrderRequestParameters P_0)
	{
		ManualResetEventSlim 놭녞 = new ManualResetEventSlim();
		string 놭놫 = null;
		try
		{
			Core.Instance.OrderAdded += delegate(Order P_0)
			{
				if (!놭녞.IsSet)
				{
					if (!string.IsNullOrEmpty(놭놫) && P_0.Id == 놭놫)
					{
						놭녞.Set();
					}
					else if (P_0.IsCorrespondingOrder(P_0))
					{
						놭녞.Set();
					}
				}
			};
			Core.Instance.Connections[P_0.ConnectionId]?.Limitation?.Wait(P_0.Type, P_0.CancellationToken);
			TradingOperationResult tradingOperationResult = Core.Instance.PlaceOrder(P_0);
			if (tradingOperationResult != null && tradingOperationResult.Status == TradingOperationResultStatus.Failure)
			{
				return tradingOperationResult;
			}
			놭놫 = tradingOperationResult.OrderId;
			놭녞.Wait(TimeSpan.FromSeconds(5.0));
			return tradingOperationResult;
		}
		catch (Exception ex)
		{
			Core.Instance.Loggers.Log(ex);
		}
		finally
		{
			Core.Instance.OrderAdded -= delegate(Order P_0)
			{
				if (!놭녞.IsSet)
				{
					if (!string.IsNullOrEmpty(놭놫) && P_0.Id == 놭놫)
					{
						놭녞.Set();
					}
					else if (P_0.IsCorrespondingOrder(P_0))
					{
						놭녞.Set();
					}
				}
			};
		}
		return null;
	}

	private static TradingOperationResult 녴(ModifyOrderRequestParameters P_0)
	{
		ManualResetEventSlim 놭녶 = new ManualResetEventSlim();
		try
		{
			Core.Instance.OrderAdded += delegate(Order P_0)
			{
				if (!놭녶.IsSet && P_0.IsCorrespondingOrder(P_0))
				{
					놭녶.Set();
				}
			};
			Core.Instance.Connections[P_0.ConnectionId]?.Limitation?.Wait(P_0.Type, P_0.CancellationToken);
			TradingOperationResult tradingOperationResult = Core.Instance.ModifyOrder(P_0);
			if (tradingOperationResult != null && tradingOperationResult.Status == TradingOperationResultStatus.Failure)
			{
				return tradingOperationResult;
			}
			놭녶.Wait(TimeSpan.FromSeconds(5.0));
			return tradingOperationResult;
		}
		catch (Exception ex)
		{
			Core.Instance.Loggers.Log(ex);
		}
		finally
		{
			Core.Instance.OrderAdded -= delegate(Order P_0)
			{
				if (!놭녶.IsSet && P_0.IsCorrespondingOrder(P_0))
				{
					놭녶.Set();
				}
			};
		}
		return null;
	}

	private static AdvancedTradingOperationResult 녴(IList<Order> P_0, CancellationToken P_1, string P_2)
	{
		if (!P_0.Any())
		{
			return AdvancedTradingOperationResult.녴();
		}
		AdvancedTradingOperationResult advancedTradingOperationResult = new AdvancedTradingOperationResult();
		ManualResetEvent 놭녲 = new ManualResetEvent(initialState: false);
		HashSet<string> 놭놭 = new HashSet<string>(P_0.Select((Order P_0) => P_0.Id));
		try
		{
			Core.Instance.OrderRemoved += delegate(Order P_0)
			{
				놭놭.Remove(P_0.Id);
				if (놭놭.Count == 0)
				{
					놭녲.Set();
				}
			};
			foreach (Order item in P_0)
			{
				CancelOrderRequestParameters cancelOrderRequestParameters = new CancelOrderRequestParameters
				{
					Order = item,
					CancellationToken = P_1,
					SendingSource = P_2
				};
				item.Connection.Limitation?.Wait(cancelOrderRequestParameters.Type, cancelOrderRequestParameters.CancellationToken);
				TradingOperationResult tradingOperationResult = Core.Instance.CancelOrder(cancelOrderRequestParameters);
				if (tradingOperationResult != null && tradingOperationResult.Status == TradingOperationResultStatus.Failure)
				{
					놭놭.Remove(item.Id);
				}
				advancedTradingOperationResult.녴(cancelOrderRequestParameters, tradingOperationResult);
			}
			if (!놭놭.Any())
			{
				놭녲.Set();
			}
			놭녲.WaitOne(TimeSpan.FromSeconds(5.0));
			return advancedTradingOperationResult;
		}
		finally
		{
			Core.Instance.OrderRemoved -= delegate(Order P_0)
			{
				놭놭.Remove(P_0.Id);
				if (놭놭.Count == 0)
				{
					놭녲.Set();
				}
			};
		}
	}
}
