using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using TradingPlatform.BusinessLayer.Integration;

namespace TradingPlatform.BusinessLayer;

public sealed class SymbolMap : IDisposable, IUniqueID, ICustomizable, IConnectionStateDependent
{
	[CompilerGenerated]
	private sealed class 녴
	{
		public SymbolMap 놵녥;

		public Symbol 놵농;

		internal void 녴()
		{
			놵녥.놴(놵녥.TradableSymbol);
			놵녥.녵놁 = 놵농;
			놵녥.놂(놵녥.QuotesSymbol);
			놵녥.녴(놵녥.TradableSymbol);
		}
	}

	[CompilerGenerated]
	private sealed class 놴
	{
		public SymbolMap 놵념;

		public bool 놵녨;

		internal void 녴()
		{
			놵념.놴(놵념.TradableSymbol);
			놵념.녵놶 = 놵녨;
			놵념.놂(놵녨 ? 놵념.QuotesSymbol : 놵념.TradableSymbol);
			놵념.녴(놵념.TradableSymbol);
		}
	}

	[CompilerGenerated]
	private sealed class 놂
	{
		public SymbolMap 놵녺;

		public Symbol 놵놣;

		public Symbol 놵녮;

		public Action 놵뇆;

		internal void 녴()
		{
			놵녺.놴(놵놣);
			놵녮.녴(delegate
			{
				놵녺.놴(놵녮);
				놵녺.녵녿 = 놵녮;
				놵녺.놂(놵녺.QuotesSymbol);
				놵녺.녴(놵녮);
			});
			놵녺.녴(놵놣);
		}

		internal void 놴()
		{
			놵녺.놴(놵녮);
			놵녺.녵녿 = 놵녮;
			놵녺.놂(놵녺.QuotesSymbol);
			놵녺.녴(놵녮);
		}
	}

	[CompilerGenerated]
	private string 녵놽;

	private Symbol 녵녿;

	private Symbol 녵놁;

	[CompilerGenerated]
	private Symbol 녵녭;

	[CompilerGenerated]
	private Symbol 녵녱;

	[CompilerGenerated]
	private Symbol 녵놲;

	[CompilerGenerated]
	private Symbol 녵높;

	private bool 녵놶;

	private readonly ConnectionStateObserver 녵뇏;

	public string UniqueId => Id;

	public string Id
	{
		[CompilerGenerated]
		get
		{
			return 녵놽;
		}
		[CompilerGenerated]
		private set
		{
			녵놽 = value;
		}
	}

	public Symbol TradableSymbol
	{
		get
		{
			return 녵녿;
		}
		private set
		{
			if (녵녿 == value)
			{
				return;
			}
			Symbol 놵놣 = TradableSymbol;
			놵놣.녴(delegate
			{
				놴(놵놣);
				value.녴(delegate
				{
					놴(value);
					녵녿 = value;
					놂(QuotesSymbol);
					녴(value);
				});
				녴(놵놣);
			});
		}
	}

	public Symbol QuotesSymbol
	{
		get
		{
			return 녵놁;
		}
		private set
		{
			if (녵놁 != value)
			{
				TradableSymbol.녴(delegate
				{
					놴(TradableSymbol);
					녵놁 = value;
					놂(QuotesSymbol);
					녴(TradableSymbol);
				});
			}
		}
	}

	public Symbol TickHistorySymbol
	{
		[CompilerGenerated]
		get
		{
			return 녵녭;
		}
		[CompilerGenerated]
		private set
		{
			녵녭 = value;
		}
	}

	public Symbol MinuteHistorySymbol
	{
		[CompilerGenerated]
		get
		{
			return 녵녱;
		}
		[CompilerGenerated]
		private set
		{
			녵녱 = value;
		}
	}

	public Symbol DayHistorySymbol
	{
		[CompilerGenerated]
		get
		{
			return 녵놲;
		}
		[CompilerGenerated]
		private set
		{
			녵놲 = value;
		}
	}

	public Symbol VolumeAnalysisSymbol
	{
		[CompilerGenerated]
		get
		{
			return 녵높;
		}
		[CompilerGenerated]
		private set
		{
			녵높 = value;
		}
	}

