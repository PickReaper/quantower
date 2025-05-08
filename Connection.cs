using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using IdentityModel.Client;
using IdentityModel.OidcClient;
using IdentityModel.OidcClient.Browser;
using IdentityModel.OidcClient.Results;
using TradingPlatform.BusinessLayer.Integration;
using TradingPlatform.BusinessLayer.Licence;
using TradingPlatform.BusinessLayer.Utils;
using TradingPlatform.BusinessLayer.Utils.Limitation;
using TradingPlatform.BusinessLayer.Utils.Storage;
using TradingPlatform.BusinessLayer.Utils.UserTradesLocalStorage;
using TradingPlatform.BusinessLayer.VolumeAnalysis.Storage;
using 녴;

namespace TradingPlatform.BusinessLayer;

/// <summary>
/// Represents information about connection and provides an access to the current trading information(Symbols, Orders, Position, Accounts etc.).
/// </summary>
[Published]
public sealed class Connection : ICustomizable, IComparable
{
	[Serializable]
	[CompilerGenerated]
	private sealed class 녴
	{
		public static readonly 녴 놓녢 = new 녴();

		public static Func<SettingItem, SettingItem> 놓놞;

		public static Func<Symbol, int> 놓놳;

		public static Func<Period, long> 놓놺;

		public static Func<Connection, bool> 놓놅;

		public static Func<Connection, bool> 놓녜;

		public static Func<Connection, bool> 놓뇃;

		public static Func<SettingItem, bool> 놓녯;

		public static Func<PlaceOrderRequestParameters, string> 놓놮;

		public static Func<OptionSerie, DateTime> 놓녫;

		public static Func<UserTradesInterval, DateTime> 놓뇁;

		public static Func<UserTradesInterval, IEnumerable<MessageTrade>> 놓놧;

		public static Func<UserTradesInterval, IEnumerable<MessageTrade>> 놓녝;

		public static Func<Order, Symbol> 놓뇈;

		public static Func<IGrouping<Symbol, Order>, Symbol> 놓놑;

		public static Func<Position, Symbol> 놓놦;

		public static Func<IGrouping<Symbol, Position>, Symbol> 놓놐;

		internal SettingItem 녴(SettingItem P_0)
		{
			return P_0.GetCopy();
		}

		internal int 녴(Symbol P_0)
		{
			return P_0.TotalSubscriptionsCount;
		}

		internal long 녴(Period P_0)
		{
			return P_0.Ticks;
		}

		internal bool 녴(Connection P_0)
		{
			if (P_0.State != 0)
			{
				return P_0.State == ConnectionState.Connecting;
			}
			return true;
		}

		internal bool 놴(Connection P_0)
		{
			return P_0.Type == ConnectionType.General;
		}

		internal bool 놂(Connection P_0)
		{
			return Core.Instance.RulesManager.IsAllowed(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놓(), P_0.Id).Status != TradingOperationStatus.Allowed;
		}

		internal bool 놴(SettingItem P_0)
		{
			return P_0 is SettingItemOAuth;
		}

		internal string 녴(PlaceOrderRequestParameters P_0)
		{
			return P_0.Symbol.ConnectionId;
		}

		internal DateTime 녴(OptionSerie P_0)
		{
			return P_0.ExpirationDate;
		}

		internal DateTime 녴(UserTradesInterval P_0)
		{
			return P_0.Interval.From;
		}

		internal IEnumerable<MessageTrade> 놴(UserTradesInterval P_0)
		{
			return P_0.Trades;
		}

		internal IEnumerable<MessageTrade> 놂(UserTradesInterval P_0)
		{
			return P_0.Trades;
		}

		internal Symbol 녴(Order P_0)
		{
			return P_0.Symbol;
		}

		internal Symbol 녴(IGrouping<Symbol, Order> P_0)
		{
			return P_0.Key;
		}

		internal Symbol 녴(Position P_0)
		{
			return P_0.Symbol;
		}

		internal Symbol 녴(IGrouping<Symbol, Position> P_0)
		{
			return P_0.Key;
		}
	}

	[CompilerGenerated]
	private sealed class 놴
	{
		public GetStrikesRequestParameters 놓녚;

