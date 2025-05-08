using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace TradingPlatform.BusinessLayer;

public static class SelectItemExtensions
{
	[CompilerGenerated]
	private sealed class 녴<녴>
	{
		public 녴 놭놉;

		internal bool 녴(SelectItem P_0)
		{
			return P_0.Value.Equals(놭놉);
		}
	}

	public static SelectItem GetItemByValue<TValue>(this IEnumerable<SelectItem> list, TValue value)
	{
		return list.FirstOrDefault((SelectItem P_0) => P_0.Value.Equals(value));
	}
}
