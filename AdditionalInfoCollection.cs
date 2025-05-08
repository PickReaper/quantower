using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using TradingPlatform.BusinessLayer.Utils.EqualityComparers;

namespace TradingPlatform.BusinessLayer;

/// <summary>
/// The additional info collection.
/// </summary>
public class AdditionalInfoCollection : IEnumerable<AdditionalInfoItem>, IEnumerable, IEquatable<AdditionalInfoCollection>
{
	[CompilerGenerated]
	private sealed class 녴 : IEnumerable<AdditionalInfoItem>, IEnumerable, IEnumerator<AdditionalInfoItem>, IEnumerator, IDisposable
	{
		private int 녞놝;

		private AdditionalInfoItem 녞뇄;

		private int 녞녑;

		public AdditionalInfoCollection 녞놈;

		private object 녞놬;

		private bool 녞놊;

		private Dictionary<string, AdditionalInfoItem>.Enumerator 녞놪;

		AdditionalInfoItem IEnumerator<AdditionalInfoItem>.Current
		{
			[DebuggerHidden]
			get
			{
				return 녞뇄;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return 녞뇄;
			}
		}

		[DebuggerHidden]
		public 녴(int P_0)
		{
			녞놝 = P_0;
			녞녑 = Environment.CurrentManagedThreadId;
		}

		[DebuggerHidden]
		private void 녴()
		{
			int num = 녞놝;
			if ((uint)(num - -4) <= 1u || num == 1)
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
			녞놬 = null;
			녞놪 = default(Dictionary<string, AdditionalInfoItem>.Enumerator);
			녞놝 = -2;
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
				int num = 녞놝;
				AdditionalInfoCollection additionalInfoCollection = 녞놈;
				switch (num)
				{
				default:
					return false;
				case 0:
					녞놝 = -1;
					녞놬 = additionalInfoCollection.녞;
					녞놊 = false;
					녞놝 = -3;
					Monitor.Enter(녞놬, ref 녞놊);
					녞놪 = additionalInfoCollection.놎.GetEnumerator();
					녞놝 = -4;
					break;
				case 1:
					녞놝 = -4;
					break;
				}
				if (녞놪.MoveNext())
				{
					녞뇄 = 녞놪.Current.Value.Clone() as AdditionalInfoItem;
					녞놝 = 1;
					return true;
				}
				놂();
				녞놪 = default(Dictionary<string, AdditionalInfoItem>.Enumerator);
				놴();
				녞놬 = null;
				return false;
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
			녞놝 = -1;
			if (녞놊)
			{
				Monitor.Exit(녞놬);
			}
		}

