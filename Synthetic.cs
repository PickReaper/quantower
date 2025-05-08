using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using TradingPlatform.BusinessLayer.Integration;
using TradingPlatform.BusinessLayer.Utils;
using 녴;

namespace TradingPlatform.BusinessLayer;

public sealed class Synthetic : CustomSymbol, ICustomizable
{
	[Serializable]
	[CompilerGenerated]
	private new sealed class 녴
	{
		public static readonly 녴 뇇놷 = new 녴();

		public static Func<SyntheticItem, string> 뇇녗;

		public static Func<SyntheticItem, bool> 뇇놜;

		public static Func<SyntheticItem, bool> 뇇놨;

		public static Func<SyntheticItem, SyntheticItem> 뇇녢;

		public static Func<OrderType, bool> 뇇놞;

		public static Func<SyntheticItem, bool> 뇇놳;

		public static Func<OrderType, bool> 뇇놺;

		public static Func<SyntheticItem, TimeInForce[]> 뇇놅;

		public static Func<IEnumerable<TimeInForce>, IEnumerable<TimeInForce>, IEnumerable<TimeInForce>> 뇇녜;

		public static Func<SyntheticItem, IEnumerable<string>> 뇇뇃;

		public static Func<SyntheticItem, IEnumerable<Period>> 뇇녯;

		public static Func<SyntheticItem, IEnumerable<HistoryType>> 뇇놮;

		public static Func<SyntheticItem, IEnumerable<HistoryType>> 뇇녫;

		public static Func<SyntheticItem, Symbol> 뇇뇁;

		public static Action<SyntheticItem> 뇇놧;

		internal string 녴(SyntheticItem P_0)
		{
			return P_0.Symbol.ConnectionId;
		}

		internal bool 놴(SyntheticItem P_0)
		{
			return P_0.Symbol == null;
		}

		internal bool 놂(SyntheticItem P_0)
		{
			return P_0.Symbol.State == BusinessObjectState.Fake;
		}

		internal SyntheticItem 놎(SyntheticItem P_0)
		{
			return new SyntheticItem(P_0);
		}

		internal bool 녞(SyntheticItem P_0)
		{
			return P_0.Symbol.GetAlowedOrderTypes(OrderTypeUsage.Order)?.FirstOrDefault((OrderType P_0) => P_0.Behavior == OrderTypeBehavior.Market) != null;
		}

		internal bool 녴(OrderType P_0)
		{
			return P_0.Behavior == OrderTypeBehavior.Market;
		}

		internal TimeInForce[] 놫(SyntheticItem P_0)
		{
			return P_0.Symbol.GetAlowedOrderTypes(OrderTypeUsage.Order).First((OrderType P_0) => P_0.Behavior == OrderTypeBehavior.Market).AllowedTifs;
		}

		internal bool 놴(OrderType P_0)
		{
			return P_0.Behavior == OrderTypeBehavior.Market;
		}

		internal IEnumerable<TimeInForce> 녴(IEnumerable<TimeInForce> P_0, IEnumerable<TimeInForce> P_1)
		{
			return P_0.Intersect(P_1);
		}

		internal IEnumerable<string> 녪(SyntheticItem P_0)
		{
			return P_0.Symbol.HistoryMetadata.AllowedAggregations;
		}

		internal IEnumerable<Period> 녶(SyntheticItem P_0)
		{
			return P_0.Symbol.HistoryMetadata.AllowedPeriodsHistoryAggregationTime;
		}

		internal IEnumerable<HistoryType> 녵(SyntheticItem P_0)
		{
			return P_0.Symbol.HistoryMetadata.AllowedHistoryTypesHistoryAggregationTime;
		}

		internal IEnumerable<HistoryType> 놭(SyntheticItem P_0)
		{
			return P_0.Symbol.HistoryMetadata.AllowedHistoryTypesHistoryAggregationTick;
		}

		internal Symbol 녲(SyntheticItem P_0)
		{
			return P_0.Symbol;
		}

		internal void 뇋(SyntheticItem P_0)
		{
			P_0.Symbol = Core.Instance.GetSymbol(P_0.Symbol.CreateInfo());
		}
	}

	[CompilerGenerated]
	private new sealed class 놴
	{
		public PlaceOrderRequestParameters 뇇녝;

		public Func<OrderType, bool> 뇇뇈;

		internal double 녴(SyntheticItem P_0)
		{
			return (double)((뇇녝.Side == Side.Buy) ? 1 : (-1)) * P_0.TradeRatio;
		}

		internal bool 녴(OrderType P_0)
		{
			return P_0.Behavior == 뇇녝.OrderType.Behavior;
		}
	}

