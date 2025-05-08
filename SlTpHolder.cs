using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using ProtoBuf;
using TradingPlatform.BusinessLayer.Serialization;

namespace TradingPlatform.BusinessLayer;

[ProtoContract]
public sealed class SlTpHolder : ICloneable, IXElementSerialization, IEquatable<SlTpHolder>, ICustomizable
{
	[CompilerGenerated]
	private CloseOrderType 놫놚;

	[CompilerGenerated]
	private double 놫놹;

	[CompilerGenerated]
	private double 놫놘;

	[CompilerGenerated]
	private PriceMeasurement 놫뇌;

	[CompilerGenerated]
	private bool 놫녷;

	[CompilerGenerated]
	private double 놫녟;

	[ProtoMember(1)]
	public CloseOrderType Type
	{
		[CompilerGenerated]
		get
		{
			return 놫놚;
		}
		[CompilerGenerated]
		private set
		{
			놫놚 = value;
		}
	}

	[ProtoMember(2)]
	public double Price
	{
		[CompilerGenerated]
		get
		{
			return 놫놹;
		}
		[CompilerGenerated]
		private set
		{
			놫놹 = value;
		}
	}

	[ProtoMember(3)]
	public double Quantity
	{
		[CompilerGenerated]
		get
		{
			return 놫놘;
		}
		[CompilerGenerated]
		set
		{
			놫놘 = value;
		}
	}

	[ProtoMember(4)]
	public PriceMeasurement PriceMeasurement
	{
		[CompilerGenerated]
		get
		{
			return 놫뇌;
		}
		[CompilerGenerated]
		private set
		{
			놫뇌 = value;
		}
	}

	[ProtoMember(5)]
	public bool IsTrailing
	{
		[CompilerGenerated]
		get
		{
			return 놫녷;
		}
		[CompilerGenerated]
		private set
		{
			놫녷 = value;
		}
	}

	[ProtoMember(6)]
	public double QuantityPercentage
	{
		[CompilerGenerated]
		get
		{
			return 놫녟;
		}
		[CompilerGenerated]
		set
		{
			놫녟 = value;
		}
	}

	public IList<SettingItem> Settings
	{
		get
		{
			return new List<SettingItem>
			{
				new SettingItemSelectorLocalized(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶농(), (int)Type, new List<SelectItem>
				{
					new SelectItem(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶념(), 0),
					new SelectItem(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶녨(), 1)
				}),
				new SettingItemDouble(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶녺(), Price),
				new SettingItemDouble(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶놣(), Quantity),
				new SettingItemSelectorLocalized(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶녮(), (int)PriceMeasurement, new List<SelectItem>
				{
					new SelectItem(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶뇆(), 0),
					new SelectItem(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶뇉(), 1)
				}),
				new SettingItemBoolean(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶뇍(), IsTrailing),
				new SettingItemDouble(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶놙(), QuantityPercentage)
			};
		}
		set
		{
			Type = (CloseOrderType)value.GetValueOrDefault((int)Type, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶농());
			Price = value.GetValueOrDefault(Price, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶녺());
			Quantity = value.GetValueOrDefault(Quantity, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶놣());
			PriceMeasurement = (PriceMeasurement)value.GetValueOrDefault((int)PriceMeasurement, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶녮());
			IsTrailing = value.GetValueOrDefault(IsTrailing, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶뇍());
			QuantityPercentage = value.GetValueOrDefault(QuantityPercentage, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶놙());
		}
	}

	[NotPublished]
	public SlTpHolder(IList<SettingItem> settings)
	{
		Settings = settings;
	}

	internal SlTpHolder()
	{
	}

	public static SlTpHolder CreateSL(double price, PriceMeasurement priceMeasurement = PriceMeasurement.Absolute, bool isTrailing = false, double quantity = double.NaN, double quantityPercentage = double.NaN)
	{
		return new SlTpHolder
		{
			Type = CloseOrderType.StopLoss,
			Price = price,
			Quantity = quantity,
			PriceMeasurement = priceMeasurement,
			IsTrailing = isTrailing,
			QuantityPercentage = quantityPercentage
		};
	}