	public bool IsActive
	{
		get
		{
			return 녵놶;
		}
		private set
		{
			if (녵놶 == value)
			{
				return;
			}
			if (TradableSymbol == null)
			{
				녵놶 = value;
				return;
			}
			TradableSymbol.녴(delegate
			{
				놴(TradableSymbol);
				녵놶 = value;
				놂(value ? QuotesSymbol : TradableSymbol);
				녴(TradableSymbol);
			});
		}
	}

	public IList<SettingItem> Settings
	{
		get
		{
			return new List<SettingItem>
			{
				new SettingItemString(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭놸(), Id),
				new SettingItemSymbol(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭녽(), TradableSymbol),
				new SettingItemSymbol(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭놏(), QuotesSymbol),
				new SettingItemSymbol(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭녥(), TickHistorySymbol),
				new SettingItemSymbol(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭농(), MinuteHistorySymbol),
				new SettingItemSymbol(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭념(), DayHistorySymbol),
				new SettingItemSymbol(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭녨(), VolumeAnalysisSymbol),
				new SettingItemBoolean(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭놫(), IsActive)
			};
		}
		set
		{
			Id = value.GetValueOrDefault(Id, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭놸());
			녵녿 = value.GetValueOrDefault(녵녿, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭녽());
			녵놁 = value.GetValueOrDefault(녵놁, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭놏());
			TickHistorySymbol = value.GetValueOrDefault(TickHistorySymbol, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭녥());
			MinuteHistorySymbol = value.GetValueOrDefault(MinuteHistorySymbol, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭농());
			DayHistorySymbol = value.GetValueOrDefault(DayHistorySymbol, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭념());
			VolumeAnalysisSymbol = value.GetValueOrDefault(VolumeAnalysisSymbol, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭녨());
			IsActive = value.GetValueOrDefault(IsActive, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭놫());
			if (value.TryGetValue<Symbol>(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭녨(), out var value2))
			{
				VolumeAnalysisSymbol = value2;
			}
			else
			{
				VolumeAnalysisSymbol = DayHistorySymbol ?? MinuteHistorySymbol ?? TickHistorySymbol ?? QuotesSymbol;
			}
		}
	}

	internal SymbolMap()
	{
		녵뇏 = new ConnectionStateObserver(this, ConnectionStateObserverPriority.High, ConnectionState.Connected, ConnectionState.Disconnected, ConnectionState.ConnectionLost);
	}

	internal SymbolMap(Symbol P_0)
		: this()
	{
		Id = Guid.NewGuid().ToString();
		IsActive = true;
		녵녿 = P_0;
	}

	internal bool 녴(Period P_0, out Symbol P_1)
	{
		P_1 = null;
		if (P_0.BasePeriod >= BasePeriod.Day)
		{
			P_1 = DayHistorySymbol;
		}
		else if (P_0.BasePeriod >= BasePeriod.Minute)
		{
			P_1 = MinuteHistorySymbol;
		}
		else
		{
			P_1 = TickHistorySymbol;
		}
		return P_1 != null;
	}

	internal void 녴(SymbolMappingParameters P_0, bool P_1 = true)
	{
		IsActive = P_0.IsActive;
		TradableSymbol = P_0.TradableSymbol;
		if (P_1)
		{
			QuotesSymbol = P_0.QuotesSymbol;
		}
		else
		{
			녵놁 = P_0.QuotesSymbol;
		}
		TickHistorySymbol = P_0.TickHistorySymbol;
		MinuteHistorySymbol = P_0.MinuteHistorySymbol;
		DayHistorySymbol = P_0.DayHistorySymbol;
		VolumeAnalysisSymbol = P_0.VolumeAnalysisSymbol;
	}

	internal void 녴()
	{
		QuotesSymbol = null;
		TickHistorySymbol = null;
		MinuteHistorySymbol = null;
		DayHistorySymbol = null;
		VolumeAnalysisSymbol = null;
	}

	public SymbolMapState GetState()
	{
		return new SymbolMapState(this);
	}

