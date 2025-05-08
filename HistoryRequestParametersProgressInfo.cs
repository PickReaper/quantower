using System;
using System.Runtime.CompilerServices;

namespace TradingPlatform.BusinessLayer;

public class HistoryRequestParametersProgressInfo : IProgress<float>
{
	[CompilerGenerated]
	private float 녰;

	public float ProgressValue
	{
		[CompilerGenerated]
		get
		{
			return 녰;
		}
		[CompilerGenerated]
		private set
		{
			녰 = value;
		}
	}

	public void Report(float value)
	{
		ProgressValue = value;
	}
}
