using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;

namespace TradingPlatform.BusinessLayer;

public record GroupTradingOperation(GroupTradingOperationType Type, GroupTradingOperationFilters Filters)
{
	public GroupTradingOperationType Type
	{
		[CompilerGenerated]
		get
		{
			return Type;
		}
		[CompilerGenerated]
		init
		{
			Type = value;
		}
	}

	public GroupTradingOperationFilters Filters
	{
		[CompilerGenerated]
		get
		{
			return Filters;
		}
		[CompilerGenerated]
		init
		{
			Filters = value;
		}
	}

	[CompilerGenerated]
	private readonly GroupTradingOperationType 놴녹 = Type;

	[CompilerGenerated]
	private readonly GroupTradingOperationFilters 놴녔 = Filters;

	[CompilerGenerated]
	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놂());
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
		builder.Append(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂녞());
		builder.Append(Type.ToString());
		builder.Append(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놫());
		builder.Append(Filters.ToString());
		return true;
	}

	[CompilerGenerated]
	public void Deconstruct(out GroupTradingOperationType Type, out GroupTradingOperationFilters Filters)
	{
		Type = this.Type;
		Filters = this.Filters;
	}
}