	public static SlTpHolder CreateTP(double price, PriceMeasurement priceMeasurement = PriceMeasurement.Absolute, double quantity = double.NaN, double quantityPercentage = double.NaN)
	{
		return new SlTpHolder
		{
			Type = CloseOrderType.TakeProfit,
			Price = price,
			Quantity = quantity,
			PriceMeasurement = priceMeasurement,
			IsTrailing = false,
			QuantityPercentage = quantityPercentage
		};
	}

	public string Format(Symbol symbol)
	{
		if (symbol == null)
		{
			return Price.ToString();
		}
		if (PriceMeasurement == PriceMeasurement.Absolute)
		{
			return symbol.FormatPrice(Price);
		}
		return symbol.FormatOffset(Price, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놎놊());
	}

	public object Clone()
	{
		if (Type == CloseOrderType.StopLoss)
		{
			return CreateSL(Price, PriceMeasurement, IsTrailing, Quantity, QuantityPercentage);
		}
		return CreateTP(Price, PriceMeasurement, Quantity, QuantityPercentage);
	}

	public XElement ToXElement()
	{
		XElement xElement = new XElement(GetType().Name);
		xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶놐(), ((int)Type).ToString()));
		xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶녰(), Price));
		xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶녯(), Quantity));
		xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶놚(), ((int)PriceMeasurement).ToString()));
		xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶놹(), IsTrailing));
		xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶놘(), QuantityPercentage));
		return xElement;
	}

	public void FromXElement(XElement element, DeserializationInfo deserializationInfo)
	{
		XElement xElement = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶놐());
		if (xElement != null)
		{
			Type = (CloseOrderType)xElement.ToInt();
		}
		XElement xElement2 = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶녰());
		if (xElement2 != null)
		{
			Price = xElement2.ToDouble();
		}
		XElement xElement3 = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶놚());
		if (xElement3 != null)
		{
			PriceMeasurement = (PriceMeasurement)xElement3.ToInt();
		}
		XElement xElement4 = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶놹());
		if (xElement4 != null)
		{
			IsTrailing = xElement4.ToBool();
		}
		XElement xElement5 = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶녯());
		if (xElement5 != null)
		{
			Quantity = xElement5.ToDouble();
		}
		XElement xElement6 = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶놘());
		if (xElement6 != null)
		{
			QuantityPercentage = xElement6.ToDouble();
		}
		if (Quantity == 0.0)
		{
			Quantity = double.NaN;
		}
	}

	public bool Equals(SlTpHolder other)
	{
		if (other == null)
		{
			return false;
		}
		if (this == other)
		{
			return true;
		}
		if (Type == other.Type && Price.Equals(other.Price) && Quantity.Equals(other.Quantity) && QuantityPercentage.Equals(other.QuantityPercentage) && PriceMeasurement == other.PriceMeasurement)
		{
			return IsTrailing == other.IsTrailing;
		}
		return false;
	}

	public override bool Equals(object obj)
	{
		if (obj == null)
		{
			return false;
		}
		if (this == obj)
		{
			return true;
		}
		if (obj.GetType() != GetType())
		{
			return false;
		}
		return Equals((SlTpHolder)obj);
	}

	public override int GetHashCode()
	{
		return (int)(((uint)((((((((int)Type * 397) ^ Price.GetHashCode()) * 397) ^ Quantity.GetHashCode()) * 397) ^ QuantityPercentage.GetHashCode()) * 397) ^ (uint)PriceMeasurement) * 397) ^ IsTrailing.GetHashCode();
	}

	public override string ToString()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(9, 4);
		defaultInterpolatedStringHandler.AppendFormatted(Type);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놎놖());
		defaultInterpolatedStringHandler.AppendFormatted(PriceMeasurement);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놎놖());
		defaultInterpolatedStringHandler.AppendFormatted(Price);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놎놖());
		object value;
		if (!double.IsNaN(QuantityPercentage))
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(0, 1);
			defaultInterpolatedStringHandler2.AppendFormatted(QuantityPercentage, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶녗());
			value = defaultInterpolatedStringHandler2.ToStringAndClear();
		}
		else
		{
			value = $"{Quantity}";
		}
		defaultInterpolatedStringHandler.AppendFormatted((string?)value);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}
}
