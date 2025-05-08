using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using TradingPlatform.BusinessLayer.Integration;

namespace TradingPlatform.BusinessLayer;

/// <summary>
/// Provides possibility to group and sort symbols for each connection
/// </summary>
[Published]
[DataContract(Name = "InstrumentGroup", Namespace = "TradingPlatform")]
public class SymbolGroup : BusinessObject
{
	[CompilerGenerated]
	private string 놰녴;

	[CompilerGenerated]
	private string 놰놴;

	[CompilerGenerated]
	private int 놰놂;

	/// <summary>
	/// Gets group Id
	/// </summary>
	[DataMember(Name = "GroupId")]
	public string Id
	{
		[CompilerGenerated]
		get
		{
			return 놰녴;
		}
		[CompilerGenerated]
		private set
		{
			놰녴 = value;
		}
	}

	/// <summary>
	/// Gets group name
	/// </summary>
	[DataMember(Name = "GroupName")]
	public string GroupName
	{
		[CompilerGenerated]
		get
		{
			return 놰놴;
		}
		[CompilerGenerated]
		private set
		{
			놰놴 = value;
		}
	}

	/// <summary>
	/// Gets sort index for comparing process
	/// </summary>
	[DataMember(Name = "SortIndex")]
	public int SortIndex
	{
		[CompilerGenerated]
		get
		{
			return 놰놂;
		}
		[CompilerGenerated]
		private set
		{
			놰놂 = value;
		}
	}

	internal SymbolGroup(string P_0)
		: base(P_0)
	{
	}

	internal void 녴(MessageSymbolGroup P_0)
	{
		Id = P_0.Id;
		GroupName = P_0.GroupName;
		SortIndex = P_0.SortIndex;
	}
}
