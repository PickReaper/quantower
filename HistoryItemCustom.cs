using System.Runtime.CompilerServices;

namespace TradingPlatform.BusinessLayer;

public sealed class HistoryItemCustom : HistoryItem
{
	private const int 놇녚 = 0;

	private const int 놇녳 = 1;

	private const int 놇놉 = 2;

	private const int 놇놥 = 3;

	private double[] 놇놯;

	[CompilerGenerated]
	private bool 놇녾;

	internal double Open
	{
		get
		{
			return 놇놯[0];
		}
		set
		{
			놇놯[0] = value;
		}
	}

	internal double High
	{
		get
		{
			return 놇놯[1];
		}
		set
		{
			놇놯[1] = value;
		}
	}

	internal double Low
	{
		get
		{
			return 놇놯[2];
		}
		set
		{
			놇놯[2] = value;
		}
	}

	internal double Close
	{
		get
		{
			return 놇놯[3];
		}
		set
		{
			놇놯[3] = value;
		}
	}

	public override double this[PriceType priceType] => priceType switch
	{
		PriceType.Open => Open, 
		PriceType.High => High, 
		PriceType.Low => Low, 
		PriceType.Close => Close, 
		_ => base[priceType], 
	};

	internal bool IsEmpty
	{
		[CompilerGenerated]
		get
		{
			return 놇녾;
		}
		[CompilerGenerated]
		set
		{
			놇녾 = value;
		}
	}

	internal HistoryItemCustom(double P_0, double P_1, double P_2, double P_3)
	{
		놇놯 = new double[4];
		Open = P_0;
		High = P_1;
		Low = P_2;
		Close = P_3;
		IsEmpty = double.IsNaN(P_0) && double.IsNaN(P_1) && double.IsNaN(P_2) && double.IsNaN(P_3);
	}

	private HistoryItemCustom(HistoryItemCustom P_0)
		: base(P_0)
	{
		놇놯 = new double[4];
		for (int i = 0; i < P_0.놇놯.Length; i++)
		{
			놇놯[i] = P_0.놇놯[i];
		}
	}

	public override object Clone()
	{
		return new HistoryItemCustom(this);
	}
}
