using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using TradingPlatform.BusinessLayer.Integration;

namespace TradingPlatform.BusinessLayer;

[Published]
[DataContract(Name = "CryptoAssetBalances", Namespace = "TradingPlatform")]
public class CryptoAssetBalances : BusinessObject, IMessageBuilder<MessageCryptoAssetBalances>
{
	[CompilerGenerated]
	private string 놄놖;

	[CompilerGenerated]
	private Asset 놄놝;

	[CompilerGenerated]
	private double 놄뇄;

	[CompilerGenerated]
	private double 놄녑;

	[CompilerGenerated]
	private double 놄놈;

	[CompilerGenerated]
	private double 놄놬;

	[CompilerGenerated]
	private double 놄놊;

	[CompilerGenerated]
	private double 놄놪;

	[CompilerGenerated]
	private double 놄놌;

	[CompilerGenerated]
	private double 놄놕;

	[CompilerGenerated]
	private DateTime 놄뇊;

	[CompilerGenerated]
	private GetAvailableBalanceHandler 놄놋;

	private string 놄녣;

	[DataMember(Name = "AssetId")]
	public string AssetId
	{
		[CompilerGenerated]
		get
		{
			return 놄놖;
		}
		[CompilerGenerated]
		internal set
		{
			놄놖 = value;
		}
	}

	public Asset Asset
	{
		[CompilerGenerated]
		get
		{
			return 놄놝;
		}
		[CompilerGenerated]
		private set
		{
			놄놝 = value;
		}
	}

	[DataMember(Name = "TotalBalance")]
	public double TotalBalance
	{
		[CompilerGenerated]
		get
		{
			return 놄뇄;
		}
		[CompilerGenerated]
		internal set
		{
			놄뇄 = value;
		}
	}

	[DataMember(Name = "AvailableBalance")]
	public double AvailableBalance
	{
		[CompilerGenerated]
		get
		{
			return 놄녑;
		}
		[CompilerGenerated]
		internal set
		{
			놄녑 = value;
		}
	}

	[DataMember(Name = "ReservedBalance")]
	public double ReservedBalance
	{
		[CompilerGenerated]
		get
		{
			return 놄놈;
		}
		[CompilerGenerated]
		internal set
		{
			놄놈 = value;
		}
	}

	[DataMember(Name = "TotalInUSD")]
	public double TotalInUSD
	{
		[CompilerGenerated]
		get
		{
			return 놄놬;
		}
		[CompilerGenerated]
		internal set
		{
			놄놬 = value;
		}
	}

	[DataMember(Name = "TotalInBTC")]
	public double TotalInBTC
	{
		[CompilerGenerated]
		get
		{
			return 놄놊;
		}
		[CompilerGenerated]
		internal set
		{
			놄놊 = value;
		}
	}

	[DataMember(Name = "Debt")]
	public double Debt
	{
		[CompilerGenerated]
		get
		{
			return 놄놪;
		}
		[CompilerGenerated]
		internal set
		{
			놄놪 = value;
		}
	}

	[DataMember(Name = "Equity")]
	public double Equity
	{
		[CompilerGenerated]
		get
		{
			return 놄놌;
		}
		[CompilerGenerated]
		internal set
		{
			놄놌 = value;
		}
	}

	[DataMember(Name = "EquityInBTC")]
	public double EquityInBTC
	{
		[CompilerGenerated]
		get
		{
			return 놄놕;
		}
		[CompilerGenerated]
		internal set
		{
			놄놕 = value;
		}
	}

	public DateTime LastUpdateTime
	{
		[CompilerGenerated]
		get
		{
			return 놄뇊;
		}
		[CompilerGenerated]
		private set
		{
			놄뇊 = value;
		}
	}

	public GetAvailableBalanceHandler AvailableBalanceHandler
	{
		[CompilerGenerated]
		get
		{
			return 놄놋;
		}
		[CompilerGenerated]
		set
		{
			놄놋 = value;
		}
	}

	public double GetAvailableBalance(OrderRequestParameters requestParameters)
	{
		double availableBalance = 0.0;
		GetAvailableBalanceHandler availableBalanceHandler = AvailableBalanceHandler;
		if (availableBalanceHandler != null && availableBalanceHandler(AssetId, requestParameters, out availableBalance))
		{
			return availableBalance;
		}
		return AvailableBalance;
	}

	internal CryptoAssetBalances(string P_0)
		: base(P_0)
	{
	}

	internal void 녴(MessageCryptoAssetBalances P_0)
	{
		AssetId = P_0.AssetId;
		TotalBalance = P_0.TotalBalance;
		AvailableBalance = P_0.AvailableBalance;
		ReservedBalance = P_0.ReservedBalance;
		TotalInUSD = P_0.TotalInUSD;
		TotalInBTC = P_0.TotalInBTC;
		Debt = P_0.Debt;
		Equity = P_0.Equity;
		EquityInBTC = P_0.EquityInBTC;
		AvailableBalanceHandler = P_0.AvailableBalanceHandler;
		놄녣 = P_0.AccountId;
		if (!string.IsNullOrEmpty(P_0.AssetId) && ConnectionCache.녪뇋.TryGetValue(P_0.AssetId, out var value))
		{
			Asset = value;
		}
		LastUpdateTime = Core.Instance.TimeUtils.DateTimeUtcNow;
	}

	public override string ToString()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(18, 2);
		defaultInterpolatedStringHandler.AppendFormatted(AssetId);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸녗());
		defaultInterpolatedStringHandler.AppendFormatted(TotalBalance);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	public MessageCryptoAssetBalances BuildMessage()
	{
		return new MessageCryptoAssetBalances
		{
			AssetId = AssetId,
			TotalBalance = TotalBalance,
			AvailableBalance = AvailableBalance,
			ReservedBalance = ReservedBalance,
			TotalInUSD = TotalInUSD,
			TotalInBTC = TotalInBTC,
			Debt = Debt,
			Equity = Equity,
			EquityInBTC = EquityInBTC,
			AvailableBalanceHandler = AvailableBalanceHandler,
			AccountId = 놄녣
		};
	}
}
