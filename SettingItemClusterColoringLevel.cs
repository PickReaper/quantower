using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Xml.Linq;
using TradingPlatform.BusinessLayer.Serialization;
using TradingPlatform.BusinessLayer.Utils;

namespace TradingPlatform.BusinessLayer;

[Serializable]
[DataContract]
public class SettingItemClusterColoringLevel : SettingItem
{
	[CompilerGenerated]
	private int 놃놭;

	[CompilerGenerated]
	private decimal 놃녲 = 1m;

	[CompilerGenerated]
	private decimal 놃뇋 = decimal.MinValue;

	[CompilerGenerated]
	private decimal 놃놸 = decimal.MaxValue;

	[CompilerGenerated]
	private bool 놃놿 = true;

	public int NumericPrecision
	{
		[CompilerGenerated]
		get
		{
			return 놃놭;
		}
		[CompilerGenerated]
		set
		{
			놃놭 = value;
		}
	}

	public decimal Increment
	{
		[CompilerGenerated]
		get
		{
			return 놃녲;
		}
		[CompilerGenerated]
		set
		{
			놃녲 = value;
		}
	}

	public decimal Minimum
	{
		[CompilerGenerated]
		get
		{
			return 놃뇋;
		}
		[CompilerGenerated]
		set
		{
			놃뇋 = value;
		}
	}

	public decimal Maximum
	{
		[CompilerGenerated]
		get
		{
			return 놃놸;
		}
		[CompilerGenerated]
		set
		{
			놃놸 = value;
		}
	}

	public bool WithRightColor
	{
		[CompilerGenerated]
		get
		{
			return 놃놿;
		}
		[CompilerGenerated]
		set
		{
			놃놿 = value;
		}
	}

	public override SettingItemType Type => SettingItemType.ClusterColoringLevels;

	[DataMember(Name = "Value")]
	private ClusterCustomColoringLevel Level
	{
		get
		{
			return Value as ClusterCustomColoringLevel;
		}
		set
		{
			Value = value;
		}
	}

	public SettingItemClusterColoringLevel()
	{
	}

	public SettingItemClusterColoringLevel(string name, ClusterCustomColoringLevel level, int sortIndex = 0)
		: base(name, level, sortIndex)
	{
		NumericPrecision = 0;
	}

	public SettingItemClusterColoringLevel(SettingItemClusterColoringLevel settingItem)
		: base(settingItem)
	{
		NumericPrecision = settingItem.NumericPrecision;
		Increment = settingItem.Increment;
		Minimum = settingItem.Minimum;
		Maximum = settingItem.Maximum;
	}

	public override SettingItem GetCopy()
	{
		return new SettingItemClusterColoringLevel(this);
	}

	protected override bool IsValueTypeValid(object value)
	{
		return value is ClusterCustomColoringLevel;
	}

	protected override XElement ValueToXElement()
	{
		return Level.ToXElement();
	}

	protected override void ValueFromXElement(XElement element, DeserializationInfo deserializationInfo)
	{
		ClusterCustomColoringLevel clusterCustomColoringLevel = new ClusterCustomColoringLevel();
		clusterCustomColoringLevel.FromXElement(element, deserializationInfo);
		Value = clusterCustomColoringLevel;
	}
}
