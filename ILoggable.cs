namespace TradingPlatform.BusinessLayer;

public interface ILoggable
{
	string Event { get; }

	string Message { get; }
}
