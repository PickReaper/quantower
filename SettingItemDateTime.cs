using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Xml.Linq;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using ProtoBuf;
using TradingPlatform.BusinessLayer.DataBinding;
using TradingPlatform.BusinessLayer.Serialization;

namespace TradingPlatform.BusinessLayer;

/// <summary>
/// Typecasts setting as DateTimePicker item
/// </summary>
[Serializable]
[DataContract]
public sealed class SettingItemDateTime : SettingItem
{
	private const string 놃뇅 = "ddMMyyyy HH:mm:ss.ffffff";

	[CompilerGenerated]
	private bool 놃놵;

	private DatePickerFormat 놃놡;

	[CompilerGenerated]
	private DateTime 놃놻;

	[CompilerGenerated]
	private DateTime 놃놃;

	public override SettingItemType Type => SettingItemType.DateTime;

	public bool ApplyOnEachInput
	{
		[CompilerGenerated]
		get
		{
			return 놃놵;
		}
		[CompilerGenerated]
		set
		{
			놃놵 = value;
		}
	}

	[Bindable("format")]
	public DatePickerFormat Format
	{
		get
		{
			return 놃놡;
		}
		set
		{
			SetValue(ref 놃놡, value, null, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰녫());
		}
	}

	public DateTime MinDate
	{
		[CompilerGenerated]
		get
		{
			return 놃놻;
		}
		[CompilerGenerated]
		set
		{
			놃놻 = value;
		}
	}

	public DateTime MaxDate
	{
		[CompilerGenerated]
		get
		{
			return 놃놃;
		}
		[CompilerGenerated]
		set
		{
			놃놃 = value;
		}
	}

	[DataMember(Name = "Value")]
	[ProtoMember(1)]
	private DateTime ValueDateTime
	{
		get
		{
			return (DateTime)Value;
		}
		set
		{
			Value = value;
		}
	}

	public SettingItemDateTime()
	{
	}

	public SettingItemDateTime(string name, DateTime value = default(DateTime), int sortIndex = 0)
		: base(name, value, sortIndex)
	{
		Format = DatePickerFormat.DateTime;
		ApplyOnEachInput = false;
		MinDate = DateTime.MinValue;
		MaxDate = DateTime.MaxValue;
	}

	private SettingItemDateTime(SettingItemDateTime P_0)
		: base(P_0)
	{
		Format = P_0.Format;
		ApplyOnEachInput = P_0.ApplyOnEachInput;
		MinDate = P_0.MinDate;
		MaxDate = P_0.MaxDate;
	}

	public override SettingItem GetCopy()
	{
		return new SettingItemDateTime(this);
	}

	public static implicit operator DateTime(SettingItemDateTime item)
	{
		return (DateTime)item.Value;
	}

	protected override bool IsValueTypeValid(object value)
	{
		return value is DateTime;
	}

	protected override XElement ValueToXElement()
	{
		return new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴놯(), ValueDateTime.ToString(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녲뇏(), CultureInfo.InvariantCulture));
	}

	protected override void ValueFromXElement(XElement element, DeserializationInfo deserializationInfo)
	{
		XElement xElement = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴놯());
		if (xElement == null)
		{
			return;
		}
		if (deserializationInfo.Version < 1.3)
		{
			XElement xElement2 = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰뇁());
			if (xElement2 != null && xElement2.Value == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰놧())
			{
				ValueDateTime = xElement.ToDateTime(toUTC: true);
			}
			else
			{
				ValueDateTime = xElement.ToDateTime();
			}
		}
		else
		{
			ValueDateTime = xElement.ToDateTime(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녲뇏());
		}
	}
}
