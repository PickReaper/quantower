using System.Runtime.CompilerServices;
using TradingPlatform.BusinessLayer.Utils;

namespace TradingPlatform.BusinessLayer;

public class TradingSignalEventArgs : EntityLifecycleEventArgs
{
	[CompilerGenerated]
	private readonly TradingSignal 놫놱;

	public TradingSignal TradingSignal
	{
		[CompilerGenerated]
		get
		{
			return 놫놱;
		}
		[CompilerGenerated]
		init
		{
			놫놱 = value;
		}
	}
}
