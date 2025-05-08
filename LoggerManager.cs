using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using CommandLine;
using TradingPlatform.BusinessLayer.Utils;
using 녴;

namespace TradingPlatform.BusinessLayer;

public sealed class LoggerManager : BufferedProcessor<Action>, IDisposable
{
	[Serializable]
	[CompilerGenerated]
	private sealed class 녴
	{
		public static readonly 녴 녲놾 = new 녴();

		public static Action<ParserSettings> 녲뇀;

		public static Func<TypeWrapper, bool> 녲놽;

		public static Func<TypeWrapper, Type> 녲녿;

		public static Predicate<ILogger> 녲놁;

		internal void 녴(ParserSettings P_0)
		{
			P_0.IgnoreUnknownArguments = true;
		}

		internal bool 녴(TypeWrapper P_0)
		{
			return !P_0.Type.IsAbstract;
		}

		internal Type 놴(TypeWrapper P_0)
		{
			return P_0.Type;
		}

		internal bool 녴(ILogger P_0)
		{
			return P_0 == null;
		}
	}

	[CompilerGenerated]
	private sealed class 놴
	{
		public LoggerManager 녲녭;

		public string 녲녱;

		public LoggingLevel 녲놲;

		public string 녲높;

		internal void 녴()
		{
			DateTime dateTimeUtcNow = Core.Instance.TimeUtils.DateTimeUtcNow;
			녲녭.놂놰?.Log(녲녱, dateTimeUtcNow, 녲놲, 녲높);
			ApplicationLoggerEvent applicationLoggerEvent = new ApplicationLoggerEvent
			{
				Date = dateTimeUtcNow,
				Type = 녲놲,
				Event = 녲녱,
				Message = string.Empty,
				ConnectionName = 녲높
			};
			녲녭.녴(applicationLoggerEvent);
			녲녭.녴(dateTimeUtcNow, 녲녱, string.Empty);
		}
	}

	[CompilerGenerated]
	private sealed class 놂
	{
		public LoggerManager 녲놶;

		public string 녲뇏;

		public Exception 녲녻;

		public LoggingLevel 녲녙;

		public string 녲놢;

		internal void 녴()
		{
			DateTime dateTimeUtcNow = Core.Instance.TimeUtils.DateTimeUtcNow;
			녲놶.놂놰?.Log(녲뇏, 녲녻, dateTimeUtcNow, 녲녙, 녲놢);
			ApplicationLoggerEvent applicationLoggerEvent = new ApplicationLoggerEvent
			{
				Date = dateTimeUtcNow,
				Type = 녲녙,
				Event = 녲뇏,
				Message = GetFormattedErrorMessage(녲녻),
				ConnectionName = 녲놢
			};
			녲놶.녴(applicationLoggerEvent);
			녲놶.녴(dateTimeUtcNow, 녲뇏, 녲녻.Message);
		}
	}

	[CompilerGenerated]
	private sealed class 놎
	{
		public LoggerManager 녲녧;

		public ILoggable 녲녤;

		public LoggingLevel 녲놆;

		public string 녲뇎;

		internal void 녴()
		{
			DateTime dateTimeUtcNow = Core.Instance.TimeUtils.DateTimeUtcNow;
			녲녧.놂놰.Log(녲녤, dateTimeUtcNow, 녲놆, 녲뇎);
			ApplicationLoggerEvent applicationLoggerEvent = new ApplicationLoggerEvent
			{
				Date = dateTimeUtcNow,
				Type = 녲놆,
				Event = 녲녤.Event,
				Message = 녲녤.Message,
				ConnectionName = 녲뇎
			};
			녲녧.녴(applicationLoggerEvent);
			녲녧.녴(dateTimeUtcNow, 녲녤.Event, 녲녤.Message);
		}
	}

	[CompilerGenerated]
	private sealed class 녞
	{
		public LoggerManager 녲놷;

		public string 녲녗;

		public DateTime 녲놜;

		internal void 녴()
		{
			녲놷.녴(녲녗, 녲놜);
		}
	}

	[CompilerGenerated]
	private sealed class 놫
	{
		public ILogger 녲놨;

		public DateTime 녲녢;

		public DateTime 녲놞;

		internal void 녴()
		{
			녲놨.DeleteLogFilesExcept(녲녢, 녲놞);
		}
	}

