using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using TradingPlatform.BusinessLayer.Integration;
using TradingPlatform.BusinessLayer.Licence;
using TradingPlatform.BusinessLayer.LocalOrders;
using TradingPlatform.BusinessLayer.Media.Messengers;
using TradingPlatform.BusinessLayer.Settings.OTP;
using TradingPlatform.BusinessLayer.Utils;
using TradingPlatform.BusinessLayer.Utils.TradingProtection;
using 녴;

namespace TradingPlatform.BusinessLayer;

/// <summary>
/// The main entry point in the API. Core keeps access to all business logic entities and their properties:
/// connections, accounts, symbols, positions, orders, etc. Some of them can be reached through using managers or directly via specified collections.
/// You can always access the Core object via static Core.Instance property.
/// </summary>
[Published]
public class Core : IDisposable, IBusinessObjectsProvider
{
	[Serializable]
	[CompilerGenerated]
	private sealed class 녴
	{
		public static readonly 녴 놓놕 = new 녴();

		public static Func<Connection, IEnumerable<Symbol>> 놓뇊;

		public static Func<Connection, IEnumerable<SymbolType>> 놓놋;

		public static Func<Connection, IEnumerable<Account>> 놓녣;

		public static Func<Connection, IEnumerable<Asset>> 놓녩;

		public static Func<Connection, IEnumerable<Exchange>> 놓놤;

		public static Func<Connection, IEnumerable<Order>> 놓논;

		public static Func<Connection, IEnumerable<OrderType>> 놓녘;

		public static Func<Connection, IEnumerable<Position>> 놓노;

		public static Func<Connection, IEnumerable<ClosedPosition>> 놓녒;

		public static Func<Connection, IEnumerable<CorporateAction>> 놓녕;

		public static Func<Connection, IEnumerable<ReportType>> 놓녖;

		public static Func<Connection, IEnumerable<AccountOperation>> 놇녴;

		public static Func<Connection, IEnumerable<TradingSignal>> 놇놴;

		public static Func<Connection, bool> 놇놂;

		public static Func<Connection, bool> 놇놎;

		public static Func<Connection, bool> 놇녞;

		public static Func<Connection, bool> 놇놫;

		public static Func<PlaceOrderRequestParameters, string> 놇녪;

		public static Func<Connection, IEnumerable<DeliveredAsset>> 놇녶;

		public static Func<Connection, bool> 놇녵;

		public static Func<Connection, bool> 놇놭;

		internal IEnumerable<Symbol> 녴(Connection P_0)
		{
			return P_0.BusinessObjects.Symbols;
		}

		internal IEnumerable<SymbolType> 놴(Connection P_0)
		{
			return P_0.BusinessObjects.SymbolTypes;
		}

		internal IEnumerable<Account> 놂(Connection P_0)
		{
			return P_0.BusinessObjects.Accounts;
		}

		internal IEnumerable<Asset> 놎(Connection P_0)
		{
			return P_0.BusinessObjects.Assets;
		}

		internal IEnumerable<Exchange> 녞(Connection P_0)
		{
			return P_0.BusinessObjects.Exchanges;
		}

		internal IEnumerable<Order> 놫(Connection P_0)
		{
			return P_0.BusinessObjects.Orders;
		}

		internal IEnumerable<OrderType> 녪(Connection P_0)
		{
			return P_0.BusinessObjects.OrderTypes;
		}

		internal IEnumerable<Position> 녶(Connection P_0)
		{
			return P_0.BusinessObjects.Positions;
		}

		internal IEnumerable<ClosedPosition> 녵(Connection P_0)
		{
			return P_0.BusinessObjects.ClosedPositions;
		}

		internal IEnumerable<CorporateAction> 놭(Connection P_0)
		{
			return P_0.BusinessObjects.CorporateActions;
		}

		internal IEnumerable<ReportType> 녲(Connection P_0)
		{
			return P_0.BusinessObjects.ReportTypes;
		}

		internal IEnumerable<AccountOperation> 뇋(Connection P_0)
		{
			return P_0.BusinessObjects.AccountOperations;
		}

		internal IEnumerable<TradingSignal> 놸(Connection P_0)
		{
			return P_0.BusinessObjects.TradingSignals;
		}

		internal bool 놿(Connection P_0)
		{
			return P_0.Connected;
		}

		internal bool 놄(Connection P_0)
		{
			return P_0.Connected;
		}

		internal bool 놰(Connection P_0)
		{
			return P_0.Connected;
		}

		internal bool 놓(Connection P_0)
		{
			return P_0.Connected;
		}

		internal string 녴(PlaceOrderRequestParameters P_0)
		{
			return P_0.ConnectionId;
		}

		internal IEnumerable<DeliveredAsset> 놇(Connection P_0)
		{
			return P_0.BusinessObjects.DeliveredAssets;
		}

		internal bool 뇅(Connection P_0)
		{
			if (P_0 != null)
			{
				string vendorName = P_0.VendorName;
				if (vendorName == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵녖() || vendorName == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭녴() || vendorName == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭놴())
				{
					return true;
				}
			}
			return false;
		}

