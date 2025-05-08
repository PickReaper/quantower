using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Xml.Linq;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using ProtoBuf;
using TradingPlatform.BusinessLayer.Integration;
using TradingPlatform.BusinessLayer.Serialization;

namespace TradingPlatform.BusinessLayer;

/// <summary>
/// Represent access to DayBar quote, which contains summary information about instrument prices.
/// </summary>
[DataContract(Name = "DayBar", Namespace = "TradingPlatform")]
[ProtoContract]
[Published]
public class DayBar : MessageQuote, IXElementSerialization
{
	[CompilerGenerated]
	private double 뇅놇;

	[CompilerGenerated]
	private double 뇅뇅;

	[CompilerGenerated]
	private double 뇅놵;

	[CompilerGenerated]
	private double 뇅놡;

	[CompilerGenerated]
	private long 뇅놻;

	[CompilerGenerated]
	private double 뇅놃;

	[CompilerGenerated]
	private double 뇅뇇;

	[CompilerGenerated]
	private double 뇅놛;

	[CompilerGenerated]
	private double 뇅놼;

	[CompilerGenerated]
	private double 뇅놗;

	[CompilerGenerated]
	private double 뇅뇂;

	[CompilerGenerated]
	private double 뇅놩;

	[CompilerGenerated]
	private double 뇅녡;

	[CompilerGenerated]
	private double 뇅녦;

	[CompilerGenerated]
	private long 뇅놀;

	[CompilerGenerated]
	private double 뇅놔;

	[CompilerGenerated]
	private double 뇅놾;

	[CompilerGenerated]
	private double 뇅뇀;

	[CompilerGenerated]
	private double 뇅놽;

	[CompilerGenerated]
	private double 뇅녿;

	[CompilerGenerated]
	private double 뇅놁;

	[CompilerGenerated]
	private double 뇅녭;

	[CompilerGenerated]
	private double 뇅녱;

	[CompilerGenerated]
	private double 뇅놲;

	[CompilerGenerated]
	private double 뇅높;

	[CompilerGenerated]
	private double 뇅놶;

	[CompilerGenerated]
	private double 뇅뇏;

	[CompilerGenerated]
	private double 뇅녻;

	[CompilerGenerated]
	private double 뇅녙;

	[CompilerGenerated]
	private double 뇅놢;

	[CompilerGenerated]
	private double 뇅녧;

	[CompilerGenerated]
	private double 뇅녤;

	[CompilerGenerated]
	private bool 뇅놆;

	[NotPublished]
	public override MessageType Type => MessageType.DayBar;

	/// <summary>
	/// High price
	/// </summary>
	[DataMember(Name = "High")]
	[ProtoMember(1)]
	public double High
	{
		[CompilerGenerated]
		get
		{
			return 뇅놇;
		}
		[CompilerGenerated]
		set
		{
			뇅놇 = value;
		}
	}

	/// <summary>
	/// Open price
	/// </summary>
	[DataMember(Name = "Open")]
	[ProtoMember(2)]
	public double Open
	{
		[CompilerGenerated]
		get
		{
			return 뇅뇅;
		}
		[CompilerGenerated]
		set
		{
			뇅뇅 = value;
		}
	}

	/// <summary>
	/// Low price
	/// </summary>
	[DataMember(Name = "Low")]
	[ProtoMember(3)]
	public double Low
	{
		[CompilerGenerated]
		get
		{
			return 뇅놵;
		}
		[CompilerGenerated]
		set
		{
			뇅놵 = value;
		}
	}

	/// <summary>
	/// Previous Close price
	/// </summary>
	[DataMember(Name = "PreviousClose")]
	[ProtoMember(4)]
	public double PreviousClose
	{
		[CompilerGenerated]
		get
		{
			return 뇅놡;
		}
		[CompilerGenerated]
		set
		{
			뇅놡 = value;
		}
	}

	/// <summary>
	/// Ticks value
	/// </summary>
	[DataMember(Name = "Ticks")]
	[ProtoMember(5)]
	public long Ticks
	{
		[CompilerGenerated]
		get
		{
			return 뇅놻;
		}
		[CompilerGenerated]
		set
		{
			뇅놻 = value;
		}
	}

