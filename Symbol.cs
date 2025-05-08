using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using TradingPlatform.BusinessLayer.Integration;
using TradingPlatform.BusinessLayer.Utils;
using 녴;

namespace TradingPlatform.BusinessLayer;

/// <summary>
/// Represent access to symbol information and properties.
/// </summary>
[Published]
public class Symbol : BusinessObject, IComparable<Symbol>, 녪, IMessageBuilder<MessageSymbol>, IMessageBuilder<DayBar>, IEquatable<Symbol>, IConnectionStateDependent
{
	[CompilerGenerated]
	private static class 녴
	{
		public static Func<double, double, double> 놻놐;
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class 놴
	{
		public static readonly 놴 놻녚 = new 놴();

		public static Func<double, double, double> 놻녳;

		public static Func<long, long, long> 놻놉;

		public static Func<long, long, long> 놻놥;

		public static Func<Exchange, string> 놻놯;

		internal double 녴(double P_0, double P_1)
		{
			return P_0;
		}

		internal long 녴(long P_0, long P_1)
		{
			return P_0;
		}

		internal long 놴(long P_0, long P_1)
		{
			if (P_0 < 0)
			{
				return P_1;
			}
			return P_0;
		}

		internal string 녴(Exchange P_0)
		{
			return P_0.Id;
		}
	}

	[CompilerGenerated]
	private sealed class 놂
	{
		public MessageSymbolInfo 놻녾;

		internal bool 녴(OptionSerie P_0)
		{
			return P_0.Id == 놻녾.OptionSerieId;
		}
	}

	[CompilerGenerated]
	private sealed class 놎
	{
		public OrderTypeUsage? 놻녬;

		internal bool 녴(OrderType P_0)
		{
			return P_0.Usage.HasFlag(놻녬);
		}
	}

	public const string SPOT_SYMBOL_ID = "spotSymbolId";

	public const string TRADING_SYMBOL_ID = "TradingSymbol";

	[CompilerGenerated]
	private string 놰뇏;

	[CompilerGenerated]
	private string 놰녻;

	[CompilerGenerated]
	private string 놰녙;

	[CompilerGenerated]
	private SymbolType 놰놢;

	[CompilerGenerated]
	private Asset 놰녧;

	[CompilerGenerated]
	private Asset 놰녤;

	private Exchange 놰놆;

	private string 놰뇎;

	[CompilerGenerated]
	private TimeSpan 놰놷;

	[CompilerGenerated]
	private AdditionalInfoCollection 놰녗;

	[CompilerGenerated]
	private double 놰놜;

	[CompilerGenerated]
	private double 놰놨;

	[CompilerGenerated]
	private NettingType 놰녢;

	[CompilerGenerated]
	private SymbolGroup 놰놞;

	[CompilerGenerated]
	private SymbolQuotingType 놰놳;

	[CompilerGenerated]
	private double 놰놺;

	private List<VariableTick> 놰놅;

	private double? 놰녜;

	[CompilerGenerated]
	private double 놰뇃;

	[CompilerGenerated]
	private double 놰녯;

	[CompilerGenerated]
	private DateTime 놰놮;

	[CompilerGenerated]
	private DateTime 놰녫;

	[CompilerGenerated]
	private DateTime 놰뇁;

	[CompilerGenerated]
	private double 놰놧;

	[CompilerGenerated]
	private OptionCodingStyle 놰녝;

	[CompilerGenerated]
	private OptionType 놰뇈;

	[CompilerGenerated]
	private OptionSerie 놰놑;

	[CompilerGenerated]
	private string 놰놦;

	private Symbol 놰놐;

	private string 놰녚;

	[CompilerGenerated]
	private AvailableDerivatives 놰녳;

	[CompilerGenerated]
	private AvailableDerivatives 놰놉;

	private List<Exchange> 놰놥;

	[CompilerGenerated]
	private FutureContractType? 놰놯;

	[CompilerGenerated]
	private double 놰녾;

	[CompilerGenerated]
	private double 놰녬;

	[CompilerGenerated]
	private double 놰녹;

	[CompilerGenerated]
	private double 놰녔;

	[CompilerGenerated]
	private DateTime 놰녠;

	[CompilerGenerated]
	private double 놰놠;

	[CompilerGenerated]
	private double 놰놟;

	[CompilerGenerated]
	private DateTime 놰녓;

	[CompilerGenerated]
	private double 놰녛;

	[CompilerGenerated]
	private double 놰녽;

	[CompilerGenerated]
	private double 놰놏;

	[CompilerGenerated]
	private double 놰녥;

	[CompilerGenerated]
	private double 놰농;

	[CompilerGenerated]
	private double 놰념;

	[CompilerGenerated]
	private double 놰녨;

	[CompilerGenerated]
	private double 놰녺;

	[CompilerGenerated]
	private double 놰놣;

	[CompilerGenerated]
	private long 놰녮;

	[CompilerGenerated]
	private long 놰뇆;

	[CompilerGenerated]
	private DepthOfMarket 놰뇉;

	private double 놰뇍;

	private double 놰놙;

	[CompilerGenerated]
	private double 놰녰;

	[CompilerGenerated]
	private double 놰놚;

	[CompilerGenerated]
	private double 놰놹;

	[CompilerGenerated]
	private double 놰놘;

	[CompilerGenerated]
	private double 놰뇌;

	[CompilerGenerated]
	private double 놰녷;

	[CompilerGenerated]
	private double 놰녟;

	[CompilerGenerated]
	private double 놰놱;

	[CompilerGenerated]
	private double 놰놖;

	[CompilerGenerated]
	private double 놰놝;

	[CompilerGenerated]
	private double 놰뇄;

	[CompilerGenerated]
	private double 놰녑;

	[CompilerGenerated]
	private double 놰놈;

	private readonly object 놰놬;

	private TickDirection 놰놊;

	private TickDirection 놰놪;

	private TickDirection 놰놌;

	[CompilerGenerated]
	private HistoryType 놰놕;

	protected HistoryMetadata historyMetadata;

	[CompilerGenerated]
	private SymbolVolumeType 놰뇊;

	protected VolumeAnalysisMetadata volumeAnalysisMetadata;

	private QuoteHandler 놰놋;

	private Level2Handler 놰녣;

	private LastHandler 놰녩;

	private MarkHandler 놰놤;

	[CompilerGenerated]
	private DayBarHandler 놰논;

	[CompilerGenerated]
	private SymbolUpdateHandler 놰녘;

	private readonly 뇇<string, Rule> 놰노;

	[CompilerGenerated]
	private bool 놰녒;

	[CompilerGenerated]
	private bool 놰녕;

	[CompilerGenerated]
	private bool 놰녖;

	[CompilerGenerated]
	private bool 놓녴;

	[CompilerGenerated]
	private bool 놓놴;

	[CompilerGenerated]
	private DeltaCalculationType 놓놂;

	[CompilerGenerated]
	private double 놓놎;

	private string 놓녞;

	private const double 놓놫 = 1.0 / 32.0;

	private const double 놓녪 = 1.0 / 64.0;

	private const double 놓녶 = 1.0 / 128.0;

	private const double 놓녵 = 1.0 / 256.0;

	/// <summary>
	/// Gets symbol Id
	/// </summary>
	public string Id
	{
		[CompilerGenerated]
		get
		{
			return 놰뇏;
		}
		[CompilerGenerated]
		protected set
		{
			놰뇏 = value;
		}
	}

	public SymbolComplexIdentifier ComplexId => new SymbolComplexIdentifier(base.ConnectionId, ExchangeId, Id);

	/// <summary>
	/// Gets symbol name
	/// </summary>
	public string Name
	{
		[CompilerGenerated]
		get
		{
			return 놰녻;
		}
		[CompilerGenerated]
		protected set
		{
			놰녻 = value;
		}
	}

	/// <summary>
	/// Gets symbol description
	/// </summary>
	public string Description
	{
		[CompilerGenerated]
		get
		{
			return 놰녙;
		}
		[CompilerGenerated]
		private set
		{
			놰녙 = value;
		}
	}

	/// <summary>
	/// Gets symbol type
	/// </summary>
	public SymbolType SymbolType
	{
		[CompilerGenerated]
		get
		{
			return 놰놢;
		}
		[CompilerGenerated]
		private set
		{
			놰놢 = value;
		}
	}

	/// <summary>
	/// Gets symbol base Asset
	/// </summary>
	public Asset Product
	{
		[CompilerGenerated]
		get
		{
			return 놰녧;
		}
		[CompilerGenerated]
		protected set
		{
			놰녧 = value;
		}
	}

	/// <summary>
	/// Gets symbol counter Asset
	/// </summary>
	public Asset QuotingCurrency
	{
		[CompilerGenerated]
		get
		{
			return 놰녤;
		}
		[CompilerGenerated]
		protected set
		{
			놰녤 = value;
		}
	}

	/// <summary>
	/// Gets Exchange of current symbol
	/// </summary>
	public Exchange Exchange
	{
		get
		{
			return 놰놆;
		}
		protected set
		{
			놰놆 = value;
			ExchangeId = Exchange?.Id;
		}
	}