		internal bool 놵(Connection P_0)
		{
			if (P_0 != null)
			{
				string vendorName = P_0.VendorName;
				if (vendorName == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵녖() || vendorName == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭녴() || vendorName == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭놴())
				{
					return true;
				}
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class 놴
	{
		public BusinessObjectInfo 놇녲;

		internal bool 녴(Account P_0)
		{
			return P_0.Id == 놇녲.Id;
		}
	}

	[CompilerGenerated]
	private sealed class 놂
	{
		public GetSymbolRequestParameters 놇뇋;

		internal bool 녴(Synthetic P_0)
		{
			return P_0.Id == 놇뇋.SymbolId;
		}

		internal bool 녴(HistoricalSymbol P_0)
		{
			return P_0.Id == 놇뇋.SymbolId;
		}
	}

	[CompilerGenerated]
	private sealed class 놎
	{
		public string 놇놸;

		internal bool 녴(OrderType P_0)
		{
			return P_0.Id == 놇놸;
		}

		internal bool 놴(OrderType P_0)
		{
			return P_0.Id == 놇놸;
		}
	}

	[CompilerGenerated]
	private sealed class 녞
	{
		public string 놇놿;

		internal bool 녴(Connection P_0)
		{
			return P_0.Id == 놇놿;
		}
	}

	[CompilerGenerated]
	private sealed class 놫
	{
		public ModifyOrderRequestParameters 놇놄;

		internal bool 녴(Connection P_0)
		{
			return P_0.Id == 놇놄.ConnectionId;
		}
	}

	[CompilerGenerated]
	private sealed class 녪
	{
		public ClosePositionRequestParameters 놇놰;

		internal bool 녴(Connection P_0)
		{
			return P_0.Id == 놇놰.ConnectionId;
		}
	}

	[CompilerGenerated]
	private sealed class 녶
	{
		public CancelOrderRequestParameters 놇놓;

		internal bool 녴(Connection P_0)
		{
			return P_0.Id == 놇놓.ConnectionId;
		}
	}

	[CompilerGenerated]
	private sealed class 녵
	{
		public string 놇놇;

		internal bool 녴(Connection P_0)
		{
			return P_0.Id == 놇놇;
		}
	}

	[CompilerGenerated]
	private sealed class 놭
	{
		public HistoricalSymbol 놇뇅;

		internal bool 녴(HistoricalSymbol P_0)
		{
			return P_0.Id == 놇뇅.Id;
		}
	}

	private static Core 녪녹;

	[CompilerGenerated]
	private readonly ConnectionsManager 녪녔;

	[CompilerGenerated]
	private readonly LoggerManager 녪녠;

	[CompilerGenerated]
	private readonly LicencesManager 녪놠;

	[CompilerGenerated]
	private readonly VendorManager 녪놟;

	[CompilerGenerated]
	private readonly HistoryAggregationManager 녪녓;

	[CompilerGenerated]
	private readonly VolumeAnalysisManager 녪녛;

	[CompilerGenerated]
	private readonly IndicatorManager 녪녽;

	[CompilerGenerated]
	private readonly StrategyManager 녪놏;

	[CompilerGenerated]
	private readonly OrderPlacingStrategiesManager 녪녥;

	[CompilerGenerated]
	private readonly MessengersManager 녪농;

	[CompilerGenerated]
	private readonly LocalOrdersManager 녪념;

	[CompilerGenerated]
	private readonly RulesManager 녪녨;

	[CompilerGenerated]
	private readonly SymbolsMappingManager 녪녺;

	[CompilerGenerated]
	private readonly CustomSessionsManager 녪놣;

	[CompilerGenerated]
	private readonly TimeUtils 녪녮;

	[CompilerGenerated]
	private readonly MailUtils 녪뇆;

	[CompilerGenerated]
	private readonly TradingProtector 녪뇉;

	[CompilerGenerated]
	private IBrandingInformation 녪뇍;

	private TradingStatus 녪놙;

	[CompilerGenerated]
	private Action<TradingStatus> 녪녰;

	[CompilerGenerated]
	private 놃<int, CustomMessage> 녪놚;

	[CompilerGenerated]
	private bool 녪놹;

	[CompilerGenerated]
	private CustomAccountPropertiesProvider 녪놘;

	[CompilerGenerated]
	private Action<Account> 녪뇌;

	[CompilerGenerated]
	private Action<Symbol> 녪녷;

	[CompilerGenerated]
	private Action<Order> 녪녟;

	[CompilerGenerated]
	private Action<Order> 녪놱;

	[CompilerGenerated]
	private Action<Position> 녪놖;

	[CompilerGenerated]
	private Action<Position> 녪놝;

	[CompilerGenerated]
	private Action<ClosedPosition> 녪뇄;

	[CompilerGenerated]
	private Action<ClosedPosition> 녪녑;

	[CompilerGenerated]
	private Action<Trade> 녪놈;

	[CompilerGenerated]
	private Action<CorporateAction> 녪놬;

	[CompilerGenerated]
	private Action<OrderHistory> 녪놊;

	[CompilerGenerated]
	private AdvancedTradingOperations 녪놪;

	[CompilerGenerated]
	private Action<DeliveredAsset> 녪놌;

	[CompilerGenerated]
	private Action<DeliveredAsset> 녪놕;

	[CompilerGenerated]
	private Action<DealTicket> 녪뇊;

	[CompilerGenerated]
	private readonly SymbolsListManager 녪놋;

	private readonly List<HistoricalSymbol> 녪녣;

	[CompilerGenerated]
	private Action<HistoricalSymbol> 녪녩;

	[CompilerGenerated]
	private Action<HistoricalSymbol> 녪놤;

	[CompilerGenerated]
	private Action<HistoricalSymbol> 녪논;

	[CompilerGenerated]
	private Action<Synthetic> 녪녘;

	[CompilerGenerated]
	private Action<Synthetic> 녪노;

	[CompilerGenerated]
	private Action<Synthetic> 녪녒;

	[CompilerGenerated]
	private readonly List<Synthetic> 녪녕 = new List<Synthetic>();

	[CompilerGenerated]
	private EventHandler<TradingSignalEventArgs> 녪녖;

	[CompilerGenerated]
	private Action<Alert> 녶녴;

	[CompilerGenerated]
	private Action<OTPHolder, string, string> 녶놴;

	[CompilerGenerated]
	private Action 녶놂;

	private Timer 녶놎;

	[CompilerGenerated]
	private IBrowserFactory 녶녞;

	[CompilerGenerated]
	private IOAuthBrowserCreator 녶놫;

	[CompilerGenerated]
	private Func<string, string, bool> 녶녪;

	[CompilerGenerated]
	private EventHandler<RequestEventArgs> 녶녶;

	[CompilerGenerated]
	private EventHandler<PerformedRequestEventArgs> 녶녵;

	/// <summary>
	/// Gets a singleton instance of <see cref="T:TradingPlatform.BusinessLayer.Core" />. API entry point
	/// </summary>
	public static Core Instance
	{
		get
		{
			lock (typeof(Core))
			{
				if (녪녹 == null)
				{
					녪녹 = new Core();
				}
			}
			return 녪녹;
		}
	}

	/// <summary>
	/// Gets an access to all created connections and manages them
	/// </summary>
	public ConnectionsManager Connections
	{
		[CompilerGenerated]
		get
		{
			return 녪녔;
		}
	}

	/// <summary>
	/// Gets an access to the system logging mechanism
	/// </summary>
	public LoggerManager Loggers
	{
		[CompilerGenerated]
		get
		{
			return 녪녠;
		}
	}

	/// <summary>
	/// Obtains licence rules for the current user
	/// </summary>
	[NotPublished]
	public LicencesManager Licences
	{
		[CompilerGenerated]
		get
		{
			return 녪놠;
		}
	}

	/// <summary>
	/// Gets an access to all available trading data vendors and creates them
	/// </summary>
	[NotPublished]
	public VendorManager Vendors
	{
		[CompilerGenerated]
		get
		{
			return 녪놟;
		}
	}

	/// <summary>
	/// Gets an access to the all available aggregation types
	/// </summary>
	[NotPublished]
	public HistoryAggregationManager HistoryAggregations
	{
		[CompilerGenerated]
		get
		{
			return 녪녓;
		}
	}

	/// <summary>
	/// Access to Volume Analysis calculations
	/// </summary>
	public VolumeAnalysisManager VolumeAnalysis
	{
		[CompilerGenerated]
		get
		{
			return 녪녛;
		}
	}

	/// <summary>
	/// Gets an access to the all available indicators and creates them
	/// </summary>
	public IndicatorManager Indicators
	{
		[CompilerGenerated]
		get
		{
			return 녪녽;
		}
	}

	/// <summary>
	/// Gets an access to the all available trading strategies and manages them
	/// </summary>
	public StrategyManager Strategies
	{
		[CompilerGenerated]
		get
		{
			return 녪놏;
		}
	}

	public OrderPlacingStrategiesManager OrderPlacingStrategies
	{
		[CompilerGenerated]
		get
		{
			return 녪녥;
		}
	}

	public MessengersManager Messengers
	{
		[CompilerGenerated]
		get
		{
			return 녪농;
		}
	}

	public LocalOrdersManager LocalOrders
	{
		[CompilerGenerated]
		get
		{
			return 녪념;
		}
	}

	/// <summary>
	/// Gets a <see cref="T:TradingPlatform.BusinessLayer.Rule" /> permissions checking mechanism
	/// </summary>
	[NotPublished]
	public RulesManager RulesManager
	{
		[CompilerGenerated]
		get
		{
			return 녪녨;
		}
	}

	public SymbolsMappingManager SymbolsMapping
	{
		[CompilerGenerated]
		get
		{
			return 녪녺;
		}
	}

	public CustomSessionsManager CustomSessions
	{
		[CompilerGenerated]
		get
		{
			return 녪놣;
		}
	}

	/// <summary>
	/// Gets a time based conversion and synchronization mechanism
	/// </summary>
	public TimeUtils TimeUtils
	{
		[CompilerGenerated]
		get
		{
			return 녪녮;
		}
	}

	/// <summary>
	/// Gets SMTP mail service for sending emails
	/// </summary>
	public MailUtils MailUtils
	{
		[CompilerGenerated]
		get
		{
			return 녪뇆;
		}
	}

	public TradingProtector TradingProtection
	{
		[CompilerGenerated]
		get
		{
			return 녪뇉;
		}
	}

	public IBrandingInformation BrandingInformation
	{
		[CompilerGenerated]
		get
		{
			return 녪뇍;
		}
		[CompilerGenerated]
		private set
		{
			녪뇍 = value;
		}
	}

	public Version CurrentVersion => new Version(GetType().Assembly.GetName().Version.ToString(3));

	/// <summary>
	/// Represents current trading status
	/// </summary>
	public TradingStatus TradingStatus
	{
		get
		{
			return 녪놙;
		}
		set
		{
			녪놙 = value;
			녪녰?.Invoke(value);
		}
	}

	internal 놃<int, CustomMessage> CustomMessageProcessor
	{
		[CompilerGenerated]
		get
		{
			return 녪놚;
		}
		[CompilerGenerated]
		private set
		{
			녪놚 = value;
		}
	}

	private bool AlreadyInitialized
	{
		[CompilerGenerated]
		get
		{
			return 녪놹;
		}
		[CompilerGenerated]
		set
		{
			녪놹 = value;
		}
	}

	public CustomAccountPropertiesProvider CustomAccountPropertiesProvider
	{
		[CompilerGenerated]
		get
		{
			return 녪놘;
		}
		[CompilerGenerated]
		private set
		{
			녪놘 = value;
		}
	}

	/// <summary>
	/// Gets all available <see cref="T:TradingPlatform.BusinessLayer.Symbol" />s from open connections
	/// </summary>
	public Symbol[] Symbols => Connections.Connected.SelectMany((Connection P_0) => P_0.BusinessObjects.Symbols).ToArray();

	/// <summary>
	/// Gets all available <see cref="T:TradingPlatform.BusinessLayer.SymbolType" />s from open connections
	/// </summary>
	public SymbolType[] SymbolTypes => Connections.Connected.SelectMany((Connection P_0) => P_0.BusinessObjects.SymbolTypes).Distinct().ToArray();

	/// <summary>
	/// Gets all available <see cref="T:TradingPlatform.BusinessLayer.Account" />s from open connections
	/// </summary>
	public Account[] Accounts => Connections.Connected.SelectMany((Connection P_0) => P_0.BusinessObjects.Accounts).ToArray();

	/// <summary>
	/// Gets all available <see cref="T:TradingPlatform.BusinessLayer.Asset" />s from open connections
	/// </summary>
	public Asset[] Assets => Connections.Connected.SelectMany((Connection P_0) => P_0.BusinessObjects.Assets).ToArray();

	/// <summary>
	/// Gets all available <see cref="T:TradingPlatform.BusinessLayer.Exchange" />s from open connections
	/// </summary>
	public Exchange[] Exchanges => Connections.Connected.SelectMany((Connection P_0) => P_0.BusinessObjects.Exchanges).ToArray();

	/// <summary>
	/// Gets all available <see cref="T:TradingPlatform.BusinessLayer.Order" />s from open connections
	/// </summary>
	public Order[] Orders => Connections.Connected.SelectMany((Connection P_0) => P_0.BusinessObjects.Orders).ToArray();

	/// <summary>
	/// Gets all available <see cref="T:TradingPlatform.BusinessLayer.OrderType" />s from open connections
	/// </summary>
	public OrderType[] OrderTypes => Connections.Connected.SelectMany((Connection P_0) => P_0.BusinessObjects.OrderTypes).ToArray();

	/// <summary>
	/// Gets all available <see cref="T:TradingPlatform.BusinessLayer.Position" />s from open connections
	/// </summary>
	public Position[] Positions => Connections.Connected.SelectMany((Connection P_0) => P_0.BusinessObjects.Positions).ToArray();

	/// <summary>
	/// Gets all available <see cref="T:TradingPlatform.BusinessLayer.ClosedPosition" />s from open connections
	/// </summary>
	public ClosedPosition[] ClosedPositions => Connections.Connected.SelectMany((Connection P_0) => P_0.BusinessObjects.ClosedPositions).ToArray();

	/// <summary>
	/// Gets all available <see cref="T:TradingPlatform.BusinessLayer.CorporateAction" />s from open connections
	/// </summary>
	public CorporateAction[] CorporateActions => Connections.Connected.SelectMany((Connection P_0) => P_0.BusinessObjects.CorporateActions).ToArray();

	/// <summary>
	/// Gets all available <see cref="T:TradingPlatform.BusinessLayer.ReportType" />s from open connections. Otherwise returns empty list
	/// </summary>&gt;
	public ReportType[] ReportTypes => Connections.Connected.SelectMany((Connection P_0) => P_0.BusinessObjects.ReportTypes).ToArray();

	public AccountOperation[] AccountOperations => Connections.Connected.SelectMany((Connection P_0) => P_0.BusinessObjects.AccountOperations).ToArray();

	/// <summary>
	/// Gets all available <see cref="T:TradingPlatform.BusinessLayer.TradingSignal" />s from open connections. Otherwise returns empty list
	/// </summary>&gt;
	public TradingSignal[] TradingSignals => Connections.Connected.SelectMany((Connection P_0) => P_0.BusinessObjects.TradingSignals).ToArray();

	public AdvancedTradingOperations AdvancedTradingOperations
	{
		[CompilerGenerated]
		get
		{
			return 녪놪;
		}
		[CompilerGenerated]
		private set
		{
			녪놪 = value;
		}
	}

	public DeliveredAsset[] DeliveredAssets => Connections.Connected.SelectMany((Connection P_0) => P_0.BusinessObjects.DeliveredAssets).ToArray();

	/// <summary>
	/// Gets all previously configured <see cref="T:TradingPlatform.BusinessLayer.SymbolList" />s
	/// </summary>
	[NotPublished]
	public SymbolList[] SymbolList => SymbolListManager.Items;

	/// <summary>
	/// Gets an access to <see cref="T:TradingPlatform.BusinessLayer.SymbolList" />s and manages them
	/// </summary>
	[NotPublished]
	public SymbolsListManager SymbolListManager
	{
		[CompilerGenerated]
		get
		{
			return 녪놋;
		}
	}

	/// <summary>
	/// Represent all available Historical Symbols
	/// </summary>
	[NotPublished]
	public List<HistoricalSymbol> HistoricalSymbols => new List<HistoricalSymbol>(녪녣);

	/// <summary>
	/// Represent all available Synthetic items
	/// </summary>
	[NotPublished]
	public List<Synthetic> Synthetics
	{
		[CompilerGenerated]
		get
		{
			return 녪녕;
		}
	}

	[NotPublished]
	public IBrowserFactory BrowserFactory
	{
		[CompilerGenerated]
		get
		{
			return 녶녞;
		}
		[CompilerGenerated]
		set
		{
			녶녞 = value;
		}
	}

	[NotPublished]
	public IOAuthBrowserCreator OAuthBrowserCreator
	{
		[CompilerGenerated]
		get
		{
			return 녶놫;
		}
		[CompilerGenerated]
		set
		{
			녶놫 = value;
		}
	}

	/// <summary>
	/// Will be triggered when <see cref="P:TradingPlatform.BusinessLayer.Core.TradingStatus" /> changed
	/// </summary>
	public event Action<TradingStatus> OnTradingStatusChanged
	{
		[CompilerGenerated]
		add
		{
			Action<TradingStatus> action = 녪녰;
			Action<TradingStatus> action2;
			do
			{
				action2 = action;
				Action<TradingStatus> value2 = (Action<TradingStatus>)Delegate.Combine(action2, value);
				action = Interlocked.CompareExchange(ref 녪녰, value2, action2);
			}
			while ((object)action != action2);
		}
		[CompilerGenerated]
		remove
		{
			Action<TradingStatus> action = 녪녰;
			Action<TradingStatus> action2;
			do
			{
				action2 = action;
				Action<TradingStatus> value2 = (Action<TradingStatus>)Delegate.Remove(action2, value);
				action = Interlocked.CompareExchange(ref 녪녰, value2, action2);
			}
			while ((object)action != action2);
		}
	}

	/// <summary>
	/// Will be triggered when new <see cref="T:TradingPlatform.BusinessLayer.Account" /> added to the core
	/// </summary>
	public event Action<Account> AccountAdded
	{
		[CompilerGenerated]
		add
		{
			Action<Account> action = 녪뇌;
			Action<Account> action2;
			do
			{
				action2 = action;
				Action<Account> value2 = (Action<Account>)Delegate.Combine(action2, value);
				action = Interlocked.CompareExchange(ref 녪뇌, value2, action2);
			}
			while ((object)action != action2);
		}
		[CompilerGenerated]
		remove
		{
			Action<Account> action = 녪뇌;
			Action<Account> action2;
			do
			{
				action2 = action;
				Action<Account> value2 = (Action<Account>)Delegate.Remove(action2, value);
				action = Interlocked.CompareExchange(ref 녪뇌, value2, action2);
			}
			while ((object)action != action2);
		}
	}

	/// <summary>
	/// Will be triggered when new <see cref="T:TradingPlatform.BusinessLayer.Symbol" /> added to the core
	/// </summary>
	public event Action<Symbol> SymbolAdded
	{
		[CompilerGenerated]
		add
		{
			Action<Symbol> action = 녪녷;
			Action<Symbol> action2;
			do
			{
				action2 = action;
				Action<Symbol> value2 = (Action<Symbol>)Delegate.Combine(action2, value);
				action = Interlocked.CompareExchange(ref 녪녷, value2, action2);
			}
			while ((object)action != action2);
		}
		[CompilerGenerated]
		remove
		{
			Action<Symbol> action = 녪녷;
			Action<Symbol> action2;
			do
			{
				action2 = action;
				Action<Symbol> value2 = (Action<Symbol>)Delegate.Remove(action2, value);
				action = Interlocked.CompareExchange(ref 녪녷, value2, action2);
			}
			while ((object)action != action2);
		}
	}

	/// <summary>
	/// Will be triggered when new <see cref="T:TradingPlatform.BusinessLayer.Order" /> placed
	/// </summary>
	public event Action<Order> OrderAdded
	{
		[CompilerGenerated]
		add
		{
			Action<Order> action = 녪녟;
			Action<Order> action2;
			do
			{
				action2 = action;
				Action<Order> value2 = (Action<Order>)Delegate.Combine(action2, value);
				action = Interlocked.CompareExchange(ref 녪녟, value2, action2);
			}
			while ((object)action != action2);
		}
		[CompilerGenerated]
		remove
		{
			Action<Order> action = 녪녟;
			Action<Order> action2;
			do
			{
				action2 = action;
				Action<Order> value2 = (Action<Order>)Delegate.Remove(action2, value);
				action = Interlocked.CompareExchange(ref 녪녟, value2, action2);
			}
			while ((object)action != action2);
		}
	}

	/// <summary>
	/// Will be triggered when <see cref="T:TradingPlatform.BusinessLayer.Order" /> canceled
	/// </summary>
	public event Action<Order> OrderRemoved
	{
		[CompilerGenerated]
		add
		{
			Action<Order> action = 녪놱;
			Action<Order> action2;
			do
			{
				action2 = action;
				Action<Order> value2 = (Action<Order>)Delegate.Combine(action2, value);
				action = Interlocked.CompareExchange(ref 녪놱, value2, action2);
			}
			while ((object)action != action2);
		}
		[CompilerGenerated]
		remove
		{
			Action<Order> action = 녪놱;
			Action<Order> action2;
			do
			{
				action2 = action;
				Action<Order> value2 = (Action<Order>)Delegate.Remove(action2, value);
				action = Interlocked.CompareExchange(ref 녪놱, value2, action2);
			}
			while ((object)action != action2);
		}
	}

	/// <summary>
	/// Will be triggered when new <see cref="T:TradingPlatform.BusinessLayer.Position" /> opened
	/// </summary>
	public event Action<Position> PositionAdded
	{
		[CompilerGenerated]
		add
		{
			Action<Position> action = 녪놖;
			Action<Position> action2;
			do
			{
				action2 = action;
				Action<Position> value2 = (Action<Position>)Delegate.Combine(action2, value);
				action = Interlocked.CompareExchange(ref 녪놖, value2, action2);
			}
			while ((object)action != action2);
		}
		[CompilerGenerated]
		remove
		{
			Action<Position> action = 녪놖;
			Action<Position> action2;
			do
			{
				action2 = action;
				Action<Position> value2 = (Action<Position>)Delegate.Remove(action2, value);
				action = Interlocked.CompareExchange(ref 녪놖, value2, action2);
			}
			while ((object)action != action2);
		}
	}

	/// <summary>
	/// Will be triggered when <see cref="T:TradingPlatform.BusinessLayer.Position" /> closed
	/// </summary>
	public event Action<Position> PositionRemoved
	{
		[CompilerGenerated]
		add
		{
			Action<Position> action = 녪놝;
			Action<Position> action2;
			do
			{
				action2 = action;
				Action<Position> value2 = (Action<Position>)Delegate.Combine(action2, value);
				action = Interlocked.CompareExchange(ref 녪놝, value2, action2);
			}
			while ((object)action != action2);
		}
		[CompilerGenerated]
		remove
		{
			Action<Position> action = 녪놝;
			Action<Position> action2;
			do
			{
				action2 = action;
				Action<Position> value2 = (Action<Position>)Delegate.Remove(action2, value);
				action = Interlocked.CompareExchange(ref 녪놝, value2, action2);
			}
			while ((object)action != action2);
		}
	}

	/// <summary>
	/// Will be triggered when new <see cref="T:TradingPlatform.BusinessLayer.ClosedPosition" /> added
	/// </summary>
	public event Action<ClosedPosition> ClosedPositionAdded
	{
		[CompilerGenerated]
		add
		{
			Action<ClosedPosition> action = 녪뇄;
			Action<ClosedPosition> action2;
			do
			{
				action2 = action;
				Action<ClosedPosition> value2 = (Action<ClosedPosition>)Delegate.Combine(action2, value);
				action = Interlocked.CompareExchange(ref 녪뇄, value2, action2);
			}
			while ((object)action != action2);
		}
		[CompilerGenerated]
		remove
		{
			Action<ClosedPosition> action = 녪뇄;
			Action<ClosedPosition> action2;
			do
			{
				action2 = action;
				Action<ClosedPosition> value2 = (Action<ClosedPosition>)Delegate.Remove(action2, value);
				action = Interlocked.CompareExchange(ref 녪뇄, value2, action2);
			}
			while ((object)action != action2);
		}
	}

	/// <summary>
	/// Will be triggered when <see cref="T:TradingPlatform.BusinessLayer.ClosedPosition" /> removed
	/// </summary>
	public event Action<ClosedPosition> ClosedPositionRemoved
	{
		[CompilerGenerated]
		add
		{
			Action<ClosedPosition> action = 녪녑;
			Action<ClosedPosition> action2;
			do
			{
				action2 = action;
				Action<ClosedPosition> value2 = (Action<ClosedPosition>)Delegate.Combine(action2, value);
				action = Interlocked.CompareExchange(ref 녪녑, value2, action2);
			}
			while ((object)action != action2);
		}
		[CompilerGenerated]
		remove
		{
			Action<ClosedPosition> action = 녪녑;
			Action<ClosedPosition> action2;
			do
			{
				action2 = action;
				Action<ClosedPosition> value2 = (Action<ClosedPosition>)Delegate.Remove(action2, value);
				action = Interlocked.CompareExchange(ref 녪녑, value2, action2);
			}
			while ((object)action != action2);
		}
	}

	/// <summary>
	/// Will be triggered when new <see cref="T:TradingPlatform.BusinessLayer.Trade" /> occured
	/// </summary>
	public event Action<Trade> TradeAdded
	{
		[CompilerGenerated]
		add
		{
			Action<Trade> action = 녪놈;
			Action<Trade> action2;
			do
			{
				action2 = action;
				Action<Trade> value2 = (Action<Trade>)Delegate.Combine(action2, value);
				action = Interlocked.CompareExchange(ref 녪놈, value2, action2);
			}
			while ((object)action != action2);
		}
		[CompilerGenerated]
		remove
		{
			Action<Trade> action = 녪놈;
			Action<Trade> action2;
			do
			{
				action2 = action;
				Action<Trade> value2 = (Action<Trade>)Delegate.Remove(action2, value);
				action = Interlocked.CompareExchange(ref 녪놈, value2, action2);
			}
			while ((object)action != action2);
		}
	}

	/// <summary>
	/// Will be triggered when new <see cref="T:TradingPlatform.BusinessLayer.CorporateAction" /> occured
	/// </summary>
	public event Action<CorporateAction> CorporateActionAdded
	{
		[CompilerGenerated]
		add
		{
			Action<CorporateAction> action = 녪놬;
			Action<CorporateAction> action2;
			do
			{
				action2 = action;
				Action<CorporateAction> value2 = (Action<CorporateAction>)Delegate.Combine(action2, value);
				action = Interlocked.CompareExchange(ref 녪놬, value2, action2);
			}
			while ((object)action != action2);
		}
		[CompilerGenerated]
		remove
		{
			Action<CorporateAction> action = 녪놬;
			Action<CorporateAction> action2;
			do
			{
				action2 = action;
				Action<CorporateAction> value2 = (Action<CorporateAction>)Delegate.Remove(action2, value);
				action = Interlocked.CompareExchange(ref 녪놬, value2, action2);
			}
			while ((object)action != action2);
		}
	}

	/// <summary>
	/// Will be triggered when new <see cref="T:TradingPlatform.BusinessLayer.OrderHistory" /> added
	/// </summary>
	public event Action<OrderHistory> OrdersHistoryAdded
	{
		[CompilerGenerated]
		add
		{
			Action<OrderHistory> action = 녪놊;
			Action<OrderHistory> action2;
			do
			{
				action2 = action;
				Action<OrderHistory> value2 = (Action<OrderHistory>)Delegate.Combine(action2, value);
				action = Interlocked.CompareExchange(ref 녪놊, value2, action2);
			}
			while ((object)action != action2);
		}
		[CompilerGenerated]
		remove
		{
			Action<OrderHistory> action = 녪놊;
			Action<OrderHistory> action2;
			do
			{
				action2 = action;
				Action<OrderHistory> value2 = (Action<OrderHistory>)Delegate.Remove(action2, value);
				action = Interlocked.CompareExchange(ref 녪놊, value2, action2);
			}
			while ((object)action != action2);
		}
	}

	public event Action<DeliveredAsset> DeliveredAssetAdded
	{
		[CompilerGenerated]
		add
		{
			Action<DeliveredAsset> action = 녪놌;
			Action<DeliveredAsset> action2;
			do
			{
				action2 = action;
				Action<DeliveredAsset> value2 = (Action<DeliveredAsset>)Delegate.Combine(action2, value);
				action = Interlocked.CompareExchange(ref 녪놌, value2, action2);
			}
			while ((object)action != action2);
		}
		[CompilerGenerated]
		remove
		{
			Action<DeliveredAsset> action = 녪놌;
			Action<DeliveredAsset> action2;
			do
			{
				action2 = action;
				Action<DeliveredAsset> value2 = (Action<DeliveredAsset>)Delegate.Remove(action2, value);
				action = Interlocked.CompareExchange(ref 녪놌, value2, action2);
			}
			while ((object)action != action2);
		}
	}

	public event Action<DeliveredAsset> DeliveredAssetRemoved
	{
		[CompilerGenerated]
		add
		{
			Action<DeliveredAsset> action = 녪놕;
			Action<DeliveredAsset> action2;
			do
			{
				action2 = action;
				Action<DeliveredAsset> value2 = (Action<DeliveredAsset>)Delegate.Combine(action2, value);
				action = Interlocked.CompareExchange(ref 녪놕, value2, action2);
			}
			while ((object)action != action2);
		}
		[CompilerGenerated]
		remove
		{
			Action<DeliveredAsset> action = 녪놕;
			Action<DeliveredAsset> action2;
			do
			{
				action2 = action;
				Action<DeliveredAsset> value2 = (Action<DeliveredAsset>)Delegate.Remove(action2, value);
				action = Interlocked.CompareExchange(ref 녪놕, value2, action2);
			}
			while ((object)action != action2);
		}
	}

	/// <summary>
	/// Will be triggered when new <see cref="T:TradingPlatform.BusinessLayer.DealTicket" /> received
	/// </summary>
	public event Action<DealTicket> DealTicketReceived
	{
		[CompilerGenerated]
		add
		{
			Action<DealTicket> action = 녪뇊;
			Action<DealTicket> action2;
			do
			{
				action2 = action;
				Action<DealTicket> value2 = (Action<DealTicket>)Delegate.Combine(action2, value);
				action = Interlocked.CompareExchange(ref 녪뇊, value2, action2);
			}
			while ((object)action != action2);
		}
		[CompilerGenerated]
		remove
		{
			Action<DealTicket> action = 녪뇊;
			Action<DealTicket> action2;
			do
			{
				action2 = action;
				Action<DealTicket> value2 = (Action<DealTicket>)Delegate.Remove(action2, value);
				action = Interlocked.CompareExchange(ref 녪뇊, value2, action2);
			}
			while ((object)action != action2);
		}
	}

	[NotPublished]
	public event Action<HistoricalSymbol> HistoricalSymbolAdded
	{
		[CompilerGenerated]
		add
		{
			Action<HistoricalSymbol> action = 녪녩;
			Action<HistoricalSymbol> action2;
			do
			{
				action2 = action;
				Action<HistoricalSymbol> value2 = (Action<HistoricalSymbol>)Delegate.Combine(action2, value);
				action = Interlocked.CompareExchange(ref 녪녩, value2, action2);
			}
			while ((object)action != action2);
		}
		[CompilerGenerated]
		remove
		{
			Action<HistoricalSymbol> action = 녪녩;
			Action<HistoricalSymbol> action2;
			do
			{
				action2 = action;
				Action<HistoricalSymbol> value2 = (Action<HistoricalSymbol>)Delegate.Remove(action2, value);
				action = Interlocked.CompareExchange(ref 녪녩, value2, action2);
			}
			while ((object)action != action2);
		}
	}

	[NotPublished]
	public event Action<HistoricalSymbol> HistoricalSymbolRemoved
	{
		[CompilerGenerated]
		add
		{
			Action<HistoricalSymbol> action = 녪놤;
			Action<HistoricalSymbol> action2;
			do
			{
				action2 = action;
				Action<HistoricalSymbol> value2 = (Action<HistoricalSymbol>)Delegate.Combine(action2, value);
				action = Interlocked.CompareExchange(ref 녪놤, value2, action2);
			}
			while ((object)action != action2);
		}
		[CompilerGenerated]
		remove
		{
			Action<HistoricalSymbol> action = 녪놤;
			Action<HistoricalSymbol> action2;
			do
			{
				action2 = action;
				Action<HistoricalSymbol> value2 = (Action<HistoricalSymbol>)Delegate.Remove(action2, value);
				action = Interlocked.CompareExchange(ref 녪놤, value2, action2);
			}
			while ((object)action != action2);
		}
	}

	[NotPublished]
	public event Action<HistoricalSymbol> HistoricalSymbolUpdated
	{
		[CompilerGenerated]
		add
		{
			Action<HistoricalSymbol> action = 녪논;
			Action<HistoricalSymbol> action2;
			do
			{
				action2 = action;
				Action<HistoricalSymbol> value2 = (Action<HistoricalSymbol>)Delegate.Combine(action2, value);
				action = Interlocked.CompareExchange(ref 녪논, value2, action2);
			}
			while ((object)action != action2);
		}
		[CompilerGenerated]
		remove
		{
			Action<HistoricalSymbol> action = 녪논;
			Action<HistoricalSymbol> action2;
			do
			{
				action2 = action;
				Action<HistoricalSymbol> value2 = (Action<HistoricalSymbol>)Delegate.Remove(action2, value);
				action = Interlocked.CompareExchange(ref 녪논, value2, action2);
			}
			while ((object)action != action2);
		}
	}

	/// <summary>
	/// Will be triggered when custom symbol <see cref="T:TradingPlatform.BusinessLayer.Synthetic" /> added
	/// </summary>
	[NotPublished]
	public event Action<Synthetic> SyntheticAdded
	{
		[CompilerGenerated]
		add
		{
			Action<Synthetic> action = 녪녘;
			Action<Synthetic> action2;
			do
			{
				action2 = action;
				Action<Synthetic> value2 = (Action<Synthetic>)Delegate.Combine(action2, value);
				action = Interlocked.CompareExchange(ref 녪녘, value2, action2);
			}
			while ((object)action != action2);
		}
		[CompilerGenerated]
		remove
		{
			Action<Synthetic> action = 녪녘;
			Action<Synthetic> action2;
			do
			{
				action2 = action;
				Action<Synthetic> value2 = (Action<Synthetic>)Delegate.Remove(action2, value);
				action = Interlocked.CompareExchange(ref 녪녘, value2, action2);
			}
			while ((object)action != action2);
		}
	}

	/// <summary>
	/// Will be triggered when custom symbol <see cref="T:TradingPlatform.BusinessLayer.Synthetic" /> removed
	/// </summary>
	[NotPublished]
	public event Action<Synthetic> SyntheticRemoved
	{
		[CompilerGenerated]
		add
		{
			Action<Synthetic> action = 녪노;
			Action<Synthetic> action2;
			do
			{
				action2 = action;
				Action<Synthetic> value2 = (Action<Synthetic>)Delegate.Combine(action2, value);
				action = Interlocked.CompareExchange(ref 녪노, value2, action2);
			}
			while ((object)action != action2);
		}
		[CompilerGenerated]
		remove
		{
			Action<Synthetic> action = 녪노;
			Action<Synthetic> action2;
			do
			{
				action2 = action;
				Action<Synthetic> value2 = (Action<Synthetic>)Delegate.Remove(action2, value);
				action = Interlocked.CompareExchange(ref 녪노, value2, action2);
			}
			while ((object)action != action2);
		}
	}

	/// <summary>
	/// Will be triggered when custom symbol <see cref="T:TradingPlatform.BusinessLayer.Synthetic" /> updated
	/// </summary>
	[NotPublished]
	public event Action<Synthetic> SyntheticUpdated
	{
		[CompilerGenerated]
		add
		{
			Action<Synthetic> action = 녪녒;
			Action<Synthetic> action2;
			do
			{
				action2 = action;
				Action<Synthetic> value2 = (Action<Synthetic>)Delegate.Combine(action2, value);
				action = Interlocked.CompareExchange(ref 녪녒, value2, action2);
			}
			while ((object)action != action2);
		}
		[CompilerGenerated]
		remove
		{
			Action<Synthetic> action = 녪녒;
			Action<Synthetic> action2;
			do
			{
				action2 = action;
				Action<Synthetic> value2 = (Action<Synthetic>)Delegate.Remove(action2, value);
				action = Interlocked.CompareExchange(ref 녪녒, value2, action2);
			}
			while ((object)action != action2);
		}
	}

	/// <summary>
	/// Will be triggered when <see cref="T:TradingPlatform.BusinessLayer.TradingSignal" /> created/chenged/removed
	/// </summary>
	public event EventHandler<TradingSignalEventArgs> TradingSignalUpdate
	{
		[CompilerGenerated]
		add
		{
			EventHandler<TradingSignalEventArgs> eventHandler = 녪녖;
			EventHandler<TradingSignalEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<TradingSignalEventArgs> value2 = (EventHandler<TradingSignalEventArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref 녪녖, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<TradingSignalEventArgs> eventHandler = 녪녖;
			EventHandler<TradingSignalEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<TradingSignalEventArgs> value2 = (EventHandler<TradingSignalEventArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref 녪녖, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event Action<Alert> OnAlert
	{
		[CompilerGenerated]
		add
		{
			Action<Alert> action = 녶녴;
			Action<Alert> action2;
			do
			{
				action2 = action;
				Action<Alert> value2 = (Action<Alert>)Delegate.Combine(action2, value);
				action = Interlocked.CompareExchange(ref 녶녴, value2, action2);
			}
			while ((object)action != action2);
		}
		[CompilerGenerated]
		remove
		{
			Action<Alert> action = 녶녴;
			Action<Alert> action2;
			do
			{
				action2 = action;
				Action<Alert> value2 = (Action<Alert>)Delegate.Remove(action2, value);
				action = Interlocked.CompareExchange(ref 녶녴, value2, action2);
			}
			while ((object)action != action2);
		}
	}

	public event Action<OTPHolder, string, string> OnRequestOTP
	{
		[CompilerGenerated]
		add
		{
			Action<OTPHolder, string, string> action = 녶놴;
			Action<OTPHolder, string, string> action2;
			do
			{
				action2 = action;
				Action<OTPHolder, string, string> value2 = (Action<OTPHolder, string, string>)Delegate.Combine(action2, value);
				action = Interlocked.CompareExchange(ref 녶놴, value2, action2);
			}
			while ((object)action != action2);
		}
		[CompilerGenerated]
		remove
		{
			Action<OTPHolder, string, string> action = 녶놴;
			Action<OTPHolder, string, string> action2;
			do
			{
				action2 = action;
				Action<OTPHolder, string, string> value2 = (Action<OTPHolder, string, string>)Delegate.Remove(action2, value);
				action = Interlocked.CompareExchange(ref 녶놴, value2, action2);
			}
			while ((object)action != action2);
		}
	}

	public event Func<string, string, bool> OnAskUserConfirmationForTradingWithRunningEmulator
	{
		[CompilerGenerated]
		add
		{
			Func<string, string, bool> func = 녶녪;
			Func<string, string, bool> func2;
			do
			{
				func2 = func;
				Func<string, string, bool> value2 = (Func<string, string, bool>)Delegate.Combine(func2, value);
				func = Interlocked.CompareExchange(ref 녶녪, value2, func2);
			}
			while ((object)func != func2);
		}
		[CompilerGenerated]
		remove
		{
			Func<string, string, bool> func = 녶녪;
			Func<string, string, bool> func2;
			do
			{
				func2 = func;
				Func<string, string, bool> value2 = (Func<string, string, bool>)Delegate.Remove(func2, value);
				func = Interlocked.CompareExchange(ref 녶녪, value2, func2);
			}
			while ((object)func != func2);
		}
	}

	public event EventHandler<RequestEventArgs> NewRequest
	{
		[CompilerGenerated]
		add
		{
			EventHandler<RequestEventArgs> eventHandler = 녶녶;
			EventHandler<RequestEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<RequestEventArgs> value2 = (EventHandler<RequestEventArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref 녶녶, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<RequestEventArgs> eventHandler = 녶녶;
			EventHandler<RequestEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<RequestEventArgs> value2 = (EventHandler<RequestEventArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref 녶녶, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler<PerformedRequestEventArgs> NewPerformedRequest
	{
		[CompilerGenerated]
		add
		{
			EventHandler<PerformedRequestEventArgs> eventHandler = 녶녵;
			EventHandler<PerformedRequestEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<PerformedRequestEventArgs> value2 = (EventHandler<PerformedRequestEventArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref 녶녵, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<PerformedRequestEventArgs> eventHandler = 녶녵;
			EventHandler<PerformedRequestEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<PerformedRequestEventArgs> value2 = (EventHandler<PerformedRequestEventArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref 녶녵, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	private Core()
	{
		global::녴.놂.녴(GetType().Assembly.Location);
		녪녔 = new ConnectionsManager();
		녪녠 = new LoggerManager();
		녪놠 = new LicencesManager();
		녪놟 = new VendorManager();
		녪녓 = new HistoryAggregationManager();
		녪녛 = new VolumeAnalysisManager();
		녪녽 = new IndicatorManager();
		녪놏 = new StrategyManager();
		녪녥 = new OrderPlacingStrategiesManager();
		녪놋 = new SymbolsListManager();
		녪녨 = new RulesManager();
		녪녺 = new SymbolsMappingManager();
		녪놣 = new CustomSessionsManager();
		녪농 = new MessengersManager();
		녪념 = new LocalOrdersManager();
		녪녮 = new TimeUtils();
		녪뇆 = new MailUtils();
		녪뇉 = new TradingProtector();
		녪녣 = new List<HistoricalSymbol>();
		CustomAccountPropertiesProvider = new CustomAccountPropertiesProvider();
	}

	/// <summary>
	/// Starts a <see cref="T:TradingPlatform.BusinessLayer.Core" /> initialization process which initializes given Managers, <see cref="T:TradingPlatform.BusinessLayer.Connection" /> and Utils. And provides a subscribing on events.
	/// </summary>
	[NotPublished]
	public void Initialize()
	{
		lock (녪녹)
		{
			if (AlreadyInitialized)
			{
				return;
			}
			AlreadyInitialized = true;
		}
		CustomMessageProcessor = new 놃<int, CustomMessage>();
		ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
		Loggers.녴();
		Loggers.Log(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵놣(), LoggingLevel.Verbose);
		Loggers.Log(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵녮(), LoggingLevel.Verbose);
		TimeUtils.녴();
		Licences.녴();
		Vendors.녴();
		HistoryAggregations.녴();
		VolumeAnalysis.녴();
		Indicators.녴();
		Strategies.녴();
		OrderPlacingStrategies.녴();
		Connections.Initialize();
		SymbolsMapping.녴();
		Messengers.녴();
		SymbolListManager.녴();
		LocalOrders.Initialize();
		AdvancedTradingOperations = new AdvancedTradingOperations();
		녴();
		Loggers.Log(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵뇆(), LoggingLevel.Verbose);
	}

	/// <summary>
	/// Disposes all previously initialized modules and unsubscribe from events
	/// </summary>
	[NotPublished]
	public void Dispose()
	{
		lock (녪녹)
		{
			if (!AlreadyInitialized)
			{
				return;
			}
			Licences.Dispose();
			Vendors.놴();
			HistoryAggregations.놴();
			VolumeAnalysis.놴();
			Indicators.Dispose();
			Strategies.Dispose();
			OrderPlacingStrategies.Dispose();
			Messengers.Dispose();
			Connections.Dispose();
			TimeUtils.놴();
			MailUtils.녴();
			Loggers.Dispose();
			if (녶놎 != null)
			{
				녶놎.Dispose();
				녶놎 = null;
			}
			AlreadyInitialized = false;
			lock (typeof(Core))
			{
				녪녹 = null;
			}
		}
	}

	/// <summary>
	/// Gets an instance of exist Account or creates a new one with given info parameter
	/// </summary>
	/// <param name="accountInfo"></param>
	/// <returns></returns>
	public Account GetAccount(BusinessObjectInfo accountInfo)
	{
		if (accountInfo == null)
		{
			throw new ArgumentNullException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵뇉());
		}
		Account account = Connections[accountInfo.ConnectionId]?.BusinessObjects?.Accounts?.FirstOrDefault((Account P_0) => P_0.Id == accountInfo.Id);
		if (account != null)
		{
			return account;
		}
		if (accountInfo is 놅 { IsCrypto: not false })
		{
			return new CryptoAccount(accountInfo);
		}
		return new Account(accountInfo);
	}

	internal void 녴(Account P_0)
	{
		녪뇌.InvokeSafely(P_0);
	}

	internal void 녴(Symbol P_0)
	{
		녪녷.InvokeSafely(P_0);
	}

	/// <summary>
	/// Returns all <see cref="T:TradingPlatform.BusinessLayer.Symbol" />s from open connections which satisfy given request parameters, otherwise returns empty list
	/// </summary>
	/// <param name="requestParameters"></param>
	/// <returns></returns>
	[NotPublished]
	public IList<Symbol> SearchSymbols(SearchSymbolsRequestParameters requestParameters)
	{
		List<Symbol> list = new List<Symbol>();
		if (string.IsNullOrEmpty(requestParameters.ConnectionId))
		{
			Connection[] connected = Connections.Connected;
			for (int i = 0; i < connected.Length; i++)
			{
				IList<Symbol> list2 = connected[i].녴(requestParameters);
				if (list2 != null)
				{
					list.AddRange(list2);
				}
			}
		}
		else
		{
			IList<Symbol> list3 = Connections[requestParameters.ConnectionId]?.녴(requestParameters);
			if (list3 != null)
			{
				list.AddRange(list3);
			}
		}
		return list;
	}

	/// <summary>
	/// Retrieves any <see cref="T:TradingPlatform.BusinessLayer.Symbol" /> by given request parameters. Otherwise returns null
	/// </summary>
	/// <param name="requestParameters"></param>
	/// <param name="connectionId"> Must be specified if open connections total is more than one. Will search only in Synthetic symbols list if id is equal to <see cref="F:TradingPlatform.BusinessLayer.Synthetic.SYNTHETIC_CONNECTION_ID" /> </param>
	/// <param name="downloadSymbol"></param>
	/// <returns></returns>
	public Symbol GetSymbol(GetSymbolRequestParameters requestParameters, string connectionId = null, NonFixedListDownload downloadSymbol = NonFixedListDownload.Download)
	{
		if (connectionId == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵뇍())
		{
			return Synthetics.Find((Synthetic P_0) => P_0.Id == requestParameters.SymbolId);
		}
		if (connectionId == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵놙())
		{
			return HistoricalSymbols.Find((HistoricalSymbol P_0) => P_0.Id == requestParameters.SymbolId);
		}
		if (!string.IsNullOrEmpty(connectionId))
		{
			return Connections[connectionId]?.녴(requestParameters, downloadSymbol);
		}
		if (Connections.All.Count((Connection P_0) => P_0.Connected) > 1)
		{
			throw new ArgumentException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵녰());
		}
		return Connections.All.FirstOrDefault((Connection P_0) => P_0.Connected)?.녴(requestParameters, downloadSymbol);
	}

	/// <summary>
	/// Gets an instance of exist symbol or creates a new one with given info parameter
	/// </summary>
	/// <param name="symbolInfo"></param>
	/// <returns></returns>
	public Symbol GetSymbol(BusinessObjectInfo symbolInfo)
	{
		if (symbolInfo == null)
		{
			throw new ArgumentNullException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵놚());
		}
		GetSymbolRequestParameters requestParameters = new GetSymbolRequestParameters
		{
			SymbolId = symbolInfo.Id
		};
		return GetSymbol(requestParameters, symbolInfo.ConnectionId) ?? new Symbol(symbolInfo);
	}

	[NotPublished]
	public IList<Symbol> GetFutureContracts(Symbol underlier)
	{
		return GetFutureContracts(new GetFutureContractsRequestParameters
		{
			ConnectionId = underlier.ConnectionId,
			ExchangeId = underlier.Exchange.Id,
			UnderlierId = underlier.Id
		});
	}

	[NotPublished]
	public IList<Symbol> GetFutureContracts(string root, string exchangeId, string connectionId = null)
	{
		return GetFutureContracts(new GetFutureContractsRequestParameters
		{
			ConnectionId = connectionId,
			Root = root,
			ExchangeId = exchangeId
		});
	}

	[NotPublished]
	public IList<Symbol> GetFutureContracts(GetFutureContractsRequestParameters requestParameters)
	{
		if (requestParameters == null)
		{
			throw new ArgumentNullException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵놹());
		}
		if (string.IsNullOrEmpty(requestParameters.Root) && string.IsNullOrEmpty(requestParameters.UnderlierId))
		{
			throw new ArgumentNullException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵놘());
		}
		if (!string.IsNullOrEmpty(requestParameters.ConnectionId))
		{
			return Connections[requestParameters.ConnectionId]?.녴(requestParameters);
		}
		if (Connections.All.Count((Connection P_0) => P_0.Connected) > 1)
		{
			throw new ArgumentException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵뇌());
		}
		return Connections.All.FirstOrDefault()?.녴(requestParameters);
	}

	[NotPublished]
	public virtual IList<OptionSerie> GetOptionSeries(Symbol underlier)
	{
		return GetOptionSeries(new GetOptionSeriesRequestParameters(underlier));
	}

	[NotPublished]
	public virtual IList<OptionSerie> GetOptionSeries(GetOptionSeriesRequestParameters requestParameters)
	{
		if (requestParameters == null)
		{
			throw new ArgumentNullException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵놹());
		}
		if (string.IsNullOrEmpty(requestParameters.ConnectionId))
		{
			throw new ArgumentNullException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놎뇉());
		}
		if (string.IsNullOrEmpty(requestParameters.UnderlierId))
		{
			throw new ArgumentNullException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵녷());
		}
		return Connections[requestParameters.ConnectionId]?.녴(requestParameters);
	}

	[NotPublished]
	public virtual IList<Symbol> GetStrikes(OptionSerie serie)
	{
		return GetStrikes(new GetStrikesRequestParameters(serie));
	}

	[NotPublished]
	public virtual IList<Symbol> GetStrikes(GetStrikesRequestParameters requestParameters)
	{
		if (requestParameters == null)
		{
			throw new ArgumentNullException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵놹());
		}
		if (string.IsNullOrEmpty(requestParameters.ConnectionId))
		{
			throw new ArgumentNullException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놎뇉());
		}
		if (string.IsNullOrEmpty(requestParameters.UnderlierId))
		{
			throw new ArgumentNullException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵녷());
		}
		if (string.IsNullOrEmpty(requestParameters.SerieId))
		{
			throw new ArgumentNullException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵녟());
		}
		return Connections[requestParameters.ConnectionId]?.녴(requestParameters);
	}

	internal void 녴(Order P_0)
	{
		Loggers.Log(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵놱(), P_0.ToString());
		녪녟.InvokeSafely(P_0);
	}

	internal void 놴(Order P_0)
	{
		Loggers.Log(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵놖(), P_0.ToString());
		녪놱.InvokeSafely(P_0);
	}

	/// <summary>
	/// Gets <see cref="T:TradingPlatform.BusinessLayer.OrderType" /> instance by given Id string. Otherwise returns null
	/// </summary>
	/// <param name="orderTypeId"></param>
	/// <param name="connectionId">Must be specified if open connections total is more than one</param>
	/// <returns></returns>
	public OrderType GetOrderType(string orderTypeId, string connectionId = null)
	{
		if (string.IsNullOrEmpty(orderTypeId))
		{
			throw new ArgumentNullException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵놝());
		}
		if (!string.IsNullOrEmpty(connectionId))
		{
			return Connections[connectionId]?.BusinessObjects?.OrderTypes?.FirstOrDefault((OrderType P_0) => P_0.Id == orderTypeId);
		}
		Connection[] array = Connections.All.Where((Connection P_0) => P_0.Connected).ToArray();
		if (array.Length > 1)
		{
			throw new ArgumentException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵뇄());
		}
		return array.First().BusinessObjects.OrderTypes.SingleOrDefault((OrderType P_0) => P_0.Id == orderTypeId);
	}

