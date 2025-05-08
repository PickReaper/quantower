using System;
using System.Runtime.CompilerServices;

namespace TradingPlatform.BusinessLayer;

public readonly struct IndicatorCloudKey : IEquatable<IndicatorCloudKey>
{
	[CompilerGenerated]
	private readonly int 뇄;

	[CompilerGenerated]
	private readonly int 녑;

	public int Line1Index
	{
		[CompilerGenerated]
		get
		{
			return 뇄;
		}
	}

	public int Line2Index
	{
		[CompilerGenerated]
		get
		{
			return 녑;
		}
	}

	public IndicatorCloudKey(int line1Index, int line2Index)
	{
		뇄 = line1Index;
		녑 = line2Index;
	}

	public bool Equals(IndicatorCloudKey other)
	{
		if (Line1Index == other.Line1Index)
		{
			return Line2Index == other.Line2Index;
		}
		return false;
	}

	public override bool Equals(object obj)
	{
		if (obj is IndicatorCloudKey other)
		{
			return Equals(other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return (Line1Index * 397) ^ Line2Index;
	}
}
