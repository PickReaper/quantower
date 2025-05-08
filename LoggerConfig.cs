using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;

namespace TradingPlatform.BusinessLayer;

public record LoggerConfig
{
	public string LoggerName
	{
		[CompilerGenerated]
		get
		{
			return 놂놴;
		}
		[CompilerGenerated]
		set
		{
			놂놴 = value;
		}
	}

	public string OutputFolderPath
	{
		[CompilerGenerated]
		get
		{
			return 놂놂;
		}
		[CompilerGenerated]
		set
		{
			놂놂 = value;
		}
	}

	public LoggerScope Scope
	{
		[CompilerGenerated]
		get
		{
			return 놂놎;
		}
		[CompilerGenerated]
		set
		{
			놂놎 = value;
		}
	}

	[CompilerGenerated]
	private string 놂놴;

	[CompilerGenerated]
	private string 놂놂;

	[CompilerGenerated]
	private LoggerScope 놂놎;

	[CompilerGenerated]
	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놆());
		stringBuilder.Append(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놎());
		if (PrintMembers(stringBuilder))
		{
			stringBuilder.Append(' ');
		}
		stringBuilder.Append('}');
		return stringBuilder.ToString();
	}

	[CompilerGenerated]
	protected virtual bool PrintMembers(StringBuilder builder)
	{
		RuntimeHelpers.EnsureSufficientExecutionStack();
		builder.Append(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂뇎());
		builder.Append((object?)LoggerName);
		builder.Append(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놷());
		builder.Append((object?)OutputFolderPath);
		builder.Append(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂녗());
		builder.Append(Scope.ToString());
		return true;
	}
}
