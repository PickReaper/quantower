using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace TradingPlatform.BusinessLayer;

public class SettingItemMultipleRelation : SettingItemRelation
{
	[Serializable]
	[CompilerGenerated]
	private new sealed class 녴
	{
		public static readonly 녴 놵놺 = new 녴();

		public static Func<SettingItemRelation, IEnumerable<KeyValuePair<string, IEnumerable<object>>>> 놵놅;

		public static Func<KeyValuePair<string, IEnumerable<object>>, string> 놵녜;

		public static Func<KeyValuePair<string, IEnumerable<object>>, IEnumerable<object>> 놵뇃;

		internal IEnumerable<KeyValuePair<string, IEnumerable<object>>> 녴(SettingItemRelation P_0)
		{
			return P_0.놴놷;
		}

		internal string 녴(KeyValuePair<string, IEnumerable<object>> P_0)
		{
			return P_0.Key;
		}

		internal IEnumerable<object> 놴(KeyValuePair<string, IEnumerable<object>> P_0)
		{
			return P_0.Value;
		}
	}

	private readonly List<SettingItemRelation> 녵놛;

	public SettingItemMultipleRelation(params SettingItemRelation[] relations)
		: base(relations.SelectMany((SettingItemRelation P_0) => P_0.놴놷).ToDictionary((KeyValuePair<string, IEnumerable<object>> P_0) => P_0.Key, (KeyValuePair<string, IEnumerable<object>> P_0) => P_0.Value))
	{
		녵놛 = relations.ToList();
	}

	public void AddRelation(SettingItemRelation relation)
	{
		foreach (KeyValuePair<string, IEnumerable<object>> item in relation.놴놷)
		{
			놴놷.Add(item.Key, item.Value);
		}
		녵놛.Add(relation);
	}

	public void InsertRelation(int index, SettingItemRelation relation)
	{
		foreach (KeyValuePair<string, IEnumerable<object>> item in relation.놴놷)
		{
			놴놷.Add(item.Key, item.Value);
		}
		녵놛.Insert(0, relation);
	}

	public override bool CheckRelation(SettingItem dependentItem, SettingItem changedItem, bool isPopulating, params SettingItem[] parentItems)
	{
		bool flag = false;
		foreach (SettingItemRelation item in 녵놛)
		{
			flag = ((base.MultipleRelationCondition != MultipleRelationCondition.IfAll) ? (flag | item.CheckRelation(dependentItem, changedItem, isPopulating, parentItems)) : (flag & item.CheckRelation(dependentItem, changedItem, isPopulating, parentItems)));
		}
		return flag;
	}
}