	/// <summary>
	/// Gets Exchange id of current symbol
	/// </summary>
	public string ExchangeId
	{
		get
		{
			return Exchange?.Id ?? 놰뇎;
		}
		private set
		{
			놰뇎 = value;
		}
	}

	/// <summary>
	/// Returns delay with which quote come in platform.
	/// </summary>
	public TimeSpan QuoteDelay
	{
		[CompilerGenerated]
		get
		{
			return 놰놷;
		}
		[CompilerGenerated]
		private set
		{
			놰놷 = value;
		}
	}

	/// <summary>
	/// Gets symbol additional info
	/// </summary>
	[NotPublished]
	public AdditionalInfoCollection AdditionalInfo
	{
		[CompilerGenerated]
		get
		{
			return 놰녗;
		}
		[CompilerGenerated]
		private set
		{
			놰녗 = value;
		}
	}

	/// <summary>
	/// The highest trade allowed
	/// </summary>
	public double MaxLot
	{
		[CompilerGenerated]
		get
		{
			return 놰놜;
		}
		[CompilerGenerated]
		private set
		{
			놰놜 = value;
		}
	}

	/// <summary>
	/// The lowest trade allowed
	/// </summary>
	public double MinLot
	{
		[CompilerGenerated]
		get
		{
			return 놰놨;
		}
		[CompilerGenerated]
		private set
		{
			놰놨 = value;
		}
	}

	/// <summary>
	/// Gets symbol NettingType
	/// </summary>
	public NettingType NettingType
	{
		[CompilerGenerated]
		get
		{
			return 놰녢;
		}
		[CompilerGenerated]
		private set
		{
			놰녢 = value;
		}
	}

	/// <summary>
	/// Gets SymbolGroup
	/// </summary>
	public SymbolGroup Group
	{
		[CompilerGenerated]
		get
		{
			return 놰놞;
		}
		[CompilerGenerated]
		protected set
		{
			놰놞 = value;
		}
	}

	/// <summary>
	/// Gets current SymbolQuotingType
	/// </summary>
	public SymbolQuotingType QuotingType
	{
		[CompilerGenerated]
		get
		{
			return 놰놳;
		}
		[CompilerGenerated]
		private set
		{
			놰놳 = value;
		}
	}

	/// <summary>
	/// Amount of base asset <see cref="P:TradingPlatform.BusinessLayer.Symbol.Product" /> for one lot.
	/// </summary>
	public double LotSize
	{
		[CompilerGenerated]
		get
		{
			return 놰놺;
		}
		[CompilerGenerated]
		private set
		{
			놰놺 = value;
		}
	}

	/// <summary>
	/// Stores list of symbol ticksizes
	/// </summary>
	public List<VariableTick> VariableTickList
	{
		get
		{
			return 놰놅;
		}
		private set
		{
			놰놅 = value;
			List<VariableTick> list = 놰놅;
			if (list != null && list.Count == 1)
			{
				놰녜 = 놰놅[0].TickSize;
			}
			else
			{
				놰녜 = null;
			}
		}
	}

	/// <summary>
	/// Step of the lot changes
	/// </summary>
	public double LotStep
	{
		[CompilerGenerated]
		get
		{
			return 놰뇃;
		}
		[CompilerGenerated]
		private set
		{
			놰뇃 = value;
		}
	}

	/// <summary>
	/// Step of the notional value changes
	/// </summary>
	public double NotionalValueStep
	{
		[CompilerGenerated]
		get
		{
			return 놰녯;
		}
		[CompilerGenerated]
		private set
		{
			놰녯 = value;
		}
	}

	/// <summary>
	/// Gets derivative expiration date
	/// </summary>
	public DateTime ExpirationDate
	{
		[CompilerGenerated]
		get
		{
			return 놰놮;
		}
		[CompilerGenerated]
		private set
		{
			놰놮 = value;
		}
	}

	/// <summary>
	/// Gets derivative last trading date
	/// </summary>
	public DateTime LastTradingDate
	{
		[CompilerGenerated]
		get
		{
			return 놰녫;
		}
		[CompilerGenerated]
		private set
		{
			놰녫 = value;
		}
	}

	/// <summary>
	/// Gets derivative maturity date
	/// </summary>
	public DateTime MaturityDate
	{
		[CompilerGenerated]
		get
		{
			return 놰뇁;
		}
		[CompilerGenerated]
		private set
		{
			놰뇁 = value;
		}
	}

	/// <summary>
	/// Gets derivative strike price
	/// </summary>
	[NotPublished]
	public double StrikePrice
	{
		[CompilerGenerated]
		get
		{
			return 놰놧;
		}
		[CompilerGenerated]
		private set
		{
			놰놧 = value;
		}
	}

	/// <summary>
	/// Gets derivative option style
	/// </summary>
	[NotPublished]
	public OptionCodingStyle OptionStyle
	{
		[CompilerGenerated]
		get
		{
			return 놰녝;
		}
		[CompilerGenerated]
		private set
		{
			놰녝 = value;
		}
	}

	/// <summary>
	/// Gets derivative option type
	/// </summary>
	[NotPublished]
	public OptionType OptionType
	{
		[CompilerGenerated]
		get
		{
			return 놰뇈;
		}
		[CompilerGenerated]
		private set
		{
			놰뇈 = value;
		}
	}

	/// <summary>
	/// Gets derivative option serie
	/// </summary>
	[NotPublished]
	public OptionSerie OptionSerie
	{
		[CompilerGenerated]
		get
		{
			return 놰놑;
		}
		[CompilerGenerated]
		private set
		{
			놰놑 = value;
		}
	}

	/// <summary>
	/// Gets derivative underlier name
	/// </summary>
	public string Root
	{
		[CompilerGenerated]
		get
		{
			return 놰놦;
		}
		[CompilerGenerated]
		private set
		{
			놰놦 = value;
		}
	}

	/// <summary>
	/// Gets derivative underlier symbol
	/// </summary>
	public Symbol Underlier
	{
		get
		{
			return 놰놐;
		}
		private set
		{
			놰놐 = value;
			UnderlierId = Underlier?.Id;
		}
	}

	/// <summary>
	/// Gets derivative underlier symbol id
	/// </summary>
	public string UnderlierId
	{
		get
		{
			return Underlier?.Id ?? 놰녚;
		}
		private set
		{
			놰녚 = value;
		}
	}

	public AvailableDerivatives AvailableFutures
	{
		[CompilerGenerated]
		get
		{
			return 놰녳;
		}
		[CompilerGenerated]
		private set
		{
			놰녳 = value;
		}
	}

	public AvailableDerivatives AvailableOptions
	{
		[CompilerGenerated]
		get
		{
			return 놰놉;
		}
		[CompilerGenerated]
		private set
		{
			놰놉 = value;
		}
	}

	public Exchange[] AvailableOptionsExchanges => 놰놥.ToArray();

	public FutureContractType? FutureContractType
	{
		[CompilerGenerated]
		get
		{
			return 놰놯;
		}
		[CompilerGenerated]
		private set
		{
			놰놯 = value;
		}
	}

	/// <summary>
	/// Gets Ask price
	/// </summary>
	public double Ask
	{
		[CompilerGenerated]
		get
		{
			return 놰녾;
		}
		[CompilerGenerated]
		private set
		{
			놰녾 = value;
		}
	}

	/// <summary>
	/// Gets Ask size
	/// </summary>
	public double AskSize
	{
		[CompilerGenerated]
		get
		{
			return 놰녬;
		}
		[CompilerGenerated]
		private set
		{
			놰녬 = value;
		}
	}

	/// <summary>
	/// Gets Bid price
	/// </summary>
	public double Bid
	{
		[CompilerGenerated]
		get
		{
			return 놰녹;
		}
		[CompilerGenerated]
		private set
		{
			놰녹 = value;
		}
	}

	/// <summary>
	/// Gets Bid size
	/// </summary>
	public double BidSize
	{
		[CompilerGenerated]
		get
		{
			return 놰녔;
		}
		[CompilerGenerated]
		private set
		{
			놰녔 = value;
		}
	}

	/// <summary>
	/// Gets quote time
	/// </summary>
	public DateTime QuoteDateTime
	{
		[CompilerGenerated]
		get
		{
			return 놰녠;
		}
		[CompilerGenerated]
		private set
		{
			놰녠 = value;
		}
	}

	/// <summary>
	/// Gets last price
	/// </summary>
	public double Last
	{
		[CompilerGenerated]
		get
		{
			return 놰놠;
		}
		[CompilerGenerated]
		private set
		{
			놰놠 = value;
		}
	}

	/// <summary>
	/// Gets last size
	/// </summary>
	public double LastSize
	{
		[CompilerGenerated]
		get
		{
			return 놰놟;
		}
		[CompilerGenerated]
		private set
		{
			놰놟 = value;
		}
	}

