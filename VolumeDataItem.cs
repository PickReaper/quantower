using System.Runtime.CompilerServices;

namespace TradingPlatform.BusinessLayer;

public sealed class VolumeDataItem : IVolumeData
{
	[CompilerGenerated]
	private double 녶뇈;

	[CompilerGenerated]
	private double 녶놑;

	[CompilerGenerated]
	private double 녶놦;

	[CompilerGenerated]
	private int 녶놐;

	[CompilerGenerated]
	private int 녶녚;

	[CompilerGenerated]
	private int 녶녳;

	public double Volume
	{
		[CompilerGenerated]
		get
		{
			return 녶뇈;
		}
		[CompilerGenerated]
		set
		{
			녶뇈 = value;
		}
	}

	public double BuyVolume
	{
		[CompilerGenerated]
		get
		{
			return 녶놑;
		}
		[CompilerGenerated]
		set
		{
			녶놑 = value;
		}
	}

	public double SellVolume
	{
		[CompilerGenerated]
		get
		{
			return 녶놦;
		}
		[CompilerGenerated]
		set
		{
			녶놦 = value;
		}
	}

	public int Trades
	{
		[CompilerGenerated]
		get
		{
			return 녶놐;
		}
		[CompilerGenerated]
		set
		{
			녶놐 = value;
		}
	}

	public int BuyTrades
	{
		[CompilerGenerated]
		get
		{
			return 녶녚;
		}
		[CompilerGenerated]
		set
		{
			녶녚 = value;
		}
	}

	public int SellTrades
	{
		[CompilerGenerated]
		get
		{
			return 녶녳;
		}
		[CompilerGenerated]
		set
		{
			녶녳 = value;
		}
	}

	public VolumeDataItem()
	{
	}

	public VolumeDataItem(VolumeDataItem volumeData)
	{
		Volume = volumeData.Volume;
		BuyVolume = volumeData.BuyVolume;
		SellVolume = volumeData.SellVolume;
		Trades = volumeData.Trades;
		BuyTrades = volumeData.BuyTrades;
		SellTrades = volumeData.SellTrades;
	}
}
