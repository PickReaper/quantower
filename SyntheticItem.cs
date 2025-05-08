using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;

namespace TradingPlatform.BusinessLayer;

public sealed class SyntheticItem : ICloneable, ICustomizable
{
	[CompilerGenerated]
	private Symbol 놫녭;

	[CompilerGenerated]
	private double 놫녱;

	[CompilerGenerated]
	private double 놫놲;

	[CompilerGenerated]
	private string 놫높;

	public Symbol Symbol
	{
		[CompilerGenerated]
		get
		{
			return 놫녭;
		}
		[CompilerGenerated]
		set
		{
			놫녭 = value;
		}
	}

	public double Coefficient
	{
		[CompilerGenerated]
		get
		{
			return 놫녱;
		}
		[CompilerGenerated]
		set
		{
			놫녱 = value;
		}
	}

	public double TradeRatio
	{
		[CompilerGenerated]
		get
		{
			return 놫놲;
		}
		[CompilerGenerated]
		set
		{
			놫놲 = value;
		}
	}

	public string TradeComment
	{
		[CompilerGenerated]
		get
		{
			return 놫높;
		}
		[CompilerGenerated]
		set
		{
			놫높 = value;
		}
	}

	public IList<SettingItem> Settings
	{
		get
		{
			return new List<SettingItem>
			{
				new SettingItemSymbol(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶놅(), Symbol),
				new SettingItemDouble(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶녜(), Coefficient),
				new SettingItemDouble(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶뇃(), TradeRatio)
			};
		}
		set
		{
			if (value.GetItemByName(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶놅()) is SettingItemSymbol settingItemSymbol)
			{
				Symbol = settingItemSymbol.Value as Symbol;
			}
			if (value.GetItemByName(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶녜()) is SettingItemDouble settingItemDouble)
			{
				Coefficient = (double)settingItemDouble.Value;
			}
			if (value.GetItemByName(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶뇃()) is SettingItemDouble settingItemDouble2)
			{
				TradeRatio = (double)settingItemDouble2.Value;
			}
		}
	}

	public SyntheticItem()
	{
		Coefficient = 1.0;
		TradeRatio = 1.0;
		TradeComment = null;
	}

	public SyntheticItem(SyntheticItem syntheticItem)
	{
		Symbol = syntheticItem.Symbol;
		Coefficient = syntheticItem.Coefficient;
		TradeRatio = syntheticItem.TradeRatio;
		TradeComment = syntheticItem.TradeComment;
	}

	public override string ToString()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
		defaultInterpolatedStringHandler.AppendFormatted(Coefficient);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶놺());
		defaultInterpolatedStringHandler.AppendFormatted(Symbol?.Name);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	public object Clone()
	{
		return new SyntheticItem(this);
	}
}
