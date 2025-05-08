using System.Runtime.CompilerServices;

namespace TradingPlatform.BusinessLayer;

[Published]
public class PnLRequestParameters : RequestParameters
{
	[CompilerGenerated]
	private Symbol 녶녕;

	[CompilerGenerated]
	private Account 녶녖;

	[CompilerGenerated]
	private double 녵녴;

	[CompilerGenerated]
	private double 녵놴;

	[CompilerGenerated]
	private Side 녵놂;

	[CompilerGenerated]
	private double 녵놎;

	[CompilerGenerated]
	private string 녵녞;

	public override RequestType Type => RequestType.PnL;

	public Symbol Symbol
	{
		[CompilerGenerated]
		get
		{
			return 녶녕;
		}
		[CompilerGenerated]
		set
		{
			녶녕 = value;
		}
	}

	public Account Account
	{
		[CompilerGenerated]
		get
		{
			return 녶녖;
		}
		[CompilerGenerated]
		set
		{
			녶녖 = value;
		}
	}

	public double OpenPrice
	{
		[CompilerGenerated]
		get
		{
			return 녵녴;
		}
		[CompilerGenerated]
		set
		{
			녵녴 = value;
		}
	}

	public double ClosePrice
	{
		[CompilerGenerated]
		get
		{
			return 녵놴;
		}
		[CompilerGenerated]
		set
		{
			녵놴 = value;
		}
	}

	public Side Side
	{
		[CompilerGenerated]
		get
		{
			return 녵놂;
		}
		[CompilerGenerated]
		set
		{
			녵놂 = value;
		}
	}

	public double Quantity
	{
		[CompilerGenerated]
		get
		{
			return 녵놎;
		}
		[CompilerGenerated]
		set
		{
			녵놎 = value;
		}
	}

	public string PositionId
	{
		[CompilerGenerated]
		get
		{
			return 녵녞;
		}
		[CompilerGenerated]
		set
		{
			녵녞 = value;
		}
	}

	public PnLRequestParameters()
	{
		OpenPrice = double.NaN;
		ClosePrice = double.NaN;
		Quantity = double.NaN;
	}

	public PnLRequestParameters(PnLRequestParameters original)
	{
		Symbol = original.Symbol;
		Account = original.Account;
		OpenPrice = original.OpenPrice;
		ClosePrice = original.ClosePrice;
		Side = original.Side;
		Quantity = original.Quantity;
		PositionId = original.PositionId;
	}
}
