using System;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using TradingPlatform.BusinessLayer.DataBinding;

namespace TradingPlatform.BusinessLayer;

public class SettingItemDoubleWithLink : SettingItemDouble
{
	private string 녵녡;

	[CompilerGenerated]
	private Action<object> 녵녦;

	public override SettingItemType Type => SettingItemType.DoubleWithLink;

	[Bindable("linkText")]
	public string LinkText
	{
		get
		{
			return 녵녡;
		}
		set
		{
			SetValue(ref 녵녡, value, null, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭놠());
		}
	}

	public Action<object> LinkAction
	{
		[CompilerGenerated]
		get
		{
			return 녵녦;
		}
		[CompilerGenerated]
		set
		{
			녵녦 = value;
		}
	}

	public SettingItemDoubleWithLink()
	{
	}

	public SettingItemDoubleWithLink(string name, double value, Action<object> linkAction, int sortIndex = 0)
		: base(name, value, sortIndex)
	{
		LinkAction = linkAction;
	}

	private SettingItemDoubleWithLink(SettingItemDoubleWithLink P_0)
		: base(P_0)
	{
		LinkText = P_0.LinkText;
		LinkAction = P_0.LinkAction;
	}

	public override SettingItem GetCopy()
	{
		return new SettingItemDoubleWithLink(this);
	}
}
