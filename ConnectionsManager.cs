using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using TradingPlatform.BusinessLayer.Integration;
using 녴;

namespace TradingPlatform.BusinessLayer;

public sealed class ConnectionsManager : ICustomizable, IDisposable
{
	[Serializable]
	[CompilerGenerated]
	private sealed class 녴
	{
		public static readonly 녴 놓놖 = new 녴();

		public static Func<Connection, bool> 놓놝;

		public static Func<VendorInfo, IEnumerable<ConnectionInfo>> 놓뇄;

		public static Func<ConnectionInfo, bool> 놓녑;

		internal bool 녴(Connection P_0)
		{
			return P_0.Connected;
		}

		internal IEnumerable<ConnectionInfo> 녴(VendorInfo P_0)
		{
			return P_0.DefaultConnections;
		}

		internal bool 녴(ConnectionInfo P_0)
		{
			return P_0.AllowCreateCustomConnections;
		}
	}

	[CompilerGenerated]
	private sealed class 놴
	{
		public string 놓놈;

		public string 놓놬;

		internal bool 녴(ConnectionInfo P_0)
		{
			if (P_0.CreationType == ConnectionCreationType.Default && P_0.VendorName == 놓놈)
			{
				return P_0.Group == 놓놬;
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class 놂
	{
		public ConnectionInfo 놓놊;

		internal bool 녴(ConnectionInfo P_0)
		{
			if (P_0.CreationType == ConnectionCreationType.Default && P_0.VendorName == 놓놊.VendorName)
			{
				return P_0.Group == 놓놊.Group;
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class 놎
	{
		public 놭 놓놪;

		public ConnectionsManager 놓놌;

		internal void 녴()
		{
			놓놌.놂(놓놪.Connection);
		}

		internal Task 녴(Task t)
		{
			return 놓놪.CurrentTask = null;
		}
	}

	private const int 녪녜 = 10000;

	private readonly 뇇<string, Connection> 녪뇃;

	private readonly object 녪녯;

	private readonly 뇇<string, ConnectionInfo> 녪놮;

	private Timer 녪녫;

	[CompilerGenerated]
	private Action<Connection> 녪뇁;

	[CompilerGenerated]
	private Action<Connection> 녪놧;

	[CompilerGenerated]
	private EventHandler<ConnectionStateChangedEventArgs> 녪녝;

	[CompilerGenerated]
	private EventHandler<ConnectionConnectingProgressChangedEventArgs> 녪뇈;

	[CompilerGenerated]
	private Action 녪놑;

	[CompilerGenerated]
	private Action<ConnectionInfo> 녪놦;

	[CompilerGenerated]
	private Action<ConnectionInfo> 녪놐;

	[CompilerGenerated]
	private Action<ConnectionInfo> 녪녚;

	private bool 녪녳;

	private readonly List<ConnectionStateObserver> 녪놉;

	private readonly object 녪놥;

	private readonly Dictionary<string, 놭> 녪놯;

	private int 녪녾;

	internal static readonly 놀 녪녬 = new 놀();

	public Connection[] All => 녪뇃.Values.ToArray();

	public Connection[] Connected => (from P_0 in 녪뇃.Values.ToList()
		where P_0.Connected
		select P_0).ToArray();

	public ConnectionInfo[] ConnectionsInfo => 녪놮.Values.ToArray();

	public Connection this[string id]
	{
		get
		{
			if (string.IsNullOrEmpty(id))
			{
				return null;
			}
			return 녪뇃[id];
		}
	}

	public IList<SettingItem> Settings
	{
		get
		{
			List<SettingItem> list = new List<SettingItem>();
			ConnectionInfo[] connectionsInfo = Core.Instance.Connections.ConnectionsInfo;
			foreach (ConnectionInfo connectionInfo in connectionsInfo)
			{
				try
				{
					list.Add(new SettingItemGroup(connectionInfo.Name, connectionInfo.Settings));
				}
				catch (Exception ex)
				{
					Core.Instance.Loggers.Log(ex, connectionInfo.Name);
				}
			}
			return list;
		}
		set
		{
			foreach (SettingItem item in value)
			{
				녪녬.녴(item);
				ConnectionInfo connectionInfo = new ConnectionInfo(item.Name)
				{
					Settings = (item.Value as IList<SettingItem>)
				};
				if (connectionInfo.VendorInfo != null)
				{
					AddConnectionInfo(connectionInfo);
				}
			}
		}
	}

	public event Action<Connection> ConnectionAdded
	{
		[CompilerGenerated]
		add
		{
			Action<Connection> action = 녪뇁;
			Action<Connection> action2;
			do
			{
				action2 = action;
				Action<Connection> value2 = (Action<Connection>)Delegate.Combine(action2, value);
				action = Interlocked.CompareExchange(ref 녪뇁, value2, action2);
			}
			while ((object)action != action2);
		}
		[CompilerGenerated]
		remove
		{
			Action<Connection> action = 녪뇁;
			Action<Connection> action2;
			do
			{
				action2 = action;
				Action<Connection> value2 = (Action<Connection>)Delegate.Remove(action2, value);
				action = Interlocked.CompareExchange(ref 녪뇁, value2, action2);
			}
			while ((object)action != action2);
		}
	}

	public event Action<Connection> ConnectionRemoved
	{
		[CompilerGenerated]
		add
		{
			Action<Connection> action = 녪놧;
			Action<Connection> action2;
			do
			{
				action2 = action;
				Action<Connection> value2 = (Action<Connection>)Delegate.Combine(action2, value);
				action = Interlocked.CompareExchange(ref 녪놧, value2, action2);
			}
			while ((object)action != action2);
		}
		[CompilerGenerated]
		remove
		{
			Action<Connection> action = 녪놧;
			Action<Connection> action2;
			do
			{
				action2 = action;
				Action<Connection> value2 = (Action<Connection>)Delegate.Remove(action2, value);
				action = Interlocked.CompareExchange(ref 녪놧, value2, action2);
			}
			while ((object)action != action2);
		}
	}

	public event EventHandler<ConnectionStateChangedEventArgs> ConnectionStateChanged
	{
		[CompilerGenerated]
		add
		{
			EventHandler<ConnectionStateChangedEventArgs> eventHandler = 녪녝;
			EventHandler<ConnectionStateChangedEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<ConnectionStateChangedEventArgs> value2 = (EventHandler<ConnectionStateChangedEventArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref 녪녝, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<ConnectionStateChangedEventArgs> eventHandler = 녪녝;
			EventHandler<ConnectionStateChangedEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<ConnectionStateChangedEventArgs> value2 = (EventHandler<ConnectionStateChangedEventArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref 녪녝, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler<ConnectionConnectingProgressChangedEventArgs> ConnectionConnectingProgressChanged
	{
		[CompilerGenerated]
		add
		{
			EventHandler<ConnectionConnectingProgressChangedEventArgs> eventHandler = 녪뇈;
			EventHandler<ConnectionConnectingProgressChangedEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<ConnectionConnectingProgressChangedEventArgs> value2 = (EventHandler<ConnectionConnectingProgressChangedEventArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref 녪뇈, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<ConnectionConnectingProgressChangedEventArgs> eventHandler = 녪뇈;
			EventHandler<ConnectionConnectingProgressChangedEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<ConnectionConnectingProgressChangedEventArgs> value2 = (EventHandler<ConnectionConnectingProgressChangedEventArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref 녪뇈, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event Action PingUpdated
	{
		[CompilerGenerated]
		add
		{
			Action action = 녪놑;
			Action action2;
			do
			{
				action2 = action;
				Action value2 = (Action)Delegate.Combine(action2, value);
				action = Interlocked.CompareExchange(ref 녪놑, value2, action2);
			}
			while ((object)action != action2);
		}
		[CompilerGenerated]
		remove
		{
			Action action = 녪놑;
			Action action2;
			do
			{
				action2 = action;
				Action value2 = (Action)Delegate.Remove(action2, value);
				action = Interlocked.CompareExchange(ref 녪놑, value2, action2);
			}
			while ((object)action != action2);
		}
	}

	public event Action<ConnectionInfo> ConnectionInfoAdded
	{
		[CompilerGenerated]
		add
		{
			Action<ConnectionInfo> action = 녪놦;
			Action<ConnectionInfo> action2;
			do
			{
				action2 = action;
				Action<ConnectionInfo> value2 = (Action<ConnectionInfo>)Delegate.Combine(action2, value);
				action = Interlocked.CompareExchange(ref 녪놦, value2, action2);
			}
			while ((object)action != action2);
		}
		[CompilerGenerated]
		remove
		{
			Action<ConnectionInfo> action = 녪놦;
			Action<ConnectionInfo> action2;
			do
			{
				action2 = action;
				Action<ConnectionInfo> value2 = (Action<ConnectionInfo>)Delegate.Remove(action2, value);
				action = Interlocked.CompareExchange(ref 녪놦, value2, action2);
			}
			while ((object)action != action2);
		}
	}

	public event Action<ConnectionInfo> ConnectionInfoRemoved
	{
		[CompilerGenerated]
		add
		{
			Action<ConnectionInfo> action = 녪놐;
			Action<ConnectionInfo> action2;
			do
			{
				action2 = action;
				Action<ConnectionInfo> value2 = (Action<ConnectionInfo>)Delegate.Combine(action2, value);
				action = Interlocked.CompareExchange(ref 녪놐, value2, action2);
			}
			while ((object)action != action2);
		}
		[CompilerGenerated]
		remove
		{
			Action<ConnectionInfo> action = 녪놐;
			Action<ConnectionInfo> action2;
			do
			{
				action2 = action;
				Action<ConnectionInfo> value2 = (Action<ConnectionInfo>)Delegate.Remove(action2, value);
				action = Interlocked.CompareExchange(ref 녪놐, value2, action2);
			}
			while ((object)action != action2);
		}
	}

	public event Action<ConnectionInfo> ConnectionInfoRenamed
	{
		[CompilerGenerated]
		add
		{
			Action<ConnectionInfo> action = 녪녚;
			Action<ConnectionInfo> action2;
			do
			{
				action2 = action;
				Action<ConnectionInfo> value2 = (Action<ConnectionInfo>)Delegate.Combine(action2, value);
				action = Interlocked.CompareExchange(ref 녪녚, value2, action2);
			}
			while ((object)action != action2);
		}
		[CompilerGenerated]
		remove
		{
			Action<ConnectionInfo> action = 녪녚;
			Action<ConnectionInfo> action2;
			do
			{
				action2 = action;
				Action<ConnectionInfo> value2 = (Action<ConnectionInfo>)Delegate.Remove(action2, value);
				action = Interlocked.CompareExchange(ref 녪녚, value2, action2);
			}
			while ((object)action != action2);
		}
	}

	public ConnectionsManager()
	{
		녪뇃 = 뇇<string, Connection>.놂();
		녪놮 = new 뇇<string, ConnectionInfo>();
		녪놯 = new Dictionary<string, 놭>();
		녪녯 = new object();
		녪놉 = new List<ConnectionStateObserver>();
		녪놥 = new object();
	}

	internal ConnectionsManager(List<Connection> P_0)
		: this()
	{
		foreach (Connection item in P_0)
		{
			녪뇃.녴(item.Id, item);
		}
	}

	public void Initialize()
	{
		Core.Instance.Loggers.Log(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵녓(), LoggingLevel.Verbose);
		foreach (ConnectionInfo item in Core.Instance.Vendors.Vendors.SelectMany((VendorInfo P_0) => P_0.DefaultConnections))
		{
			녪놮[item.ConnectionId] = item;
		}
		녴();
		Core.Instance.녴(놂);
		Core.Instance.Loggers.Log(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵녛(), LoggingLevel.Verbose);
	}

	public Connection CreateConnection(ConnectionInfo info)
	{
		lock (녪녯)
		{
			if (녪뇃.녴(info.ConnectionId, out var result))
			{
				return result;
			}
			result = new Connection(info);
			녪뇃.녴(result.Id, result);
			녴(result);
			return result;
		}
	}

	public void RemoveConnection(Connection connection)
	{
		if (connection == null)
		{
			return;
		}
		lock (녪녯)
		{
			녪놯.Remove(connection.Id);
			if (녪뇃.놴(connection.Id))
			{
				connection.Disconnect();
				녪뇃.녴(connection.Id);
				놴(connection);
			}
		}
	}

	public ConnectionInfo CreateCustomConnectionInfo(string name, string vendorName, string group = null)
	{
		if (name == null)
		{
			throw new ArgumentNullException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놝());
		}
		if (vendorName == null)
		{
			throw new ArgumentNullException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵녽());
		}
		if (group == null)
		{
			group = vendorName;
		}
		List<ConnectionInfo> list = ConnectionsInfo.Where((ConnectionInfo P_0) => P_0.CreationType == ConnectionCreationType.Default && P_0.VendorName == vendorName && P_0.Group == group).ToList();
		if (list.Count == 0)
		{
			throw new ArgumentException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵놏() + vendorName + _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵녥() + group);
		}
		if (!list.Any((ConnectionInfo P_0) => P_0.AllowCreateCustomConnections))
		{
			throw new InvalidOperationException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵농() + vendorName + _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵녥() + group);
		}
		return new ConnectionInfo(name, group, vendorName, ConnectionCreationType.Custom)
		{
			Links = list[0].Links
		};
	}

	public ConnectionInfo CreateTechnicalConnectionInfo(string name, string vendorName, string id = null)
	{
		if (name == null)
		{
			throw new ArgumentNullException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놝());
		}
		if (vendorName == null)
		{
			throw new ArgumentNullException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵녽());
		}
		ConnectionInfo connectionInfo = new ConnectionInfo(name, vendorName, vendorName, ConnectionCreationType.Technical);
		if (!string.IsNullOrEmpty(id))
		{
			connectionInfo.ConnectionId = id;
		}
		return connectionInfo;
	}

	public void AddConnectionInfo(ConnectionInfo connectionInfo)
	{
		if (connectionInfo == null)
		{
			throw new ArgumentNullException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵념());
		}
		if (connectionInfo.CreationType == ConnectionCreationType.Technical)
		{
			throw new InvalidOperationException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵녨());
		}
		if (녪놮.녴(connectionInfo.ConnectionId, out var connectionInfo2))
		{
			connectionInfo2.Settings = connectionInfo.Settings;
			return;
		}
		녪놮[connectionInfo.ConnectionId] = connectionInfo;
		List<ConnectionInfo> list = ConnectionsInfo.Where((ConnectionInfo P_0) => P_0.CreationType == ConnectionCreationType.Default && P_0.VendorName == connectionInfo.VendorName && P_0.Group == connectionInfo.Group).ToList();
		if (list.Count > 0)
		{
			connectionInfo.Links = list[0].Links;
			connectionInfo.Copyrights = list[0].Copyrights;
		}
		녪놦.InvokeSafely(connectionInfo);
	}

	public void RemoveConnectionInfo(ConnectionInfo connectionInfo)
	{
		if (connectionInfo == null)
		{
			throw new ArgumentNullException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵념());
		}
		if (녪놮.놴(connectionInfo.ConnectionId))
		{
			녪놮.녴(connectionInfo.ConnectionId);
			if (녪뇃.녴(connectionInfo.ConnectionId, out var connection))
			{
				RemoveConnection(connection);
			}
			녪놐.InvokeSafely(connectionInfo);
		}
	}

	public void RenameConnectionInfo(ConnectionInfo connectionInfo, string newName)
	{
		if (connectionInfo == null)
		{
			throw new ArgumentNullException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵념());
		}
		if (string.IsNullOrEmpty(newName))
		{
			throw new ArgumentNullException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵녺());
		}
		if (!(connectionInfo.Name == newName))
		{
			connectionInfo.Name = newName;
			녪녚.InvokeSafely(connectionInfo);
		}
	}

	private void 녴(Connection P_0)
	{
		P_0.StateChanged += 녴;
		P_0.ConnectingProgressChanged += 녴;
		녪뇁.InvokeSafely(P_0);
	}

	private void 놴(Connection P_0)
	{
		P_0.StateChanged -= 녴;
		P_0.ConnectingProgressChanged -= 녴;
		녪놧.InvokeSafely(P_0);
	}

	private void 녴(object P_0, ConnectionStateChangedEventArgs P_1)
	{
		if (!(P_0 is Connection connection))
		{
			return;
		}
		lock (녪녯)
		{
			if (P_1.NewState == ConnectionState.ConnectionLost && !녪놯.ContainsKey(connection.Id))
			{
				녪놯.Add(connection.Id, new 놭(connection));
			}
		}
		List<ConnectionStateObserver> list = null;
		lock (녪놥)
		{
			list = new List<ConnectionStateObserver>(녪놉);
		}
		foreach (ConnectionStateObserver item in list)
		{
			item.녴(P_0, P_1);
		}
		녪녝.InvokeSafely(P_0, P_1);
	}

	private void 녴(object P_0, ConnectionConnectingProgressChangedEventArgs P_1)
	{
		if (P_0 is Connection)
		{
			녪뇈?.Invoke(P_0, P_1);
		}
	}

	public void Dispose()
	{
		놴();
		if (녪뇃 != null)
		{
			List<Connection> list = new List<Connection>(녪뇃.Values);
			foreach (Connection item in list)
			{
				item.Disconnect();
			}
			녪뇃.놴();
			list.Clear();
		}
		Core.Instance.놴(놂);
	}

	internal void 녴(ConnectionStateObserver P_0)
	{
		lock (녪놥)
		{
			녪놉.Add(P_0);
			녪놉.Sort();
		}
	}

	internal void 놴(ConnectionStateObserver P_0)
	{
		lock (녪놥)
		{
			녪놉.Remove(P_0);
		}
	}

	private void 녴()
	{
		try
		{
			if (녪녫 == null)
			{
				녪녫 = new Timer(녴);
				녪녫.Change(0, 10000);
			}
		}
		catch
		{
		}
	}

	private void 놴()
	{
		try
		{
			if (녪녫 != null)
			{
				녪녫.Change(-1, -1);
				녪녫.Dispose();
				녪녫 = null;
			}
		}
		catch (Exception)
		{
		}
	}

	private void 녴(object P_0)
	{
		if (녪녳)
		{
			return;
		}
		try
		{
			녪녳 = true;
			Connection[] all = All;
			for (int i = 0; i < all.Length; i++)
			{
				all[i].놴();
			}
			녪놑?.Invoke();
		}
		catch (Exception ex)
		{
			Core.Instance.Loggers.Log(ex);
		}
		finally
		{
			녪녳 = false;
		}
	}

	private void 놂()
	{
		if (녪녾 < 10)
		{
			녪녾++;
			return;
		}
		List<놭> list = new List<놭>();
		lock (녪녯)
		{
			list.AddRange(녪놯.Values);
		}
		foreach (놭 놓놪 in list)
		{
			if (놓놪.CurrentTask != null || 놓놪.Connection.State == ConnectionState.Connecting)
			{
				continue;
			}
			놓놪.ReconnectDelay -= 1.0;
			if (놓놪.ReconnectDelay <= 0.0)
			{
				놓놪.CurrentTask = Task.Run(delegate
				{
					놂(놓놪.Connection);
				}).ContinueWith((Task t) => 놓놪.CurrentTask = null);
			}
		}
		녪녾 = 0;
	}

	private void 놂(Connection P_0)
	{
		놭 value;
		lock (녪녯)
		{
			if (!녪놯.TryGetValue(P_0.Id, out value))
			{
				return;
			}
		}
		value.ReconnectAttempts++;
		ConnectionResult connectionResult = P_0.Connect();
		if (P_0.State == ConnectionState.Connected || connectionResult.Cancelled)
		{
			lock (녪녯)
			{
				녪놯.Remove(P_0.Id);
				return;
			}
		}
		if (connectionResult.State == ConnectionState.Fail)
		{
			value.ReconnectDelay = 5.0;
		}
	}
}
