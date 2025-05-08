using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace TradingPlatform.BusinessLayer;

public sealed class HistoryItemVolumeProfile : HistoryItem
{
	[Serializable]
	[CompilerGenerated]
	private sealed class 녴
	{
		public static readonly 녴 놻놬 = new 녴();

		public static Func<KeyValuePair<double, VolumeDataItem>, double> 놻놊;

		public static Func<KeyValuePair<double, VolumeDataItem>, VolumeDataItem> 놻놪;

		internal double 녴(KeyValuePair<double, VolumeDataItem> P_0)
		{
			return P_0.Key;
		}

		internal VolumeDataItem 놴(KeyValuePair<double, VolumeDataItem> P_0)
		{
			return new VolumeDataItem(P_0.Value);
		}
	}

	[CompilerGenerated]
	private long 뇅놰;

	[CompilerGenerated]
	private Dictionary<double, VolumeDataItem> 뇅놓;

	public override long TicksRight
	{
		[CompilerGenerated]
		get
		{
			return 뇅놰;
		}
		[CompilerGenerated]
		set
		{
			뇅놰 = value;
		}
	}

	public Dictionary<double, VolumeDataItem> PriceLevels
	{
		[CompilerGenerated]
		get
		{
			return 뇅놓;
		}
		[CompilerGenerated]
		set
		{
			뇅놓 = value;
		}
	}

	public HistoryItemVolumeProfile()
	{
	}

	public HistoryItemVolumeProfile(HistoryItemVolumeProfile item)
		: base(item)
	{
		TicksRight = item.TicksRight;
		PriceLevels = item.PriceLevels.ToDictionary((KeyValuePair<double, VolumeDataItem> P_0) => P_0.Key, (KeyValuePair<double, VolumeDataItem> P_0) => new VolumeDataItem(P_0.Value));
	}

	public override object Clone()
	{
		return new HistoryItemVolumeProfile(this);
	}
}
