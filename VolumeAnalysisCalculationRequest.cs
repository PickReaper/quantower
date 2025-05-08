using System;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;

namespace TradingPlatform.BusinessLayer;

/// <summary>
/// Provides VA calculation request per <see cref="T:TradingPlatform.BusinessLayer.Symbol" />
/// </summary>
[Published]
public class VolumeAnalysisCalculationRequest : VolumeAnalysisCalculationParameters
{
	[CompilerGenerated]
	private Symbol 녲놥;

	[CompilerGenerated]
	private DateTime 녲놯;

	[CompilerGenerated]
	private DateTime 녲녾;

	public Symbol Symbol
	{
		[CompilerGenerated]
		get
		{
			return 녲놥;
		}
		[CompilerGenerated]
		set
		{
			녲놥 = value;
		}
	}

	public DateTime From
	{
		[CompilerGenerated]
		get
		{
			return 녲놯;
		}
		[CompilerGenerated]
		set
		{
			녲놯 = value;
		}
	}

	public DateTime To
	{
		[CompilerGenerated]
		get
		{
			return 녲녾;
		}
		[CompilerGenerated]
		set
		{
			녲녾 = value;
		}
	}

	internal string Marker => Symbol?.Name + _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녲뇂() + Symbol?.ConnectionId;

	public VolumeAnalysisCalculationRequest()
	{
	}

	internal VolumeAnalysisCalculationRequest(VolumeAnalysisCalculationRequest P_0)
		: base(P_0)
	{
		Symbol = P_0.Symbol;
		From = P_0.From;
		To = P_0.To;
	}

	internal VolumeAnalysisCalculationRequest(VolumeAnalysisCalculationParameters P_0)
		: base(P_0)
	{
	}
}
