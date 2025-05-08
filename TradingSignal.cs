using System;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using TradingPlatform.BusinessLayer.Integration;

namespace TradingPlatform.BusinessLayer;

public sealed class TradingSignal : BusinessObject, IMessageBuilder<MessageTradingSignal>
{
	[CompilerGenerated]
	private string 놓놭;

	[CompilerGenerated]
	private string 놓녲;

	[CompilerGenerated]
	private string 놓뇋;

	[CompilerGenerated]
	private string 놓놸;

	[CompilerGenerated]
	private Side 놓놿;

	[CompilerGenerated]
	private OrderTypeBehavior 놓놄;

	[CompilerGenerated]
	private double 놓놰;

	[CompilerGenerated]
	private double 놓놓;

	[CompilerGenerated]
	private double 놓놇;

	[CompilerGenerated]
	private double 놓뇅;

	[CompilerGenerated]
	private DateTime 놓놵;

	[CompilerGenerated]
	private DateTime 놓놡;

	[CompilerGenerated]
	private DateTime 놓놻;

	[CompilerGenerated]
	private string 놓놃;

	[CompilerGenerated]
	private string 놓뇇;

	[CompilerGenerated]
	private string 놓놛;

	[CompilerGenerated]
	private string 놓놼;

	[CompilerGenerated]
	private string 놓놗;

	public string Id
	{
		[CompilerGenerated]
		get
		{
			return 놓놭;
		}
		[CompilerGenerated]
		private set
		{
			놓놭 = value;
		}
	}

	public string Ticker
	{
		[CompilerGenerated]
		get
		{
			return 놓녲;
		}
		[CompilerGenerated]
		private set
		{
			놓녲 = value;
		}
	}

	public string Root
	{
		[CompilerGenerated]
		get
		{
			return 놓뇋;
		}
		[CompilerGenerated]
		private set
		{
			놓뇋 = value;
		}
	}

	public string VendorName
	{
		[CompilerGenerated]
		get
		{
			return 놓놸;
		}
		[CompilerGenerated]
		private set
		{
			놓놸 = value;
		}
	}

	public Side Side
	{
		[CompilerGenerated]
		get
		{
			return 놓놿;
		}
		[CompilerGenerated]
		private set
		{
			놓놿 = value;
		}
	}

	public OrderTypeBehavior OrderTypeBehavior
	{
		[CompilerGenerated]
		get
		{
			return 놓놄;
		}
		[CompilerGenerated]
		private set
		{
			놓놄 = value;
		}
	}

	public double EntryPrice
	{
		[CompilerGenerated]
		get
		{
			return 놓놰;
		}
		[CompilerGenerated]
		private set
		{
			놓놰 = value;
		}
	}

	public double TargetPrice
	{
		[CompilerGenerated]
		get
		{
			return 놓놓;
		}
		[CompilerGenerated]
		private set
		{
			놓놓 = value;
		}
	}

	public double StopPrice
	{
		[CompilerGenerated]
		get
		{
			return 놓놇;
		}
		[CompilerGenerated]
		private set
		{
			놓놇 = value;
		}
	}

	public double Confidence
	{
		[CompilerGenerated]
		get
		{
			return 놓뇅;
		}
		[CompilerGenerated]
		private set
		{
			놓뇅 = value;
		}
	}

	public double Profitability
	{
		get
		{
			if (Side != 0)
			{
				return 1.0 - TargetPrice / EntryPrice;
			}
			return TargetPrice / EntryPrice - 1.0;
		}
	}

	public DateTime Published
	{
		[CompilerGenerated]
		get
		{
			return 놓놵;
		}
		[CompilerGenerated]
		private set
		{
			놓놵 = value;
		}
	}

	public DateTime Updated
	{
		[CompilerGenerated]
		get
		{
			return 놓놡;
		}
		[CompilerGenerated]
		private set
		{
			놓놡 = value;
		}
	}

