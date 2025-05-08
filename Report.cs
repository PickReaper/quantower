using System.Collections.Generic;

namespace TradingPlatform.BusinessLayer;

/// <summary>
/// Represents a report grid which can hold system reports based on <see cref="T:TradingPlatform.BusinessLayer.ReportRow" />s and <see cref="T:TradingPlatform.BusinessLayer.ReportColumn" />s content.
/// </summary>
public class Report
{
	/// <summary>
	/// Columns collection 
	/// </summary>
	public List<ReportColumn> Columns;

	/// <summary>
	/// Rows collection 
	/// </summary>
	public List<ReportRow> Rows;

	internal string 녲;

	/// <summary>
	/// Initializes report grid
	/// </summary>
	public Report()
	{
		Columns = new List<ReportColumn>();
		Rows = new List<ReportRow>();
	}

	/// <summary>
	/// Adds coloring column to the report
	/// </summary>
	public void AddColumn(string header, ComparingType valueType, ColouringModes coloringModes)
	{
		Columns.Add(new ReportColumn(header, valueType, coloringModes));
	}

	/// <summary>
	/// Adds default(non-colored) column to the report
	/// </summary>
	public void AddColumn(string header, ComparingType valueType)
	{
		AddColumn(header, valueType, ColouringModes.None);
	}
}