	/// <summary>
	/// Gets <see cref="T:TradingPlatform.BusinessLayer.Order" /> instance by given Id string. Otherwise returns null
	/// </summary>
	/// <param name="orderId"></param>
	/// <param name="connectionId">Must be specified if open connections total is more than one</param>
	/// <returns></returns>
	public Order GetOrderById(string orderId, string connectionId = null)
	{
		Connection connection = Connections[connectionId];
		if (connection != null)
		{
			return connection.녴(orderId);
		}
		Connection[] all = Connections.All;
		for (int i = 0; i < all.Length; i++)
		{
			Order order = all[i].녴(orderId);
			if (order != null)
			{
				return order;
			}
		}
		return null;
	}

	internal void 녴(Position P_0)
	{
		녪놖.InvokeSafely(P_0);
	}

	internal void 놴(Position P_0)
	{
		녪놝.InvokeSafely(P_0);
	}

	/// <summary>
	/// Gets <see cref="T:TradingPlatform.BusinessLayer.Position" /> instance by given Id string. Otherwise returns null
	/// </summary>
	/// <param name="positionId"></param>
	/// <param name="connectionId">Must be specified if open connections total is more than one</param>
	/// <returns></returns>
	public Position GetPositionById(string positionId, string connectionId = null)
	{
		Connection connection = Connections[connectionId];
		if (connection != null)
		{
			return connection.놴(positionId);
		}
		Connection[] all = Connections.All;
		for (int i = 0; i < all.Length; i++)
		{
			Position position = all[i].놴(positionId);
			if (position != null)
			{
				return position;
			}
		}
		return null;
	}

