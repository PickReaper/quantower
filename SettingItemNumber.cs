using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using ProtoBuf;
using TradingPlatform.BusinessLayer.DataBinding;

namespace TradingPlatform.BusinessLayer;

[Serializable]
[KnownType(typeof(SettingItemDouble))]
[KnownType(typeof(SettingItemInteger))]
[KnownType(typeof(SettingItemLong))]
[ProtoInclude(1, typeof(SettingItemDouble))]
[ProtoInclude(2, typeof(SettingItemInteger))]
[ProtoInclude(3, typeof(SettingItemLong))]
[DataContract]
[ProtoContract]
public abstract class SettingItemNumber<T> : SettingItem where T : struct
{
	private T 놃놀;

	private T 놃놔;

	private T 놃놾;

	private string 놃뇀;

	[CompilerGenerated]
	private bool 놃놽;

	[Bindable("maximum")]
	public T Maximum
	{
		get
		{
			return 놃놀;
		}
		set
		{
			SetValue(ref 놃놀, value, null, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰놑());
		}
	}

	[Bindable("minimum")]
	public T Minimum
	{
		get
		{
			return 놃놔;
		}
		set
		{
			SetValue(ref 놃놔, value, null, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰놦());
		}
	}

	[Bindable("increment")]
	public T Increment
	{
		get
		{
			return 놃놾;
		}
		set
		{
			SetValue(ref 놃놾, value, null, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰놐());
		}
	}

	[Bindable("dimension")]
	public string Dimension
	{
		get
		{
			return 놃뇀;
		}
		set
		{
			SetValue(ref 놃뇀, value, null, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰녚());
		}
	}

	public bool UseTradingNumeric
	{
		[CompilerGenerated]
		get
		{
			return 놃놽;
		}
		[CompilerGenerated]
		set
		{
			놃놽 = value;
		}
	}

	public SettingItemNumber()
	{
	}

	public SettingItemNumber(string name, T value, int sortIndex = 0)
		: base(name, value, sortIndex)
	{
	}

	protected SettingItemNumber(SettingItemNumber<T> settingItem)
		: base(settingItem)
	{
		Maximum = settingItem.Maximum;
		Minimum = settingItem.Minimum;
		Increment = settingItem.Increment;
		Dimension = settingItem.Dimension;
		UseTradingNumeric = settingItem.UseTradingNumeric;
	}

	public override bool Equals(SettingItem other)
	{
		if (!base.Equals(other))
		{
			return false;
		}
		if (!(other is SettingItemNumber<T> settingItemNumber))
		{
			return false;
		}
		if (EqualityComparer<T>.Default.Equals(Maximum, settingItemNumber.Maximum) && EqualityComparer<T>.Default.Equals(Minimum, settingItemNumber.Minimum) && EqualityComparer<T>.Default.Equals(Increment, settingItemNumber.Increment) && Dimension == settingItemNumber.Dimension)
		{
			return UseTradingNumeric == settingItemNumber.UseTradingNumeric;
		}
		return false;
	}

	public override int GetHashCode()
	{
		HashCode hashCode = default(HashCode);
		hashCode.Add(base.GetHashCode());
		hashCode.Add(Maximum);
		hashCode.Add(Minimum);
		hashCode.Add(Increment);
		hashCode.Add(Dimension);
		hashCode.Add(UseTradingNumeric);
		return hashCode.ToHashCode();
	}
}
