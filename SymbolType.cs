using System.Runtime.Serialization;

namespace TradingPlatform.BusinessLayer;

/// <summary>
/// Договориль использовать множественное число для типа инструмента
/// </summary>
[DataContract(Name = "InstrumentType", Namespace = "TradingPlatform")]
public enum SymbolType
{
	[EnumMember]
	Unknown,
	[EnumMember]
	Forex,
	[EnumMember]
	Equities,
	[EnumMember]
	CFD,
	[EnumMember]
	Indexes,
	[EnumMember]
	Futures,
	[EnumMember]
	Options,
	[EnumMember]
	ETF,
	[EnumMember]
	Crypto,
	[EnumMember]
	Synthetic,
	[EnumMember]
	Spot,
	[EnumMember]
	Forward,
	[EnumMember]
	FixedIncome,
	[EnumMember]
	Warrants,
	/// <summary>
	/// Завели для индийской интеграции
	/// </summary>
	[EnumMember]
	Debentures,
	[EnumMember]
	Bond,
	[EnumMember]
	Swap
}
