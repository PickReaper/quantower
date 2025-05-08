using System.Runtime.CompilerServices;

namespace TradingPlatform.BusinessLayer;

public struct VWAP
{
	[CompilerGenerated]
	private double 놵;

	[CompilerGenerated]
	private Side 놡;

	public double Price
	{
		[CompilerGenerated]
		readonly get
		{
			return 놵;
		}
		[CompilerGenerated]
		internal set
		{
			놵 = value;
		}
	}

	public Side Side
	{
		[CompilerGenerated]
		readonly get
		{
			return 놡;
		}
		[CompilerGenerated]
		internal set
		{
			놡 = value;
		}
	}
}