	/// <summary>
	/// Gets last time
	/// </summary>
	public DateTime LastDateTime
	{
		[CompilerGenerated]
		get
		{
			return 놰녓;
		}
		[CompilerGenerated]
		private set
		{
			놰녓 = value;
		}
	}

	/// <summary>
	/// Gets mark price
	/// </summary>
	public double Mark
	{
		[CompilerGenerated]
		get
		{
			return 놰녛;
		}
		[CompilerGenerated]
		private set
		{
			놰녛 = value;
		}
	}

	/// <summary>
	/// Gets mark size
	/// </summary>
	public double MarkSize
	{
		[CompilerGenerated]
		get
		{
			return 놰녽;
		}
		[CompilerGenerated]
		private set
		{
			놰녽 = value;
		}
	}

	/// <summary>
	/// Gets open price
	/// </summary>
	public double Open
	{
		[CompilerGenerated]
		get
		{
			return 놰놏;
		}
		[CompilerGenerated]
		private set
		{
			놰놏 = value;
		}
	}

	/// <summary>
	/// Gets previous close price
	/// </summary>
	public double PrevClose
	{
		[CompilerGenerated]
		get
		{
			return 놰녥;
		}
		[CompilerGenerated]
		private set
		{
			놰녥 = value;
		}
	}

	/// <summary>
	/// Gets high price
	/// </summary>
	public double High
	{
		[CompilerGenerated]
		get
		{
			return 놰농;
		}
		[CompilerGenerated]
		private set
		{
			놰농 = value;
		}
	}

	/// <summary>
	/// Gets low price
	/// </summary>
	public double Low
	{
		[CompilerGenerated]
		get
		{
			return 놰념;
		}
		[CompilerGenerated]
		private set
		{
			놰념 = value;
		}
	}

	/// <summary>
	/// Gets volume value
	/// </summary>
	public double Volume
	{
		[CompilerGenerated]
		get
		{
			return 놰녨;
		}
		[CompilerGenerated]
		private set
		{
			놰녨 = value;
		}
	}

	/// <summary>
	/// Gets quote asset volume value
	/// </summary>
	public double QuoteAssetVolume
	{
		[CompilerGenerated]
		get
		{
			return 놰녺;
		}
		[CompilerGenerated]
		private set
		{
			놰녺 = value;
		}
	}

	/// <summary>
	/// Gets PrevSettlement value
	/// </summary>
	[NotPublished]
	public double PrevSettlement
	{
		[CompilerGenerated]
		get
		{
			return 놰놣;
		}
		[CompilerGenerated]
		private set
		{
			놰놣 = value;
		}
	}

	/// <summary>
	/// Gets ticks amount
	/// </summary>
	public long Ticks
	{
		[CompilerGenerated]
		get
		{
			return 놰녮;
		}
		[CompilerGenerated]
		private set
		{
			놰녮 = value;
		}
	}

	/// <summary>
	/// Gets trades amount
	/// </summary>
	public long Trades
	{
		[CompilerGenerated]
		get
		{
			return 놰뇆;
		}
		[CompilerGenerated]
		private set
		{
			놰뇆 = value;
		}
	}

	/// <summary>
	/// Gets Level2 data
	/// </summary>
	public DepthOfMarket DepthOfMarket
	{
		[CompilerGenerated]
		get
		{
			return 놰뇉;
		}
		[CompilerGenerated]
		private set
		{
			놰뇉 = value;
		}
	}

	/// <summary>
	/// Gets spread value between Bid and Ask
	/// </summary>
	public double Spread
	{
		get
		{
			if (double.IsNaN(Bid) || double.IsNaN(Ask))
			{
				return double.NaN;
			}
			return CalculateTicks(Bid, Ask);
		}
	}

	/// <summary>
	/// Gets <see cref="P:TradingPlatform.BusinessLayer.Symbol.Spread" /> percentage value
	/// </summary>
	public double SpreadPercentage
	{
		get
		{
			if (double.IsNaN(Bid) || double.IsNaN(Ask))
			{
				return double.NaN;
			}
			decimal num = (decimal)Ask;
			decimal num2 = (decimal)Bid;
			decimal num3 = (num + num2) / 2m;
			if (num3 == 0m)
			{
				return double.NaN;
			}
			return (double)((num - num2) / num3 * 100m);
		}
	}

	/// <summary>
	/// Gets change value between Bid/Last and Close price
	/// </summary>
	public double Change
	{
		get
		{
			if (AllowCalculateRealtimeChange)
			{
				return CurrentPrice - ClosePrice;
			}
			return 놰뇍;
		}
	}

	/// <summary>
	/// Gets <see cref="P:TradingPlatform.BusinessLayer.Symbol.Change" /> percentage value
	/// </summary>
	public double ChangePercentage
	{
		get
		{
			if (AllowCalculateRealtimeChange)
			{
				double change = Change;
				double closePrice = ClosePrice;
				if (double.IsNaN(change) || double.IsNaN(closePrice) || closePrice == 0.0)
				{
					return double.NaN;
				}
				return (double)((decimal)change / Math.Abs((decimal)closePrice) * 100m);
			}
			return 놰놙;
		}
	}

	private double CurrentPrice => HistoryType switch
	{
		HistoryType.Ask => Ask, 
		HistoryType.Last => Last, 
		HistoryType.Midpoint => (Bid + Ask) / 2.0, 
		HistoryType.Mark => Mark, 
		_ => Bid, 
	};

	private double ClosePrice
	{
		get
		{
			if (!double.IsNaN(PrevSettlement) && PrevSettlement != 0.0)
			{
				return PrevSettlement;
			}
			return PrevClose;
		}
	}

	public double OpenInterest
	{
		[CompilerGenerated]
		get
		{
			return 놰녰;
		}
		[CompilerGenerated]
		private set
		{
			놰녰 = value;
		}
	}

	public double FundingRate
	{
		[CompilerGenerated]
		get
		{
			return 놰놚;
		}
		[CompilerGenerated]
		private set
		{
			놰놚 = value;
		}
	}

	public double TopPriceLimit
	{
		[CompilerGenerated]
		get
		{
			return 놰놹;
		}
		[CompilerGenerated]
		private set
		{
			놰놹 = value;
		}
	}

	public double BottomPriceLimit
	{
		[CompilerGenerated]
		get
		{
			return 놰놘;
		}
		[CompilerGenerated]
		private set
		{
			놰놘 = value;
		}
	}

	public double AverageTradedPrice
	{
		[CompilerGenerated]
		get
		{
			return 놰뇌;
		}
		[CompilerGenerated]
		private set
		{
			놰뇌 = value;
		}
	}

	public double TotalBuyQuantity
	{
		[CompilerGenerated]
		get
		{
			return 놰녷;
		}
		[CompilerGenerated]
		private set
		{
			놰녷 = value;
		}
	}

	public double TotalSellQuantity
	{
		[CompilerGenerated]
		get
		{
			return 놰녟;
		}
		[CompilerGenerated]
		private set
		{
			놰녟 = value;
		}
	}

	public double IV
	{
		[CompilerGenerated]
		get
		{
			return 놰놱;
		}
		[CompilerGenerated]
		private set
		{
			놰놱 = value;
		}
	}

	public double Delta
	{
		[CompilerGenerated]
		get
		{
			return 놰놖;
		}
		[CompilerGenerated]
		private set
		{
			놰놖 = value;
		}
	}

	public double Vega
	{
		[CompilerGenerated]
		get
		{
			return 놰놝;
		}
		[CompilerGenerated]
		private set
		{
			놰놝 = value;
		}
	}

	public double Gamma
	{
		[CompilerGenerated]
		get
		{
			return 놰뇄;
		}
		[CompilerGenerated]
		private set
		{
			놰뇄 = value;
		}
	}

	public double Theta
	{
		[CompilerGenerated]
		get
		{
			return 놰녑;
		}
		[CompilerGenerated]
		private set
		{
			놰녑 = value;
		}
	}

	public double Rho
	{
		[CompilerGenerated]
		get
		{
			return 놰놈;
		}
		[CompilerGenerated]
		private set
		{
			놰놈 = value;
		}
	}

	internal bool HasAnySubscription => QuotesSubscribed | Level2Subscribed | LastsSubscribed | MarkSubscribed;

	/// <summary>
	/// Default history type
	/// </summary>
	public HistoryType HistoryType
	{
		[CompilerGenerated]
		get
		{
			return 놰놕;
		}
		[CompilerGenerated]
		private set
		{
			놰놕 = value;
		}
	}

	/// <summary>
	/// List of all available history types
	/// </summary>
	[NotPublished]
	public virtual HistoryMetadata HistoryMetadata
	{
		get
		{
			HistoryMetadata historyMetaData = historyMetadata;
			if (historyMetaData == null)
			{
				Connection connection = Connection;
				if (connection == null)
				{
					return null;
				}
				historyMetaData = connection.HistoryMetaData;
			}
			return historyMetaData;
		}
	}

