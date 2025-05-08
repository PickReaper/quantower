using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using ProtoBuf;

namespace TradingPlatform.BusinessLayer;

[ProtoContract]
public class SearchSymbolsRequestParameters : CachedRequestParameters
{
	[CompilerGenerated]
	private string 놵놡;

	[CompilerGenerated]
	private string 놵놻;

	[CompilerGenerated]
	private IList<string> 놵놃 = new List<string>();

	[CompilerGenerated]
	private IList<SymbolType> 놵뇇 = new List<SymbolType>();

	[CompilerGenerated]
	private Func<string, string> 놵놛;

	public override RequestType Type => RequestType.SearchSymbol;

	public string ConnectionId
	{
		[CompilerGenerated]
		get
		{
			return 놵놡;
		}
		[CompilerGenerated]
		set
		{
			놵놡 = value;
		}
	}

	[ProtoMember(1)]
	public string FilterName
	{
		[CompilerGenerated]
		get
		{
			return 놵놻;
		}
		[CompilerGenerated]
		set
		{
			놵놻 = value;
		}
	}

	[ProtoMember(2)]
	public IList<string> ExchangeIds
	{
		[CompilerGenerated]
		get
		{
			return 놵놃;
		}
		[CompilerGenerated]
		set
		{
			놵놃 = value;
		}
	}

	[ProtoMember(3)]
	public IList<SymbolType> SymbolTypes
	{
		[CompilerGenerated]
		get
		{
			return 놵뇇;
		}
		[CompilerGenerated]
		set
		{
			놵뇇 = value;
		}
	}

	public Func<string, string> GetSynonyms
	{
		[CompilerGenerated]
		get
		{
			return 놵놛;
		}
		[CompilerGenerated]
		set
		{
			놵놛 = value;
		}
	}

	public SearchSymbolsRequestParameters()
	{
	}

	public SearchSymbolsRequestParameters(SearchSymbolsRequestParameters origin)
		: base(origin)
	{
		ConnectionId = origin.ConnectionId;
		FilterName = origin.FilterName;
		ExchangeIds = new List<string>(origin.ExchangeIds);
		SymbolTypes = new List<SymbolType>(origin.SymbolTypes);
		GetSynonyms = origin.GetSynonyms;
	}

	public override int GetCacheKey()
	{
		HashCode hashCode = default(HashCode);
		hashCode.Add(FilterName ?? string.Empty);
		hashCode.Add(((IStructuralEquatable)ExchangeIds.ToArray()).GetHashCode((IEqualityComparer)EqualityComparer<string>.Default));
		hashCode.Add(((IStructuralEquatable)SymbolTypes.Cast<int>().ToArray()).GetHashCode((IEqualityComparer)EqualityComparer<int>.Default));
		return hashCode.ToHashCode();
	}
}
