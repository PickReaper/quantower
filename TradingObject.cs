using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace TradingPlatform.BusinessLayer;

[DataContract(Name = "TradingObject")]
public abstract class TradingObject : BusinessObject, ITradingObject
{
	[CompilerGenerated]
	private string 놓놆;

	[CompilerGenerated]
	private Account 놓뇎;

	[CompilerGenerated]
	private Symbol 놓놷;

	[CompilerGenerated]
	private Side 놓녗;

	[CompilerGenerated]
	private string 놓놜;

	private readonly Lazy<AdditionalInfoCollection> 놓놨;

	[DataMember(Name = "ID")]
	public string Id
	{
		[CompilerGenerated]
		get
		{
			return 놓놆;
		}
		[CompilerGenerated]
		protected set
		{
			놓놆 = value;
		}
	}

	[DataMember(Name = "Account")]
	public Account Account
	{
		[CompilerGenerated]
		get
		{
			return 놓뇎;
		}
		[CompilerGenerated]
		protected set
		{
			놓뇎 = value;
		}
	}

	[DataMember(Name = "Instrument")]
	public Symbol Symbol
	{
		[CompilerGenerated]
		get
		{
			return 놓놷;
		}
		[CompilerGenerated]
		protected set
		{
			놓놷 = value;
		}
	}

	[DataMember(Name = "Side")]
	public Side Side
	{
		[CompilerGenerated]
		get
		{
			return 놓녗;
		}
		[CompilerGenerated]
		protected set
		{
			놓녗 = value;
		}
	}

	[DataMember(Name = "Comment")]
	public string Comment
	{
		[CompilerGenerated]
		get
		{
			return 놓놜;
		}
		[CompilerGenerated]
		protected set
		{
			놓놜 = value;
		}
	}

	public AdditionalInfoCollection AdditionalInfo
	{
		get
		{
			if (!놓놨.IsValueCreated)
			{
				return null;
			}
			return 놓놨.Value;
		}
	}

	protected TradingObject(string connectionId)
		: base(connectionId)
	{
		놓놨 = new Lazy<AdditionalInfoCollection>();
	}

	protected void ProcessAdditionalItems(List<AdditionalInfoItem> items)
	{
		if (items == null)
		{
			return;
		}
		foreach (AdditionalInfoItem item in items)
		{
			놓놨.Value.녴(item);
		}
	}
}