	public DateTime ExpiresAt
	{
		[CompilerGenerated]
		get
		{
			return 놓놻;
		}
		[CompilerGenerated]
		private set
		{
			놓놻 = value;
		}
	}

	public string Duration
	{
		[CompilerGenerated]
		get
		{
			return 놓놃;
		}
		[CompilerGenerated]
		private set
		{
			놓놃 = value;
		}
	}

	public string Status
	{
		[CompilerGenerated]
		get
		{
			return 놓뇇;
		}
		[CompilerGenerated]
		private set
		{
			놓뇇 = value;
		}
	}

	public string Description
	{
		[CompilerGenerated]
		get
		{
			return 놓놛;
		}
		[CompilerGenerated]
		private set
		{
			놓놛 = value;
		}
	}

	public string Details
	{
		[CompilerGenerated]
		get
		{
			return 놓놼;
		}
		[CompilerGenerated]
		private set
		{
			놓놼 = value;
		}
	}

	public string Source
	{
		[CompilerGenerated]
		get
		{
			return 놓놗;
		}
		[CompilerGenerated]
		private set
		{
			놓놗 = value;
		}
	}

	internal TradingSignal(string P_0)
		: base(P_0)
	{
	}

	internal void 녴(MessageTradingSignal P_0)
	{
		Id = P_0.Id;
		Ticker = P_0.Ticker;
		Root = P_0.Root;
		VendorName = P_0.VendorName;
		Side = P_0.Side;
		OrderTypeBehavior = P_0.OrderTypeBehavior;
		EntryPrice = P_0.EntryPrice;
		TargetPrice = P_0.TargetPrice;
		StopPrice = P_0.StopPrice;
		Confidence = P_0.Confidence;
		Published = P_0.Published;
		Updated = P_0.Updated;
		ExpiresAt = P_0.ExpiresAt;
		Duration = P_0.Duration;
		Status = P_0.Status;
		Description = P_0.Description;
		Details = P_0.Details;
		Source = P_0.Source;
	}

	public override string ToString()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 4);
		defaultInterpolatedStringHandler.AppendFormatted(Side);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놀());
		defaultInterpolatedStringHandler.AppendFormatted(OrderTypeBehavior);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놀());
		defaultInterpolatedStringHandler.AppendFormatted(Ticker ?? Root);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂녙());
		defaultInterpolatedStringHandler.AppendFormatted(Description);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놢());
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	private MessageTradingSignal 녴()
	{
		return new MessageTradingSignal(Id)
		{
			Ticker = Ticker,
			Root = Root,
			VendorName = VendorName,
			Side = Side,
			OrderTypeBehavior = OrderTypeBehavior,
			EntryPrice = EntryPrice,
			TargetPrice = TargetPrice,
			StopPrice = StopPrice,
			Confidence = Confidence,
			Published = Published,
			Updated = Updated,
			ExpiresAt = ExpiresAt,
			Duration = Duration,
			Status = Status,
			Description = Description,
			Details = Details,
			Source = Source
		};
	}

	MessageTradingSignal IMessageBuilder<MessageTradingSignal>.BuildMessage()
	{
		//ILSpy generated this explicit interface implementation from .override directive in 녴
		return this.녴();
	}

	public string Format()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(18, 7);
		defaultInterpolatedStringHandler.AppendFormatted(Confidence, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸놚());
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴뇎());
		defaultInterpolatedStringHandler.AppendFormatted(Status);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놀());
		defaultInterpolatedStringHandler.AppendFormatted(Ticker ?? Root);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸놹());
		defaultInterpolatedStringHandler.AppendFormatted(EntryPrice);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸놘());
		defaultInterpolatedStringHandler.AppendFormatted(TargetPrice);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸뇌());
		defaultInterpolatedStringHandler.AppendFormatted(StopPrice);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴뇎());
		defaultInterpolatedStringHandler.AppendFormatted(Updated, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂뇂());
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}
}
