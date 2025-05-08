using System;
using System.Globalization;
using System.Linq;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using TradingPlatform.BusinessLayer.Integration;

namespace TradingPlatform.BusinessLayer;

public sealed class HistoryAggregationLevel2 : HistoryAggregation
{
	public override string Name => _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿녵();

	[NotPublished]
	public override Period GetPeriod => Period.TICK1;

	[NotPublished]
	public override HistoryType GetHistoryType
	{
		get
		{
			throw new Exception(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸놤());
		}
	}

	public HistoryAggregationLevel2()
	{
	}

	public override string FormatTime(DateTime dt)
	{
		return dt.ToString(DateTimeFormatInfo.CurrentInfo.ShortDatePattern + _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭녤());
	}

	private HistoryAggregationLevel2(HistoryAggregationLevel2 P_0)
		: base(P_0)
	{
	}

	[NotPublished]
	public override object Clone()
	{
		return new HistoryAggregationLevel2(this);
	}

	public override HistoryAggregation GetAggregationToDirectDownload(HistoryMetadata metadata)
	{
		if (!metadata.AllowedAggregations.Contains(Name))
		{
			return null;
		}
		return this;
	}
}
