using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;

namespace TradingPlatform.BusinessLayer;

public struct ScriptKey
{
	[Serializable]
	[CompilerGenerated]
	private sealed class 녴
	{
		public static readonly 녴 녶놱 = new 녴();

		public static Func<DescriptionAttribute, string> 녶놖;

		internal string 녴(DescriptionAttribute P_0)
		{
			return P_0.Description;
		}
	}

	[CompilerGenerated]
	private string[] 놴녵;

	[CompilerGenerated]
	private ScriptCreationType 놴놭;

	[CompilerGenerated]
	private string 놴녲;

	[CompilerGenerated]
	private string 놴뇋;

	[CompilerGenerated]
	private string 놴놸;

	private const string 놴놿 = "|";

	public string[] FoldersHierarchy
	{
		[CompilerGenerated]
		readonly get
		{
			return 놴녵;
		}
		[CompilerGenerated]
		private set
		{
			놴녵 = value;
		}
	}

	internal ScriptCreationType ScriptCreationType
	{
		[CompilerGenerated]
		readonly get
		{
			return 놴놭;
		}
		[CompilerGenerated]
		private set
		{
			놴놭 = value;
		}
	}

	internal string RelativePath
	{
		[CompilerGenerated]
		readonly get
		{
			return 놴녲;
		}
		[CompilerGenerated]
		private set
		{
			놴녲 = value;
		}
	}

	internal string AssemblyName
	{
		[CompilerGenerated]
		readonly get
		{
			return 놴뇋;
		}
		[CompilerGenerated]
		private set
		{
			놴뇋 = value;
		}
	}

	internal string ScriptName
	{
		[CompilerGenerated]
		readonly get
		{
			return 놴놸;
		}
		[CompilerGenerated]
		private set
		{
			놴놸 = value;
		}
	}

	public ScriptKey(ScriptCreationType scriptCreationType, string relativePath, string assemblyName, string scriptName)
	{
		this = default(ScriptKey);
		ScriptCreationType = scriptCreationType;
		RelativePath = relativePath;
		AssemblyName = assemblyName;
		ScriptName = scriptName;
		FoldersHierarchy = relativePath.Split(new char[1] { Path.DirectorySeparatorChar }, StringSplitOptions.RemoveEmptyEntries);
	}

	public override bool Equals(object obj)
	{
		ScriptKey scriptKey = (ScriptKey)obj;
		if (ScriptName != scriptKey.ScriptName)
		{
			return false;
		}
		if (AssemblyName != scriptKey.AssemblyName)
		{
			return false;
		}
		if (RelativePath != scriptKey.RelativePath)
		{
			return false;
		}
		if (ScriptCreationType != scriptKey.ScriptCreationType)
		{
			return false;
		}
		return true;
	}

	public override int GetHashCode()
	{
		return ((((((0x50C5D1F ^ ScriptCreationType.GetHashCode()) * 16777619) ^ (RelativePath ?? string.Empty).GetHashCode()) * 16777619) ^ (AssemblyName ?? string.Empty).GetHashCode()) * 16777619) ^ (ScriptName ?? string.Empty).GetHashCode();
	}

	public static bool operator !=(ScriptKey key1, ScriptKey key2)
	{
		return !key1.Equals(key2);
	}

	public static bool operator ==(ScriptKey key1, ScriptKey key2)
	{
		return key1.Equals(key2);
	}

	public static ScriptKey CreateScriptKeyFromString(string stringKey)
	{
		string[] array = stringKey.Split(new string[1] { _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴놅() }, StringSplitOptions.None);
		if (array.Length != 4 || !array[0].TryParseEnum<ScriptCreationType, DescriptionAttribute>((DescriptionAttribute P_0) => P_0.Description, out var enumValue))
		{
			return default(ScriptKey);
		}
		return new ScriptKey(enumValue, array[1], array[2], array[3]);
	}

	public override string ToString()
	{
		return $"{ScriptCreationType.GetDescription()}{_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴놅()}{RelativePath}{_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴놅()}{AssemblyName}{_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴놅()}{ScriptName}";
	}
}
