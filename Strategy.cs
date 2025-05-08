using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using TradingPlatform.BusinessLayer.Serialization;
using TradingPlatform.BusinessLayer.Utils;

namespace TradingPlatform.BusinessLayer;

/// <summary>
/// The base class for strategies
/// </summary>
[Published]
public abstract class Strategy : ExecutionEntity, IXElementSerialization, IConnectionStateDependent
{
	[CompilerGenerated]
	private string 뇅놤;

	private StrategyState 뇅논;

	[CompilerGenerated]
	private string 뇅녘;

	[CompilerGenerated]
	private StrategyEventHandler 뇅노;

	[CompilerGenerated]
	private Action<Strategy> 뇅녒;

	[CompilerGenerated]
	private bool 뇅녕;

	private ILogger 뇅녖;

	private DateTime 놵녴;

	private DateTime 놵놴;

	private Meter 놵놂;

	private readonly ConnectionStateObserver 놵놎;

	private StrategyState? 놵녞;

	/// <summary>
	/// Unique ID of the strategy
	/// </summary>
	public string Id
	{
		[CompilerGenerated]
		get
		{
			return 뇅놤;
		}
		[CompilerGenerated]
		internal set
		{
			뇅놤 = value;
		}
	}

	/// <summary>
	/// The current state of the strategy
	/// </summary>
	public StrategyState State
	{
		get
		{
			return 뇅논;
		}
		internal set
		{
			StrategyState strategyState = 뇅논;
			뇅논 = value;
			Core.Instance.Strategies.녴(this, 뇅논, strategyState);
		}
	}

	public string InstanceName
	{
		[CompilerGenerated]
		get
		{
			return 뇅녘;
		}
		[CompilerGenerated]
		set
		{
			뇅녘 = value;
		}
	}

