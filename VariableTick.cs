using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Xml.Linq;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using ProtoBuf;
using TradingPlatform.BusinessLayer.Serialization;
using TradingPlatform.BusinessLayer.Utils;

namespace TradingPlatform.BusinessLayer;

[DataContract(Name = "VariableTick", Namespace = "TradingPlatform")]
[ProtoContract]
public class VariableTick : IXElementSerialization
{
	[CompilerGenerated]
	private double 놫놖;

	[CompilerGenerated]
	private bool 놫놝;

	[CompilerGenerated]
	private double 놫뇄;

	[CompilerGenerated]
	private double 놫녑;

	[CompilerGenerated]
	private double 놫놈;

	[CompilerGenerated]
	private int 놫놬;

	[DataMember]
	[ProtoMember(1)]
	public double LeftBorder
	{
		[CompilerGenerated]
		get
		{
			return 놫놖;
		}
		[CompilerGenerated]
		private set
		{
			놫놖 = value;
		}
	}

	[DataMember]
	[ProtoMember(2)]
	public bool IncludeLeftBorder
	{
		[CompilerGenerated]
		get
		{
			return 놫놝;
		}
		[CompilerGenerated]
		private set
		{
			놫놝 = value;
		}
	}

	[DataMember]
	[ProtoMember(3)]
	public double TickSize
	{
		[CompilerGenerated]
		get
		{
			return 놫뇄;
		}
		[CompilerGenerated]
		private set
		{
			놫뇄 = value;
		}
	}

	[DataMember]
	[ProtoMember(4)]
	public double TickCost
	{
		[CompilerGenerated]
		get
		{
			return 놫녑;
		}
		[CompilerGenerated]
		private set
		{
			놫녑 = value;
		}
	}

	[DataMember]
	[ProtoMember(5)]
	public double RightBorder
	{
		[CompilerGenerated]
		get
		{
			return 놫놈;
		}
		[CompilerGenerated]
		private set
		{
			놫놈 = value;
		}
	}

	[DataMember]
	[ProtoMember(6)]
	public int Precision
	{
		[CompilerGenerated]
		get
		{
			return 놫놬;
		}
		[CompilerGenerated]
		private set
		{
			놫놬 = value;
		}
	}

	/// <summary>
	/// проверка на вхождение
	/// </summary>
	public bool CheckPrice(double price)
	{
		if ((!(price > LeftBorder) || !(price < RightBorder)) && (price != LeftBorder || !IncludeLeftBorder))
		{
			if (price == RightBorder)
			{
				return !IncludeLeftBorder;
			}
			return false;
		}
		return true;
	}

	public VariableTick(double lowLimit, double highLimit, bool allowLimit, double tickSize, double tickCost, int? precision = null)
	{
		LeftBorder = lowLimit;
		RightBorder = highLimit;
		IncludeLeftBorder = allowLimit;
		TickSize = (double)(decimal)tickSize;
		TickCost = tickCost;
		Precision = ((!precision.HasValue) ? CoreMath.GetValuePrecision((decimal)TickSize) : precision.Value);
	}

	public VariableTick(double tickSize, double tickCost = 1.0, int? precision = null)
		: this(double.NegativeInfinity, double.PositiveInfinity, allowLimit: true, tickSize, tickCost, precision)
	{
	}

	internal VariableTick()
	{
	}

	public override string ToString()
	{
		return LeftBorder + ((IncludeLeftBorder && LeftBorder != double.NegativeInfinity) ? _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶녷() : _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶뇌()) + _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶녺() + ((!IncludeLeftBorder && RightBorder != double.PositiveInfinity) ? _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶녷() : _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶뇌()) + RightBorder;
	}

	public XElement ToXElement()
	{
		XElement xElement = new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶녟());
		xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶놱(), LeftBorder.ToString(CultureInfo.InvariantCulture)));
		xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶놖(), RightBorder.ToString(CultureInfo.InvariantCulture)));
		xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶놝(), IncludeLeftBorder));
		xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶뇄(), TickSize));
		xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶녑(), TickCost));
		xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶놈(), Precision));
		return xElement;
	}

	public void FromXElement(XElement element, DeserializationInfo deserializationInfo)
	{
		XElement xElement = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶놱());
		if (xElement != null)
		{
			LeftBorder = xElement.ToDouble();
		}
		XElement xElement2 = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶놖());
		if (xElement2 != null)
		{
			RightBorder = xElement2.ToDouble();
		}
		XElement xElement3 = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶놝());
		if (xElement3 != null)
		{
			IncludeLeftBorder = xElement3.ToBool();
		}
		XElement xElement4 = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶뇄());
		if (xElement4 != null)
		{
			TickSize = xElement4.ToDouble();
		}
		XElement xElement5 = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶녑());
		if (xElement5 != null)
		{
			TickCost = xElement5.ToDouble();
		}
		XElement xElement6 = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶놈());
		if (xElement6 != null)
		{
			Precision = xElement6.ToInt();
		}
	}
}
