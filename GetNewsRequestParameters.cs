using System;
using System.Runtime.CompilerServices;

namespace TradingPlatform.BusinessLayer;

public sealed class GetNewsRequestParameters : NewsRequestParametersBase
{
	[CompilerGenerated]
	private DateTime 놵녲;

	[CompilerGenerated]
	private DateTime 놵뇋;

	public override RequestType Type
	{
		get
		{
			throw new NotImplementedException();
		}
	}

	public DateTime From
	{
		[CompilerGenerated]
		get
		{
			return 놵녲;
		}
		[CompilerGenerated]
		set
		{
			놵녲 = value;
		}
	}

	public DateTime To
	{
		[CompilerGenerated]
		get
		{
			return 놵뇋;
		}
		[CompilerGenerated]
		set
		{
			놵뇋 = value;
		}
	}

	public GetNewsRequestParameters()
	{
	}

	public GetNewsRequestParameters(GetNewsRequestParameters original)
		: base(original)
	{
		From = original.From;
		To = original.To;
	}
}
