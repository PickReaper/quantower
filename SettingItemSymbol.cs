using System;
using System.Runtime.Serialization;
using System.Xml.Linq;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using TradingPlatform.BusinessLayer.Serialization;

namespace TradingPlatform.BusinessLayer;

/// <summary>
/// Typecasts setting as SymbolLookup item
/// </summary>
[Serializable]
[DataContract]
public sealed class SettingItemSymbol : SettingItem
{
	public override SettingItemType Type => SettingItemType.Symbol;

	[DataMember(Name = "Value")]
	private BusinessObjectInfo ValueInfo
	{
		get
		{
			return (Value as Symbol)?.CreateInfo() ?? BusinessObjectInfo.Empty;
		}
		set
		{
			if (!(value == BusinessObjectInfo.Empty) && !(value == SymbolInfo.Empty))
			{
				Value = Core.Instance.GetSymbol(value);
			}
		}
	}

	public SettingItemSymbol()
	{
	}

	public SettingItemSymbol(string name, Symbol value = null, int sortIndex = 0)
		: base(name, value, sortIndex)
	{
	}

	private SettingItemSymbol(SettingItemSymbol P_0)
		: base(P_0)
	{
	}

	public override SettingItem GetCopy()
	{
		return new SettingItemSymbol(this);
	}

	public static implicit operator Symbol(SettingItemSymbol item)
	{
		return item.Value as Symbol;
	}

	protected override bool IsValueTypeValid(object value)
	{
		return value is Symbol;
	}

	protected override void ValueFromXElement(XElement element, DeserializationInfo deserializationInfo)
	{
		SymbolInfo empty = SymbolInfo.Empty;
		XElement xElement = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶녬());
		if (xElement != null)
		{
			empty.FromXElement(xElement, deserializationInfo);
			ValueInfo = empty;
		}
	}

	protected override XElement ValueToXElement()
	{
		return ValueInfo.ToXElement();
	}
}
