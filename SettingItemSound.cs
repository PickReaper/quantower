using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Linq;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using TradingPlatform.BusinessLayer.Serialization;
using TradingPlatform.BusinessLayer.Utils.Sounds;

namespace TradingPlatform.BusinessLayer;

[Serializable]
[DataContract]
public class SettingItemSound : SettingItem
{
	public bool EnableSounds;

	public override SettingItemType Type => SettingItemType.Sound;

	[DataMember(Name = "Value")]
	private Dictionary<string, SoundItem> ValuDictionrary
	{
		get
		{
			return value as Dictionary<string, SoundItem>;
		}
		set
		{
			base.value = value;
		}
	}

	public SettingItemSound()
	{
	}

	public SettingItemSound(string name, Dictionary<string, SoundItem> value, bool enableSounds = true, int sortIndex = 0)
		: base(name, value, sortIndex)
	{
		EnableSounds = enableSounds;
	}

	private SettingItemSound(SettingItemSound P_0)
		: base(P_0)
	{
		EnableSounds = P_0.EnableSounds;
	}

	public override SettingItem GetCopy()
	{
		return new SettingItemSound(this);
	}

	protected override bool IsValueTypeValid(object value)
	{
		return value is Dictionary<string, SoundItem>;
	}

	protected override XElement ValueToXElement()
	{
		XElement xElement = new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴놯());
		xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰농(), EnableSounds));
		foreach (KeyValuePair<string, SoundItem> item in ValuDictionrary)
		{
			xElement.Add(item.Value.ToXElement());
		}
		return xElement;
	}

	protected override void ValueFromXElement(XElement element, DeserializationInfo deserializationInfo)
	{
		XElement xElement = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴놯());
		EnableSounds = xElement.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰농()).ToBool();
		Dictionary<string, SoundItem> dictionary = new Dictionary<string, SoundItem>();
		foreach (XElement item in xElement.Elements(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녲뇊()))
		{
			SoundItem soundItem = new SoundItem();
			soundItem.FromXElement(item, deserializationInfo);
			dictionary[soundItem.Name] = soundItem;
		}
		ValuDictionrary = dictionary;
	}
}
