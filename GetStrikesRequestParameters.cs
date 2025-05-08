using System;
using System.Runtime.CompilerServices;
using ProtoBuf;

namespace TradingPlatform.BusinessLayer;

[ProtoContract]
public class GetStrikesRequestParameters : CachedRequestParameters
{
	[CompilerGenerated]
	private string 놵놓;

	[CompilerGenerated]
	private string 놵놇;

	[CompilerGenerated]
	private string 놵뇅;

	[CompilerGenerated]
	private DateTime 놵놵;

	public override RequestType Type => RequestType.Strikes;

	public string ConnectionId
	{
		[CompilerGenerated]
		get
		{
			return 놵놓;
		}
		[CompilerGenerated]
		set
		{
			놵놓 = value;
		}
	}

	[ProtoMember(1)]
	public string UnderlierId
	{
		[CompilerGenerated]
		get
		{
			return 놵놇;
		}
		[CompilerGenerated]
		set
		{
			놵놇 = value;
		}
	}

	[ProtoMember(2)]
	public string SerieId
	{
		[CompilerGenerated]
		get
		{
			return 놵뇅;
		}
		[CompilerGenerated]
		set
		{
			놵뇅 = value;
		}
	}

	[ProtoMember(3)]
	public DateTime ExpirationDate
	{
		[CompilerGenerated]
		get
		{
			return 놵놵;
		}
		[CompilerGenerated]
		set
		{
			놵놵 = value;
		}
	}

	public GetStrikesRequestParameters()
	{
	}

	public GetStrikesRequestParameters(GetStrikesRequestParameters origin)
		: base(origin)
	{
		ConnectionId = origin.ConnectionId;
		UnderlierId = origin.UnderlierId;
		SerieId = origin.SerieId;
		ExpirationDate = origin.ExpirationDate;
	}

	internal GetStrikesRequestParameters(OptionSerie P_0)
	{
		ConnectionId = P_0.ConnectionId;
		UnderlierId = P_0.UnderlierId;
		SerieId = P_0.Id;
		ExpirationDate = P_0.ExpirationDate;
	}

	public override int GetCacheKey()
	{
		HashCode hashCode = default(HashCode);
		if (UnderlierId != null)
		{
			hashCode.Add(UnderlierId);
		}
		if (SerieId != null)
		{
			hashCode.Add(SerieId);
		}
		hashCode.Add(ExpirationDate);
		return hashCode.ToHashCode();
	}
}