	/// <summary>
	/// Gets SymbolVolumeType
	/// </summary>
	public SymbolVolumeType VolumeType
	{
		[CompilerGenerated]
		get
		{
			return 놰뇊;
		}
		[CompilerGenerated]
		private set
		{
			놰뇊 = value;
		}
	}

	/// <summary>
	/// List of all available history types
	/// </summary>
	[NotPublished]
	public virtual VolumeAnalysisMetadata VolumeAnalysisMetadata
	{
		get
		{
			VolumeAnalysisMetadata obj = volumeAnalysisMetadata;
			if (obj == null)
			{
				Connection connection = Connection;
				if (connection == null)
				{
					return null;
				}
				obj = connection.VolumeAnalysisMetadata;
			}
			return obj;
		}
	}

	internal bool QuotesSubscribed => 놰놋 != null;

	internal bool Level2Subscribed => 놰녣 != null;

	internal bool LastsSubscribed => 놰녩 != null;

	internal bool MarkSubscribed => 놰놤 != null;

	int 녪.PriorityIndex => 20;

	뇇<string, Rule> 녪.Rules => 놰노;

	/// <summary>
	/// Gets real time <see cref="P:TradingPlatform.BusinessLayer.Symbol.Ticks" /> calculation setting
	/// </summary>
	[NotPublished]
	public bool AllowCalculateRealtimeTicks
	{
		[CompilerGenerated]
		get
		{
			return 놰녒;
		}
		[CompilerGenerated]
		private set
		{
			놰녒 = value;
		}
	}

	/// <summary>
	/// Gets real time <see cref="P:TradingPlatform.BusinessLayer.Symbol.Trades" /> calculation setting
	/// </summary>
	[NotPublished]
	public bool AllowCalculateRealtimeTrades
	{
		[CompilerGenerated]
		get
		{
			return 놰녕;
		}
		[CompilerGenerated]
		private set
		{
			놰녕 = value;
		}
	}

	/// <summary>
	/// Gets real time <see cref="P:TradingPlatform.BusinessLayer.Symbol.Volume" /> calculation setting
	/// </summary>
	[NotPublished]
	public bool AllowCalculateRealtimeVolume
	{
		[CompilerGenerated]
		get
		{
			return 놰녖;
		}
		[CompilerGenerated]
		private set
		{
			놰녖 = value;
		}
	}

	/// <summary>
	/// Gets real time <see cref="P:TradingPlatform.BusinessLayer.Symbol.Change" /> calculation setting
	/// </summary>
	[NotPublished]
	public bool AllowCalculateRealtimeChange
	{
		[CompilerGenerated]
		get
		{
			return 놓녴;
		}
		[CompilerGenerated]
		private set
		{
			놓녴 = value;
		}
	}

	[NotPublished]
	public bool AllowAbbreviatePriceByTickSize
	{
		[CompilerGenerated]
		get
		{
			return 놓놴;
		}
		[CompilerGenerated]
		set
		{
			놓놴 = value;
		}
	}

	public DeltaCalculationType DeltaCalculationType
	{
		[CompilerGenerated]
		get
		{
			return 놓놂;
		}
		[CompilerGenerated]
		private set
		{
			놓놂 = value;
		}
	}

	public double MinVolumeAnalysisTickSize
	{
		[CompilerGenerated]
		get
		{
			return 놓놎;
		}
		[CompilerGenerated]
		private set
		{
			놓놎 = value;
		}
	}

	public SessionsContainer CurrentSessionsInfo
	{
		get
		{
			if (string.IsNullOrEmpty(놓녞))
			{
				return Exchange?.CurrentSessionsInfo;
			}
			if (ConnectionCache?.TradingSessions == null)
			{
				return null;
			}
			ConnectionCache.TradingSessions.TryGetValue(놓녞, out var value);
			return value;
		}
	}

	internal int TotalSubscriptionsCount => (LastsSubscribed ? 1 : 0) + (MarkSubscribed ? 1 : 0) + (QuotesSubscribed ? 1 : 0) + (Level2Subscribed ? 1 : 0);

	/// <summary>
	/// Gets cached tick size if it available, else tries to obtain <see cref="M:TradingPlatform.BusinessLayer.Symbol.GetTickSize(System.Double)" /> with Last, Bid, Ask, first element of <see cref="T:TradingPlatform.BusinessLayer.VariableTick" /> list otherwise - <see cref="F:TradingPlatform.BusinessLayer.Utils.Const.DOUBLE_UNDEFINED" />
	/// </summary>
	public double TickSize
	{
		get
		{
			if (놰녜.HasValue)
			{
				return 놰녜.Value;
			}
			if (!double.IsNaN(Last))
			{
				return GetTickSize(Last);
			}
			if (!double.IsNaN(Bid))
			{
				return GetTickSize(Bid);
			}
			if (!double.IsNaN(Ask))
			{
				return GetTickSize(Ask);
			}
			return VariableTickList?.FirstOrDefault()?.TickSize ?? double.NaN;
		}
	}

	/// <summary>
	/// Will be triggered when new Level1 quote is comming
	/// </summary>
	public event QuoteHandler NewQuote
	{
		add
		{
			녴(ref 놰놋, value, SubscribeQuoteType.Quote);
		}
		remove
		{
			놴(ref 놰놋, value, SubscribeQuoteType.Quote);
		}
	}

	/// <summary>
	/// Will be triggered when new Level2 quote is comming
	/// </summary>
	public event Level2Handler NewLevel2
	{
		add
		{
			녴(ref 놰녣, value, SubscribeQuoteType.Level2);
		}
		remove
		{
			놴(ref 놰녣, value, SubscribeQuoteType.Level2);
		}
	}

	/// <summary>
	/// Will be triggered when new trade quote is comming
	/// </summary>
	public event LastHandler NewLast
	{
		add
		{
			녴(ref 놰녩, value, SubscribeQuoteType.Last);
		}
		remove
		{
			놴(ref 놰녩, value, SubscribeQuoteType.Last);
		}
	}

	public event MarkHandler NewMark
	{
		add
		{
			녴(ref 놰놤, value, SubscribeQuoteType.Mark);
		}
		remove
		{
			놴(ref 놰놤, value, SubscribeQuoteType.Mark);
		}
	}

	/// <summary>
	/// Will be triggered when new correctional quote is comming from the vendor.
	/// </summary>
	public event DayBarHandler NewDayBar
	{
		[CompilerGenerated]
		add
		{
			DayBarHandler dayBarHandler = 놰논;
			DayBarHandler dayBarHandler2;
			do
			{
				dayBarHandler2 = dayBarHandler;
				DayBarHandler value2 = (DayBarHandler)Delegate.Combine(dayBarHandler2, value);
				dayBarHandler = Interlocked.CompareExchange(ref 놰논, value2, dayBarHandler2);
			}
			while ((object)dayBarHandler != dayBarHandler2);
		}
		[CompilerGenerated]
		remove
		{
			DayBarHandler dayBarHandler = 놰논;
			DayBarHandler dayBarHandler2;
			do
			{
				dayBarHandler2 = dayBarHandler;
				DayBarHandler value2 = (DayBarHandler)Delegate.Remove(dayBarHandler2, value);
				dayBarHandler = Interlocked.CompareExchange(ref 놰논, value2, dayBarHandler2);
			}
			while ((object)dayBarHandler != dayBarHandler2);
		}
	}

	/// <summary>
	/// Will be triggered when symbol updated.
	/// </summary>
	public event SymbolUpdateHandler Updated
	{
		[CompilerGenerated]
		add
		{
			SymbolUpdateHandler symbolUpdateHandler = 놰녘;
			SymbolUpdateHandler symbolUpdateHandler2;
			do
			{
				symbolUpdateHandler2 = symbolUpdateHandler;
				SymbolUpdateHandler value2 = (SymbolUpdateHandler)Delegate.Combine(symbolUpdateHandler2, value);
				symbolUpdateHandler = Interlocked.CompareExchange(ref 놰녘, value2, symbolUpdateHandler2);
			}
			while ((object)symbolUpdateHandler != symbolUpdateHandler2);
		}
		[CompilerGenerated]
		remove
		{
			SymbolUpdateHandler symbolUpdateHandler = 놰녘;
			SymbolUpdateHandler symbolUpdateHandler2;
			do
			{
				symbolUpdateHandler2 = symbolUpdateHandler;
				SymbolUpdateHandler value2 = (SymbolUpdateHandler)Delegate.Remove(symbolUpdateHandler2, value);
				symbolUpdateHandler = Interlocked.CompareExchange(ref 놰녘, value2, symbolUpdateHandler2);
			}
			while ((object)symbolUpdateHandler != symbolUpdateHandler2);
		}
	}

	private void 녴<녴>(ref 녴 P_0, 녴 P_1, SubscribeQuoteType P_2) where 녴 : Delegate
	{
		lock (놰놬)
		{
			if (P_0 == null)
			{
				SubscribeAction(P_2);
			}
			P_0 = (녴)Delegate.Combine(P_0, P_1);
		}
	}

