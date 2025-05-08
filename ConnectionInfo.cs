using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using TradingPlatform.BusinessLayer.Integration;
using TradingPlatform.BusinessLayer.Utils.Extensions;

namespace TradingPlatform.BusinessLayer;

/// <summary>
/// Represents all needed parameters for the connection constructing process.
/// </summary>
[Published]
public sealed class ConnectionInfo : ICustomizable, IRenamable, IComparable, IComparable<ConnectionInfo>
{
	[Serializable]
	[CompilerGenerated]
	private sealed class 녴
	{
		public static readonly 녴 놓녟 = new 녴();

		public static Func<SettingItem, SettingItem> 놓놱;

		internal SettingItem 녴(SettingItem P_0)
		{
			return P_0.GetCopy();
		}
	}

	internal const string 녪녭 = "ConnectionId";

	private const string 녪녱 = "Name";

	internal const string 녪놲 = "Group";

	private const string 녪높 = "VendorName";

	private const string 녪놶 = "IsFavourite";

	private const string 녪뇏 = "ConnectionState";

	private const string 녪녻 = "CreationType";

	[CompilerGenerated]
	private string 녪녙;

	[CompilerGenerated]
	private string 녪놢;

	[CompilerGenerated]
	private string 녪녧;

	[CompilerGenerated]
	private string 녪녤;

	[CompilerGenerated]
	private bool 녪놆;

	[CompilerGenerated]
	private ConnectionState 녪뇎;

	[CompilerGenerated]
	private IList<SettingItem> 녪놷;

	[CompilerGenerated]
	private IList<SettingItem> 녪녗;

	[CompilerGenerated]
	private ConnectionCreationType 녪놜;

	[CompilerGenerated]
	private string 녪놨;

	[CompilerGenerated]
	private bool 녪녢;

	[CompilerGenerated]
	private List<ConnectionInfoLink> 녪놞;

	[CompilerGenerated]
	private string 녪놳;

	private VendorInfo 녪놺;

	[CompilerGenerated]
	private bool 녪놅;

	/// <summary>
	/// Gets a user friendly name of the connection
	/// </summary>
	public string Name
	{
		[CompilerGenerated]
		get
		{
			return 녪녙;
		}
		[CompilerGenerated]
		internal set
		{
			녪녙 = value;
		}
	}

	/// <summary>
	/// Gets connection group
	/// </summary>
	public string Group
	{
		[CompilerGenerated]
		get
		{
			return 녪놢;
		}
		[CompilerGenerated]
		private set
		{
			녪놢 = value;
		}
	}

	/// <summary>
	/// Gets vendor's name
	/// </summary>
	public string VendorName
	{
		[CompilerGenerated]
		get
		{
			return 녪녧;
		}
		[CompilerGenerated]
		private set
		{
			녪녧 = value;
		}
	}

	/// <summary>
	/// Gets connection Id
	/// </summary>
	public string ConnectionId
	{
		[CompilerGenerated]
		get
		{
			return 녪녤;
		}
		[CompilerGenerated]
		internal set
		{
			녪녤 = value;
		}
	}

	/// <summary>
	/// Favorites one will be displayed in Control center toolbar
	/// </summary>
	public bool IsFavourite
	{
		[CompilerGenerated]
		get
		{
			return 녪놆;
		}
		[CompilerGenerated]
		set
		{
			녪놆 = value;
		}
	}

	/// <summary>
	/// Gets ConnectionState
	/// </summary>
	public ConnectionState ConnectionState
	{
		[CompilerGenerated]
		get
		{
			return 녪뇎;
		}
		[CompilerGenerated]
		internal set
		{
			녪뇎 = value;
		}
	}

	/// <summary>
	/// Gets vendor's settings
	/// </summary>
	public IList<SettingItem> VendorSettings
	{
		[CompilerGenerated]
		get
		{
			return 녪놷;
		}
		[CompilerGenerated]
		private set
		{
			녪놷 = value;
		}
	}

	internal IList<SettingItem> ConnectionSettings
	{
		[CompilerGenerated]
		get
		{
			return 녪녗;
		}
		[CompilerGenerated]
		set
		{
			녪녗 = value;
		}
	}

	/// <summary>
	/// Specifies how connection was created: by default or by user
	/// </summary>
	public ConnectionCreationType CreationType
	{
		[CompilerGenerated]
		get
		{
			return 녪놜;
		}
		[CompilerGenerated]
		private set
		{
			녪놜 = value;
		}
	}

	public string ConnectionLogoPath
	{
		[CompilerGenerated]
		get
		{
			return 녪놨;
		}
		[CompilerGenerated]
		internal set
		{
			녪놨 = value;
		}
	}

