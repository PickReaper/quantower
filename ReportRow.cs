using System.Collections.Generic;
using TradingPlatform.BusinessLayer.Integration;

namespace TradingPlatform.BusinessLayer;

/// <summary>
/// Exposes report row decoration
/// </summary>
public class ReportRow
{
	/// <summary>
	/// A collection of cells
	/// </summary>
	public List<ReportCell> Cells;

	/// <summary>
	/// Initializes cells in the row
	/// </summary>
	public ReportRow()
	{
		Cells = new List<ReportCell>();
	}

	/// <summary>
	/// Adds cells to the row by label and value
	/// </summary>
	public void AddCell(string label, object value, IFormattingDescription formattingDescription = null)
	{
		Cells.Add(new ReportCell(label, value, formattingDescription));
	}

	/// <summary>
	/// Adds cells to the row by value only
	/// </summary>
	public void AddCell(object value, IFormattingDescription formattingDescription = null)
	{
		if (value == null)
		{
			AddCell(string.Empty, string.Empty, formattingDescription);
			return;
		}
		string label = ((!(value is double d)) ? value.ToString() : (double.IsNaN(d) ? string.Empty : d.ToString()));
		AddCell(label, value, formattingDescription);
	}
}