	private void 놴<녴>(ref 녴 P_0, 녴 P_1, SubscribeQuoteType P_2) where 녴 : Delegate
	{
		lock (놰놬)
		{
			bool flag = P_0 != null;
			P_0 = (녴)Delegate.Remove(P_0, P_1);
			if (P_0 == null && flag)
			{
				UnSubscribeAction(P_2);
			}
		}
	}

	protected internal Symbol()
	{
	}

	[NotPublished]
	protected internal Symbol(string connectionId)
		: base(connectionId)
	{
		놰놬 = new object();
		녴();
		놰노 = new 뇇<string, Rule>();
		Core.Instance.RulesManager.Defaults.ForEach(delegate(Rule P_0)
		{
			놰노.녴(P_0.Name, P_0);
		});
	}

	private protected void 녴()
	{
		NettingType = NettingType.Undefined;
		Ask = double.NaN;
		AskSize = double.NaN;
		Bid = double.NaN;
		BidSize = double.NaN;
		Last = double.NaN;
		LastSize = double.NaN;
		Mark = double.NaN;
		MarkSize = double.NaN;
		Open = double.NaN;
		PrevClose = double.NaN;
		High = double.NaN;
		Low = double.NaN;
		Volume = double.NaN;
		QuoteAssetVolume = double.NaN;
		PrevSettlement = double.NaN;
		놰뇍 = double.NaN;
		놰놙 = double.NaN;
		OpenInterest = double.NaN;
		FundingRate = double.NaN;
		TopPriceLimit = double.NaN;
		BottomPriceLimit = double.NaN;
		TotalBuyQuantity = double.NaN;
		TotalSellQuantity = double.NaN;
		IV = double.NaN;
		Delta = double.NaN;
		Vega = double.NaN;
		Gamma = double.NaN;
		Theta = double.NaN;
		Rho = double.NaN;
		Ticks = 0L;
		Trades = 0L;
		DepthOfMarket = new DepthOfMarket(this);
		AllowCalculateRealtimeTicks = true;
		AllowCalculateRealtimeTrades = true;
		AllowCalculateRealtimeVolume = true;
		AllowCalculateRealtimeChange = true;
		DeltaCalculationType = DeltaCalculationType.AggressorFlag;
		MinVolumeAnalysisTickSize = double.NaN;
		AvailableFutures = AvailableDerivatives.None;
		AvailableOptions = AvailableDerivatives.None;
		MinLot = 1.0;
		MaxLot = 2147483647.0;
		LotStep = 1.0;
		LotSize = 1.0;
		NotionalValueStep = 1.0;
		놰놥 = new List<Exchange>();
	}

	[NotPublished]
	protected internal Symbol(BusinessObjectInfo objectInfo)
		: this(objectInfo.ConnectionId)
	{
		Id = objectInfo.Id;
		Name = objectInfo.Name;
		State = BusinessObjectState.Fake;
		if (objectInfo is SymbolInfo symbolInfo)
		{
			ExchangeId = symbolInfo.ExchangeId;
			SymbolType = symbolInfo.SymbolType;
			FutureContractType = symbolInfo.FutureContractType;
			UnderlierId = symbolInfo.UnderlierId;
			Root = symbolInfo.Root;
			ExpirationDate = symbolInfo.ExpirationDate;
		}
	}

	internal void 녴(MessageSymbolInfo P_0)
	{
		if (string.IsNullOrEmpty(Id))
		{
			Id = P_0.Id;
		}
		Name = P_0.Name;
		Description = P_0.Description;
		SymbolType = P_0.SymbolType;
		AvailableFutures = P_0.AvailableFutures;
		AvailableOptions = P_0.AvailableOptions;
		Root = P_0.Root;
		LotStep = P_0.LotStep;
		MinLot = P_0.MinLot;
		MaxLot = P_0.MaxLot;
		HistoryType = P_0.HistoryType;
		VariableTickList = P_0.VariableTickList;
		StrikePrice = P_0.StrikePrice;
		OptionType = P_0.OptionType;
		ExpirationDate = P_0.ExpirationDate;
		LastTradingDate = P_0.LastTradingDate;
		FutureContractType = P_0.FutureContractType;
		if (ConnectionCache != null && !string.IsNullOrEmpty(P_0.ExchangeId))
		{
			if (ConnectionCache.ExchangesCache.녴(P_0.ExchangeId, out var exchange))
			{
				Exchange = exchange;
			}
			else
			{
				ExchangeId = P_0.ExchangeId;
			}
			if (P_0.AvailableOptionsExchanges != null)
			{
				string[] availableOptionsExchanges = P_0.AvailableOptionsExchanges;
				foreach (string text in availableOptionsExchanges)
				{
					if (ConnectionCache.ExchangesCache.녴(text, out var item))
					{
						놰놥.Add(item);
					}
				}
			}
		}
		if (string.IsNullOrEmpty(P_0.UnderlierId))
		{
			return;
		}
		if (ConnectionCache != null && ConnectionCache.SymbolsCache.녴(P_0.UnderlierId, out var underlier))
		{
			Underlier = underlier;
		}
		else
		{
			UnderlierId = P_0.UnderlierId;
		}
		if (P_0.OptionSerieId != null && Underlier != null)
		{
			OptionSerie = Connection.녴(new GetOptionSeriesRequestParameters(Underlier))?.FirstOrDefault((OptionSerie P_0) => P_0.Id == P_0.OptionSerieId);
		}
	}

	internal void 녴(MessageSymbol P_0)
	{
		녴((MessageSymbolInfo)P_0);
		if (ConnectionCache != null)
		{
			if (P_0.ProductAssetId != null && ConnectionCache.녪뇋.TryGetValue(P_0.ProductAssetId, out var value))
			{
				Product = value;
			}
			if (P_0.QuotingCurrencyAssetID != null && ConnectionCache.녪뇋.TryGetValue(P_0.QuotingCurrencyAssetID, out var value2))
			{
				QuotingCurrency = value2;
			}
			if (!string.IsNullOrEmpty(P_0.GroupId) && ConnectionCache.SymbolGroupsCache.TryGetValue(P_0.GroupId, out var value3))
			{
				Group = value3;
			}
		}
		QuoteDelay = P_0.QuoteDelay;
		MaturityDate = P_0.MaturityDate;
		QuotingType = P_0.QuotingType;
		LotSize = P_0.LotSize;
		NotionalValueStep = P_0.NotionalValueStep;
		NettingType = P_0.NettingType;
		if (P_0.SymbolAdditionalInfo != null)
		{
			if (AdditionalInfo == null)
			{
				AdditionalInfoCollection additionalInfoCollection2 = (AdditionalInfo = new AdditionalInfoCollection());
			}
			foreach (AdditionalInfoItem item in P_0.SymbolAdditionalInfo)
			{
				AdditionalInfo.녴(item);
			}
		}
		historyMetadata = P_0.HistoryMetadata;
		volumeAnalysisMetadata = P_0.VolumeAnalysisMetadata;
		VolumeType = P_0.VolumeType;
		AllowCalculateRealtimeTicks = P_0.AllowCalculateRealtimeTicks;
		AllowCalculateRealtimeTrades = P_0.AllowCalculateRealtimeTrades;
		AllowCalculateRealtimeVolume = P_0.AllowCalculateRealtimeVolume;
		AllowCalculateRealtimeChange = P_0.AllowCalculateRealtimeChange;
		AllowAbbreviatePriceByTickSize = P_0.AllowAbbreviatePriceByTickSize;
		DeltaCalculationType = P_0.DeltaCalculationType;
		MinVolumeAnalysisTickSize = P_0.MinVolumeAnalysisTickSize;
		놓녞 = P_0.SessionsContainerId;
		놴();
	}

	protected internal virtual void SubscribeAction(SubscribeQuoteType type)
	{
		if (State == BusinessObjectState.Fake)
		{
			return;
		}
		if (Core.Instance.SymbolsMapping.TryGetQuotesSymbol(this, out var quotesSymbol) && quotesSymbol != this)
		{
			switch (type)
			{
			case SubscribeQuoteType.Quote:
				quotesSymbol.NewQuote += 녴;
				break;
			case SubscribeQuoteType.Level2:
			{
				DOMQuote dOMQuote = ((IMessageBuilder<DOMQuote>)quotesSymbol.DepthOfMarket).BuildMessage();
				dOMQuote.SymbolId = Id;
				녴(dOMQuote);
				quotesSymbol.NewLevel2 += 녴;
				break;
			}
			case SubscribeQuoteType.Last:
				quotesSymbol.NewLast += 녴;
				break;
			case SubscribeQuoteType.Mark:
				quotesSymbol.NewMark += 녴;
				break;
			}
			bool flag = ((type == SubscribeQuoteType.Quote || (uint)(type - 2) <= 1u) ? true : false);
			if (flag && (quotesSymbol.놰논 == null || !quotesSymbol.놰논.GetInvocationList().Contains(new DayBarHandler(녴))))
			{
				quotesSymbol.NewDayBar += 녴;
				DayBar dayBar = ((IMessageBuilder<DayBar>)quotesSymbol).BuildMessage();
				dayBar.SymbolId = Id;
				녴((MessageQuote)dayBar);
			}
		}
		else
		{
			Core.Instance.Connections[base.ConnectionId]?.녴(this, type);
		}
	}