	public const string SYNTHETIC_CONNECTION_ID = "CUSTOM_SYMBOL_CONNECTION";

	[CompilerGenerated]
	private Action<Synthetic> 뇇놰;

	[CompilerGenerated]
	private ReadOnlyCollection<SyntheticItem> 뇇놓;

	[CompilerGenerated]
	private SyntheticState 뇇놇;

	[CompilerGenerated]
	private SyntheticPriceModifier 뇇뇅;

	[CompilerGenerated]
	private bool 뇇놵;

	private List<OrderType> 뇇놡;

	private readonly object 뇇놻;

	private readonly ConnectionStateObserver 뇇놃;

	private bool 뇇뇇;

	private bool 뇇놛;

	public override Connection Connection => Items?.FirstOrDefault()?.Symbol?.Connection;

	public override BusinessObjectState State
	{
		get
		{
			if (SyntheticState != SyntheticState.Initialized)
			{
				return BusinessObjectState.Fake;
			}
			return base.State;
		}
		protected internal set
		{
			base.State = value;
		}
	}

	public string[] LegsConnectionsIds => Items.Select((SyntheticItem P_0) => P_0.Symbol.ConnectionId).Distinct().ToArray();

	public SyntheticPriceModifierType PriceModifierType
	{
		get
		{
			return PriceModifier?.Type ?? SyntheticPriceModifierType.Undefined;
		}
		set
		{
			SyntheticPriceModifier priceModifier = PriceModifier;
			if (priceModifier == null || priceModifier.Type != value)
			{
				PriceModifier = SyntheticPriceModifier.Create(value);
			}
		}
	}

	public ReadOnlyCollection<SyntheticItem> Items
	{
		[CompilerGenerated]
		get
		{
			return 뇇놓;
		}
		[CompilerGenerated]
		private set
		{
			뇇놓 = value;
		}
	}

	public SyntheticState SyntheticState
	{
		[CompilerGenerated]
		get
		{
			return 뇇놇;
		}
		[CompilerGenerated]
		private set
		{
			뇇놇 = value;
		}
	}

	public SyntheticPriceModifier PriceModifier
	{
		[CompilerGenerated]
		get
		{
			return 뇇뇅;
		}
		[CompilerGenerated]
		private set
		{
			뇇뇅 = value;
		}
	}

	public bool ForceUseTicksForHistory
	{
		[CompilerGenerated]
		get
		{
			return 뇇놵;
		}
		[CompilerGenerated]
		set
		{
			뇇놵 = value;
		}
	}

	public IList<SettingItem> Settings
	{
		get
		{
			List<SettingItem> list = new List<SettingItem>
			{
				new SettingItemString(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶놅(), base.Name),
				new SettingItemString(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶녭(), base.Id),
				new SettingItemInteger(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰논(), (int)PriceModifierType)
			};
			if (base.Group != null)
			{
				list.Add(new SettingItemGroup(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰녘(), new List<SettingItem>
				{
					new SettingItemString(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놵(), base.Group.GroupName),
					new SettingItemString(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶녭(), base.Group.Id)
				}));
			}
			for (int i = 0; i < Items.Count; i++)
			{
				list.Add(new SettingItemGroup(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰노(), Items[i].Settings));
			}
			return list;
		}
		set
		{
			if (value.GetItemByName(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶놅()) is SettingItemString settingItemString)
			{
				base.Name = (string)settingItemString.Value;
			}
			if (value.GetItemByName(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶녭()) is SettingItemString settingItemString2)
			{
				base.Id = (string)settingItemString2.Value;
			}
			PriceModifierType = (SyntheticPriceModifierType)value.GetValueOrDefault((int)PriceModifierType, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰논());
			if (value.GetItemByName(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰녘())?.Value is IEnumerable<SettingItem> list)
			{
				string text = list.GetItemByName(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놵())?.Value?.ToString();
				string text2 = list.GetItemByName(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶녭())?.Value?.ToString();
				if (!string.IsNullOrEmpty(text) && !string.IsNullOrEmpty(text2))
				{
					base.Group = new SymbolGroup(base.ConnectionId);
					base.Group.녴(new MessageSymbolGroup
					{
						GroupName = text,
						Id = text2
					});
				}
			}
			List<SyntheticItem> list2 = new List<SyntheticItem>();
			for (int i = 0; i < value.Count; i++)
			{
				if (!(value[i].Name != _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰노()))
				{
					list2.Add(new SyntheticItem
					{
						Settings = (value[i].Value as List<SettingItem>)
					});
				}
			}
			Items = new ReadOnlyCollection<SyntheticItem>(list2);
		}
	}

