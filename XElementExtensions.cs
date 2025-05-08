using System;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;

namespace TradingPlatform.BusinessLayer;

public static class XElementExtensions
{
	public static bool ToBool(this XElement element)
	{
		if (!bool.TryParse(element.Value, out var result))
		{
			return false;
		}
		return result;
	}

	public static int ToInt(this XElement element)
	{
		if (!int.TryParse(element.Value, out var result))
		{
			return 0;
		}
		return result;
	}

	public static long ToLong(this XElement element)
	{
		if (!long.TryParse(element.Value, out var result))
		{
			return 0L;
		}
		return result;
	}

	public static double ToDouble(this XElement element)
	{
		if (!double.TryParse(element.Value, NumberStyles.Float, CultureInfo.InvariantCulture, out var result))
		{
			return 0.0;
		}
		return result;
	}

	public static decimal ToDecimal(this XElement element)
	{
		if (!decimal.TryParse(element.Value, out var result))
		{
			return 0m;
		}
		return result;
	}

	public static DateTime ToDateTime(this XElement element, bool toUTC = false)
	{
		if (DateTime.TryParse(element.Value, out var result))
		{
			if (!toUTC)
			{
				return result;
			}
			return result.ToUniversalTime();
		}
		return default(DateTime);
	}

	public static DateTime ToDateTime(this XElement element, string format)
	{
		if (DateTime.TryParseExact(element.Value, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out var result))
		{
			return DateTime.SpecifyKind(result, DateTimeKind.Utc);
		}
		return default(DateTime);
	}

	public static TimeSpan ToTimeSpan(this XElement element)
	{
		if (!TimeSpan.TryParse(element.Value, out var result))
		{
			return default(TimeSpan);
		}
		return result;
	}

	public static Color ToColor(this XElement element)
	{
		if (string.IsNullOrEmpty(element.Value))
		{
			return Color.Empty;
		}
		int num = element.Value.IndexOf(',');
		int num2 = element.Value.IndexOf(',', num + 1);
		int num3 = element.Value.IndexOf(',', num2 + 1);
		return Color.FromArgb(int.Parse(element.Value.Substring(num3 + 1, element.Value.Length - num3 - 1)), int.Parse(element.Value.Substring(0, num)), int.Parse(element.Value.Substring(num + 1, num2 - num - 1)), int.Parse(element.Value.Substring(num2 + 1, num3 - num2 - 1)));
	}

	public static XElement ToXElement(this Color color, string nodeName = "Color")
	{
		XName? name = nodeName;
		string content;
		if (!color.IsEmpty)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 4);
			defaultInterpolatedStringHandler.AppendFormatted(color.R);
			defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂녤());
			defaultInterpolatedStringHandler.AppendFormatted(color.G);
			defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂녤());
			defaultInterpolatedStringHandler.AppendFormatted(color.B);
			defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂녤());
			defaultInterpolatedStringHandler.AppendFormatted(color.A);
			content = defaultInterpolatedStringHandler.ToStringAndClear();
		}
		else
		{
			content = string.Empty;
		}
		return new XElement(name, content);
	}

	public static Font ToFont(this XElement element)
	{
		if (string.IsNullOrEmpty(element.Value))
		{
			return null;
		}
		int num = element.Value.IndexOf(',');
		int num2 = element.Value.IndexOf(',', num + 1);
		int num3 = element.Value.IndexOf(',', num2 + 1);
		float.TryParse(element.Value.Substring(num + 1, num2 - num - 1), NumberStyles.Float, CultureInfo.InvariantCulture, out var result);
		return new Font(element.Value.Substring(0, num), result, (FontStyle)int.Parse(element.Value.Substring(num2 + 1, num3 - num2 - 1)), (GraphicsUnit)int.Parse(element.Value.Substring(num3 + 1, element.Value.Length - num3 - 1)));
	}

	public static XElement ToXElement(this Font font, string nodeName = "Font")
	{
		XName? name = nodeName;
		string content;
		if (font != null)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 4);
			defaultInterpolatedStringHandler.AppendFormatted(font.Name);
			defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂녤());
			defaultInterpolatedStringHandler.AppendFormatted(font.Size.ToString(CultureInfo.InvariantCulture));
			defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂녤());
			defaultInterpolatedStringHandler.AppendFormatted((int)font.Style);
			defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂녤());
			defaultInterpolatedStringHandler.AppendFormatted((int)font.Unit);
			content = defaultInterpolatedStringHandler.ToStringAndClear();
		}
		else
		{
			content = string.Empty;
		}
		return new XElement(name, content);
	}
}
