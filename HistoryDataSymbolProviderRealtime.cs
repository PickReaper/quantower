using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;

namespace TradingPlatform.BusinessLayer;

public sealed class HistoryDataSymbolProviderRealtime : IHistoryDataProvider, IDisposable
{
	private const int 놫뇋 = 10000;

	[CompilerGenerated]
	private Action<string> 놫놸;

	[CompilerGenerated]
	private string 놫놿;

	private DateTime 놫놄;

	private DateTime 놫놰;

	private readonly HistoricalData 놫놓;

	private readonly HistoryRequestParameters 놫놇;

	private readonly ManualResetEventSlim 놫뇅;

	public bool AllDataAlreadyProvided
	{
		get
		{
			if (!(놫놰 >= 놫놇.ToTime))
			{
				return Core.Instance.TimeUtils.DateTimeUtcNow - 놫놇.Symbol.QuoteDelay - TimeSpan.FromSeconds(10.0) > 놫놇.ToTime;
			}
			return true;
		}
	}

	public string ProgressValue
	{
		[CompilerGenerated]
		get
		{
			return 놫놿;
		}
		[CompilerGenerated]
		private set
		{
			놫놿 = value;
		}
	}

	public event Action<string> ProgressChanged
	{
		[CompilerGenerated]
		add
		{
			Action<string> action = 놫놸;
			Action<string> action2;
			do
			{
				action2 = action;
				Action<string> value2 = (Action<string>)Delegate.Combine(action2, value);
				action = Interlocked.CompareExchange(ref 놫놸, value2, action2);
			}
			while ((object)action != action2);
		}
		[CompilerGenerated]
		remove
		{
			Action<string> action = 놫놸;
			Action<string> action2;
			do
			{
				action2 = action;
				Action<string> value2 = (Action<string>)Delegate.Remove(action2, value);
				action = Interlocked.CompareExchange(ref 놫놸, value2, action2);
			}
			while ((object)action != action2);
		}
	}

	public HistoryDataSymbolProviderRealtime(HistoryRequestParameters historyRequestParameters)
	{
		놫놇 = historyRequestParameters;
		HistoryRequestParameters historyRequestParameters2 = new HistoryRequestParameters(놫놇)
		{
			ToTime = default(DateTime)
		};
		놫뇅 = new ManualResetEventSlim();
		놫놓 = 놫놇.Symbol.GetHistory(historyRequestParameters2);
		놫놓.NewHistoryItem += 녴;
	}

	public void Dispose()
	{
		놫뇅.Dispose();
		놫놓.NewHistoryItem -= 녴;
		놫놓.Dispose();
	}

	public HistoryHolder GetHistory(CancellationToken cancellationToken)
	{
		if (놫놇.Symbol == null)
		{
			return null;
		}
		if (놫놇.Symbol.State == BusinessObjectState.Fake)
		{
			return null;
		}
		TimeSpan timeout = 놫놇.ToTime - Core.Instance.TimeUtils.DateTimeUtcNow + 놫놇.Symbol.QuoteDelay + TimeSpan.FromSeconds(10.0);
		놫뇅.Wait(timeout, cancellationToken);
		놫뇅.Reset();
		if (놫놓.Count == 0)
		{
			return null;
		}
		List<IHistoryItem> list = new List<IHistoryItem>();
		HistoryRequestParameters historyRequestParameters = new HistoryRequestParameters(놫놇);
		int i;
		for (i = 0; i < 10000 && i < 놫놓.Count; i++)
		{
			IHistoryItem historyItem = 놫놓[i, SeekOriginHistory.Begin];
			놫놰 = historyItem.TimeLeft;
			if (historyItem.TimeLeft >= 놫놇.ToTime)
			{
				break;
			}
			if (historyItem.TimeLeft >= 놫놇.FromTime)
			{
				list.Add(historyItem);
			}
		}
		if (!list.Any())
		{
			return null;
		}
		historyRequestParameters.FromTime = list.First().TimeLeft;
		historyRequestParameters.ToTime = new DateTime(list.Last().TicksRight + 1, DateTimeKind.Utc);
		놫놓.CutItems(i);
		return new HistoryHolder(list, historyRequestParameters);
	}

	private void 녴(object P_0, HistoryEventArgs P_1)
	{
		놫놄 = P_1.HistoryItem.TimeLeft;
		if (놫놄 < 놫놇.FromTime)
		{
			if (놫놓.Count > 10000)
			{
				놫놓.CutItems(10000);
			}
			ProgressValue = _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶놜();
			놫놸?.Invoke(ProgressValue);
			return;
		}
		if (놫놓.Count >= 10000)
		{
			놫뇅.Set();
			return;
		}
		if (놫놄 >= 놫놇.ToTime)
		{
			놫뇅.Set();
			return;
		}
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(25, 2);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶놨());
		defaultInterpolatedStringHandler.AppendFormatted(놫놓.Count((IHistoryItem P_0) => P_0.TicksLeft > 놫놇.FromTime.Ticks));
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶녢());
		defaultInterpolatedStringHandler.AppendFormatted(10000);
		ProgressValue = defaultInterpolatedStringHandler.ToStringAndClear();
		놫놸?.Invoke(ProgressValue);
	}

	[CompilerGenerated]
	private bool 녴(IHistoryItem P_0)
	{
		return P_0.TicksLeft > 놫놇.FromTime.Ticks;
	}
}