	public event Action<Synthetic> Reinitialized
	{
		[CompilerGenerated]
		add
		{
			Action<Synthetic> action = 뇇놰;
			Action<Synthetic> action2;
			do
			{
				action2 = action;
				Action<Synthetic> value2 = (Action<Synthetic>)Delegate.Combine(action2, value);
				action = Interlocked.CompareExchange(ref 뇇놰, value2, action2);
			}
			while ((object)action != action2);
		}
		[CompilerGenerated]
		remove
		{
			Action<Synthetic> action = 뇇놰;
			Action<Synthetic> action2;
			do
			{
				action2 = action;
				Action<Synthetic> value2 = (Action<Synthetic>)Delegate.Remove(action2, value);
				action = Interlocked.CompareExchange(ref 뇇놰, value2, action2);
			}
			while ((object)action != action2);
		}
	}

	public Synthetic(string name, SyntheticPriceModifierType priceModifierType)
		: base(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵뇍())
	{
		뇇놻 = new object();
		뇇놡 = new List<OrderType>();
		ForceUseTicksForHistory = false;
		PriceModifierType = priceModifierType;
		Items = new ReadOnlyCollection<SyntheticItem>(Array.Empty<SyntheticItem>());
		SyntheticState = SyntheticState.NotInitialized;
		base.Name = name;
		Core.Instance.녴(녞);
		뇇놃 = new ConnectionStateObserver(this, ConnectionStateObserverPriority.High, ConnectionState.Connected, ConnectionState.Disconnected, ConnectionState.ConnectionLost);
	}

	public Synthetic(string name, SyntheticPriceModifierType priceModifierType, IEnumerable<SyntheticItem> items)
		: this(name, priceModifierType)
	{
		Reinitialize(items);
	}

	public Synthetic(string name, Synthetic origin)
		: this(name, origin.PriceModifierType, origin.Items)
	{
	}

