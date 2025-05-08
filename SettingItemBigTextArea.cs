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
public sealed class SettingItemBigTextArea : SettingItem
{
	[CompilerGenerated]
	private string 놃녶;

	[CompilerGenerated]
	private string 놃녵;

	public override SettingItemType Type => SettingItemType.BigTextArea;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return 놃녶;
		}
		[CompilerGenerated]
		set
		{
			놃녶 = value;
		}
	}

	public string HelpLinkTitle
	{
		[CompilerGenerated]
		get
		{
			return 놃녵;
		}
		[CompilerGenerated]
		set
		{
			놃녵 = value;
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

	public SettingItemBigTextArea()
	{
	}

	public SettingItemBigTextArea(string name, string value, int sortIndex = 0)
		: base(name, value, sortIndex)
	{
	}

	private SettingItemBigTextArea(SettingItemBigTextArea P_0)
		: base(P_0)
	{
	}

	public override SettingItem GetCopy()
	{
		return new SettingItemBigTextArea(this);
	}

	public static implicit operator string(SettingItemBigTextArea item)
	{
		return item.Value as string;
	}

	protected override bool IsValueTypeValid(object value)
	{
		return value is string;
	}
}
