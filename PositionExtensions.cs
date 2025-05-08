namespace TradingPlatform.BusinessLayer;

public static class PositionExtensions
{
	public static bool IsBreakevenPossible(this Position position)
	{
		PnLItem pnLItem = position?.NetPnL ?? position?.GrossPnL;
		if (pnLItem == null)
		{
			return true;
		}
		return pnLItem.Value > 0.0;
	}
}
