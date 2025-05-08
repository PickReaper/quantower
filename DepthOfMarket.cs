using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using TradingPlatform.BusinessLayer.Integration;
using 녴;

namespace TradingPlatform.BusinessLayer;

/// <summary>
/// Represent access to level2 data.
/// </summary>
[Published]
public class DepthOfMarket : IMessageBuilder<DOMQuote>
{
	[CompilerGenerated]
	private 녶 놾;

	[CompilerGenerated]
	private 녶 뇀;

	private Dictionary<int, DepthOfMarketAggregatedCollections> 놽;

	private readonly Symbol 녿;

	private readonly object 놁;

	/// <summary>
	/// Gets Level2 Asks list
	/// </summary>
	internal 녶 Asks
	{
		[CompilerGenerated]
		get
		{
			return 놾;
		}
		[CompilerGenerated]
		private set
		{
			놾 = value;
		}
	}

	/// <summary>
	/// Gets Level2 Bids list
	/// </summary>
	internal 녶 Bids
	{
		[CompilerGenerated]
		get
		{
			return 뇀;
		}
		[CompilerGenerated]
		private set
		{
			뇀 = value;
		}
	}

	internal DepthOfMarket(Symbol P_0)
	{
		녿 = P_0;
		bool flag = Core.Instance.RulesManager.IsAllowed(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸(), 녿.ConnectionId).Status == TradingOperationStatus.Allowed;
		Asks = new 녶(QuotePriceType.Ask, flag);
		Bids = new 녶(QuotePriceType.Bid, flag);
		놁 = new object();
		놽 = new Dictionary<int, DepthOfMarketAggregatedCollections>();
	}

	internal void 녴(Level2Quote P_0)
	{
		lock (놁)
		{
			if (P_0.PriceType == QuotePriceType.Ask)
			{
				Asks.녴(P_0);
			}
			else
			{
				Bids.녴(P_0);
			}
			놽 = new Dictionary<int, DepthOfMarketAggregatedCollections>();
		}
	}

	internal void 녴(DOMQuote P_0)
	{
		lock (놁)
		{
			Asks.녴(P_0.Asks);
			Bids.녴(P_0.Bids);
			놽 = new Dictionary<int, DepthOfMarketAggregatedCollections>();
		}
	}

	internal void 녴()
	{
		lock (놁)
		{
			Asks.녴();
			Bids.녴();
			놽.Clear();
		}
	}

	/// <summary>
	/// Gets current Level2 data
	/// </summary>
	/// <param name="parameters">Parameters of DepthOfMarket</param>
	/// <returns></returns>
	public DepthOfMarketAggregatedCollections GetDepthOfMarketAggregatedCollections(GetDepthOfMarketParameters parameters = null)
	{
		if (parameters == null)
		{
			parameters = new GetDepthOfMarketParameters();
		}
		lock (놁)
		{
			int hashCode = parameters.GetHashCode();
			if (!놽.TryGetValue(hashCode, out var value))
			{
				value = new DepthOfMarketAggregatedCollections
				{
					Asks = Asks.녴(parameters.GetLevel2ItemsParameters),
					Bids = Bids.녴(parameters.GetLevel2ItemsParameters)
				};
				if (parameters.CalculateImbalancePercent)
				{
					녴(value.Asks, value.Bids);
				}
				놽[hashCode] = value;
			}
			return value;
		}
	}

	/// <summary>
	/// Gets current Level2 data
	/// </summary>
	/// <param name="parameters">Parameters of request for Leve2Item collection</param>
	/// <returns></returns>
	public DepthOfMarketAggregatedCollections GetDepthOfMarketAggregatedCollections(GetLevel2ItemsParameters parameters)
	{
		return GetDepthOfMarketAggregatedCollections(new GetDepthOfMarketParameters
		{
			GetLevel2ItemsParameters = parameters
		});
	}

	private static void 녴(Level2Item[] P_0, Level2Item[] P_1)
	{
		int num = Math.Min(P_1.Length, P_0.Length);
		for (int i = 0; i < num; i++)
		{
			Level2Item level2Item = P_0[i];
			Level2Item level2Item2 = P_1[i];
			double cumulative = level2Item.Cumulative;
			double cumulative2 = level2Item2.Cumulative;
			if (cumulative >= 0.0 && cumulative2 >= 0.0)
			{
				level2Item.ImbalancePercent = Math.Round(level2Item.Cumulative / (level2Item.Cumulative + level2Item2.Cumulative) * 100.0, 2);
				level2Item2.ImbalancePercent = 100.0 - level2Item.ImbalancePercent;
			}
		}
	}

	private DOMQuote 놴()
	{
		return new DOMQuote(녿.Id, Core.Instance.TimeUtils.DateTimeUtcNow)
		{
			Asks = Asks.Items.Values.ToList(),
			Bids = Bids.Items.Values.ToList()
		};
	}

	DOMQuote IMessageBuilder<DOMQuote>.BuildMessage()
	{
		//ILSpy generated this explicit interface implementation from .override directive in 놴
		return this.놴();
	}
}
