using System;
using System.Threading;

namespace TradingPlatform.BusinessLayer;

[Published]
public interface IVolumeAnalysisCalculationProgress : IDisposable
{
	VolumeAnalysisCalculationState State { get; }

	int ProgressPercent { get; }

	int ProgressBarIndex { get; }

	bool IsAborted { get; }

	VolumeAnalysisCalculationParameters CalculationParameters { get; }

	event EventHandler<VolumeAnalysisTaskEventArgs> StateChanged;

	event EventHandler<VolumeAnalysisTaskEventArgs> ProgressChanged;

	void AbortLoading();

	void Wait(CancellationToken token = default(CancellationToken));
}