	private const int 놂녶 = 864000;

	private const int 놂녵 = 600;

	private const string 놂놭 = "Loggers";

	private int 놂녲;

	[CompilerGenerated]
	private bool 놂뇋;

	[CompilerGenerated]
	private int 놂놸;

	[CompilerGenerated]
	private Action<ApplicationLoggerEvent> 놂놿;

	[CompilerGenerated]
	private LoggingLevel 놂놄;

	private ILogger 놂놰;

	private readonly List<Type> 놂놓;

	private readonly List<ILogger> 놂놇;

	private readonly List<string> 놂뇅;

	public bool EnableAutoDeleting
	{
		[CompilerGenerated]
		get
		{
			return 놂뇋;
		}
		[CompilerGenerated]
		set
		{
			놂뇋 = value;
		}
	}

	public int AutoDeletePeriod
	{
		[CompilerGenerated]
		get
		{
			return 놂놸;
		}
		[CompilerGenerated]
		set
		{
			놂놸 = value;
		}
	}

	/// <summary>
	/// Current logging level
	/// </summary>
	public LoggingLevel CurrentLogLevel
	{
		[CompilerGenerated]
		get
		{
			return 놂놄;
		}
		[CompilerGenerated]
		private set
		{
			놂놄 = value;
		}
	}

	public event Action<ApplicationLoggerEvent> NewLog
	{
		[CompilerGenerated]
		add
		{
			Action<ApplicationLoggerEvent> action = 놂놿;
			Action<ApplicationLoggerEvent> action2;
			do
			{
				action2 = action;
				Action<ApplicationLoggerEvent> value2 = (Action<ApplicationLoggerEvent>)Delegate.Combine(action2, value);
				action = Interlocked.CompareExchange(ref 놂놿, value2, action2);
			}
			while ((object)action != action2);
		}
		[CompilerGenerated]
		remove
		{
			Action<ApplicationLoggerEvent> action = 놂놿;
			Action<ApplicationLoggerEvent> action2;
			do
			{
				action2 = action;
				Action<ApplicationLoggerEvent> value2 = (Action<ApplicationLoggerEvent>)Delegate.Remove(action2, value);
				action = Interlocked.CompareExchange(ref 놂놿, value2, action2);
			}
			while ((object)action != action2);
		}
	}

	public LoggerManager()
	{
		AutoDeletePeriod = 30;
		EnableAutoDeleting = true;
		놂녲 = 863400;
		놂놓 = new List<Type>();
		놂놇 = new List<ILogger>();
		놂뇅 = new List<string>();
		CurrentLogLevel = LoggingLevel.System | LoggingLevel.Error | LoggingLevel.Trading;
		new Parser(delegate(ParserSettings P_0)
		{
			P_0.IgnoreUnknownArguments = true;
		}).ParseArguments<놄>(Environment.GetCommandLineArgs()).WithParsed(delegate(놄 P_0)
		{
			AddLogLevel(P_0.LoggingLevel);
		}).WithNotParsed(delegate(IEnumerable<Error> P_0)
		{
			foreach (Error item in P_0)
			{
				Log(item.ToString(), LoggingLevel.Error);
			}
		});
	}

