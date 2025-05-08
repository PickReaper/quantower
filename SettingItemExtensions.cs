using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;

namespace TradingPlatform.BusinessLayer;

public static class SettingItemExtensions
{
	[Serializable]
	[CompilerGenerated]
	private sealed class 녴
	{
		public static readonly 녴 놭녓 = new 녴();

		public static Func<SettingItem, string> 놭녛;

		public static Func<SettingItem, string> 놭녽;

		public static Func<SettingItem, SettingItem> 놭놏;

		public static Func<AdditionalInfoItem, string> 놭녥;

		public static Func<AdditionalInfoItem, object> 놭농;

		public static Func<SettingItem, SettingItem> 놭념;

		internal string 녴(SettingItem P_0)
		{
			return P_0.Name;
		}

		internal string 놴(SettingItem P_0)
		{
			return P_0.Name;
		}

		internal SettingItem 놂(SettingItem P_0)
		{
			return P_0;
		}

		internal string 녴(AdditionalInfoItem P_0)
		{
			return P_0.Id;
		}

		internal object 놴(AdditionalInfoItem P_0)
		{
			return P_0.Value;
		}

		internal SettingItem 놎(SettingItem P_0)
		{
			return P_0.GetCopy();
		}
	}

	[CompilerGenerated]
	private sealed class 놴
	{
		public SettingItem 놭녨;

		public object 놭녺;

		internal void 녴()
		{
			놭녨.Value = 놭녺;
		}
	}

	[CompilerGenerated]
	private sealed class 놂 : IEnumerable<SettingItem>, IEnumerable, IEnumerator<SettingItem>, IEnumerator, IDisposable
	{
		private int 놭놣;

		private SettingItem 놭녮;

		private int 놭뇆;

		private IEnumerable<SettingItem> 놭뇉;

		public IEnumerable<SettingItem> 놭뇍;

		private IEnumerator<SettingItem> 놭놙;

		private IEnumerator<SettingItem> 놭녰;

		SettingItem IEnumerator<SettingItem>.Current
		{
			[DebuggerHidden]
			get
			{
				return 놭녮;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return 놭녮;
			}
		}

		[DebuggerHidden]
		public 놂(int P_0)
		{
			놭놣 = P_0;
			놭뇆 = Environment.CurrentManagedThreadId;
		}

		[DebuggerHidden]
		private void 녴()
		{
			int num = 놭놣;
			if ((uint)(num - -4) <= 1u || (uint)(num - 1) <= 1u)
			{
				try
				{
					if (num == -4 || num == 1)
					{
						try
						{
						}
						finally
						{
							놂();
						}
					}
				}
				finally
				{
					놴();
				}
			}
			놭놙 = null;
			놭녰 = null;
			놭놣 = -2;
		}

		void IDisposable.Dispose()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 녴
			this.녴();
		}

		private bool MoveNext()
		{
			try
			{
				switch (놭놣)
				{
				default:
					return false;
				case 0:
					놭놣 = -1;
					if (놭뇉 == null)
					{
						return false;
					}
					놭놙 = 놭뇉.GetEnumerator();
					놭놣 = -3;
					goto IL_00e8;
				case 1:
					놭놣 = -4;
					goto IL_00b2;
				case 2:
					{
						놭놣 = -3;
						goto IL_00e8;
					}
					IL_00b2:
					if (놭녰.MoveNext())
					{
						SettingItem current = 놭녰.Current;
						놭녮 = current;
						놭놣 = 1;
						return true;
					}
					놂();
					놭녰 = null;
					goto IL_00e8;
					IL_00e8:
					if (놭놙.MoveNext())
					{
						SettingItem current2 = 놭놙.Current;
						if (current2.Value is IEnumerable<SettingItem> settings)
						{
							놭녰 = settings.ExpandGroups().GetEnumerator();
							놭놣 = -4;
							goto IL_00b2;
						}
						놭녮 = current2;
						놭놣 = 2;
						return true;
					}
					놴();
					놭놙 = null;
					return false;
				}
			}
			catch
			{
				//try-fault
				녴();
				throw;
			}
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void 놴()
		{
			놭놣 = -1;
			if (놭놙 != null)
			{
				놭놙.Dispose();
			}
		}

		private void 놂()
		{
			놭놣 = -3;
			if (놭녰 != null)
			{
				놭녰.Dispose();
			}
		}

		[DebuggerHidden]
		private void 놎()
		{
			throw new NotSupportedException();
		}

		void IEnumerator.Reset()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 놎
			this.놎();
		}

