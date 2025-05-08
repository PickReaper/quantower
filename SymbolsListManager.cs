using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Xml.Linq;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using FluentFTP;
using TradingPlatform.BusinessLayer.Serialization;

namespace TradingPlatform.BusinessLayer;

/// <summary>
/// The symbols list manager.
/// </summary>
public sealed class SymbolsListManager : ICustomizable
{
	[CompilerGenerated]
	private static class 녴
	{
		public static Func<XElement, IXElementSerialization> 놓놩;
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class 놴
	{
		public static readonly 놴 놓녡 = new 놴();

		public static Func<FtpListItem, bool> 놓녦;

		public static Func<FtpListItem, bool> 놓놀;

		public static Func<FtpListItem, bool> 놓놔;

		internal bool 녴(FtpListItem P_0)
		{
			return P_0.Type == FtpObjectType.Directory;
		}

		internal bool 놴(FtpListItem P_0)
		{
			return P_0.Type == FtpObjectType.File;
		}

		internal bool 놂(FtpListItem P_0)
		{
			return Path.GetExtension(P_0.Name) == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸녟();
		}
	}

	private readonly Dictionary<string, SymbolList> 놫놠;

	private readonly Dictionary<string, SymbolList> 놫놟;

	/// <summary>
	/// Gets the count.
	/// </summary>
	public int Count => 놫놠.Count + 놫놟.Count;

	/// <summary>
	/// Gets or Sets the settings.
	/// </summary>
	public IList<SettingItem> Settings
	{
		get
		{
			List<SettingItem> list = new List<SettingItem>();
			foreach (KeyValuePair<string, SymbolList> item in 놫놠)
			{
				list.Add(new SettingItemGroup(item.Key, item.Value.Settings));
			}
			return list;
		}
		set
		{
			foreach (SettingItem item in value)
			{
				if (item.Value is IList<SettingItem> settings)
				{
					if (놫놠.TryGetValue(item.Name, out var value2))
					{
						value2.Settings = settings;
						continue;
					}
					value2 = new SymbolList
					{
						Settings = settings
					};
					놫놠.Add(item.Name, value2);
				}
			}
		}
	}

	internal SymbolList[] Items => 놫놟.Values.Concat(놫놠.Values).ToArray();

	internal SymbolsListManager()
	{
		놫놠 = new Dictionary<string, SymbolList>();
		놫놟 = new Dictionary<string, SymbolList>();
	}

	internal void 녴()
	{
	}

	internal void 녴(string P_0, IEnumerable<Symbol> P_1)
	{
		놫놠.Add(P_0, new SymbolList(P_0, P_1));
	}

	internal void 녴(string P_0, IList<Symbol> P_1)
	{
		놫놠[P_0].Symbols = P_1;
	}

	internal void 녴(string P_0)
	{
		놫놠.Remove(P_0);
	}

	internal void 녴(string P_0, string P_1)
	{
		if (!놫놠.TryGetValue(P_0, out var value))
		{
			throw new ArgumentException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶놟() + P_0);
		}
		놫놠.Remove(P_0);
		value.녴(P_1);
		놫놠.Add(P_1, value);
	}

	[Conditional("quantower_in_licences")]
	private void 놴()
	{
		Task.Factory.StartNew(delegate
		{
			try
			{
				using FtpClient ftpClient = new FtpClient(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶녓(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶녛(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶녽());
				ftpClient.Connect();
				foreach (FtpListItem item in from P_0 in ftpClient.GetListing(Path.Combine(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶놏(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶녥()))
					where P_0.Type == FtpObjectType.Directory
					select P_0)
				{
					FtpListItem[] array = (from P_0 in ftpClient.GetListing(item.FullName)
						where P_0.Type == FtpObjectType.File
						where Path.GetExtension(P_0.Name) == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸녟()
						select P_0).ToArray();
					foreach (FtpListItem ftpListItem in array)
					{
						using MemoryStream memoryStream = new MemoryStream();
						ftpClient.DownloadStream(memoryStream, ftpListItem.FullName, 0L, null, 0L);
						memoryStream.Position = 0L;
						double version;
						List<SettingItem> list = Serializer.DeserializeXML(memoryStream, out version, SettingItem.DesserrializationFabric).OfType<SettingItem>().ToList();
						if (list != null && list.Any())
						{
							SymbolList symbolList = new SymbolList(list, false)
							{
								Group = item.Name
							};
							string key = Path.Combine(item.Name, symbolList.Name);
							놫놟[key] = symbolList;
						}
					}
				}
			}
			catch (Exception ex)
			{
				Core.Instance.Loggers.Log(ex);
			}
		});
	}

	[CompilerGenerated]
	private void 놂()
	{
		try
		{
			using FtpClient ftpClient = new FtpClient(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶녓(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶녛(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶녽());
			ftpClient.Connect();
			foreach (FtpListItem item in from P_0 in ftpClient.GetListing(Path.Combine(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶놏(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶녥()))
				where P_0.Type == FtpObjectType.Directory
				select P_0)
			{
				FtpListItem[] array = (from P_0 in ftpClient.GetListing(item.FullName)
					where P_0.Type == FtpObjectType.File
					where Path.GetExtension(P_0.Name) == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸녟()
					select P_0).ToArray();
				foreach (FtpListItem ftpListItem in array)
				{
					using MemoryStream memoryStream = new MemoryStream();
					ftpClient.DownloadStream(memoryStream, ftpListItem.FullName, 0L, null, 0L);
					memoryStream.Position = 0L;
					double version;
					List<SettingItem> list = Serializer.DeserializeXML(memoryStream, out version, SettingItem.DesserrializationFabric).OfType<SettingItem>().ToList();
					if (list != null && list.Any())
					{
						SymbolList symbolList = new SymbolList(list, false)
						{
							Group = item.Name
						};
						string key = Path.Combine(item.Name, symbolList.Name);
						놫놟[key] = symbolList;
					}
				}
			}
		}
		catch (Exception ex)
		{
			Core.Instance.Loggers.Log(ex);
		}
	}
}
