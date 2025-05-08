using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using 녴;

namespace TradingPlatform.BusinessLayer;

public static class loc
{
	private const string 놂놵 = "CoreLocarizer";

	public const string HIDDEN = "#hidden#";

	private static 놓 놂놡;

	private static Dictionary<string, 놓> 놂놻 = new Dictionary<string, 놓>();

	private static CultureInfo DefaultCultureInfo => CultureInfo.CurrentUICulture;

	private static CultureInfo TerminalCultureInfo => CultureInfo.DefaultThreadCurrentUICulture;

	/// <summary>
	///
	/// </summary>
	public static void OnLocaleChanged()
	{
		foreach (놓 value in 놂놻.Values)
		{
			value.녴(TerminalCultureInfo);
		}
		놂놡?.녴(TerminalCultureInfo);
	}

	private static 놰 녴(string P_0, string P_1)
	{
		return new 놰
		{
			DirectoryPath = Path.GetDirectoryName(P_0),
			Name = P_1
		};
	}

	/// <summary>
	/// Чисто, як маркер для парсера xgettext.exe
	/// </summary>
	/// <param name="text"></param>
	/// <returns></returns>
	public static string key(string text)
	{
		return text;
	}

	public static string _(string text, string pluginFolderName = null, [CallerFilePath] string callerFilePath = null)
	{
		if (string.IsNullOrWhiteSpace(text))
		{
			return string.Empty;
		}
		string empty = string.Empty;
		string text2 = text;
		empty = ((!string.IsNullOrWhiteSpace(pluginFolderName)) ? pluginFolderName : 녴(callerFilePath));
		if (!string.IsNullOrWhiteSpace(empty))
		{
			if (놂놻.ContainsKey(empty) && 놂놻[empty].Catalog.Translations.ContainsKey(text))
			{
				text2 = 놂놻[empty].Catalog.GetString(text);
			}
			if (!text2.Equals(text))
			{
				return text2;
			}
		}
		if (놂놡 != null && 놂놡.Catalog.Translations.ContainsKey(text))
		{
			text2 = 놂놡.Catalog.GetString(text);
		}
		return text2;
	}

	/// <summary>
	/// Check, whether current translation equal to hidden
	/// </summary>        
	public static bool IsHidden(string text, string pluginFolderName = null, [CallerFilePath] string callerFilePath = null)
	{
		try
		{
			if (string.IsNullOrWhiteSpace(text))
			{
				return false;
			}
			if (text == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놧())
			{
				return true;
			}
			string empty = string.Empty;
			bool flag = false;
			empty = ((!string.IsNullOrWhiteSpace(pluginFolderName)) ? pluginFolderName : 녴(callerFilePath));
			if (!string.IsNullOrWhiteSpace(empty))
			{
				if (놂놻.ContainsKey(empty) && 놂놻[empty].CatalogEN.Translations.ContainsKey(text))
				{
					flag = 놂놻[empty].CatalogEN.GetString(text) == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놧();
				}
				if (flag)
				{
					return flag;
				}
			}
			if (놂놡 != null && 놂놡.CatalogEN.Translations.ContainsKey(text))
			{
				flag = 놂놡.CatalogEN.GetString(text) == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놧();
			}
			return flag;
		}
		catch
		{
			return false;
		}
	}

	private static string 녴(string P_0)
	{
		if (P_0 == null)
		{
			return string.Empty;
		}
		foreach (string item in Path.GetDirectoryName(P_0).Split(Path.DirectorySeparatorChar).Reverse())
		{
			if (놂놻.ContainsKey(item))
			{
				return item;
			}
		}
		return string.Empty;
	}

	/// <summary>
	///
	/// </summary>
	/// <param name="pluginName"></param>
	public static void UnRegisterPlugin(string pluginName)
	{
		if (놂놻.ContainsKey(pluginName))
		{
			놓 놓 = 놂놻[pluginName];
			놓.놴();
			if (놓.AttachedPluginCounter <= 0)
			{
				놂놻.Remove(pluginName);
			}
		}
	}

	/// <summary>
	///
	/// </summary>
	/// <param name="pluginName"></param>
	/// <param name="location"></param>
	public static void RegisterPlugin(string pluginName, string location)
	{
		if (!놂놻.ContainsKey(pluginName))
		{
			놰 놰 = 녴(location, pluginName);
			놂놻[pluginName] = new 놓(TerminalCultureInfo ?? DefaultCultureInfo, 놰);
		}
	}

	/// <summary>
	///
	/// </summary>
	public static void InitializeCoreLocalizer()
	{
		놰 놰 = 녴(Assembly.GetCallingAssembly().Location, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂녝());
		놂놡 = new 놓(TerminalCultureInfo ?? DefaultCultureInfo, 놰);
	}
}
