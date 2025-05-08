using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Xml.Linq;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using ProtoBuf;
using TradingPlatform.BusinessLayer.Serialization;

namespace TradingPlatform.BusinessLayer;

/// <summary>
/// Typecasts setting as Period item
/// </summary>
[Serializable]
[Published]
[DataContract]
[ProtoContract]
public sealed class SettingItemPeriod : SettingItem
{
	[CompilerGenerated]
	private int 놃놲;

	[CompilerGenerated]
	private int 놃높;

	[CompilerGenerated]
	private BasePeriod[] 놃놶;

	public override SettingItemType Type => SettingItemType.Period;

	public int MultiplierMinimum
	{
		[CompilerGenerated]
		get
		{
			return 놃놲;
		}
		[CompilerGenerated]
		set
		{
			놃놲 = value;
		}
	}

	public int MultiplierMaximum
	{
		[CompilerGenerated]
		get
		{
			return 놃높;
		}
		[CompilerGenerated]
		set
		{
			놃높 = value;
		}
	}

	public BasePeriod[] ExcludedPeriods
	{
		[CompilerGenerated]
		get
		{
			return 놃놶;
		}
		[CompilerGenerated]
		set
		{
			놃놶 = value;
		}
	}

	[DataMember(Name = "Value")]
	[ProtoMember(1)]
	private Period ValuePeriod
	{
		get
		{
			if (value != null)
			{
				return (Period)value;
			}
			return default(Period);
		}
		set
		{
			base.value = value;
		}
	}

	public SettingItemPeriod()
	{
	}

	public SettingItemPeriod(string name, Period value, int sortIndex = 0)
		: base(name, value, sortIndex)
	{
		MultiplierMinimum = 1;
		MultiplierMaximum = int.MaxValue;
	}

	private SettingItemPeriod(SettingItemPeriod P_0)
		: base(P_0)
	{
		MultiplierMinimum = P_0.MultiplierMinimum;
		MultiplierMaximum = P_0.MultiplierMaximum;
		ExcludedPeriods = P_0.ExcludedPeriods;
	}

	[NotPublished]
	public override SettingItem GetCopy()
	{
		return new SettingItemPeriod(this);
	}

	[NotPublished]
	public static implicit operator Period(SettingItemPeriod item)
	{
		return (Period)item.Value;
	}

	[NotPublished]
	protected override bool IsValueTypeValid(object value)
	{
		return value is Period;
	}

	[NotPublished]
	protected override object ValidateValue(object value)
	{
		Period period = (Period)value;
		if (period.PeriodMultiplier < MultiplierMinimum)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(17, 3);
			defaultInterpolatedStringHandler.AppendFormatted(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰놥());
			defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰놯());
			defaultInterpolatedStringHandler.AppendFormatted(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰녾());
			defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂());
			defaultInterpolatedStringHandler.AppendFormatted(MultiplierMinimum);
			throw new ArgumentException(defaultInterpolatedStringHandler.ToStringAndClear());
		}
		if (period.PeriodMultiplier > MultiplierMaximum)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(17, 3);
			defaultInterpolatedStringHandler.AppendFormatted(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰놥());
			defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰녬());
			defaultInterpolatedStringHandler.AppendFormatted(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰녹());
			defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂());
			defaultInterpolatedStringHandler.AppendFormatted(MultiplierMaximum);
			throw new ArgumentException(defaultInterpolatedStringHandler.ToStringAndClear());
		}
		BasePeriod[] excludedPeriods = ExcludedPeriods;
		if (excludedPeriods != null && excludedPeriods.Contains(period.BasePeriod))
		{
			throw new ArgumentException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰녔());
		}
		return value;
	}

	[NotPublished]
	protected override XElement ValueToXElement()
	{
		XElement xElement = new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇁());
		xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴놯(), ((IXElementSerialization)Value).ToXElement()));
		return xElement;
	}

	[NotPublished]
	protected override void ValueFromXElement(XElement element, DeserializationInfo deserializationInfo)
	{
		XElement xElement = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇁());
		if (xElement != null)
		{
			XElement xElement2 = xElement.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴놯());
			if (xElement2 != null)
			{
				Period period = default(Period);
				period.FromXElement(xElement2.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇁()), deserializationInfo);
				value = period;
			}
		}
	}
}
