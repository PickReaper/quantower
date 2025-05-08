using System.Runtime.CompilerServices;

namespace TradingPlatform.BusinessLayer;

public sealed class HistoryItemTimeStatistics : HistoryItem, IVolumeData
{
	[CompilerGenerated]
	private long 뇅녵;

	[CompilerGenerated]
	private double 뇅놭;

	[CompilerGenerated]
	private int 뇅녲;

	[CompilerGenerated]
	private double 뇅뇋;

	[CompilerGenerated]
	private int 뇅놸;

	[CompilerGenerated]
	private double 뇅놿;

	[CompilerGenerated]
	private int 뇅놄;

	public override long TicksRight
	{
		[CompilerGenerated]
		get
		{
			return 뇅녵;
		}
		[CompilerGenerated]
		set
		{
			뇅녵 = value;
		}
	}

	public double Volume
	{
		[CompilerGenerated]
		get
		{
			return 뇅놭;
		}
		[CompilerGenerated]
		set
		{
			뇅놭 = value;
		}
	}

	public int Trades
	{
		[CompilerGenerated]
		get
		{
			return 뇅녲;
		}
		[CompilerGenerated]
		set
		{
			뇅녲 = value;
		}
	}

	public double BuyVolume
	{
		[CompilerGenerated]
		get
		{
			return 뇅뇋;
		}
		[CompilerGenerated]
		set
		{
			뇅뇋 = value;
		}
	}

	public int BuyTrades
	{
		[CompilerGenerated]
		get
		{
			return 뇅놸;
		}
		[CompilerGenerated]
		set
		{
			뇅놸 = value;
		}
	}

	public double SellVolume
	{
		[CompilerGenerated]
		get
		{
			return 뇅놿;
		}
		[CompilerGenerated]
		set
		{
			뇅놿 = value;
		}
	}

	public int SellTrades
	{
		[CompilerGenerated]
		get
		{
			return 뇅놄;
		}
		[CompilerGenerated]
		set
		{
			뇅놄 = value;
		}
	}

	public HistoryItemTimeStatistics()
	{
	}

	public HistoryItemTimeStatistics(HistoryItemTimeStatistics item)
		: base(item)
	{
		TicksRight = item.TicksRight;
		Volume = item.Volume;
		BuyVolume = item.BuyVolume;
		SellVolume = item.SellVolume;
		Trades = item.Trades;
		BuyTrades = item.BuyTrades;
		SellTrades = item.SellTrades;
	}

	public override object Clone()
	{
		return new HistoryItemTimeStatistics(this);
	}
}
