using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using TradingPlatform.BusinessLayer.Utils;
using 녴;

namespace TradingPlatform.BusinessLayer;

public abstract class ExecutionEntity : IDisposable, ICustomizable
{
	[Serializable]
	[CompilerGenerated]
	private sealed class 녴
	{
		public static readonly 녴 뇅녾 = new 녴();

		public static Func<FieldInfo, bool> 뇅녬;

		public static Func<PropertyInfo, bool> 뇅녹;

		public static Func<FieldInfo, bool> 뇅녔;

		public static Func<PropertyInfo, bool> 뇅녠;

		public static Func<FieldInfo, bool> 뇅놠;

		public static Func<PropertyInfo, bool> 뇅놟;

		public static Func<FieldInfo, bool> 뇅녓;

		public static Func<PropertyInfo, bool> 뇅녛;

		internal bool 녴(FieldInfo P_0)
		{
			return Attribute.IsDefined(P_0, typeof(InputParameterAttribute));
		}

		internal bool 녴(PropertyInfo P_0)
		{
			return Attribute.IsDefined(P_0, typeof(InputParameterAttribute));
		}

		internal bool 놴(FieldInfo P_0)
		{
			if (녶농.IsAssignableFrom(P_0.FieldType))
			{
				return !Attribute.IsDefined(P_0, typeof(InputParameterAttribute));
			}
			return false;
		}

		internal bool 놴(PropertyInfo P_0)
		{
			if (녶농.IsAssignableFrom(P_0.PropertyType))
			{
				return !Attribute.IsDefined(P_0, typeof(InputParameterAttribute));
			}
			return false;
		}

		internal bool 놂(FieldInfo P_0)
		{
			return Attribute.IsDefined(P_0, typeof(InputParameterAttribute));
		}

		internal bool 놂(PropertyInfo P_0)
		{
			return Attribute.IsDefined(P_0, typeof(InputParameterAttribute));
		}

		internal bool 놎(FieldInfo P_0)
		{
			if (녶농.IsAssignableFrom(P_0.FieldType))
			{
				return !Attribute.IsDefined(P_0, typeof(InputParameterAttribute));
			}
			return false;
		}

