using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using TradingPlatform.BusinessLayer.Serialization;

namespace TradingPlatform.BusinessLayer;

[Serializable]
public class PairColor : IXElementSerialization, IEquatable<PairColor>
{
	[CompilerGenerated]
	private Color 녲놮;

	[CompilerGenerated]
	private Color 녲녫;

	[CompilerGenerated]
	private string 녲뇁;

	[CompilerGenerated]
	private string 녲놧;

	public Color Color1
	{
		[CompilerGenerated]
		get
		{
			return 녲놮;
		}
		[CompilerGenerated]
		set
		{
			녲놮 = value;
		}
	}

	public Color Color2
	{
		[CompilerGenerated]
		get
		{
			return 녲녫;
		}
		[CompilerGenerated]
		set
		{
			녲녫 = value;
		}
	}

	public string Text1
	{
		[CompilerGenerated]
		get
		{
			return 녲뇁;
		}
		[CompilerGenerated]
		set
		{
			녲뇁 = value;
		}
	}

	public string Text2
	{
		[CompilerGenerated]
		get
		{
			return 녲놧;
		}
		[CompilerGenerated]
		set
		{
			녲놧 = value;
		}
	}

	public PairColor()
	{
	}

	public PairColor(Color color1, Color color2, string text1 = null, string text2 = null)
	{
		Color1 = color1;
		Color2 = color2;
		Text1 = text1;
		Text2 = text2;
	}

	public XElement ToXElement()
	{
		return new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녲뇅(), Color1.ToXElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녲놵()), Color2.ToXElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녲놡()));
	}

	public void FromXElement(XElement element, DeserializationInfo deserializationInfo)
	{
		XElement xElement = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녲놵());
		if (xElement != null)
		{
			Color1 = xElement.ToColor();
		}
		XElement xElement2 = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녲놡());
		if (xElement2 != null)
		{
			Color2 = xElement2.ToColor();
		}
	}

	public bool Equals(PairColor other)
	{
		if (other == null)
		{
			return false;
		}
		if (this == other)
		{
			return true;
		}
		if (Color1.Equals(other.Color1) && Color2.Equals(other.Color2) && Text1 == other.Text1)
		{
			return Text2 == other.Text2;
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
		return Equals((PairColor)obj);
	}

	public override int GetHashCode()
	{
		return HashCode.Combine(Color1, Color2, Text1, Text2);
	}
}
