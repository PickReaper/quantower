using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;

namespace TradingPlatform.BusinessLayer;

public class Renamable : IRenamable
{
	[Serializable]
	[CompilerGenerated]
	private sealed class 녴
	{
		public static readonly 녴 놵놊 = new 녴();

		public static Converter<string, string> 놵놪;

		internal string 녴(string P_0)
		{
			return P_0.ToLower();
		}
	}

	[CompilerGenerated]
	private bool 녲놃;

	[CompilerGenerated]
	private List<string> 녲뇇;

	public bool AllowFileSystemForbiddenSymbols = true;

	[CompilerGenerated]
	private string 녲놛;

	public bool AllowEmptyName
	{
		[CompilerGenerated]
		get
		{
			return 녲놃;
		}
		[CompilerGenerated]
		set
		{
			녲놃 = value;
		}
	}

	public List<string> ExcludeNames
	{
		[CompilerGenerated]
		get
		{
			return 녲뇇;
		}
		[CompilerGenerated]
		set
		{
			녲뇇 = value;
		}
	}

	public string Name
	{
		[CompilerGenerated]
		get
		{
			return 녲놛;
		}
		[CompilerGenerated]
		set
		{
			녲놛 = value;
		}
	}

	public bool IsNameAllowed(string s, ref string error)
	{
		if (!AllowEmptyName && string.IsNullOrWhiteSpace(s))
		{
			error = _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭놤();
			return false;
		}
		if (ExcludeNames != null && ExcludeNames.ConvertAll((string P_0) => P_0.ToLower()).ToArray().Contains(s.ToLower()))
		{
			error = _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭논();
			return false;
		}
		char[] invalidFileNameChars = Path.GetInvalidFileNameChars();
		if (s.IndexOfAny(invalidFileNameChars) != -1)
		{
			string text = string.Empty;
			string text2 = string.Empty;
			char[] array = invalidFileNameChars;
			foreach (char c in array)
			{
				if (char.IsWhiteSpace(c) || char.IsControl(c))
				{
					string text3 = text2;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(4, 1);
					defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭녘());
					defaultInterpolatedStringHandler.AppendFormatted((int)c);
					defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂녹());
					text2 = text3 + defaultInterpolatedStringHandler.ToStringAndClear();
				}
				else
				{
					string text4 = text;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 1);
					defaultInterpolatedStringHandler.AppendFormatted(c);
					defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂녹());
					text = text4 + defaultInterpolatedStringHandler.ToStringAndClear();
				}
			}
			text2 = text2.Trim();
			text2 = text2.Trim(',');
			text += text2;
			error = _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭노() + text;
			return false;
		}
		error = string.Empty;
		return true;
	}
}
