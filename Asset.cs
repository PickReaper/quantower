using System;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using TradingPlatform.BusinessLayer.Integration;
using TradingPlatform.BusinessLayer.Utils;

namespace TradingPlatform.BusinessLayer;

/// <summary>
/// Defines asset entity
/// </summary>
[Published]
public class Asset : BusinessObject, IComparable, IMessageBuilder<MessageAsset>
{
	[CompilerGenerated]
	private string 놄뇆;

	[CompilerGenerated]
	private string 놄뇉;

	[CompilerGenerated]
	private string 놄뇍;

	private double 놄놙;

	[CompilerGenerated]
	private int 놄녰;

	[CompilerGenerated]
	private string 놄놚;

	/// <summary>
	/// Asset id bearer
	/// </summary>
	public string Id
	{
		[CompilerGenerated]
		get
		{
			return 놄뇆;
		}
		[CompilerGenerated]
		private set
		{
			놄뇆 = value;
		}
	}

	/// <summary>
	/// Asset name bearer
	/// </summary>
	public string Name
	{
		[CompilerGenerated]
		get
		{
			return 놄뇉;
		}
		[CompilerGenerated]
		private set
		{
			놄뇉 = value;
		}
	}

	/// <summary>
	/// Asset description
	/// </summary>
	public string Description
	{
		[CompilerGenerated]
		get
		{
			return 놄뇍;
		}
		[CompilerGenerated]
		private set
		{
			놄뇍 = value;
		}
	}

	/// <summary>
	/// Defines a number precision of the change value
	/// </summary>
	public double MinimumChange
	{
		get
		{
			return 놄놙;
		}
		set
		{
			if (놄놙 != value)
			{
				놄놙 = value;
				Precision = CoreMath.GetValuePrecision((decimal)놄놙);
			}
		}
	}

	/// <summary>
	/// Gets precision value
	/// </summary>
	public int Precision
	{
		[CompilerGenerated]
		get
		{
			return 놄녰;
		}
		[CompilerGenerated]
		private set
		{
			놄녰 = value;
		}
	}

	/// <summary>
	/// Gets asset ISO 4217 code
	/// </summary>
	public string IsoCode
	{
		[CompilerGenerated]
		get
		{
			return 놄놚;
		}
		[CompilerGenerated]
		private set
		{
			놄놚 = value;
		}
	}

	/// <summary>
	/// Creates an Asset instance
	/// </summary>
	/// <param name="connectionId">given connection Id</param>
	[NotPublished]
	public Asset(string connectionId)
		: base(connectionId)
	{
	}

	/// <summary>
	/// Formats price into precision normalized string
	/// </summary>
	/// <param name="price"></param>
	/// <returns></returns>
	public string FormatPrice(double price)
	{
		if (!double.IsNaN(price))
		{
			return price.Format(Precision);
		}
		return _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇅();
	}

	/// <summary>
	/// Formats price into concatenated string which contains the precision normalized value and Asset's name
	/// </summary>
	/// <param name="price"></param>
	/// <returns></returns>
	public string FormatPriceWithCurrency(double price)
	{
		if (!double.IsNaN(price))
		{
			return price.Format(Precision) + _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놀() + Name;
		}
		return _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇅();
	}

	public string FormatWithCurrency(double value)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
		defaultInterpolatedStringHandler.AppendFormatted(value);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놀());
		defaultInterpolatedStringHandler.AppendFormatted(Name);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	internal void 녴(MessageAsset P_0)
	{
		Id = P_0.Id;
		Name = P_0.Name;
		Description = P_0.Description;
		MinimumChange = P_0.MinimumChange;
		IsoCode = P_0.IsoCode;
	}

	private MessageAsset 녴()
	{
		return new MessageAsset
		{
			Id = Id,
			Name = Name,
			Description = Description,
			MinimumChange = MinimumChange,
			IsoCode = IsoCode
		};
	}

	MessageAsset IMessageBuilder<MessageAsset>.BuildMessage()
	{
		//ILSpy generated this explicit interface implementation from .override directive in 녴
		return this.녴();
	}

	/// <summary>
	/// Gets Asset name
	/// </summary>
	/// <returns></returns>
	[NotPublished]
	public override string ToString()
	{
		return Name;
	}

	/// <summary>
	/// Uses comparison by Assets names
	/// </summary>
	/// <param name="obj"></param>
	/// <returns></returns>
	[NotPublished]
	public int CompareTo(object obj)
	{
		if (!(obj is Asset asset))
		{
			return 1;
		}
		return Name.CompareTo(asset.Name);
	}
}
