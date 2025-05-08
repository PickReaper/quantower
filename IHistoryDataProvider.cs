using System;
using System.Threading;

namespace TradingPlatform.BusinessLayer;

public interface IHistoryDataProvider
{
	bool AllDataAlreadyProvided { get; }

	string ProgressValue { get; }

	event Action<string> ProgressChanged;

	HistoryHolder GetHistory(CancellationToken changeToken);
}