		internal bool 놎(PropertyInfo P_0)
		{
			if (녶농.IsAssignableFrom(P_0.PropertyType))
			{
				return !Attribute.IsDefined(P_0, typeof(InputParameterAttribute));
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class 놴
	{
		public SettingItem 뇅녽;

		internal bool 녴(SettingItem P_0)
		{
			return P_0.Name == 뇅녽.Name;
		}
	}

	[CompilerGenerated]
	private sealed class 놂
	{
		public SettingItem 뇅놏;

		internal bool 녴(SettingItem P_0)
		{
			return P_0.Name == 뇅놏.Name;
		}
	}

	private static readonly Type 녶농;

	private static readonly Dictionary<Type, SettingItemType> 녶념;

	[CompilerGenerated]
	private string 녶녨;

	[CompilerGenerated]
	private string 녶녺;

	[CompilerGenerated]
	private ScriptKey 녶놣;

	[CompilerGenerated]
	private readonly Version 녶녮;

	[CompilerGenerated]
	private Action<ExecutionEntity> 녶뇆;

	private readonly Type 녶뇉;

	[CompilerGenerated]
	private bool 녶뇍;

	protected static Core Core => Core.Instance;

	public string Name
	{
		[CompilerGenerated]
		get
		{
			return 녶녨;
		}
		[CompilerGenerated]
		protected set
		{
			녶녨 = value;
		}
	}

	public string Description
	{
		[CompilerGenerated]
		get
		{
			return 녶녺;
		}
		[CompilerGenerated]
		protected set
		{
			녶녺 = value;
		}
	}

	public ScriptKey Key
	{
		[CompilerGenerated]
		get
		{
			return 녶놣;
		}
		[CompilerGenerated]
		internal set
		{
			녶놣 = value;
		}
	}

	public Version Version
	{
		[CompilerGenerated]
		get
		{
			return 녶녮;
		}
	}

	public virtual IList<SettingItem> Settings
	{
		get
		{
			List<SettingItem> list = new List<SettingItem>();
			SettingItemSeparatorGroup separatorGroup = new SettingItemSeparatorGroup(loc._(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭녜(), null, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭뇃()), -1000)
			{
				Key = _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭녯()
			};
			foreach (FieldInfo item in from P_0 in 녶뇉.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
				where Attribute.IsDefined(P_0, typeof(InputParameterAttribute))
				select P_0)
			{
				InputParameterAttribute customAttribute = item.GetCustomAttribute<InputParameterAttribute>(inherit: true);
				object value = item.GetValue(this);
				SettingItem 뇅녽 = 녴(customAttribute, item.FieldType, item.Name, value);
				if (뇅녽 != null)
				{
					if (list.Any((SettingItem P_0) => P_0.Name == 뇅녽.Name))
					{
						Core.Loggers.Log(Name + _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭놮() + 뇅녽.Name + _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭녫());
					}
					else
					{
						list.Add(뇅녽);
					}
				}
			}
			foreach (PropertyInfo item2 in from P_0 in 녶뇉.GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
				where Attribute.IsDefined(P_0, typeof(InputParameterAttribute))
				select P_0)
			{
				InputParameterAttribute customAttribute2 = item2.GetCustomAttribute<InputParameterAttribute>(inherit: true);
				object value2 = item2.GetValue(this);
				SettingItem 뇅놏 = 녴(customAttribute2, item2.PropertyType, item2.Name, value2);
				if (뇅놏 != null)
				{
					if (list.Any((SettingItem P_0) => P_0.Name == 뇅놏.Name))
					{
						Core.Loggers.Log(Name + _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭놮() + 뇅놏.Name + _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭녫());
					}
					else
					{
						list.Add(뇅놏);
					}
				}
			}
			foreach (FieldInfo item3 in from P_0 in 녶뇉.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
				where 녶농.IsAssignableFrom(P_0.FieldType) && !Attribute.IsDefined(P_0, typeof(InputParameterAttribute))
				select P_0)
			{
				if (item3.GetValue(this) is SettingItem settingItem)
				{
					list.Add(settingItem.GetCopy());
				}
			}
			foreach (PropertyInfo item4 in from P_0 in 녶뇉.GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
				where 녶농.IsAssignableFrom(P_0.PropertyType) && !Attribute.IsDefined(P_0, typeof(InputParameterAttribute))
				select P_0)
			{
				if (item4.GetValue(this) is SettingItem settingItem2)
				{
					list.Add(settingItem2.GetCopy());
				}
			}
			list.Add(new SettingItemString(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭뇁(), Key.ToString())
			{
				VisibilityMode = VisibilityMode.Hidden
			});
			for (int i = 0; i < list.Count; i++)
			{
				list[i].SeparatorGroup = separatorGroup;
			}
			return list;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂논());
			}
			bool flag = false;
			Dictionary<string, FieldInfo> dictionary = null;
			Dictionary<string, PropertyInfo> dictionary2 = null;
			IEnumerable<FieldInfo> enumerable = from P_0 in 녶뇉.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
				where Attribute.IsDefined(P_0, typeof(InputParameterAttribute))
				select P_0;
			IEnumerable<PropertyInfo> enumerable2 = from P_0 in 녶뇉.GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
				where Attribute.IsDefined(P_0, typeof(InputParameterAttribute))
				select P_0;
			if (enumerable.Count() > 0)
			{
				dictionary = new Dictionary<string, FieldInfo>();
				foreach (FieldInfo item in enumerable)
				{
					InputParameterAttribute customAttribute = item.GetCustomAttribute<InputParameterAttribute>(inherit: true);
					string key = (string.IsNullOrEmpty(customAttribute.Name) ? item.Name : customAttribute.Name);
					dictionary.TryAdd(key, item);
				}
			}
			if (enumerable2.Count() > 0)
			{
				dictionary2 = new Dictionary<string, PropertyInfo>();
				foreach (PropertyInfo item2 in enumerable2)
				{
					InputParameterAttribute customAttribute2 = item2.GetCustomAttribute<InputParameterAttribute>(inherit: true);
					string key2 = (string.IsNullOrEmpty(customAttribute2.Name) ? item2.Name : customAttribute2.Name);
					dictionary2.TryAdd(key2, item2);
				}
			}
			foreach (SettingItem item3 in value)
			{
				object value2;
				if (item3.Type == SettingItemType.SelectorLocalized)
				{
					if (!(item3.Value is SelectItem selectItem))
					{
						continue;
					}
					value2 = selectItem.Value;
				}
				else
				{
					value2 = item3.Value;
				}
				FieldInfo value3 = null;
				if (dictionary != null && dictionary.TryGetValue(item3.Name, out value3))
				{
					value3.SetValue(this, value2);
					flag = true;
					continue;
				}
				PropertyInfo value4 = null;
				if (dictionary2 != null && dictionary2.TryGetValue(item3.Name, out value4))
				{
					value4.SetValue(this, value2);
					flag = true;
				}
			}
			foreach (FieldInfo item4 in from P_0 in 녶뇉.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
				where 녶농.IsAssignableFrom(P_0.FieldType) && !Attribute.IsDefined(P_0, typeof(InputParameterAttribute))
				select P_0)
			{
				if (item4.GetValue(this) is SettingItem settingItem)
				{
					flag |= settingItem.녴(value);
				}
			}
			foreach (PropertyInfo item5 in from P_0 in 녶뇉.GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
				where 녶농.IsAssignableFrom(P_0.PropertyType) && !Attribute.IsDefined(P_0, typeof(InputParameterAttribute))
				select P_0)
			{
				if (item5.GetValue(this) is SettingItem settingItem2)
				{
					flag |= settingItem2.녴(value);
				}
			}
			if (value.GetItemByName(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭뇁()) is SettingItemString settingItemString && !string.IsNullOrEmpty(settingItemString.Value as string))
			{
				Key = ScriptKey.CreateScriptKeyFromString(settingItemString.Value.ToString());
			}
			if (flag)
			{
				OnSettingsUpdated();
			}
		}
	}

