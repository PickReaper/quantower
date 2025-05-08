using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;

namespace TradingPlatform.BusinessLayer;

public abstract class ScriptManager<TScriptInfo, TScript> : IDisposable where TScriptInfo : ScriptInfo where TScript : ExecutionEntity
{
	[CompilerGenerated]
	private sealed class 녴
	{
		public ScriptCreationType 녶놝;

		public string 녶뇄;

		public string 녶녑;

		internal bool 녴(ScriptKey P_0)
		{
			return P_0.ScriptCreationType == 녶놝;
		}

		internal bool 놴(ScriptKey P_0)
		{
			return P_0.RelativePath == 녶뇄;
		}

		internal bool 놂(ScriptKey P_0)
		{
			return P_0.AssemblyName == 녶녑;
		}
	}

	[CompilerGenerated]
	private sealed class 놴
	{
		public ScriptManager<TScriptInfo, TScript> 녶놈;

		public FileSystemEventArgs 녶놬;

		internal void 녴(Task P_0)
		{
			녶놈.녴(녶놬.FullPath);
		}
	}

	[CompilerGenerated]
	private sealed class 놂
	{
		public ScriptManager<TScriptInfo, TScript> 녶놊;

		public FileSystemEventArgs 녶놪;

		internal void 녴(Task P_0)
		{
			녶놊.녴(녶놪.FullPath);
		}
	}

	[CompilerGenerated]
	private sealed class 놎
	{
		public ScriptManager<TScriptInfo, TScript> 녶놌;

		public List<string> 녶놕;

		internal void 녴(string P_0)
		{
			녶놌.놴놡.Add(P_0);
		}

		internal void 녴(Task P_0)
		{
			foreach (string item in 녶놕)
			{
				if (!녶놌.놴놡.Contains(item))
				{
					break;
				}
				녶놌.놴놻.Remove(item);
				if (!녶놌.놴뇅.TryGetValue(item, out var value))
				{
					continue;
				}
				foreach (TScriptInfo item2 in new List<TScriptInfo>(value))
				{
					녶놌.놴(item2, item);
					녶놌.놴(item2);
				}
			}
		}
	}

	[CompilerGenerated]
	private sealed class 녞
	{
		public string 녶뇊;

		internal bool 녴(string P_0)
		{
			return P_0.Contains(녶뇊);
		}
	}

	[CompilerGenerated]
	private ScriptInfoEventHandler 놴놄;

	[CompilerGenerated]
	private ScriptInfoEventHandler 놴놰;

	[CompilerGenerated]
	private ScriptInfoEventHandler 놴놓;

	protected Dictionary<ScriptKey, TScriptInfo> scriptsInfoCache;

	private readonly Dictionary<string, List<ScriptKey>> 놴놇;

	private readonly Dictionary<string, List<TScriptInfo>> 놴뇅;

	private readonly FileSystemWatcher 놴놵;

	private readonly HashSet<string> 놴놡;

	private readonly Dictionary<string, DateTime> 놴놻;

	private readonly object 놴놃;

	protected abstract string DefaultScriptsPath { get; }

	public abstract string CustomScriptsPath { get; }

	public TScriptInfo[] All => scriptsInfoCache.Values.ToArray();