		internal bool 녴(Symbol P_0)
		{
			if (P_0.OptionSerie != null)
			{
				return P_0.OptionSerie.Id == 놓녚.SerieId;
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class 놂
	{
		public IList<string> 놓녳;

		public IList<SymbolType> 놓놉;

		public string[] 놓놥;

		public SearchSymbolsRequestParameters 놓놯;

		internal bool 녴(Symbol P_0)
		{
			return 놓녳.Contains(P_0.ExchangeId);
		}

		internal bool 놴(Symbol P_0)
		{
			return 놓놉.Contains(P_0.SymbolType);
		}

		internal bool 놂(Symbol P_0)
		{
			return Connection.녴(놓놥, P_0, 놓놯.GetSynonyms);
		}
	}

	[CompilerGenerated]
	private sealed class 놎
	{
		public TradesHistoryRequestParameters 놓녾;

		internal bool 녴(MessageTrade P_0)
		{
			if (!string.IsNullOrEmpty(놓녾.SymbolId))
			{
				return P_0.SymbolId == 놓녾.SymbolId;
			}
			return true;
		}
	}

	[CompilerGenerated]
	private sealed class 녞
	{
		public CancellationToken 놓녬;

		public AccountTradesLoadingCallback 놓녹;

		public Connection 놓녔;

		public TradesHistoryRequestParameters 놓녠;

		public CancellationTokenSource 놓놠;
	}

	[CompilerGenerated]
	private sealed class 놫
	{
		public Interval<DateTime> 놓놟;

		public TradesHistoryRequestParameters 놓녓;

		public List<MessageTrade> 놓녛;

		public 녞 놓녽;

		internal void 녴(IList<MessageTrade> P_0, bool P_1)
		{
			try
			{
				if (놓녽.놓녬.IsCancellationRequested)
				{
					return;
				}
				if (P_0 == null)
				{
					if (P_1)
					{
						놓녽.놓녹.InvokeSafely(new List<Trade>(), P_1);
					}
					return;
				}
				P_0 = 놓녽.놓녔.녴(놓녓, P_0).Trades.ToList();
				놓녛.AddRange(P_0);
				List<Trade> list = 놓녽.놓녔.녴(P_0, 놓녽.놓녬).ToList();
				놓녽.놓녹.InvokeSafely(list, P_1);
				if (P_1 && string.IsNullOrEmpty(놓녽.놓녠.SymbolId) && !놓녽.놓녔.놫놪.UsersTradesCacheMetadata.AllowSingleSymbolLoading)
				{
					놓녽.놓녔.놫녒?.Save(new UserTradesInterval
					{
						Interval = 놓놟,
						Trades = 놓녛
					});
				}
			}
			catch (Exception ex)
			{
				Core.Instance.Loggers.Log(ex);
			}
			finally
			{
				if (P_1)
				{
					놓녽.놓놠.Dispose();
				}
			}
		}
	}

	[CompilerGenerated]
	private sealed class 녪
	{
		public TradesHistoryRequestParameters 놓놏;

		internal bool 녴(MessageTrade P_0)
		{
			return 놓놏.Interval.Contains(P_0.DateTime);
		}
	}

	[CompilerGenerated]
	private sealed class 녶
	{
		public Connection 놓녥;

		public CancellationToken 놓농;

		internal void 녴(string P_0)
		{
			놓녥.ConnectingProgress = P_0;
		}

		internal bool 녴(Connection P_0)
		{
			return P_0 != 놓녥;
		}
	}

	[CompilerGenerated]
	private sealed class 녵
	{
		public DateTime 놓념;

		public 녶 놓녨;

		internal void 녴()
		{
			try
			{
				놓녨.놓녥.GetTrades(new TradesHistoryRequestParameters
				{
					From = 놓념.AddDays(-2.0),
					To = 놓념,
					CancellationToken = 놓녨.놓농
				});
			}
			catch (Exception ex)
			{
				Core.Instance.Loggers.Log(ex);
			}
		}
	}

	[CompilerGenerated]
	private sealed class 놭
	{
		public Connection 놓녺;

		public SubscribeQuotesParameters 놓놣;

		internal void 녴()
		{
			놓녺.놫녕.SubscribeSymbol(놓놣);
		}
	}

	[CompilerGenerated]
	private sealed class 녲
	{
		public Connection 놓녮;

		public SubscribeQuotesParameters 놓뇆;

		internal void 녴()
		{
			놓녮.놫녕.UnSubscribeSymbol(놓뇆);
		}
	}

	internal const string 놫놊 = "Test";

	internal 놶 놫놪;

	private string 놫놌;

	[CompilerGenerated]
	private ConnectionType 놫놕;

	[CompilerGenerated]
	private EventHandler<ConnectionStateChangedEventArgs> 놫뇊;

	[CompilerGenerated]
	private EventHandler<ConnectionConnectingProgressChangedEventArgs> 놫놋;

	[CompilerGenerated]
	private TimeSpan? 놫녣;

	[CompilerGenerated]
	private TimeSpan? 놫녩;

	private DateTime 놫놤;

	[CompilerGenerated]
	private ConnectionResult 놫논;

	[CompilerGenerated]
	private 놽 놫녘;

	[CompilerGenerated]
	private VolumeAnalysisStorage 놫노;

	private UsersTradesStorage 놫녒;

	private Vendor 놫녕;

	private CancellationTokenSource 놫녖;

	[CompilerGenerated]
	private readonly ConnectionInfo 녪녴;

	[CompilerGenerated]
	private EventHandler<RequestEventArgs> 녪놴;

	[CompilerGenerated]
	private EventHandler<PerformedRequestEventArgs> 녪놂;

	[CompilerGenerated]
	private Limiter 녪놎;

	private readonly ActionBufferedProcessor 녪녞;

	/// <summary>
	/// Provides access to all business objects which are belong to this connection
	/// </summary>
	public IBusinessObjectsProvider BusinessObjects => 놫놪;

	/// <summary>
	/// Gets connection Id
	/// </summary>
	public string Id
	{
		get
		{
			return Info.ConnectionId;
		}
		private set
		{
			Info.ConnectionId = value;
		}
	}

	/// <summary>
	/// Gets connection Name
	/// </summary>
	public string Name
	{
		get
		{
			return Info.Name;
		}
		set
		{
			Info.Name = value;
		}
	}

	/// <summary>
	/// Gets connection's vendor name
	/// </summary>
	public string VendorName => Info.VendorName;

	/// <summary>
	/// Contains list of connection settings. Will be reused on each population time.
	/// </summary>
	public IList<SettingItem> Settings
	{
		get
		{
			return Info.Settings;
		}
		set
		{
			Info.Settings = value;
		}
	}

	/// <summary>
	/// Gets connection's state (Connected/Connecting/Fail etc.)
	/// </summary>
	public ConnectionState State
	{
		get
		{
			return Info.ConnectionState;
		}
		private set
		{
			if (Info.ConnectionState != value)
			{
				ConnectionState connectionState = Info.ConnectionState;
				Info.ConnectionState = value;
				놫놤 = ((value == ConnectionState.Connected) ? Core.Instance.TimeUtils.DateTimeUtcNow : default(DateTime));
				녴(connectionState);
			}
		}
	}

	public string ConnectingProgress
	{
		get
		{
			return 놫놌;
		}
		private set
		{
			if (!(놫놌 == value))
			{
				놫놌 = value;
				놫놋?.Invoke(this, new ConnectionConnectingProgressChangedEventArgs(ConnectingProgress));
			}
		}
	}

	/// <summary>
	/// Defines connection type
	/// </summary>
	public ConnectionType Type
	{
		[CompilerGenerated]
		get
		{
			return 놫놕;
		}
		[CompilerGenerated]
		set
		{
			놫놕 = value;
		}
	}

	/// <summary>
	/// Represents connection ping time
	/// </summary>
	public TimeSpan? PingTime
	{
		[CompilerGenerated]
		get
		{
			return 놫녣;
		}
		[CompilerGenerated]
		private set
		{
			놫녣 = value;
		}
	}

	public TimeSpan? RoundTripTime
	{
		[CompilerGenerated]
		get
		{
			return 놫녩;
		}
		[CompilerGenerated]
		private set
		{
			놫녩 = value;
		}
	}

	/// <summary>
	/// Messages count that one is waited to process
	/// </summary>
	public int MessagesQueueDepth => 놫놪?.QueueDepth ?? 0;

	public TimeSpan Uptime
	{
		get
		{
			if (!(놫놤 == default(DateTime)))
			{
				return Core.Instance.TimeUtils.DateTimeUtcNow - 놫놤;
			}
			return TimeSpan.Zero;
		}
	}

	/// <summary>
	/// Gets a matched available metadata info with the vendor's side
	/// </summary>
	public HistoryMetadata HistoryMetaData => 놫놪.HistoryMetadata?.Copy;

	public TradesHistoryMetadata TradesHistoryMetadata
	{
		get
		{
			if (놫놪.UsersTradesCacheMetadata != null)
			{
				return new TradesHistoryMetadata(놫놪.UsersTradesCacheMetadata);
			}
			return null;
		}
	}

	public VolumeAnalysisMetadata VolumeAnalysisMetadata => 놫놪.VolumeAnalysisMetadata?.Copy;

	public IEnumerable<SettingItem> NewsFeedSettings => 놫놪?.NewsFeedSettings?.Select((SettingItem P_0) => P_0.GetCopy());

	public ConnectionResult LastConnectionResult
	{
		[CompilerGenerated]
		get
		{
			return 놫논;
		}
		[CompilerGenerated]
		private set
		{
			놫논 = value;
		}
	}

	internal 놽 HistoryLoadingManager
	{
		[CompilerGenerated]
		get
		{
			return 놫녘;
		}
		[CompilerGenerated]
		private set
		{
			놫녘 = value;
		}
	}

	internal VolumeAnalysisStorage VolumeAnalysisStorage
	{
		[CompilerGenerated]
		get
		{
			return 놫노;
		}
		[CompilerGenerated]
		private set
		{
			놫노 = value;
		}
	}

	internal bool Connected => State == ConnectionState.Connected;

	public ConnectionInfo Info
	{
		[CompilerGenerated]
		get
		{
			return 녪녴;
		}
	}

	public int TotalSubscriptionsCount => BusinessObjects.Symbols.Sum((Symbol P_0) => P_0.TotalSubscriptionsCount);

	public DateTime ServerTime => 놫녕?.ServerTime ?? Core.Instance.TimeUtils.DateTimeUtcNow;

	[NotPublished]
	public Limiter Limitation
	{
		[CompilerGenerated]
		get
		{
			return 녪놎;
		}
		[CompilerGenerated]
		private set
		{
			녪놎 = value;
		}
	}

	/// <summary>
	/// Will be triggered when <see cref="P:TradingPlatform.BusinessLayer.Connection.State" /> changed.
	/// </summary>
	public event EventHandler<ConnectionStateChangedEventArgs> StateChanged
	{
		[CompilerGenerated]
		add
		{
			EventHandler<ConnectionStateChangedEventArgs> eventHandler = 놫뇊;
			EventHandler<ConnectionStateChangedEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<ConnectionStateChangedEventArgs> value2 = (EventHandler<ConnectionStateChangedEventArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref 놫뇊, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<ConnectionStateChangedEventArgs> eventHandler = 놫뇊;
			EventHandler<ConnectionStateChangedEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<ConnectionStateChangedEventArgs> value2 = (EventHandler<ConnectionStateChangedEventArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref 놫뇊, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	/// <summary>
	/// Will be triggered when <see cref="P:TradingPlatform.BusinessLayer.Connection.ConnectingProgress" /> changed.
	/// </summary>
	public event EventHandler<ConnectionConnectingProgressChangedEventArgs> ConnectingProgressChanged
	{
		[CompilerGenerated]
		add
		{
			EventHandler<ConnectionConnectingProgressChangedEventArgs> eventHandler = 놫놋;
			EventHandler<ConnectionConnectingProgressChangedEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<ConnectionConnectingProgressChangedEventArgs> value2 = (EventHandler<ConnectionConnectingProgressChangedEventArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref 놫놋, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<ConnectionConnectingProgressChangedEventArgs> eventHandler = 놫놋;
			EventHandler<ConnectionConnectingProgressChangedEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<ConnectionConnectingProgressChangedEventArgs> value2 = (EventHandler<ConnectionConnectingProgressChangedEventArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref 놫놋, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler<RequestEventArgs> NewRequest
	{
		[CompilerGenerated]
		add
		{
			EventHandler<RequestEventArgs> eventHandler = 녪놴;
			EventHandler<RequestEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<RequestEventArgs> value2 = (EventHandler<RequestEventArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref 녪놴, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<RequestEventArgs> eventHandler = 녪놴;
			EventHandler<RequestEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<RequestEventArgs> value2 = (EventHandler<RequestEventArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref 녪놴, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler<PerformedRequestEventArgs> NewPerformedRequest
	{
		[CompilerGenerated]
		add
		{
			EventHandler<PerformedRequestEventArgs> eventHandler = 녪놂;
			EventHandler<PerformedRequestEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<PerformedRequestEventArgs> value2 = (EventHandler<PerformedRequestEventArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref 녪놂, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<PerformedRequestEventArgs> eventHandler = 녪놂;
			EventHandler<PerformedRequestEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<PerformedRequestEventArgs> value2 = (EventHandler<PerformedRequestEventArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref 녪놂, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	internal Connection(ConnectionInfo P_0)
	{
		녪녴 = P_0;
		Type = ConnectionType.General;
		if (string.IsNullOrEmpty(P_0.ConnectionId))
		{
			Id = Guid.NewGuid().ToString();
		}
		State = ConnectionState.Disconnected;
		녪녞 = new ActionBufferedProcessor();
	}

	/// <summary>
	/// Establishes a connection to a specified vendor
	/// </summary>
	/// <returns></returns>
	public ConnectionResult Connect()
	{
		LastConnectionResult = new ConnectionResult();
		IProgress<string> progress = new Progress<string>(delegate(string P_0)
		{
			ConnectingProgress = P_0;
		});
		if (State == ConnectionState.Connected)
		{
			return LastConnectionResult;
		}
		if (State == ConnectionState.Connecting)
		{
			LastConnectionResult.State = ConnectionState.Connecting;
			LastConnectionResult.Message = _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶놬();
			return LastConnectionResult;
		}
		if (State == ConnectionState.Disconnecting)
		{
			LastConnectionResult.State = ConnectionState.Connecting;
			LastConnectionResult.Message = _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶놊();
			return LastConnectionResult;
		}
		놫녖 = new CancellationTokenSource();
		CancellationToken 놓농 = 놫녖.Token;
		놫놪 = (Info.SyncMsgProcessing ? new 녜(Id) : new 놶(Id));
		progress.Report(null);
		State = ConnectionState.Connecting;
		놫놪.녴();
		VendorInfo vendorInfo = Core.Instance.Vendors[VendorName];
		놫녕 = vendorInfo.녴();
		놫녕.NewMessage += 녴;
		try
		{
			놓농.ThrowIfCancellationRequested();
			vendorInfo.놴();
			Core.Instance.Loggers.Log(Name + _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶놪());
			녴(놓농);
			LastConnectionResult = 놫녕.Connect(new ConnectRequestParameters
			{
				ConnectionSettings = Settings,
				BrowserFactory = Core.Instance.BrowserFactory,
				ConnectionId = Id,
				CancellationToken = 놓농,
				ConnectingProgress = progress
			});
			if (LastConnectionResult.UpdatedSettings != null)
			{
				Settings = LastConnectionResult.UpdatedSettings;
			}
			놓농.ThrowIfCancellationRequested();
			if (LastConnectionResult.State == ConnectionState.Fail)
			{
				State = ConnectionState.Disconnecting;
				녴();
				State = ConnectionState.Disconnected;
				Core.Instance.Loggers.Log(Name + _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶놌() + LastConnectionResult.Message);
				return LastConnectionResult;
			}
			놓농.ThrowIfCancellationRequested();
			progress.Report(loc._(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶놕(), null, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶뇊()));
			IList<MessageSessionsContainer> sessions = 놫녕.GetSessions(놓농);
			if (sessions != null)
			{
				foreach (MessageSessionsContainer item in sessions)
				{
					녴(item);
				}
			}
			놓농.ThrowIfCancellationRequested();
			progress.Report(loc._(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶놋(), null, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶뇊()));
			IList<MessageExchange> exchanges = 놫녕.GetExchanges(놓농);
			if (exchanges != null)
			{
				foreach (MessageExchange item2 in exchanges)
				{
					녴(item2);
				}
			}
			놓농.ThrowIfCancellationRequested();
			progress.Report(loc._(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶녣(), null, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶뇊()));
			IList<MessageSymbolGroup> symbolGroups = 놫녕.GetSymbolGroups(놓농);
			if (symbolGroups != null)
			{
				foreach (MessageSymbolGroup item3 in symbolGroups)
				{
					녴(item3);
				}
			}
			놓농.ThrowIfCancellationRequested();
			놫놪.HistoryMetadata = 놫녕.GetHistoryMetadata(놓농);
			놫놪.HistoryMetadata.AllowedPeriodsHistoryAggregationTime = 놫놪.HistoryMetadata.AllowedPeriodsHistoryAggregationTime.OrderByDescending((Period P_0) => P_0.Ticks).ToArray();
			놫놪.VolumeAnalysisMetadata = 놫녕.GetVolumeAnalysisMetadata();
			놫놪.NewsFeedSettings = 놫녕.GetNewsProviderSettings(놓농);
			놫놪.UsersTradesCacheMetadata = 놫녕.GetTradesMetadata();
			놫놪.LimitationMetadata = 놫녕.GetLimitationMetadata();
			if (놫놪.LimitationMetadata?.Limits != null)
			{
				Limitation = new Limiter(놫놪.LimitationMetadata);
			}
			놓농.ThrowIfCancellationRequested();
			progress.Report(loc._(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶녩(), null, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶뇊()));
			foreach (OrderType allowedOrderType in 놫녕.GetAllowedOrderTypes(놓농))
			{
				allowedOrderType.ConnectionId = Id;
				놫놪.OrderTypesCache.녴(allowedOrderType.Id, allowedOrderType);
			}
			놓농.ThrowIfCancellationRequested();
			progress.Report(loc._(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶놤(), null, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶뇊()));
			foreach (MessageAsset asset in 놫녕.GetAssets(놓농))
			{
				녴(asset);
			}
			progress.Report(loc._(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶녣(), null, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶뇊()));
			녴(놫녕.GetSymbolTypes(놓농));
			놓농.ThrowIfCancellationRequested();
			progress.Report(loc._(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶논(), null, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶뇊()));
			foreach (MessageAccount account in 놫녕.GetAccounts(놓농))
			{
				녴(account);
			}
			놓농.ThrowIfCancellationRequested();
			foreach (MessageCryptoAssetBalances cryptoAssetBalance in 놫녕.GetCryptoAssetBalances(놓농))
			{
				녴(cryptoAssetBalance);
			}
			놓농.ThrowIfCancellationRequested();
			progress.Report(loc._(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶녘(), null, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶뇊()));
			foreach (MessageOptionSerie item4 in 놫녕.GetAllOptionSeries(놓농))
			{
				녴(item4);
			}
			놓농.ThrowIfCancellationRequested();
			progress.Report(loc._(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶노(), null, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶뇊()));
			foreach (MessageSymbol symbol in 놫녕.GetSymbols(놓농))
			{
				녴(symbol);
			}
			놓농.ThrowIfCancellationRequested();
			progress.Report(loc._(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶녒(), null, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶뇊()));
			foreach (MessageRule rule in 놫녕.GetRules(놓농))
			{
				녴(rule);
			}
			놓농.ThrowIfCancellationRequested();
			progress.Report(loc._(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶녕(), null, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶뇊()));
			foreach (MessageOpenPosition position in 놫녕.GetPositions(놓농))
			{
				녴(position);
			}
			놓농.ThrowIfCancellationRequested();
			progress.Report(loc._(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶녖(), null, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶뇊()));
			foreach (MessageClosedPosition closedPosition in 놫녕.GetClosedPositions(놓농))
			{
				녴(closedPosition);
			}
			놓농.ThrowIfCancellationRequested();
			progress.Report(loc._(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵녴(), null, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶뇊()));
			foreach (MessageReportType reportsMetaDatum in 놫녕.GetReportsMetaData(놓농))
			{
				녴(reportsMetaDatum);
			}
			놓농.ThrowIfCancellationRequested();
			progress.Report(loc._(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵놴(), null, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶뇊()));
			foreach (MessageOpenOrder pendingOrder in 놫녕.GetPendingOrders(놓농))
			{
				녴(pendingOrder);
			}
			놓농.ThrowIfCancellationRequested();
			progress.Report(loc._(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵놂(), null, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶뇊()));
			foreach (MessageAccountOperation accountOperation in 놫녕.GetAccountOperations(놓농))
			{
				녴(accountOperation);
			}
			놓농.ThrowIfCancellationRequested();
			progress.Report(loc._(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵놎(), null, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶뇊()));
			foreach (MessageTradingSignal tradingSignal in 놫녕.GetTradingSignals(놓농))
			{
				녴(tradingSignal);
			}
			놓농.ThrowIfCancellationRequested();
			progress.Report(loc._(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵녞(), null, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶뇊()));
			놫놪.WaitAllMessagesProcess(놓농);
			progress.Report(null);
			놓농.ThrowIfCancellationRequested();
			놫녕.OnConnected(놓농);
			놓농.ThrowIfCancellationRequested();
			놁 놁 = new 놁
			{
				AllowLocalStorage = 놫놪.HistoryMetadata.UseHistoryLocalCache,
				DegreeOfParallelism = 놫놪.HistoryMetadata.DegreeOfParallelism,
				LoadHistoryDelegate = 녴
			};
			if (놁.AllowLocalStorage)
			{
				놁.LocalStorageConnectionString = Path.Combine(Const.HISTORY_PATH, (Name + _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂녙() + Id + _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놢()).EncodeFilePathPart(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵놫());
			}
			HistoryLoadingManager = 놽.녴(놁);
			if (놁.AllowLocalStorage)
			{
				VolumeAnalysisStorage = VolumeAnalysisStorage.Create(Path.Combine(Const.VOLUME_ANALYSIS_PATH, (Name + _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂녙() + Id + _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놢()).EncodeFilePathPart(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵녪()));
			}
			if (놫놪.UsersTradesCacheMetadata.AllowLocalStorage)
			{
				놫녒 = UsersTradesStorage.Create(Path.Combine(Const.USER_TRADES_CACHE_PATH, (Name + _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂녙() + Id + _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놢()).EncodeFilePathPart(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵녶()), Id);
				if (놫놪.UsersTradesCacheMetadata.LoadTradesFromCurrentTradingDate)
				{
					DateTime 놓념 = Core.Instance.TimeUtils.DateTimeUtcNow;
					Task.Factory.StartNew(delegate
					{
						try
						{
							GetTrades(new TradesHistoryRequestParameters
							{
								From = 놓념.AddDays(-2.0),
								To = 놓념,
								CancellationToken = 놓농
							});
						}
						catch (Exception ex)
						{
							Core.Instance.Loggers.Log(ex);
						}
					}, 놓농);
				}
			}
			놫놪.녪놀 = true;
			녪녞?.Start();
			State = ConnectionState.Connected;
		}
		catch (OperationCanceledException)
		{
			LastConnectionResult.State = ConnectionState.Fail;
			LastConnectionResult.Message = _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵녵();
			LastConnectionResult.Cancelled = true;
			State = ConnectionState.Disconnecting;
			녴();
			State = ConnectionState.Disconnected;
		}
		catch (Exception exception)
		{
			LastConnectionResult.State = ConnectionState.Fail;
			LastConnectionResult.Message = exception.GetFullMessageRecursive();
			State = ConnectionState.Fail;
			Core.Instance.Loggers.Log(LastConnectionResult.Message, LoggingLevel.Verbose);
			녴();
			State = ConnectionState.Disconnected;
		}
		finally
		{
			vendorInfo.놂();
		}
		ConnectionResult lastConnectionResult = LastConnectionResult;
		if (lastConnectionResult != null && lastConnectionResult.State == ConnectionState.Connected)
		{
			Core.Instance.Loggers.Log(Name + _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵놭());
			놂(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵녲());
		}
		else
		{
			Core.Instance.Loggers.Log(Name + _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶놌() + LastConnectionResult?.Message);
		}
		if (Type == ConnectionType.General && State == ConnectionState.Connected && Core.Instance.RulesManager.IsAllowed(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놓(), Id).Status != 0)
		{
			try
			{
				if ((Core.Instance.Licences.GetLicenceRuleItem(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놎녙()) ?? Core.Instance.Licences.GetLicenceRuleItem(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놟()) ?? Core.Instance.Licences.GetLicenceRuleItem(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놠()) ?? Core.Instance.Licences.GetLicenceRuleItem(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놎녱()) ?? Core.Instance.Licences.GetLicenceRuleItem(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놓())) == null)
				{
					Connection[] array = (from P_0 in Core.Instance.Connections.All
						where P_0 != this
						where P_0.State == ConnectionState.Connected || P_0.State == ConnectionState.Connecting
						where P_0.Type == ConnectionType.General
						where Core.Instance.RulesManager.IsAllowed(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놓(), P_0.Id).Status != TradingOperationStatus.Allowed
						select P_0).ToArray();
					if (array.Any())
					{
						Connection[] array2 = array;
						foreach (Connection connection in array2)
						{
							if (connection.LastConnectionResult != null)
							{
								connection.LastConnectionResult.State = ConnectionState.Fail;
								connection.LastConnectionResult.Message = _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵뇋();
							}
							connection.Disconnect();
						}
						MessageDealTicket messageDealTicket = new MessageDealTicket(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵놸(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵놿());
						녴(messageDealTicket);
					}
				}
			}
			catch (Exception ex3)
			{
				Core.Instance.Loggers.Log(ex3);
			}
		}
		return LastConnectionResult;
	}

	private void 녴(CancellationToken P_0)
	{
		IList<SettingItem> settings = Settings;
		if (!(settings.GetItemByPath(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵놄()) is SettingItemGroup { Value: IList<SettingItem> value }) || !(value.FirstOrDefault((SettingItem P_0) => P_0 is SettingItemOAuth) is SettingItemOAuth settingItemOAuth))
		{
			return;
		}
		OidcClientOptions copy = settingItemOAuth.OidcOptions.GetCopy();
		if (copy == null)
		{
			throw new Exception(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵놰());
		}
		if (settingItemOAuth.UpdateIdentityAuthorityUrl != null)
		{
			copy.Authority = settingItemOAuth.UpdateIdentityAuthorityUrl(settings, P_0);
		}
		if (string.IsNullOrEmpty(copy.Authority) && copy.ProviderInformation == null)
		{
			return;
		}
		int value2 = 55650;
		try
		{
			value2 = TcpIpHelper.GetRandomUnusedPort;
		}
		catch (Exception ex)
		{
			Core.Instance.Loggers.Log(ex, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵놓());
		}
		copy.Browser = new 녡(settingItemOAuth.AllowOpenNewWindow, value2)
		{
			놎녽 = Core.Instance.OAuthBrowserCreator
		};
		if (string.IsNullOrEmpty(copy.RedirectUri))
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(17, 1);
			defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵놇());
			defaultInterpolatedStringHandler.AppendFormatted(value2);
			string postLogoutRedirectUri = (copy.RedirectUri = defaultInterpolatedStringHandler.ToStringAndClear());
			copy.PostLogoutRedirectUri = postLogoutRedirectUri;
		}
		OidcClient oidcClient = new OidcClient(copy);
		LoginRequest loginRequest = new LoginRequest
		{
			BrowserDisplayMode = DisplayMode.Visible,
			BrowserTimeout = 300,
			BackChannelExtraParameters = settingItemOAuth.BackChannelExtraParameters
		};
		OAuthResult oAuthResult = settingItemOAuth.Value as OAuthResult;
		Result result = null;
		if (oAuthResult != null && !string.IsNullOrEmpty(oAuthResult.RefreshToken) && oAuthResult.UseSavedTokens)
		{
			RefreshTokenResult refreshTokenResult = null;
			if (VendorName.Contains(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵뇅()))
			{
				UriBuilder uriBuilder = new UriBuilder(copy.ProviderInformation.TokenEndpoint);
				NameValueCollection nameValueCollection = HttpUtility.ParseQueryString(string.Empty);
				nameValueCollection.Add(new NameValueCollection
				{
					{
						_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵놵(),
						copy.ClientId
					},
					{
						_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵놡(),
						copy.ClientSecret
					},
					{
						_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵놻(),
						oAuthResult.RefreshToken
					},
					{
						_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵놃(),
						_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵놻()
					}
				});
				uriBuilder.Query = nameValueCollection.ToString();
				using HttpClient httpClient = new HttpClient();
				TokenResponse result2 = ProtocolResponse.FromHttpResponseAsync<TokenResponse>(httpClient.Send(new HttpRequestMessage(HttpMethod.Get, uriBuilder.Uri), P_0)).Result;
				if (result2 != null && !result2.IsError)
				{
					refreshTokenResult = new RefreshTokenResult();
					try
					{
						Type? typeFromHandle = typeof(RefreshTokenResult);
						typeFromHandle.GetProperty(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵뇇())?.SetValue(refreshTokenResult, result2.AccessToken);
						typeFromHandle.GetProperty(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵놛())?.SetValue(refreshTokenResult, result2.RefreshToken);
						typeFromHandle.GetProperty(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵놼())?.SetValue(refreshTokenResult, result2.ExpiresIn);
					}
					catch (Exception ex2)
					{
						Core.Instance.Loggers.Log(ex2, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵놗());
					}
				}
			}
			else
			{
				refreshTokenResult = oidcClient.RefreshTokenAsync(oAuthResult.RefreshToken, null, null, P_0).Result;
			}
			result = refreshTokenResult;
			oAuthResult.RequestRefreshResult = refreshTokenResult;
		}
		else if (VendorName.Contains(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵뇅()))
		{
			result = new LoginResult();
			BrowserOptions options = new BrowserOptions(new RequestUrl(copy.ProviderInformation.AuthorizeEndpoint).CreateAuthorizeUrl(copy.ClientId, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵뇂(), redirectUri: copy.RedirectUri, scope: copy.Scope, state: null, nonce: null, loginHint: null, acrValues: null, prompt: null, responseMode: null, codeChallenge: null, codeChallengeMethod: null, display: null, maxAge: null), copy.RedirectUri)
			{
				Timeout = TimeSpan.FromSeconds(loginRequest.BrowserTimeout),
				DisplayMode = loginRequest.BrowserDisplayMode
			};
			BrowserResult result3 = copy.Browser.InvokeAsync(options, P_0).Result;
			if (result3.IsError)
			{
				throw new Exception(result3.Error);
			}
			NameValueCollection nameValueCollection2 = HttpUtility.ParseQueryString(result3.Response);
			if (!nameValueCollection2.AllKeys.Contains<string>(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵뇂()))
			{
				throw new Exception(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵놩());
			}
			using HttpClient httpClient2 = new HttpClient();
			new TokenClient(httpClient2, new TokenClientOptions
			{
				Address = copy.ProviderInformation.TokenEndpoint,
				ClientId = copy.ClientId,
				ClientSecret = copy.ClientSecret
			});
			string value3 = nameValueCollection2[_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵뇂()];
			UriBuilder uriBuilder2 = new UriBuilder(copy.ProviderInformation.TokenEndpoint);
			NameValueCollection nameValueCollection3 = HttpUtility.ParseQueryString(string.Empty);
			nameValueCollection3.Add(new NameValueCollection
			{
				{
					_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵놵(),
					copy.ClientId
				},
				{
					_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵놡(),
					copy.ClientSecret
				},
				{
					_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵녡(),
					copy.RedirectUri
				},
				{
					_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵놃(),
					_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵녦()
				},
				{
					_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵뇂(),
					value3
				}
			});
			uriBuilder2.Query = nameValueCollection3.ToString();
			TokenResponse result4 = ProtocolResponse.FromHttpResponseAsync<TokenResponse>(httpClient2.Send(new HttpRequestMessage(HttpMethod.Get, uriBuilder2.Uri), P_0)).Result;
			if (result4.IsError)
			{
				result.Error = result4.Error;
			}
			oAuthResult.TokenResponce = result4;
		}
		else
		{
			if (oAuthResult != null && !string.IsNullOrEmpty(oAuthResult.IdentityToken))
			{
				LogoutRequest request2 = new LogoutRequest
				{
					IdTokenHint = oAuthResult.IdentityToken
				};
				oidcClient.LogoutAsync(request2, P_0).Wait(P_0);
				Task.Delay(700, P_0).Wait(P_0);
			}
			result = (oAuthResult.RequestTokenResult = oidcClient.LoginAsync(loginRequest, P_0).Result);
		}
		Settings = new List<SettingItem>
		{
			new SettingItemGroup(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵놄(), new List<SettingItem> { settingItemOAuth })
		};
		if (!result.IsError)
		{
			return;
		}
		if (result.Error == BrowserResultType.UserCancel.ToString())
		{
			throw new OperationCanceledException();
		}
		throw new Exception(result.Error);
	}

	/// <summary>
	/// Closes a connection.
	/// </summary>
	public void Disconnect()
	{
		if (State == ConnectionState.Connecting)
		{
			놫녖.Cancel();
		}
		else if (State == ConnectionState.Connected)
		{
			놂(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵놀());
			State = ConnectionState.Disconnecting;
			Core.Instance.Loggers.Log(Name + _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵놔());
			녴();
			State = ConnectionState.Disconnected;
			Core.Instance.Loggers.Log(Name + _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵놾());
		}
	}

	private void 녴()
	{
		놫놪?.Stop();
		if (놫녕 != null)
		{
			try
			{
				놫녕.Disconnect();
			}
			catch (Exception ex)
			{
				Core.Instance.Loggers.Log(ex, null, LoggingLevel.Verbose);
			}
			놫녕.NewMessage -= 녴;
			놫녕 = null;
		}
		녪녞?.Stop();
		if (HistoryLoadingManager != null)
		{
			HistoryLoadingManager.Dispose();
			HistoryLoadingManager = null;
		}
		if (VolumeAnalysisStorage != null)
		{
			VolumeAnalysisStorage.Dispose();
			VolumeAnalysisStorage = null;
		}
		if (놫녒 != null)
		{
			놫녒.Dispose();
			놫녒 = null;
		}
		if (Limitation != null)
		{
			Limitation.Dispose();
			Limitation = null;
		}
	}

	internal void 놴()
	{
		if (놫녕 == null || State != 0)
		{
			return;
		}
		PingResult pingResult;
		try
		{
			pingResult = 놫녕.Ping();
			if (State != 0)
			{
				return;
			}
		}
		catch (Exception ex)
		{
			pingResult = new PingResult
			{
				State = PingEnum.Disconnected
			};
			Core.Instance.Loggers.Log(ex, null, LoggingLevel.Verbose);
		}
		if (pingResult != null && pingResult.State == PingEnum.Connected)
		{
			PingTime = pingResult.PingTime;
			RoundTripTime = pingResult.RoundTripTime;
		}
		else
		{
			녴();
			State = (pingResult.StopReconnecting ? ConnectionState.Disconnected : ConnectionState.ConnectionLost);
			Core.Instance.Loggers.Log(Name + _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵뇀() + (pingResult.StopReconnecting ? _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵놽() : string.Empty));
		}
	}

	public void SendCustomRequest(RequestParameters parameters)
	{
		try
		{
			if (!Connected)
			{
				Core.Instance.Loggers.Log(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵녿(), LoggingLevel.Verbose);
				return;
			}
			using CancellationTokenSource cancellationTokenSource = CancellationTokenSource.CreateLinkedTokenSource(parameters.CancellationToken, 놫녖.Token);
			parameters.CancellationToken = cancellationTokenSource.Token;
			녴(parameters);
			놫녕.SendCustomRequest(parameters);
		}
		catch (Exception ex)
		{
			Core.Instance.Loggers.Log(ex, null, LoggingLevel.Verbose);
		}
		finally
		{
			녴(parameters, (object)null);
		}
	}

	internal void 녴(Symbol P_0, SubscribeQuoteType P_1)
	{
		if (놫녕 != null)
		{
			SubscribeQuotesParameters 놓놣 = new SubscribeQuotesParameters(P_0.Id, P_1);
			녪녞.Push(delegate
			{
				놫녕.SubscribeSymbol(놓놣);
			});
		}
	}

	internal void 놴(Symbol P_0, SubscribeQuoteType P_1)
	{
		if (놫녕 != null)
		{
			SubscribeQuotesParameters 놓뇆 = new SubscribeQuotesParameters(P_0.Id, P_1);
			녪녞.Push(delegate
			{
				놫녕.UnSubscribeSymbol(놓뇆);
			});
		}
	}

	internal TradingOperationResult 녴(PlaceOrderRequestParameters P_0)
	{
		TradingOperationResult tradingOperationResult = null;
		using CancellationTokenSource cancellationTokenSource = CancellationTokenSource.CreateLinkedTokenSource(P_0.CancellationToken, 놫녖.Token);
		PlaceOrderRequestParameters placeOrderRequestParameters = new PlaceOrderRequestParameters(P_0)
		{
			CancellationToken = cancellationTokenSource.Token
		};
		try
		{
			if (!Connected)
			{
				long requestId = placeOrderRequestParameters.RequestId;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(14, 1);
				defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵놁());
				defaultInterpolatedStringHandler.AppendFormatted(State);
				tradingOperationResult = TradingOperationResult.CreateError(requestId, defaultInterpolatedStringHandler.ToStringAndClear());
				return tradingOperationResult;
			}
			AllowedResult allowedResult = TradingOperations.IsAllowed(TradingOperation.PlaceOrder, new TradingOperationParameters
			{
				Account = placeOrderRequestParameters.Account,
				Symbol = placeOrderRequestParameters.Symbol
			});
			if (allowedResult.Status == TradingOperationStatus.NotAllowed)
			{
				tradingOperationResult = TradingOperationResult.CreateError(placeOrderRequestParameters.RequestId, allowedResult.Reason);
				return tradingOperationResult;
			}
			if (placeOrderRequestParameters.OrderType == null)
			{
				tradingOperationResult = TradingOperationResult.CreateError(placeOrderRequestParameters.RequestId, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵녭());
				return tradingOperationResult;
			}
			if (placeOrderRequestParameters.TimeInForce == TimeInForce.Default)
			{
				placeOrderRequestParameters.TimeInForce = placeOrderRequestParameters.OrderType.AllowedTifs.FirstOrDefault();
			}
			녴((RequestParameters)placeOrderRequestParameters);
			Core.Instance.Loggers.Log(placeOrderRequestParameters, LoggingLevel.Trading, Name);
			tradingOperationResult = 놫녕.PlaceOrder(placeOrderRequestParameters);
		}
		catch (Exception ex)
		{
			tradingOperationResult = TradingOperationResult.CreateError(placeOrderRequestParameters.RequestId, ex.Message);
		}
		finally
		{
			Core.Instance.Loggers.Log(tradingOperationResult, LoggingLevel.Trading, Name);
			녴(placeOrderRequestParameters, tradingOperationResult);
		}
		return tradingOperationResult;
	}

	internal TradingOperationResult 녴(PlaceMultiOrderOrderRequestParameters P_0)
	{
		TradingOperationResult tradingOperationResult = null;
		using CancellationTokenSource cancellationTokenSource = CancellationTokenSource.CreateLinkedTokenSource(P_0.CancellationToken, 놫녖.Token);
		PlaceMultiOrderOrderRequestParameters placeMultiOrderOrderRequestParameters = new PlaceMultiOrderOrderRequestParameters(P_0)
		{
			CancellationToken = cancellationTokenSource.Token
		};
		try
		{
			if (!Connected)
			{
				long requestId = placeMultiOrderOrderRequestParameters.RequestId;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(14, 1);
				defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵놁());
				defaultInterpolatedStringHandler.AppendFormatted(State);
				tradingOperationResult = TradingOperationResult.CreateError(requestId, defaultInterpolatedStringHandler.ToStringAndClear());
				return tradingOperationResult;
			}
			if (placeMultiOrderOrderRequestParameters.OrderParameters == null || !placeMultiOrderOrderRequestParameters.OrderParameters.Any())
			{
				tradingOperationResult = TradingOperationResult.CreateError(placeMultiOrderOrderRequestParameters.RequestId, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵녱());
				return tradingOperationResult;
			}
			if (placeMultiOrderOrderRequestParameters.OrderParameters.Select((PlaceOrderRequestParameters P_0) => P_0.Symbol.ConnectionId).Distinct().Count() > 1)
			{
				tradingOperationResult = TradingOperationResult.CreateError(placeMultiOrderOrderRequestParameters.RequestId, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵놲());
				return tradingOperationResult;
			}
			if (placeMultiOrderOrderRequestParameters.GroupOrderType == GroupOrderType.OCO && Core.Instance.RulesManager.IsAllowed(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵높(), Id).Status != 0)
			{
				tradingOperationResult = TradingOperationResult.CreateError(placeMultiOrderOrderRequestParameters.RequestId, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵놶());
				return tradingOperationResult;
			}
			PlaceOrderRequestParameters[] orderParameters = placeMultiOrderOrderRequestParameters.OrderParameters;
			foreach (PlaceOrderRequestParameters placeOrderRequestParameters in orderParameters)
			{
				AllowedResult allowedResult = TradingOperations.IsAllowed(TradingOperation.PlaceOrder, new TradingOperationParameters
				{
					Account = placeOrderRequestParameters.Account,
					Symbol = placeOrderRequestParameters.Symbol
				});
				if (allowedResult.Status == TradingOperationStatus.NotAllowed)
				{
					tradingOperationResult = TradingOperationResult.CreateError(placeMultiOrderOrderRequestParameters.RequestId, allowedResult.Reason);
					return tradingOperationResult;
				}
			}
			녴((RequestParameters)placeMultiOrderOrderRequestParameters);
			Core.Instance.Loggers.Log(placeMultiOrderOrderRequestParameters, LoggingLevel.Trading, Name);
			tradingOperationResult = 놫녕.PlaceMultiOrder(placeMultiOrderOrderRequestParameters);
		}
		catch (Exception ex)
		{
			tradingOperationResult = TradingOperationResult.CreateError(placeMultiOrderOrderRequestParameters.RequestId, ex.Message);
		}
		finally
		{
			Core.Instance.Loggers.Log(tradingOperationResult, LoggingLevel.Trading, Name);
			녴(placeMultiOrderOrderRequestParameters, tradingOperationResult);
		}
		return tradingOperationResult;
	}

	internal TradingOperationResult 녴(ModifyOrderRequestParameters P_0)
	{
		TradingOperationResult tradingOperationResult = null;
		using CancellationTokenSource cancellationTokenSource = CancellationTokenSource.CreateLinkedTokenSource(P_0.CancellationToken, 놫녖.Token);
		ModifyOrderRequestParameters modifyOrderRequestParameters = new ModifyOrderRequestParameters(P_0)
		{
			CancellationToken = cancellationTokenSource.Token
		};
		try
		{
			if (!Connected)
			{
				long requestId = modifyOrderRequestParameters.RequestId;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(14, 1);
				defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵놁());
				defaultInterpolatedStringHandler.AppendFormatted(State);
				tradingOperationResult = TradingOperationResult.CreateError(requestId, defaultInterpolatedStringHandler.ToStringAndClear());
				return tradingOperationResult;
			}
			AllowedResult allowedResult = TradingOperations.IsAllowed(TradingOperation.ModifyOrder, new TradingOperationParameters
			{
				Account = modifyOrderRequestParameters.Account,
				Symbol = modifyOrderRequestParameters.Symbol
			});
			if (allowedResult.Status == TradingOperationStatus.NotAllowed)
			{
				tradingOperationResult = TradingOperationResult.CreateError(modifyOrderRequestParameters.RequestId, allowedResult.Reason);
				return tradingOperationResult;
			}
			if (modifyOrderRequestParameters.TimeInForce == TimeInForce.Default)
			{
				modifyOrderRequestParameters.TimeInForce = modifyOrderRequestParameters.OrderType.AllowedTifs.FirstOrDefault();
			}
			녴((RequestParameters)modifyOrderRequestParameters);
			Core.Instance.Loggers.Log(modifyOrderRequestParameters, LoggingLevel.Trading, Name);
			tradingOperationResult = 놫녕.ModifyOrder(modifyOrderRequestParameters);
		}
		catch (Exception ex)
		{
			tradingOperationResult = TradingOperationResult.CreateError(modifyOrderRequestParameters.RequestId, ex.Message);
		}
		finally
		{
			Core.Instance.Loggers.Log(tradingOperationResult, LoggingLevel.Trading, Name);
			녴(modifyOrderRequestParameters, tradingOperationResult);
		}
		return tradingOperationResult;
	}

	internal TradingOperationResult 녴(ClosePositionRequestParameters P_0)
	{
		TradingOperationResult tradingOperationResult = null;
		using CancellationTokenSource cancellationTokenSource = CancellationTokenSource.CreateLinkedTokenSource(P_0.CancellationToken, 놫녖.Token);
		ClosePositionRequestParameters closePositionRequestParameters = new ClosePositionRequestParameters(P_0)
		{
			CancellationToken = cancellationTokenSource.Token
		};
		try
		{
			if (!Connected)
			{
				long requestId = closePositionRequestParameters.RequestId;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(14, 1);
				defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵놁());
				defaultInterpolatedStringHandler.AppendFormatted(State);
				tradingOperationResult = TradingOperationResult.CreateError(requestId, defaultInterpolatedStringHandler.ToStringAndClear());
				return tradingOperationResult;
			}
			AllowedResult allowedResult = TradingOperations.IsAllowed(TradingOperation.ClosePosition, new TradingOperationParameters
			{
				Position = closePositionRequestParameters.Position
			});
			if (allowedResult.Status == TradingOperationStatus.NotAllowed)
			{
				tradingOperationResult = TradingOperationResult.CreateError(closePositionRequestParameters.RequestId, allowedResult.Reason);
				return tradingOperationResult;
			}
			녴((RequestParameters)closePositionRequestParameters);
			Core.Instance.Loggers.Log(closePositionRequestParameters, LoggingLevel.Trading, Name);
			tradingOperationResult = 놫녕.ClosePosition(closePositionRequestParameters);
		}
		catch (Exception ex)
		{
			tradingOperationResult = TradingOperationResult.CreateError(closePositionRequestParameters.RequestId, ex.Message);
		}
		finally
		{
			Core.Instance.Loggers.Log(tradingOperationResult, LoggingLevel.Trading, Name);
			녴(closePositionRequestParameters, tradingOperationResult);
		}
		return tradingOperationResult;
	}

	internal TradingOperationResult 녴(CancelOrderRequestParameters P_0)
	{
		TradingOperationResult tradingOperationResult = null;
		using CancellationTokenSource cancellationTokenSource = CancellationTokenSource.CreateLinkedTokenSource(P_0.CancellationToken, 놫녖.Token);
		CancelOrderRequestParameters cancelOrderRequestParameters = new CancelOrderRequestParameters(P_0)
		{
			CancellationToken = cancellationTokenSource.Token
		};
		try
		{
			if (!Connected)
			{
				long requestId = cancelOrderRequestParameters.RequestId;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(14, 1);
				defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵놁());
				defaultInterpolatedStringHandler.AppendFormatted(State);
				tradingOperationResult = TradingOperationResult.CreateError(requestId, defaultInterpolatedStringHandler.ToStringAndClear());
				return tradingOperationResult;
			}
			AllowedResult allowedResult = TradingOperations.IsAllowed(TradingOperation.CancelOrder, new TradingOperationParameters
			{
				Order = cancelOrderRequestParameters.Order
			});
			if (allowedResult.Status == TradingOperationStatus.NotAllowed)
			{
				tradingOperationResult = TradingOperationResult.CreateError(cancelOrderRequestParameters.RequestId, allowedResult.Reason);
				return tradingOperationResult;
			}
			녴((RequestParameters)cancelOrderRequestParameters);
			Core.Instance.Loggers.Log(cancelOrderRequestParameters, LoggingLevel.Trading, Name);
			tradingOperationResult = 놫녕.CancelOrder(cancelOrderRequestParameters);
			return tradingOperationResult;
		}
		catch (Exception ex)
		{
			tradingOperationResult = TradingOperationResult.CreateError(P_0.RequestId, ex.Message);
			return tradingOperationResult;
		}
		finally
		{
			Core.Instance.Loggers.Log(tradingOperationResult, LoggingLevel.Trading, Name);
			녴(cancelOrderRequestParameters, tradingOperationResult);
		}
	}

	internal MarginInfo 녴(OrderRequestParameters P_0)
	{
		MarginInfo result = null;
		if (!Connected)
		{
			Core.Instance.Loggers.Log(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵녿(), LoggingLevel.Verbose);
			return result;
		}
		try
		{
			using CancellationTokenSource cancellationTokenSource = CancellationTokenSource.CreateLinkedTokenSource(P_0.CancellationToken, 놫녖.Token);
			P_0.CancellationToken = cancellationTokenSource.Token;
			result = 놫녕.GetMarginInfo(P_0);
		}
		catch (Exception ex)
		{
			Core.Instance.Loggers.Log(ex, null, LoggingLevel.Verbose);
		}
		return result;
	}

	internal Symbol 녴(GetSymbolRequestParameters P_0, NonFixedListDownload P_1 = NonFixedListDownload.Download)
	{
		if (!Connected)
		{
			Core.Instance.Loggers.Log(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵녿(), LoggingLevel.Verbose);
			return null;
		}
		return 놴(P_0, P_1);
	}

	internal Symbol 놴(GetSymbolRequestParameters P_0, NonFixedListDownload P_1 = NonFixedListDownload.Download)
	{
		Symbol symbol = null;
		if (string.IsNullOrEmpty(P_0.SymbolId))
		{
			return symbol;
		}
		if (놫놪.SymbolsCache.녴(P_0.SymbolId, out symbol))
		{
			return symbol;
		}
		if (!놫녕.AllowNonFixedList || P_1 == NonFixedListDownload.IgnoreDownload)
		{
			return symbol;
		}
		뇋<Symbol> 뇋 = 놫놪.GetSymbolRequestCache.녴(P_0);
		if (뇋 != null && 뇋.Finished)
		{
			return 뇋.Result;
		}
		try
		{
			using CancellationTokenSource cancellationTokenSource = CancellationTokenSource.CreateLinkedTokenSource(P_0.CancellationToken, 놫녖.Token);
			GetSymbolRequestParameters getSymbolRequestParameters = new GetSymbolRequestParameters(P_0)
			{
				CancellationToken = cancellationTokenSource.Token
			};
			MessageSymbol nonFixedSymbol = 놫녕.GetNonFixedSymbol(getSymbolRequestParameters);
			if (nonFixedSymbol == null)
			{
				return symbol;
			}
			놫놪.Push(nonFixedSymbol);
			CancellationTokenSource cancellationTokenSource2 = new CancellationTokenSource(TimeSpan.FromSeconds(15.0));
			using CancellationTokenSource cancellationTokenSource3 = CancellationTokenSource.CreateLinkedTokenSource(getSymbolRequestParameters.CancellationToken, cancellationTokenSource2.Token);
			while (!cancellationTokenSource3.IsCancellationRequested)
			{
				if (놫놪.SymbolsCache.녴(nonFixedSymbol.Id, out symbol))
				{
					return symbol;
				}
				Thread.Sleep(100);
			}
			Core.Instance.Loggers.Log(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵뇏() + P_0.SymbolId, LoggingLevel.Verbose);
		}
		catch (Exception ex)
		{
			Core.Instance.Loggers.Log(ex, null, LoggingLevel.Verbose);
		}
		finally
		{
			if (!P_0.CancellationToken.IsCancellationRequested)
			{
				놫놪.GetSymbolRequestCache.녴(P_0, symbol);
			}
		}
		return symbol;
	}

	internal IList<Symbol> 녴(SearchSymbolsRequestParameters P_0)
	{
		List<Symbol> list = new List<Symbol>();
		if (!Connected)
		{
			Core.Instance.Loggers.Log(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵녿(), LoggingLevel.Verbose);
			return null;
		}
		using CancellationTokenSource cancellationTokenSource = CancellationTokenSource.CreateLinkedTokenSource(P_0.CancellationToken, 놫녖.Token);
		SearchSymbolsRequestParameters searchSymbolsRequestParameters = new SearchSymbolsRequestParameters(P_0)
		{
			CancellationToken = cancellationTokenSource.Token
		};
		searchSymbolsRequestParameters.SymbolTypes = searchSymbolsRequestParameters.SymbolTypes.Intersect(BusinessObjects.SymbolTypes).ToList();
		if (string.IsNullOrEmpty(searchSymbolsRequestParameters.FilterName) || !놫녕.AllowNonFixedList)
		{
			return 놴(searchSymbolsRequestParameters);
		}
		뇋<List<Symbol>> 뇋 = 놫놪.SearchSymbolsRequestCache.녴(searchSymbolsRequestParameters);
		if (뇋 != null && 뇋.Finished)
		{
			return new List<Symbol>(뇋.Result);
		}
		try
		{
			IList<MessageSymbolInfo> list2 = 놫녕.SearchSymbols(new SearchSymbolsRequestParameters(searchSymbolsRequestParameters));
			if (list2 == null || list2.Count == 0)
			{
				return list;
			}
			foreach (MessageSymbolInfo item in list2)
			{
				if (item != null)
				{
					list.Add(놫놪.녴(item));
				}
			}
		}
		catch (Exception ex)
		{
			Core.Instance.Loggers.Log(ex, null, LoggingLevel.Verbose);
		}
		finally
		{
			if (!searchSymbolsRequestParameters.CancellationToken.IsCancellationRequested)
			{
				놫놪.SearchSymbolsRequestCache.녴(searchSymbolsRequestParameters, new List<Symbol>(list));
			}
		}
		return list;
	}

	internal IList<Symbol> 녴(GetFutureContractsRequestParameters P_0)
	{
		IList<Symbol> list = new List<Symbol>();
		if (!Connected)
		{
			Core.Instance.Loggers.Log(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵녿(), LoggingLevel.Verbose);
			return null;
		}
		using CancellationTokenSource cancellationTokenSource = CancellationTokenSource.CreateLinkedTokenSource(P_0.CancellationToken, 놫녖.Token);
		GetFutureContractsRequestParameters getFutureContractsRequestParameters = new GetFutureContractsRequestParameters(P_0)
		{
			CancellationToken = cancellationTokenSource.Token
		};
		if (!놫녕.AllowNonFixedList)
		{
			return 녴(getFutureContractsRequestParameters, false);
		}
		뇋<List<Symbol>> 뇋 = 놫놪.GetFutureContractsRequestCache.녴(getFutureContractsRequestParameters);
		if (뇋 != null && 뇋.Finished)
		{
			return new List<Symbol>(뇋.Result);
		}
		try
		{
			IList<MessageSymbolInfo> futureContracts = 놫녕.GetFutureContracts(getFutureContractsRequestParameters);
			if (futureContracts == null || futureContracts.Count == 0)
			{
				return list;
			}
			foreach (MessageSymbolInfo item in futureContracts)
			{
				if (item != null)
				{
					list.Add(놫놪.녴(item));
				}
			}
		}
		catch (Exception ex)
		{
			Core.Instance.Loggers.Log(ex, null, LoggingLevel.Verbose);
		}
		finally
		{
			if (!getFutureContractsRequestParameters.CancellationToken.IsCancellationRequested)
			{
				놫놪.GetFutureContractsRequestCache.녴(getFutureContractsRequestParameters, new List<Symbol>(list));
			}
		}
		return list;
	}

	internal IList<OptionSerie> 녴(GetOptionSeriesRequestParameters P_0)
	{
		List<OptionSerie> list = new List<OptionSerie>();
		if (!Connected)
		{
			Core.Instance.Loggers.Log(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵녿(), LoggingLevel.Verbose);
			return list;
		}
		using CancellationTokenSource cancellationTokenSource = CancellationTokenSource.CreateLinkedTokenSource(P_0.CancellationToken, 놫녖.Token);
		GetOptionSeriesRequestParameters getOptionSeriesRequestParameters = new GetOptionSeriesRequestParameters(P_0)
		{
			CancellationToken = cancellationTokenSource.Token
		};
		if (!놫녕.AllowNonFixedList)
		{
			return 놴(getOptionSeriesRequestParameters);
		}
		뇋<List<OptionSerie>> 뇋 = 놫놪.GetOptionSeriesRequestCache.녴(getOptionSeriesRequestParameters);
		if (뇋 != null && 뇋.Finished)
		{
			return new List<OptionSerie>(뇋.Result);
		}
		try
		{
			IList<MessageOptionSerie> optionSeries = 놫녕.GetOptionSeries(getOptionSeriesRequestParameters);
			if (optionSeries == null)
			{
				return list;
			}
			foreach (MessageOptionSerie item in optionSeries)
			{
				if (item != null)
				{
					list.Add(놫놪.녴(item));
				}
			}
			list = list.OrderBy((OptionSerie P_0) => P_0.ExpirationDate).ToList();
		}
		catch (Exception ex)
		{
			Core.Instance.Loggers.Log(ex, null, LoggingLevel.Verbose);
		}
		finally
		{
			if (!getOptionSeriesRequestParameters.CancellationToken.IsCancellationRequested)
			{
				놫놪.GetOptionSeriesRequestCache.녴(getOptionSeriesRequestParameters, new List<OptionSerie>(list));
			}
		}
		return list;
	}

	internal IList<Symbol> 녴(GetStrikesRequestParameters P_0)
	{
		List<Symbol> list = new List<Symbol>();
		if (!Connected)
		{
			Core.Instance.Loggers.Log(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵녿(), LoggingLevel.Verbose);
			return null;
		}
		using CancellationTokenSource cancellationTokenSource = CancellationTokenSource.CreateLinkedTokenSource(P_0.CancellationToken, 놫녖.Token);
		GetStrikesRequestParameters getStrikesRequestParameters = new GetStrikesRequestParameters(P_0)
		{
			CancellationToken = cancellationTokenSource.Token
		};
		if (!놫녕.AllowNonFixedList)
		{
			return 놫놪.Symbols.Where((Symbol P_0) => P_0.OptionSerie != null && P_0.OptionSerie.Id == P_0.SerieId).ToList();
		}
		뇋<List<Symbol>> 뇋 = 놫놪.GetStrikesRequestCache.녴(getStrikesRequestParameters);
		if (뇋 != null && 뇋.Finished)
		{
			return new List<Symbol>(뇋.Result);
		}
		try
		{
			IList<MessageSymbolInfo> strikes = 놫녕.GetStrikes(new GetStrikesRequestParameters(getStrikesRequestParameters));
			if (strikes == null)
			{
				return list;
			}
			foreach (MessageSymbolInfo item in strikes)
			{
				if (item != null)
				{
					list.Add(놫놪.녴(item));
				}
			}
		}
		catch (Exception ex)
		{
			Core.Instance.Loggers.Log(ex, null, LoggingLevel.Verbose);
		}
		finally
		{
			if (!getStrikesRequestParameters.CancellationToken.IsCancellationRequested)
			{
				놫놪.GetStrikesRequestCache.녴(getStrikesRequestParameters, new List<Symbol>(list));
			}
		}
		return list;
	}

	private IList<Symbol> 놴(SearchSymbolsRequestParameters P_0)
	{
		IEnumerable<Symbol> source = 놫놪.Symbols;
		IList<string> 놓녳 = P_0.ExchangeIds;
		if (놓녳 != null && 놓녳.Any())
		{
			source = source.Where((Symbol P_0) => 놓녳.Contains(P_0.ExchangeId));
		}
		IList<SymbolType> 놓놉 = P_0.SymbolTypes;
		if (놓놉 != null && 놓놉.Any())
		{
			source = source.Where((Symbol P_0) => 놓놉.Contains(P_0.SymbolType));
		}
		string filterName = P_0.FilterName;
		if (string.IsNullOrEmpty(filterName))
		{
			return source.ToList();
		}
		string[] 놓놥 = filterName.Split(new char[1] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
		return source.Where((Symbol P_0) => 녴(놓놥, P_0, P_0.GetSynonyms)).ToList();
	}

	private IList<Symbol> 녴(GetFutureContractsRequestParameters P_0, bool P_1 = false)
	{
		List<Symbol> list = new List<Symbol>();
		ICollection<Symbol> collection;
		if (!P_1)
		{
			ICollection<Symbol> symbols = 놫놪.Symbols;
			collection = symbols;
		}
		else
		{
			collection = 놫놪.SymbolsInfoCache.Values;
		}
		foreach (Symbol item in collection)
		{
			if (item.SymbolType != SymbolType.Futures && item.SymbolType != SymbolType.Forward)
			{
				continue;
			}
			if (!string.IsNullOrEmpty(P_0.UnderlierId))
			{
				if (item.Underlier != null && item.Underlier.Id == P_0.UnderlierId)
				{
					list.Add(item);
				}
			}
			else if (item.Root == P_0.Root)
			{
				list.Add(item);
			}
		}
		return list;
	}

	private IList<OptionSerie> 놴(GetOptionSeriesRequestParameters P_0)
	{
		if (놫놪.OptionSeriesCache.녴(P_0.UnderlierId, out var result))
		{
			return result;
		}
		return new List<OptionSerie>();
	}

	private static bool 녴(string[] P_0, Symbol P_1, Func<string, string> P_2)
	{
		bool result = true;
		foreach (string text in P_0)
		{
			bool num = P_1.Name.Contains(text, StringComparison.InvariantCultureIgnoreCase);
			bool flag = !string.IsNullOrEmpty(P_1.Description) && P_1.Description.Contains(text, StringComparison.InvariantCultureIgnoreCase);
			bool flag2 = text.Length > 2 && P_1.Name.Contains(text.Insert(3, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶녢()), StringComparison.InvariantCultureIgnoreCase);
			bool flag3 = text.Length > 3 && text[3] == '/' && P_1.Name.Contains(text.Remove(3, 1), StringComparison.InvariantCultureIgnoreCase);
			bool flag4 = false;
			bool flag5 = false;
			bool flag6 = false;
			if (P_2 != null)
			{
				string text2 = P_2(text);
				if (!string.IsNullOrEmpty(text2))
				{
					flag4 = P_1.Name.Contains(text2, StringComparison.InvariantCultureIgnoreCase);
					flag5 = text2.Length > 2 && P_1.Name.Contains(text2.Insert(3, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶녢()), StringComparison.InvariantCultureIgnoreCase);
					flag6 = text2.Length > 3 && text2[3] == '/' && P_1.Name.Contains(text2.Remove(3, 1), StringComparison.InvariantCultureIgnoreCase);
				}
			}
			if (!num && !flag && !flag2 && !flag3 && !flag4 && !flag5 && !flag6)
			{
				result = false;
				break;
			}
		}
		return result;
	}

	internal Order 녴(string P_0)
	{
		if (State != 0)
		{
			return null;
		}
		if (놫놪 == null)
		{
			return null;
		}
		if (놫놪.OrdersCache.녴(P_0, out var result))
		{
			return result;
		}
		return null;
	}

	internal PnL 녴(PnLRequestParameters P_0)
	{
		if (!Connected)
		{
			Core.Instance.Loggers.Log(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵녿(), LoggingLevel.Verbose);
			return null;
		}
		try
		{
			using CancellationTokenSource cancellationTokenSource = CancellationTokenSource.CreateLinkedTokenSource(P_0.CancellationToken, 놫녖.Token);
			PnL pnL = 놫녕.CalculatePnL(new PnLRequestParameters(P_0)
			{
				CancellationToken = cancellationTokenSource.Token
			});
			if (pnL == null)
			{
				return pnL;
			}
			if (pnL.GrossPnL != null)
			{
				pnL.GrossPnL.ConnectionId = Id;
			}
			if (pnL.NetPnL != null)
			{
				pnL.NetPnL.ConnectionId = Id;
			}
			if (pnL.Fee != null)
			{
				pnL.Fee.ConnectionId = Id;
			}
			return pnL;
		}
		catch (Exception ex)
		{
			Core.Instance.Loggers.Log(ex, null, LoggingLevel.Verbose);
		}
		return null;
	}

	internal Position 놴(string P_0)
	{
		if (State != 0)
		{
			return null;
		}
		if (놫놪 == null)
		{
			return null;
		}
		if (놫놪.PositionsCache.녴(P_0, out var result))
		{
			return result;
		}
		return null;
	}

	private IList<IHistoryItem> 녴(HistoryRequestParameters P_0)
	{
		IList<IHistoryItem> list = new List<IHistoryItem>();
		if (!Connected)
		{
			Core.Instance.Loggers.Log(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵녿(), LoggingLevel.Verbose);
			return list;
		}
		try
		{
			using CancellationTokenSource cancellationTokenSource = CancellationTokenSource.CreateLinkedTokenSource(P_0.CancellationToken, 놫녖.Token);
			LoggerManager loggers = Core.Instance.Loggers;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 3);
			defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵녻());
			defaultInterpolatedStringHandler.AppendFormatted(P_0.Aggregation);
			defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵녙());
			defaultInterpolatedStringHandler.AppendFormatted(P_0.FromTime);
			defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵놢());
			defaultInterpolatedStringHandler.AppendFormatted(P_0.ToTime);
			loggers.Log(defaultInterpolatedStringHandler.ToStringAndClear(), LoggingLevel.LoadingHistory, Name);
			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();
			list = 놫녕.LoadHistory(new HistoryRequestParameters(P_0)
			{
				CancellationToken = cancellationTokenSource.Token
			});
			stopwatch.Stop();
			bool flag = list != null;
			LoggerManager loggers2 = Core.Instance.Loggers;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(54, 6);
			defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵녻());
			defaultInterpolatedStringHandler.AppendFormatted(P_0.Aggregation);
			defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵녙());
			defaultInterpolatedStringHandler.AppendFormatted(P_0.FromTime);
			defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵놢());
			defaultInterpolatedStringHandler.AppendFormatted(P_0.ToTime);
			defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵녧());
			defaultInterpolatedStringHandler.AppendFormatted(flag ? _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵놆() : _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵녤());
			defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵뇎());
			defaultInterpolatedStringHandler.AppendFormatted(list?.Count ?? 0);
			defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵놷());
			defaultInterpolatedStringHandler.AppendFormatted(stopwatch.Elapsed.TotalSeconds, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵녗());
			defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵놜());
			loggers2.Log(defaultInterpolatedStringHandler.ToStringAndClear(), LoggingLevel.LoadingHistory, Name);
		}
		catch (Exception ex)
		{
			Core.Instance.Loggers.Log(ex, null, LoggingLevel.Verbose);
		}
		return list;
	}

	[Obfuscation(Exclude = true)]
	internal VolumeAnalysisInterval LoadVolumeAnalysis(VolumeAnalysisByPeriodRequestParameters requestParameters)
	{
		if (!Connected)
		{
			Core.Instance.Loggers.Log(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵녿(), LoggingLevel.Verbose);
			return null;
		}
		try
		{
			using CancellationTokenSource cancellationTokenSource = CancellationTokenSource.CreateLinkedTokenSource(requestParameters.CancellationToken, 놫녖.Token);
			VolumeAnalysisByPeriodRequestParameters volumeAnalysisByPeriodRequestParameters = new VolumeAnalysisByPeriodRequestParameters(requestParameters)
			{
				CancellationToken = cancellationTokenSource.Token
			};
			VendorVolumeAnalysisByPeriodResponse vendorVolumeAnalysisByPeriodResponse = 놫녕.LoadVolumeAnalysis(volumeAnalysisByPeriodRequestParameters);
			if (vendorVolumeAnalysisByPeriodResponse == null)
			{
				return null;
			}
			return new VolumeAnalysisInterval
			{
				Interval = vendorVolumeAnalysisByPeriodResponse.ActualDataInterval,
				Description = volumeAnalysisByPeriodRequestParameters.ToDescription(),
				VolumeAnalysis = vendorVolumeAnalysisByPeriodResponse.Data
			};
		}
		catch (Exception ex)
		{
			Core.Instance.Loggers.Log(ex, null, LoggingLevel.Verbose);
		}
		return null;
	}

	public IEnumerable<NewsArticle> GetNews(GetNewsRequestParameters requestParameters)
	{
		using CancellationTokenSource cancellationTokenSource = CancellationTokenSource.CreateLinkedTokenSource(requestParameters.CancellationToken, 놫녖.Token);
		IEnumerable<MessageNewsHeadline> news = 놫녕.GetNews(new GetNewsRequestParameters(requestParameters)
		{
			CancellationToken = cancellationTokenSource.Token
		});
		if (news == null)
		{
			return Array.Empty<NewsArticle>();
		}
		if (!news.Any())
		{
			return Array.Empty<NewsArticle>();
		}
		List<NewsArticle> list = new List<NewsArticle>();
		foreach (MessageNewsHeadline item in news)
		{
			if (item != null)
			{
				if (requestParameters.CancellationToken.IsCancellationRequested)
				{
					break;
				}
				NewsArticle newsArticle = new NewsArticle(Id);
				newsArticle.녴(item);
				list.Add(newsArticle);
			}
		}
		return list.ToArray();
	}

	public string GetNewsArticleContent(GetNewsArticleContentRequestParameters requestParameters)
	{
		using CancellationTokenSource cancellationTokenSource = CancellationTokenSource.CreateLinkedTokenSource(requestParameters.CancellationToken, 놫녖.Token);
		return 놫녕.GetNewsArticleContent(new GetNewsArticleContentRequestParameters(requestParameters)
		{
			CancellationToken = cancellationTokenSource.Token
		});
	}

	public void SubscribeNewsUpdates(SubscribeNewsRequestParameters subscribeNewsRequestParameters, Action<NewsArticle> updateAction)
	{
		if (updateAction == null)
		{
			throw new ArgumentException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵놨());
		}
		int hashCode = updateAction.GetHashCode();
		if (!놫놪.NewsSubscribersCache.TryGetValue(hashCode, out var value))
		{
			value = new HashSet<Action<NewsArticle>>();
			놫놪.NewsSubscribersCache[hashCode] = value;
		}
		int count = value.Count;
		value.Add(updateAction);
		if (value.Count > count)
		{
			using (CancellationTokenSource cancellationTokenSource = CancellationTokenSource.CreateLinkedTokenSource(subscribeNewsRequestParameters.CancellationToken, 놫녖.Token))
			{
				subscribeNewsRequestParameters.SubscribeId = hashCode.ToString();
				subscribeNewsRequestParameters.CancellationToken = cancellationTokenSource.Token;
				놫녕.SubscribeNewsUpdates(subscribeNewsRequestParameters);
			}
		}
	}

	public void UnsubscribeNewsUpdates(SubscribeNewsRequestParameters subscribeNewsRequestParameters, Action<NewsArticle> updateAction)
	{
		if (updateAction == null)
		{
			throw new ArgumentException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵놨());
		}
		int hashCode = updateAction.GetHashCode();
		if (!놫놪.NewsSubscribersCache.TryGetValue(hashCode, out var value))
		{
			return;
		}
		int count = value.Count;
		value.Remove(updateAction);
		if (value.Count > count)
		{
			using (CancellationTokenSource cancellationTokenSource = CancellationTokenSource.CreateLinkedTokenSource(subscribeNewsRequestParameters.CancellationToken, 놫녖.Token))
			{
				subscribeNewsRequestParameters.SubscribeId = hashCode.ToString();
				subscribeNewsRequestParameters.CancellationToken = cancellationTokenSource.Token;
				놫녕.UnsubscribeNewsUpdates(subscribeNewsRequestParameters);
			}
		}
	}

	[Obsolete("Use Core.Instance.GetTrades() instead")]
	public IList<Trade> GetTrades(TradesHistoryRequestParameters parameters)
	{
		parameters.Progress?.Report(0f);
		if (parameters.To > Core.Instance.TimeUtils.DateTimeUtcNow)
		{
			parameters.To = Core.Instance.TimeUtils.DateTimeUtcNow;
		}
		if (parameters.ForceReload && !TradesHistoryMetadata.AllowReloadFromServer)
		{
			parameters.ForceReload = false;
		}
		using CancellationTokenSource cancellationTokenSource = CancellationTokenSource.CreateLinkedTokenSource(parameters.CancellationToken, 놫녖.Token);
		CancellationToken token = cancellationTokenSource.Token;
		List<Interval<DateTime>> list;
		IList<UserTradesInterval> list2 = 녴(parameters, out list);
		foreach (Interval<DateTime> item in list)
		{
			if (token.IsCancellationRequested)
			{
				break;
			}
			TradesHistoryRequestParameters tradesHistoryRequestParameters = new TradesHistoryRequestParameters
			{
				From = item.From,
				To = item.To,
				SymbolId = parameters.SymbolId,
				ForceReload = parameters.ForceReload,
				CancellationToken = token,
				Progress = parameters.Progress
			};
			IList<MessageTrade> list3 = null;
			try
			{
				list3 = 놫녕.GetTrades(tradesHistoryRequestParameters);
			}
			catch (Exception ex)
			{
				Core.Instance.Loggers.Log(ex);
			}
			if (token.IsCancellationRequested)
			{
				break;
			}
			if (list3 != null)
			{
				UserTradesInterval userTradesInterval = 녴(tradesHistoryRequestParameters, list3);
				list2.Add(userTradesInterval);
				if (string.IsNullOrEmpty(parameters.SymbolId) || !놫놪.UsersTradesCacheMetadata.AllowSingleSymbolLoading)
				{
					놫녒?.Save(userTradesInterval);
				}
			}
		}
		if (token.IsCancellationRequested)
		{
			return Array.Empty<Trade>();
		}
		MessageTrade[] array = (from P_0 in list2.OrderBy((UserTradesInterval P_0) => P_0.Interval.From).SelectMany((UserTradesInterval P_0) => P_0.Trades)
			where string.IsNullOrEmpty(parameters.SymbolId) || P_0.SymbolId == parameters.SymbolId
			select P_0).ToArray();
		if (!array.Any())
		{
			return Array.Empty<Trade>();
		}
		return 녴(array, token);
	}

	internal void 녴(TradesHistoryRequestParameters P_0, AccountTradesLoadingCallback P_1)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂녪());
		}
		if (P_1 == null)
		{
			throw new ArgumentNullException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵녢());
		}
		P_0.Progress?.Report(0f);
		if (P_0.To > Core.Instance.TimeUtils.DateTimeUtcNow)
		{
			P_0.To = Core.Instance.TimeUtils.DateTimeUtcNow;
		}
		CancellationTokenSource 놓놠 = CancellationTokenSource.CreateLinkedTokenSource(P_0.CancellationToken, 놫녖.Token);
		CancellationToken 놓녬 = 놓놠.Token;
		List<Interval<DateTime>> list;
		IList<UserTradesInterval> source = 녴(P_0, out list);
		P_1.InvokeSafely(녴(source.SelectMany((UserTradesInterval P_0) => P_0.Trades).ToList(), 놓녬), !list.Any());
		foreach (Interval<DateTime> 놓놟 in list)
		{
			if (놓녬.IsCancellationRequested)
			{
				break;
			}
			TradesHistoryRequestParameters 놓녓 = new TradesHistoryRequestParameters
			{
				From = 놓놟.From,
				To = 놓놟.To,
				SymbolId = P_0.SymbolId,
				ForceReload = P_0.ForceReload,
				CancellationToken = 놓녬,
				Progress = P_0.Progress
			};
			List<MessageTrade> 놓녛 = new List<MessageTrade>();
			놫녕.GetTrades(놓녓, delegate(IList<MessageTrade> P_0, bool P_1)
			{
				try
				{
					if (!놓녬.IsCancellationRequested)
					{
						if (P_0 == null)
						{
							if (P_1)
							{
								P_1.InvokeSafely(new List<Trade>(), P_1);
							}
						}
						else
						{
							P_0 = 녴(놓녓, P_0).Trades.ToList();
							놓녛.AddRange(P_0);
							List<Trade> list2 = 녴(P_0, 놓녬).ToList();
							P_1.InvokeSafely(list2, P_1);
							if (P_1 && string.IsNullOrEmpty(P_0.SymbolId) && !놫놪.UsersTradesCacheMetadata.AllowSingleSymbolLoading)
							{
								놫녒?.Save(new UserTradesInterval
								{
									Interval = 놓놟,
									Trades = 놓녛
								});
							}
						}
					}
				}
				catch (Exception ex)
				{
					Core.Instance.Loggers.Log(ex);
				}
				finally
				{
					if (P_1)
					{
						놓놠.Dispose();
					}
				}
			});
		}
	}

