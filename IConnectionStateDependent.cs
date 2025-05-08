namespace TradingPlatform.BusinessLayer;

public interface IConnectionStateDependent
{
	ConnectionDependency GetConnectionStateDependency();

	void OnConnectionStateChanged(Connection connection, ConnectionStateChangedEventArgs e);
}
