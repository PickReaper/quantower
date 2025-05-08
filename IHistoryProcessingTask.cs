using System;

namespace TradingPlatform.BusinessLayer;

public interface IHistoryProcessingTask
{
	HistoryTaskStateEnum TaskState { get; }

	string ProgressValue { get; }

	string Description { get; }

	event Action<HistoryTaskStateEnum> TaskStateChanged;

	event Action<string> ProgressChanged;

	void Stop();
}
