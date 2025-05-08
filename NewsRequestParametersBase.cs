using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace TradingPlatform.BusinessLayer;

public abstract class NewsRequestParametersBase : RequestParameters
{
	[CompilerGenerated]
	private IEnumerable<SettingItem> 녶녘;

	public IEnumerable<SettingItem> AdditionalParameters
	{
		[CompilerGenerated]
		get
		{
			return 녶녘;
		}
		[CompilerGenerated]
		set
		{
			녶녘 = value;
		}
	}

	public NewsRequestParametersBase()
	{
	}

	public NewsRequestParametersBase(NewsRequestParametersBase original)
		: base(original)
	{
		AdditionalParameters = original.AdditionalParameters;
	}
}
