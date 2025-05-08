namespace TradingPlatform.BusinessLayer;

[Published]
public enum StrategyState
{
	Created = 10,
	Working = 20,
	Stopped = 30,
	Removed = 40,
	WaitingForConnection = 50
}
