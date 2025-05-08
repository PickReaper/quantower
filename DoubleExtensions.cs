using System;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;

namespace TradingPlatform.BusinessLayer;

public static class DoubleExtensions
{
	private const string 놴녖 = "#,0.##########";

	public static string Format(this double value, int precision = 2, bool abbreviate = false)
	{
		if (double.IsNaN(value))
		{
			return _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇅();
		}
		if (abbreviate)
		{
			return value.녴(precision);
		}
		double num = ((value == -0.0) ? Math.Abs(value) : value);
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놗());
		defaultInterpolatedStringHandler.AppendFormatted(precision);
		return num.ToString(defaultInterpolatedStringHandler.ToStringAndClear());
	}

	private static string 녴(this double P_0, int P_1)
	{
		string value = _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놇();
		if (Math.Abs(P_0) >= 1000000000000.0)
		{
			P_0 /= 1000000000000.0;
			value = _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂뇂();
		}
		else if (Math.Abs(P_0) >= 1000000000.0)
		{
			P_0 /= 1000000000.0;
			value = _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놩();
		}
		else if (Math.Abs(P_0) >= 1000000.0)
		{
			P_0 /= 1000000.0;
			value = _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂녡();
		}
		else if (Math.Abs(P_0) >= 1000.0)
		{
			P_0 /= 1000.0;
			value = _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂녦();
		}
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
		if (!string.IsNullOrEmpty(value))
		{
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted(P_0.놴(1));
			defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놀());
			defaultInterpolatedStringHandler.AppendFormatted(value);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}
		defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놗());
		defaultInterpolatedStringHandler.AppendFormatted(P_1);
		return P_0.ToString(defaultInterpolatedStringHandler.ToStringAndClear());
	}

	private static double 놴(this double P_0, int P_1)
	{
		double num = Math.Pow(10.0, P_1);
		return Math.Truncate(P_0 * num) / num;
	}

	public static bool IsNanOrDefault(this double value)
	{
		if (value != 0.0)
		{
			return double.IsNaN(value);
		}
		return true;
	}

	public static string FormatPriceWithMaxPrecision(this double price, IFormatProvider formatProvider = null)
	{
		if (double.IsInfinity(price) || double.IsNaN(price))
		{
			price = 0.0;
		}
		if (formatProvider != null)
		{
			return price.ToString(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놔(), formatProvider);
		}
		return price.ToString(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놔());
	}

	public static string FormatPriceWithMaxPrecision(this double price, int precision)
	{
		if (double.IsInfinity(price) || double.IsNaN(price))
		{
			price = 0.0;
		}
		string text = _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놾();
		for (int i = 0; i < precision; i++)
		{
			text += _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂뇀();
		}
		for (int j = precision; j < 10; j++)
		{
			text += _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놽();
		}
		return price.ToString(text);
	}

	public static double RoundTo(this double value, int degree)
	{
		decimal num = (decimal)value;
		decimal num2 = (decimal)Math.Pow(10.0, degree);
		return (double)(num - num % num2);
	}
}
