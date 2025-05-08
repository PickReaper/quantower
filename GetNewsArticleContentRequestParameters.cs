using System;
using System.Runtime.CompilerServices;

namespace TradingPlatform.BusinessLayer;

public sealed class GetNewsArticleContentRequestParameters : RequestParameters
{
	[CompilerGenerated]
	private string 녶논;

	public override RequestType Type
	{
		get
		{
			throw new NotImplementedException();
		}
	}

	public string ArticleId
	{
		[CompilerGenerated]
		get
		{
			return 녶논;
		}
		[CompilerGenerated]
		set
		{
			녶논 = value;
		}
	}

	public GetNewsArticleContentRequestParameters()
	{
	}

	public GetNewsArticleContentRequestParameters(GetNewsArticleContentRequestParameters original)
		: base(original)
	{
		ArticleId = original.ArticleId;
	}
}
