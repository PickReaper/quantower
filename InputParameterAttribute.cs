using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace TradingPlatform.BusinessLayer;

/// <summary>
/// Use this attribute to mark input parameters of your script. You will see them in the settings screen on adding
/// </summary>
[Published]
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
public class InputParameterAttribute : Attribute
{
	[CompilerGenerated]
	private string 녩;

	[CompilerGenerated]
	private int 놤;

	[CompilerGenerated]
	private double 논;

	[CompilerGenerated]
	private double 녘;

	[CompilerGenerated]
	private double 노;

	[CompilerGenerated]
	private int 녒;

	[CompilerGenerated]
	private IComparable[] 녕;

	/// <summary>
	/// Displayed name of input parameter
	/// </summary>
	public string Name
	{
		[CompilerGenerated]
		get
		{
			return 녩;
		}
		[CompilerGenerated]
		private set
		{
			녩 = value;
		}
	}

	/// <summary>
	/// Sort index for input paramter
	/// </summary>
	public int SortIndex
	{
		[CompilerGenerated]
		get
		{
			return 놤;
		}
		[CompilerGenerated]
		private set
		{
			놤 = value;
		}
	}

	/// <summary>
	/// Minimal value for numeric input parameters
	/// </summary>
	public double Minimum
	{
		[CompilerGenerated]
		get
		{
			return 논;
		}
		[CompilerGenerated]
		private set
		{
			논 = value;
		}
	}

	/// <summary>
	/// Maximal value for numeric input parameters
	/// </summary>
	public double Maximum
	{
		[CompilerGenerated]
		get
		{
			return 녘;
		}
		[CompilerGenerated]
		private set
		{
			녘 = value;
		}
	}

	/// <summary>
	/// Increment value for numeric input parameters
	/// </summary>
	public double Increment
	{
		[CompilerGenerated]
		get
		{
			return 노;
		}
		[CompilerGenerated]
		private set
		{
			노 = value;
		}
	}

	/// <summary>
	/// Decimal palces for numeric input parameters
	/// </summary>
	public int DecimalPlaces
	{
		[CompilerGenerated]
		get
		{
			return 녒;
		}
		[CompilerGenerated]
		private set
		{
			녒 = value;
		}
	}

	/// <summary>
	/// List of predefined values
	/// </summary>
	public IComparable[] Variants
	{
		[CompilerGenerated]
		get
		{
			return 녕;
		}
		[CompilerGenerated]
		private set
		{
			녕 = value;
		}
	}

	public InputParameterAttribute(string name = "", int sortIndex = 0, double minimum = -2147483648.0, double maximum = 2147483647.0, double increment = 0.01, int decimalPlaces = 2, object[] variants = null)
	{
		Name = name;
		SortIndex = sortIndex;
		Minimum = minimum;
		Maximum = maximum;
		Increment = increment;
		DecimalPlaces = decimalPlaces;
		Variants = variants?.Cast<IComparable>()?.ToArray();
	}
}
