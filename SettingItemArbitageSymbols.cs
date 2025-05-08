using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Xml.Linq;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using TradingPlatform.BusinessLayer.Serialization;
using TradingPlatform.BusinessLayer.Utils;

namespace TradingPlatform.BusinessLayer;

[Serializable]
[DataContract]
public class SettingItemArbitageSymbols : SettingItem
{
	[CompilerGenerated]
	private ArbitrageSymbol 놃놴;

	[CompilerGenerated]
	private decimal 놃놂;

	[CompilerGenerated]
	private decimal 놃놎;

	[CompilerGenerated]
	private ArbitrageSymbol 놃녞;

	[CompilerGenerated]
	private ArbitrageSymbol 놃놫;

	[CompilerGenerated]
	private ArbitrageSymbol 놃녪;

	[DataMember(Name = "Value")]
	private List<ArbitrageSymbol> ArbitrageSymbols
	{
		get
		{
			return Value as List<ArbitrageSymbol>;
		}
		set
		{
			Value = value;
		}
	}

	public override SettingItemType Type => SettingItemType.ArbitageSymbols;

	public ArbitrageSymbol FirstArbitrageSymbol
	{
		[CompilerGenerated]
		get
		{
			return 놃놴;
		}
		[CompilerGenerated]
		set
		{
			놃놴 = value;
		}
	}

	public decimal BaseMaxTradingQuantity
	{
		[CompilerGenerated]
		get
		{
			return 놃놂;
		}
		[CompilerGenerated]
		set
		{
			놃놂 = value;
		}
	}

	public decimal QuotingMaxTradingQuantity
	{
		[CompilerGenerated]
		get
		{
			return 놃놎;
		}
		[CompilerGenerated]
		set
		{
			놃놎 = value;
		}
	}

	public ArbitrageSymbol AddedSymbol
	{
		[CompilerGenerated]
		get
		{
			return 놃녞;
		}
		[CompilerGenerated]
		set
		{
			놃녞 = value;
		}
	}

	public ArbitrageSymbol RemovedSymbol
	{
		[CompilerGenerated]
		get
		{
			return 놃놫;
		}
		[CompilerGenerated]
		set
		{
			놃놫 = value;
		}
	}

	public ArbitrageSymbol ModifiedSymbol
	{
		[CompilerGenerated]
		get
		{
			return 놃녪;
		}
		[CompilerGenerated]
		set
		{
			놃녪 = value;
		}
	}

	public SettingItemArbitageSymbols()
	{
	}

	public SettingItemArbitageSymbols(string name, List<ArbitrageSymbol> symbols, int sortIndex = 0)
		: base(name, symbols, sortIndex)
	{
		BaseMaxTradingQuantity = 0m;
		QuotingMaxTradingQuantity = 0m;
	}

	private SettingItemArbitageSymbols(SettingItemArbitageSymbols P_0)
		: base(P_0)
	{
		BaseMaxTradingQuantity = P_0.BaseMaxTradingQuantity;
		QuotingMaxTradingQuantity = P_0.QuotingMaxTradingQuantity;
	}

	public override SettingItem GetCopy()
	{
		return new SettingItemArbitageSymbols(this);
	}

	protected override bool IsValueTypeValid(object value)
	{
		return value is List<ArbitrageSymbol>;
	}

	public override void FromXElement(XElement element, DeserializationInfo deserializationInfo)
	{
		XElement xElement = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰놅());
		if (xElement != null)
		{
			BaseMaxTradingQuantity = xElement.ToDecimal();
		}
		XElement xElement2 = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰녜());
		if (xElement2 != null)
		{
			QuotingMaxTradingQuantity = xElement2.ToDecimal();
		}
		base.FromXElement(element, deserializationInfo);
	}

	protected override void ValueFromXElement(XElement element, DeserializationInfo deserializationInfo)
	{
		List<ArbitrageSymbol> list = new List<ArbitrageSymbol>();
		IEnumerable<XElement> enumerable = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰뇃()).Elements();
		if (enumerable != null)
		{
			foreach (XElement item in enumerable)
			{
				ArbitrageSymbol arbitrageSymbol = new ArbitrageSymbol();
				arbitrageSymbol.FromXElement(item, deserializationInfo);
				list.Add(arbitrageSymbol);
			}
		}
		Value = list;
		base.ValueFromXElement(element, deserializationInfo);
	}

	public override XElement ToXElement()
	{
		XElement xElement = base.ToXElement();
		xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰놅(), BaseMaxTradingQuantity));
		xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰녜(), QuotingMaxTradingQuantity));
		return xElement;
	}

	protected override XElement ValueToXElement()
	{
		XElement xElement = new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰뇃());
		foreach (ArbitrageSymbol arbitrageSymbol in ArbitrageSymbols)
		{
			xElement.Add(arbitrageSymbol.ToXElement());
		}
		return xElement;
	}
}
