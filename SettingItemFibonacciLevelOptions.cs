using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Xml.Linq;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using TradingPlatform.BusinessLayer.Serialization;
using TradingPlatform.BusinessLayer.Utils;

namespace TradingPlatform.BusinessLayer;

public class SettingItemFibonacciLevelOptions : SettingItem
{
	[CompilerGenerated]
	private Font 놃뇇;

	[CompilerGenerated]
	private int 놃놛;

	[CompilerGenerated]
	private decimal 놃놼;

	public override SettingItemType Type => SettingItemType.FibonacciLevelOptions;

	public Font DefaultFont
	{
		[CompilerGenerated]
		get
		{
			return 놃뇇;
		}
		[CompilerGenerated]
		set
		{
			놃뇇 = value;
		}
	}

	public int DecimalPlaces
	{
		[CompilerGenerated]
		get
		{
			return 놃놛;
		}
		[CompilerGenerated]
		set
		{
			놃놛 = value;
		}
	}

	public decimal Increment
	{
		[CompilerGenerated]
		get
		{
			return 놃놼;
		}
		[CompilerGenerated]
		set
		{
			놃놼 = value;
		}
	}

	[DataMember(Name = "Value")]
	private List<FibonacciLevelOptions> ValuelevelOptions
	{
		get
		{
			return Value as List<FibonacciLevelOptions>;
		}
		set
		{
			Value = value;
		}
	}

	public SettingItemFibonacciLevelOptions()
	{
		녴();
	}

	public SettingItemFibonacciLevelOptions(string name, List<FibonacciLevelOptions> value, int sortIndex = 0)
		: base(name, value, sortIndex)
	{
		녴();
	}

	protected SettingItemFibonacciLevelOptions(SettingItemFibonacciLevelOptions settingItem)
		: base(settingItem)
	{
		녴();
	}

	private void 녴()
	{
		DecimalPlaces = 2;
		Increment = 0.01m;
	}

	public override SettingItem GetCopy()
	{
		return new SettingItemFibonacciLevelOptions(this);
	}

	protected override bool IsValueTypeValid(object value)
	{
		return value is List<FibonacciLevelOptions>;
	}

	protected override XElement ValueToXElement()
	{
		XElement xElement = new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰녝());
		foreach (FibonacciLevelOptions valuelevelOption in ValuelevelOptions)
		{
			xElement.Add(valuelevelOption.ToXElement());
		}
		return xElement;
	}

	protected override void ValueFromXElement(XElement element, DeserializationInfo deserializationInfo)
	{
		List<FibonacciLevelOptions> list = new List<FibonacciLevelOptions>();
		foreach (XElement item in element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰녝()).Elements())
		{
			FibonacciLevelOptions fibonacciLevelOptions = CreateFibonaccilevel();
			fibonacciLevelOptions.FromXElement(item, deserializationInfo);
			list.Add(fibonacciLevelOptions);
		}
		Value = list;
	}

	protected virtual FibonacciLevelOptions CreateFibonaccilevel()
	{
		return new FibonacciLevelOptions();
	}
}
