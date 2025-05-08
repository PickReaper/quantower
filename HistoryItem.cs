using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using ProtoBuf;

namespace TradingPlatform.BusinessLayer;

[ProtoContract]
[ProtoInclude(2, typeof(HistoryItemLast))]
[ProtoInclude(3, typeof(HistoryItemTick))]
[ProtoInclude(4, typeof(HistoryItemMark))]
[ProtoInclude(5, typeof(HistoryItemBar))]
[ProtoInclude(6, typeof(HistoryItemLevel2))]
[ProtoInclude(7, typeof(HistoryItemDom))]
[ProtoInclude(8, typeof(HistoryItemTimeStatistics))]
[DataContract]
public abstract class HistoryItem : IHistoryItem, ICloneable
{
	public static class CustomFields
	{
		public static class Trend
		{
			public const string UP = "up";

			public const string DOWN = "down";
		}

		public const string IS_TEMPORARY_BAR = "isTemporaryBar";

		public const string TREND = "trend";

		public const string ONE_STEP_BACK = "OneStepBack";
	}

	[CompilerGenerated]
	private long 녶뇁;

	private Dictionary<string, object> 녶놧;

	[CompilerGenerated]
	private VolumeAnalysisData 녶녝;

	public DateTime TimeLeft => new DateTime(TicksLeft, DateTimeKind.Utc);

	[ProtoMember(1)]
	[DataMember(Order = 1)]
	public long TicksLeft
	{
		[CompilerGenerated]
		get
		{
			return 녶뇁;
		}
		[CompilerGenerated]
		set
		{
			녶뇁 = value;
		}
	}

	public virtual long TicksRight
	{
		get
		{
			return TicksLeft;
		}
		set
		{
		}
	}

	public virtual double this[PriceType priceType] => double.NaN;

	public VolumeAnalysisData VolumeAnalysisData
	{
		[CompilerGenerated]
		get
		{
			return 녶녝;
		}
		[CompilerGenerated]
		set
		{
			녶녝 = value;
		}
	}

	protected HistoryItem()
	{
		TicksLeft = 0L;
	}

	public void SetData(string key, object value)
	{
		if (string.IsNullOrEmpty(key))
		{
			throw new ArgumentNullException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭녻());
		}
		if (value == null)
		{
			throw new ArgumentNullException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂뇄());
		}
		if (녶놧 == null)
		{
			녶놧 = new Dictionary<string, object>();
		}
		녶놧[key] = value;
	}

	public bool TryGetData<TData>(string key, out TData data)
	{
		data = default(TData);
		if (녶놧 == null)
		{
			return false;
		}
		if (!녶놧.TryGetValue(key, out var value) || !(value is TData))
		{
			return false;
		}
		data = (TData)value;
		return true;
	}

	protected HistoryItem(MessageQuote message)
	{
		TicksLeft = message.Time.Ticks;
	}

	protected HistoryItem(HistoryItem original)
	{
		TicksLeft = original.TicksLeft;
		if (original.VolumeAnalysisData != null)
		{
			VolumeAnalysisData = new VolumeAnalysisData(original.VolumeAnalysisData);
		}
		if (original.녶놧 == null)
		{
			return;
		}
		foreach (KeyValuePair<string, object> item in original.녶놧)
		{
			SetData(item.Key, item.Value);
		}
	}

	public abstract object Clone();

	public override string ToString()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
		defaultInterpolatedStringHandler.AppendFormatted(TicksLeft);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놀());
		defaultInterpolatedStringHandler.AppendFormatted(TimeLeft);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}
}
