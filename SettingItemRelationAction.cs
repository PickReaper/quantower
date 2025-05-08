using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace TradingPlatform.BusinessLayer;

public class SettingItemRelationAction : SettingItemRelation
{
	[Serializable]
	[CompilerGenerated]
	private new sealed class 녴
	{
		public static readonly 녴 놵녯 = new 녴();

		public static Func<KeyValuePair<string, SettingItemRelationCallback>, string> 놵놮;

		public static Func<KeyValuePair<string, SettingItemRelationCallback>, IEnumerable<object>> 놵녫;

		internal string 녴(KeyValuePair<string, SettingItemRelationCallback> P_0)
		{
			return P_0.Key;
		}

		internal IEnumerable<object> 놴(KeyValuePair<string, SettingItemRelationCallback> P_0)
		{
			return Enumerable.Empty<object>();
		}
	}

	private readonly IDictionary<string, SettingItemRelationCallback> 녵놩;

	public SettingItemRelationAction(IDictionary<string, SettingItemRelationCallback> callbacks)
		: base(callbacks.ToDictionary((KeyValuePair<string, SettingItemRelationCallback> P_0) => P_0.Key, (KeyValuePair<string, SettingItemRelationCallback> P_0) => Enumerable.Empty<object>()))
	{
		녵놩 = callbacks;
		RelationDelegate = 녴;
	}

	private bool 녴(SettingItemRelationParameters P_0)
	{
		if (!녵놩.TryGetValue(P_0.ChangedItem.Name, out var value))
		{
			return false;
		}
		try
		{
			return value(P_0.ChangedItem, P_0.DependentItem);
		}
		catch (Exception ex)
		{
			Core.Instance.Loggers.Log(ex);
		}
		return false;
	}
}