	protected internal virtual void UnSubscribeAction(SubscribeQuoteType type)
	{
		if (State == BusinessObjectState.Fake)
		{
			return;
		}
		if (Core.Instance.SymbolsMapping.TryGetQuotesSymbol(this, out var quotesSymbol) && quotesSymbol != this)
		{
			switch (type)
			{
			case SubscribeQuoteType.Quote:
				quotesSymbol.NewQuote -= 녴;
				break;
			case SubscribeQuoteType.Level2:
				quotesSymbol.NewLevel2 -= 녴;
				break;
			case SubscribeQuoteType.Last:
				quotesSymbol.NewLast -= 녴;
				break;
			case SubscribeQuoteType.Mark:
				quotesSymbol.NewMark -= 녴;
				break;
			}
			QuoteHandler quoteHandler = quotesSymbol.놰놋;
			if (quoteHandler == null || !quoteHandler.GetInvocationList().Contains(new QuoteHandler(녴)))
			{
				LastHandler lastHandler = quotesSymbol.놰녩;
				if (lastHandler == null || !lastHandler.GetInvocationList().Contains(new LastHandler(녴)))
				{
					MarkHandler markHandler = quotesSymbol.놰놤;
					if (markHandler == null || !markHandler.GetInvocationList().Contains(new MarkHandler(녴)))
					{
						quotesSymbol.NewDayBar -= 녴;
						녴((MessageQuote)new DayBar(Id, Core.Instance.TimeUtils.DateTimeUtcNow));
					}
				}
			}
		}
		else
		{
			Core.Instance.Connections[base.ConnectionId]?.놴(this, type);
		}
		if (type == SubscribeQuoteType.Level2)
		{
			DepthOfMarket.녴();
		}
	}

	private void 녴(Symbol P_0, Quote P_1)
	{
		녴((MessageQuote)P_1);
	}

	private void 녴(Symbol P_0, Level2Quote P_1, DOMQuote P_2)
	{
		녴(P_2);
		녴(P_1);
	}

	private void 녴(Symbol P_0, Last P_1)
	{
		녴((MessageQuote)P_1);
	}

	private void 녴(Symbol P_0, Mark P_1)
	{
		녴((MessageQuote)P_1);
	}

	private void 녴(Symbol P_0, DayBar P_1)
	{
		녴((MessageQuote)P_1);
	}

	internal void 녴(Action P_0)
	{
		lock (놰놬)
		{
			P_0();
		}
	}

	internal void 녴(MessageQuote P_0)
	{
		if (P_0 == null)
		{
			return;
		}
		if (!(P_0 is Quote quote))
		{
			if (!(P_0 is Level2Quote level2Quote))
			{
				if (!(P_0 is DOMQuote dOMQuote))
				{
					if (!(P_0 is Last last))
					{
						if (!(P_0 is Mark mark))
						{
							if (!(P_0 is DayBar dayBar))
							{
								return;
							}
							Func<double, double, double> func;
							Func<long, long, long> func2;
							if (dayBar.FullRefresh)
							{
								func = (double P_0, double P_1) => P_0;
								func2 = (long P_0, long P_1) => P_0;
							}
							else
							{
								func = CoreMath.ProcessNaN;
								func2 = (long P_0, long P_1) => (P_0 < 0) ? P_1 : P_0;
							}
							Open = func(dayBar.Open, Open);
							High = func(dayBar.High, High);
							Low = func(dayBar.Low, Low);
							PrevClose = func(dayBar.PreviousClose, PrevClose);
							Volume = func(dayBar.Volume, Volume);
							QuoteAssetVolume = func(dayBar.QuoteAssetVolume, QuoteAssetVolume);
							PrevSettlement = func(dayBar.PrevSettlementPrice, PrevSettlement);
							Ticks = func2(dayBar.Ticks, Ticks);
							Trades = func2(dayBar.Trades, Trades);
							Bid = func(dayBar.Bid, Bid);
							BidSize = func(dayBar.BidSize, BidSize);
							Ask = func(dayBar.Ask, Ask);
							AskSize = func(dayBar.AskSize, AskSize);
							Last = func(dayBar.Last, Last);
							LastSize = func(dayBar.LastSize, LastSize);
							Mark = func(dayBar.Mark, Mark);
							MarkSize = func(dayBar.MarkSize, MarkSize);
							if (!AllowCalculateRealtimeChange)
							{
								놰뇍 = func(dayBar.Change, 놰뇍);
								놰놙 = func(dayBar.ChangePercentage, 놰놙);
							}
							OpenInterest = func(dayBar.OpenInterest, OpenInterest);
							FundingRate = func(dayBar.FundingRate, FundingRate);
							TopPriceLimit = func(dayBar.TopPriceLimit, TopPriceLimit);
							BottomPriceLimit = func(dayBar.BottomPriceLimit, BottomPriceLimit);
							AverageTradedPrice = func(dayBar.AverageTradedPrice, AverageTradedPrice);
							TotalBuyQuantity = dayBar.TotalBuyQuantity;
							TotalSellQuantity = dayBar.TotalSellQuantity;
							IV = dayBar.IV;
							Delta = dayBar.Delta;
							Vega = dayBar.Vega;
							Gamma = dayBar.Gamma;
							Theta = dayBar.Theta;
							Rho = dayBar.Rho;
							녴(dayBar);
						}
						else
						{
							Mark = mark.Price;
							MarkSize = CoreMath.ProcessNaN(mark.Size, MarkSize);
							녴(mark);
						}
						return;
					}
					if (HistoryMetadata != null && !HistoryMetadata.ServerSideTickDirectionAvailable)
					{
						last.TickDirection = DetermineTickDirection(Last, last.Price, 놰놊);
					}
					놰놊 = last.TickDirection;
					Last = last.Price;
					LastSize = last.Size;
					LastDateTime = last.Time;
					if (AllowCalculateRealtimeVolume)
					{
						Volume += last.Size;
						if (!double.IsNaN(last.QuoteAssetVolume))
						{
							QuoteAssetVolume += last.QuoteAssetVolume;
						}
					}
					if (AllowCalculateRealtimeTrades)
					{
						Trades++;
					}
					if (!double.IsNaN(last.OpenInterest))
					{
						OpenInterest = last.OpenInterest;
					}
					녴(last);
				}
				else
				{
					DepthOfMarket.녴(dOMQuote);
					녴(null, dOMQuote);
				}
			}
			else
			{
				DepthOfMarket.녴(level2Quote);
				녴(level2Quote, null);
			}
		}
		else
		{
			quote.BidTickDirection = DetermineTickDirection(Bid, quote.Bid, 놰놪);
			quote.AskTickDirection = DetermineTickDirection(Ask, quote.Ask, 놰놌);
			놰놪 = quote.BidTickDirection;
			놰놌 = quote.AskTickDirection;
			if (!double.IsNaN(quote.Bid))
			{
				Bid = quote.Bid;
			}
			if (!double.IsNaN(quote.BidSize))
			{
				BidSize = quote.BidSize;
			}
			if (!double.IsNaN(quote.Ask))
			{
				Ask = quote.Ask;
			}
			if (!double.IsNaN(quote.AskSize))
			{
				AskSize = quote.AskSize;
			}
			QuoteDateTime = quote.Time;
			if (AllowCalculateRealtimeTicks)
			{
				Ticks++;
			}
			녴(quote);
		}
	}

	private void 녴(Quote P_0)
	{
		놰놋?.Invoke(this, P_0);
	}

	private void 녴(Level2Quote P_0, DOMQuote P_1)
	{
		놰녣?.Invoke(this, P_0, P_1);
	}

	private void 녴(Last P_0)
	{
		놰녩?.Invoke(this, P_0);
	}

	private void 녴(Mark P_0)
	{
		놰놤?.Invoke(this, P_0);
	}

	private void 녴(DayBar P_0)
	{
		놰논?.Invoke(this, P_0);
	}

	/// <summary>
	/// Gets historical data according to period and other parameters
	/// </summary>
	/// <param name="period"></param>
	/// <param name="fromTime"></param>
	/// <param name="toTime"></param>
	/// <returns></returns>
	public HistoricalData GetHistory(Period period, DateTime fromTime, DateTime toTime = default(DateTime))
	{
		return GetHistory(period, HistoryType, fromTime, toTime);
	}

