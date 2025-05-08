using System;
using System.Globalization;
using System.Runtime.Serialization;
using System.Xml.Linq;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using ProtoBuf;
using TradingPlatform.BusinessLayer.DataBinding;
using TradingPlatform.BusinessLayer.Serialization;

namespace TradingPlatform.BusinessLayer;

/// <summary>
/// Typecasts setting as NumericUpDown item
/// </summary>
[Serializable]
[Published]
[DataContract]
[ProtoContract]
public class SettingItemDouble : SettingItemNumber<double>
{
	private int 놴놳;

	public override SettingItemType Type => SettingItemType.Double;

	[Bindable("decimalPlaces")]
	public int DecimalPlaces
	{
		get
		{
			return 놴놳;
		}
		set
		{
			SetValue(ref 놴놳, value, null, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴놥());
		}
	}

	[DataMember(Name = "Value")]
	[ProtoMember(1)]
	private double ValueDouble
	{
		get
		{
			return (double)value;
		}
		set
		{
			base.value = value;
		}
	}

	public SettingItemDouble()
	{
	}

	public SettingItemDouble(string name, double value, int sortIndex = 0)
		: base(name, value, sortIndex)
	{
		base.Maximum = 2147483647.0;
		base.Minimum = -2147483648.0;
		DecimalPlaces = 0;
		base.Increment = 1.0;
	}

	private protected SettingItemDouble(SettingItemDouble P_0)
		: base((SettingItemNumber<double>)P_0)
	{
		DecimalPlaces = P_0.DecimalPlaces;
	}

	[NotPublished]
	public override SettingItem GetCopy()
	{
		return new SettingItemDouble(this);
	}

	[NotPublished]
	public static implicit operator double(SettingItemDouble item)
	{
		return (double)item.Value;
	}

	[NotPublished]
	protected override bool IsValueTypeValid(object value)
	{
		return value is double;
	}

	[NotPublished]
	protected override object ValidateValue(object value)
	{
		value = base.ValidateValue(value);
		double num = (double)value;
		if (double.IsNaN(num))
		{
			num = 0.0;
		}
		else if (num > base.Maximum)
		{
			num = base.Maximum;
		}
		else if (num < base.Minimum)
		{
			num = base.Minimum;
		}
		else if (base.Increment != 0.0)
		{
			num -= (double)((decimal)num % (decimal)base.Increment);
		}
		return num;
	}

	[NotPublished]
	protected override XElement ValueToXElement()
	{
		return new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴놯(), ValueDouble.ToString(CultureInfo.InvariantCulture));
	}

	[NotPublished]
	protected override void ValueFromXElement(XElement element, DeserializationInfo deserializationInfo)
	{
		XElement xElement = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴놯());
		if (xElement != null)
		{
			ValueDouble = xElement.ToDouble();
		}
	}

	public override bool Equals(SettingItem other)
	{
		if (!base.Equals(other))
		{
			return false;
		}
		if (!(other is SettingItemDouble settingItemDouble))
		{
			return false;
		}
		return DecimalPlaces == settingItemDouble.DecimalPlaces;
	}

	public override int GetHashCode()
	{
		HashCode hashCode = default(HashCode);
		hashCode.Add(base.GetHashCode());
		hashCode.Add(DecimalPlaces);
		return hashCode.ToHashCode();
	}
}
