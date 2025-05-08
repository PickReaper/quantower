using System;

namespace TradingPlatform.BusinessLayer;

[Published]
public interface IVolumeAnalysisCalculationTask : IDisposable
{
	VolumeAnalysisData Result { get; }

	IVolumeAnalysisCalculationProgress Progress { get; }
}
