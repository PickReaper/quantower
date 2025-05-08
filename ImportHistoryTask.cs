using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;

namespace TradingPlatform.BusinessLayer;

public sealed class ImportHistoryTask : IHistoryProcessingTask, IDisposable
{
	[CompilerGenerated]
	private sealed class 녴
	{
		public CancellationToken 놄놤;

		public ImportHistoryTask 놄논;

		internal void 녴()
		{
			while (!놄논.놫놼.AllDataAlreadyProvided)
			{
				try
				{
					if (놄놤.IsCancellationRequested)
					{
						break;
					}
					HistoryHolder history = 놄논.놫놼.GetHistory(놄놤);
					if (놄놤.IsCancellationRequested || history == null)
					{
						break;
					}
					if (history.History.Any())
					{
						놄논.놫놗.SaveHistory(history);
						놄논.놫뇇 += history.History.Count;
						놄논.놫놃?.Invoke(놄논.ProgressValue);
					}
					continue;
				}
				catch (Exception ex)
				{
					Core.Instance.Loggers.Log(ex);
					놄논.Stop();
					return;
				}
			}
			놄논.TaskState = HistoryTaskStateEnum.Completed;
			놄논.놫놼.ProgressChanged -= 놄논.녴;
			(놄논.놫놼 as IDisposable)?.Dispose();
		}
	}

	[CompilerGenerated]
	private Action<HistoryTaskStateEnum> 놫놵;

	private HistoryTaskStateEnum 놫놡;

	[CompilerGenerated]
	private string 놫놻;

	[CompilerGenerated]
	private Action<string> 놫놃;

	private int 놫뇇;

	private string 놫놛;

	private readonly IHistoryDataProvider 놫놼;

	private readonly IHistoryDataReceiver 놫놗;

	private CancellationTokenSource 놫뇂;

	public HistoryTaskStateEnum TaskState
	{
		get
		{
			return 놫놡;
		}
		private set
		{
			if (놫놡 != HistoryTaskStateEnum.Completed)
			{
				놫놡 = value;
				switch (놫놡)
				{
				case HistoryTaskStateEnum.Active:
					녴();
					break;
				case HistoryTaskStateEnum.Stopped:
					놫뇂.Cancel();
					break;
				case HistoryTaskStateEnum.Completed:
					놫놛 = string.Empty;
					break;
				}
				놫놵?.Invoke(놫놡);
			}
		}
	}

	public string Description
	{
		[CompilerGenerated]
		get
		{
			return 놫놻;
		}
		[CompilerGenerated]
		set
		{
			놫놻 = value;
		}
	}

	public string ProgressValue
	{
		get
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(13, 1);
			defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶놞());
			defaultInterpolatedStringHandler.AppendFormatted(놫뇇);
			defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶놳());
			string text = defaultInterpolatedStringHandler.ToStringAndClear();
			if (string.IsNullOrEmpty(놫놛))
			{
				return text;
			}
			return text + _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂녹() + 놫놛;
		}
	}

	public event Action<HistoryTaskStateEnum> TaskStateChanged
	{
		[CompilerGenerated]
		add
		{
			Action<HistoryTaskStateEnum> action = 놫놵;
			Action<HistoryTaskStateEnum> action2;
			do
			{
				action2 = action;
				Action<HistoryTaskStateEnum> value2 = (Action<HistoryTaskStateEnum>)Delegate.Combine(action2, value);
				action = Interlocked.CompareExchange(ref 놫놵, value2, action2);
			}
			while ((object)action != action2);
		}
		[CompilerGenerated]
		remove
		{
			Action<HistoryTaskStateEnum> action = 놫놵;
			Action<HistoryTaskStateEnum> action2;
			do
			{
				action2 = action;
				Action<HistoryTaskStateEnum> value2 = (Action<HistoryTaskStateEnum>)Delegate.Remove(action2, value);
				action = Interlocked.CompareExchange(ref 놫놵, value2, action2);
			}
			while ((object)action != action2);
		}
	}

	public event Action<string> ProgressChanged
	{
		[CompilerGenerated]
		add
		{
			Action<string> action = 놫놃;
			Action<string> action2;
			do
			{
				action2 = action;
				Action<string> value2 = (Action<string>)Delegate.Combine(action2, value);
				action = Interlocked.CompareExchange(ref 놫놃, value2, action2);
			}
			while ((object)action != action2);
		}
		[CompilerGenerated]
		remove
		{
			Action<string> action = 놫놃;
			Action<string> action2;
			do
			{
				action2 = action;
				Action<string> value2 = (Action<string>)Delegate.Remove(action2, value);
				action = Interlocked.CompareExchange(ref 놫놃, value2, action2);
			}
			while ((object)action != action2);
		}
	}

	public ImportHistoryTask(IHistoryDataProvider historyDataProvider, IHistoryDataReceiver historyDataReceiver)
	{
		놫놼 = historyDataProvider;
		놫놗 = historyDataReceiver;
	}

	public void Dispose()
	{
		if (놫뇂 != null)
		{
			놫뇂.Cancel();
			놫뇂.Dispose();
			놫뇂 = null;
		}
	}

	public void Start()
	{
		TaskState = HistoryTaskStateEnum.Active;
	}

	public void Stop()
	{
		TaskState = HistoryTaskStateEnum.Stopped;
	}

	private void 녴()
	{
		놫뇂 = new CancellationTokenSource();
		CancellationToken 놄놤 = 놫뇂.Token;
		놫놼.ProgressChanged += 녴;
		놫뇇 = 0;
		놫놃?.Invoke(ProgressValue);
		Task.Factory.StartNew(delegate
		{
			while (!놫놼.AllDataAlreadyProvided)
			{
				try
				{
					if (!놄놤.IsCancellationRequested)
					{
						HistoryHolder history = 놫놼.GetHistory(놄놤);
						if (!놄놤.IsCancellationRequested && history != null)
						{
							if (history.History.Any())
							{
								놫놗.SaveHistory(history);
								놫뇇 += history.History.Count;
								놫놃?.Invoke(ProgressValue);
							}
							continue;
						}
					}
				}
				catch (Exception ex)
				{
					Core.Instance.Loggers.Log(ex);
					Stop();
					return;
				}
				break;
			}
			TaskState = HistoryTaskStateEnum.Completed;
			놫놼.ProgressChanged -= 녴;
			(놫놼 as IDisposable)?.Dispose();
		}, 놄놤);
	}

	private void 녴(string P_0)
	{
		놫놛 = P_0;
		놫놃?.Invoke(ProgressValue);
	}
}
