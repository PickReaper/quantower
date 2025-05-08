using System.Runtime.Serialization;

namespace TradingPlatform.BusinessLayer;

[DataContract(Name = "AvailableDerivatives", Namespace = "TradingPlatform")]
public enum AvailableDerivatives
{
	None,
	Unknown,
	Present
}
