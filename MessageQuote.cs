using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using ProtoBuf;
using TradingPlatform.BusinessLayer.Integration;

namespace TradingPlatform.BusinessLayer;

[Serializable]
[KnownType(typeof(Level2Quote))]
[KnownType(typeof(Last))]
[KnownType(typeof(Quote))]
[KnownType(typeof(DOMQuote))]
[KnownType(typeof(DayBar))]
[KnownType(typeof(Mark))]
[DataContract(Name = "MessageQuote", Namespace = "TradingPlatform")]
[ProtoContract]
[ProtoInclude(3, typeof(Quote))]
[ProtoInclude(4, typeof(Last))]
[ProtoInclude(5, typeof(Level2Quote))]
[ProtoInclude(6, typeof(DOMQuote))]
[ProtoInclude(7, typeof(DayBar))]
[ProtoInclude(8, typeof(Mark))]
public abstract class MessageQuote : Message
{
	[CompilerGenerated]
	private string 녶놏;

	[CompilerGenerated]
	private DateTime 녶녥;

	[DataMember(Name = "Symbol")]
	[ProtoMember(1)]
	public string SymbolId
	{
		[CompilerGenerated]
		get
		{
			return 녶놏;
		}
		[CompilerGenerated]
		protected internal set
		{
			녶놏 = value;
		}
	}

	/// <summary>
	/// Time of the quote
	/// </summary>
	[DataMember(Name = "Time")]
	[ProtoMember(2)]
	public DateTime Time
	{
		[CompilerGenerated]
		get
		{
			return 녶녥;
		}
		[CompilerGenerated]
		set
		{
			녶녥 = value;
		}
	}

	private protected MessageQuote()
	{
	}

	protected MessageQuote(string symbolId, DateTime time)
	{
		SymbolId = symbolId;
		Time = time;
	}

	[NotPublished]
	public override string ToString()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 4);
		defaultInterpolatedStringHandler.AppendFormatted(Time.Ticks);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놀());
		defaultInterpolatedStringHandler.AppendFormatted(Type);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂녹());
		defaultInterpolatedStringHandler.AppendFormatted(Time);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂녹());
		defaultInterpolatedStringHandler.AppendFormatted(SymbolId);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}
}
