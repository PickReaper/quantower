using System;
using System.ComponentModel;

namespace TradingPlatform.BusinessLayer;

[Flags]
public enum LoggingLevel
{
	System = 1,
	[Description("Exception")]
	Error = 2,
	Trading = 4,
	Verbose = 8,
	Quotes = 0x10,
	Painting = 0x20,
	Performance = 0x40,
	[Description("Loading history")]
	LoadingHistory = 0x80
}
