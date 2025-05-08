using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using TradingPlatform.BusinessLayer.Integration;

namespace TradingPlatform.BusinessLayer;

public sealed class HistoryAggregationReversal : HistoryAggregation
{
	private const string 놇놜 = "Length";

	private const string 놇놨 = "Reversal Length";

	private const string 놇녢 = "Calculation Type";

	[CompilerGenerated]
	private int 놇놞;

	[CompilerGenerated]
	private int 놇놳;

	[CompilerGenerated]
	private HistoryProcessorReversalCalculationType 놇놺;

	public override string Name => _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놄();

	public override IList<SettingItem> Settings
	{
		get
		{
			return new List<SettingItem>
			{
				new SettingItemInteger(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놰(), Length)
				{
					Minimum = 0,
					Increment = 1,
					SortIndex = 10
				},
				new SettingItemInteger(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놓(), ReversalLength)
				{
					Minimum = 1,
					Increment = 1,
					SortIndex = 10
				},
				new SettingItemSelectorLocalized(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놇(), (int)CalculationType, new List<SelectItem>
				{
					new SelectItem(loc._(HistoryProcessorReversalCalculationType.PreviousBar.GetDescription(), null, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿뇅()), 0),
					new SelectItem(loc._(HistoryProcessorReversalCalculationType.Independent.GetDescription(), null, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿뇅()), 1)
				})
				{
					SortIndex = 10
				}
			};
		}
		set
		{
			if (value == null)
			{
				return;
			}
			foreach (SettingItem item in value)
			{
				string name = item.Name;
				if (!(name == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놰()))
				{
					if (name == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놓())
					{
						ReversalLength = (int)item.Value;
					}
				}
				else
				{
					Length = (int)item.Value;
				}
			}
			CalculationType = (HistoryProcessorReversalCalculationType)value.GetValueOrDefault((int)CalculationType, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놇());
		}
	}

	public int Length
	{
		[CompilerGenerated]
		get
		{
			return 놇놞;
		}
		[CompilerGenerated]
		private set
		{
			놇놞 = value;
		}
	}

	public int ReversalLength
	{
		[CompilerGenerated]
		get
		{
			return 놇놳;
		}
		[CompilerGenerated]
		private set
		{
			놇놳 = value;
		}
	}

	public HistoryProcessorReversalCalculationType CalculationType
	{
		[CompilerGenerated]
		get
		{
			return 놇놺;
		}
		[CompilerGenerated]
		private set
		{
			놇놺 = value;
		}
	}

	public override Period GetPeriod => Period.TICK1;

	public override HistoryType GetHistoryType => HistoryType.Last;

	[NotPublished]
	public override Period DefaultRange => Period.HOUR1;

	public HistoryAggregationReversal(int length, int reversalLength, HistoryProcessorReversalCalculationType calculationType)
	{
		Length = length;
		ReversalLength = reversalLength;
		CalculationType = calculationType;
	}

	private HistoryAggregationReversal(HistoryAggregationReversal P_0)
		: base(P_0)
	{
		Length = P_0.Length;
		ReversalLength = P_0.ReversalLength;
		CalculationType = P_0.CalculationType;
	}

	[NotPublished]
	public override string ToString()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(9, 4);
		defaultInterpolatedStringHandler.AppendFormatted(Name);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴뇎());
		defaultInterpolatedStringHandler.AppendFormatted(Length);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴뇎());
		defaultInterpolatedStringHandler.AppendFormatted(ReversalLength);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴뇎());
		defaultInterpolatedStringHandler.AppendFormatted(CalculationType.GetDescription());
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	[NotPublished]
	public override object Clone()
	{
		return new HistoryAggregationReversal(this);
	}

	[NotPublished]
	public override string FormatTime(DateTime dt)
	{
		return dt.ToString(DateTimeFormatInfo.CurrentInfo.ShortDatePattern + _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭녤());
	}

	public override HistoryAggregation GetAggregationToDirectDownload(HistoryMetadata metadata)
	{
		return new HistoryAggregationTick(HistoryType.Last);
	}
}
