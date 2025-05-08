using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using TradingPlatform.BusinessLayer.Utils.Extensions;

namespace TradingPlatform.BusinessLayer;

public sealed class CustomSessionsAssignment : IUniqueID, ICustomizable, IEquatable<CustomSessionsAssignment>
{
	[CompilerGenerated]
	private string 녶놛;

	[CompilerGenerated]
	private bool 녶놼;

	[CompilerGenerated]
	private string 녶놗;

	[CompilerGenerated]
	private string 녶뇂;

	[CompilerGenerated]
	private string 녶놩;

	[CompilerGenerated]
	private string 녶녡;

	public IList<SettingItem> Settings
	{
		get
		{
			return new List<SettingItem>
			{
				new SettingItemString(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭놸(), UniqueId),
				new SettingItemBoolean(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭놫(), IsActive),
				new SettingItemString(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭놿(), ConnectionId),
				new SettingItemString(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭놄(), ExchangeId),
				new SettingItemString(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭놰(), SymbolId),
				new SettingItemString(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭놓(), CustomSessionsContainerId)
			};
		}
		set
		{
			UniqueId = value.GetValueOrDefault(UniqueId, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭놸());
			IsActive = value.GetValueOrDefault(IsActive, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭놫());
			ConnectionId = value.GetValueOrDefault(ConnectionId, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭놿());
			ExchangeId = value.GetValueOrDefault(ExchangeId, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭놄());
			SymbolId = value.GetValueOrDefault(SymbolId, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭놰());
			CustomSessionsContainerId = value.GetValueOrDefault(CustomSessionsContainerId, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭놓());
		}
	}

	public string UniqueId
	{
		[CompilerGenerated]
		get
		{
			return 녶놛;
		}
		[CompilerGenerated]
		private set
		{
			녶놛 = value;
		}
	}

	public bool IsActive
	{
		[CompilerGenerated]
		get
		{
			return 녶놼;
		}
		[CompilerGenerated]
		set
		{
			녶놼 = value;
		}
	}

	public string ConnectionId
	{
		[CompilerGenerated]
		get
		{
			return 녶놗;
		}
		[CompilerGenerated]
		private set
		{
			녶놗 = value;
		}
	}

	public string ExchangeId
	{
		[CompilerGenerated]
		get
		{
			return 녶뇂;
		}
		[CompilerGenerated]
		private set
		{
			녶뇂 = value;
		}
	}

	public string SymbolId
	{
		[CompilerGenerated]
		get
		{
			return 녶놩;
		}
		[CompilerGenerated]
		private set
		{
			녶놩 = value;
		}
	}

	public string CustomSessionsContainerId
	{
		[CompilerGenerated]
		get
		{
			return 녶녡;
		}
		[CompilerGenerated]
		internal set
		{
			녶녡 = value;
		}
	}

	public ExchangeComplexIdentifier ExchangeComplexId => new ExchangeComplexIdentifier(ConnectionId, ExchangeId);

	public SymbolComplexIdentifier SymbolComplexId => new SymbolComplexIdentifier(ConnectionId, ExchangeId, SymbolId);

	public Connection Connection => Core.Instance.Connections[ConnectionId];

	public Exchange Exchange => Core.Instance.Exchanges.FirstOrDefault(delegate(Exchange P_0)
	{
		ExchangeComplexIdentifier complexId = P_0.ComplexId;
		ExchangeComplexIdentifier? obj = this?.ExchangeComplexId;
		return complexId == obj;
	});

	public Symbol Symbol
	{
		get
		{
			try
			{
				if (string.IsNullOrEmpty(SymbolId))
				{
					return null;
				}
				return Core.Instance.GetSymbol(new GetSymbolRequestParameters
				{
					SymbolId = SymbolId
				}, ConnectionId);
			}
			catch
			{
				return null;
			}
		}
	}

	public CustomSessionsContainer SessionsContainer => Core.Instance.CustomSessions[CustomSessionsContainerId];

	public CustomSessionsAssignment(string containerId, string connectionId = null, string exchangeId = null, string symbolId = null)
		: this()
	{
		IsActive = true;
		CustomSessionsContainerId = containerId;
		ConnectionId = connectionId;
		ExchangeId = exchangeId;
		SymbolId = symbolId;
	}

	public CustomSessionsAssignment(CustomSessionsAssignment origin)
		: this()
	{
		IsActive = origin.IsActive;
		ConnectionId = origin.ConnectionId;
		ExchangeId = origin.ExchangeId;
		SymbolId = origin.SymbolId;
		CustomSessionsContainerId = origin.CustomSessionsContainerId;
	}

	internal CustomSessionsAssignment()
	{
		UniqueId = Guid.NewGuid().ToShortString();
	}

	internal void 녴(CustomSessionsAssignment P_0)
	{
		IsActive = P_0.IsActive;
		ConnectionId = P_0.ConnectionId;
		ExchangeId = P_0.ExchangeId;
		SymbolId = P_0.SymbolId;
		CustomSessionsContainerId = P_0.CustomSessionsContainerId;
	}

	public bool Equals(CustomSessionsAssignment other)
	{
		if (other == null)
		{
			return false;
		}
		if (this == other)
		{
			return true;
		}
		if (ConnectionId == other.ConnectionId && ExchangeId == other.ExchangeId && SymbolId == other.SymbolId)
		{
			return CustomSessionsContainerId == other.CustomSessionsContainerId;
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
		return Equals((CustomSessionsAssignment)obj);
	}

	public override int GetHashCode()
	{
		return (((((((ConnectionId != null) ? ConnectionId.GetHashCode() : 0) * 397) ^ ((ExchangeId != null) ? ExchangeId.GetHashCode() : 0)) * 397) ^ ((SymbolId != null) ? SymbolId.GetHashCode() : 0)) * 397) ^ ((CustomSessionsContainerId != null) ? CustomSessionsContainerId.GetHashCode() : 0);
	}

	[CompilerGenerated]
	private bool 녴(Exchange P_0)
	{
		ExchangeComplexIdentifier complexId = P_0.ComplexId;
		ExchangeComplexIdentifier? obj = this?.ExchangeComplexId;
		return complexId == obj;
	}
}
