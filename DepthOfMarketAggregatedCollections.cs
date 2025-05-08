using System.Runtime.CompilerServices;

namespace TradingPlatform.BusinessLayer;

/// <summary>
/// Leve2 data. Contains Bids and Ask collections
/// </summary>
[Published]
public class DepthOfMarketAggregatedCollections
{
	[CompilerGenerated]
	private Level2Item[] 녭;

	[CompilerGenerated]
	private Level2Item[] 녱;

	public Level2Item[] Asks
	{
		[CompilerGenerated]
		get
		{
			return 녭;
		}
		[CompilerGenerated]
		internal set
		{
			녭 = value;
		}
	}

	public Level2Item[] Bids
	{
		[CompilerGenerated]
		get
		{
			return 녱;
		}
		[CompilerGenerated]
		internal set
		{
			녱 = value;
		}
	}
}
