using System.Runtime.CompilerServices;

namespace TradingPlatform.BusinessLayer;

/// <summary>
/// Represent parameters of DepthOfMarket
/// </summary>
[Published]
public class GetDepthOfMarketParameters
{
	[CompilerGenerated]
	private GetLevel2ItemsParameters 놲;

	[CompilerGenerated]
	private bool 높;

	public GetLevel2ItemsParameters GetLevel2ItemsParameters
	{
		[CompilerGenerated]
		get
		{
			return 놲;
		}
		[CompilerGenerated]
		set
		{
			놲 = value;
		}
	}

	public bool CalculateImbalancePercent
	{
		[CompilerGenerated]
		get
		{
			return 높;
		}
		[CompilerGenerated]
		set
		{
			높 = value;
		}
	}

	public GetDepthOfMarketParameters()
	{
		GetLevel2ItemsParameters = new GetLevel2ItemsParameters();
	}

	public static bool operator ==(GetDepthOfMarketParameters p1, GetDepthOfMarketParameters p2)
	{
		if ((object)p1 == null || (object)p2 == null)
		{
			if ((object)p1 == null)
			{
				return (object)p2 == null;
			}
			return false;
		}
		return p1.Equals(p2);
	}

	public static bool operator !=(GetDepthOfMarketParameters p1, GetDepthOfMarketParameters p2)
	{
		if ((object)p1 == null || (object)p2 == null)
		{
			if ((object)p1 == null)
			{
				return (object)p2 != null;
			}
			return true;
		}
		return !p1.Equals(p2);
	}

	public override bool Equals(object obj)
	{
		if (!(obj is GetDepthOfMarketParameters getDepthOfMarketParameters))
		{
			return false;
		}
		if (GetLevel2ItemsParameters != getDepthOfMarketParameters.GetLevel2ItemsParameters)
		{
			return false;
		}
		if (CalculateImbalancePercent != getDepthOfMarketParameters.CalculateImbalancePercent)
		{
			return false;
		}
		return true;
	}

	public override int GetHashCode()
	{
		return GetLevel2ItemsParameters.GetHashCode() ^ CalculateImbalancePercent.GetHashCode();
	}
}