	private IList<UserTradesInterval> 녴(TradesHistoryRequestParameters P_0, out List<Interval<DateTime>> P_1)
	{
		List<UserTradesInterval> list = new List<UserTradesInterval>();
		P_1 = new List<Interval<DateTime>>();
		if (!P_0.ForceReload && 놫녒 != null)
		{
			IList<UserTradesInterval> collection = 놫녒.Load(P_0.Interval, out P_1);
			list.AddRange(collection);
		}
		else
		{
			P_1.Add(P_0.Interval);
		}
		if (!(놫놤 == default(DateTime)) && !P_0.ForceReload)
		{
			UsersTradesStorage usersTradesStorage = 놫녒;
			if (usersTradesStorage != null && usersTradesStorage.IsRealtimeCollectingAllowed)
			{
				for (int i = 0; i < P_1.Count; i++)
				{
					Interval<DateTime> interval = P_1[i];
					if (!(interval.To <= 놫놤))
					{
						if (interval.From >= 놫놤)
						{
							P_1.RemoveAt(i--);
						}
						else
						{
							P_1[i] = new Interval<DateTime>(interval.From, 놫놤);
						}
					}
				}
				return list;
			}
		}
		return list;
	}

	private UserTradesInterval 녴(TradesHistoryRequestParameters P_0, IList<MessageTrade> P_1)
	{
		List<MessageTrade> trades = P_1.Where((MessageTrade P_0) => P_0.Interval.Contains(P_0.DateTime)).ToList();
		return new UserTradesInterval
		{
			Trades = trades,
			Interval = new Interval<DateTime>(P_0.From, P_0.To)
		};
	}

