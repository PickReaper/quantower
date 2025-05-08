using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace TradingPlatform.BusinessLayer;

public class SettingItemRelationEnability : SettingItemRelation
{
	[CompilerGenerated]
	private new static class 녴
	{
		public static SettingItemRelationDelegate 놵뇁;
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class 놴
	{
		public static readonly 놴 놵놧 = new 놴();

		public static Func<string, string> 놵녝;

		internal string 녴(string P_0)
		{
			return P_0;
		}
	}

	[CompilerGenerated]
	private sealed class 놂
	{
		public object 놵뇈;

		internal IEnumerable<object> 녴(string P_0)
		{
			return new List<object> { 놵뇈 };
		}
	}

	public SettingItemRelationEnability(string parentSettingsName, params object[] relationValues)
		: base(new Dictionary<string, IEnumerable<object>> { 
		{
			parentSettingsName,
			new List<object>(relationValues)
		} }, SettingItemRelation.CheckEnabilityRelation)
	{
	}

	public SettingItemRelationEnability(string[] parentSettingsNames, object relationValue)
		: base(((IEnumerable<string>)parentSettingsNames).ToDictionary((Func<string, string>)((string P_0) => P_0), (Func<string, IEnumerable<object>>)((string P_0) => new List<object> { relationValue })), SettingItemRelation.CheckEnabilityRelation)
	{
	}

	public SettingItemRelationEnability(IDictionary<string, IEnumerable<object>> relationValuesByParentItemName)
		: base(relationValuesByParentItemName, SettingItemRelation.CheckEnabilityRelation)
	{
	}
}