	/// <summary>
	/// Volume value
	/// </summary>
	[DataMember(Name = "Volume")]
	[ProtoMember(6)]
	public double Volume
	{
		[CompilerGenerated]
		get
		{
			return 뇅놃;
		}
		[CompilerGenerated]
		set
		{
			뇅놃 = value;
		}
	}

	/// <summary>
	/// Volume value
	/// </summary>
	[DataMember(Name = "quoteAssetVolume")]
	[ProtoMember(7)]
	public double QuoteAssetVolume
	{
		[CompilerGenerated]
		get
		{
			return 뇅뇇;
		}
		[CompilerGenerated]
		set
		{
			뇅뇇 = value;
		}
	}

	/// <summary>
	/// Previous settlement price
	/// </summary>
	[DataMember(Name = "PrevSettlementPrice")]
	[ProtoMember(8)]
	public double PrevSettlementPrice
	{
		[CompilerGenerated]
		get
		{
			return 뇅놛;
		}
		[CompilerGenerated]
		set
		{
			뇅놛 = value;
		}
	}

	/// <summary>
	/// Bid price
	/// </summary>
	[DataMember(Name = "Bid")]
	[ProtoMember(9)]
	public double Bid
	{
		[CompilerGenerated]
		get
		{
			return 뇅놼;
		}
		[CompilerGenerated]
		set
		{
			뇅놼 = value;
		}
	}

	/// <summary>
	/// Bid size
	/// </summary>
	[DataMember(Name = "BidSize")]
	[ProtoMember(10)]
	public double BidSize
	{
		[CompilerGenerated]
		get
		{
			return 뇅놗;
		}
		[CompilerGenerated]
		set
		{
			뇅놗 = value;
		}
	}

	/// <summary>
	/// Ask price
	/// </summary>
	[DataMember(Name = "Ask")]
	[ProtoMember(11)]
	public double Ask
	{
		[CompilerGenerated]
		get
		{
			return 뇅뇂;
		}
		[CompilerGenerated]
		set
		{
			뇅뇂 = value;
		}
	}

	/// <summary>
	/// Ask size
	/// </summary>
	[DataMember(Name = "AskSize")]
	[ProtoMember(12)]
	public double AskSize
	{
		[CompilerGenerated]
		get
		{
			return 뇅놩;
		}
		[CompilerGenerated]
		set
		{
			뇅놩 = value;
		}
	}

	/// <summary>
	/// Last price
	/// </summary>
	[DataMember(Name = "Last")]
	[ProtoMember(13)]
	public double Last
	{
		[CompilerGenerated]
		get
		{
			return 뇅녡;
		}
		[CompilerGenerated]
		set
		{
			뇅녡 = value;
		}
	}

	/// <summary>
	/// Last size
	/// </summary>
	[DataMember(Name = "LastSize")]
	[ProtoMember(14)]
	public double LastSize
	{
		[CompilerGenerated]
		get
		{
			return 뇅녦;
		}
		[CompilerGenerated]
		set
		{
			뇅녦 = value;
		}
	}

	/// <summary>
	/// Trades value
	/// </summary>
	[DataMember(Name = "Trades")]
	[ProtoMember(15)]
	public long Trades
	{
		[CompilerGenerated]
		get
		{
			return 뇅놀;
		}
		[CompilerGenerated]
		set
		{
			뇅놀 = value;
		}
	}

	/// <summary>
	/// Change value
	/// </summary>
	[DataMember(Name = "Change")]
	[ProtoMember(16)]
	public double Change
	{
		[CompilerGenerated]
		get
		{
			return 뇅놔;
		}
		[CompilerGenerated]
		set
		{
			뇅놔 = value;
		}
	}

	/// <summary>
	/// Change value in percentage
	/// </summary>
	[DataMember(Name = "ChangePercentage")]
	[ProtoMember(17)]
	public double ChangePercentage
	{
		[CompilerGenerated]
		get
		{
			return 뇅놾;
		}
		[CompilerGenerated]
		set
		{
			뇅놾 = value;
		}
	}