	private Trade[] 녴(IList<MessageTrade> P_0, CancellationToken P_1)
	{
		List<Trade> list = new List<Trade>();
		foreach (MessageTrade item in P_0)
		{
			if (item != null)
			{
				if (P_1.IsCancellationRequested)
				{
					break;
				}
				녴(new GetSymbolRequestParameters
				{
					SymbolId = item.SymbolId,
					CancellationToken = P_1
				});
				Trade trade = new Trade(Id);
				trade.녴(item);
				list.Add(trade);
			}
		}
		return list.ToArray();
	}

	public IList<OrderHistory> GetOrdersHistory(OrdersHistoryRequestParameters parameters)
	{
		parameters.Progress?.Report(0f);
		if (parameters.To > Core.Instance.TimeUtils.DateTimeUtcNow)
		{
			parameters.To = Core.Instance.TimeUtils.DateTimeUtcNow;
		}
		using CancellationTokenSource cancellationTokenSource = CancellationTokenSource.CreateLinkedTokenSource(parameters.CancellationToken, 놫녖.Token);
		parameters.CancellationToken = cancellationTokenSource.Token;
		IList<MessageOrderHistory> list = null;
		try
		{
			list = 놫녕.GetOrdersHistory(parameters);
		}
		catch (Exception ex)
		{
			Core.Instance.Loggers.Log(ex);
		}
		if (parameters.CancellationToken.IsCancellationRequested)
		{
			return Array.Empty<OrderHistory>();
		}
		if (list == null)
		{
			return Array.Empty<OrderHistory>();
		}
		if (!list.Any())
		{
			return Array.Empty<OrderHistory>();
		}
		List<OrderHistory> list2 = new List<OrderHistory>();
		foreach (MessageOrderHistory item in list)
		{
			if (item != null)
			{
				if (parameters.CancellationToken.IsCancellationRequested)
				{
					break;
				}
				녴(new GetSymbolRequestParameters
				{
					SymbolId = item.SymbolId,
					CancellationToken = parameters.CancellationToken
				});
				OrderHistory orderHistory = new OrderHistory(Id);
				orderHistory.녴(item);
				list2.Add(orderHistory);
			}
		}
		return list2.ToArray();
	}

