using TradingPlatform.BusinessLayer.Chart;

namespace TradingPlatform.BusinessLayer;

public interface ISaveAsTemplate : ISetAsDefault
{
	IChartObjectTemplate[] AvailableTemplates { get; }

	void SaveAsTemplate();

	void ApplyTemplate(IChartObjectTemplate template);

	void RenameTemplate(IChartObjectTemplate template);

	void RemoveTemplate(IChartObjectTemplate template);
}
