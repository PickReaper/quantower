using System;
using System.Runtime.CompilerServices;

namespace TradingPlatform.BusinessLayer;

public sealed class SubscribeNewsRequestParameters : NewsRequestParametersBase
{
	[CompilerGenerated]
	private string 놵놸;

	public override RequestType Type
	{
		get
		{
			throw new NotImplementedException();
		}
	}

	public string SubscribeId
	{
		[CompilerGenerated]
		get
		{
			return 놵놸;
		}
		[CompilerGenerated]
		set
		{
			놵놸 = value;
		}
	}

	public SubscribeNewsRequestParameters()
	{
	}

	public SubscribeNewsRequestParameters(SubscribeNewsRequestParameters original)
		: base(original)
	{
		SubscribeId = original.SubscribeId;
	}
}
