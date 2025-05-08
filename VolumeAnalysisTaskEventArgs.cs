using System;
using System.Runtime.CompilerServices;

namespace TradingPlatform.BusinessLayer;

public class VolumeAnalysisTaskEventArgs : EventArgs
{
	[CompilerGenerated]
	private readonly VolumeAnalysisCalculationState 놂놢;

	[CompilerGenerated]
	private readonly int 놂녧;

	public VolumeAnalysisCalculationState CalculationState
	{
		[CompilerGenerated]
		get
		{
			return 놂놢;
		}
	}

	public int ProgressPercent
	{
		[CompilerGenerated]
		get
		{
			return 놂녧;
		}
	}

	internal VolumeAnalysisTaskEventArgs(IVolumeAnalysisCalculationProgress P_0)
	{
		놂놢 = P_0.State;
		놂녧 = P_0.ProgressPercent;
	}
}
