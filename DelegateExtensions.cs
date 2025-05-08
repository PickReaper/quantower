using System;

namespace TradingPlatform.BusinessLayer;

public static class DelegateExtensions
{
	public static void InvokeSafely(this Delegate @delegate, params object[] args)
	{
		if ((object)@delegate == null)
		{
			return;
		}
		Delegate[] invocationList = @delegate.GetInvocationList();
		foreach (Delegate delegate2 in invocationList)
		{
			try
			{
				delegate2.DynamicInvoke(args);
			}
			catch (Exception ex)
			{
				Core.Instance.Loggers.Log(ex);
			}
		}
	}
}