	public void Rename(string newName)
	{
		if (string.IsNullOrEmpty(newName))
		{
			throw new ArgumentException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰뇊());
		}
		base.Name = newName;
		뇇놰?.Invoke(this);
		base.놴();
	}

	public void RenameGroup(string groupName)
	{
		if (string.IsNullOrEmpty(groupName))
		{
			base.Group = null;
		}
		else
		{
			if (base.Group == null)
			{
				SymbolGroup symbolGroup2 = (base.Group = new SymbolGroup(base.ConnectionId));
			}
			base.Group.녴(new MessageSymbolGroup
			{
				GroupName = groupName,
				Id = groupName,
				SortIndex = 0
			});
		}
		뇇놰?.Invoke(this);
		base.놴();
	}

	public void Reinitialize(IEnumerable<SyntheticItem> newItems)
	{
		if (newItems == null)
		{
			throw new ArgumentNullException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰놋());
		}
		try
		{
			lock (뇇놻)
			{
				SyntheticState = SyntheticState.NotInitialized;
				녴();
				base.녴();
				MessageSymbol messageSymbol = new MessageSymbol(base.Id)
				{
					Name = base.Name,
					SymbolType = SymbolType.Synthetic,
					QuotingType = SymbolQuotingType.Undefined,
					MinLot = 1.0,
					LotStep = 1.0,
					LotSize = 1.0,
					VolumeType = SymbolVolumeType.Disable,
					NettingType = NettingType.Undefined,
					AllowCalculateRealtimeChange = true,
					AllowCalculateRealtimeTicks = false,
					AllowCalculateRealtimeTrades = false,
					AllowCalculateRealtimeVolume = false
				};
				녴(messageSymbol);
				if (!newItems.Any() || newItems.Any((SyntheticItem P_0) => P_0.Symbol == null) || newItems.Any((SyntheticItem P_0) => P_0.Symbol.State == BusinessObjectState.Fake))
				{
					return;
				}
				Items = new ReadOnlyCollection<SyntheticItem>(newItems.Select((SyntheticItem P_0) => new SyntheticItem(P_0)).ToArray());
				StringBuilder stringBuilder = new StringBuilder();
				double num = double.MinValue;
				double num2 = double.MaxValue;
				bool flag = true;
				bool flag2 = true;
				TimeSpan timeSpan = TimeSpan.MaxValue;
				double num3 = double.MaxValue;
				foreach (SyntheticItem item in Items)
				{
					if (stringBuilder.Length < 100)
					{
						StringBuilder stringBuilder2 = stringBuilder;
						StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(5, 2, stringBuilder2);
						handler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰녣());
						handler.AppendFormatted(item.Symbol.FormatQuantity(item.Coefficient));
						handler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶놩());
						handler.AppendFormatted(item.Symbol.Name);
						handler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰녩());
						stringBuilder2.Append(ref handler);
					}
					if (item.Symbol.MinLot > num)
					{
						num = item.Symbol.MinLot;
					}
					if (item.Symbol.MaxLot < num2)
					{
						num2 = item.Symbol.MaxLot;
					}
					if (item.Symbol.HistoryType != HistoryType.Last)
					{
						flag = false;
					}
					if (item.Symbol.HistoryType != HistoryType.Mark)
					{
						flag2 = false;
					}
					if (item.Symbol.TickSize < num3)
					{
						num3 = item.Symbol.TickSize;
					}
					if (item.Symbol.QuoteDelay < timeSpan)
					{
						timeSpan = item.Symbol.QuoteDelay;
					}
				}
				if (PriceModifierType == SyntheticPriceModifierType.Ln)
				{
					num3 = 1E-05;
				}
				messageSymbol.Description = stringBuilder.ToString().TrimEnd('+', ' ');
				messageSymbol.QuoteDelay = timeSpan;
				messageSymbol.VariableTickList = new List<VariableTick>
				{
					new VariableTick(num3, 1.0, null)
				};
				messageSymbol.MaxLot = Math.Floor(num2);
				messageSymbol.HistoryType = (flag ? HistoryType.Last : (flag2 ? HistoryType.Mark : HistoryType.Bid));
				녴(messageSymbol);
				bool flag3 = true;
				flag3 = Items.All((SyntheticItem P_0) => P_0.Symbol.GetAlowedOrderTypes(OrderTypeUsage.Order)?.FirstOrDefault((OrderType P_0) => P_0.Behavior == OrderTypeBehavior.Market) != null);
				if (((녪)this).Rules[_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녞()] is 높<bool> 높)
				{
					높.녴(new MessageRule
					{
						Value = flag3
					});
				}
				if (flag3)
				{
					TimeInForce[] source = Items.Select((SyntheticItem P_0) => P_0.Symbol.GetAlowedOrderTypes(OrderTypeUsage.Order).First((OrderType P_0) => P_0.Behavior == OrderTypeBehavior.Market).AllowedTifs).Cast<IEnumerable<TimeInForce>>().Aggregate((IEnumerable<TimeInForce> P_0, IEnumerable<TimeInForce> P_1) => P_0.Intersect(P_1))
						.ToArray();
					if (!source.Any())
					{
						source = new TimeInForce[1];
					}
					뇇놡 = new List<OrderType>
					{
						new MarketOrderType(source.ToArray())
					};
				}
				else
				{
					뇇놡 = new List<OrderType>
					{
						new MarketOrderType(default(TimeInForce))
					};
				}
				historyMetadata = new HistoryMetadata
				{
					AllowedAggregations = Items.SelectMany((SyntheticItem P_0) => P_0.Symbol.HistoryMetadata.AllowedAggregations).Distinct().ToArray(),
					AllowedPeriodsHistoryAggregationTime = Items.SelectMany((SyntheticItem P_0) => P_0.Symbol.HistoryMetadata.AllowedPeriodsHistoryAggregationTime).Distinct().ToArray(),
					AllowedHistoryTypesHistoryAggregationTime = Items.SelectMany((SyntheticItem P_0) => P_0.Symbol.HistoryMetadata.AllowedHistoryTypesHistoryAggregationTime).Distinct().ToArray(),
					AllowedHistoryTypesHistoryAggregationTick = Items.SelectMany((SyntheticItem P_0) => P_0.Symbol.HistoryMetadata.AllowedHistoryTypesHistoryAggregationTick).Distinct().ToArray()
				};
				foreach (SyntheticItem item2 in Items)
				{
					item2.Symbol.NewQuote += 녴;
					item2.Symbol.NewLast += 녴;
					item2.Symbol.NewMark += 녴;
					item2.Symbol.NewLevel2 += 녴;
					item2.Symbol.NewDayBar += 녴;
				}
				놎();
				SyntheticState = SyntheticState.Initialized;
				뇇뇇 = true;
			}
		}
		catch (Exception ex)
		{
			Core.Instance.Loggers.Log(ex);
		}
	}

	public override void Dispose()
	{
		뇇놃.Dispose();
		녴();
		SyntheticState = SyntheticState.NotInitialized;
		base.Dispose();
	}

	private new void 녴()
	{
		try
		{
			foreach (SyntheticItem item in Items)
			{
				item.Symbol.NewQuote -= 녴;
				item.Symbol.NewLast -= 녴;
				item.Symbol.NewMark -= 녴;
				item.Symbol.NewLevel2 -= 녴;
				item.Symbol.NewDayBar -= 녴;
			}
		}
		catch (Exception ex)
		{
			Core.Instance.Loggers.Log(ex);
		}
	}

	protected internal override void SubscribeAction(SubscribeQuoteType type)
	{
	}

	protected internal override void UnSubscribeAction(SubscribeQuoteType type)
	{
	}

	private new void 놴()
	{
		try
		{
			ReadOnlyCollection<SyntheticItem> items = Items;
			if (items != null && items.Count == 0)
			{
				return;
			}
			int count = Items.Count;
			double[] array = new double[count];
			Level2Item[][] array2 = new Level2Item[count][];
			Level2Item[][] array3 = new Level2Item[count][];
			DateTime dateTimeUtcNow = Core.Instance.TimeUtils.DateTimeUtcNow;
			for (int i = 0; i < Items.Count; i++)
			{
				SyntheticItem syntheticItem = Items[i];
				SessionsContainer currentSessionsInfo = syntheticItem.Symbol.CurrentSessionsInfo;
				if (currentSessionsInfo != null && !currentSessionsInfo.ContainsDate(dateTimeUtcNow))
				{
					return;
				}
				array[i] = syntheticItem.Coefficient;
				DepthOfMarketAggregatedCollections depthOfMarketAggregatedCollections = syntheticItem.Symbol.DepthOfMarket.GetDepthOfMarketAggregatedCollections();
				if (syntheticItem.Coefficient > 0.0)
				{
					array3[i] = new Level2Item[depthOfMarketAggregatedCollections.Bids.Length];
					for (int j = 0; j < depthOfMarketAggregatedCollections.Bids.Length; j++)
					{
						array3[i][j] = depthOfMarketAggregatedCollections.Bids[j];
					}
				}
				else
				{
					array3[i] = new Level2Item[depthOfMarketAggregatedCollections.Asks.Length];
					for (int k = 0; k < depthOfMarketAggregatedCollections.Asks.Length; k++)
					{
						array3[i][k] = depthOfMarketAggregatedCollections.Asks[k];
					}
				}
				if (syntheticItem.Coefficient > 0.0)
				{
					array2[i] = new Level2Item[depthOfMarketAggregatedCollections.Asks.Length];
					for (int l = 0; l < depthOfMarketAggregatedCollections.Asks.Length; l++)
					{
						array2[i][l] = depthOfMarketAggregatedCollections.Asks[l];
					}
				}
				else
				{
					array2[i] = new Level2Item[depthOfMarketAggregatedCollections.Bids.Length];
					for (int m = 0; m < depthOfMarketAggregatedCollections.Bids.Length; m++)
					{
						array2[i][m] = depthOfMarketAggregatedCollections.Bids[m];
					}
				}
			}
			(Level2Quote[], DateTime) tuple = global::녴.녞.녴(array, QuotePriceType.Bid, base.Id, array3, PriceModifier);
			(Level2Quote[], DateTime) tuple2 = global::녴.녞.녴(array, QuotePriceType.Ask, base.Id, array2, PriceModifier);
			DOMQuote dOMQuote = new DOMQuote(base.Id, dateTimeUtcNow);
			Level2Quote[] item = tuple.Item1;
			foreach (Level2Quote level2Quote in item)
			{
				dOMQuote.Bids.Add(new Level2Quote(level2Quote.PriceType, level2Quote.SymbolId, level2Quote.Id, RoundPriceToTickSize(level2Quote.Price), level2Quote.Size, level2Quote.Time));
			}
			item = tuple2.Item1;
			foreach (Level2Quote level2Quote2 in item)
			{
				dOMQuote.Asks.Add(new Level2Quote(level2Quote2.PriceType, level2Quote2.SymbolId, level2Quote2.Id, RoundPriceToTickSize(level2Quote2.Price), level2Quote2.Size, level2Quote2.Time));
			}
			녴(dOMQuote);
		}
		catch (Exception ex)
		{
			Core.Instance.Loggers.Log(ex);
		}
	}

	private void 놂()
	{
		ReadOnlyCollection<SyntheticItem> items = Items;
		if (items == null || items.Count != 0)
		{
			int count = Items.Count;
			double[] array = new double[count];
			double[] array2 = new double[count];
			double[] array3 = new double[count];
			double[] array4 = new double[count];
			double[] array5 = new double[count];
			DateTime[] array6 = new DateTime[count];
			for (int i = 0; i < Items.Count; i++)
			{
				SyntheticItem syntheticItem = Items[i];
				array[i] = syntheticItem.Coefficient;
				array2[i] = syntheticItem.Symbol.Open;
				array3[i] = syntheticItem.Symbol.High;
				array4[i] = syntheticItem.Symbol.Low;
				array5[i] = syntheticItem.Symbol.PrevClose;
				array6[i] = syntheticItem.Symbol.QuoteDateTime;
			}
			(double, double, double, double, DateTime) tuple = global::녴.녞.놴(array, array2, array3, array4, array5, array6, PriceModifier);
			DayBar dayBar = new DayBar(base.Name, tuple.Item5)
			{
				Open = tuple.Item1,
				High = tuple.Item2,
				Low = tuple.Item3,
				PreviousClose = tuple.Item4
			};
			녴(dayBar);
		}
	}

	private void 놎()
	{
		ReadOnlyCollection<SyntheticItem> items = Items;
		if (items == null || items.Count != 0)
		{
			int count = Items.Count;
			double[] array = new double[count];
			double[] array2 = new double[count];
			double[] array3 = new double[count];
			double[] array4 = new double[count];
			double[] array5 = new double[count];
			double[] array6 = new double[count];
			double[] array7 = new double[count];
			double[] array8 = new double[count];
			double[] array9 = new double[count];
			double[] array10 = new double[count];
			double[] array11 = new double[count];
			double[] array12 = new double[count];
			double[] array13 = new double[count];
			DateTime[] array14 = new DateTime[count];
			for (int i = 0; i < Items.Count; i++)
			{
				SyntheticItem syntheticItem = Items[i];
				array[i] = syntheticItem.Coefficient;
				array2[i] = syntheticItem.Symbol.Ask;
				array3[i] = syntheticItem.Symbol.Bid;
				array4[i] = syntheticItem.Symbol.AskSize;
				array5[i] = syntheticItem.Symbol.BidSize;
				array6[i] = syntheticItem.Symbol.Last;
				array7[i] = syntheticItem.Symbol.LastSize;
				array8[i] = syntheticItem.Symbol.Mark;
				array9[i] = syntheticItem.Symbol.MarkSize;
				array10[i] = syntheticItem.Symbol.Open;
				array11[i] = syntheticItem.Symbol.High;
				array12[i] = syntheticItem.Symbol.Low;
				array13[i] = syntheticItem.Symbol.PrevClose;
				array14[i] = syntheticItem.Symbol.QuoteDateTime;
			}
			(double, double, double, double, DateTime) tuple = global::녴.녞.녴(array, array2, array3, array4, array5, array14, PriceModifier);
			(double, double, DateTime) tuple2 = global::녴.녞.녴(array, array6, array7, array14, PriceModifier);
			(double, double, DateTime) tuple3 = global::녴.녞.놴(array, array8, array9, array14, PriceModifier);
			(double, double, double, double, DateTime) tuple4 = global::녴.녞.놴(array, array10, array11, array12, array13, array14, PriceModifier);
			DayBar obj = new DayBar(base.Name, tuple.Item5)
			{
				Bid = tuple.Item2,
				BidSize = tuple.Item4
			};
			(obj.Ask, _, obj.AskSize, _, _) = tuple;
			(obj.Last, obj.LastSize, _) = tuple2;
			(obj.Mark, obj.MarkSize, _) = tuple3;
			(obj.Open, obj.High, obj.Low, obj.PreviousClose, _) = tuple4;
			녴(obj);
		}
	}

	private void 녞()
	{
		if (SyntheticState == SyntheticState.Initialized)
		{
			if (뇇뇇)
			{
				뇇뇇 = false;
				놴();
			}
			if (뇇놛)
			{
				뇇놛 = false;
				놂();
			}
		}
	}

	private void 녴(Symbol P_0, Last P_1)
	{
		if (SyntheticState == SyntheticState.NotInitialized)
		{
			return;
		}
		int count = Items.Count;
		double[] array = new double[count];
		double[] array2 = new double[count];
		double[] array3 = new double[count];
		DateTime[] array4 = new DateTime[count];
		for (int i = 0; i < Items.Count; i++)
		{
			SyntheticItem syntheticItem = Items[i];
			array[i] = syntheticItem.Coefficient;
			array2[i] = syntheticItem.Symbol.Last;
			array3[i] = syntheticItem.Symbol.LastSize;
			array4[i] = syntheticItem.Symbol.LastDateTime;
			SessionsContainer currentSessionsInfo = syntheticItem.Symbol.CurrentSessionsInfo;
			if (currentSessionsInfo != null && !currentSessionsInfo.ContainsDate(array4[i]))
			{
				return;
			}
		}
		(double, double, DateTime) tuple = global::녴.녞.녴(array, array2, array3, array4, PriceModifier);
		if (!tuple.Item1.IsNanOrDefault())
		{
			tuple.Item1 = RoundPriceToTickSize(tuple.Item1);
			Last last = new Last(base.Name, tuple.Item1, tuple.Item2, tuple.Item3)
			{
				AggressorFlag = AggressorFlag.NotSet
			};
			녴(last);
		}
	}

	private void 녴(Symbol P_0, Mark P_1)
	{
		if (SyntheticState == SyntheticState.NotInitialized)
		{
			return;
		}
		int count = Items.Count;
		double[] array = new double[count];
		double[] array2 = new double[count];
		double[] array3 = new double[count];
		DateTime[] array4 = new DateTime[count];
		for (int i = 0; i < Items.Count; i++)
		{
			SyntheticItem syntheticItem = Items[i];
			array[i] = syntheticItem.Coefficient;
			array2[i] = syntheticItem.Symbol.Mark;
			array3[i] = syntheticItem.Symbol.MarkSize;
			array4[i] = syntheticItem.Symbol.LastDateTime;
			SessionsContainer currentSessionsInfo = syntheticItem.Symbol.CurrentSessionsInfo;
			if (currentSessionsInfo != null && !currentSessionsInfo.ContainsDate(array4[i]))
			{
				return;
			}
		}
		(double, double, DateTime) tuple = global::녴.녞.놴(array, array2, array3, array4, PriceModifier);
		if (tuple.Item1 != 0.0)
		{
			tuple.Item1 = RoundPriceToTickSize(tuple.Item1);
			Mark mark = new Mark(base.Name, tuple.Item3, tuple.Item1, tuple.Item2);
			녴(mark);
		}
	}

	private void 녴(Symbol P_0, Quote P_1)
	{
		if (SyntheticState == SyntheticState.NotInitialized)
		{
			return;
		}
		int count = Items.Count;
		double[] array = new double[count];
		double[] array2 = new double[count];
		double[] array3 = new double[count];
		double[] array4 = new double[count];
		double[] array5 = new double[count];
		DateTime[] array6 = new DateTime[count];
		for (int i = 0; i < Items.Count; i++)
		{
			SyntheticItem syntheticItem = Items[i];
			array[i] = syntheticItem.Coefficient;
			array2[i] = syntheticItem.Symbol.Ask;
			array3[i] = syntheticItem.Symbol.Bid;
			array4[i] = syntheticItem.Symbol.AskSize;
			array5[i] = syntheticItem.Symbol.BidSize;
			array6[i] = syntheticItem.Symbol.QuoteDateTime;
			SessionsContainer currentSessionsInfo = syntheticItem.Symbol.CurrentSessionsInfo;
			if (currentSessionsInfo != null && !currentSessionsInfo.ContainsDate(array6[i]))
			{
				return;
			}
		}
		(double, double, double, double, DateTime) tuple = global::녴.녞.녴(array, array2, array3, array4, array5, array6, PriceModifier);
		if (!tuple.Item2.IsNanOrDefault() || !tuple.Item1.IsNanOrDefault())
		{
			tuple.Item2 = RoundPriceToTickSize(tuple.Item2);
			tuple.Item1 = RoundPriceToTickSize(tuple.Item1);
			Quote quote = new Quote(base.Name, tuple.Item2, tuple.Item4, tuple.Item1, tuple.Item3, tuple.Item5);
			녴(quote);
		}
	}

	private void 녴(Symbol P_0, Level2Quote P_1, DOMQuote P_2)
	{
		뇇뇇 = true;
	}

	private void 녴(Symbol P_0, DayBar P_1)
	{
		뇇놛 = true;
	}

	private protected override HistoricalData 녴(HistoryRequestParameters P_0)
	{
		return new 놺(P_0);
	}

	public override List<OrderType> GetAlowedOrderTypes(OrderTypeUsage? usage)
	{
		return 뇇놡;
	}

	public override bool IsTradingAllowed(Account account)
	{
		foreach (Symbol item in Items.Select((SyntheticItem P_0) => P_0.Symbol))
		{
			Account account2 = item.Connection?.BusinessObjects?.Accounts?.FirstOrDefault();
			if (account2 == null)
			{
				return false;
			}
			if (!item.IsTradingAllowed(account2))
			{
				return false;
			}
		}
		return true;
	}

	internal override TradingOperationResult 녴(PlaceOrderRequestParameters P_0)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵녣());
		}
		if (P_0.OrderTypeId != _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵놋())
		{
			return TradingOperationResult.CreateError(P_0.RequestId, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰놤());
		}
		List<SyntheticItem> list = Items.OrderByDescending((SyntheticItem P_0) => (double)((P_0.Side == Side.Buy) ? 1 : (-1)) * P_0.TradeRatio).ToList();
		for (int i = 0; i < list.Count; i++)
		{
			SyntheticItem syntheticItem = list[i];
			Symbol symbol = syntheticItem.Symbol;
			PlaceOrderRequestParameters placeOrderRequestParameters = new PlaceOrderRequestParameters(P_0)
			{
				Symbol = symbol,
				Account = ((LegsConnectionsIds.Length > 1) ? symbol.Connection.BusinessObjects.Accounts[0] : P_0.Account)
			};
			OrderType orderType = syntheticItem.Symbol.GetAlowedOrderTypes(OrderTypeUsage.Order).FirstOrDefault((OrderType P_0) => P_0.Behavior == P_0.OrderType.Behavior);
			if (orderType == null)
			{
				return TradingOperationResult.CreateError(P_0.RequestId, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵녭());
			}
			placeOrderRequestParameters.OrderTypeId = orderType.Id;
			placeOrderRequestParameters.Quantity = (double)Math.Abs((decimal)placeOrderRequestParameters.Quantity * (decimal)syntheticItem.TradeRatio);
			if ((P_0.Side == Side.Buy && syntheticItem.TradeRatio > 0.0) || (P_0.Side == Side.Sell && syntheticItem.TradeRatio < 0.0))
			{
				placeOrderRequestParameters.Side = Side.Buy;
			}
			else
			{
				placeOrderRequestParameters.Side = Side.Sell;
			}
			if (!string.IsNullOrEmpty(syntheticItem.TradeComment))
			{
				placeOrderRequestParameters.Comment = syntheticItem.TradeComment;
			}
			TradingOperationResult tradingOperationResult = syntheticItem.Symbol.녴(placeOrderRequestParameters);
			if (tradingOperationResult.Status == TradingOperationResultStatus.Failure)
			{
				return tradingOperationResult;
			}
		}
		return TradingOperationResult.CreateSuccess(P_0.RequestId);
	}

	public override Account GetDefaultAccount(Account currentValue = null)
	{
		if (LegsConnectionsIds.Length != 1)
		{
			return null;
		}
		if (currentValue?.ConnectionId == Items[0].Symbol.ConnectionId)
		{
			return currentValue;
		}
		return Core.Instance.Connections[Items[0].Symbol.ConnectionId]?.BusinessObjects?.Accounts?.FirstOrDefault();
	}

	public override string FormatQuantity(double quantity, bool inLots = true, bool abbreviate = false)
	{
		int valuePrecision = CoreMath.GetValuePrecision((decimal)quantity);
		return quantity.Format(valuePrecision, abbreviate);
	}

	public override ConnectionDependency GetConnectionStateDependency()
	{
		return new ConnectionDependency
		{
			Behavior = ConnectionDependencyBehavior.PartialDependency,
			DependentConnectionsIds = LegsConnectionsIds
		};
	}

	public override void OnConnectionStateChanged(Connection connection, ConnectionStateChangedEventArgs e)
	{
		List<SyntheticItem> list = Items.ToList();
		list.ForEach(delegate(SyntheticItem P_0)
		{
			P_0.Symbol = Core.Instance.GetSymbol(P_0.Symbol.CreateInfo());
		});
		Reinitialize(list);
	}
}
