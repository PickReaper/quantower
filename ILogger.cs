using System;
using System.Collections.Generic;

namespace TradingPlatform.BusinessLayer;

public interface ILogger : IDisposable
{
	LoggerScope AllowedScopes { get; }

	void Configure(LoggerConfig loggerConfig);

	void Log(string message, DateTime date, LoggingLevel level = LoggingLevel.System, string connection = null);

	void Log(string message, Exception exception, DateTime date, LoggingLevel level = LoggingLevel.Error, string connection = null);

	void Log(Exception exception, DateTime date, LoggingLevel level = LoggingLevel.Error, string connection = null);

	void Log(ILoggable loggable, DateTime date, LoggingLevel level = LoggingLevel.Error, string connection = null);

	List<LoggerEvent> GetHistory(DateTime from, DateTime to);

	void DeleteLogFilesExcept(DateTime from, DateTime to);
}