	public event ScriptInfoEventHandler ScriptAdded
	{
		[CompilerGenerated]
		add
		{
			ScriptInfoEventHandler scriptInfoEventHandler = 놴놄;
			ScriptInfoEventHandler scriptInfoEventHandler2;
			do
			{
				scriptInfoEventHandler2 = scriptInfoEventHandler;
				ScriptInfoEventHandler value2 = (ScriptInfoEventHandler)Delegate.Combine(scriptInfoEventHandler2, value);
				scriptInfoEventHandler = Interlocked.CompareExchange(ref 놴놄, value2, scriptInfoEventHandler2);
			}
			while ((object)scriptInfoEventHandler != scriptInfoEventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			ScriptInfoEventHandler scriptInfoEventHandler = 놴놄;
			ScriptInfoEventHandler scriptInfoEventHandler2;
			do
			{
				scriptInfoEventHandler2 = scriptInfoEventHandler;
				ScriptInfoEventHandler value2 = (ScriptInfoEventHandler)Delegate.Remove(scriptInfoEventHandler2, value);
				scriptInfoEventHandler = Interlocked.CompareExchange(ref 놴놄, value2, scriptInfoEventHandler2);
			}
			while ((object)scriptInfoEventHandler != scriptInfoEventHandler2);
		}
	}

	public event ScriptInfoEventHandler ScriptUpdated
	{
		[CompilerGenerated]
		add
		{
			ScriptInfoEventHandler scriptInfoEventHandler = 놴놰;
			ScriptInfoEventHandler scriptInfoEventHandler2;
			do
			{
				scriptInfoEventHandler2 = scriptInfoEventHandler;
				ScriptInfoEventHandler value2 = (ScriptInfoEventHandler)Delegate.Combine(scriptInfoEventHandler2, value);
				scriptInfoEventHandler = Interlocked.CompareExchange(ref 놴놰, value2, scriptInfoEventHandler2);
			}
			while ((object)scriptInfoEventHandler != scriptInfoEventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			ScriptInfoEventHandler scriptInfoEventHandler = 놴놰;
			ScriptInfoEventHandler scriptInfoEventHandler2;
			do
			{
				scriptInfoEventHandler2 = scriptInfoEventHandler;
				ScriptInfoEventHandler value2 = (ScriptInfoEventHandler)Delegate.Remove(scriptInfoEventHandler2, value);
				scriptInfoEventHandler = Interlocked.CompareExchange(ref 놴놰, value2, scriptInfoEventHandler2);
			}
			while ((object)scriptInfoEventHandler != scriptInfoEventHandler2);
		}
	}

	public event ScriptInfoEventHandler ScriptDeleted
	{
		[CompilerGenerated]
		add
		{
			ScriptInfoEventHandler scriptInfoEventHandler = 놴놓;
			ScriptInfoEventHandler scriptInfoEventHandler2;
			do
			{
				scriptInfoEventHandler2 = scriptInfoEventHandler;
				ScriptInfoEventHandler value2 = (ScriptInfoEventHandler)Delegate.Combine(scriptInfoEventHandler2, value);
				scriptInfoEventHandler = Interlocked.CompareExchange(ref 놴놓, value2, scriptInfoEventHandler2);
			}
			while ((object)scriptInfoEventHandler != scriptInfoEventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			ScriptInfoEventHandler scriptInfoEventHandler = 놴놓;
			ScriptInfoEventHandler scriptInfoEventHandler2;
			do
			{
				scriptInfoEventHandler2 = scriptInfoEventHandler;
				ScriptInfoEventHandler value2 = (ScriptInfoEventHandler)Delegate.Remove(scriptInfoEventHandler2, value);
				scriptInfoEventHandler = Interlocked.CompareExchange(ref 놴놓, value2, scriptInfoEventHandler2);
			}
			while ((object)scriptInfoEventHandler != scriptInfoEventHandler2);
		}
	}

	protected ScriptManager()
	{
		scriptsInfoCache = new Dictionary<ScriptKey, TScriptInfo>();
		놴놇 = new Dictionary<string, List<ScriptKey>>();
		놴뇅 = new Dictionary<string, List<TScriptInfo>>();
		놴놵 = new FileSystemWatcher();
		놴놡 = new HashSet<string>();
		놴놻 = new Dictionary<string, DateTime>();
		놴놃 = new object();
	}

	internal virtual void 녴()
	{
		string customScriptsPath = CustomScriptsPath;
		if (!Directory.Exists(customScriptsPath))
		{
			Directory.CreateDirectory(customScriptsPath);
		}
		List<TypeWrapper> list = AssemblyLoader.LoadTypes(DefaultScriptsPath, typeof(TScript), null, SearchOption.AllDirectories, loadInMemory: true);
		녴(list, ScriptCreationType.Default);
		List<TypeWrapper> list2 = AssemblyLoader.LoadTypes(customScriptsPath, typeof(TScript), null, SearchOption.AllDirectories, loadInMemory: true, allowLoadingReferences: true);
		녴(list2, ScriptCreationType.Custom);
		놴놵.Path = customScriptsPath;
		놴놵.NotifyFilter = NotifyFilters.FileName | NotifyFilters.DirectoryName | NotifyFilters.Size;
		놴놵.IncludeSubdirectories = true;
		놴놵.Created += 녴;
		놴놵.Changed += 놴;
		놴놵.Deleted += 놂;
		놴놵.EnableRaisingEvents = true;
	}

	private void 녴(List<TypeWrapper> P_0, ScriptCreationType P_1)
	{
		if (P_0 == null)
		{
			return;
		}
		string scriptsFolderPath = GetScriptsFolderPath(P_1);
		foreach (TypeWrapper item in P_0)
		{
			try
			{
				ConstructorInfo constructor = item.Type.GetConstructor(Array.Empty<Type>());
				string directoryName = Path.GetDirectoryName(녴(item.AssemblyLocation, scriptsFolderPath));
				TScriptInfo val = CreateScriptInfo(constructor, P_1, directoryName, item.Type.Assembly.GetName().Name);
				if (!(val.Key == default(ScriptKey)))
				{
					녴(val, item.AssemblyLocation);
				}
			}
			catch (Exception ex)
			{
				Core.Instance.Loggers.Log(ex);
			}
		}
	}

	protected abstract string GetScriptsFolderPath(ScriptCreationType scriptCreationType);

	protected abstract TScriptInfo CreateScriptInfo(ConstructorInfo ctor, ScriptCreationType scriptCreationType, string relativePath, string assemblyName);

	protected ScriptKey SearchScriptKey(string scriptName, string assemblyName, string relativePath, ScriptCreationType scriptCreationType = ScriptCreationType.Default)
	{
		if (!놴놇.TryGetValue(scriptName, out var value))
		{
			return default(ScriptKey);
		}
		if (!value.Any())
		{
			return default(ScriptKey);
		}
		List<ScriptKey> source = new List<ScriptKey>(value);
		source = source.Where((ScriptKey P_0) => P_0.ScriptCreationType == scriptCreationType).ToList();
		if (!string.IsNullOrEmpty(relativePath))
		{
			source = source.Where((ScriptKey P_0) => P_0.RelativePath == relativePath).ToList();
		}
		if (!string.IsNullOrEmpty(assemblyName))
		{
			source = source.Where((ScriptKey P_0) => P_0.AssemblyName == assemblyName).ToList();
		}
		return source.FirstOrDefault();
	}

	private static string 녴(string P_0, string P_1)
	{
		Uri uri = new Uri(P_0);
		if (!P_1.EndsWith(Path.DirectorySeparatorChar.ToString()))
		{
			P_1 += Path.DirectorySeparatorChar;
		}
		return Uri.UnescapeDataString(new Uri(P_1).MakeRelativeUri(uri).ToString().Replace('/', Path.DirectorySeparatorChar));
	}

	public virtual void Dispose()
	{
		놴놵.Created -= 녴;
		놴놵.Changed -= 놴;
		놴놵.Deleted -= 놂;
		놴놵.EnableRaisingEvents = false;
		놴놵.Dispose();
		scriptsInfoCache?.Clear();
		놴놇?.Clear();
	}

	private void 녴(object P_0, FileSystemEventArgs P_1)
	{
		if (!놴(P_1.FullPath))
		{
			놴놡.Remove(P_1.FullPath);
			Task.Delay(1000).ContinueWith(delegate
			{
				녴(P_1.FullPath);
			});
		}
	}

	private void 놴(object P_0, FileSystemEventArgs P_1)
	{
		if (!놴(P_1.FullPath))
		{
			Task.Delay(1000).ContinueWith(delegate
			{
				녴(P_1.FullPath);
			});
		}
	}

	private void 놂(object P_0, FileSystemEventArgs P_1)
	{
		List<string> 녶놕 = new List<string>();
		if (!Path.HasExtension(P_1.FullPath))
		{
			string 녶뇊 = _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴녜() + MakeRelativePath(CustomScriptsPath, P_1.FullPath) + _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴녜();
			녶놕.AddRange(놴뇅.Keys.Where((string P_0) => P_0.Contains(녶뇊)));
		}
		else if (Path.GetExtension(P_1.FullPath) == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴뇃())
		{
			녶놕.Add(P_1.FullPath);
		}
		if (녶놕.Count == 0)
		{
			return;
		}
		녶놕.ForEach(delegate(string P_0)
		{
			놴놡.Add(P_0);
		});
		Task.Delay(2000).ContinueWith(delegate
		{
			foreach (string item in 녶놕)
			{
				if (!놴놡.Contains(item))
				{
					break;
				}
				놴놻.Remove(item);
				if (놴뇅.TryGetValue(item, out var value))
				{
					foreach (TScriptInfo item2 in new List<TScriptInfo>(value))
					{
						놴(item2, item);
						놴(item2);
					}
				}
			}
		});
	}

	private void 녴(ScriptInfo P_0)
	{
		놴놄?.Invoke(P_0, new ScriptInfoEventArgs());
	}

	protected virtual void OnScriptUpdated(ScriptInfo scriptInfo)
	{
		놴놰?.Invoke(scriptInfo, new ScriptInfoEventArgs());
	}

	private void 놴(ScriptInfo P_0)
	{
		놴놓?.Invoke(P_0, new ScriptInfoEventArgs());
	}

	private void 녴(TScriptInfo P_0, string P_1)
	{
		ScriptKey key = P_0.Key;
		scriptsInfoCache.Add(key, P_0);
		if (!놴놇.TryGetValue(key.ScriptName, out var value))
		{
			value = new List<ScriptKey>();
			놴놇.Add(key.ScriptName, value);
		}
		value.Add(key);
		if (!놴뇅.TryGetValue(P_1, out var value2))
		{
			value2 = new List<TScriptInfo>();
			놴뇅.Add(P_1, value2);
		}
		value2.Add(P_0);
	}

	private void 놴(TScriptInfo P_0, string P_1)
	{
		ScriptKey key = P_0.Key;
		scriptsInfoCache.Remove(key);
		if (놴놇.TryGetValue(key.ScriptName, out var value))
		{
			value.Remove(key);
		}
		if (놴뇅.TryGetValue(P_1, out var value2))
		{
			value2.Remove(P_0);
		}
		if (!value2.Any())
		{
			놴뇅.Remove(P_1);
		}
	}

	private bool 녴(string P_0, DateTime P_1)
	{
		if (놴놻.TryGetValue(P_0, out var value))
		{
			return value == P_1;
		}
		return false;
	}

	private void 녴(string P_0)
	{
		try
		{
			lock (놴놃)
			{
				DateTime lastWriteTimeUtc = File.GetLastWriteTimeUtc(P_0);
				bool num = 녴(P_0, lastWriteTimeUtc);
				놴놻[P_0] = lastWriteTimeUtc;
				if (num)
				{
					return;
				}
			}
			string scriptsFolderPath = GetScriptsFolderPath(ScriptCreationType.Custom);
			foreach (TypeWrapper item in AssemblyLoader.녴(P_0, typeof(TScript), true, true))
			{
				try
				{
					ConstructorInfo constructor = item.Type.GetConstructor(Array.Empty<Type>());
					string directoryName = Path.GetDirectoryName(녴(item.AssemblyLocation, scriptsFolderPath));
					TScriptInfo val = CreateScriptInfo(constructor, ScriptCreationType.Custom, directoryName, item.Type.Assembly.GetName().Name);
					if (!(val.Key == default(ScriptKey)))
					{
						ScriptKey key = val.Key;
						if (scriptsInfoCache.ContainsKey(key))
						{
							scriptsInfoCache[key] = val;
							OnScriptUpdated(val);
						}
						else
						{
							녴(val, P_0);
							녴(val);
						}
					}
				}
				catch (Exception ex)
				{
					Core.Instance.Loggers.Log(ex);
				}
			}
		}
		catch (Exception ex2)
		{
			Core.Instance.Loggers.Log(ex2);
		}
	}

	private static bool 놴(string P_0)
	{
		if (!Path.HasExtension(P_0))
		{
			return true;
		}
		if (Path.GetExtension(P_0) != _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴뇃())
		{
			return true;
		}
		return false;
	}

	public static string MakeRelativePath(string fromPath, string toPath)
	{
		if (string.IsNullOrEmpty(fromPath))
		{
			throw new ArgumentNullException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴녯());
		}
		if (string.IsNullOrEmpty(toPath))
		{
			throw new ArgumentNullException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴놮());
		}
		Uri uri = new Uri(fromPath);
		Uri uri2 = new Uri(toPath);
		if (uri.Scheme != uri2.Scheme)
		{
			return toPath;
		}
		string text = Uri.UnescapeDataString(uri.MakeRelativeUri(uri2).ToString());
		if (uri2.Scheme.Equals(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴녫(), StringComparison.InvariantCultureIgnoreCase))
		{
			text = text.Replace(Path.AltDirectorySeparatorChar, Path.DirectorySeparatorChar);
		}
		return text;
	}
}
