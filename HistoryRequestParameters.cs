using System;
using System.Runtime.CompilerServices;
using ProtoBuf;
using TradingPlatform.BusinessLayer.History.Storage;
using TradingPlatform.BusinessLayer.Utils;

namespace TradingPlatform.BusinessLayer;

/// <summary>
/// Resolves a history request parameters per symbol
/// </summary>
[Published]
[ProtoContract]
public sealed class HistoryRequestParameters : RequestParameters
{
	private Symbol 녶놉;

	private string 녶놥;

	[CompilerGenerated]
	private DateTime 녶놯;

	[CompilerGenerated]
	private DateTime 녶녾;

	[CompilerGenerated]
	private HistoryAggregation 녶녬;

	[CompilerGenerated]
	private bool 녶녹;

	[CompilerGenerated]
	private bool 녶녔;

	[CompilerGenerated]
	private ISessionsContainer 녶녠;

	[CompilerGenerated]
	private IProgress<float> 녶놠;

	[CompilerGenerated]
	private readonly HistoryRequestType 녶놟;

	public override RequestType Type => RequestType.History;

	public Symbol Symbol
	{
		get
		{
			return 녶놉;
		}
		set
		{
			녶놉 = value;
			녶놥 = 녶놉?.Id;
		}
	}

	[ProtoMember(1)]
	public string SymbolId
	{
		get
		{
			string id = 녶놥;
			if (id == null)
			{
				Symbol symbol = Symbol;
				if (symbol == null)
				{
					return null;
				}
				id = symbol.Id;
			}
			return id;
		}
		set
		{
			녶놥 = value;
		}
	}

	[ProtoMember(2)]
	public DateTime FromTime
	{
		[CompilerGenerated]
		get
		{
			return 녶놯;
		}
		[CompilerGenerated]
		set
		{
			녶놯 = value;
		}
	}

	[ProtoMember(3)]
	public DateTime ToTime
	{
		[CompilerGenerated]
		get
		{
			return 녶녾;
		}
		[CompilerGenerated]
		set
		{
			녶녾 = value;
		}
	}

	public Interval<DateTime> Interval
	{
		get
		{
			return new Interval<DateTime>(FromTime, ToTime);
		}
		set
		{
			FromTime = value.From;
			ToTime = value.To;
		}
	}

	public HistoryAggregation Aggregation
	{
		[CompilerGenerated]
		get
		{
			return 녶녬;
		}
		[CompilerGenerated]
		set
		{
			녶녬 = value;
		}
	}

	public bool ForceReload
	{
		[CompilerGenerated]
		get
		{
			return 녶녹;
		}
		[CompilerGenerated]
		set
		{
			녶녹 = value;
		}
	}

	public bool ExcludeOutOfSession
	{
		[CompilerGenerated]
		get
		{
			return 녶녔;
		}
		[CompilerGenerated]
		set
		{
			녶녔 = value;
		}
	}

	public ISessionsContainer SessionsContainer
	{
		[CompilerGenerated]
		get
		{
			return 녶녠;
		}
		[CompilerGenerated]
		set
		{
			녶녠 = value;
		}
	}

	public IProgress<float> ProgressInfo
	{
		[CompilerGenerated]
		get
		{
			return 녶놠;
		}
		[CompilerGenerated]
		set
		{
			녶놠 = value;
		}
	}

	public HistoryRequestParameters Copy => new HistoryRequestParameters(this);

	public HistoryRequestType HistoryRequestType
	{
		[CompilerGenerated]
		get
		{
			return 녶놟;
		}
		[CompilerGenerated]
		init
		{
			녶놟 = value;
		}
	}

	public HistoryRequestParameters()
	{
		ProgressInfo = new HistoryRequestParametersProgressInfo();
		ForceReload = false;
		ExcludeOutOfSession = true;
	}

	public HistoryRequestParameters(HistoryRequestParameters original)
	{
		Symbol = original.Symbol;
		SymbolId = original.SymbolId;
		Aggregation = original.Aggregation?.Clone() as HistoryAggregation;
		FromTime = original.FromTime;
		ToTime = original.ToTime;
		ForceReload = original.ForceReload;
		base.CancellationToken = original.CancellationToken;
		SessionsContainer = original.SessionsContainer;
		ExcludeOutOfSession = original.ExcludeOutOfSession;
		HistoryRequestType = original.HistoryRequestType;
	}

	public HistoryDescription ToDescription()
	{
		return new HistoryDescription(SymbolId, Aggregation);
	}
}
