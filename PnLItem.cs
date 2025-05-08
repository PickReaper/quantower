using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using ProtoBuf;

namespace TradingPlatform.BusinessLayer;

[DataContract(Name = "PnLItem", Namespace = "TradingPlatform")]
[ProtoContract]
public class PnLItem : BusinessObject
{
	[CompilerGenerated]
	private double 놓녱;

	[CompilerGenerated]
	private string 놓놲;

	[CompilerGenerated]
	private double 놓높;

	private Asset 놓놶;

	[DataMember(Name = "Value")]
	[ProtoMember(1)]
	public double Value
	{
		[CompilerGenerated]
		get
		{
			return 놓녱;
		}
		[CompilerGenerated]
		set
		{
			놓녱 = value;
		}
	}

	[DataMember(Name = "AssetID")]
	[ProtoMember(2)]
	public string AssetID
	{
		[CompilerGenerated]
		get
		{
			return 놓놲;
		}
		[CompilerGenerated]
		set
		{
			놓놲 = value;
		}
	}

	[DataMember(Name = "ValuePercent")]
	[ProtoMember(3)]
	public double ValuePercent
	{
		[CompilerGenerated]
		get
		{
			return 놓높;
		}
		[CompilerGenerated]
		set
		{
			놓높 = value;
		}
	}

	public Asset Asset => 놓놶 ?? (놓놶 = Core.Instance.Assets.FirstOrDefault((Asset P_0) => P_0.ConnectionId == base.ConnectionId && P_0.Id == AssetID));

	public PnLItem()
		: base(string.Empty)
	{
		ValuePercent = double.NaN;
	}

	public override bool Equals(object obj)
	{
		if (!(obj is PnLItem pnLItem))
		{
			return false;
		}
		if (Value != pnLItem.Value)
		{
			return false;
		}
		if (AssetID != pnLItem.AssetID)
		{
			return false;
		}
		return true;
	}

	public override int GetHashCode()
	{
		return (13 * 7 + Value.GetHashCode()) * 7 + AssetID.GetHashCode();
	}

	public string Format()
	{
		string text = FormatPercent();
		if (text == null)
		{
			return FormatValue();
		}
		return FormatValue() + _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂녙() + text + _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놢();
	}

	public string FormatValue()
	{
		return Asset?.FormatPriceWithCurrency(Value) ?? Value.Format();
	}

	public string FormatPercent()
	{
		if (!double.IsNaN(ValuePercent))
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
			defaultInterpolatedStringHandler.AppendFormatted(ValuePercent, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶녗());
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}
		return null;
	}

	public override string ToString()
	{
		return Format();
	}

	[CompilerGenerated]
	private bool 녴(Asset P_0)
	{
		if (P_0.ConnectionId == base.ConnectionId)
		{
			return P_0.Id == AssetID;
		}
		return false;
	}
}
