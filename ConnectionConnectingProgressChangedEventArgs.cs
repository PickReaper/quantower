using System.Runtime.CompilerServices;

namespace TradingPlatform.BusinessLayer;

public class ConnectionConnectingProgressChangedEventArgs
{
	[CompilerGenerated]
	private string 놐;

	public string Progress
	{
		[CompilerGenerated]
		get
		{
			return 놐;
		}
		[CompilerGenerated]
		private set
		{
			놐 = value;
		}
	}

	internal ConnectionConnectingProgressChangedEventArgs(string P_0)
	{
		Progress = P_0;
	}
}
