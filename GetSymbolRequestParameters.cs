using System.Runtime.CompilerServices;
using ProtoBuf;

namespace TradingPlatform.BusinessLayer;

[Published]
[ProtoContract]
public class GetSymbolRequestParameters : CachedRequestParameters
{
	[CompilerGenerated]
	private string 놵놭;

	public override RequestType Type => RequestType.Symbol;

	[ProtoMember(1)]
	public string SymbolId
	{
		[CompilerGenerated]
		get
		{
			return 놵놭;
		}
		[CompilerGenerated]
		set
		{
			놵놭 = value;
		}
	}

	public override int GetCacheKey()
	{
		return SymbolId.GetHashCode();
	}

	public GetSymbolRequestParameters()
	{
	}

	public GetSymbolRequestParameters(GetSymbolRequestParameters origin)
		: base(origin)
	{
		SymbolId = origin.SymbolId;
	}
}
