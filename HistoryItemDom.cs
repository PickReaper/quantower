using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using ProtoBuf;

namespace TradingPlatform.BusinessLayer;

[ProtoContract]
public sealed class HistoryItemDom : HistoryItem
{
	[Serializable]
	[CompilerGenerated]
	private sealed class 녴
	{
		public static readonly 녴 놻놖 = new 녴();

		public static Func<Level2Quote, HistoryItemLevel2> 놻놝;

		public static Func<Level2Quote, HistoryItemLevel2> 놻뇄;

		public static Func<HistoryItemLevel2, HistoryItemLevel2> 놻녑;

		public static Func<HistoryItemLevel2, HistoryItemLevel2> 놻놈;

		internal HistoryItemLevel2 녴(Level2Quote P_0)
		{
			return new HistoryItemLevel2(P_0);
		}

		internal HistoryItemLevel2 놴(Level2Quote P_0)
		{
			return new HistoryItemLevel2(P_0);
		}

		internal HistoryItemLevel2 녴(HistoryItemLevel2 P_0)
		{
			return new HistoryItemLevel2(P_0);
		}

		internal HistoryItemLevel2 놴(HistoryItemLevel2 P_0)
		{
			return new HistoryItemLevel2(P_0);
		}
	}

	[CompilerGenerated]
	private List<HistoryItemLevel2> 놇놬;

	[CompilerGenerated]
	private List<HistoryItemLevel2> 놇놊;

	[ProtoMember(1)]
	public List<HistoryItemLevel2> Asks
	{
		[CompilerGenerated]
		get
		{
			return 놇놬;
		}
		[CompilerGenerated]
		set
		{
			놇놬 = value;
		}
	}

	[ProtoMember(2)]
	public List<HistoryItemLevel2> Bids
	{
		[CompilerGenerated]
		get
		{
			return 놇놊;
		}
		[CompilerGenerated]
		set
		{
			놇놊 = value;
		}
	}

	/// <summary>
	/// Creates HistoryItemLast instance
	/// </summary>
	public HistoryItemDom()
	{
		Asks = new List<HistoryItemLevel2>();
		Bids = new List<HistoryItemLevel2>();
	}

	public HistoryItemDom(DOMQuote domQuote)
		: base(domQuote)
	{
		Asks = domQuote.Asks.Select((Level2Quote P_0) => new HistoryItemLevel2(P_0)).ToList();
		Bids = domQuote.Bids.Select((Level2Quote P_0) => new HistoryItemLevel2(P_0)).ToList();
	}

	public HistoryItemDom(HistoryItemDom original)
		: base(original)
	{
		Asks = original.Asks.Select((HistoryItemLevel2 P_0) => new HistoryItemLevel2(P_0)).ToList();
		Bids = original.Bids.Select((HistoryItemLevel2 P_0) => new HistoryItemLevel2(P_0)).ToList();
	}

	[NotPublished]
	public override object Clone()
	{
		return new HistoryItemDom(this);
	}
}
