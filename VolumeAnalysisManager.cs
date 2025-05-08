using System;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using TradingPlatform.BusinessLayer.Utils;
using 녴;

namespace TradingPlatform.BusinessLayer;

/// <summary>
/// Volume Analysis calculations
/// </summary>
[Published]
public class VolumeAnalysisManager
{
	private const int 놂놨 = 10;

	private const int 놂녢 = 7;

	private int 놂놞;

	private readonly ActionBufferedProcessorWithPriority 놂놳;

	internal VolumeAnalysisManager()
	{
		놂놳 = new ActionBufferedProcessorWithPriority(3);
	}

	internal void 녴()
	{
		놂놳.Start();
	}

	internal void 놴()
	{
		놂놳?.Stop();
	}

	/// <summary>
	/// Calculate volume profile for requested time range
	/// </summary>
	public IVolumeAnalysisCalculationTask CalculateProfile(VolumeAnalysisCalculationRequest request)
	{
		VolumeAnalysisCalculationRequest volumeAnalysisCalculationRequest = new VolumeAnalysisCalculationRequest(request);
		if (Core.Instance.SymbolsMapping.TryGetVolumeAnalysisSymbol(request.Symbol, out var volumeAnalysisSymbol))
		{
			volumeAnalysisCalculationRequest.Symbol = volumeAnalysisSymbol;
		}
		bool num = 녴(volumeAnalysisCalculationRequest);
		뇃 뇃 = new 뇃(volumeAnalysisCalculationRequest);
		if (!num)
		{
			뇃.State = VolumeAnalysisCalculationState.Finished;
			return 뇃;
		}
		놂놳.Push(뇃.녴, 1, volumeAnalysisCalculationRequest.Marker);
		return 뇃;
	}

	/// <summary>
	/// Calculate volume profile for each bar in History Data
	/// </summary>
	public IVolumeAnalysisCalculationProgress CalculateProfile(HistoricalData historicalData, VolumeAnalysisCalculationParameters calculationParameters)
	{
		VolumeAnalysisCalculationRequest volumeAnalysisCalculationRequest = new VolumeAnalysisCalculationRequest(calculationParameters)
		{
			Symbol = historicalData.Symbol,
			From = ((historicalData.Count == 0) ? Core.Instance.TimeUtils.DateTimeUtcNow : historicalData[0, SeekOriginHistory.Begin].TimeLeft),
			To = ((historicalData.ToTime == DateTime.MinValue) ? Core.Instance.TimeUtils.DateTimeUtcNow : historicalData.ToTime)
		};
		if (Core.Instance.SymbolsMapping.TryGetVolumeAnalysisSymbol(volumeAnalysisCalculationRequest.Symbol, out var volumeAnalysisSymbol))
		{
			volumeAnalysisCalculationRequest.Symbol = volumeAnalysisSymbol;
		}
		bool num = 녴(volumeAnalysisCalculationRequest);
		녯 녯 = ((historicalData.Aggregation.BarCreationBehavior == BarCreationBehavior.Deferred) ? new 놮(historicalData, volumeAnalysisCalculationRequest) : new 녯(historicalData, volumeAnalysisCalculationRequest));
		if (!num)
		{
			녯.State = VolumeAnalysisCalculationState.Finished;
			return 녯;
		}
		historicalData.VolumeAnalysisCalculationProgress = 녯;
		놂놳.Push(녯.녴, 1, volumeAnalysisCalculationRequest.Marker);
		return 녯;
	}

	/// <summary>
	/// Calculate volume profile for requested time range
	/// </summary>
	public IVolumeAnalysisCalculationTask CalculateProfile(Symbol symbol, DateTime from, DateTime to)
	{
		return CalculateProfile(new VolumeAnalysisCalculationRequest
		{
			Symbol = symbol,
			From = from,
			To = to
		});
	}

	/// <summary>
	/// Calculate volume profile for each bar in History Data
	/// </summary>
	public IVolumeAnalysisCalculationProgress CalculateProfile(HistoricalData historicalData)
	{
		return CalculateProfile(historicalData, new VolumeAnalysisCalculationParameters());
	}

	private bool 녴(VolumeAnalysisCalculationRequest P_0)
	{
		if (P_0 == null)
		{
			return false;
		}
		if ((Core.Instance.Licences.GetLicenceRuleItem(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂녠()) ?? Core.Instance.Licences.GetLicenceRuleItem(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놠()) ?? Core.Instance.Licences.GetLicenceRuleItem(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놟()) ?? Core.Instance.Licences.GetLicenceRuleItem(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놓())) == null && Core.Instance.RulesManager.IsAllowed(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놓(), P_0.Symbol).Status != 0 && Core.Instance.RulesManager.IsAllowed(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂녠(), P_0.Symbol).Status != 0 && (P_0.Symbol == null || P_0.Symbol.State != BusinessObjectState.Fake))
		{
			놂놞++;
			if (놂놞 > 10)
			{
				Core.Instance.Licences.OnLicenceCheckError(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂녓(), null);
				return false;
			}
			DateTime dateTime = Core.Instance.TimeUtils.DateTimeUtcNow.AddDays(-7.0);
			if (P_0.From < dateTime)
			{
				P_0.From = dateTime;
				Core.Instance.Licences.OnLicenceCheckError(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂녛(), null);
			}
		}
		return true;
	}
}
