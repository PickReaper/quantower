namespace TradingPlatform.BusinessLayer;

public interface IIndicatorsCollection
{
	void AddIndicator(Indicator indicator);

	void RemoveIndicator(Indicator indicator);
}
