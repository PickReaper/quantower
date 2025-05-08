using System;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace TradingPlatform.BusinessLayer;

public static class EnumExtensions
{
	[Serializable]
	[CompilerGenerated]
	private sealed class 녴
	{
		public static readonly 녴 놭놢 = new 녴();

		public static Func<EnumMemberAttribute, string> 놭녧;

		public static Func<DescriptionAttribute, string> 놭녤;

		internal string 녴(EnumMemberAttribute P_0)
		{
			return P_0.Value;
		}

		internal string 녴(DescriptionAttribute P_0)
		{
			return P_0.Description;
		}
	}

	public static string GetEnumMember(this Enum value)
	{
		return value.GetAttributeValueOrDefault<string, EnumMemberAttribute>((EnumMemberAttribute P_0) => P_0.Value, value.ToString());
	}

	public static string GetDescription(this Enum value)
	{
		return value.GetAttributeValueOrDefault<string, DescriptionAttribute>((DescriptionAttribute P_0) => P_0.Description, value.ToString());
	}

	public static TValue GetAttributeValueOrDefault<TValue, TAttribute>(this Enum value, Func<TAttribute, TValue> valueFunc, TValue defaultValue) where TAttribute : Attribute
	{
		TAttribute attribute = value.GetAttribute<TAttribute>();
		if (valueFunc == null || attribute == null)
		{
			return defaultValue;
		}
		return valueFunc(attribute);
	}

	public static TAttribute GetAttribute<TAttribute>(this Enum value) where TAttribute : Attribute
	{
		return value.GetType().GetField(value.ToString()).GetCustomAttributes(typeof(TAttribute), inherit: false)
			.Cast<TAttribute>()
			.FirstOrDefault();
	}
}