	public bool AllowCreateCustomConnections
	{
		[CompilerGenerated]
		get
		{
			return 녪녢;
		}
		[CompilerGenerated]
		internal set
		{
			녪녢 = value;
		}
	}

	public List<ConnectionInfoLink> Links
	{
		[CompilerGenerated]
		get
		{
			return 녪놞;
		}
		[CompilerGenerated]
		internal set
		{
			녪놞 = value;
		}
	}

	public string Copyrights
	{
		[CompilerGenerated]
		get
		{
			return 녪놳;
		}
		[CompilerGenerated]
		internal set
		{
			녪놳 = value;
		}
	}

	public VendorInfo VendorInfo
	{
		get
		{
			return 녪놺;
		}
		internal set
		{
			if (value == null)
			{
				return;
			}
			녪놺 = value;
			List<SettingItem> list = new List<SettingItem>(녪놺.ConnectionParameters);
			if (ConnectionSettings != null)
			{
				list.MergeWith(ConnectionSettings.Select((SettingItem P_0) => P_0.GetCopy()).ToList());
			}
			VendorSettings = list;
		}
	}

	/// <summary>
	/// <see cref="T:TradingPlatform.BusinessLayer.ICustomizable" /> realization
	/// </summary>
	public IList<SettingItem> Settings
	{
		get
		{
			int value = (int)((ConnectionState != ConnectionState.Connecting) ? ((ConnectionState == ConnectionState.Disconnecting) ? ConnectionState.Disconnected : ConnectionState) : ConnectionState.Connected);
			List<SettingItem> list = new List<SettingItem>
			{
				new SettingItemString(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놎뇉(), ConnectionId)
				{
					VisibilityMode = VisibilityMode.Hidden
				},
				new SettingItemString(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놵(), Name)
				{
					Text = _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵놯()
				},
				new SettingItemString(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놎뇍(), Group)
				{
					VisibilityMode = VisibilityMode.Hidden
				},
				new SettingItemString(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵녾(), VendorName)
				{
					VisibilityMode = VisibilityMode.Hidden
				},
				new SettingItemBoolean(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵녬(), IsFavourite)
				{
					VisibilityMode = VisibilityMode.Hidden
				},
				new SettingItemInteger(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵녹(), value)
				{
					VisibilityMode = VisibilityMode.Hidden
				},
				new SettingItemInteger(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵녔(), (int)CreationType)
				{
					VisibilityMode = VisibilityMode.Hidden
				}
			};
			if (VendorSettings != null)
			{
				for (int i = 0; i < VendorSettings.Count; i++)
				{
					list.Add(VendorSettings[i].GetCopy());
				}
			}
			return list;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂뇄());
			}
			foreach (SettingItem item in value)
			{
				try
				{
					string name = item.Name;
					if (name != null)
					{
						switch (name.Length)
						{
						case 12:
							switch (name[1])
							{
							case 'o':
								if (!(name == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놎뇉()))
								{
									break;
								}
								ConnectionId = item.Value as string;
								goto end_IL_0021;
							case 'r':
								if (!(name == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵녔()))
								{
									break;
								}
								CreationType = (ConnectionCreationType)(int)item.Value;
								goto end_IL_0021;
							}
							break;
						case 4:
							if (!(name == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놵()))
							{
								break;
							}
							Name = item.Value as string;
							goto end_IL_0021;
						case 10:
							if (!(name == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵녾()))
							{
								break;
							}
							VendorName = item.Value as string;
							놂();
							goto end_IL_0021;
						case 5:
							if (!(name == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놎뇍()))
							{
								break;
							}
							Group = item.Value as string;
							goto end_IL_0021;
						case 11:
							if (!(name == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵녬()))
							{
								break;
							}
							IsFavourite = (bool)item.Value;
							goto end_IL_0021;
						case 15:
						{
							if (!(name == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵녹()))
							{
								break;
							}
							ConnectionState connectionState = (ConnectionState)(int)item.Value;
							if (connectionState == ConnectionState.Disconnecting)
							{
								connectionState = ConnectionState.Disconnected;
							}
							ConnectionState = connectionState;
							goto end_IL_0021;
						}
						}
					}
					VendorSettings?.UpdateItemValue(item.Name, item.Value);
					end_IL_0021:;
				}
				catch (Exception ex)
				{
					Core.Instance.Loggers.Log(ex);
				}
			}
			if (string.IsNullOrEmpty(ConnectionLogoPath) && CreationType == ConnectionCreationType.Custom)
			{
				놴();
			}
		}
	}

	public bool SyncMsgProcessing
	{
		[CompilerGenerated]
		get
		{
			return 녪놅;
		}
		[CompilerGenerated]
		set
		{
			녪놅 = value;
		}
	}

	string IRenamable.Name
	{
		get
		{
			return Name;
		}
		set
		{
			Core.Instance.Connections.RenameConnectionInfo(this, value);
		}
	}

	/// <summary>
	/// Creates connection info instance
	/// </summary>
	/// <param name="name"></param>
	internal ConnectionInfo(string P_0)
	{
		Name = P_0;
		ConnectionState = ConnectionState.Disconnected;
		ConnectionId = string.Empty;
	}

	internal ConnectionInfo(string P_0, string P_1)
		: this(P_0, P_1, P_1, ConnectionCreationType.Custom)
	{
	}

	/// <summary>
	/// Creates connection info instance.
	/// </summary>
	/// <param name="name"></param>
	/// <param name="group"></param>
	/// <param name="vendorName"></param>
	/// <param name="creationType"></param>
	internal ConnectionInfo(string P_0, string P_1, string P_2, ConnectionCreationType P_3 = ConnectionCreationType.Default)
		: this(P_0)
	{
		Group = P_1 ?? P_2;
		VendorName = P_2;
		CreationType = P_3;
		ConnectionId = 녴();
		if (CreationType == ConnectionCreationType.Custom)
		{
			놴();
			놂();
		}
		else if (CreationType == ConnectionCreationType.Technical)
		{
			놂();
		}
	}

	private string 녴()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 4);
		defaultInterpolatedStringHandler.AppendFormatted(VendorName);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놎놙());
		defaultInterpolatedStringHandler.AppendFormatted(Group);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놎놙());
		defaultInterpolatedStringHandler.AppendFormatted(CreationType);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놎놙());
		defaultInterpolatedStringHandler.AppendFormatted((CreationType == ConnectionCreationType.Default) ? Name : Guid.NewGuid().ToShortString());
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	private void 놴()
	{
		ConnectionInfo connectionInfo = Core.Instance.Connections.ConnectionsInfo.FirstOrDefault((ConnectionInfo P_0) => P_0.CreationType == ConnectionCreationType.Default && P_0.Group == Group);
		if (connectionInfo != null)
		{
			ConnectionLogoPath = connectionInfo.ConnectionLogoPath;
		}
	}

	private void 놂()
	{
		if (VendorInfo == null)
		{
			VendorInfo vendorInfo = Core.Instance.Vendors.Vendors.FirstOrDefault((VendorInfo P_0) => P_0.MetaData.VendorName == VendorName);
			ConnectionInfo connectionInfo = vendorInfo?.DefaultConnections.FirstOrDefault((ConnectionInfo P_0) => P_0.Group == Group);
			if (connectionInfo != null)
			{
				ConnectionSettings = connectionInfo.ConnectionSettings;
			}
			VendorInfo = vendorInfo;
		}
	}

	[NotPublished]
	public override string ToString()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(26, 3);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵녠());
		defaultInterpolatedStringHandler.AppendFormatted(Name);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵놠());
		defaultInterpolatedStringHandler.AppendFormatted(VendorName);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵놟());
		defaultInterpolatedStringHandler.AppendFormatted(IsFavourite);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	public override bool Equals(object obj)
	{
		if (obj is ConnectionInfo connectionInfo)
		{
			return ConnectionId == connectionInfo.ConnectionId;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return -463474436 + EqualityComparer<string>.Default.GetHashCode(ConnectionId);
	}

	private bool 녴(string P_0, ref string P_1)
	{
		return true;
	}

	bool IRenamable.IsNameAllowed(string P_0, ref string P_1)
	{
		//ILSpy generated this explicit interface implementation from .override directive in 녴
		return this.녴(P_0, ref P_1);
	}

	public int CompareTo(object obj)
	{
		return CompareTo(obj as ConnectionInfo);
	}

	public int CompareTo(ConnectionInfo other)
	{
		if (this == other)
		{
			return 0;
		}
		if (other == null)
		{
			return 1;
		}
		return string.Compare(ConnectionId, other.ConnectionId, StringComparison.Ordinal);
	}

	[CompilerGenerated]
	private bool 녴(ConnectionInfo P_0)
	{
		if (P_0.CreationType == ConnectionCreationType.Default)
		{
			return P_0.Group == Group;
		}
		return false;
	}

	[CompilerGenerated]
	private bool 녴(VendorInfo P_0)
	{
		return P_0.MetaData.VendorName == VendorName;
	}

	[CompilerGenerated]
	private bool 놴(ConnectionInfo P_0)
	{
		return P_0.Group == Group;
	}
}
