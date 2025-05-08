using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using TradingPlatform.BusinessLayer.Utils;

namespace TradingPlatform.BusinessLayer;

public sealed class HistoryDataSymbolProvider : IHistoryDataProvider
{
	[CompilerGenerated]
	private Action<string> 놫녪;

	private readonly Symbol 놫녶;

	private readonly HistoryRequestParameters 놫녵;

	private readonly Interval<DateTime>[] 놫놭;

	private int 놫녲;

	public bool AllDataAlreadyProvided => 놫녲 >= 놫놭.Length;

	public string ProgressValue => ((float)놫녲 / (float)놫놭.Length).ToString(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶녗());

	public event Action<string> ProgressChanged
	{
		[CompilerGenerated]
		add
		{
			Action<string> action = 놫녪;
			Action<string> action2;
			do
			{
				action2 = action;
				Action<string> value2 = (Action<string>)Delegate.Combine(action2, value);
				action = Interlocked.CompareExchange(ref 놫녪, value2, action2);
			}
			while ((object)action != action2);
		}
		[CompilerGenerated]
		remove
		{
			Action<string> action = 놫녪;
			Action<string> action2;
			do
			{
				action2 = action;
				Action<string> value2 = (Action<string>)Delegate.Remove(action2, value);
				action = Interlocked.CompareExchange(ref 놫녪, value2, action2);
			}
			while ((object)action != action2);
		}
	}

	public HistoryDataSymbolProvider(Symbol realSymbolToImportHistory, HistoryRequestParameters historyRequestParameters)
	{
		놫녶 = realSymbolToImportHistory;
		놫녵 = historyRequestParameters;
		놫놭 = 놫녵.Interval.Split(놫녶.GetHistoryDownloadingStep(놫녵.Aggregation)).ToArray();
		놫녲 = 0;
	}

	public HistoryHolder GetHistory(CancellationToken cancellationToken)
	{
		Interval<DateTime> interval = 놫놭[놫녲];
		HistoryRequestParameters historyRequestParameters = new HistoryRequestParameters(놫녵)
		{
			Interval = interval,
			CancellationToken = cancellationToken
		};
		if (놫녶 == null)
		{
			return null;
		}
		HistoricalData history = 놫녶.GetHistory(historyRequestParameters);
		List<IHistoryItem> list = new List<IHistoryItem>();
		for (int i = 0; i < history.Count; i++)
		{
			list.Add(history[i, SeekOriginHistory.Begin]);
		}
		놫녲++;
		놫녪?.Invoke(ProgressValue);
		return new HistoryHolder(list, historyRequestParameters);
	}
}