		private void 놂()
		{
			녞놝 = -3;
			((IDisposable)녞놪/*cast due to .constrained prefix*/).Dispose();
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
		private IEnumerator<AdditionalInfoItem> 녞()
		{
			녴 result;
			if (녞놝 == -2 && 녞녑 == Environment.CurrentManagedThreadId)
			{
				녞놝 = 0;
				result = this;
			}
			else
			{
				result = new 녴(0)
				{
					녞놈 = 녞놈
				};
			}
			return result;
		}

		IEnumerator<AdditionalInfoItem> IEnumerable<AdditionalInfoItem>.GetEnumerator()
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

	private readonly Dictionary<string, AdditionalInfoItem> 놎;

	private readonly object 녞;

	private static readonly ListEqualityComparer<AdditionalInfoItem> 놫;

	/// <summary>
	/// Gets the count.
	/// </summary>
	public int Count => 놎.Count;

	public AdditionalInfoItem this[string key]
	{
		get
		{
			if (TryGetItem(key, out var item))
			{
				return item;
			}
			throw new KeyNotFoundException();
		}
	}

	/// <summary>
	/// Gets the items.
	/// </summary>
	public IEnumerable<AdditionalInfoItem> Items
	{
		[IteratorStateMachine(typeof(녴))]
		get
		{
			//yield-return decompiler failed: Unexpected instruction in Iterator.Dispose()
			return new 녴(-2)
			{
				녞놈 = this
			};
		}
	}

	static AdditionalInfoCollection()
	{
		놫 = new ListEqualityComparer<AdditionalInfoItem>(EqualityComparer<AdditionalInfoItem>.Default);
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="T:TradingPlatform.BusinessLayer.AdditionalInfoCollection" /> class.
	/// </summary>
	public AdditionalInfoCollection()
	{
		놎 = new Dictionary<string, AdditionalInfoItem>();
		녞 = new object();
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="T:TradingPlatform.BusinessLayer.AdditionalInfoCollection" /> class.
	/// </summary>
	/// <param name="items">The items.</param>
	public AdditionalInfoCollection(params AdditionalInfoItem[] items)
		: this()
	{
		foreach (AdditionalInfoItem additionalInfoItem in items)
		{
			녴(additionalInfoItem);
		}
	}

	/// <summary>
	/// Try get item.
	/// </summary>
	/// <param name="apiKey">The api key.</param>
	/// <param name="item">The item.</param>
	/// <returns>A bool.</returns>
	public bool TryGetItem(string apiKey, out AdditionalInfoItem item)
	{
		item = null;
		lock (녞)
		{
			if (놎.TryGetValue(apiKey, out var value))
			{
				item = value.Clone() as AdditionalInfoItem;
				return true;
			}
		}
		return false;
	}

	internal void 녴(AdditionalInfoItem P_0)
	{
		lock (녞)
		{
			if (!놎.TryGetValue(P_0.Id, out var value))
			{
				value = new AdditionalInfoItem();
				놎.Add(P_0.Id, value);
			}
			value.Update(P_0);
		}
	}

	internal void 녴(IEnumerable<SettingItem> P_0)
	{
		lock (녞)
		{
			foreach (SettingItem item in P_0)
			{
				if (놎.TryGetValue(item.Name, out var value))
				{
					value.Value = item.Value;
				}
			}
		}
	}

	/// <summary>
	/// Gets the enumerator.
	/// </summary>
	/// <returns><![CDATA[IEnumerator<AdditionalInfoItem>]]></returns>
	public IEnumerator<AdditionalInfoItem> GetEnumerator()
	{
		return Items.GetEnumerator();
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

	/// <summary>
	/// Tos the string.
	/// </summary>
	/// <returns>A string.</returns>
	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		using (IEnumerator<AdditionalInfoItem> enumerator = GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				AdditionalInfoItem current = enumerator.Current;
				if (current.Hidden || !current.Visible)
				{
					continue;
				}
				string value = ((current.FormattingDescription == null) ? current.Value.ToString() : current.FormattingDescription.GetFormattedData());
				if (string.IsNullOrEmpty(current.NameKey) && string.IsNullOrEmpty(value))
				{
					continue;
				}
				if (string.IsNullOrEmpty(current.NameKey))
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder3 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(2, 1, stringBuilder2);
					handler.AppendFormatted(value);
					handler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴());
					stringBuilder3.Append(ref handler);
					continue;
				}
				object value2 = current.Value;
				if (value2 is bool)
				{
					if ((bool)value2)
					{
						StringBuilder stringBuilder2 = stringBuilder;
						StringBuilder stringBuilder4 = stringBuilder2;
						StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(2, 1, stringBuilder2);
						handler.AppendFormatted(current.NameKey);
						handler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴());
						stringBuilder4.Append(ref handler);
					}
				}
				else
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder5 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(5, 2, stringBuilder2);
					handler.AppendFormatted(current.NameKey);
					handler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂());
					handler.AppendFormatted(value);
					handler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴());
					stringBuilder5.Append(ref handler);
				}
			}
		}
		return stringBuilder.ToString().TrimEnd(' ', ';');
	}

	public bool Equals(AdditionalInfoCollection other)
	{
		List<AdditionalInfoItem> x = Items.ToList();
		List<AdditionalInfoItem> y = other.Items.ToList();
		return 놫.Equals(x, y);
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
		return Equals((AdditionalInfoCollection)obj);
	}

	public override int GetHashCode()
	{
		return 놫.GetHashCode(Items.ToList());
	}
}
