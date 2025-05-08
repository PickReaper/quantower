using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;

namespace TradingPlatform.BusinessLayer;

public class SettingItemRelation
{
	[Serializable]
	[CompilerGenerated]
	private sealed class 녴
	{
		public static readonly 녴 녵놼 = new 녴();

		public static Func<KeyValuePair<SettingItem, IEnumerable<object>>, bool> 녵놗;

		internal bool 녴(KeyValuePair<SettingItem, IEnumerable<object>> P_0)
		{
			놴 CS_0024_003C_003E8__locals2 = new 놴
			{
				녵뇂 = P_0.Key
			};
			IEnumerable<object> value = P_0.Value;
			if (!CS_0024_003C_003E8__locals2.녵뇂.Visible)
			{
				return false;
			}
			return value.Any((object P_0) => P_0 != null && SettingItemRelation.녴(P_0, CS_0024_003C_003E8__locals2.녵뇂.Value));
		}
	}

	[CompilerGenerated]
	private sealed class 놴
	{
		public SettingItem 녵뇂;

		internal bool 녴(object P_0)
		{
			if (P_0 != null)
			{
				return SettingItemRelation.녴(P_0, 녵뇂.Value);
			}
			return false;
		}
	}

	[CompilerGenerated]
	private MultipleRelationCondition 놴뇎;

	internal readonly IDictionary<string, IEnumerable<object>> 놴놷;

	protected SettingItemRelationDelegate RelationDelegate;

	public string[] ParentSettingsNames => 놴놷.Keys.ToArray();

	public MultipleRelationCondition MultipleRelationCondition
	{
		[CompilerGenerated]
		get
		{
			return 놴뇎;
		}
		[CompilerGenerated]
		set
		{
			놴뇎 = value;
		}
	}

	public SettingItemRelation(IDictionary<string, IEnumerable<object>> relationValuesByParentItemName, SettingItemRelationDelegate relationDelegate = null)
	{
		if (relationValuesByParentItemName.Keys.Count == 0)
		{
			throw new ArgumentException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴녚());
		}
		RelationDelegate = relationDelegate;
		놴놷 = relationValuesByParentItemName;
		MultipleRelationCondition = MultipleRelationCondition.IfAny;
	}

	public virtual bool CheckRelation(SettingItem dependentItem, SettingItem changedItem, bool isPopulating, params SettingItem[] parentItems)
	{
		if (dependentItem == null)
		{
			throw new ArgumentNullException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴녳());
		}
		if (parentItems.Length == 0)
		{
			throw new AggregateException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴놉());
		}
		SettingItemRelationParameters settingItemRelationParameters = new SettingItemRelationParameters
		{
			DependentItem = dependentItem,
			ChangedItem = changedItem,
			RelationValuesByParentItem = new Dictionary<SettingItem, IEnumerable<object>>(),
			MultipleRelationCondition = MultipleRelationCondition,
			IsPopulating = isPopulating
		};
		foreach (SettingItem settingItem in parentItems)
		{
			if (놴놷.TryGetValue(settingItem.Name, out var value) && !settingItemRelationParameters.RelationValuesByParentItem.ContainsKey(settingItem))
			{
				settingItemRelationParameters.RelationValuesByParentItem.Add(settingItem, value);
			}
		}
		return RelationDelegate(settingItemRelationParameters);
	}

	protected static bool CheckEnabilityRelation(SettingItemRelationParameters relationParameters)
	{
		SettingItem dependentItem = relationParameters.DependentItem;
		bool flag = CheckValues(relationParameters.RelationValuesByParentItem, relationParameters.MultipleRelationCondition);
		bool result = dependentItem.Enabled != flag;
		dependentItem.Enabled = flag;
		return result;
	}

	protected static bool CheckVisibilityRelation(SettingItemRelationParameters relationParameters)
	{
		SettingItem dependentItem = relationParameters.DependentItem;
		bool flag = CheckValues(relationParameters.RelationValuesByParentItem, relationParameters.MultipleRelationCondition);
		bool result = dependentItem.Visible != flag;
		dependentItem.Visible = flag;
		return result;
	}

	protected static bool CheckValues(IDictionary<SettingItem, IEnumerable<object>> relationValuesByParentItem, MultipleRelationCondition condition)
	{
		Func<KeyValuePair<SettingItem, IEnumerable<object>>, bool> predicate = delegate(KeyValuePair<SettingItem, IEnumerable<object>> P_0)
		{
			SettingItem 녵뇂 = P_0.Key;
			IEnumerable<object> value = P_0.Value;
			return 녵뇂.Visible && value.Any((object P_0) => P_0 != null && 녴(P_0, 녵뇂.Value));
		};
		if (condition == MultipleRelationCondition.IfAny)
		{
			return relationValuesByParentItem.Any(predicate);
		}
		return relationValuesByParentItem.All(predicate);
	}

	[CompilerGenerated]
	internal static bool 녴(object P_0, object P_1)
	{
		if (P_0.Equals(P_1) || P_0 == P_1)
		{
			return true;
		}
		if (P_1 is SelectItem selectItem)
		{
			return 녴(P_0, selectItem.Value);
		}
		return false;
	}
}
