using System;
using System.Runtime.CompilerServices;

namespace TradingPlatform.BusinessLayer;

public class TypeWrapper
{
	[CompilerGenerated]
	private Type 놴녮;

	[CompilerGenerated]
	private string 놴뇆;

	public Type Type
	{
		[CompilerGenerated]
		get
		{
			return 놴녮;
		}
		[CompilerGenerated]
		private set
		{
			놴녮 = value;
		}
	}

	public string AssemblyLocation
	{
		[CompilerGenerated]
		get
		{
			return 놴뇆;
		}
		[CompilerGenerated]
		private set
		{
			놴뇆 = value;
		}
	}

	internal TypeWrapper(Type P_0, string P_1)
	{
		Type = P_0;
		AssemblyLocation = P_1;
	}

	public static implicit operator Type(TypeWrapper typeWrapper)
	{
		return typeWrapper.Type;
	}

	public override string ToString()
	{
		return Type?.ToString();
	}
}