	internal void 녴()
	{
		List<TypeWrapper> list = AssemblyLoader.LoadTypes(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놜(), typeof(ILogger), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놨(), SearchOption.AllDirectories);
		if (list != null)
		{
			놂놓.AddRange(from P_0 in list
				where !P_0.Type.IsAbstract
				select P_0.Type);
			놂놰 = GetLogger(new LoggerConfig
			{
				LoggerName = _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂녢(),
				OutputFolderPath = Path.Combine(Directory.GetParent(Const.EXECUTING_FOLDER).FullName, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놞(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놳(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놺()),
				Scope = LoggerScope.Application
			});
			Start();
			Core.Instance.녴(놂);
		}
	}

	public void Dispose()
	{
		Core.Instance.놴(놂);
		Stop();
		if (놂놰 != null)
		{
			놂놰.Dispose();
			놂놰 = null;
		}
	}

	public ILogger GetLogger(LoggerConfig loggerConfig)
	{
		List<ILogger> list = new List<ILogger>();
		foreach (Type item in 놂놓)
		{
			ILogger logger = (ILogger)Activator.CreateInstance(item);
			if (logger.AllowedScopes.HasFlag(loggerConfig.Scope))
			{
				list.Add(logger);
			}
		}
		녙 녙 = new 녙(list);
		녙.Configure(loggerConfig);
		녴(녙);
		return 녙;
	}

	/// <summary>
	/// Sets logs with custom messag, logging level, connection name
	/// </summary>
	public void Log(string message, LoggingLevel loggingLevel = LoggingLevel.System, string connectionName = null)
	{
		if (녴(loggingLevel))
		{
			Push(delegate
			{
				DateTime dateTimeUtcNow = Core.Instance.TimeUtils.DateTimeUtcNow;
				놂놰?.Log(message, dateTimeUtcNow, loggingLevel, connectionName);
				ApplicationLoggerEvent applicationLoggerEvent = new ApplicationLoggerEvent
				{
					Date = dateTimeUtcNow,
					Type = loggingLevel,
					Event = message,
					Message = string.Empty,
					ConnectionName = connectionName
				};
				녴(applicationLoggerEvent);
				녴(dateTimeUtcNow, message, string.Empty);
			});
		}
	}

	/// <summary>
	/// Sets logs with exception and custom message (optional), logging level, connection name
	/// </summary>
	public void Log(Exception ex, string message = null, LoggingLevel loggingLevel = LoggingLevel.Error, string connectionName = null)
	{
		if (!(ex is ThreadAbortException) && 녴(loggingLevel))
		{
			Push(delegate
			{
				DateTime dateTimeUtcNow = Core.Instance.TimeUtils.DateTimeUtcNow;
				놂놰?.Log(message, ex, dateTimeUtcNow, loggingLevel, connectionName);
				ApplicationLoggerEvent applicationLoggerEvent = new ApplicationLoggerEvent
				{
					Date = dateTimeUtcNow,
					Type = loggingLevel,
					Event = message,
					Message = GetFormattedErrorMessage(ex),
					ConnectionName = connectionName
				};
				녴(applicationLoggerEvent);
				녴(dateTimeUtcNow, message, ex.Message);
			});
		}
	}

	/// <summary>
	/// Sets logs with objects inherited from ILoggable interface,logging level, connection name
	/// </summary>
	public void Log(ILoggable loggable, LoggingLevel loggingLevel = LoggingLevel.System, string connectionName = null)
	{
		if (loggable == null)
		{
			throw new ArgumentNullException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놅());
		}
		if (녴(loggingLevel))
		{
			Push(delegate
			{
				DateTime dateTimeUtcNow = Core.Instance.TimeUtils.DateTimeUtcNow;
				놂놰.Log(loggable, dateTimeUtcNow, loggingLevel, connectionName);
				ApplicationLoggerEvent applicationLoggerEvent = new ApplicationLoggerEvent
				{
					Date = dateTimeUtcNow,
					Type = loggingLevel,
					Event = loggable.Event,
					Message = loggable.Message,
					ConnectionName = connectionName
				};
				녴(applicationLoggerEvent);
				녴(dateTimeUtcNow, loggable.Event, loggable.Message);
			});
		}
	}

	public void Log(string @event, string message, LoggingLevel loggingLevel = LoggingLevel.System, string connectionName = null)
	{
		Log(new Loggable(@event, message), loggingLevel, connectionName);
	}

	private void 녴(ApplicationLoggerEvent P_0)
	{
		놂놿?.Invoke(P_0);
	}

	/// <summary>
	/// Sets a log level in case of deep debug
	/// </summary>
	public void AddLogLevel(LoggingLevel loggingLevel)
	{
		CurrentLogLevel |= loggingLevel;
	}

	/// <summary>
	/// Remove a log level if one has not needed already
	/// </summary>
	public void RemoveLogLevel(LoggingLevel loggingLevel)
	{
		CurrentLogLevel &= ~loggingLevel;
	}

	public List<ApplicationLoggerEvent> GetHistory(DateTime from, DateTime to)
	{
		List<ApplicationLoggerEvent> list = new List<ApplicationLoggerEvent>();
		if (놂놰 != null)
		{
			list.AddRange(놂놰.GetHistory(from, to).OfType<ApplicationLoggerEvent>());
		}
		return list;
	}

	/// <summary>
	/// Manage files existence in folder.
	/// </summary>
	public void RegisterExternalLogFolder(string path)
	{
		if (!Directory.Exists(path))
		{
			return;
		}
		if (!놂뇅.Contains(path))
		{
			놂뇅.Add(path);
		}
		if (EnableAutoDeleting && 놂녲 < 863400)
		{
			DateTime 녲놜 = Core.Instance.TimeUtils.DateTimeUtcNow.AddDays(-AutoDeletePeriod);
			Push(delegate
			{
				녴(path, 녲놜);
			});
		}
	}

	private void 놴()
	{
		if (놂놰 == null || !EnableAutoDeleting)
		{
			return;
		}
		Log(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂녜());
		DateTime dateTimeUtcNow = Core.Instance.TimeUtils.DateTimeUtcNow;
		DateTime dateTime = dateTimeUtcNow.AddDays(-AutoDeletePeriod);
		foreach (ILogger item in 놂놇)
		{
			item?.DeleteLogFilesExcept(dateTime, dateTimeUtcNow);
		}
		foreach (string item2 in 놂뇅)
		{
			녴(item2, dateTime);
		}
		Log(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂뇃());
	}

	private void 녴(string P_0, DateTime P_1)
	{
		if (string.IsNullOrEmpty(P_0))
		{
			return;
		}
		try
		{
			if (!Directory.Exists(P_0))
			{
				return;
			}
			string[] files = Directory.GetFiles(P_0);
			foreach (string text in files)
			{
				FileInfo fileInfo = new FileInfo(text);
				if (fileInfo.CreationTimeUtc < P_1 || fileInfo.LastWriteTime < P_1)
				{
					File.Delete(text);
				}
			}
		}
		catch (Exception ex)
		{
			Core.Instance.Loggers.Log(ex, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂녯());
		}
	}

	private void 녴(ILogger P_0)
	{
		놂놇.RemoveAll((ILogger P_0) => P_0 == null);
		놂놇.Add(P_0);
		if (EnableAutoDeleting && 놂녲 < 863400)
		{
			DateTime 녲놞 = Core.Instance.TimeUtils.DateTimeUtcNow;
			DateTime 녲녢 = 녲놞.AddDays(-AutoDeletePeriod);
			Push(delegate
			{
				P_0.DeleteLogFilesExcept(녲녢, 녲놞);
			});
		}
	}

	private void 놂()
	{
		if (놂녲 < 864000)
		{
			놂녲++;
			return;
		}
		Push(놴);
		놂녲 = 0;
	}

	private bool 녴(LoggingLevel P_0)
	{
		if (!CurrentLogLevel.HasFlag(P_0))
		{
			return (LoggingLevel.System | LoggingLevel.Error | LoggingLevel.Trading | LoggingLevel.LoadingHistory).HasFlag(P_0);
		}
		return true;
	}

	private void 녴(DateTime P_0, string P_1, string P_2)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(4, 1);
		defaultInterpolatedStringHandler.AppendFormatted(P_0, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놮());
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇂());
		StringBuilder stringBuilder = new StringBuilder(defaultInterpolatedStringHandler.ToStringAndClear());
		if (!string.IsNullOrEmpty(P_1))
		{
			StringBuilder stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder3 = stringBuilder2;
			StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(9, 1, stringBuilder2);
			handler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂녫());
			handler.AppendFormatted(P_1);
			stringBuilder3.Append(ref handler);
		}
		if (!string.IsNullOrEmpty(P_2))
		{
			StringBuilder stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder4 = stringBuilder2;
			StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(11, 1, stringBuilder2);
			handler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂뇁());
			handler.AppendFormatted(P_2);
			stringBuilder4.Append(ref handler);
		}
	}

	protected override void Process(Action subject)
	{
		subject?.Invoke();
	}

	protected static string GetFormattedErrorMessage(Exception ex)
	{
		return new StringBuilder().Append(ex.Message).Append(' ').Append(ex.StackTrace)
			.Replace(Environment.NewLine, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놀())
			.ToString();
	}

	[CompilerGenerated]
	private void 녴(놄 P_0)
	{
		AddLogLevel(P_0.LoggingLevel);
	}

	[CompilerGenerated]
	private void 녴(IEnumerable<Error> P_0)
	{
		foreach (Error item in P_0)
		{
			Log(item.ToString(), LoggingLevel.Error);
		}
	}
}
