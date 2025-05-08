using System;
using System.Runtime.CompilerServices;

namespace TradingPlatform.BusinessLayer;

[Published]
public class VolumeAnalysisDataEventArgs : EventArgs
{
	[CompilerGenerated]
	private readonly double 놂녗;

	[CompilerGenerated]
	private readonly VolumeAnalysisItem 놂놜;

	public double Price
	{
		[CompilerGenerated]
		get
		{
			return 놂녗;
		}
	}

	public VolumeAnalysisItem Item
	{
		[CompilerGenerated]
		get
		{
			return 놂놜;
		}
	}

	internal VolumeAnalysisDataEventArgs(double P_0, VolumeAnalysisItem P_1)
	{
		놂녗 = P_0;
		놂놜 = P_1;
	}
}
