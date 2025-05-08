using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace TradingPlatform.BusinessLayer;

public class IndicatorInfo : ScriptInfo
{
	[CompilerGenerated]
	private string 녶놙;

	[CompilerGenerated]
	private bool 녶녰;

	[CompilerGenerated]
	private string 녶놚;

	public string Group
	{
		[CompilerGenerated]
		get
		{
			return 녶놙;
		}
		[CompilerGenerated]
		private set
		{
			녶놙 = value;
		}
	}

	public bool IsAvailableInWatchlist
	{
		[CompilerGenerated]
		get
		{
			return 녶녰;
		}
		[CompilerGenerated]
		private set
		{
			녶녰 = value;
		}
	}

	public string ShortName
	{
		[CompilerGenerated]
		get
		{
			return 녶놚;
		}
		[CompilerGenerated]
		private set
		{
			녶놚 = value;
		}
	}

	internal IndicatorInfo(ConstructorInfo P_0, ScriptCreationType P_1, string P_2, string P_3)
		: base(P_0, P_1, P_2, P_3)
	{
	}

	protected override void Initialize(string relativePath, string assemblyName)
	{
		using Indicator indicator = ctor.Invoke(null) as Indicator;
		base.Name = indicator.Name;
		ShortName = 녴(indicator);
		base.Description = indicator.Description;
		base.Version = indicator.Version;
		base.Key = new ScriptKey(base.ScriptCreationType, relativePath, assemblyName, base.Name);
		indicator.Key = base.Key;
		base.Settings = indicator.Settings as List<SettingItem>;
		IsAvailableInWatchlist = indicator is IWatchlistIndicator;
	}

	internal Indicator 녴()
	{
		Indicator indicator = ctor?.Invoke(null) as Indicator;
		if (indicator != null)
		{
			indicator.Key = base.Key;
		}
		return indicator;
	}

	public override string ToString()
	{
		return base.Name;
	}

	private string 녴(Indicator P_0)
	{
		if (string.IsNullOrEmpty(P_0.ShortName))
		{
			return string.Empty;
		}
		int num = P_0.ShortName.IndexOf('(');
		if (num == -1)
		{
			return P_0.ShortName;
		}
		return P_0.ShortName.Substring(0, num).TrimEnd();
	}
}
