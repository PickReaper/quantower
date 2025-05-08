using System.Runtime.CompilerServices;
using ProtoBuf;

namespace TradingPlatform.BusinessLayer;

[ProtoContract]
public class PnL
{
	[CompilerGenerated]
	private PnLItem 뇁;

	[CompilerGenerated]
	private PnLItem 놧;

	[CompilerGenerated]
	private PnLItem 녝;

	[CompilerGenerated]
	private PnLItem 뇈;

	[ProtoMember(1)]
	public PnLItem GrossPnL
	{
		[CompilerGenerated]
		get
		{
			return 뇁;
		}
		[CompilerGenerated]
		set
		{
			뇁 = value;
		}
	}

	[ProtoMember(2)]
	public PnLItem NetPnL
	{
		[CompilerGenerated]
		get
		{
			return 놧;
		}
		[CompilerGenerated]
		set
		{
			놧 = value;
		}
	}

	[ProtoMember(3)]
	public PnLItem Fee
	{
		[CompilerGenerated]
		get
		{
			return 녝;
		}
		[CompilerGenerated]
		set
		{
			녝 = value;
		}
	}

	[ProtoMember(4)]
	public PnLItem Swaps
	{
		[CompilerGenerated]
		get
		{
			return 뇈;
		}
		[CompilerGenerated]
		set
		{
			뇈 = value;
		}
	}
}
