using System;
using System.IO;
using System.Reflection;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;

namespace TradingPlatform.BusinessLayer;

public static class StringExtensions
{
	public static bool Contains(this string str1, string str2, StringComparison stringComparison)
	{
		return str1.IndexOf(str2, stringComparison) >= 0;
	}

	public static bool TryParseEnum<TEnum, TAttribute>(this string str, Func<TAttribute, string> getAttributeValue, out TEnum enumValue) where TEnum : struct, IConvertible where TAttribute : Attribute
	{
		if (!typeof(TEnum).IsEnum)
		{
			throw new ArgumentException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂뇏());
		}
		enumValue = default(TEnum);
		FieldInfo[] fields = enumValue.GetType().GetFields();
		foreach (FieldInfo fieldInfo in fields)
		{
			object[] customAttributes = fieldInfo.GetCustomAttributes(typeof(TAttribute), inherit: false);
			if (customAttributes.Length == 0)
			{
				continue;
			}
			object[] array = customAttributes;
			for (int j = 0; j < array.Length; j++)
			{
				if (array[j] is TAttribute arg && getAttributeValue(arg) == str)
				{
					enumValue = (TEnum)fieldInfo.GetValue(null);
					return true;
				}
			}
		}
		return false;
	}

	public static string EncodeFilePathPart(this string fileName)
	{
		string text = fileName;
		char[] invalidFileNameChars = Path.GetInvalidFileNameChars();
		foreach (char value in invalidFileNameChars)
		{
			text = text.Replace($"{value}", $"{value}");
		}
		return text;
	}
}