	public override string ToString()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(15, 6);
		defaultInterpolatedStringHandler.AppendFormatted(TradableSymbol);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴뇎());
		defaultInterpolatedStringHandler.AppendFormatted(QuotesSymbol);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴뇎());
		defaultInterpolatedStringHandler.AppendFormatted(TickHistorySymbol);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴뇎());
		defaultInterpolatedStringHandler.AppendFormatted(MinuteHistorySymbol);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴뇎());
		defaultInterpolatedStringHandler.AppendFormatted(DayHistorySymbol);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴뇎());
		defaultInterpolatedStringHandler.AppendFormatted(VolumeAnalysisSymbol);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	public void Dispose()
	{
		녵뇏.Dispose();
	}

	public ConnectionDependency GetConnectionStateDependency()
	{
		List<string> list = new List<string> { TradableSymbol.ConnectionId };
		녴(QuotesSymbol, list);
		녴(TickHistorySymbol, list);
		녴(MinuteHistorySymbol, list);
		녴(DayHistorySymbol, list);
		녴(VolumeAnalysisSymbol, list);
		return new ConnectionDependency
		{
			Behavior = ConnectionDependencyBehavior.PartialDependency,
			DependentConnectionsIds = list.ToArray()
		};
	}

	public void OnConnectionStateChanged(Connection connection, ConnectionStateChangedEventArgs e)
	{
		string id = connection.Id;
		if (TradableSymbol.ConnectionId == id)
		{
			TradableSymbol = Core.Instance.GetSymbol(TradableSymbol.CreateInfo());
		}
		if (QuotesSymbol?.ConnectionId == id)
		{
			QuotesSymbol = Core.Instance.GetSymbol(QuotesSymbol.CreateInfo());
		}
		if (TickHistorySymbol?.ConnectionId == id)
		{
			TickHistorySymbol = Core.Instance.GetSymbol(TickHistorySymbol.CreateInfo());
		}
		if (MinuteHistorySymbol?.ConnectionId == id)
		{
			MinuteHistorySymbol = Core.Instance.GetSymbol(MinuteHistorySymbol.CreateInfo());
		}
		if (DayHistorySymbol?.ConnectionId == id)
		{
			DayHistorySymbol = Core.Instance.GetSymbol(DayHistorySymbol.CreateInfo());
		}
		if (VolumeAnalysisSymbol?.ConnectionId == id)
		{
			VolumeAnalysisSymbol = Core.Instance.GetSymbol(VolumeAnalysisSymbol.CreateInfo());
		}
	}

	private void 녴(Symbol P_0, List<string> P_1)
	{
		if (P_0 != null)
		{
			P_1.Add(P_0.ConnectionId);
		}
	}

	private void 녴(Symbol P_0)
	{
		if (P_0.QuotesSubscribed)
		{
			P_0.SubscribeAction(SubscribeQuoteType.Quote);
		}
		if (P_0.Level2Subscribed)
		{
			P_0.SubscribeAction(SubscribeQuoteType.Level2);
		}
		if (P_0.LastsSubscribed)
		{
			P_0.SubscribeAction(SubscribeQuoteType.Last);
		}
		if (P_0.MarkSubscribed)
		{
			P_0.SubscribeAction(SubscribeQuoteType.Mark);
		}
	}

	private void 놴(Symbol P_0)
	{
		if (P_0.QuotesSubscribed)
		{
			P_0.UnSubscribeAction(SubscribeQuoteType.Quote);
		}
		if (P_0.Level2Subscribed)
		{
			P_0.UnSubscribeAction(SubscribeQuoteType.Level2);
		}
		if (P_0.LastsSubscribed)
		{
			P_0.UnSubscribeAction(SubscribeQuoteType.Last);
		}
		if (P_0.MarkSubscribed)
		{
			P_0.UnSubscribeAction(SubscribeQuoteType.Mark);
		}
	}

	private void 놂(Symbol P_0)
	{
		if (P_0 != null && TradableSymbol.HasAnySubscription)
		{
			DayBar dayBar = 놎(P_0);
			dayBar.FullRefresh = true;
			TradableSymbol.녴(dayBar);
		}
	}

	private DayBar 놎(Symbol P_0)
	{
		return ((IMessageBuilder<DayBar>)P_0).BuildMessage();
	}
}
