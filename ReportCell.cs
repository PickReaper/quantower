using TradingPlatform.BusinessLayer.Integration;

namespace TradingPlatform.BusinessLayer;

/// <summary>
/// Exposes report cell decoration
/// </summary>
public class ReportCell
{
	/// <summary>
	/// Cell label
	/// </summary>
	public string Label;

	/// <summary>
	/// Cell value
	/// </summary>
	public object Value;

	public IFormattingDescription formattingDescription;

	internal ReportCell(string P_0, object P_1, IFormattingDescription P_2 = null)
	{
		Label = P_0;
		Value = P_1;
		formattingDescription = P_2;
	}
}
