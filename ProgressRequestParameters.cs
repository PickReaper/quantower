using System;
using System.Runtime.CompilerServices;

namespace TradingPlatform.BusinessLayer;

public abstract class ProgressRequestParameters<TProgress> : RequestParameters
{
	[CompilerGenerated]
	private IProgress<TProgress> 녵놫;

	public IProgress<TProgress> Progress
	{
		[CompilerGenerated]
		get
		{
			return 녵놫;
		}
		[CompilerGenerated]
		set
		{
			녵놫 = value;
		}
	}

	public ProgressRequestParameters()
	{
		Progress = new Progress<TProgress>();
	}

	protected ProgressRequestParameters(ProgressRequestParameters<TProgress> origin)
		: base(origin)
	{
		Progress = origin.Progress;
	}
}
