using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using TradingPlatform.BusinessLayer.Utils;

namespace TradingPlatform.BusinessLayer;

public abstract class Line : ICustomizable
{
	[CompilerGenerated]
	private string 녶놹;

	[CompilerGenerated]
	private Color 녶놘;

	[CompilerGenerated]
	private int 녶뇌;

	[CompilerGenerated]
	private LineStyle 녶녷;

	[CompilerGenerated]
	private bool 녶녟;

	public string Name
	{
		[CompilerGenerated]
		get
		{
			return 녶놹;
		}
		[CompilerGenerated]
		set
		{
			녶놹 = value;
		}
	}

	public Color Color
	{
		[CompilerGenerated]
		get
		{
			return 녶놘;
		}
		[CompilerGenerated]
		set
		{
			녶놘 = value;
		}
	}

	public int Width
	{
		[CompilerGenerated]
		get
		{
			return 녶뇌;
		}
		[CompilerGenerated]
		set
		{
			녶뇌 = value;
		}
	}

	public LineStyle Style
	{
		[CompilerGenerated]
		get
		{
			return 녶녷;
		}
		[CompilerGenerated]
		set
		{
			녶녷 = value;
		}
	}

	public bool Visible
	{
		[CompilerGenerated]
		get
		{
			return 녶녟;
		}
		[CompilerGenerated]
		set
		{
			녶녟 = value;
		}
	}

	public virtual IList<SettingItem> Settings
	{
		get
		{
			return new List<SettingItem>
			{
				new SettingItemBoolean(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶놢(), Visible)
				{
					SortIndex = 0
				},
				new SettingItemLineOptions(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭녚(), new LineOptions
				{
					WithCheckBox = false,
					Color = Color,
					Width = Width,
					LineStyle = Style
				})
				{
					SortIndex = 1
				}
			};
		}
		set
		{
			SettingItem itemByName = value.GetItemByName(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶놢());
			if (itemByName != null && itemByName.Value is bool visible)
			{
				Visible = visible;
			}
			itemByName = value.GetItemByName(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭녚());
			if (itemByName != null && itemByName.Value is LineOptions lineOptions)
			{
				Color = lineOptions.Color;
				Width = lineOptions.Width;
				Style = lineOptions.LineStyle;
			}
		}
	}

	protected Line(string name, Color color, int width, LineStyle style)
	{
		Name = name;
		Color = color;
		Width = width;
		Style = style;
		Visible = true;
	}
}