	/// <summary>
	/// Gets Profit'n'Loss <see cref="T:TradingPlatform.BusinessLayer.PnL" /> with given request parameters from open connection. Otherwise returns null
	/// </summary>
	/// <param name="parameters"></param>
	/// <returns></returns>
	public PnL CalculatePnL(PnLRequestParameters parameters)
	{
		string 놇놿 = parameters.Account?.ConnectionId ?? parameters.Symbol.ConnectionId;
		Connection connection = Connections.All.FirstOrDefault((Connection P_0) => P_0.Id == 놇놿);
		if (connection == null)
		{
			Loggers.Log(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵녑(), LoggingLevel.Error);
			return null;
		}
		if (!connection.Connected)
		{
			Loggers.Log(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵녿(), LoggingLevel.Error);
			return null;
		}
		return connection.녴(parameters);
	}

	internal void 녴(ClosedPosition P_0)
	{
		녪뇄.InvokeSafely(P_0);
	}

	internal void 놴(ClosedPosition P_0)
	{
		녪녑.InvokeSafely(P_0);
	}

	internal void 녴(Trade P_0)
	{
		Order orderById = GetOrderById(P_0.OrderId, P_0.ConnectionId);
		LoggerManager loggers = Loggers;
		string @event = _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵놈();
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(14, 2);
		defaultInterpolatedStringHandler.AppendFormatted(P_0);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵놬());
		defaultInterpolatedStringHandler.AppendFormatted((orderById == null) ? _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵놊() : $"{orderById}");
		loggers.Log(@event, defaultInterpolatedStringHandler.ToStringAndClear());
		녪놈.InvokeSafely(P_0);
	}

	/// <summary>
	/// Gets collection of <see cref="T:TradingPlatform.BusinessLayer.Trade" /> by given parameters
	/// </summary>
	/// <param name="parameters"></param>
	/// <param name="connectionId"></param>
	/// <returns></returns>
	public IList<Trade> GetTrades(TradesHistoryRequestParameters parameters, string connectionId = null)
	{
		if (parameters == null)
		{
			throw new ArgumentNullException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂녪());
		}
		if (string.IsNullOrEmpty(connectionId))
		{
			List<Trade> list = new List<Trade>();
			Connection[] all = Connections.All;
			for (int i = 0; i < all.Length; i++)
			{
				IList<Trade> trades = all[i].GetTrades(new TradesHistoryRequestParameters(parameters));
				if (trades != null)
				{
					list.AddRange(trades);
				}
			}
			return list;
		}
		return Connections[connectionId]?.GetTrades(parameters) ?? new List<Trade>();
	}

	/// <summary>
	/// Gets collection of <see cref="T:TradingPlatform.BusinessLayer.Trade" /> by given parameters and callback
	/// </summary>
	/// <param name="parameters"></param>
	/// <param name="callback"></param>
	/// <param name="connectionId"></param>
	/// <exception cref="T:System.ArgumentNullException"></exception>
	public void GetTrades(TradesHistoryRequestParameters parameters, AccountTradesLoadingCallback callback, string connectionId = null)
	{
		if (parameters == null)
		{
			throw new ArgumentNullException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂녪());
		}
		if (callback == null)
		{
			throw new ArgumentNullException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵녢());
		}
		if (string.IsNullOrEmpty(connectionId))
		{
			Connection[] all = Connections.All;
			for (int i = 0; i < all.Length; i++)
			{
				all[i].녴(new TradesHistoryRequestParameters(parameters), callback);
			}
		}
		Connections[connectionId]?.녴(parameters, callback);
	}

	internal void 녴(CorporateAction P_0)
	{
		녪놬.InvokeSafely(P_0);
	}

	internal void 녴(OrderHistory P_0)
	{
		Loggers.Log(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵놪(), P_0.ToString());
		녪놊.InvokeSafely(P_0);
	}

	/// <summary>
	/// Gets collection of <see cref="T:TradingPlatform.BusinessLayer.OrderHistory" /> by given parameters
	/// </summary>
	/// <param name="parameters"></param>
	/// <param name="connectionId"></param>
	/// <returns></returns>
	public IList<OrderHistory> GetOrdersHistory(OrdersHistoryRequestParameters parameters, string connectionId = null)
	{
		if (parameters == null)
		{
			throw new ArgumentNullException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂녪());
		}
		if (string.IsNullOrEmpty(connectionId))
		{
			List<OrderHistory> list = new List<OrderHistory>();
			Connection[] all = Connections.All;
			for (int i = 0; i < all.Length; i++)
			{
				IList<OrderHistory> ordersHistory = all[i].GetOrdersHistory(parameters);
				if (ordersHistory != null)
				{
					list.AddRange(ordersHistory);
				}
			}
			return list;
		}
		return Connections[connectionId]?.GetOrdersHistory(parameters) ?? new List<OrderHistory>();
	}

	public TradingOperationResult PlaceOrder(Symbol symbol, Account account, Side side, TimeInForce timeInForce = TimeInForce.Day, double quantity = 1.0, double price = -1.0, double triggerPrice = -1.0, double trailOffset = -1.0)
	{
		if (symbol == null)
		{
			throw new ArgumentNullException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놻());
		}
		if (account == null)
		{
			throw new ArgumentNullException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놡());
		}
		PlaceOrderRequestParameters placeOrderRequestParameters = new PlaceOrderRequestParameters
		{
			Symbol = symbol,
			Account = account,
			Side = side,
			Quantity = quantity,
			TimeInForce = timeInForce
		};
		if (price > 0.0 && triggerPrice <= 0.0 && trailOffset <= 0.0)
		{
			placeOrderRequestParameters.OrderTypeId = _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶놵();
			placeOrderRequestParameters.Price = price;
		}
		else if (triggerPrice > 0.0 && price <= 0.0 && trailOffset <= 0.0)
		{
			placeOrderRequestParameters.OrderTypeId = _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵놌();
			placeOrderRequestParameters.TriggerPrice = triggerPrice;
		}
		else if (price > 0.0 && triggerPrice > 0.0 && trailOffset <= 0.0)
		{
			placeOrderRequestParameters.OrderTypeId = _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵놕();
			placeOrderRequestParameters.Price = price;
			placeOrderRequestParameters.TriggerPrice = triggerPrice;
		}
		else if (trailOffset > 0.0 && price <= 0.0 && triggerPrice <= 0.0)
		{
			placeOrderRequestParameters.OrderTypeId = _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵뇊();
			placeOrderRequestParameters.TrailOffset = trailOffset;
		}
		else
		{
			placeOrderRequestParameters.OrderTypeId = _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵놋();
		}
		return PlaceOrder(placeOrderRequestParameters);
	}

	/// <summary>
	/// Places <see cref="T:TradingPlatform.BusinessLayer.Order" /> with given request parameters
	/// </summary>
	/// <param name="request"></param>
	/// <returns></returns>
	public TradingOperationResult PlaceOrder(PlaceOrderRequestParameters request)
	{
		if (request == null)
		{
			throw new ArgumentNullException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵녣());
		}
		if (!녴(request.Symbol?.Connection, request.RequestId, out var result))
		{
			return result;
		}
		if (!놴(request.Symbol?.Connection, request.RequestId, out result))
		{
			return result;
		}
		return request.Symbol?.녴(request);
	}

	/// <summary>
	/// Places multiple <see cref="T:TradingPlatform.BusinessLayer.Order" />s with given request parameters
	/// </summary>
	/// <param name="requests"></param>
	/// <param name="groupOrderType"></param>
	/// <returns></returns>
	public void PlaceOrders(ICollection<PlaceOrderRequestParameters> requests, GroupOrderType groupOrderType = GroupOrderType.None)
	{
		if (requests == null)
		{
			throw new ArgumentNullException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵녩());
		}
		if (requests.Count == 1)
		{
			PlaceOrder(requests.Single());
			return;
		}
		foreach (IGrouping<string, PlaceOrderRequestParameters> item in from P_0 in requests
			group P_0 by P_0.ConnectionId)
		{
			Connection connection = Connections[item.Key];
			if (RulesManager.IsAllowed(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵놤(), connection.Id).Status == TradingOperationStatus.Allowed)
			{
				PlaceMultiOrderOrderRequestParameters placeMultiOrderOrderRequestParameters = new PlaceMultiOrderOrderRequestParameters
				{
					GroupOrderType = groupOrderType,
					OrderParameters = item.ToArray()
				};
				if (녴(connection, placeMultiOrderOrderRequestParameters.RequestId, out var tradingOperationResult) && 놴(connection, placeMultiOrderOrderRequestParameters.RequestId, out tradingOperationResult))
				{
					connection.녴(placeMultiOrderOrderRequestParameters);
				}
			}
			else if (groupOrderType == GroupOrderType.None)
			{
				PlaceOrderRequestParameters[] array = item.ToArray();
				foreach (PlaceOrderRequestParameters request in array)
				{
					PlaceOrder(request);
				}
			}
		}
	}

	public TradingOperationResult ModifyOrder(Order order, TimeInForce timeInForce = TimeInForce.Default, double quantity = 1.0, double price = -1.0, double triggerPrice = -1.0, double trailOffset = -1.0)
	{
		if (order == null)
		{
			throw new ArgumentNullException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵논());
		}
		ModifyOrderRequestParameters modifyOrderRequestParameters = new ModifyOrderRequestParameters(order);
		if (timeInForce != 0)
		{
			modifyOrderRequestParameters.TimeInForce = timeInForce;
		}
		if (quantity > 0.0)
		{
			modifyOrderRequestParameters.Quantity = quantity;
		}
		if (price > 0.0)
		{
			modifyOrderRequestParameters.Price = price;
		}
		if (triggerPrice > 0.0)
		{
			modifyOrderRequestParameters.TriggerPrice = triggerPrice;
		}
		if (trailOffset > 0.0)
		{
			modifyOrderRequestParameters.TrailOffset = trailOffset;
		}
		return ModifyOrder(modifyOrderRequestParameters);
	}

	/// <summary>
	/// Modifies <see cref="T:TradingPlatform.BusinessLayer.Order" /> by given request parameters
	/// </summary>
	/// <param name="request"></param>
	/// <returns></returns>
	public TradingOperationResult ModifyOrder(ModifyOrderRequestParameters request)
	{
		if (request == null)
		{
			throw new ArgumentNullException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵녣());
		}
		if (LocalOrders.TryHandleTradingOperationRequest(request, out var result))
		{
			return result;
		}
		Connection connection = Connections.All.FirstOrDefault((Connection P_0) => P_0.Id == request.ConnectionId);
		if (connection == null)
		{
			throw new ArgumentNullException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵녑());
		}
		if (!놴(connection, request.RequestId, out result))
		{
			return result;
		}
		return connection.녴(request);
	}

	public TradingOperationResult ClosePosition(Position position, double closeQuantity = -1.0)
	{
		if (position == null)
		{
			throw new ArgumentNullException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴놈());
		}
		ClosePositionRequestParameters request = new ClosePositionRequestParameters
		{
			Position = position,
			CloseQuantity = ((closeQuantity > 0.0) ? closeQuantity : position.Quantity)
		};
		return ClosePosition(request);
	}

	/// <summary>
	/// Closes <see cref="T:TradingPlatform.BusinessLayer.Position" /> with given request parameters
	/// </summary>
	/// <param name="request"></param>
	/// <returns></returns>
	public TradingOperationResult ClosePosition(ClosePositionRequestParameters request)
	{
		if (request == null)
		{
			throw new ArgumentNullException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵녣());
		}
		Connection connection = Connections.All.FirstOrDefault((Connection P_0) => P_0.Id == request.ConnectionId);
		if (connection == null)
		{
			throw new ArgumentNullException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵녑());
		}
		if (!놴(Connections[request.ConnectionId], request.RequestId, out var result))
		{
			return result;
		}
		return connection.녴(request);
	}

	[Obsolete("Use CancelOrder(IOrder order) instead")]
	public TradingOperationResult CancelOrder(Order order, string sendingSource = null)
	{
		if (order == null)
		{
			throw new ArgumentNullException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵논());
		}
		CancelOrderRequestParameters request = new CancelOrderRequestParameters
		{
			Order = order,
			SendingSource = sendingSource
		};
		return CancelOrder(request);
	}

	public TradingOperationResult CancelOrder(IOrder order, string sendingSource = null)
	{
		if (order == null)
		{
			throw new ArgumentNullException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵논());
		}
		CancelOrderRequestParameters request = new CancelOrderRequestParameters
		{
			Order = order,
			SendingSource = sendingSource
		};
		return CancelOrder(request);
	}

	/// <summary>
	/// Cancels <see cref="T:TradingPlatform.BusinessLayer.Order" /> with given request parameters
	/// </summary>
	/// <param name="request"></param>
	/// <returns></returns>
	public TradingOperationResult CancelOrder(CancelOrderRequestParameters request)
	{
		if (request == null)
		{
			throw new ArgumentNullException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵녣());
		}
		if (LocalOrders.TryHandleTradingOperationRequest(request, out var result))
		{
			return result;
		}
		Connection connection = Connections.All.FirstOrDefault((Connection P_0) => P_0.Id == request.ConnectionId);
		if (connection == null)
		{
			throw new ArgumentNullException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵녑());
		}
		if (!놴(connection, request.RequestId, out result))
		{
			return result;
		}
		return connection.녴(request);
	}

	/// <summary>
	/// Returns <see cref="T:TradingPlatform.BusinessLayer.Report" /> with given request parameters from open connection
	/// </summary>
	/// <param name="requestParameters"></param>
	/// <returns></returns>
	public Report GetReport(ReportRequestParameters requestParameters)
	{
		Connection connection = requestParameters.ReportType.Connection;
		if (connection == null)
		{
			Loggers.Log(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵녑(), LoggingLevel.Error);
			return null;
		}
		if (!connection.Connected)
		{
			Loggers.Log(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵녿(), LoggingLevel.Error);
			return null;
		}
		return connection.녴(requestParameters);
	}

	internal void 녴(DeliveredAsset P_0)
	{
		녪놌.InvokeSafely(P_0);
	}

	internal void 놴(DeliveredAsset P_0)
	{
		녪놕.InvokeSafely(P_0);
	}

	internal void 녴(DealTicket P_0)
	{
		녪뇊.InvokeSafely(P_0);
	}

	[NotPublished]
	public void PushDealTicket(string header, string description, DealTicketType type)
	{
		녪뇊.InvokeSafely(new DealTicket(header, description, type));
	}

	[NotPublished]
	public void PushDealTicket(DealTicket dealTicket)
	{
		녪뇊.InvokeSafely(dealTicket);
	}

	/// <summary>
	/// Sends custom request if connection with given Id is open
	/// </summary>
	/// <param name="connectionId"></param>
	/// <param name="parameters"></param>
	public void SendCustomRequest(string connectionId, RequestParameters parameters)
	{
		Connections.Connected.FirstOrDefault((Connection P_0) => P_0.Id == connectionId)?.SendCustomRequest(parameters);
	}

	/// <summary>
	/// Subscribe on custom messages
	/// </summary>
	/// <param name="handler">custom  message handler</param>
	/// <param name="messagesTypes">custom messages Id</param>
	public void SubscribeToCustomMessages(Action<CustomMessage> handler, params int[] messagesTypes)
	{
		CustomMessageProcessor.녴(handler, messagesTypes);
	}

	/// <summary>
	/// Unsubscribe from custom messages
	/// </summary>
	/// <param name="handler">custom  message handler</param>
	/// <param name="messagesTypes">custom messages Id</param>
	public void UnsubscribeFromCustomMessages(Action<CustomMessage> handler, params int[] messagesTypes)
	{
		CustomMessageProcessor.놴(handler, messagesTypes);
	}

	/// <summary>
	/// Adds <see cref="T:TradingPlatform.BusinessLayer.SymbolList" /> if given parameters are valid
	/// </summary>
	/// <param name="symbolsListName"></param>
	/// <param name="symbols"></param>
	[NotPublished]
	public void AddSymbolList(string symbolsListName, IEnumerable<Symbol> symbols)
	{
		if (string.IsNullOrEmpty(symbolsListName))
		{
			throw new ArgumentNullException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵녘());
		}
		if (symbols == null)
		{
			throw new ArgumentNullException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵노());
		}
		SymbolListManager.녴(symbolsListName, symbols);
	}

	/// <summary>
	/// Replaces exist list by new list in <see cref="T:TradingPlatform.BusinessLayer.SymbolList" /> if given parameters are valid
	/// </summary>
	/// <param name="symbolsListName"></param>
	/// <param name="symbols"></param>
	[NotPublished]
	public void ReplaceSymbolList(string symbolsListName, IList<Symbol> symbols)
	{
		if (string.IsNullOrEmpty(symbolsListName))
		{
			throw new ArgumentNullException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵녘());
		}
		if (symbols == null)
		{
			throw new ArgumentNullException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵노());
		}
		SymbolListManager.녴(symbolsListName, symbols);
	}

	/// <summary>
	/// Removes <see cref="T:TradingPlatform.BusinessLayer.SymbolList" /> with a given name
	/// </summary>
	/// <param name="symbolsListName"></param>
	[NotPublished]
	public void RemoveSymbolList(string symbolsListName)
	{
		if (string.IsNullOrEmpty(symbolsListName))
		{
			throw new ArgumentNullException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵녘());
		}
		SymbolListManager.녴(symbolsListName);
	}

	/// <summary>
	/// Replaces list name by new given name in <see cref="T:TradingPlatform.BusinessLayer.SymbolList" /> if given parameters are valid
	/// </summary>
	/// <param name="symbolsListName"></param>
	/// <param name="newSymbolsListName"></param>
	[NotPublished]
	public void RenameSymbolList(string symbolsListName, string newSymbolsListName)
	{
		if (string.IsNullOrEmpty(symbolsListName))
		{
			throw new ArgumentNullException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵녘());
		}
		if (string.IsNullOrEmpty(newSymbolsListName))
		{
			throw new ArgumentNullException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵녒());
		}
		SymbolListManager.녴(symbolsListName, newSymbolsListName);
	}

	[NotPublished]
	public void AddHistoricalSymbol(HistoricalSymbol historicalSymbol)
	{
		if (!녪녣.Contains(historicalSymbol) && !녪녣.Any((HistoricalSymbol P_0) => P_0.Id == historicalSymbol.Id))
		{
			녪녣.Add(historicalSymbol);
			historicalSymbol.Updated += 놴;
			녪녩.InvokeSafely(historicalSymbol);
		}
	}

	[NotPublished]
	public void RemoveHistoricalSymbol(HistoricalSymbol historicalSymbol)
	{
		if (녪녣.Contains(historicalSymbol))
		{
			녪녣.Remove(historicalSymbol);
			historicalSymbol.Updated -= 놴;
			녪놤.InvokeSafely(historicalSymbol);
			historicalSymbol.Dispose();
		}
	}

	private void 놴(Symbol P_0)
	{
		if (P_0 is HistoricalSymbol historicalSymbol)
		{
			녪논.InvokeSafely(historicalSymbol);
		}
	}

	/// <summary>
	/// Adds given Synthetic to the list <see cref="P:TradingPlatform.BusinessLayer.Core.Synthetics" /> if it does not contain
	/// </summary>
	/// <param name="synthetic"></param>
	[NotPublished]
	public void AddSynthetic(Synthetic synthetic)
	{
		if (!Synthetics.Contains(synthetic))
		{
			Synthetics.Add(synthetic);
			synthetic.Reinitialized += 녴;
			녪녘.InvokeSafely(synthetic);
		}
	}

	private void 녴(Synthetic P_0)
	{
		녪녒.InvokeSafely(P_0);
	}

	/// <summary>
	/// Removes given Synthetic from the list <see cref="P:TradingPlatform.BusinessLayer.Core.Synthetics" /> if it exists
	/// </summary>
	/// <param name="synthetic"></param>
	[NotPublished]
	public void RemoveSynthetic(Synthetic synthetic)
	{
		if (Synthetics.Contains(synthetic))
		{
			Synthetics.Remove(synthetic);
			synthetic.Reinitialized -= 녴;
			녪노.InvokeSafely(synthetic);
			synthetic.Dispose();
		}
	}

	internal void 녴(TradingSignal P_0, EntityLifecycle P_1)
	{
		녪녖.InvokeSafely(this, new TradingSignalEventArgs
		{
			TradingSignal = P_0,
			Lifecycle = P_1
		});
	}

	public void Alert(string text, string symbolName, string connectionName, Action onConfirm, string alertName)
	{
		Alert(new Alert
		{
			Text = text,
			SymbolName = symbolName,
			ConnectionName = connectionName,
			ActionOnConfirm = onConfirm,
			Name = alertName
		});
	}

	public void Alert(string text, string symbolName = "", string connectionName = "", Action onConfirm = null)
	{
		Alert(text, symbolName, connectionName, onConfirm, null);
	}

	public void Alert(Alert alert)
	{
		녶녴.InvokeSafely(alert);
	}

	public void RequestOTP(OTPHolder otpHolder, string title, string text)
	{
		녶놴.InvokeSafely(otpHolder, title, text);
	}

	[SpecialName]
	[CompilerGenerated]
	internal void 녴(Action P_0)
	{
		Action action = 녶놂;
		Action action2;
		do
		{
			action2 = action;
			Action value = (Action)Delegate.Combine(action2, P_0);
			action = Interlocked.CompareExchange(ref 녶놂, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	[CompilerGenerated]
	internal void 놴(Action P_0)
	{
		Action action = 녶놂;
		Action action2;
		do
		{
			action2 = action;
			Action value = (Action)Delegate.Remove(action2, P_0);
			action = Interlocked.CompareExchange(ref 녶놂, value, action2);
		}
		while ((object)action != action2);
	}

	private void 녴()
	{
		if (녶놎 == null)
		{
			녶놎 = new Timer(녴);
			녶놎.Change(100, 100);
		}
	}

	private void 녴(object P_0)
	{
		try
		{
			놴();
			녶놂.InvokeSafely();
			TradingProtection.녴();
		}
		catch (Exception ex)
		{
			Loggers.Log(ex);
		}
	}

	private void 놴()
	{
		Position[] positions = Positions;
		foreach (Position position in positions)
		{
			try
			{
				PnL pnL = CalculatePnL(new PnLRequestParameters
				{
					Symbol = position.Symbol,
					Account = position.Account,
					OpenPrice = position.OpenPrice,
					ClosePrice = position.CurrentPrice,
					Side = position.Side,
					Quantity = position.Quantity,
					PositionId = position.Id
				});
				if (pnL != null)
				{
					position.녴(pnL);
				}
			}
			catch (Exception ex)
			{
				Instance.Loggers.Log(ex);
			}
		}
		ClosedPosition[] closedPositions = ClosedPositions;
		foreach (ClosedPosition closedPosition in closedPositions)
		{
			try
			{
				if (closedPosition.GrossPnL != null)
				{
					continue;
				}
				PnL pnL2 = CalculatePnL(new PnLRequestParameters
				{
					Symbol = closedPosition.Symbol,
					Account = closedPosition.Account,
					OpenPrice = closedPosition.OpenPrice,
					ClosePrice = closedPosition.CurrentPrice,
					Side = closedPosition.Side,
					Quantity = 0.0,
					PositionId = closedPosition.Id
				});
				if (pnL2 != null)
				{
					closedPosition.녴(pnL2);
					ClosedPosition closedPosition2 = closedPosition;
					if (closedPosition2.GrossPnL == null)
					{
						PnLItem pnLItem2 = (closedPosition2.GrossPnL = new PnLItem());
					}
				}
			}
			catch (Exception ex2)
			{
				Instance.Loggers.Log(ex2);
			}
		}
	}

	public void InitializeBrandingInformation()
	{
		IBrandingInformation brandingInformation = new 녻();
		try
		{
			TypeWrapper typeWrapper = AssemblyLoader.LoadTypes(string.Empty, typeof(IBrandingInformation), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵녕()).FirstOrDefault();
			if (typeWrapper != null)
			{
				IBrandingInformation brandingInformation2 = (IBrandingInformation)Activator.CreateInstance(typeWrapper);
				if (brandingInformation2 != null)
				{
					brandingInformation = brandingInformation2;
				}
			}
		}
		catch (Exception ex)
		{
			Instance.Loggers.Log(ex);
		}
		BrandingInformation = brandingInformation;
	}

	public void ForceTimeSync()
	{
		TimeUtils.TimeSynchronizer.놴();
	}

	private bool 녴(Connection P_0, long P_1, out TradingOperationResult P_2)
	{
		P_2 = null;
		bool flag;
		if (P_0 != null)
		{
			string vendorName = P_0.VendorName;
			if (vendorName == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵녖() || vendorName == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭녴() || vendorName == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭놴())
			{
				flag = true;
				goto IL_003a;
			}
		}
		flag = false;
		goto IL_003a;
		IL_003a:
		if (flag)
		{
			return true;
		}
		if (TradingProtection.IsOperationAllowed())
		{
			return true;
		}
		string text = loc._(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭놂(), null, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭놎());
		PushDealTicket(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴뇊(), text, DealTicketType.Refuse);
		Loggers.Log(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴뇊(), text, LoggingLevel.Error);
		P_2 = TradingOperationResult.CreateError(P_1, text);
		return false;
	}

	private bool 놴(Connection P_0, long P_1, out TradingOperationResult P_2)
	{
		P_2 = null;
		bool flag;
		if (P_0 != null)
		{
			string vendorName = P_0.VendorName;
			if (vendorName == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵녖() || vendorName == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭녴() || vendorName == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭놴())
			{
				flag = true;
				goto IL_003a;
			}
		}
		flag = false;
		goto IL_003a;
		IL_003a:
		if (flag)
		{
			return true;
		}
		if (!Instance.Connections.Connected.Any(delegate(Connection P_0)
		{
			if (P_0 != null)
			{
				string vendorName2 = P_0.VendorName;
				if (vendorName2 == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵녖() || vendorName2 == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭녴() || vendorName2 == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭놴())
				{
					return true;
				}
			}
			return false;
		}))
		{
			return true;
		}
		bool flag2 = false;
		if (녶녪 != null)
		{
			flag2 = 녶녪(Instance.Connections.Connected.FirstOrDefault(delegate(Connection P_0)
			{
				if (P_0 != null)
				{
					string vendorName3 = P_0.VendorName;
					if (vendorName3 == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵녖() || vendorName3 == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭녴() || vendorName3 == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭놴())
					{
						return true;
					}
				}
				return false;
			}).Name, P_0.Name);
		}
		if (flag2)
		{
			return true;
		}
		string text = loc._(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭녞(), null, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭놎());
		PushDealTicket(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴뇊(), text, DealTicketType.Refuse);
		Loggers.Log(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴뇊(), text, LoggingLevel.Error);
		P_2 = TradingOperationResult.CreateError(P_1, text);
		return false;
	}

	internal void 녴(RequestParameters P_0, object P_1)
	{
		녶녵?.InvokeSafely(this, new PerformedRequestEventArgs(P_0, P_1));
	}

	internal void 녴(Connection P_0, RequestEventArgs P_1)
	{
		녶녶?.InvokeSafely(P_0, P_1);
	}
}
