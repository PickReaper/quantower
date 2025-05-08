using System;
using System.Collections.Generic;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;

namespace TradingPlatform.BusinessLayer;

public static class ListExtensions
{
	public static void AddRange<T>(this IList<T> list, IEnumerable<T> items)
	{
		if (items == null)
		{
			throw new ArgumentNullException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놁());
		}
		foreach (T item in items)
		{
			list.Add(item);
		}
	}
}