	internal Report 녴(ReportRequestParameters P_0)
	{
		using CancellationTokenSource cancellationTokenSource = CancellationTokenSource.CreateLinkedTokenSource(P_0.CancellationToken, 놫녖.Token);
		ReportRequestParameters reportRequestParameters = new ReportRequestParameters(P_0)
		{
			CancellationToken = cancellationTokenSource.Token
		};
		Report report = 놫녕.GenerateReport(reportRequestParameters);
		foreach (ReportRow row in report.Rows)
		{
			foreach (ReportCell cell in row.Cells)
			{
				if (cell.formattingDescription != null)
				{
					cell.formattingDescription.ConnectionId = Id;
				}
			}
		}
		return report;
	}

	private void 녴(object P_0, VendorEventArgs P_1)
	{
		녴(P_1.Message);
	}

	private void 녴(Message P_0)
	{
		if (P_0 != null)
		{
			놫놪.Push(P_0);
		}
	}

	private void 녴(ConnectionState P_0)
	{
		try
		{
			놫뇊?.Invoke(this, new ConnectionStateChangedEventArgs(P_0, State, LastConnectionResult.Clone() as ConnectionResult));
		}
		catch (Exception ex)
		{
			Core.Instance.Loggers.Log(ex);
		}
	}

	private void 녴(RequestParameters P_0)
	{
		RequestEventArgs requestEventArgs = new RequestEventArgs(P_0);
		녪놴?.InvokeSafely(this, requestEventArgs);
		Core.Instance.녴(this, requestEventArgs);
	}

