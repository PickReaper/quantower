using System;
using System.Linq;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;

namespace TradingPlatform.BusinessLayer;

public sealed class ConnectionStateObserver : IDisposable, IComparable<ConnectionStateObserver>
{
	private IConnectionStateDependent 녹;

	private readonly ConnectionStateObserverPriority 녔;

	private readonly ConnectionState[] 녠;

	public ConnectionStateObserver(IConnectionStateDependent dependencyObject, ConnectionStateObserverPriority priority = ConnectionStateObserverPriority.Normal, params ConnectionState[] monitoringStates)
	{
		녹 = dependencyObject;
		녔 = priority;
		녠 = monitoringStates;
		Core.Instance.Connections.녴(this);
	}

	internal void 녴(object P_0, ConnectionStateChangedEventArgs P_1)
	{
		if (!녠.Contains(P_1.NewState) || !(P_0 is Connection connection))
		{
			return;
		}
		try
		{
			ConnectionDependency connectionDependency = 녹?.GetConnectionStateDependency();
			if ((connectionDependency == null || connectionDependency.Behavior != 0) && ((connectionDependency != null && connectionDependency.Behavior == ConnectionDependencyBehavior.TotalDependency) || connectionDependency?.DependentConnectionsIds?.Contains(connection.Id) == true))
			{
				녹?.OnConnectionStateChanged(connection, P_1);
			}
		}
		catch (Exception ex)
		{
			Core.Instance.Loggers.Log(ex);
		}
	}

	public void Dispose()
	{
		Core.Instance.Connections.놴(this);
		녹 = null;
	}

	public int CompareTo(ConnectionStateObserver other)
	{
		return -1 * 녔.CompareTo(other.녔);
	}

	public override string ToString()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(4, 2);
		defaultInterpolatedStringHandler.AppendFormatted(녔);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇂());
		defaultInterpolatedStringHandler.AppendFormatted(녹);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}
}