	private protected bool Disposed
	{
		[CompilerGenerated]
		get
		{
			return 녶뇍;
		}
		[CompilerGenerated]
		private set
		{
			녶뇍 = value;
		}
	}

	public event Action<ExecutionEntity> OnDispose
	{
		[CompilerGenerated]
		add
		{
			Action<ExecutionEntity> action = 녶뇆;
			Action<ExecutionEntity> action2;
			do
			{
				action2 = action;
				Action<ExecutionEntity> value2 = (Action<ExecutionEntity>)Delegate.Combine(action2, value);
				action = Interlocked.CompareExchange(ref 녶뇆, value2, action2);
			}
			while ((object)action != action2);
		}
		[CompilerGenerated]
		remove
		{
			Action<ExecutionEntity> action = 녶뇆;
			Action<ExecutionEntity> action2;
			do
			{
				action2 = action;
				Action<ExecutionEntity> value2 = (Action<ExecutionEntity>)Delegate.Remove(action2, value);
				action = Interlocked.CompareExchange(ref 녶뇆, value2, action2);
			}
			while ((object)action != action2);
		}
	}

	static ExecutionEntity()
	{
		녶농 = typeof(SettingItem);
		녶념 = new Dictionary<Type, SettingItemType>
		{
			{
				typeof(bool),
				SettingItemType.Boolean
			},
			{
				typeof(int),
				SettingItemType.Integer
			},
			{
				typeof(string),
				SettingItemType.String
			},
			{
				typeof(long),
				SettingItemType.Integer
			},
			{
				typeof(double),
				SettingItemType.Double
			},
			{
				typeof(decimal),
				SettingItemType.Double
			},
			{
				typeof(DateTime),
				SettingItemType.DateTime
			},
			{
				typeof(Period),
				SettingItemType.Period
			},
			{
				typeof(Account),
				SettingItemType.Account
			},
			{
				typeof(Symbol),
				SettingItemType.Symbol
			},
			{
				typeof(Color),
				SettingItemType.Color
			},
			{
				typeof(PairColor),
				SettingItemType.PairColor
			},
			{
				typeof(LineOptions),
				SettingItemType.LineOptions
			}
		};
	}

	protected ExecutionEntity()
	{
		녶뇉 = GetType();
		string text = 녶뇉.Assembly.놴();
		녶녮 = (string.IsNullOrEmpty(text) ? null : new Version(text));
	}

	public virtual void Dispose()
	{
		Disposed = true;
		녶뇆?.Invoke(this);
	}

	protected virtual void OnSettingsUpdated()
	{
	}

	protected void CheckDisposed()
	{
		if (Disposed)
		{
			throw new ObjectDisposedException(Name);
		}
	}

