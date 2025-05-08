using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using TradingPlatform.BusinessLayer.Integration;

namespace TradingPlatform.BusinessLayer;

public sealed class NewsArticle : BusinessObject
{
	[Serializable]
	[CompilerGenerated]
	private sealed class 녴
	{
		public static readonly 녴 놻놡 = new 녴();

		public static Func<Symbol, bool> 놻놻;

		internal bool 녴(Symbol P_0)
		{
			return P_0 != null;
		}
	}

	[CompilerGenerated]
	private string 놰놎;

	[CompilerGenerated]
	private DateTime 놰녞;

	[CompilerGenerated]
	private string 놰놫;

	[CompilerGenerated]
	private string 놰녪;

	[CompilerGenerated]
	private string 놰녶;

	[CompilerGenerated]
	private IEnumerable<Symbol> 놰녵;

	private string[] 놰놭;

	private bool 놰녲;

	public string Id
	{
		[CompilerGenerated]
		get
		{
			return 놰놎;
		}
		[CompilerGenerated]
		private set
		{
			놰놎 = value;
		}
	}

	public DateTime CreationDate
	{
		[CompilerGenerated]
		get
		{
			return 놰녞;
		}
		[CompilerGenerated]
		private set
		{
			놰녞 = value;
		}
	}

	public string Title
	{
		[CompilerGenerated]
		get
		{
			return 놰놫;
		}
		[CompilerGenerated]
		private set
		{
			놰놫 = value;
		}
	}

	public string SourceLink
	{
		[CompilerGenerated]
		get
		{
			return 놰녪;
		}
		[CompilerGenerated]
		private set
		{
			놰녪 = value;
		}
	}

	public string Category
	{
		[CompilerGenerated]
		get
		{
			return 놰녶;
		}
		[CompilerGenerated]
		private set
		{
			놰녶 = value;
		}
	}

	public IEnumerable<Symbol> Symbols
	{
		[CompilerGenerated]
		get
		{
			return 놰녵;
		}
		[CompilerGenerated]
		private set
		{
			놰녵 = value;
		}
	}

	public bool NeedToLoadSymbols
	{
		get
		{
			if (놰놭 != null)
			{
				return 놰놭.Any();
			}
			return false;
		}
	}

	internal NewsArticle(string P_0)
		: base(P_0)
	{
		Symbols = new Symbol[0];
		놰놭 = new string[0];
	}

	internal void 녴(MessageNewsHeadline P_0)
	{
		Id = P_0.Id;
		CreationDate = P_0.CreationDate;
		Title = P_0.Title;
		SourceLink = P_0.SourceLink;
		Category = P_0.Category;
		if (P_0.SymbolsIds != null && P_0.SymbolsIds.Any())
		{
			놰놭 = P_0.SymbolsIds.ToArray();
		}
	}

	public void LoadSymbols()
	{
		if (놰녲)
		{
			return;
		}
		놰녲 = true;
		if (!NeedToLoadSymbols)
		{
			return;
		}
		try
		{
			Symbols = (from P_0 in 놰놭
				select Connection.녴(new GetSymbolRequestParameters
				{
					SymbolId = P_0
				}) into P_0
				where P_0 != null
				select P_0).ToArray();
			놰놭 = null;
		}
		catch (Exception ex)
		{
			Core.Instance.Loggers.Log(ex);
		}
		finally
		{
			놰녲 = false;
		}
	}

	[CompilerGenerated]
	private Symbol 녴(string P_0)
	{
		return Connection.녴(new GetSymbolRequestParameters
		{
			SymbolId = P_0
		});
	}
}
