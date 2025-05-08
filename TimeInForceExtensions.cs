using System;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;

namespace TradingPlatform.BusinessLayer;

public static class TimeInForceExtensions
{
	public static string Format(this TimeInForce value, DateTime expiration = default(DateTime))
	{
		if (expiration == default(DateTime))
		{
			return value.ToString();
		}
		switch (value)
		{
		case TimeInForce.GTD:
			return value.ToString() + _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂녙() + Core.Instance.TimeUtils.ConvertFromUTCToSelectedTimeZone(expiration).ToShortDateString() + _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놢();
		case TimeInForce.GTT:
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 2);
			defaultInterpolatedStringHandler.AppendFormatted(value.ToString());
			defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂녙());
			defaultInterpolatedStringHandler.AppendFormatted(Core.Instance.TimeUtils.ConvertFromUTCToSelectedTimeZone(expiration), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂녧());
			defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놢());
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}
		default:
			return value.ToString();
		}
	}
}
