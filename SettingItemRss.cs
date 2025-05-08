using System;
using System.Runtime.Serialization;
using System.Xml.Linq;
using TradingPlatform.BusinessLayer.Serialization;
using TradingPlatform.BusinessLayer.Utils;

namespace TradingPlatform.BusinessLayer;

[Serializable]
[DataContract]
public sealed class SettingItemRss : SettingItem
{
	public override SettingItemType Type => SettingItemType.Rss;

	[DataMember(Name = "Value")]
	private Rss ValueRss
	{
		get
		{
			return Value as Rss;
		}
		set
		{
			Value = value;
		}
	}

	public SettingItemRss()
	{
	}

	public SettingItemRss(string name, Rss value, int sortIndex = 0)
		: base(name, value, sortIndex)
	{
	}

	private SettingItemRss(SettingItemRss P_0)
		: base(P_0)
	{
	}

	public override SettingItem GetCopy()
	{
		return new SettingItemRss(this);
	}

	protected override bool IsValueTypeValid(object value)
	{
		return value is Rss;
	}

	protected override void ValueFromXElement(XElement element, DeserializationInfo deserializationInfo)
	{
		Rss rss = new Rss();
		rss.FromXElement(element, deserializationInfo);
		Value = rss;
	}
}
