using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Xml;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using TradingPlatform.BusinessLayer.Utils;

namespace TradingPlatform.BusinessLayer;

/// <summary>
/// The assembly loader.
/// </summary>
public static class AssemblyLoader
{
	private class 녴
	{
		[CompilerGenerated]
		private string 놭뇇;

		[CompilerGenerated]
		private Assembly 놭놛;

		public string AssemblyFolder
		{
			[CompilerGenerated]
			get
			{
				return 놭뇇;
			}
			[CompilerGenerated]
			set
			{
				놭뇇 = value;
			}
		}

		public Assembly Assembly
		{
			[CompilerGenerated]
			get
			{
				return 놭놛;
			}
			[CompilerGenerated]
			set
			{
				놭놛 = value;
			}
		}

		public 녴(string P_0, Assembly P_1)
		{
			AssemblyFolder = P_0;
			Assembly = P_1;
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class 놴
	{
		public static readonly 놴 놭놼 = new 놴();

		internal Assembly? 녴(object P_0, ResolveEventArgs P_1)
		{
			try
			{
				try
				{
					if (P_1.RequestingAssembly != null && 놴녺.TryGetValue(P_1.Name, out var value) && File.Exists(value))
					{
						Assembly assembly = Assembly.Load(File.ReadAllBytes(value));
						if ((object)assembly != null)
						{
							LoggerManager loggers = Core.Instance.Loggers;
							DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(74, 2);
							defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭뇊());
							defaultInterpolatedStringHandler.AppendFormatted(P_1.Name);
							defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭놋());
							defaultInterpolatedStringHandler.AppendFormatted(P_1.RequestingAssembly);
							loggers.Log(defaultInterpolatedStringHandler.ToStringAndClear());
							LoggerManager loggers2 = Core.Instance.Loggers;
							defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(74, 3);
							defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭녣());
							defaultInterpolatedStringHandler.AppendFormatted(P_1.Name);
							defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭놋());
							defaultInterpolatedStringHandler.AppendFormatted(P_1.RequestingAssembly);
							defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭녩());
							defaultInterpolatedStringHandler.AppendFormatted(value);
							loggers2.Log(defaultInterpolatedStringHandler.ToStringAndClear());
							return assembly;
						}
					}
				}
				catch (Exception ex)
				{
					Core.Instance.Loggers.Log(ex);
				}
				if (P_1.RequestingAssembly != null && 놴녨.TryGetValue(P_1.RequestingAssembly.FullName, out var value2))
				{
					Assembly assembly2 = AssemblyLoader.녴(P_1.Name, value2.AssemblyFolder);
					if ((object)assembly2 != null)
					{
						return assembly2;
					}
					if (놴녨.TryGetValue(P_1.Name, out var value3))
					{
						return value3.Assembly;
					}
					LoggerManager loggers3 = Core.Instance.Loggers;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(74, 2);
					defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭뇊());
					defaultInterpolatedStringHandler.AppendFormatted(P_1.Name);
					defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭놋());
					defaultInterpolatedStringHandler.AppendFormatted(P_1.RequestingAssembly);
					loggers3.Log(defaultInterpolatedStringHandler.ToStringAndClear());
				}
			}
			catch (Exception ex2)
			{
				Core.Instance.Loggers.Log(ex2);
			}
			return null;
		}
	}

	private static readonly HashSet<string> 놴념;

	private static readonly Dictionary<string, 녴> 놴녨;

	private static readonly Dictionary<string, string> 놴녺;

	private static Dictionary<string, Dictionary<string, Assembly>> 놴놣;

	static AssemblyLoader()
	{
		놴놣 = new Dictionary<string, Dictionary<string, Assembly>>();
		놴녨 = new Dictionary<string, 녴>();
		놴념 = new HashSet<string>
		{
			_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놓(),
			_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놇()
		};
		try
		{
			놴녺 = new Dictionary<string, string>();
			string text = Path.Combine(Const.CUSTOM_SCRIPTS_PATH, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂뇅());
			if (File.Exists(text))
			{
				XmlDocument xmlDocument = new XmlDocument();
				xmlDocument.Load(text);
				foreach (XmlNode childNode in xmlDocument.DocumentElement.ChildNodes)
				{
					if (childNode.Attributes[_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놵()] != null && childNode.Attributes[_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놡()] != null)
					{
						string value = Path.Combine(Const.CUSTOM_SCRIPTS_PATH, childNode.Attributes[_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놡()].Value);
						놴녺[childNode.Attributes[_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놵()].Value] = value;
					}
				}
			}
		}
		catch (Exception ex)
		{
			Core.Instance.Loggers.Log(ex, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놻());
		}
		AppDomain.CurrentDomain.AssemblyResolve += delegate(object P_0, ResolveEventArgs P_1)
		{
			try
			{
				try
				{
					if (P_1.RequestingAssembly != null && 놴녺.TryGetValue(P_1.Name, out var value2) && File.Exists(value2))
					{
						Assembly assembly = Assembly.Load(File.ReadAllBytes(value2));
						if ((object)assembly != null)
						{
							LoggerManager loggers = Core.Instance.Loggers;
							DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(74, 2);
							defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭뇊());
							defaultInterpolatedStringHandler.AppendFormatted(P_1.Name);
							defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭놋());
							defaultInterpolatedStringHandler.AppendFormatted(P_1.RequestingAssembly);
							loggers.Log(defaultInterpolatedStringHandler.ToStringAndClear());
							LoggerManager loggers2 = Core.Instance.Loggers;
							defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(74, 3);
							defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭녣());
							defaultInterpolatedStringHandler.AppendFormatted(P_1.Name);
							defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭놋());
							defaultInterpolatedStringHandler.AppendFormatted(P_1.RequestingAssembly);
							defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭녩());
							defaultInterpolatedStringHandler.AppendFormatted(value2);
							loggers2.Log(defaultInterpolatedStringHandler.ToStringAndClear());
							return assembly;
						}
					}
				}
				catch (Exception ex2)
				{
					Core.Instance.Loggers.Log(ex2);
				}
				if (P_1.RequestingAssembly != null && 놴녨.TryGetValue(P_1.RequestingAssembly.FullName, out var value3))
				{
					Assembly assembly2 = 녴(P_1.Name, value3.AssemblyFolder);
					if ((object)assembly2 != null)
					{
						return assembly2;
					}
					if (놴녨.TryGetValue(P_1.Name, out var value4))
					{
						return value4.Assembly;
					}
					LoggerManager loggers3 = Core.Instance.Loggers;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(74, 2);
					defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭뇊());
					defaultInterpolatedStringHandler.AppendFormatted(P_1.Name);
					defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭놋());
					defaultInterpolatedStringHandler.AppendFormatted(P_1.RequestingAssembly);
					loggers3.Log(defaultInterpolatedStringHandler.ToStringAndClear());
				}
			}
			catch (Exception ex3)
			{
				Core.Instance.Loggers.Log(ex3);
			}
			return (Assembly?)null;
		};
	}

	/// <summary>
	/// Load types.
	/// </summary>
	/// <param name="folderName">The folder name.</param>
	/// <param name="targetType">The target type.</param>
	/// <param name="assemblyNameFilter">The assembly name filter.</param>
	/// <param name="searchOption">The search option.</param>
	/// <param name="loadInMemory">If true, load in memory.</param>
	/// <param name="allowLoadingReferences">If true, allow loading references.</param>
	/// <returns><![CDATA[List<TypeWrapper>]]></returns>
	public static List<TypeWrapper> LoadTypes(string folderName, Type targetType, string assemblyNameFilter = null, SearchOption searchOption = SearchOption.TopDirectoryOnly, bool loadInMemory = false, bool allowLoadingReferences = false)
	{
		List<TypeWrapper> list = new List<TypeWrapper>();
		try
		{
			foreach (string item in Directory.EnumerateFiles(Path.Combine(Const.EXECUTING_FOLDER, folderName), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놃(), searchOption))
			{
				string fileName = Path.GetFileName(item);
				if (string.IsNullOrEmpty(assemblyNameFilter) || fileName.Contains(assemblyNameFilter))
				{
					List<TypeWrapper> list2 = 녴(item, targetType, loadInMemory, allowLoadingReferences);
					if (list2 != null)
					{
						list.AddRange(list2);
					}
				}
			}
		}
		catch (Exception ex)
		{
			Core.Instance.Loggers.Log(ex);
		}
		return list;
	}

	internal static List<TypeWrapper> 녴(string P_0, Type P_1, bool P_2 = false, bool P_3 = false)
	{
		List<TypeWrapper> list = new List<TypeWrapper>();
		try
		{
			Assembly assembly = (P_2 ? Assembly.Load(File.ReadAllBytes(P_0)) : Assembly.LoadFrom(P_0));
			if (P_3)
			{
				놴녨[assembly.FullName] = new 녴(Path.GetDirectoryName(P_0), assembly);
			}
			foreach (Type exportedType in assembly.ExportedTypes)
			{
				if (!exportedType.IsAbstract && (P_1.IsAssignableFrom(exportedType) || exportedType.GetInterfaces().Contains(P_1)))
				{
					list.Add(new TypeWrapper(exportedType, P_0));
				}
			}
			if (P_3 && list.Any())
			{
				녴(assembly, P_0);
			}
		}
		catch (BadImageFormatException ex)
		{
			Core.Instance.Loggers.Log(ex, null, LoggingLevel.Verbose);
		}
		catch (Exception ex2)
		{
			Core.Instance.Loggers.Log(ex2);
		}
		return list;
	}

	private static void 녴(Assembly P_0, string P_1)
	{
		AssemblyName[] referencedAssemblies = P_0.GetReferencedAssemblies();
		foreach (AssemblyName assemblyName in referencedAssemblies)
		{
			if (assemblyName.Name.Contains(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂뇇()) || 놴념.Contains(assemblyName.Name))
			{
				continue;
			}
			try
			{
				string path = Path.Combine(Path.GetDirectoryName(P_1), assemblyName.Name + _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴뇃());
				if (File.Exists(path))
				{
					Assembly assembly = Assembly.Load(File.ReadAllBytes(path));
					if ((object)assembly != null)
					{
						놴녨[assemblyName.FullName] = new 녴(Path.GetDirectoryName(P_1), assembly);
						녴(assembly, P_1);
					}
				}
			}
			catch (Exception ex)
			{
				Core.Instance.Loggers.Log(ex);
			}
		}
	}

	private static void 녴(string P_0)
	{
		놴놣[P_0] = new Dictionary<string, Assembly>();
		foreach (string item in Directory.EnumerateFiles(P_0, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놃(), SearchOption.AllDirectories))
		{
			try
			{
				Assembly assembly = Assembly.Load(File.ReadAllBytes(item));
				if ((object)assembly != null)
				{
					놴놣[P_0][assembly.FullName] = assembly;
				}
			}
			catch (BadImageFormatException ex)
			{
				Core.Instance.Loggers.Log(ex, null, LoggingLevel.Verbose);
			}
			catch (Exception ex2)
			{
				Core.Instance.Loggers.Log(ex2);
			}
		}
	}

	private static Assembly 녴(string P_0, string P_1)
	{
		if (!놴놣.ContainsKey(P_1))
		{
			녴(P_1);
		}
		if (놴놣.TryGetValue(P_1, out var value) && value.TryGetValue(P_0, out var value2))
		{
			return value2;
		}
		return null;
	}
}
