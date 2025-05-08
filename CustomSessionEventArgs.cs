using System.Runtime.CompilerServices;
using TradingPlatform.BusinessLayer.Utils;

namespace TradingPlatform.BusinessLayer;

public class CustomSessionEventArgs : EntityLifecycleEventArgs
{
	[CompilerGenerated]
	private readonly CustomSessionsAssignment 녶놃;

	[CompilerGenerated]
	private readonly CustomSessionsContainer 녶뇇;

	public CustomSessionsAssignment Assignment
	{
		[CompilerGenerated]
		get
		{
			return 녶놃;
		}
		[CompilerGenerated]
		init
		{
			녶놃 = value;
		}
	}

	public CustomSessionsContainer Container
	{
		[CompilerGenerated]
		get
		{
			return 녶뇇;
		}
		[CompilerGenerated]
		init
		{
			녶뇇 = value;
		}
	}
}
