using System.Threading.Tasks;

namespace TradingPlatform.BusinessLayer;

public static class TaskExtensions
{
	public static void GetResultWithoutContextCapturing(this Task task)
	{
		task.ConfigureAwait(continueOnCapturedContext: false).GetAwaiter().GetResult();
	}

	public static T GetResultWithoutContextCapturing<T>(this Task<T> task)
	{
		return task.ConfigureAwait(continueOnCapturedContext: false).GetAwaiter().GetResult();
	}
}
