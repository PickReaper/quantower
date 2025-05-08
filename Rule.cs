using System;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using TradingPlatform.BusinessLayer.Integration;
using 녴;

namespace TradingPlatform.BusinessLayer;

public abstract class Rule
{
	public const string ALLOW_TRADING = "Allow trading";

	public const string ALLOW_SCREENER = "Allow screener";

	public const string ALLOW_CONTAINS_SCREENER_CONDITIONS = "Allow 'contains' screener conditions";

	public const string ALLOW_NEWS = "Allow news";

	public const string ALLOW_SL = "Allow SL";

	public const string ALLOW_TP = "Allow TP";

	public const string ALLOW_SL_TRAILING = "Allow SL Trailing";

	public const string ALLOW_TP_TRAILING = "Allow TP Trailing";

	public const string ALLOW_MULTI_SL_TP = "ALLOW_MULTI_SL_TP";

	public const string ALLOW_MODIFY_ORDER = "Allow modify order";

	public const string ALLOW_MODIFY_ORDER_TYPE = "Allow modify order type";

	public const string ALLOW_MODIFY_AMOUNT = "Allow modify amount";

	public const string ALLOW_MODIFY_PRICE = "Allow modify price";

	public const string ALLOW_MODIFY_TIF = "Allow modify tif";

	public const string ALLOW_CHANGE_TO_MARKET = "Allow change to market";

	public const string ALLOW_REVERSE_POSITION = "Allow reverse position";

	public const string ALLOW_REDUCE_ONLY = "Allow reduce-only";

	public const string ALLOW_EXPORT = "Allow export";

	public const string ALLOW_LINK_OCO = "Allow Link OCO";

	public const string ALLOW_NEW_OCO = "Allow New OCO";

	public const string ALLOW_GROUP_ORDERS = "Allow group orders";

	public const string ALLOW_PARTIAL_CLOSE_POSITION = "Allow partial close position";

	public const string DEFAULT_SHOW_STRIKES_COUNT = "DEFAULT_SHOW_STRIKES_COUNT";

	public const string LEVEL2_IS_AGGREGATED = "LEVEL2_IS_AGGREGATED";

	public const string LEVEL2_HAS_IMPLIED_SIZE = "LEVEL2_HAS_IMPLIED_SIZE";

	public const string PLACE_ORDER_TRADING_OPERATION_HAS_ORDER_ID = "PLACE_ORDER_TRADING_OPERATION_HAS_ORDER_ID";

	public const string ALLOW_VOLUME_ANALYSIS_FROM_TICK_HISTORY = "ALLOW_VOLUME_ANALYSIS_FROM_TICK_HISTORY";

	[CompilerGenerated]
	private string 놿;

	internal string Name
	{
		[CompilerGenerated]
		get
		{
			return 놿;
		}
		[CompilerGenerated]
		private set
		{
			놿 = value;
		}
	}

	protected Rule(string name)
	{
		Name = name;
	}

	internal virtual void 녴(MessageRule P_0)
	{
		Name = P_0.Name;
	}

	internal static Rule 놴(MessageRule P_0)
	{
		object value = P_0.Value;
		if (!(value is string text))
		{
			if (!(value is int num))
			{
				if (value is bool flag)
				{
					return new 높<bool>(P_0.Name, flag);
				}
				throw new ArgumentException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놎());
			}
			return new 높<int>(P_0.Name, num);
		}
		return new 높<string>(P_0.Name, text);
	}
}
