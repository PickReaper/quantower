using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using TradingPlatform.BusinessLayer.Utils;

namespace TradingPlatform.BusinessLayer;

public class IndicatorCloud : IComparable<IndicatorCloud>
{
	[CompilerGenerated]
	private int 녷;

	[CompilerGenerated]
	private int 녟;

	private Color 놱;

	[CompilerGenerated]
	private SolidBrush 놖;

	internal const int 놝 = -1;

	public int FromIndex
	{
		[CompilerGenerated]
		get
		{
			return 녷;
		}
		[CompilerGenerated]
		set
		{
			녷 = value;
		}
	}

	public int ToIndex
	{
		[CompilerGenerated]
		get
		{
			return 녟;
		}
		[CompilerGenerated]
		set
		{
			녟 = value;
		}
	}

	public Interval<int> Interval => new Interval<int>(FromIndex, ToIndex);

	public Color Color
	{
		get
		{
			return 놱;
		}
		set
		{
			놱 = value;
			Brush = new SolidBrush(놱);
		}
	}

	public SolidBrush Brush
	{
		[CompilerGenerated]
		get
		{
			return 놖;
		}
		[CompilerGenerated]
		private set
		{
			놖 = value;
		}
	}

	public IndicatorCloud()
	{
		FromIndex = -1;
		ToIndex = -1;
	}

	public int CompareTo(IndicatorCloud other)
	{
		if (this == other)
		{
			return 0;
		}
		if (other == null)
		{
			return 1;
		}
		return FromIndex.CompareTo(other.FromIndex);
	}

	public override string ToString()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(14, 3);
		defaultInterpolatedStringHandler.AppendFormatted(FromIndex);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴뇎());
		defaultInterpolatedStringHandler.AppendFormatted(ToIndex);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴놷());
		defaultInterpolatedStringHandler.AppendFormatted(Color.Name);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}
}
