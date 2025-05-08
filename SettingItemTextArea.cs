using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using ProtoBuf;

namespace TradingPlatform.BusinessLayer;

/// <summary>
/// Typecasts setting as TextBox item
/// </summary>
[Serializable]
[DataContract]
[ProtoContract]
public sealed class SettingItemTextArea : SettingItem
{
	[CompilerGenerated]
	private bool 놃놷;

	public override SettingItemType Type => SettingItemType.TextArea;

	public bool ApplyOnEachInput
	{
		[CompilerGenerated]
		get
		{
			return 놃놷;
		}
		[CompilerGenerated]
		set
		{
			놃놷 = value;
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

	public SettingItemTextArea()
	{
	}

	public SettingItemTextArea(string name, string value, int sortIndex = 0)
		: base(name, value, sortIndex)
	{
	}

	private SettingItemTextArea(SettingItemTextArea P_0)
		: base(P_0)
	{
	}

	public override SettingItem GetCopy()
	{
		return new SettingItemTextArea(this);
	}

	public static implicit operator string(SettingItemTextArea item)
	{
		return item.Value as string;
	}

	protected override bool IsValueTypeValid(object value)
	{
		return value is string;
	}
}