	/// <summary>
	/// Gets historical data according to period and other parameters
	/// </summary>
	/// <param name="period"></param>
	/// <param name="historyType"></param>
	/// <param name="fromTime"></param>
	/// <param name="toTime"></param>
	/// <returns></returns>
	public HistoricalData GetHistory(Period period, HistoryType historyType, DateTime fromTime, DateTime toTime = default(DateTime))
	{
		HistoryAggregation aggregation = ((period.BasePeriod != 0) ? new HistoryAggregationTime(period, historyType) : ((period.PeriodMultiplier != 1) ? ((HistoryAggregation)new HistoryAggregationTickBars(period.PeriodMultiplier, historyType)) : ((HistoryAggregation)new HistoryAggregationTick(historyType))));
		HistoryRequestParameters historyRequestParameters = new HistoryRequestParameters
		{
			Symbol = this,
			Aggregation = aggregation,
			FromTime = fromTime,
			ToTime = toTime
		};
		return GetHistory(historyRequestParameters);
	}

	/// <summary>
	/// Gets historical data according to aggregation and other parameters
	/// </summary>
	/// <param name="aggregation"></param>
	/// <param name="historyType"></param>
	/// <param name="fromTime"></param>
	/// <param name="toTime"></param>
	/// <returns></returns>
	public HistoricalData GetHistory(HistoryAggregation aggregation, DateTime fromTime, DateTime toTime = default(DateTime))
	{
		return GetHistory(new HistoryRequestParameters
		{
			Symbol = this,
			Aggregation = aggregation,
			FromTime = fromTime,
			ToTime = toTime
		});
	}

	/// <summary>
	/// Gets historical data according to given history request
	/// </summary>
	/// <param name="historyRequestParameters"></param>
	/// <returns></returns>
	public HistoricalData GetHistory(HistoryRequestParameters historyRequestParameters)
	{
		if (historyRequestParameters == null)
		{
			throw new ArgumentNullException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸뇉());
		}
		historyRequestParameters.Symbol = this;
		HistoricalData historicalData = 녴(historyRequestParameters);
		historicalData.Reload();
		return historicalData;
	}

	private protected virtual HistoricalData 녴(HistoryRequestParameters P_0)
	{
		return new HistoricalData(P_0);
	}

	/// <summary>
	/// Gets historical ticks data according to given parameters
	/// </summary>
	/// <param name="historyType"></param>
	/// <param name="fromTime"></param>
	/// <param name="toTime"></param>
	/// <returns></returns>
	public HistoricalData GetTickHistory(HistoryType historyType, DateTime fromTime, DateTime toTime = default(DateTime))
	{
		return GetHistory(new HistoryRequestParameters
		{
			Symbol = this,
			Aggregation = new HistoryAggregationTick(historyType),
			FromTime = fromTime,
			ToTime = toTime
		});
	}

	/// <summary>
	/// Returns rounded to <see cref="P:TradingPlatform.BusinessLayer.Symbol.TickSize" /> price
	/// </summary>
	public double RoundPriceToTickSize(double price, double tickSize = double.NaN)
	{
		if (double.IsNaN(price) || (VariableTickList == null && tickSize.IsNanOrDefault()))
		{
			return 0.0;
		}
		if (tickSize.IsNanOrDefault())
		{
			VariableTick variableTick = FindVariableTick(price);
			if (variableTick == null)
			{
				return price;
			}
			tickSize = variableTick.TickSize;
		}
		return CoreMath.RoundToIncrement(price, tickSize);
	}

	/// <summary>
	/// Calculates new price which equal to given price shifted by a number of given ticks
	/// </summary>
	/// <param name="price"></param>
	/// <param name="ticks"></param>
	/// <returns></returns>
	public double CalculatePrice(double price, double ticks)
	{
		decimal num = (decimal)price;
		decimal num2 = (decimal)ticks;
		return (double)(num + num2 * (decimal)GetTickSize(price));
	}

	/// <summary>
	/// Calculates ticks between two prices
	/// </summary>
	/// <param name="price1"></param>
	/// <param name="price2"></param>
	/// <returns></returns>
	public double CalculateTicks(double price1, double price2)
	{
		if (double.IsNaN(price1) || double.IsNaN(price2))
		{
			return double.NaN;
		}
		decimal num = (decimal)price1;
		decimal num2 = (decimal)price2;
		decimal num3 = (decimal)GetTickSize(price1);
		decimal num4 = default(decimal);
		if (num3 != 0m)
		{
			num4 = (num2 - num) / num3;
		}
		return (double)num4;
	}

	/// <summary>
	/// Gets cached symbol tick size or retrives it from the <see cref="T:TradingPlatform.BusinessLayer.VariableTick" /> list
	/// </summary>
	/// <param name="price"></param>
	/// <returns></returns>
	public double GetTickSize(double price)
	{
		if (놰녜.HasValue)
		{
			return 놰녜.Value;
		}
		return FindVariableTick(price)?.TickSize ?? double.NaN;
	}

	/// <summary>
	/// Gets symbol tick cost retrived from the <see cref="T:TradingPlatform.BusinessLayer.VariableTick" /> list by price
	/// </summary>
	/// <param name="price"></param>
	/// <returns></returns>
	public double GetTickCost(double price)
	{
		return FindVariableTick(price)?.TickCost ?? double.NaN;
	}

	/// <summary>
	/// Returns VariableTick if it can be retrived from <see cref="T:TradingPlatform.BusinessLayer.VariableTick" /> list by price or null
	/// </summary>
	/// <param name="price"></param>
	/// <returns></returns>
	public VariableTick FindVariableTick(double price)
	{
		List<VariableTick> variableTickList = VariableTickList;
		if (variableTickList == null)
		{
			if (Underlier != null)
			{
				variableTickList = Underlier.VariableTickList;
			}
			if (variableTickList == null)
			{
				return null;
			}
		}
		for (int num = variableTickList.Count - 1; num >= 0; num--)
		{
			VariableTick variableTick = variableTickList[num];
			if (variableTick.CheckPrice(price))
			{
				return variableTick;
			}
		}
		return null;
	}

	private protected void 놴()
	{
		놰녘?.Invoke(this);
	}

	[NotPublished]
	public override string ToString()
	{
		return Name;
	}

	[NotPublished]
	public override BusinessObjectInfo CreateInfo()
	{
		return new SymbolInfo
		{
			ConnectionId = base.ConnectionId,
			Id = Id,
			Name = Name,
			ExchangeId = ExchangeId,
			SymbolType = SymbolType,
			FutureContractType = FutureContractType,
			UnderlierId = UnderlierId,
			Root = Root,
			ExpirationDate = ExpirationDate
		};
	}

	public override bool Equals(object obj)
	{
		return Equals(obj as Symbol);
	}

