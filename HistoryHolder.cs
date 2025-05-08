using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TradingPlatform.BusinessLayer.History.Storage;

namespace TradingPlatform.BusinessLayer;

public class HistoryHolder
{
	[CompilerGenerated]
	private readonly IList<IHistoryItem> 뇉;

	[CompilerGenerated]
	private readonly HistoryRequestParameters 뇍;

	[CompilerGenerated]
	private int 놙;

	public IList<IHistoryItem> History
	{
		[CompilerGenerated]
		get
		{
			return 뇉;
		}
	}

	public HistoryRequestParameters RequestParameters
	{
		[CompilerGenerated]
		get
		{
			return 뇍;
		}
	}

	public int ProgressPercent
	{
		[CompilerGenerated]
		get
		{
			return 놙;
		}
		[CompilerGenerated]
		private set
		{
			놙 = value;
		}
	}

	public HistoryHolder(IList<IHistoryItem> history, HistoryRequestParameters requestParameters, int progressPercent = 100)
	{
		뇉 = history;
		뇍 = requestParameters;
		ProgressPercent = progressPercent;
	}

	public HistoryInterval ToHistoryInterval()
	{
		return new HistoryInterval
		{
			Description = RequestParameters.ToDescription(),
			Interval = RequestParameters.Interval,
			History = History
		};
	}
}
