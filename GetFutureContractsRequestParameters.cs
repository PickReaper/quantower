using System;
using System.Runtime.CompilerServices;
using ProtoBuf;

namespace TradingPlatform.BusinessLayer;

[ProtoContract]
public class GetFutureContractsRequestParameters : CachedRequestParameters
{
	[CompilerGenerated]
	private string 놵놫;

	[CompilerGenerated]
	private string 놵녪;

	[CompilerGenerated]
	private string 놵녶;

	[CompilerGenerated]
	private string 놵녵;

	public override RequestType Type => RequestType.FutureContracts;

	public string ConnectionId
	{
		[CompilerGenerated]
		get
		{
			return 놵놫;
		}
		[CompilerGenerated]
		set
		{
			놵놫 = value;
		}
	}

	[ProtoMember(1)]
	public string Root
	{
		[CompilerGenerated]
		get
		{
			return 놵녪;
		}
		[CompilerGenerated]
		set
		{
			놵녪 = value;
		}
	}

	[ProtoMember(2)]
	public string ExchangeId
	{
		[CompilerGenerated]
		get
		{
			return 놵녶;
		}
		[CompilerGenerated]
		set
		{
			놵녶 = value;
		}
	}

	[ProtoMember(3)]
	public string UnderlierId
	{
		[CompilerGenerated]
		get
		{
			return 놵녵;
		}
		[CompilerGenerated]
		set
		{
			놵녵 = value;
		}
	}

	public GetFutureContractsRequestParameters()
	{
	}

	public GetFutureContractsRequestParameters(GetFutureContractsRequestParameters origin)
		: base(origin)
	{
		ConnectionId = origin.ConnectionId;
		Root = origin.Root;
		ExchangeId = origin.ExchangeId;
		UnderlierId = origin.UnderlierId;
	}

	public override int GetCacheKey()
	{
		if (!string.IsNullOrEmpty(UnderlierId))
		{
			return UnderlierId.GetHashCode();
		}
		HashCode hashCode = default(HashCode);
		if (Root != null)
		{
			hashCode.Add(Root);
		}
		if (ExchangeId != null)
		{
			hashCode.Add(ExchangeId);
		}
		if (UnderlierId != null)
		{
			hashCode.Add(UnderlierId);
		}
		return hashCode.ToHashCode();
	}
}