	public bool Equals(Symbol other)
	{
		if (other != null && base.ConnectionId == other.ConnectionId)
		{
			return Id == other.Id;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return (-1919740922 * -1521134295 + EqualityComparer<string>.Default.GetHashCode(base.ConnectionId)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Id);
	}

	/// <summary>
	/// Formats price value to the appropriative string with a counting on tick precision.
	/// </summary>
	/// <param name="price"></param>
	/// <returns></returns>
	public string FormatPrice(double price)
	{
		VariableTick variableTick = FindVariableTick(price);
		double num = Math.Abs(price);
		if (AllowAbbreviatePriceByTickSize && GlobalSettings.AbbreviateCryptoPrices && num != 0.0 && num < 1.0 && variableTick != null)
		{
			int num2 = -(int)Math.Floor(Math.Log10(num)) - 1;
			if (num2 == 0)
			{
				if (variableTick != null)
				{
					return price.Format(variableTick.Precision);
				}
				return price.Format();
			}
			string value = string.Empty;
			if (price < 0.0)
			{
				value = _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놎놙();
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 2);
			defaultInterpolatedStringHandler.AppendFormatted(value);
			defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸녺());
			defaultInterpolatedStringHandler.AppendFormatted(num2);
			defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놢());
			return defaultInterpolatedStringHandler.ToStringAndClear() + (num / variableTick.TickSize).ToString(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸뇍(), CultureInfo.InvariantCulture);
		}
		if (variableTick != null && (variableTick.TickSize == 1.0 / 32.0 || variableTick.TickSize == 1.0 / 64.0 || variableTick.TickSize == 1.0 / 128.0 || variableTick.TickSize == 1.0 / 256.0))
		{
			return 녴(price, variableTick);
		}
		if (variableTick != null)
		{
			return price.Format(variableTick.Precision);
		}
		return price.Format();
	}

	/// <summary>
	/// Formats price value to the appropriative string with a counting on max tick precision.
	/// </summary>
	/// <param name="price"></param>
	/// <returns></returns>
	public string FormatPriceWithMaxPrecision(double price)
	{
		VariableTick variableTick = FindVariableTick(price);
		if (variableTick != null && (variableTick.TickSize == 1.0 / 32.0 || variableTick.TickSize == 1.0 / 64.0 || variableTick.TickSize == 1.0 / 128.0 || variableTick.TickSize == 1.0 / 256.0))
		{
			return 녴(price, variableTick);
		}
		if (variableTick != null)
		{
			return price.FormatPriceWithMaxPrecision(variableTick.Precision);
		}
		return price.FormatPriceWithMaxPrecision();
	}

	private static string 녴(double P_0, VariableTick P_1)
	{
		double num = Math.Abs(P_0 - (double)(long)P_0);
		string value = ((P_1.TickSize == 1.0 / 32.0) ? ((double)(decimal)(num / P_1.TickSize)).ToString(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸놙()) : ((P_1.TickSize == 1.0 / 64.0) ? ((double)(decimal)(num / P_1.TickSize / 2.0 * 10.0)).ToString(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸녰()) : ((P_1.TickSize != 1.0 / 128.0) ? ((double)(decimal)(long)(num / P_1.TickSize / 8.0 * 10.0)).ToString(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸녰()) : ((double)(decimal)(long)(num / P_1.TickSize / 4.0 * 10.0)).ToString(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸녰()))));
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 3);
		defaultInterpolatedStringHandler.AppendFormatted((P_0 < 0.0) ? _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놎놙() : _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놇());
		defaultInterpolatedStringHandler.AppendFormatted((long)Math.Abs(P_0));
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴놺());
		defaultInterpolatedStringHandler.AppendFormatted(value);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	public virtual string FormatQuantity(double quantity, bool inLots = true, bool abbreviate = false)
	{
		if (inLots)
		{
			int valuePrecision = CoreMath.GetValuePrecision((decimal)LotStep);
			return quantity.Format(valuePrecision, abbreviate);
		}
		return (quantity * LotSize).Format(CoreMath.GetValuePrecision((decimal)NotionalValueStep), abbreviate);
	}

	/// <summary>
	/// Returns string with formatted ticks value
	/// </summary>
	/// <param name="offset"></param>
	/// <param name="dimension"></param>
	/// <returns></returns>
	public string FormatOffset(double offset, string dimension = "ticks")
	{
		return offset.FormatPriceWithMaxPrecision(0) + _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놀() + dimension;
	}

	[NotPublished]
	public string FormatQuoteAssetVolume(double volume)
	{
		return volume.Format();
	}

	/// <summary>
	/// Comparing by <see cref="P:TradingPlatform.BusinessLayer.Symbol.Name" /> value
	/// </summary>
	[NotPublished]
	public int CompareTo(Symbol symbol)
	{
		return Name.CompareTo(symbol.Name);
	}

	private MessageSymbol 놂()
	{
		return new MessageSymbol(Id)
		{
			GroupId = Group?.Id,
			Name = Name,
			Description = Description,
			SymbolType = SymbolType,
			ProductAssetId = Product?.Id,
			QuotingCurrencyAssetID = QuotingCurrency?.Id,
			ExchangeId = ExchangeId,
			QuoteDelay = QuoteDelay,
			QuotingType = QuotingType,
			LotSize = LotSize,
			VariableTickList = VariableTickList,
			LotStep = LotStep,
			NotionalValueStep = NotionalValueStep,
			MaxLot = MaxLot,
			MinLot = MinLot,
			SymbolAdditionalInfo = AdditionalInfo?.Items.ToList(),
			NettingType = NettingType,
			Root = Root,
			OptionType = OptionType,
			StrikePrice = StrikePrice,
			ExpirationDate = ExpirationDate,
			HistoryType = HistoryType,
			VolumeType = VolumeType,
			LastTradingDate = LastTradingDate,
			AllowCalculateRealtimeTicks = AllowCalculateRealtimeTicks,
			AllowCalculateRealtimeTrades = AllowCalculateRealtimeTrades,
			AllowCalculateRealtimeVolume = AllowCalculateRealtimeVolume,
			AllowCalculateRealtimeChange = AllowCalculateRealtimeChange,
			AllowAbbreviatePriceByTickSize = AllowAbbreviatePriceByTickSize,
			DeltaCalculationType = DeltaCalculationType,
			MinVolumeAnalysisTickSize = MinVolumeAnalysisTickSize,
			AvailableFutures = AvailableFutures,
			AvailableOptions = AvailableOptions,
			AvailableOptionsExchanges = (AvailableOptionsExchanges.Any() ? AvailableOptionsExchanges.Select((Exchange P_0) => P_0.Id).ToArray() : null),
			UnderlierId = Underlier?.Id,
			MaturityDate = MaturityDate,
			OptionSerieId = OptionSerie?.Id,
			SessionsContainerId = 놓녞,
			HistoryMetadata = ((historyMetadata == null) ? null : new HistoryMetadata(historyMetadata)),
			FutureContractType = FutureContractType
		};
	}

	MessageSymbol IMessageBuilder<MessageSymbol>.BuildMessage()
	{
		//ILSpy generated this explicit interface implementation from .override directive in 놂
		return this.놂();
	}

	private DayBar 놎()
	{
		return new DayBar(Id, Core.Instance.TimeUtils.DateTimeUtcNow)
		{
			Ask = Ask,
			AskSize = AskSize,
			AverageTradedPrice = AverageTradedPrice,
			TotalBuyQuantity = TotalBuyQuantity,
			TotalSellQuantity = TotalSellQuantity,
			Bid = Bid,
			BidSize = BidSize,
			BottomPriceLimit = BottomPriceLimit,
			Change = Change,
			ChangePercentage = ChangePercentage,
			High = High,
			Last = Last,
			LastSize = LastSize,
			Mark = Mark,
			Low = Low,
			Open = Open,
			OpenInterest = OpenInterest,
			FundingRate = FundingRate,
			PreviousClose = PrevClose,
			PrevSettlementPrice = PrevSettlement,
			Ticks = Ticks,
			TopPriceLimit = TopPriceLimit,
			Trades = Trades,
			Volume = Volume,
			QuoteAssetVolume = QuoteAssetVolume,
			IV = IV,
			Delta = Delta,
			Vega = Vega,
			Gamma = Gamma,
			Theta = Theta,
			Rho = Rho
		};
	}

	DayBar IMessageBuilder<DayBar>.BuildMessage()
	{
		//ILSpy generated this explicit interface implementation from .override directive in 놎
		return this.놎();
	}

	/// <summary>
	/// Gets symbol orders types list which are allowed.
	/// </summary>
	/// <param name="usage"></param>
	/// <returns></returns>
	[NotPublished]
	public virtual List<OrderType> GetAlowedOrderTypes(OrderTypeUsage? usage)
	{
		if (State == BusinessObjectState.Fake)
		{
			return new List<OrderType>();
		}
		string connectionId = base.ConnectionId;
		Connection connection = Core.Instance.Connections[connectionId];
		if (connection == null || connection.BusinessObjects.OrderTypes == null)
		{
			return null;
		}
		if (!usage.HasValue)
		{
			return connection.BusinessObjects.OrderTypes.ToList();
		}
		return connection.BusinessObjects.OrderTypes.Where((OrderType P_0) => P_0.Usage.HasFlag(usage)).ToList();
	}

	public virtual bool IsTradingAllowed(Account account)
	{
		return TradingOperations.IsAllowed(TradingOperation.PlaceOrder, new TradingOperationParameters
		{
			Symbol = this,
			Account = account
		}).Status != TradingOperationStatus.NotAllowed;
	}

	internal virtual TradingOperationResult 녴(PlaceOrderRequestParameters P_0)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵녣());
		}
		return Connection.녴(P_0);
	}

	/// <summary>
	/// An symbol has possibility to obtain the default account
	/// </summary>
	[NotPublished]
	public virtual Account GetDefaultAccount(Account currentValue = null)
	{
		if (currentValue?.ConnectionId == base.ConnectionId)
		{
			return currentValue;
		}
		return Connection?.BusinessObjects?.Accounts?.FirstOrDefault();
	}

	public MarginInfo GetMarginInfo(OrderRequestParameters orderRequestParameters)
	{
		return Connection?.녴(orderRequestParameters);
	}

	public virtual ConnectionDependency GetConnectionStateDependency()
	{
		ConnectionDependency connectionDependency = new ConnectionDependency();
		connectionDependency.Behavior = ConnectionDependencyBehavior.PartialDependency;
		connectionDependency.DependentConnectionsIds = new string[1] { base.ConnectionId };
		return connectionDependency;
	}

	public virtual void OnConnectionStateChanged(Connection connection, ConnectionStateChangedEventArgs e)
	{
	}

	public static TickDirection DetermineTickDirection(double previousPrice, double currentPrice, TickDirection prevItemTickDirection)
	{
		if (double.IsNaN(previousPrice))
		{
			return TickDirection.NotSet;
		}
		if (double.IsNaN(currentPrice))
		{
			return TickDirection.NotSet;
		}
		if (currentPrice > previousPrice)
		{
			return TickDirection.Up;
		}
		if (currentPrice < previousPrice)
		{
			return TickDirection.Down;
		}
		return prevItemTickDirection;
	}

	[NotPublished]
	public static AggressorFlag ConvertTickDirection(TickDirection tickDirection)
	{
		return tickDirection switch
		{
			TickDirection.None => AggressorFlag.None, 
			TickDirection.Up => AggressorFlag.Buy, 
			TickDirection.Down => AggressorFlag.Sell, 
			_ => AggressorFlag.NotSet, 
		};
	}

	[CompilerGenerated]
	private void 녴(Rule P_0)
	{
		놰노.녴(P_0.Name, P_0);
	}
}
