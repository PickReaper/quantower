using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using TradingPlatform.BusinessLayer.Integration;

namespace TradingPlatform.BusinessLayer;

[DataContract(Name = "OptionSerie", Namespace = "TradingPlatform")]
public sealed class OptionSerie : BusinessObject, IMessageBuilder<MessageOptionSerie>, IComparable
{
	[CompilerGenerated]
	private string 놓놾;

	[CompilerGenerated]
	private DateTime 놓뇀;

	[CompilerGenerated]
	private string 놓놽;

	[CompilerGenerated]
	private string 놓녿;

	[CompilerGenerated]
	private Exchange 놓놁;

	[CompilerGenerated]
	private OptionSerieType 놓녭;

	public string Id
	{
		[CompilerGenerated]
		get
		{
			return 놓놾;
		}
		[CompilerGenerated]
		private set
		{
			놓놾 = value;
		}
	}

	public DateTime ExpirationDate
	{
		[CompilerGenerated]
		get
		{
			return 놓뇀;
		}
		[CompilerGenerated]
		private set
		{
			놓뇀 = value;
		}
	}

	public string Name
	{
		[CompilerGenerated]
		get
		{
			return 놓놽;
		}
		[CompilerGenerated]
		private set
		{
			놓놽 = value;
		}
	}

	public string UnderlierId
	{
		[CompilerGenerated]
		get
		{
			return 놓녿;
		}
		[CompilerGenerated]
		private set
		{
			놓녿 = value;
		}
	}

	public Exchange Exchange
	{
		[CompilerGenerated]
		get
		{
			return 놓놁;
		}
		[CompilerGenerated]
		private set
		{
			놓놁 = value;
		}
	}

	public OptionSerieType SerieType
	{
		[CompilerGenerated]
		get
		{
			return 놓녭;
		}
		[CompilerGenerated]
		private set
		{
			놓녭 = value;
		}
	}

	public string VisualName
	{
		get
		{
			string text = ExpirationDate.ToShortDateString();
			if (string.IsNullOrEmpty(Name))
			{
				return text;
			}
			return Name + _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놀() + text;
		}
	}

	public override string ToString()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
		defaultInterpolatedStringHandler.AppendFormatted(UnderlierId);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놀());
		defaultInterpolatedStringHandler.AppendFormatted(Name);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놀());
		defaultInterpolatedStringHandler.AppendFormatted(ExpirationDate.ToShortDateString());
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	internal OptionSerie(string P_0)
		: base(P_0)
	{
	}

	internal void 녴(MessageOptionSerie P_0)
	{
		Id = P_0.Id;
		ExpirationDate = P_0.ExpirationDate;
		Name = P_0.Name;
		UnderlierId = P_0.UnderlierId;
		SerieType = P_0.SerieType;
		if (!string.IsNullOrEmpty(P_0.ExchangeId) && ConnectionCache != null && ConnectionCache.ExchangesCache.녴(P_0.ExchangeId, out var exchange))
		{
			Exchange = exchange;
		}
	}

	private MessageOptionSerie 녴()
	{
		return new MessageOptionSerie
		{
			Id = Id,
			ExpirationDate = ExpirationDate,
			Name = Name,
			UnderlierId = UnderlierId
		};
	}

	MessageOptionSerie IMessageBuilder<MessageOptionSerie>.BuildMessage()
	{
		//ILSpy generated this explicit interface implementation from .override directive in 녴
		return this.녴();
	}

	public override bool Equals(object obj)
	{
		if (obj is OptionSerie optionSerie && base.ConnectionId == optionSerie.ConnectionId && Id == optionSerie.Id)
		{
			return UnderlierId == optionSerie.UnderlierId;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return ((-1159877490 * -1521134295 + ExpirationDate.GetHashCode()) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Id)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(UnderlierId);
	}

	public int CompareTo(object obj)
	{
		return CompareTo(obj);
	}
}
