using System.Runtime.CompilerServices;

namespace TradingPlatform.BusinessLayer;

/// <summary>
/// Represent parameters of request for Leve2Item collection
/// </summary>
[Published]
public class GetLevel2ItemsParameters
{
	[CompilerGenerated]
	private AggregateMethod 놶;

	[CompilerGenerated]
	private ImplicitOrderBookType 뇏;

	[CompilerGenerated]
	private int 녻;

	[CompilerGenerated]
	private double 녙;

	[CompilerGenerated]
	private bool 놢;

	[CompilerGenerated]
	private bool 녧;

	/// <summary>
	/// Aggregation method
	/// </summary>
	public AggregateMethod AggregateMethod
	{
		[CompilerGenerated]
		get
		{
			return 놶;
		}
		[CompilerGenerated]
		set
		{
			놶 = value;
		}
	}

	public ImplicitOrderBookType ImplicitOrderBookType
	{
		[CompilerGenerated]
		get
		{
			return 뇏;
		}
		[CompilerGenerated]
		set
		{
			뇏 = value;
		}
	}

	/// <summary>
	/// Required amount of level2
	/// </summary>
	public int LevelsCount
	{
		[CompilerGenerated]
		get
		{
			return 녻;
		}
		[CompilerGenerated]
		set
		{
			녻 = value;
		}
	}

	/// <summary>
	/// Use custom tick size
	/// </summary>
	public double CustomTickSize
	{
		[CompilerGenerated]
		get
		{
			return 녙;
		}
		[CompilerGenerated]
		set
		{
			녙 = value;
		}
	}

	/// <summary>
	/// Calculate cumulative size
	/// </summary>
	public bool CalculateCumulative
	{
		[CompilerGenerated]
		get
		{
			return 놢;
		}
		[CompilerGenerated]
		set
		{
			놢 = value;
		}
	}

	public bool GetMBOItems
	{
		[CompilerGenerated]
		get
		{
			return 녧;
		}
		[CompilerGenerated]
		set
		{
			녧 = value;
		}
	}

	public static bool operator ==(GetLevel2ItemsParameters p1, GetLevel2ItemsParameters p2)
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

	public static bool operator !=(GetLevel2ItemsParameters p1, GetLevel2ItemsParameters p2)
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
		if (!(obj is GetLevel2ItemsParameters getLevel2ItemsParameters))
		{
			return false;
		}
		if (AggregateMethod != getLevel2ItemsParameters.AggregateMethod)
		{
			return false;
		}
		if (LevelsCount != getLevel2ItemsParameters.LevelsCount)
		{
			return false;
		}
		if (CustomTickSize != getLevel2ItemsParameters.CustomTickSize)
		{
			return false;
		}
		if (CalculateCumulative != getLevel2ItemsParameters.CalculateCumulative)
		{
			return false;
		}
		if (ImplicitOrderBookType != getLevel2ItemsParameters.ImplicitOrderBookType)
		{
			return false;
		}
		if (GetMBOItems != getLevel2ItemsParameters.GetMBOItems)
		{
			return false;
		}
		return true;
	}

	public override int GetHashCode()
	{
		return (int)((uint)AggregateMethod ^ (uint)LevelsCount ^ (uint)CustomTickSize.GetHashCode() ^ (uint)CalculateCumulative.GetHashCode() ^ (uint)ImplicitOrderBookType.GetHashCode()) ^ GetMBOItems.GetHashCode();
	}
}
