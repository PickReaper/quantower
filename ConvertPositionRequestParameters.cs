using System.Runtime.CompilerServices;

namespace TradingPlatform.BusinessLayer;

public class ConvertPositionRequestParameters : ClosePositionRequestParameters
{
	[CompilerGenerated]
	private string 놻뇊;

	public override RequestType Type => RequestType.ConvertPosition;

	public string ProductCode
	{
		[CompilerGenerated]
		get
		{
			return 놻뇊;
		}
		[CompilerGenerated]
		set
		{
			놻뇊 = value;
		}
	}
}
