using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using ProtoBuf;

namespace TradingPlatform.BusinessLayer;

/// <summary>
/// Typecasts setting as TextBox item
/// </summary>
[Serializable]
[Published]
[DataContract]
[ProtoContract]
public sealed class SettingItemString : SettingItem
{
	[CompilerGenerated]
	private bool 놃뇎;

	public override SettingItemType Type => SettingItemType.String;

	public bool ApplyOnEachInput
	{
		[CompilerGenerated]
		get
		{
			return 놃뇎;
		}
		[CompilerGenerated]
		set
		{
			놃뇎 = value;
		}
	}

	[DataMember(Name = "Value")]
	[ProtoMember(1)]
	private string ValueString
	{
		get
		{
			return Value as string;
		}
		set
		{
			Value = value;
		}
	}

	public SettingItemString()
	{
	}

	public SettingItemString(string name, string value, int sortIndex = 0)
		: base(name, value, sortIndex)
	{
	}

	private SettingItemString(SettingItemString P_0)
		: base(P_0)
	{
	}

	[NotPublished]
	public static implicit operator string(SettingItemString item)
	{
		return item.Value as string;
	}

	[NotPublished]
	public override SettingItem GetCopy()
	{
		return new SettingItemString(this);
	}

	[NotPublished]
	protected override bool IsValueTypeValid(object value)
	{
		return value is string;
	}
}
