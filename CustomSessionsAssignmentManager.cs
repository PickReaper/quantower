using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;

namespace TradingPlatform.BusinessLayer;

public class CustomSessionsAssignmentManager : IEnumerable<CustomSessionsAssignment>, IEnumerable, ICustomizable
{
	private class 녴 : IComparer<CustomSessionsAssignment>
	{
		public int Compare(CustomSessionsAssignment x, CustomSessionsAssignment y)
		{
			if (x == null && y != null)
			{
				return 1;
			}
			if (x != null && y == null)
			{
				return -1;
			}
			if (x == y)
			{
				return 0;
			}
			if (!string.IsNullOrEmpty(x.SymbolId))
			{
				return -1;
			}
			if (!string.IsNullOrEmpty(y.SymbolId))
			{
				return 1;
			}
			if (!string.IsNullOrEmpty(x.ExchangeId))
			{
				return -1;
			}
			if (!string.IsNullOrEmpty(y.ExchangeId))
			{
				return 1;
			}
			return 0;
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class 놴
	{
		public static readonly 놴 놇놻 = new 놴();

		public static Func<CustomSessionsAssignment, SettingItemGroup> 놇놃;

		internal SettingItemGroup 녴(CustomSessionsAssignment P_0)
		{
			return new SettingItemGroup(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸놈(), P_0.Settings);
		}
	}

	[CompilerGenerated]
	private sealed class 놂
	{
		public Symbol 놇뇇;

		internal bool 녴(CustomSessionsAssignment P_0)
		{
			if (P_0.IsActive)
			{
				if (!(P_0.SymbolComplexId == 놇뇇.ComplexId))
				{
					if (string.IsNullOrEmpty(P_0.SymbolId))
					{
						ExchangeComplexIdentifier exchangeComplexId = P_0.ExchangeComplexId;
						ExchangeComplexIdentifier? obj = 놇뇇.Exchange?.ComplexId;
						if (exchangeComplexId == obj)
						{
							goto IL_00ab;
						}
					}
					if (!string.IsNullOrEmpty(P_0.ExchangeId) || !(P_0.ConnectionId == 놇뇇.ConnectionId))
					{
						return string.IsNullOrEmpty(P_0.ConnectionId);
					}
				}
				goto IL_00ab;
			}
			return false;
			IL_00ab:
			return true;
		}
	}

	[CompilerGenerated]
	private EventHandler<CustomSessionEventArgs> 녶녦;

	private readonly IDictionary<string, CustomSessionsAssignment> 녶놀;

	private readonly 녴 녶놔;

	public IList<SettingItem> Settings
	{
		get
		{
			return this.Select((CustomSessionsAssignment P_0) => new SettingItemGroup(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸놈(), P_0.Settings)).Cast<SettingItem>().ToList();
		}
		set
		{
			foreach (SettingItem item in value)
			{
				if (item.Value is IList<SettingItem> settings)
				{
					CustomSessionsAssignment assignment = new CustomSessionsAssignment
					{
						Settings = settings
					};
					Add(assignment);
				}
			}
		}
	}

	public event EventHandler<CustomSessionEventArgs> Updated
	{
		[CompilerGenerated]
		add
		{
			EventHandler<CustomSessionEventArgs> eventHandler = 녶녦;
			EventHandler<CustomSessionEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<CustomSessionEventArgs> value2 = (EventHandler<CustomSessionEventArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref 녶녦, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<CustomSessionEventArgs> eventHandler = 녶녦;
			EventHandler<CustomSessionEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<CustomSessionEventArgs> value2 = (EventHandler<CustomSessionEventArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref 녶녦, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public CustomSessionsAssignmentManager()
	{
		녶놀 = new Dictionary<string, CustomSessionsAssignment>();
		녶놔 = new 녴();
	}

	public void Add(CustomSessionsAssignment assignment)
	{
		녶놀.Add(assignment.UniqueId, assignment);
		녴(assignment, EntityLifecycle.Created);
	}

	public void Edit(string assignmentId, CustomSessionsAssignment newAssignment)
	{
		if (녶놀.TryGetValue(assignmentId, out var value))
		{
			value.녴(newAssignment);
			녴(value, EntityLifecycle.Changed);
		}
	}

	public void Delete(string assignmentId)
	{
		if (녶놀.TryGetValue(assignmentId, out var value))
		{
			녶놀.Remove(assignmentId);
			녴(value, EntityLifecycle.Removed);
		}
	}

	public bool TryGetSessionsContainer(Symbol symbol, out CustomSessionsContainer container)
	{
		container = null;
		List<CustomSessionsAssignment> list = this.ToList();
		list.Sort(녶놔);
		container = list.FirstOrDefault(delegate(CustomSessionsAssignment P_0)
		{
			if (!P_0.IsActive)
			{
				return false;
			}
			if (!(P_0.SymbolComplexId == symbol.ComplexId))
			{
				if (string.IsNullOrEmpty(P_0.SymbolId))
				{
					ExchangeComplexIdentifier exchangeComplexId = P_0.ExchangeComplexId;
					ExchangeComplexIdentifier? obj = symbol.Exchange?.ComplexId;
					if (exchangeComplexId == obj)
					{
						goto IL_00ab;
					}
				}
				if (!string.IsNullOrEmpty(P_0.ExchangeId) || !(P_0.ConnectionId == symbol.ConnectionId))
				{
					return string.IsNullOrEmpty(P_0.ConnectionId);
				}
			}
			goto IL_00ab;
			IL_00ab:
			return true;
		})?.SessionsContainer;
		return container != null;
	}

	private void 녴(CustomSessionsAssignment P_0, EntityLifecycle P_1)
	{
		녶녦?.InvokeSafely(this, new CustomSessionEventArgs
		{
			Assignment = P_0,
			Lifecycle = P_1
		});
	}

	public IEnumerator<CustomSessionsAssignment> GetEnumerator()
	{
		return 녶놀.Values.GetEnumerator();
	}

	private IEnumerator 녴()
	{
		return GetEnumerator();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		//ILSpy generated this explicit interface implementation from .override directive in 녴
		return this.녴();
	}
}
