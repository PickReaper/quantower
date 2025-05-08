using System.Runtime.CompilerServices;

namespace TradingPlatform.BusinessLayer;

[Published]
public class ReportRequestParameters : ProgressRequestParameters<float>
{
	[CompilerGenerated]
	private ReportType 놴놾;

	public override RequestType Type => RequestType.Report;

	public ReportType ReportType
	{
		[CompilerGenerated]
		get
		{
			return 놴놾;
		}
		[CompilerGenerated]
		set
		{
			놴놾 = value;
		}
	}

	public ReportRequestParameters()
	{
	}

	public ReportRequestParameters(ReportRequestParameters origin)
		: base((ProgressRequestParameters<float>)origin)
	{
		ReportType = origin.ReportType.녴();
	}
}
