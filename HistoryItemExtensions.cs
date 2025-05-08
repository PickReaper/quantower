using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace TradingPlatform.BusinessLayer;

public static class HistoryItemExtensions
{
	public static void ProcessTickDirection(this IList<IHistoryItem> historyItems, CancellationToken cancellationToken)
	{
		if (historyItems == null || historyItems.Count == 0 || historyItems[0] is HistoryItemBar)
		{
			return;
		}
		if (historyItems[0] is HistoryItemTick)
		{
			double previousPrice = double.NaN;
			double previousPrice2 = double.NaN;
			TickDirection prevItemTickDirection = TickDirection.NotSet;
			TickDirection prevItemTickDirection2 = TickDirection.NotSet;
			{
				foreach (HistoryItemTick item in historyItems.OfType<HistoryItemTick>())
				{
					if (cancellationToken.IsCancellationRequested)
					{
						break;
					}
					item.BidTickDirection = Symbol.DetermineTickDirection(previousPrice, item.Bid, prevItemTickDirection);
					item.AskTickDirection = Symbol.DetermineTickDirection(previousPrice2, item.Ask, prevItemTickDirection2);
					previousPrice = item.Bid;
					previousPrice2 = item.Ask;
					prevItemTickDirection = item.BidTickDirection;
					prevItemTickDirection2 = item.AskTickDirection;
				}
				return;
			}
		}
		double previousPrice3 = double.NaN;
		TickDirection prevItemTickDirection3 = TickDirection.NotSet;
		foreach (HistoryItemLast item2 in historyItems.OfType<HistoryItemLast>())
		{
			if (cancellationToken.IsCancellationRequested)
			{
				break;
			}
			item2.TickDirection = Symbol.DetermineTickDirection(previousPrice3, item2.Price, prevItemTickDirection3);
			previousPrice3 = item2.Price;
			prevItemTickDirection3 = item2.TickDirection;
		}
	}
}
