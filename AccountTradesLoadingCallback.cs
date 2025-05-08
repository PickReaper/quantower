using System.Collections.Generic;

namespace TradingPlatform.BusinessLayer;

public delegate void AccountTradesLoadingCallback(IList<Trade> trades, bool isFinished);
