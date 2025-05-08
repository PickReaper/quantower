using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;

namespace TradingPlatform.BusinessLayer;

public class LinkOCORequestParameters : TradingRequestParameters
{
	[Serializable]
	[CompilerGenerated]
	private sealed class 녴
	{
		public static readonly 녴 놻놋 = new 녴();

		public static Func<IOrder, string> 놻녣;

		internal string 녴(IOrder P_0)
		{
			return P_0.Id;
		}
	}

	[CompilerGenerated]
	private List<IOrder> 놵녡;

	public override RequestType Type => RequestType.Custom;

	public override string Event => _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놄놸();

	public override string Message
	{
		get
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(21, 1);
			defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놄놿());
			defaultInterpolatedStringHandler.AppendFormatted(base.RequestId);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}
	}

	public override string ConnectionId => OrdersToLink?.FirstOrDefault()?.ConnectionId;

	public List<IOrder> OrdersToLink
	{
		[CompilerGenerated]
		get
		{
			return 놵녡;
		}
		[CompilerGenerated]
		set
		{
			놵녡 = value;
		}
	}

	protected override Account GetAccount()
	{
		return OrdersToLink.FirstOrDefault()?.Account;
	}

	public override string ToString()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
		defaultInterpolatedStringHandler.AppendFormatted(base.ToString());
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놀());
		defaultInterpolatedStringHandler.AppendFormatted(OrdersToLink?.Select((IOrder P_0) => P_0.Id).ToArray());
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}
}
