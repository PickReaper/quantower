using System;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;

namespace TradingPlatform.BusinessLayer;

/// <summary>
/// Represent access to level2 item.
/// </summary>
[Published]
public class Level2Item
{
	[CompilerGenerated]
	private string 녢;

	[CompilerGenerated]
	private double 놞;

	[CompilerGenerated]
	private double 놳;

	[CompilerGenerated]
	private double 놺;

	[CompilerGenerated]
	private double 놅;

	[CompilerGenerated]
	private DateTime 녜;

	[CompilerGenerated]
	private string 뇃;

	[CompilerGenerated]
	private long 녯;

	[CompilerGenerated]
	private Level2Item[] 놮;

	public string Id
	{
		[CompilerGenerated]
		get
		{
			return 녢;
		}
		[CompilerGenerated]
		internal set
		{
			녢 = value;
		}
	}

	/// <summary>
	/// Cumulative size
	/// </summary>
	public double Cumulative
	{
		[CompilerGenerated]
		get
		{
			return 놞;
		}
		[CompilerGenerated]
		internal set
		{
			놞 = value;
		}
	}

	/// <summary>
	/// Imbalance Percent
	/// </summary>
	public double ImbalancePercent
	{
		[CompilerGenerated]
		get
		{
			return 놳;
		}
		[CompilerGenerated]
		internal set
		{
			놳 = value;
		}
	}

	/// <summary>
	/// Price
	/// </summary>
	public double Price
	{
		[CompilerGenerated]
		get
		{
			return 놺;
		}
		[CompilerGenerated]
		private set
		{
			놺 = value;
		}
	}

	/// <summary>
	/// Size
	/// </summary>
	public double Size
	{
		[CompilerGenerated]
		get
		{
			return 놅;
		}
		[CompilerGenerated]
		private set
		{
			놅 = value;
		}
	}

	/// <summary>
	/// Time
	/// </summary>
	public DateTime QuoteTime
	{
		[CompilerGenerated]
		get
		{
			return 녜;
		}
		[CompilerGenerated]
		private set
		{
			녜 = value;
		}
	}

	/// <summary>
	/// MMID
	/// </summary>
	public string MMID
	{
		[CompilerGenerated]
		get
		{
			return 뇃;
		}
		[CompilerGenerated]
		private set
		{
			뇃 = value;
		}
	}

	public long Priority
	{
		[CompilerGenerated]
		get
		{
			return 녯;
		}
		[CompilerGenerated]
		private set
		{
			녯 = value;
		}
	}

	public Level2Item[] DetailedLevels
	{
		[CompilerGenerated]
		get
		{
			return 놮;
		}
		[CompilerGenerated]
		set
		{
			놮 = value;
		}
	}

	private Level2Item()
	{
		Cumulative = double.NaN;
		ImbalancePercent = double.NaN;
	}

	internal Level2Item(double P_0, double P_1, DateTime P_2, string P_3, long P_4)
		: this()
	{
		Price = P_0;
		Size = P_1;
		QuoteTime = P_2;
		MMID = P_3;
		Priority = P_4;
	}

	internal Level2Item(double P_0, double P_1, DateTime P_2, string P_3, long P_4, Level2Item[] P_5)
		: this(P_0, P_1, P_2, P_3, P_4)
	{
		DetailedLevels = P_5;
	}

	public override string ToString()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(14, 2);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놼());
		defaultInterpolatedStringHandler.AppendFormatted(Price);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놗());
		defaultInterpolatedStringHandler.AppendFormatted(Size);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}
}