	private static SettingItem 녴(InputParameterAttribute P_0, Type P_1, string P_2, object P_3)
	{
		string name = (string.IsNullOrEmpty(P_0.Name) ? P_2 : P_0.Name);
		int sortIndex = P_0.SortIndex;
		double minimum = P_0.Minimum;
		double maximum = P_0.Maximum;
		double increment = P_0.Increment;
		int decimalPlaces = P_0.DecimalPlaces;
		SettingItem result = null;
		SettingItemType value2;
		if (P_0.Variants != null)
		{
			if (P_0.Variants.Length % 2 != 0)
			{
				throw new ArgumentException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭놧());
			}
			IComparable comparable = P_3 as IComparable;
			if (comparable == null)
			{
				throw new ArgumentException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭녝());
			}
			List<SelectItem> list = new List<SelectItem>();
			SelectItem value = null;
			for (int i = 0; i < P_0.Variants.Length; i += 2)
			{
				IComparable comparable2 = P_0.Variants[i + 1];
				if (comparable2 == null)
				{
					throw new ArgumentException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭뇈());
				}
				if (comparable2.GetType() != P_1)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(70, 2);
					defaultInterpolatedStringHandler.AppendFormatted(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭놑());
					defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭놦());
					defaultInterpolatedStringHandler.AppendFormatted(P_1);
					throw new ArgumentException(defaultInterpolatedStringHandler.ToStringAndClear());
				}
				if (comparable2 is Enum)
				{
					comparable2 = (int)(object)comparable2;
					comparable = (int)(object)comparable;
				}
				SelectItem selectItem = new SelectItem(P_0.Variants[i].ToString(), comparable2);
				list.Add(selectItem);
				if (comparable2.CompareTo(comparable) == 0)
				{
					value = selectItem;
				}
			}
			result = new SettingItemSelectorLocalized(name, value, list, sortIndex);
		}
		else if (녶념.TryGetValue(P_1, out value2))
		{
			SettingItem settingItem;
			switch (value2)
			{
			case SettingItemType.Boolean:
				settingItem = new SettingItemBoolean(name, P_3 != null && (bool)P_3, sortIndex);
				break;
			case SettingItemType.Integer:
				settingItem = new SettingItemInteger(name, (P_3 != null) ? ((int)P_3) : 0, sortIndex)
				{
					Minimum = (int)minimum,
					Maximum = (int)maximum,
					Increment = Math.Max((int)increment, 1)
				};
				break;
			case SettingItemType.String:
				settingItem = new SettingItemString(name, (P_3 == null) ? null : ((string)P_3), sortIndex);
				break;
			case SettingItemType.Double:
				settingItem = new SettingItemDouble(name, (P_3 == null) ? 0.0 : ((double)P_3), sortIndex)
				{
					Minimum = minimum,
					Maximum = maximum,
					Increment = increment,
					DecimalPlaces = decimalPlaces
				};
				break;
			case SettingItemType.DateTime:
				settingItem = new SettingItemDateTime(name, (P_3 == null) ? default(DateTime) : ((DateTime)P_3), sortIndex);
				break;
			case SettingItemType.Period:
				settingItem = new SettingItemPeriod(name, (P_3 == null) ? default(Period) : ((Period)P_3), sortIndex);
				break;
			case SettingItemType.Account:
				settingItem = new SettingItemAccount(name, (P_3 == null) ? null : ((Account)P_3), sortIndex);
				break;
			case SettingItemType.Symbol:
				settingItem = new SettingItemSymbol(name, (P_3 == null) ? null : ((Symbol)P_3), sortIndex);
				break;
			case SettingItemType.Color:
				settingItem = new SettingItemColor(name, (P_3 == null) ? default(Color) : ((Color)P_3), sortIndex);
				break;
			case SettingItemType.PairColor:
				settingItem = new SettingItemPairColor(name, (P_3 == null) ? null : ((PairColor)P_3), sortIndex);
				break;
			case SettingItemType.LineOptions:
				settingItem = new SettingItemLineOptions(name, (P_3 == null) ? null : ((LineOptions)P_3), sortIndex);
				break;
			default:
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(37, 1);
				defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭놐());
				defaultInterpolatedStringHandler.AppendFormatted(P_3.GetType());
				defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놢());
				throw new ArgumentException(defaultInterpolatedStringHandler.ToStringAndClear());
			}
			}
			result = settingItem;
		}
		return result;
	}
}
