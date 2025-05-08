using System;
using System.Runtime.CompilerServices;

namespace TradingPlatform.BusinessLayer;

[Serializable]
public class SelectItem : IEquatable<SelectItem>
{
	[CompilerGenerated]
	private string 놴놺;

	[CompilerGenerated]
	private IComparable 놴놅;

	[CompilerGenerated]
	private SettingItemSeparatorGroup 놴녜;

	[CompilerGenerated]
	private object 놴뇃;

	[CompilerGenerated]
	private Action 놴녯;

	public string Text
	{
		[CompilerGenerated]
		get
		{
			return 놴놺;
		}
		[CompilerGenerated]
		set
		{
			놴놺 = value;
		}
	}

	public IComparable Value
	{
		[CompilerGenerated]
		get
		{
			return 놴놅;
		}
		[CompilerGenerated]
		set
		{
			놴놅 = value;
		}
	}

	public SettingItemSeparatorGroup SeparatorGroup
	{
		[CompilerGenerated]
		get
		{
			return 놴녜;
		}
		[CompilerGenerated]
		set
		{
			놴녜 = value;
		}
	}

	public object SelectConfirmation
	{
		[CompilerGenerated]
		get
		{
			return 놴뇃;
		}
		[CompilerGenerated]
		set
		{
			놴뇃 = value;
		}
	}

	public Action Action
	{
		[CompilerGenerated]
		get
		{
			return 놴녯;
		}
		[CompilerGenerated]
		set
		{
			놴녯 = value;
		}
	}

	public SelectItem(string text, IComparable value = null)
	{
		Text = text;
		Value = value ?? Text;
	}

	public SelectItem(string text, int value)
	{
		Text = text;
		Value = value;
	}

	public SelectItem(string text, string value)
	{
		Text = text;
		Value = value;
	}

	public override string ToString()
	{
		return Text;
	}

	public bool Equals(SelectItem other)
	{
		if (other == null)
		{
			return false;
		}
		if (this == other)
		{
			return true;
		}
		return object.Equals(Value, other.Value);
	}

	public override bool Equals(object obj)
	{
		if (obj == null)
		{
			return false;
		}
		if (this == obj)
		{
			return true;
		}
		if (obj.GetType() != GetType())
		{
			return false;
		}
		return Equals((SelectItem)obj);
	}

	public override int GetHashCode()
	{
		if (Value == null)
		{
			return 0;
		}
		return Value.GetHashCode();
	}
}
