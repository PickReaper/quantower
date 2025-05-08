namespace TradingPlatform.BusinessLayer;

public interface IVolumeAnalysisIndicator
{
	bool IsRequirePriceLevelsCalculation { get; }

	void VolumeAnalysisData_Loaded();
}
