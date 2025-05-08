using System.Reflection;

namespace TradingPlatform.BusinessLayer;

[Obfuscation(Exclude = true)]
public enum CorporateActionType
{
	Undefined,
	Split,
	Dividend
}
