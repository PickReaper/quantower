namespace TradingPlatform.BusinessLayer;

[Published]
public enum VolumeAnalysisCalculationState
{
	None = 0,
	Processing = 4,
	Finished = 0x10
}