	/// <summary>
	///
	/// </summary>
	[DataMember(Name = "OpenInterest")]
	[ProtoMember(18)]
	public double OpenInterest
	{
		[CompilerGenerated]
		get
		{
			return 뇅뇀;
		}
		[CompilerGenerated]
		set
		{
			뇅뇀 = value;
		}
	}

	[DataMember(Name = "TopPriceLimit")]
	[ProtoMember(19)]
	public double TopPriceLimit
	{
		[CompilerGenerated]
		get
		{
			return 뇅놽;
		}
		[CompilerGenerated]
		set
		{
			뇅놽 = value;
		}
	}

	[DataMember(Name = "BottomPriceLimit")]
	[ProtoMember(20)]
	public double BottomPriceLimit
	{
		[CompilerGenerated]
		get
		{
			return 뇅녿;
		}
		[CompilerGenerated]
		set
		{
			뇅녿 = value;
		}
	}

	[DataMember(Name = "AverageTradedPrice")]
	[ProtoMember(21)]
	public double AverageTradedPrice
	{
		[CompilerGenerated]
		get
		{
			return 뇅놁;
		}
		[CompilerGenerated]
		set
		{
			뇅놁 = value;
		}
	}

	[DataMember(Name = "TotalBuyQuantity")]
	[ProtoMember(22)]
	public double TotalBuyQuantity
	{
		[CompilerGenerated]
		get
		{
			return 뇅녭;
		}
		[CompilerGenerated]
		set
		{
			뇅녭 = value;
		}
	}

	[DataMember(Name = "TotalSellQuantity")]
	[ProtoMember(23)]
	public double TotalSellQuantity
	{
		[CompilerGenerated]
		get
		{
			return 뇅녱;
		}
		[CompilerGenerated]
		set
		{
			뇅녱 = value;
		}
	}

	[DataMember(Name = "IV")]
	[ProtoMember(24)]
	public double IV
	{
		[CompilerGenerated]
		get
		{
			return 뇅놲;
		}
		[CompilerGenerated]
		set
		{
			뇅놲 = value;
		}
	}

	[DataMember(Name = "Delta")]
	[ProtoMember(25)]
	public double Delta
	{
		[CompilerGenerated]
		get
		{
			return 뇅높;
		}
		[CompilerGenerated]
		set
		{
			뇅높 = value;
		}
	}

	[DataMember(Name = "Vega")]
	[ProtoMember(26)]
	public double Vega
	{
		[CompilerGenerated]
		get
		{
			return 뇅놶;
		}
		[CompilerGenerated]
		set
		{
			뇅놶 = value;
		}
	}

	[DataMember(Name = "Gamma")]
	[ProtoMember(27)]
	public double Gamma
	{
		[CompilerGenerated]
		get
		{
			return 뇅뇏;
		}
		[CompilerGenerated]
		set
		{
			뇅뇏 = value;
		}
	}

	[DataMember(Name = "Theta")]
	[ProtoMember(28)]
	public double Theta
	{
		[CompilerGenerated]
		get
		{
			return 뇅녻;
		}
		[CompilerGenerated]
		set
		{
			뇅녻 = value;
		}
	}

	[DataMember(Name = "Rho")]
	[ProtoMember(29)]
	public double Rho
	{
		[CompilerGenerated]
		get
		{
			return 뇅녙;
		}
		[CompilerGenerated]
		set
		{
			뇅녙 = value;
		}
	}

	[DataMember(Name = "Mark")]
	[ProtoMember(30)]
	public double Mark
	{
		[CompilerGenerated]
		get
		{
			return 뇅놢;
		}
		[CompilerGenerated]
		set
		{
			뇅놢 = value;
		}
	}

	[DataMember(Name = "MarkSize")]
	[ProtoMember(31)]
	public double MarkSize
	{
		[CompilerGenerated]
		get
		{
			return 뇅녧;
		}
		[CompilerGenerated]
		set
		{
			뇅녧 = value;
		}
	}

	[DataMember(Name = "FundingRate")]
	[ProtoMember(32)]
	public double FundingRate
	{
		[CompilerGenerated]
		get
		{
			return 뇅녤;
		}
		[CompilerGenerated]
		set
		{
			뇅녤 = value;
		}
	}

