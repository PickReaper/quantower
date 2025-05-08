using System;
using System.Runtime.Serialization;
using System.Xml.Linq;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using TradingPlatform.BusinessLayer.Serialization;
using 녴;

namespace TradingPlatform.BusinessLayer;

/// <summary>
/// Typecasts setting as AccountLookup item
/// </summary>
[Serializable]
[DataContract]
public sealed class SettingItemAccount : SettingItem
{
	public override SettingItemType Type => SettingItemType.Account;

	[DataMember(Name = "Value")]
	private BusinessObjectInfo ValueInfo
	{
		get
		{
			return (Value as Account)?.CreateInfo() ?? BusinessObjectInfo.Empty;
		}
		set
		{
			Value = Core.Instance.GetAccount(value);
		}
	}

	public SettingItemAccount()
	{
	}

	public SettingItemAccount(string name, Account value = null, int sortIndex = 0)
		: base(name, value, sortIndex)
	{
	}

	private SettingItemAccount(SettingItemAccount P_0)
		: base(P_0)
	{
	}

	public override SettingItem GetCopy()
	{
		return new SettingItemAccount(this);
	}

	public static implicit operator Account(SettingItemAccount item)
	{
		return item.Value as Account;
	}

	protected override bool IsValueTypeValid(object value)
	{
		return value is Account;
	}

	protected override void ValueFromXElement(XElement element, DeserializationInfo deserializationInfo)
	{
		놅 놅 = new 놅();
		XElement xElement = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶녬());
		if (xElement != null)
		{
			놅.FromXElement(xElement, deserializationInfo);
			if (!string.IsNullOrEmpty(놅.Id))
			{
				ValueInfo = 놅;
			}
		}
	}

	protected override XElement ValueToXElement()
	{
		return ValueInfo.ToXElement();
	}
}
