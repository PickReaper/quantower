using System;
using System.Runtime.Serialization;
using System.Xml.Linq;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using TradingPlatform.BusinessLayer.Serialization;

namespace TradingPlatform.BusinessLayer;

/// <summary>
/// Typecasts setting as Password item
/// </summary>
[Serializable]
[DataContract]
public sealed class SettingItemPassword : SettingItem
{
	public override SettingItemType Type => SettingItemType.Password;

	[DataMember(Name = "Value")]
	private PasswordHolder PasswordHolder
	{
		get
		{
			return (PasswordHolder)Value;
		}
		set
		{
			Value = value;
		}
	}

	public SettingItemPassword()
	{
	}

	public SettingItemPassword(string name, PasswordHolder passwordHolder, int sortIndex = 0)
		: base(name, passwordHolder, sortIndex)
	{
	}

	private SettingItemPassword(SettingItemPassword P_0)
		: base(P_0)
	{
	}

	public override SettingItem GetCopy()
	{
		return new SettingItemPassword(this);
	}

	public static implicit operator PasswordHolder(SettingItemPassword item)
	{
		return (PasswordHolder)item.Value;
	}

	protected override bool IsValueTypeValid(object value)
	{
		return value is PasswordHolder;
	}

	protected override void ValueFromXElement(XElement element, DeserializationInfo deserializationInfo)
	{
		PasswordHolder passwordHolder = new PasswordHolder(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놇(), SavePassword: true, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놇());
		XElement xElement = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭놟());
		if (xElement != null)
		{
			passwordHolder.FromXElement(xElement, deserializationInfo);
			PasswordHolder = passwordHolder;
		}
	}

	internal override void 녴(object P_0, bool P_1 = false)
	{
		PasswordHolder passwordHolder = this;
		base.녴(P_0, P_1);
		((PasswordHolder)Value).RecoverUrl = passwordHolder.RecoverUrl;
	}
}
