using System;
using System.Runtime.CompilerServices;
using TradingPlatform.BusinessLayer.Integration;

namespace TradingPlatform.BusinessLayer;

public class ConnectionStateChangedEventArgs : EventArgs
{
	[CompilerGenerated]
	private ConnectionState 놯;

	[CompilerGenerated]
	private ConnectionState 녾;

	[CompilerGenerated]
	private ConnectionResult 녬;

	public ConnectionState PreviousState
	{
		[CompilerGenerated]
		get
		{
			return 놯;
		}
		[CompilerGenerated]
		private set
		{
			놯 = value;
		}
	}

	public ConnectionState NewState
	{
		[CompilerGenerated]
		get
		{
			return 녾;
		}
		[CompilerGenerated]
		private set
		{
			녾 = value;
		}
	}

	public ConnectionResult LastConnectionResult
	{
		[CompilerGenerated]
		get
		{
			return 녬;
		}
		[CompilerGenerated]
		private set
		{
			녬 = value;
		}
	}

	internal ConnectionStateChangedEventArgs(ConnectionState P_0, ConnectionState P_1, ConnectionResult P_2)
	{
		PreviousState = P_0;
		NewState = P_1;
		LastConnectionResult = P_2;
	}
}