	private void 녴(RequestParameters P_0, object P_1)
	{
		녪놂?.InvokeSafely(this, new PerformedRequestEventArgs(P_0, P_1));
		Core.Instance.녴(P_0, P_1);
	}

	private void 놂(string P_0)
	{
		try
		{
			int num = 놫놪.Orders.Length;
			int num2 = 놫놪.Positions.Length;
			if (num <= 0 && num2 <= 0)
			{
				return;
			}
			string value = _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵놞();
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
			if (num > 0)
			{
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(19, 2);
				defaultInterpolatedStringHandler.AppendFormatted(num);
				defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵놳());
				defaultInterpolatedStringHandler.AppendFormatted(string.Join(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂녹(), (from P_0 in 놫놪.Orders
					group P_0 by P_0.Symbol into P_0
					select P_0.Key).ToList()));
				defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놢());
				value = defaultInterpolatedStringHandler.ToStringAndClear();
			}
			string value2 = _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵놺();
			if (num2 > 0)
			{
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(15, 2);
				defaultInterpolatedStringHandler.AppendFormatted(num2);
				defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵놅());
				defaultInterpolatedStringHandler.AppendFormatted(string.Join(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂녹(), (from P_0 in 놫놪.Positions
					group P_0 by P_0.Symbol into P_0
					select P_0.Key).ToList()));
				defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놢());
				value2 = defaultInterpolatedStringHandler.ToStringAndClear();
			}
			LoggerManager loggers = Core.Instance.Loggers;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(13, 4);
			defaultInterpolatedStringHandler.AppendFormatted(Name);
			defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놀());
			defaultInterpolatedStringHandler.AppendFormatted(P_0);
			defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵녜());
			defaultInterpolatedStringHandler.AppendFormatted(value);
			defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵뇃());
			defaultInterpolatedStringHandler.AppendFormatted(value2);
			defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵녯());
			loggers.Log(defaultInterpolatedStringHandler.ToStringAndClear(), LoggingLevel.Trading);
		}
		catch (Exception ex)
		{
			Core.Instance.Loggers.Log(ex);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Obfuscation(Exclude = true)]
	private void SubscribeOnMessage(Action<Message> handler)
	{
		if (놫놪 != null)
		{
			놫놪.녴(handler);
		}
	}

	public int CompareTo(object obj)
	{
		if (obj is Connection connection)
		{
			return string.Compare(Name, connection.Name, StringComparison.Ordinal);
		}
		return 0;
	}

	public override string ToString()
	{
		return Name;
	}
}
