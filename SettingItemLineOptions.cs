using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Xml.Linq;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using TradingPlatform.BusinessLayer.Serialization;
using TradingPlatform.BusinessLayer.Utils;

namespace TradingPlatform.BusinessLayer;

[Serializable]
[DataContract]
public class SettingItemLineOptions : SettingItem
{
	[CompilerGenerated]
	private LineStyle[] 놃녦;

	public override SettingItemType Type => SettingItemType.LineOptions;

	public LineStyle[] ExcludedStyles
	{
		[CompilerGenerated]
		get
		{
			return 놃녦;
		}
		[CompilerGenerated]
		set
		{
			놃녦 = value;
		}
	}

	[DataMember(Name = "Value")]
	private LineOptions ValueColor
	{
		get
		{
			return (LineOptions)Value;
		}
		set
		{
			Value = value;
		}
	}

	public SettingItemLineOptions()
	{
	}

	public SettingItemLineOptions(string name, LineOptions value, int sortIndex = 0)
		: base(name, value?.Clone(), sortIndex)
	{
	}

	private SettingItemLineOptions(SettingItemLineOptions P_0)
		: base(P_0)
	{
		if (P_0.Value is ICloneable cloneable)
		{
			value = cloneable.Clone() as LineOptions;
		}
		ExcludedStyles = P_0.ExcludedStyles;
	}

	public override SettingItem GetCopy()
	{
		return new SettingItemLineOptions(this);
	}

	protected override bool IsValueTypeValid(object value)
	{
		return value is LineOptions;
	}

	protected override object ValidateValue(object value)
	{
		LineOptions lineOptions = (LineOptions)value;
		LineStyle[] excludedStyles = ExcludedStyles;
		if (excludedStyles != null && excludedStyles.Contains(lineOptions.LineStyle))
		{
			throw new ArgumentException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰뇈());
		}
		return base.ValidateValue(value);
	}

	protected override void ValueFromXElement(XElement element, DeserializationInfo deserializationInfo)
	{
		LineOptions lineOptions = new LineOptions();
		XElement element2 = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녲녨());
		lineOptions.FromXElement(element2, deserializationInfo);
		ValueColor = lineOptions;
	}
}
