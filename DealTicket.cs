using System;
using System.Runtime.CompilerServices;

namespace TradingPlatform.BusinessLayer;

public class DealTicket
{
	[CompilerGenerated]
	private readonly string 뇇;

	[CompilerGenerated]
	private readonly string 놛;

	[CompilerGenerated]
	private readonly DealTicketType 놼;

	[CompilerGenerated]
	private readonly DateTime 놗;

	[CompilerGenerated]
	private readonly Action 뇂;

	public string Header
	{
		[CompilerGenerated]
		get
		{
			return 뇇;
		}
		[CompilerGenerated]
		init
		{
			뇇 = value;
		}
	}

	public string Description
	{
		[CompilerGenerated]
		get
		{
			return 놛;
		}
		[CompilerGenerated]
		init
		{
			놛 = value;
		}
	}

	public DealTicketType Type
	{
		[CompilerGenerated]
		get
		{
			return 놼;
		}
		[CompilerGenerated]
		init
		{
			놼 = value;
		}
	}

	public DateTime CreationTime
	{
		[CompilerGenerated]
		get
		{
			return 놗;
		}
	}

	public Action CustomAction
	{
		[CompilerGenerated]
		get
		{
			return 뇂;
		}
		[CompilerGenerated]
		init
		{
			뇂 = value;
		}
	}

	internal DealTicket(string P_0, string P_1, DealTicketType P_2)
		: this()
	{
		Header = P_0;
		Description = P_1;
		Type = P_2;
	}

	protected DealTicket()
	{
		놗 = Core.Instance.TimeUtils.DateTimeUtcNow;
	}
}
