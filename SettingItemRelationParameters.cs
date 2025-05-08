using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace TradingPlatform.BusinessLayer;

public class SettingItemRelationParameters
{
	[CompilerGenerated]
	private SettingItem 놴녗;

	[CompilerGenerated]
	private SettingItem 놴놜;

	[CompilerGenerated]
	private IDictionary<SettingItem, IEnumerable<object>> 놴놨;

	[CompilerGenerated]
	private MultipleRelationCondition 놴녢;

	[CompilerGenerated]
	private bool 놴놞;

	public SettingItem DependentItem
	{
		[CompilerGenerated]
		get
		{
			return 놴녗;
		}
		[CompilerGenerated]
		set
		{
			놴녗 = value;
		}
	}

	public SettingItem ChangedItem
	{
		[CompilerGenerated]
		get
		{
			return 놴놜;
		}
		[CompilerGenerated]
		set
		{
			놴놜 = value;
		}
	}

	public IDictionary<SettingItem, IEnumerable<object>> RelationValuesByParentItem
	{
		[CompilerGenerated]
		get
		{
			return 놴놨;
		}
		[CompilerGenerated]
		set
		{
			놴놨 = value;
		}
	}

	public MultipleRelationCondition MultipleRelationCondition
	{
		[CompilerGenerated]
		get
		{
			return 놴녢;
		}
		[CompilerGenerated]
		set
		{
			놴녢 = value;
		}
	}

	public bool IsPopulating
	{
		[CompilerGenerated]
		get
		{
			return 놴놞;
		}
		[CompilerGenerated]
		set
		{
			놴놞 = value;
		}
	}
}
