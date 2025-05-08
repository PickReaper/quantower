using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;

namespace TradingPlatform.BusinessLayer;

public sealed class CustomAccountPropertiesProvider : ICustomizable
{
	public const string CUSTOM_NAME = "CustomName";

	public const string LOCKED = "Locked";

	[CompilerGenerated]
	private Action 놫녹;

	private readonly ConcurrentDictionary<Account, Dictionary<string, object>> 놫녔;

	public IList<SettingItem> Settings
	{
		get
		{
			List<SettingItem> list = new List<SettingItem>();
			foreach (KeyValuePair<Account, Dictionary<string, object>> item2 in 놫녔)
			{
				List<SettingItem> list2 = new List<SettingItem>
				{
					new SettingItemAccount(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶녹(), item2.Key)
				};
				foreach (KeyValuePair<string, object> item3 in item2.Value)
				{
					list2.Add(녴(item3.Key, item3.Value));
				}
				SettingItemGroup item = new SettingItemGroup(string.Empty, list2);
				list.Add(item);
			}
			return list;
		}
		set
		{
			foreach (SettingItem item in value)
			{
				if (!(item is SettingItemGroup settingItemGroup))
				{
					continue;
				}
				Account account = null;
				Dictionary<string, object> dictionary = new Dictionary<string, object>();
				foreach (SettingItem item2 in settingItemGroup.Value as IList<SettingItem>)
				{
					if (item2.Name == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶녹())
					{
						account = item2.Value as Account;
					}
					else
					{
						dictionary[item2.Name] = item2.Value;
					}
				}
				if (account != null)
				{
					놫녔[account] = dictionary;
				}
			}
		}
	}

	public event Action ParametersChanged
	{
		[CompilerGenerated]
		add
		{
			Action action = 놫녹;
			Action action2;
			do
			{
				action2 = action;
				Action value2 = (Action)Delegate.Combine(action2, value);
				action = Interlocked.CompareExchange(ref 놫녹, value2, action2);
			}
			while ((object)action != action2);
		}
		[CompilerGenerated]
		remove
		{
			Action action = 놫녹;
			Action action2;
			do
			{
				action2 = action;
				Action value2 = (Action)Delegate.Remove(action2, value);
				action = Interlocked.CompareExchange(ref 놫녹, value2, action2);
			}
			while ((object)action != action2);
		}
	}

	public CustomAccountPropertiesProvider()
	{
		놫녔 = new ConcurrentDictionary<Account, Dictionary<string, object>>();
	}

	public void SetProperty(Account account, string name, object value)
	{
		if (놫녔.ContainsKey(account))
		{
			놫녔[account][name] = value;
		}
		else
		{
			놫녔[account] = new Dictionary<string, object> { { name, value } };
		}
		놫녹?.Invoke();
	}

	public object GetProperty(Account account, string name)
	{
		if (account == null)
		{
			return null;
		}
		if (놫녔.TryGetValue(account, out var value) && value.TryGetValue(name, out var value2))
		{
			return value2;
		}
		return null;
	}

	private SettingItem 녴(string P_0, object P_1)
	{
		if (!(P_1 is int))
		{
			if (!(P_1 is double))
			{
				if (!(P_1 is string))
				{
					if (P_1 is bool)
					{
						return new SettingItemBoolean(P_0, (bool)P_1);
					}
					throw new ArgumentException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶녔());
				}
				return new SettingItemString(P_0, (string)P_1);
			}
			return new SettingItemDouble(P_0, (double)P_1);
		}
		return new SettingItemInteger(P_0, (int)P_1);
	}
}
