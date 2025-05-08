using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Threading;
using 녴;

namespace TradingPlatform.BusinessLayer;

[DataContract]
[KnownType(typeof(Account))]
[KnownType(typeof(PnLItem))]
public abstract class BusinessObject : IConnectionBindedObject, IUniqueID
{
	[CompilerGenerated]
	private string 놫놴;

	[CompilerGenerated]
	private BusinessObjectState 놫놂;

	private Connection 놫놎;

	[CompilerGenerated]
	private string 놫녞;

	private static long 놫놫;

	public string ConnectionId
	{
		[CompilerGenerated]
		get
		{
			return 놫놴;
		}
		[CompilerGenerated]
		internal set
		{
			놫놴 = value;
		}
	}

	public virtual BusinessObjectState State
	{
		[CompilerGenerated]
		get
		{
			return 놫놂;
		}
		[CompilerGenerated]
		protected internal set
		{
			놫놂 = value;
		}
	}

	public virtual Connection Connection => 놫놎 ?? (놫놎 = Core.Instance.Connections[ConnectionId]);

	internal virtual 놶 ConnectionCache => Connection?.놫놪;

	/// <summary>
	/// Unique ID during active session. Don't use for serialization
	/// </summary>
	public string UniqueId
	{
		[CompilerGenerated]
		get
		{
			return 놫녞;
		}
		[CompilerGenerated]
		private set
		{
			놫녞 = value;
		}
	}

	internal BusinessObject()
	{
	}

	internal BusinessObject(string P_0)
	{
		UniqueId = Interlocked.Increment(ref 놫놫).ToString();
		ConnectionId = P_0;
		State = BusinessObjectState.Normal;
	}

	[NotPublished]
	public virtual BusinessObjectInfo CreateInfo()
	{
		return new BusinessObjectInfo
		{
			ConnectionId = ConnectionId
		};
	}
}
