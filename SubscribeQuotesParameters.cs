using System.Runtime.CompilerServices;
using ProtoBuf;

namespace TradingPlatform.BusinessLayer;

/// <summary>
/// Defines quote parameters for subscribtion
/// </summary>
[ProtoContract]
public class SubscribeQuotesParameters : RequestParameters
{
	[CompilerGenerated]
	private string 녵녪;

	[CompilerGenerated]
	private SubscribeQuoteType 녵녶;

	public override RequestType Type => RequestType.QuoteSubscribe;

	/// <summary>
	/// Symbol Id
	/// </summary>
	[ProtoMember(1)]
	public string SymbolId
	{
		[CompilerGenerated]
		get
		{
			return 녵녪;
		}
		[CompilerGenerated]
		internal set
		{
			녵녪 = value;
		}
	}

	/// <summary>
	/// Quote type
	/// </summary>
	[ProtoMember(2)]
	public SubscribeQuoteType SubscribeType
	{
		[CompilerGenerated]
		get
		{
			return 녵녶;
		}
		[CompilerGenerated]
		internal set
		{
			녵녶 = value;
		}
	}

	/// <summary>
	/// SubscribeQuotesParameters constructor 
	/// </summary>
	public SubscribeQuotesParameters(string symbolId, SubscribeQuoteType subscribeQuoteType)
	{
		SymbolId = symbolId;
		SubscribeType = subscribeQuoteType;
	}

	internal SubscribeQuotesParameters()
	{
	}
}
