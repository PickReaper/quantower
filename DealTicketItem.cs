using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace TradingPlatform.BusinessLayer;

[DataContract]
public sealed class DealTicketItem
{
	[CompilerGenerated]
	private string 놩;

	private readonly object 녡;

	[CompilerGenerated]
	private readonly int 녦;

	[DataMember(Name = "key")]
	public string Key
	{
		[CompilerGenerated]
		get
		{
			return 놩;
		}
		[CompilerGenerated]
		private set
		{
			놩 = value;
		}
	}

	[DataMember(Name = "value")]
	public string FormattedValue => 녡?.ToString();

	public int SortIndex
	{
		[CompilerGenerated]
		get
		{
			return 녦;
		}
	}

	public DealTicketItem(string key, object value, int sortIndex = 0)
	{
		Key = key;
		녡 = value;
		녦 = sortIndex;
	}
}
