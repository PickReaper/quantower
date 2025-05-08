using System.Runtime.CompilerServices;

namespace TradingPlatform.BusinessLayer;

public class ConnectionDependency
{
	[CompilerGenerated]
	private ConnectionDependencyBehavior 녚;

	private string[] 녳;

	public static ConnectionDependency NoDependency => new ConnectionDependency
	{
		Behavior = ConnectionDependencyBehavior.NoDependency
	};

	public static ConnectionDependency TotalDependency => new ConnectionDependency
	{
		Behavior = ConnectionDependencyBehavior.TotalDependency
	};

	public ConnectionDependencyBehavior Behavior
	{
		[CompilerGenerated]
		get
		{
			return 녚;
		}
		[CompilerGenerated]
		set
		{
			녚 = value;
		}
	}

	public string[] DependentConnectionsIds
	{
		get
		{
			return 녳;
		}
		set
		{
			녳 = value ?? new string[0];
		}
	}
}