	internal bool FullRefresh
	{
		[CompilerGenerated]
		get
		{
			return 뇅놆;
		}
		[CompilerGenerated]
		set
		{
			뇅놆 = value;
		}
	}

	private DayBar()
	{
	}

	[NotPublished]
	public DayBar(string symbolId, DateTime time)
		: base(symbolId, time)
	{
		High = double.NaN;
		Open = double.NaN;
		Low = double.NaN;
		PreviousClose = double.NaN;
		Ticks = -1L;
		Volume = double.NaN;
		QuoteAssetVolume = double.NaN;
		PrevSettlementPrice = double.NaN;
		Bid = double.NaN;
		BidSize = double.NaN;
		Ask = double.NaN;
		AskSize = double.NaN;
		Last = double.NaN;
		LastSize = double.NaN;
		Mark = double.NaN;
		Trades = -1L;
		Change = double.NaN;
		ChangePercentage = double.NaN;
		OpenInterest = double.NaN;
		TopPriceLimit = double.NaN;
		BottomPriceLimit = double.NaN;
		AverageTradedPrice = double.NaN;
		TotalBuyQuantity = double.NaN;
		TotalSellQuantity = double.NaN;
		IV = double.NaN;
		Delta = double.NaN;
		Vega = double.NaN;
		Gamma = double.NaN;
		Theta = double.NaN;
		Rho = double.NaN;
		FundingRate = double.NaN;
	}

	[NotPublished]
	public XElement ToXElement()
	{
		XElement xElement = new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿뇎());
		xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇋녷(), base.SymbolId));
		xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놂(), Ask));
		xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놷(), AskSize));
		xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놴(), Bid));
		xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿녗(), BidSize));
		xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸녖(), Last));
		xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놜(), LastSize));
		xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿녴()), Mark);
		xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놨(), Open));
		xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿녢(), High));
		xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놞(), Low));
		xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놳(), PreviousClose));
		xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놿(), Ticks));
		xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놺(), Trades));
		xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놤(), Volume));
		xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놅(), QuoteAssetVolume));
		return xElement;
	}

	[NotPublished]
	public void FromXElement(XElement element, DeserializationInfo deserializationInfo)
	{
		XElement xElement = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇋녷());
		if (xElement != null)
		{
			base.SymbolId = xElement.Value;
		}
		XElement xElement2 = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놂());
		if (xElement2 != null)
		{
			Ask = xElement2.ToDouble();
		}
		XElement xElement3 = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놷());
		if (xElement3 != null)
		{
			AskSize = xElement3.ToDouble();
		}
		XElement xElement4 = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놴());
		if (xElement4 != null)
		{
			Bid = xElement4.ToDouble();
		}
		XElement xElement5 = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿녗());
		if (xElement5 != null)
		{
			BidSize = xElement5.ToDouble();
		}
		XElement xElement6 = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸녖());
		if (xElement6 != null)
		{
			Last = xElement6.ToDouble();
		}
		XElement xElement7 = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놜());
		if (xElement7 != null)
		{
			LastSize = xElement7.ToDouble();
		}
		XElement xElement8 = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿녴());
		if (xElement8 != null)
		{
			Mark = xElement8.ToDouble();
		}
		XElement xElement9 = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놨());
		if (xElement9 != null)
		{
			Open = xElement9.ToDouble();
		}
		XElement xElement10 = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿녢());
		if (xElement10 != null)
		{
			High = xElement10.ToDouble();
		}
		XElement xElement11 = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놞());
		if (xElement11 != null)
		{
			Low = xElement11.ToDouble();
		}
		XElement xElement12 = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놳());
		if (xElement12 != null)
		{
			PreviousClose = xElement12.ToDouble();
		}
		XElement xElement13 = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놿());
		if (xElement13 != null)
		{
			Ticks = xElement13.ToLong();
		}
		XElement xElement14 = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놺());
		if (xElement14 != null)
		{
			Trades = xElement14.ToLong();
		}
		XElement xElement15 = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놤());
		if (xElement15 != null)
		{
			Volume = xElement15.ToDouble();
		}
		XElement xElement16 = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놅());
		if (xElement16 != null)
		{
			QuoteAssetVolume = xElement16.ToDouble();
		}
	}
}
