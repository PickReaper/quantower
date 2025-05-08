using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;

namespace TradingPlatform.BusinessLayer;

public sealed class LineLevel : Line
{
	[CompilerGenerated]
	private double 뇅놬;

	public double Level
	{
		[CompilerGenerated]
		get
		{
			return 뇅놬;
		}
		[CompilerGenerated]
		set
		{
			뇅놬 = value;
		}
	}

	public override IList<SettingItem> Settings
	{
		get
		{
			IList<SettingItem> settings = base.Settings;
			settings.Add(new SettingItemDouble(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴놯(), Level)
			{
				SortIndex = 2
			});
			return settings;
		}
		set
		{
			SettingItem itemByName = value.GetItemByName(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴놯());
			if (itemByName != null && itemByName.Value is double level)
			{
				Level = level;
			}
			base.Settings = value;
		}
	}

	public LineLevel(double level, string name, Color color, int width, LineStyle style)
		: base(name, color, width, style)
	{
		Level = level;
	}
}