	public override IList<SettingItem> Settings
	{
		get
		{
			IList<SettingItem> settings = base.Settings;
			settings.Add(new SettingItemString(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿녮(), InstanceName)
			{
				Text = loc._(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿뇆(), null, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿뇉()),
				SeparatorGroup = new SettingItemSeparatorGroup(loc._(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿뇍(), null, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿뇉()), -1100)
			});
			return settings;
		}
		set
		{
			if (value.TryGetValue<string>(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿녮(), out var value2))
			{
				InstanceName = value2;
			}
			if (State == StrategyState.Working)
			{
				throw new InvalidOperationException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놙());
			}
			base.Settings = value;
			뇅녒?.Invoke(this);
		}
	}

	public bool NewVersionAvailable
	{
		[CompilerGenerated]
		get
		{
			return 뇅녕;
		}
		[CompilerGenerated]
		internal set
		{
			뇅녕 = value;
		}
	}

	public virtual string[] MonitoringConnectionsIds => new string[0];

	private string DataFolderName => base.Name + _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂녙() + Id + _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놢();

	internal string DataFolderPath => Path.Combine(Const.SCRIPTS_DATA_PATH, DataFolderName);

	/// <summary>
	/// Event occured when strategy write a new log
	/// </summary>
	public event StrategyEventHandler NewLog
	{
		[CompilerGenerated]
		add
		{
			StrategyEventHandler strategyEventHandler = 뇅노;
			StrategyEventHandler strategyEventHandler2;
			do
			{
				strategyEventHandler2 = strategyEventHandler;
				StrategyEventHandler value2 = (StrategyEventHandler)Delegate.Combine(strategyEventHandler2, value);
				strategyEventHandler = Interlocked.CompareExchange(ref 뇅노, value2, strategyEventHandler2);
			}
			while ((object)strategyEventHandler != strategyEventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			StrategyEventHandler strategyEventHandler = 뇅노;
			StrategyEventHandler strategyEventHandler2;
			do
			{
				strategyEventHandler2 = strategyEventHandler;
				StrategyEventHandler value2 = (StrategyEventHandler)Delegate.Remove(strategyEventHandler2, value);
				strategyEventHandler = Interlocked.CompareExchange(ref 뇅노, value2, strategyEventHandler2);
			}
			while ((object)strategyEventHandler != strategyEventHandler2);
		}
	}

	/// <summary>
	/// Event occured if any of strategy settings was changed
	/// </summary>
	public event Action<Strategy> SettingsChanged
	{
		[CompilerGenerated]
		add
		{
			Action<Strategy> action = 뇅녒;
			Action<Strategy> action2;
			do
			{
				action2 = action;
				Action<Strategy> value2 = (Action<Strategy>)Delegate.Combine(action2, value);
				action = Interlocked.CompareExchange(ref 뇅녒, value2, action2);
			}
			while ((object)action != action2);
		}
		[CompilerGenerated]
		remove
		{
			Action<Strategy> action = 뇅녒;
			Action<Strategy> action2;
			do
			{
				action2 = action;
				Action<Strategy> value2 = (Action<Strategy>)Delegate.Remove(action2, value);
				action = Interlocked.CompareExchange(ref 뇅녒, value2, action2);
			}
			while ((object)action != action2);
		}
	}

	internal void 녴()
	{
		CheckDisposed();
		string dataFolderPath = DataFolderPath;
		if (!Directory.Exists(dataFolderPath))
		{
			Directory.CreateDirectory(dataFolderPath);
		}
		뇅녖 = Core.Instance.Loggers.GetLogger(new LoggerConfig
		{
			LoggerName = DataFolderName,
			OutputFolderPath = Path.Combine(DataFolderPath, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿녰()),
			Scope = LoggerScope.General
		});
		try
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
			defaultInterpolatedStringHandler.AppendFormatted(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놚());
			defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵녯());
			defaultInterpolatedStringHandler.AppendFormatted(base.Key);
			defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵녯());
			defaultInterpolatedStringHandler.AppendFormatted(Id);
			놵놂 = new Meter(defaultInterpolatedStringHandler.ToStringAndClear(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놹());
			OnInitializeMetrics(놵놂);
		}
		catch (Exception ex)
		{
			Log(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놘() + (ex.InnerException?.Message ?? ex.Message), StrategyLoggingLevel.Error);
			Core.Instance.Loggers.Log(ex, base.Name + _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿뇌());
		}
		State = StrategyState.Created;
		try
		{
			OnCreated();
			Log(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿녷());
		}
		catch (Exception ex2)
		{
			Log(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놘() + (ex2.InnerException?.Message ?? ex2.Message), StrategyLoggingLevel.Error);
			Core.Instance.Loggers.Log(ex2, base.Name + _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿녟());
		}
	}

	/// <summary>
	/// Run strategy
	/// </summary>
	public void Run()
	{
		CheckDisposed();
		if (State == StrategyState.Working)
		{
			return;
		}
		string[] monitoringConnectionsIds = MonitoringConnectionsIds;
		if (monitoringConnectionsIds != null)
		{
			string[] array = monitoringConnectionsIds;
			foreach (string text in array)
			{
				if (text != null)
				{
					Connection connection = Core.Instance.Connections[text];
					if (connection == null || connection.State != 0)
					{
						State = StrategyState.WaitingForConnection;
						return;
					}
				}
			}
		}
		State = StrategyState.Working;
		놵녴 = Core.Instance.TimeUtils.DateTimeUtcNow;
		try
		{
			OnRun();
			Log(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놱());
		}
		catch (Exception ex)
		{
			Log(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놖() + (ex.InnerException?.Message ?? ex.Message), StrategyLoggingLevel.Error);
			Core.Instance.Loggers.Log(ex, base.Name + _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놝());
		}
	}

	/// <summary>
	/// Stop strategy
	/// </summary>
	public void Stop()
	{
		CheckDisposed();
		if (State != StrategyState.Working && State != StrategyState.WaitingForConnection)
		{
			return;
		}
		bool num = State != StrategyState.WaitingForConnection;
		State = StrategyState.Stopped;
		놵놴 = Core.Instance.TimeUtils.DateTimeUtcNow;
		if (!num)
		{
			return;
		}
		try
		{
			OnStop();
			Log(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿뇄());
		}
		catch (Exception ex)
		{
			Log(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿녑() + (ex.InnerException?.Message ?? ex.Message), StrategyLoggingLevel.Error);
			Core.Instance.Loggers.Log(ex, base.Name + _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놈());
		}
	}

	/// <summary>
	/// Remove the strategy
	/// </summary>
	public void Remove()
	{
		CheckDisposed();
		if (State == StrategyState.Removed)
		{
			return;
		}
		if (State == StrategyState.Working)
		{
			Stop();
		}
		try
		{
			string dataFolderPath = DataFolderPath;
			if (Directory.Exists(dataFolderPath))
			{
				Directory.Delete(dataFolderPath, recursive: true);
			}
		}
		catch (Exception ex)
		{
			Log(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놬() + ex.GetFullMessageRecursive(), StrategyLoggingLevel.Error);
			Core.Instance.Loggers.Log(ex, base.Name + _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놊());
		}
		State = StrategyState.Removed;
		try
		{
			OnRemove();
			Log(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놪());
		}
		catch (Exception ex2)
		{
			Log(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놌() + (ex2.InnerException?.Message ?? ex2.Message), StrategyLoggingLevel.Error);
			Core.Instance.Loggers.Log(ex2, base.Name + _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놊());
		}
		finally
		{
			뇅녖?.Dispose();
			뇅녖 = null;
		}
	}

	/// <summary>
	/// Get current metrics from the strategy
	/// </summary>
	/// <returns></returns>
	public List<StrategyMetric> GetMetrics()
	{
		CheckDisposed();
		List<StrategyMetric> result = null;
		try
		{
			result = OnGetMetrics();
		}
		catch (Exception ex)
		{
			Core.Instance.Loggers.Log(ex, base.Name + _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놕());
		}
		return result;
	}

	/// <summary>
	/// Get logs from the strategy for specified date range
	/// </summary>
	/// <param name="from"></param>
	/// <param name="to"></param>
	/// <returns></returns>
	public LoggerEvent[] GetLogs(DateTime from, DateTime to)
	{
		return 뇅녖?.GetHistory(from, to)?.OfType<LoggerEvent>().ToArray() ?? Array.Empty<LoggerEvent>();
	}

	protected virtual void OnCreated()
	{
	}

	protected virtual void OnRun()
	{
	}

	protected virtual void OnStop()
	{
	}

	protected virtual void OnRemove()
	{
	}

	[Obsolete("Use OnInitializeMetrics() method to initialize System.Diagnostics.Metrics")]
	protected virtual List<StrategyMetric> OnGetMetrics()
	{
		return new List<StrategyMetric>
		{
			{
				_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿뇊(),
				(놵녴 == default(DateTime)) ? _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇅() : ExecutionEntity.Core.TimeUtils.ConvertFromUTCToSelectedTimeZone(놵녴).ToString()
			},
			{
				_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놋(),
				(놵녴 == default(DateTime)) ? _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇅() : ((State == StrategyState.Working) ? (Core.Instance.TimeUtils.DateTimeUtcNow - 놵녴).ToString(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿녣()) : (놵놴 - 놵녴).ToString(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿녣()))
			}
		};
	}

	protected virtual void OnInitializeMetrics(Meter meter)
	{
	}

	/// <summary>
	/// Write log message
	/// </summary>
	/// <param name="message"></param>
	/// <param name="level"></param>
	protected internal void Log(string message, StrategyLoggingLevel level = StrategyLoggingLevel.Info)
	{
		DateTime dateTimeUtcNow = Core.Instance.TimeUtils.DateTimeUtcNow;
		LoggingLevel loggingLevel = level switch
		{
			StrategyLoggingLevel.Trading => LoggingLevel.Trading, 
			StrategyLoggingLevel.Error => LoggingLevel.Error, 
			_ => LoggingLevel.System, 
		};
		뇅녖?.Log(message, dateTimeUtcNow, loggingLevel);
		if (뇅노 != null)
		{
			LoggerEvent loggerEvent = new LoggerEvent
			{
				Date = dateTimeUtcNow,
				Event = message,
				Type = loggingLevel
			};
			녴(loggerEvent);
		}
	}

	[NotPublished]
	public override void Dispose()
	{
		놵놎.Dispose();
		놵놂?.Dispose();
		if (State == StrategyState.Working)
		{
			Stop();
		}
		base.Dispose();
	}

	protected Strategy()
	{
		Id = Guid.NewGuid().ToString();
		놵놎 = new ConnectionStateObserver(this, ConnectionStateObserverPriority.Normal, ConnectionState.Connected, ConnectionState.Disconnected, ConnectionState.ConnectionLost);
	}

	private void 녴(LoggerEvent P_0)
	{
		뇅노?.Invoke(this, new StrategyEventArgs(State, P_0));
	}

	[NotPublished]
	public XElement ToXElement()
	{
		XElement xElement = new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴뇈());
		xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴놦(), base.Key.ToString()));
		xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶녭(), Id));
		xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놵(), base.Name));
		xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶놐(), GetType().Name));
		xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿녩(), (int)State));
		XElement xElement2 = new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놎놬());
		foreach (SettingItem setting in Settings)
		{
			xElement2.Add(setting.ToXElement());
		}
		xElement.Add(xElement2);
		return xElement;
	}

	[NotPublished]
	public void FromXElement(XElement element, DeserializationInfo deserializationInfo)
	{
		string stringKey = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴놦())?.Value;
		base.Key = ScriptKey.CreateScriptKeyFromString(stringKey);
		Id = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶녭())?.Value;
		base.Name = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놵())?.Value;
		XElement xElement = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놎놬());
		if (xElement != null)
		{
			List<SettingItem> settings = Serializer.DeserializeXML(xElement, deserializationInfo).OfType<SettingItem>().ToList();
			Settings = settings;
		}
		놵녞 = (StrategyState)(element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿녩())?.ToInt() ?? 10);
	}

	internal void 놴()
	{
		bool flag;
		switch (놵녞)
		{
		case StrategyState.Working:
		case StrategyState.WaitingForConnection:
			flag = true;
			break;
		default:
			flag = false;
			break;
		}
		if (flag)
		{
			Task.Factory.StartNew(Run);
		}
		놵녞 = null;
	}

	public ConnectionDependency GetConnectionStateDependency()
	{
		return new ConnectionDependency
		{
			Behavior = ConnectionDependencyBehavior.PartialDependency,
			DependentConnectionsIds = MonitoringConnectionsIds
		};
	}

	private void 녴(Connection P_0, ConnectionStateChangedEventArgs P_1)
	{
		if (P_1.NewState == ConnectionState.Connected)
		{
			if (State == StrategyState.WaitingForConnection)
			{
				Task.Factory.StartNew(Run);
			}
		}
		else if (State == StrategyState.Working)
		{
			Task.Factory.StartNew(Stop).ContinueWith((Task P_0) => State = StrategyState.WaitingForConnection);
		}
	}

	void IConnectionStateDependent.OnConnectionStateChanged(Connection P_0, ConnectionStateChangedEventArgs P_1)
	{
		//ILSpy generated this explicit interface implementation from .override directive in 녴
		this.녴(P_0, P_1);
	}

	[CompilerGenerated]
	private StrategyState 녴(Task P_0)
	{
		return State = StrategyState.WaitingForConnection;
	}
}
