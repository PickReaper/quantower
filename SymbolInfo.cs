using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Xml.Linq;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using TradingPlatform.BusinessLayer.Serialization;

namespace TradingPlatform.BusinessLayer;

[Serializable]
[DataContract]
public class SymbolInfo : BusinessObjectInfo, IEquatable<SymbolInfo>
{
	[CompilerGenerated]
	private string 놓뇏;

	[CompilerGenerated]
	private SymbolType 놓녻;

	[CompilerGenerated]
	private FutureContractType? 놓녙;

	[CompilerGenerated]
	private string 놓놢;

	[CompilerGenerated]
	private string 놓녧;

	[CompilerGenerated]
	private DateTime 놓녤;

	[DataMember(Name = "exchangeId")]
	public string ExchangeId
	{
		[CompilerGenerated]
		get
		{
			return 놓뇏;
		}
		[CompilerGenerated]
		internal set
		{
			놓뇏 = value;
		}
	}

	[DataMember(Name = "symbolType")]
	public SymbolType SymbolType
	{
		[CompilerGenerated]
		get
		{
			return 놓녻;
		}
		[CompilerGenerated]
		internal set
		{
			놓녻 = value;
		}
	}

	[DataMember(Name = "futuresContractType")]
	public FutureContractType? FutureContractType
	{
		[CompilerGenerated]
		get
		{
			return 놓녙;
		}
		[CompilerGenerated]
		internal set
		{
			놓녙 = value;
		}
	}

	[DataMember(Name = "underlierId")]
	public string UnderlierId
	{
		[CompilerGenerated]
		get
		{
			return 놓놢;
		}
		[CompilerGenerated]
		internal set
		{
			놓놢 = value;
		}
	}

	[DataMember(Name = "root")]
	public string Root
	{
		[CompilerGenerated]
		get
		{
			return 놓녧;
		}
		[CompilerGenerated]
		internal set
		{
			놓녧 = value;
		}
	}

	[DataMember(Name = "expirationTime")]
	public DateTime ExpirationDate
	{
		[CompilerGenerated]
		get
		{
			return 놓녤;
		}
		[CompilerGenerated]
		internal set
		{
			놓녤 = value;
		}
	}

	public new static SymbolInfo Empty => new SymbolInfo
	{
		Id = string.Empty,
		ConnectionId = string.Empty,
		Name = string.Empty,
		ExchangeId = string.Empty,
		SymbolType = SymbolType.Unknown,
		FutureContractType = null,
		UnderlierId = string.Empty,
		Root = string.Empty,
		ExpirationDate = default(DateTime)
	};

	public override XElement ToXElement()
	{
		XElement xElement = base.ToXElement();
		xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇋놚(), ExchangeId));
		xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸놱(), SymbolType.ToString()));
		if (FutureContractType.HasValue)
		{
			xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸놖(), FutureContractType.ToString()));
		}
		if (!string.IsNullOrEmpty(UnderlierId))
		{
			xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵녷(), UnderlierId));
		}
		if (!string.IsNullOrEmpty(Root))
		{
			xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸놝(), Root));
		}
		if (ExpirationDate != default(DateTime))
		{
			xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇋논(), ExpirationDate));
		}
		return xElement;
	}

	public override void FromXElement(XElement element, DeserializationInfo deserializationInfo)
	{
		base.FromXElement(element, deserializationInfo);
		XElement xElement = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇋놚());
		if (xElement != null)
		{
			ExchangeId = xElement.Value;
		}
		XElement xElement2 = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸놖());
		if (xElement2 != null && Enum.TryParse<FutureContractType>(xElement2.Value, out var result))
		{
			FutureContractType = result;
		}
		XElement xElement3 = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸놱());
		if (xElement3 != null && Enum.TryParse<SymbolType>(xElement3.Value, out var result2))
		{
			SymbolType = result2;
		}
		XElement xElement4 = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵녷());
		if (xElement4 != null)
		{
			UnderlierId = xElement4.Value;
		}
		XElement xElement5 = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸놝());
		if (xElement5 != null)
		{
			Root = xElement5.Value;
		}
		XElement xElement6 = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.뇋논());
		if (xElement6 != null)
		{
			ExpirationDate = xElement6.ToDateTime();
		}
	}

	public bool Equals(SymbolInfo other)
	{
		if ((object)other == null)
		{
			return false;
		}
		if ((object)this == other)
		{
			return true;
		}
		if (Equals((BusinessObjectInfo)other) && ExchangeId == other.ExchangeId && SymbolType == other.SymbolType && FutureContractType == other.FutureContractType && UnderlierId == other.UnderlierId && Root == other.Root)
		{
			return ExpirationDate.Equals(other.ExpirationDate);
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
		return Equals((SymbolInfo)obj);
	}

	public override int GetHashCode()
	{
		return HashCode.Combine(base.GetHashCode(), ExchangeId, (int)SymbolType, FutureContractType, UnderlierId, Root, ExpirationDate);
	}

	public static bool operator ==(SymbolInfo left, SymbolInfo right)
	{
		return object.Equals(left, right);
	}

	public static bool operator !=(SymbolInfo left, SymbolInfo right)
	{
		return !object.Equals(left, right);
	}
}
