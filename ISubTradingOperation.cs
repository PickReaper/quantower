namespace TradingPlatform.BusinessLayer;

public interface ISubTradingOperation
{
	GroupTradingOperation ParentOperation { get; }
}
