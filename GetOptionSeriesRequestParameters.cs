using System;
using System.Runtime.CompilerServices;
using ProtoBuf;

namespace TradingPlatform.BusinessLayer;

[ProtoContract]
public class GetOptionSeriesRequestParameters : CachedRequestParameters
{
	[CompilerGenerated]
	private string 놵놿;

	[CompilerGenerated]
	private string 놵놄;

	[CompilerGenerated]
	private string 놵놰;

	public override RequestType Type => RequestType.OptionSeries;

	public string ConnectionId
	{
		[CompilerGenerated]
		get
		{
			return 놵놿;
		}
		[CompilerGenerated]
		set
		{
			놵놿 = value;
		}
	}

	[ProtoMember(1)]
	public string UnderlierId
	{
		[CompilerGenerated]
		get
		{
			return 놵놄;
		}
		[CompilerGenerated]
		set
		{
			놵놄 = value;
		}
	}

	[ProtoMember(2)]
	public string ExchangeId
	{
		[CompilerGenerated]
		get
		{
			return 놵놰;
		}
		[CompilerGenerated]
		set
		{
			놵놰 = value;
		}
	}

	public GetOptionSeriesRequestParameters()
	{
	}

	public GetOptionSeriesRequestParameters(GetOptionSeriesRequestParameters origin)
		: base(origin)
	{
		ConnectionId = origin.ConnectionId;
		UnderlierId = origin.UnderlierId;
		ExchangeId = origin.ExchangeId;
	}

	internal GetOptionSeriesRequestParameters(Symbol P_0)
	{
		ConnectionId = P_0.ConnectionId;
		UnderlierId = P_0.Id;
		ExchangeId = P_0.ExchangeId;
	}

	public override int GetCacheKey()
	{
		HashCode hashCode = default(HashCode);
		if (UnderlierId != null)
		{
			hashCode.Add(UnderlierId);
		}
		if (ExchangeId != null)
		{
			hashCode.Add(ExchangeId);
		}
		return hashCode.ToHashCode();
	}
}
