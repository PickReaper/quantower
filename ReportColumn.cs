using System.Drawing;
using System.Runtime.CompilerServices;

namespace TradingPlatform.BusinessLayer;

/// <summary>
/// Exposes report column decoration
/// </summary>
public class ReportColumn
{
	[CompilerGenerated]
	private Color 뇋;

	[CompilerGenerated]
	private Color 놸;

	/// <summary>
	/// Header of the column
	/// </summary>
	public string Header;

	public ColouringModes ColoringModes;

	/// <summary>
	/// Column value type
	/// </summary>
	public ComparingType ValueType;

	public Color UpForeColor
	{
		[CompilerGenerated]
		get
		{
			return 뇋;
		}
		[CompilerGenerated]
		private set
		{
			뇋 = value;
		}
	}

	public Color DownForeColor
	{
		[CompilerGenerated]
		get
		{
			return 놸;
		}
		[CompilerGenerated]
		private set
		{
			놸 = value;
		}
	}

	internal ReportColumn(string P_0, ComparingType P_1, ColouringModes P_2)
	{
		Header = P_0;
		ValueType = P_1;
		ColoringModes = P_2;
		if (P_2 == ColouringModes.Signed)
		{
			UpForeColor = Color.FromArgb(55, 219, 186);
			DownForeColor = Color.FromArgb(235, 96, 47);
		}
	}
}
