using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;

namespace TradingPlatform.BusinessLayer;

public sealed class LineSeries : Line
{
	internal List<double> 뇅놊;

	[CompilerGenerated]
	private int 뇅놪;

	private static int 뇅놌;

	[CompilerGenerated]
	private int 뇅놕;

	[CompilerGenerated]
	private int 뇅뇊;

	[CompilerGenerated]
	private bool 뇅놋 = true;

	private readonly List<IndicatorLineMarker> 뇅녣;

	private readonly List<bool> 뇅녩 = new List<bool>();

	internal int LineSeriesId
	{
		[CompilerGenerated]
		get
		{
			return 뇅놪;
		}
		[CompilerGenerated]
		private set
		{
			뇅놪 = value;
		}
	}

	internal int Count => 뇅놊.Count;

	/// <summary>
	/// Sets the bar number (from the data beginning) from which the drawing of the given indicator line must start;
	/// </summary>
	public int DrawBegin
	{
		[CompilerGenerated]
		get
		{
			return 뇅놕;
		}
		[CompilerGenerated]
		set
		{
			뇅놕 = value;
		}
	}

	/// <summary>
	/// Time shift of indicator's line
	/// </summary>
	public int TimeShift
	{
		[CompilerGenerated]
		get
		{
			return 뇅뇊;
		}
		[CompilerGenerated]
		set
		{
			뇅뇊 = value;
		}
	}

	public bool ShowLineMarker
	{
		[CompilerGenerated]
		get
		{
			return 뇅놋;
		}
		[CompilerGenerated]
		set
		{
			뇅놋 = value;
		}
	}

	public double this[int offset = 0, SeekOriginHistory origin = SeekOriginHistory.End]
	{
		get
		{
			return GetValue(offset, origin);
		}
		set
		{
			SetValue(value, offset);
		}
	}

	public override IList<SettingItem> Settings
	{
		get
		{
			IList<SettingItem> settings = base.Settings;
			settings.Add(new SettingItemInteger(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿념(), TimeShift)
			{
				SortIndex = 3
			});
			settings.Add(new SettingItemBoolean(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿녨(), ShowLineMarker)
			{
				SortIndex = 4
			});
			settings.Add(new SettingItemInteger(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿녺(), LineSeriesId)
			{
				VisibilityMode = VisibilityMode.Hidden
			});
			return settings;
		}
		set
		{
			base.Settings = value;
			SettingItem itemByName = value.GetItemByName(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿념());
			if (itemByName != null && itemByName.Value is int timeShift)
			{
				TimeShift = timeShift;
			}
			itemByName = value.GetItemByName(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿녨());
			if (itemByName != null && itemByName.Value is bool showLineMarker)
			{
				ShowLineMarker = showLineMarker;
			}
		}
	}

	public LineSeries(string name, Color color, int width, LineStyle style)
		: base(name, color, width, style)
	{
		LineSeriesId = 뇅놌++;
		뇅놊 = new List<double>();
		뇅녣 = new List<IndicatorLineMarker>();
	}

	public double GetValue(int offset = 0, SeekOriginHistory origin = SeekOriginHistory.End)
	{
		double result = double.NaN;
		int num = 녴(offset, origin);
		if (num >= 0 && num < Count)
		{
			result = 뇅놊[num];
		}
		return result;
	}

	public void SetValue(double value, int offset = 0, SeekOriginHistory origin = SeekOriginHistory.End)
	{
		int index = 녴(offset, origin);
		뇅놊[index] = value;
	}

	internal void 녴()
	{
		뇅놊.Add(double.NaN);
		뇅녣.Add(null);
		뇅녩.Add(item: false);
	}

	public void Clear()
	{
		뇅놊.Clear();
		ClearMarkers();
		뇅녩.Clear();
	}

	/// <summary>
	/// Redraws parts of indicator's line within the interval set by offset
	/// </summary>
	public void SetMarker(int offset, Color color)
	{
		SetMarker(offset, new IndicatorLineMarker
		{
			Color = color
		});
	}

	public void SetMarker(int offset, IndicatorLineMarker indicatorMarker)
	{
		if (offset < 0 || offset >= 뇅녣.Count)
		{
			throw new ArgumentOutOfRangeException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놣());
		}
		뇅녣[뇅녣.Count - 1 - offset] = indicatorMarker;
	}

	/// <summary>
	/// Removes redrawn parts of indicator's line within the interval set by offset
	/// </summary>
	public void RemoveMarker(int offset)
	{
		if (offset < 0 || offset >= 뇅녣.Count)
		{
			throw new ArgumentOutOfRangeException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놣());
		}
		뇅녣[뇅녣.Count - 1 - offset] = null;
	}

	/// <summary>
	///
	/// </summary>
	public IndicatorLineMarker GetMarker(int offset)
	{
		if (offset < 0 || offset >= 뇅녣.Count)
		{
			return null;
		}
		return 뇅녣[뇅녣.Count - 1 - offset];
	}

	/// <summary>
	/// Fully clears markers from line
	/// </summary>
	public void ClearMarkers()
	{
		for (int i = 0; i < 뇅녣.Count; i++)
		{
			뇅녣[i] = null;
		}
	}

	public void SetLineBreak(int offset)
	{
		if (offset < 0 || offset >= 뇅녩.Count)
		{
			throw new ArgumentOutOfRangeException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놣());
		}
		뇅녩[뇅녩.Count - 1 - offset] = true;
	}

	public void RemoveLineBreak(int offset)
	{
		if (offset < 0 || offset >= 뇅녩.Count)
		{
			throw new ArgumentOutOfRangeException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놣());
		}
		뇅녩[뇅녩.Count - 1 - offset] = false;
	}

	public bool GetLineBreak(int offset)
	{
		if (offset < 0 || offset >= 뇅녩.Count)
		{
			throw new ArgumentOutOfRangeException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놣());
		}
		return 뇅녩[뇅녩.Count - 1 - offset];
	}

	private int 녴(int P_0, SeekOriginHistory P_1)
	{
		int result = P_0;
		if (P_1 == SeekOriginHistory.End)
		{
			result = Count - 1 - P_0;
		}
		return result;
	}
}
