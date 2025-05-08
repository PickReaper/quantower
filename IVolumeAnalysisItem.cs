namespace TradingPlatform.BusinessLayer;

/// <summary>
/// Defines 'Volume Analysis' calculation result item 
/// </summary>
public interface IVolumeAnalysisItem
{
	double GetValue(VolumeAnalysisField field);
}
