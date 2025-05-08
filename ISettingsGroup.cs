using System.Collections.Generic;

namespace TradingPlatform.BusinessLayer;

public interface ISettingsGroup
{
	string Text { get; }

	int SortIndex { get; }

	ISettingsGroup ParentGroup { get; }

	IList<ISettingsGroup> ChildGroups { get; }

	GroupActionInfo FirstActionInfo { get; }

	GroupActionInfo SecondActionInfo { get; }
}
