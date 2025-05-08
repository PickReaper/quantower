using System;
using System.Runtime.CompilerServices;
using System.Threading;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;

namespace TradingPlatform.BusinessLayer;

[Published]
public abstract class RequestParameters : IEquatable<RequestParameters>
{
	[CompilerGenerated]
	private CancellationToken 놴뇀;

	[CompilerGenerated]
	private string 놴놽;

	[CompilerGenerated]
	private readonly long 놴녿;

	private static long 놴놁;

	public abstract RequestType Type { get; }

	public CancellationToken CancellationToken
	{
		[CompilerGenerated]
		get
		{
			return 놴뇀;
		}
		[CompilerGenerated]
		set
		{
			놴뇀 = value;
		}
	}

	public string SendingSource
	{
		[CompilerGenerated]
		get
		{
			return 놴놽;
		}
		[CompilerGenerated]
		set
		{
			놴놽 = value;
		}
	}

	public long RequestId
	{
		[CompilerGenerated]
		get
		{
			return 놴녿;
		}
	}

	protected RequestParameters()
	{
		놴녿 = Interlocked.Increment(ref 놴놁);
	}

	protected RequestParameters(RequestParameters origin)
	{
		CancellationToken = origin.CancellationToken;
		SendingSource = origin.SendingSource;
		놴녿 = origin.RequestId;
	}

	public override string ToString()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(22, 2);
		defaultInterpolatedStringHandler.AppendFormatted(Type);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴놐());
		defaultInterpolatedStringHandler.AppendFormatted(RequestId);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	public bool Equals(RequestParameters other)
	{
		if (other == null)
		{
			return false;
		}
		if (this == other)
		{
			return true;
		}
		return RequestId == other.RequestId;
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
		return Equals((RequestParameters)obj);
	}

	public override int GetHashCode()
	{
		return RequestId.GetHashCode();
	}
}
