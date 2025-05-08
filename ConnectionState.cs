namespace TradingPlatform.BusinessLayer;

/// <summary>
/// Server connection status
/// </summary>
public enum ConnectionState
{
	Connected,
	Connecting,
	Disconnected,
	Disconnecting,
	ConnectionLost,
	Fail
}
