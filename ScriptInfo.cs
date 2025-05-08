using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;

namespace TradingPlatform.BusinessLayer;

public abstract class ScriptInfo
{
	[CompilerGenerated]
	private ScriptKey 놴놂;

	[CompilerGenerated]
	private ScriptCreationType 놴놎;

	[CompilerGenerated]
	private string 놴녞;

	[CompilerGenerated]
	private string 놴놫;

	[CompilerGenerated]
	private Version 놴녪;

	[CompilerGenerated]
	private List<SettingItem> 놴녶;

	protected ConstructorInfo ctor;

	public ScriptKey Key
	{
		[CompilerGenerated]
		get
		{
			return 놴놂;
		}
		[CompilerGenerated]
		protected set
		{
			놴놂 = value;
		}
	}

	public ScriptCreationType ScriptCreationType
	{
		[CompilerGenerated]
		get
		{
			return 놴놎;
		}
		[CompilerGenerated]
		private set
		{
			놴놎 = value;
		}
	}

	public string Name
	{
		[CompilerGenerated]
		get
		{
			return 놴녞;
		}
		[CompilerGenerated]
		protected set
		{
			놴녞 = value;
		}
	}

	public string Description
	{
		[CompilerGenerated]
		get
		{
			return 놴놫;
		}
		[CompilerGenerated]
		protected set
		{
			놴놫 = value;
		}
	}

	public Version Version
	{
		[CompilerGenerated]
		get
		{
			return 놴녪;
		}
		[CompilerGenerated]
		protected set
		{
			놴녪 = value;
		}
	}

	public List<SettingItem> Settings
	{
		[CompilerGenerated]
		get
		{
			return 놴녶;
		}
		[CompilerGenerated]
		protected set
		{
			놴녶 = value;
		}
	}

	protected ScriptInfo(ConstructorInfo ctor, ScriptCreationType scriptCreationType, string relativePath, string assemblyName)
	{
		this.ctor = ctor;
		ScriptCreationType = scriptCreationType;
		try
		{
			Initialize(relativePath, assemblyName);
		}
		catch (Exception ex)
		{
			Core.Instance.Loggers.Log(ex, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴놳() + assemblyName + _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴놺());
		}
	}

	protected abstract void Initialize(string relativePath, string assemblyName);
}