		[DebuggerHidden]
		private IEnumerator<SettingItem> 녞()
		{
			놂 놂;
			if (놭놣 == -2 && 놭뇆 == Environment.CurrentManagedThreadId)
			{
				놭놣 = 0;
				놂 = this;
			}
			else
			{
				놂 = new 놂(0);
			}
			놂.놭뇉 = 놭뇍;
			return 놂;
		}

		IEnumerator<SettingItem> IEnumerable<SettingItem>.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 녞
			return this.녞();
		}

		[DebuggerHidden]
		private IEnumerator 놫()
		{
			return 녞();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 놫
			return this.놫();
		}
	}

	public static SettingItem GetItemByName(this IEnumerable<SettingItem> list, string name)
	{
		if (string.IsNullOrEmpty(name))
		{
			return null;
		}
		foreach (SettingItem item in list)
		{
			if (item != null && item.Name == name)
			{
				return item;
			}
		}
		return null;
	}

	public static SettingItem GetItemByPath(this IEnumerable<SettingItem> list, params string[] pathLevels)
	{
		if (pathLevels == null)
		{
			throw new ArgumentNullException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놶());
		}
		IEnumerable<SettingItem> list2 = list;
		for (int i = 0; i < pathLevels.Length; i++)
		{
			string name = pathLevels[i];
			SettingItem itemByName = list2.GetItemByName(name);
			if (itemByName == null)
			{
				return null;
			}
			if (i == pathLevels.Length - 1)
			{
				return itemByName;
			}
			list2 = itemByName.Value as IList<SettingItem>;
		}
		return null;
	}

	/// <summary>
	/// Get all settings or particular settings by provided hierarchy path
	/// </summary>
	public static IEnumerable<SettingItem> GetItemsByPath(this IEnumerable<SettingItem> list, params string[] pathLevels)
	{
		if (pathLevels == null)
		{
			throw new ArgumentNullException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놶());
		}
		IEnumerable<SettingItem> enumerable = list;
		for (int i = 0; i < pathLevels.Length; i++)
		{
			string text = pathLevels[i];
			if (string.IsNullOrEmpty(text))
			{
				return enumerable;
			}
			SettingItem itemByName = enumerable.GetItemByName(text);
			if (itemByName == null)
			{
				return null;
			}
			if (itemByName.Value is IList<SettingItem> list2)
			{
				enumerable = list2;
			}
			else if (i == pathLevels.Length - 1)
			{
				return new List<SettingItem> { itemByName };
			}
		}
		return enumerable;
	}

	public static bool TryGetItemByName(this IEnumerable<SettingItem> items, string name, out SettingItem item)
	{
		item = items?.GetItemByName(name);
		return item != null;
	}

	public static void ApplyVisualGroup(this IEnumerable<SettingItem> list, SettingItemVisualGroup visualGroup, params string[] pathLevels)
	{
		if (pathLevels == null)
		{
			throw new ArgumentNullException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놶());
		}
		IEnumerable<SettingItem> itemsByPath = list.GetItemsByPath(pathLevels);
		if (itemsByPath == null)
		{
			return;
		}
		foreach (SettingItem item in itemsByPath)
		{
			if (item.Type == SettingItemType.Group && item.Value is IEnumerable<SettingItem> list2)
			{
				list2.ApplyVisualGroup(visualGroup);
			}
			else
			{
				item.VisualGroup = visualGroup;
			}
		}
	}

	public static SettingItem UpdateItemValue(this IEnumerable<SettingItem> list, string name, object newValue, bool force = false)
	{
		SettingItem itemByName = list.GetItemByName(name);
		if (itemByName == null)
		{
			return null;
		}
		if (itemByName is SettingItemGroup && itemByName.Value is IList<SettingItem> list2 && newValue is IList<SettingItem> list3)
		{
			foreach (SettingItem item in list3)
			{
				list2.UpdateItemValue(item.Name, item.Value);
			}
		}
		else
		{
			itemByName.녴(newValue, force);
		}
		return itemByName;
	}

	public static void UpdateValues(this IEnumerable<SettingItem> list, IEnumerable<SettingItem> other, bool ignoreValidation = false, params string[] filterNames)
	{
		if (list == null || other == null)
		{
			return;
		}
		Dictionary<string, SettingItem> dictionary = other.DistinctBy((SettingItem P_0) => P_0.Name).ToDictionary((SettingItem P_0) => P_0.Name, (SettingItem P_0) => P_0);
		foreach (SettingItem item in list)
		{
			if ((filterNames.Any() && !filterNames.Contains(item.Name)) || !dictionary.TryGetValue(item.Name, out var value))
			{
				continue;
			}
			if (item.Value is IList<SettingItem> list2 && value.Value is IList<SettingItem> other2)
			{
				list2.UpdateValues(other2, ignoreValidation);
				continue;
			}
			try
			{
				item.녴(value.Value, ignoreValidation);
			}
			catch (Exception ex)
			{
				Core.Instance.Loggers.Log(ex);
			}
		}
	}

	public static void UpdateValues(this IEnumerable<SettingItem> list, AdditionalInfoCollection additionalInfoCollection)
	{
		if (additionalInfoCollection == null)
		{
			return;
		}
		Dictionary<string, object> dictionary = additionalInfoCollection.ToDictionary((AdditionalInfoItem P_0) => P_0.Id, (AdditionalInfoItem P_0) => P_0.Value);
		foreach (SettingItem item in list)
		{
			try
			{
				if (dictionary.TryGetValue(item.Name, out var value))
				{
					item.녴(value);
				}
			}
			catch (Exception ex)
			{
				Core.Instance.Loggers.Log(ex);
			}
		}
	}

	public static bool IsAny(this IEnumerable<SettingItem> list, Predicate<SettingItem> predicate)
	{
		foreach (SettingItem item in list)
		{
			if (predicate(item))
			{
				return true;
			}
			if (item.Value is IList<SettingItem> list2 && list2.IsAny(predicate))
			{
				return true;
			}
		}
		return false;
	}

	public static T GetValueOrDefault<T>(this IEnumerable<SettingItem> settings, T defaultValue, params string[] pathLevels)
	{
		SettingItem itemByPath = settings.GetItemByPath(pathLevels);
		if (itemByPath == null)
		{
			return defaultValue;
		}
		return itemByPath.GetValue<T>();
	}

	public static T GetVisibleValueOrDefault<T>(this IEnumerable<SettingItem> settings, T defaultValue, params string[] pathLevels)
	{
		SettingItem itemByPath = settings.GetItemByPath(pathLevels);
		if (itemByPath == null || !itemByPath.Enabled || !itemByPath.Visible)
		{
			return defaultValue;
		}
		return itemByPath.GetValue<T>();
	}

	public static T GetValue<T>(this IEnumerable<SettingItem> settings, params string[] pathLevels)
	{
		SettingItem itemByPath = settings.GetItemByPath(pathLevels);
		if (itemByPath == null)
		{
			return default(T);
		}
		return itemByPath.GetValue<T>();
	}

	public static T GetVisibleValue<T>(this IEnumerable<SettingItem> settings, params string[] pathLevels)
	{
		SettingItem itemByPath = settings.GetItemByPath(pathLevels);
		if (itemByPath == null || !itemByPath.Enabled || !itemByPath.Visible)
		{
			return default(T);
		}
		return itemByPath.GetValue<T>();
	}

	public static T GetValue<T>(this SettingItem item)
	{
		try
		{
			object value = item.Value;
			return (!(value is SelectItem selectItem)) ? ((!(value is PasswordHolder passwordHolder)) ? ((T)item.Value) : ((T)(object)passwordHolder.Password)) : ((!(typeof(T) == typeof(string))) ? ((T)selectItem.Value) : ((T)(object)selectItem.Value?.ToString()));
		}
		catch
		{
			return default(T);
		}
	}

	public static bool TryGetValue<T>(this IEnumerable<SettingItem> settings, string name, out T value)
	{
		value = default(T);
		SettingItem itemByName = settings.GetItemByName(name);
		if (itemByName == null)
		{
			return false;
		}
		value = itemByName.GetValue<T>();
		return true;
	}

	public static bool TryGetVisibleValue<T>(this IEnumerable<SettingItem> settings, string name, out T value)
	{
		value = default(T);
		SettingItem itemByName = settings.GetItemByName(name);
		if (itemByName == null || !itemByName.Enabled || !itemByName.Visible)
		{
			return false;
		}
		value = itemByName.GetValue<T>();
		return true;
	}

	[IteratorStateMachine(typeof(놂))]
	public static IEnumerable<SettingItem> ExpandGroups(this IEnumerable<SettingItem> settings)
	{
		//yield-return decompiler failed: Unexpected instruction in Iterator.Dispose()
		return new 놂(-2)
		{
			놭뇍 = settings
		};
	}

	public static SettingItem RestoreGroupsNesting(this SettingItem settingItem)
	{
		List<SettingItemList> list = new List<SettingItemList>();
		녴(settingItem, list);
		if (list.Count > 0)
		{
			(list[0].Value as IList<SettingItem>).Add(settingItem);
			for (int i = 0; i < list.Count - 1; i++)
			{
				(list[i + 1].Value as IList<SettingItem>).Add(list[i]);
			}
			return list.Last();
		}
		return settingItem;
	}

	public static void MergeWith(this IList<SettingItem> origin, IList<SettingItem> other)
	{
		if (other == null)
		{
			return;
		}
		foreach (SettingItem item in other)
		{
			SettingItem itemByName = origin.GetItemByName(item.Name);
			if (itemByName == null)
			{
				origin.Add(item);
			}
			else if ((itemByName as SettingItemGroup)?.Value is IList<SettingItem> origin2 && (item as SettingItemGroup)?.Value is IList<SettingItem> other2)
			{
				origin2.MergeWith(other2);
			}
			else
			{
				itemByName.녴(item);
			}
		}
	}

	public static IEnumerable<SettingItem> DeepCopy(this IEnumerable<SettingItem> settings)
	{
		return settings.Select((SettingItem P_0) => P_0.GetCopy());
	}

	public static void SetValueWithReason(this SettingItem settingItem, object value, SettingItemValueChangingReason reason)
	{
		settingItem.InvokeActionWithReason(reason, delegate
		{
			settingItem.Value = value;
		});
	}

	public static void InvokeActionWithReason(this SettingItem settingItem, SettingItemValueChangingReason reason, Action action)
	{
		SettingItemValueChangingReason valueChangingReason = settingItem.ValueChangingReason;
		try
		{
			settingItem.ValueChangingReason = reason;
			action?.Invoke();
		}
		finally
		{
			settingItem.ValueChangingReason = valueChangingReason;
		}
	}

	[CompilerGenerated]
	internal static void 녴(SettingItem P_0, ICollection<SettingItemList> P_1)
	{
		if (P_0.Type == SettingItemType.Group)
		{
			SettingItemGroup item = new SettingItemGroup(P_0.Name, new List<SettingItem>());
			P_1.Add(item);
		}
		if (P_0.Group != null)
		{
			녴(P_0.Group, P_1);
		}
	}
}
