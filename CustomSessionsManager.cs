using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;

namespace TradingPlatform.BusinessLayer;

public class CustomSessionsManager : IEnumerable<CustomSessionsContainer>, IEnumerable, ICustomizable
{
	[Serializable]
	[CompilerGenerated]
	private sealed class 녴
	{
		public static readonly 녴 놇놽 = new 녴();

		public static Func<CustomSessionsContainer, SettingItemGroup> 놇녿;

		internal SettingItemGroup 녴(CustomSessionsContainer P_0)
		{
			return new SettingItemGroup(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸놪(), P_0.Settings);
		}
	}

	[CompilerGenerated]
	private readonly CustomSessionsAssignmentManager 녶녭;

	[CompilerGenerated]
	private EventHandler<CustomSessionEventArgs> 녶녱;

	private readonly IDictionary<string, CustomSessionsContainer> 녶놲;

	public CustomSessionsAssignmentManager Assignments
	{
		[CompilerGenerated]
		get
		{
			return 녶녭;
		}
	}

	public CustomSessionsContainer this[string id]
	{
		get
		{
			if (!string.IsNullOrEmpty(id) && 녶놲.TryGetValue(id, out var value))
			{
				return value;
			}
			return null;
		}
	}

	public IList<SettingItem> Settings
	{
		get
		{
			return new List<SettingItem>
			{
				new SettingItemGroup(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭놻(), this.Select((CustomSessionsContainer P_0) => new SettingItemGroup(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸놪(), P_0.Settings)).Cast<SettingItem>().ToList()),
				new SettingItemGroup(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭놃(), Assignments.Settings)
			};
		}
		set
		{
			if (value.TryGetValue<IList<SettingItem>>(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭놻(), out var value2))
			{
				녶놲.Clear();
				foreach (SettingItem item in value2)
				{
					if (item.Value is IList<SettingItem> settings)
					{
						CustomSessionsContainer customSessionsContainer = new CustomSessionsContainer
						{
							Settings = settings
						};
						녶놲.Add(customSessionsContainer.Id, customSessionsContainer);
					}
				}
			}
			if (value.TryGetValue<IList<SettingItem>>(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭놃(), out var value3))
			{
				Assignments.Settings = value3;
			}
		}
	}

	public event EventHandler<CustomSessionEventArgs> Updated
	{
		[CompilerGenerated]
		add
		{
			EventHandler<CustomSessionEventArgs> eventHandler = 녶녱;
			EventHandler<CustomSessionEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<CustomSessionEventArgs> value2 = (EventHandler<CustomSessionEventArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref 녶녱, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<CustomSessionEventArgs> eventHandler = 녶녱;
			EventHandler<CustomSessionEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<CustomSessionEventArgs> value2 = (EventHandler<CustomSessionEventArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref 녶녱, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	internal CustomSessionsManager()
	{
		녶녭 = new CustomSessionsAssignmentManager();
		녶놲 = new Dictionary<string, CustomSessionsContainer>();
	}

	public void Add(CustomSessionsContainer container)
	{
		녶놲.Add(container.Id, container);
		녴(container, EntityLifecycle.Created);
	}

	public void Edit(string containerId, CustomSessionsContainer newContainer)
	{
		if (녶놲.TryGetValue(containerId, out var value))
		{
			value.녴(newContainer);
			녴(value, EntityLifecycle.Changed);
		}
	}

	public void Delete(string containerId)
	{
		if (녶놲.TryGetValue(containerId, out var value))
		{
			녶놲.Remove(containerId);
			녴(value, EntityLifecycle.Removed);
		}
	}

	private void 녴(CustomSessionsContainer P_0, EntityLifecycle P_1)
	{
		녶녱?.InvokeSafely(this, new CustomSessionEventArgs
		{
			Container = P_0,
			Lifecycle = P_1
		});
	}

	public IEnumerator<CustomSessionsContainer> GetEnumerator()
	{
		return 녶놲.Values.GetEnumerator();
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
