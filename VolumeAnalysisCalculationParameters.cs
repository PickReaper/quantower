using System.Runtime.CompilerServices;

namespace TradingPlatform.BusinessLayer;

/// <summary>
/// Provides VA calculation parameters
/// </summary>
[Published]
public class VolumeAnalysisCalculationParameters
{
	[CompilerGenerated]
	private double 놂녿;

	[CompilerGenerated]
	private bool 놂놁;

	[CompilerGenerated]
	private DeltaCalculationType 놂녭;

	[CompilerGenerated]
	private CumulativeDeltaReset 놂녱;

	[CompilerGenerated]
	private double 놂놲;

	[CompilerGenerated]
	private int 놂높;

	[CompilerGenerated]
	private ISessionsContainer 놂놶;

	[CompilerGenerated]
	private TimeZone 놂뇏;

	[CompilerGenerated]
	private bool 놂녻;

	[CompilerGenerated]
	private bool 놂녙;

	public double FilteredVolume
	{
		[CompilerGenerated]
		get
		{
			return 놂녿;
		}
		[CompilerGenerated]
		set
		{
			놂녿 = value;
		}
	}

	public bool ForceReload
	{
		[CompilerGenerated]
		get
		{
			return 놂놁;
		}
		[CompilerGenerated]
		set
		{
			놂놁 = value;
		}
	}

	public DeltaCalculationType DeltaCalculationType
	{
		[CompilerGenerated]
		get
		{
			return 놂녭;
		}
		[CompilerGenerated]
		set
		{
			놂녭 = value;
		}
	}

	public CumulativeDeltaReset CumulativeDeltaReset
	{
		[CompilerGenerated]
		get
		{
			return 놂녱;
		}
		[CompilerGenerated]
		set
		{
			놂녱 = value;
		}
	}

	public double CustomTickSize
	{
		[CompilerGenerated]
		get
		{
			return 놂놲;
		}
		[CompilerGenerated]
		set
		{
			놂놲 = value;
		}
	}

	public int CustomStep
	{
		[CompilerGenerated]
		get
		{
			return 놂높;
		}
		[CompilerGenerated]
		set
		{
			놂높 = value;
		}
	}

	public ISessionsContainer SessionsContainer
	{
		[CompilerGenerated]
		get
		{
			return 놂놶;
		}
		[CompilerGenerated]
		set
		{
			놂놶 = value;
		}
	}

	public TimeZone TimeZone
	{
		[CompilerGenerated]
		get
		{
			return 놂뇏;
		}
		[CompilerGenerated]
		set
		{
			놂뇏 = value;
		}
	}

	public bool CalculatePriceLevels
	{
		[CompilerGenerated]
		get
		{
			return 놂녻;
		}
		[CompilerGenerated]
		set
		{
			놂녻 = value;
		}
	}

	public bool ForceUsingTickData
	{
		[CompilerGenerated]
		get
		{
			return 놂녙;
		}
		[CompilerGenerated]
		set
		{
			놂녙 = value;
		}
	}

	public VolumeAnalysisCalculationParameters()
	{
		FilteredVolume = 0.0;
		ForceReload = false;
		DeltaCalculationType = DeltaCalculationType.AggressorFlag;
		CustomTickSize = double.NaN;
		CustomStep = 1;
		CalculatePriceLevels = true;
		ForceUsingTickData = false;
	}

	internal VolumeAnalysisCalculationParameters(VolumeAnalysisCalculationParameters P_0)
	{
		FilteredVolume = P_0.FilteredVolume;
		ForceReload = P_0.ForceReload;
		DeltaCalculationType = P_0.DeltaCalculationType;
		CumulativeDeltaReset = P_0.CumulativeDeltaReset;
		CustomTickSize = P_0.CustomTickSize;
		CustomStep = P_0.CustomStep;
		SessionsContainer = P_0.SessionsContainer;
		TimeZone = P_0.TimeZone;
		CalculatePriceLevels = P_0.CalculatePriceLevels;
		ForceUsingTickData = P_0.ForceUsingTickData;
	}
}
