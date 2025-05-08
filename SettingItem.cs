using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Threading;
using System.Xml.Linq;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using ProtoBuf;
using TradingPlatform.BusinessLayer.DataBinding;
using TradingPlatform.BusinessLayer.Serialization;
using TradingPlatform.BusinessLayer.Settings.Condition;

namespace TradingPlatform.BusinessLayer;

[Serializable]
[DataContract]
[KnownType(typeof(SettingItemAccount))]
[KnownType(typeof(SettingItemBoolean))]
[KnownType(typeof(SettingItemBooleanSwitcher))]
[KnownType(typeof(SettingItemDateTime))]
[KnownType(typeof(SettingItemSymbol))]
[KnownType(typeof(SettingItemPassword))]
[KnownType(typeof(SettingItemPeriod))]
[KnownType(typeof(SettingItemSelector))]
[KnownType(typeof(SettingItemSelectorLocalized))]
[KnownType(typeof(SettingItemString))]
[KnownType(typeof(SettingItemFile))]
[KnownType(typeof(SettingItemGroup))]
[KnownType(typeof(SettingItemRadioLocalized))]
[KnownType(typeof(SettingItemAction))]
[KnownType(typeof(SettingItemFont))]
[KnownType(typeof(SettingItemTimeZone))]
[KnownType(typeof(SettingItemRss))]
[KnownType(typeof(SettingItemAlignment))]
[KnownType(typeof(SettingItemPairColor))]
[KnownType(typeof(SettingItemColor))]
[KnownType(typeof(SettingItemSound))]
[KnownType(typeof(SettingItemLineOptions))]
[KnownType(typeof(SettingItemTimeZoneManager))]
[KnownType(typeof(SettingItemAlert))]
[KnownType(typeof(SettingItemFibonacciLevelOptions))]
[KnownType(typeof(SettingItemMinotauroFibonacciLevelOptions))]
[KnownType(typeof(SettingItemRangeSelector))]
[KnownType(typeof(SettingitemPoints))]
[KnownType(typeof(SettingItemTimeFrameConfig))]
[KnownType(typeof(SettingItemBooleanLocalized))]
[KnownType(typeof(SettingItemNumber<int>))]
[KnownType(typeof(SettingItemNumber<double>))]
[KnownType(typeof(SettingItemNumber<long>))]
[KnownType(typeof(SettingItemClusterColoringLevel))]
[KnownType(typeof(SettingItemOrderRequestParameters))]
[KnownType(typeof(SettingItemIconedAction))]
[KnownType(typeof(SettingItemSlider))]
[KnownType(typeof(SettingItemDoubleWithLink))]
[KnownType(typeof(SettingItemCondition))]
[ProtoContract]
[ProtoInclude(2, typeof(SettingItemAccount))]
[ProtoInclude(3, typeof(SettingItemBoolean))]
[ProtoInclude(4, typeof(SettingItemBooleanSwitcher))]
[ProtoInclude(5, typeof(SettingItemDateTime))]
[ProtoInclude(6, typeof(SettingItemNumber<double>))]
[ProtoInclude(7, typeof(SettingItemSymbol))]
[ProtoInclude(8, typeof(SettingItemNumber<int>))]
[ProtoInclude(9, typeof(SettingItemPassword))]
[ProtoInclude(10, typeof(SettingItemPeriod))]
[ProtoInclude(11, typeof(SettingItemSelector))]
[ProtoInclude(12, typeof(SettingItemSelectorLocalized))]
[ProtoInclude(13, typeof(SettingItemString))]
[ProtoInclude(14, typeof(SettingItemFile))]
[ProtoInclude(15, typeof(SettingItemGroup))]
[ProtoInclude(16, typeof(SettingItemRadioLocalized))]
[ProtoInclude(17, typeof(SettingItemAction))]
[ProtoInclude(18, typeof(SettingItemFont))]
[ProtoInclude(19, typeof(SettingItemTimeZone))]
[ProtoInclude(20, typeof(SettingItemRss))]
[ProtoInclude(21, typeof(SettingItemAlignment))]
[ProtoInclude(22, typeof(SettingItemPairColor))]
[ProtoInclude(23, typeof(SettingItemColor))]
[ProtoInclude(24, typeof(SettingItemSound))]
[ProtoInclude(25, typeof(SettingItemLineOptions))]
[ProtoInclude(26, typeof(SettingItemTimeZoneManager))]
[ProtoInclude(27, typeof(SettingItemAlert))]
[ProtoInclude(28, typeof(SettingItemFibonacciLevelOptions))]
[ProtoInclude(29, typeof(SettingItemRangeSelector))]
[ProtoInclude(30, typeof(SettingitemPoints))]
[ProtoInclude(31, typeof(SettingItemTimeFrameConfig))]
[ProtoInclude(32, typeof(SettingItemBooleanLocalized))]
[ProtoInclude(33, typeof(SettingItemClusterColoringLevel))]
[ProtoInclude(34, typeof(SettingItemArbitageSymbols))]
[ProtoInclude(36, typeof(SettingItemOrderRequestParameters))]
[ProtoInclude(38, typeof(SettingItemIconedAction))]
[ProtoInclude(39, typeof(SettingItemSlider))]
[ProtoInclude(40, typeof(SettingItemDoubleWithLink))]
[ProtoInclude(41, typeof(SettingItemNumber<long>))]
[ProtoInclude(42, typeof(SettingItemCondition))]
public abstract class SettingItem : BindableEntity, IComparable<SettingItem>, IEquatable<SettingItem>, IXElementSerialization
{
	[CompilerGenerated]
	private string 놵녳;

	private string 놵놉;

	protected object value;

	[CompilerGenerated]
	private int 놵놥;

	[CompilerGenerated]
	private VisibilityMode 놵놯;

	[CompilerGenerated]
	private string 놵녾;

	[CompilerGenerated]
	private SettingItemGroup 놵녬;

	[CompilerGenerated]
	private SettingItemSeparatorGroup 놵녹;

	[CompilerGenerated]
	private ISettingsGroup 놵녔;

	private bool 놵녠;

	[CompilerGenerated]
	private SettingItemValueChangingBehavior 놵놠;

	[CompilerGenerated]
	private SettingItemValueChangingReason 놵놟;

	private bool 놵녓;

	[CompilerGenerated]
	private SettingItemEventHandler 놵녛;

	[CompilerGenerated]
	private SettingItemRelation 놵녽;

	[CompilerGenerated]
	private bool 놵놏;

	public abstract SettingItemType Type { get; }

	[DataMember(Name = "Name")]
	[ProtoMember(1)]
	public string Name
	{
		[CompilerGenerated]
		get
		{
			return 놵녳;
		}
		[CompilerGenerated]
		set
		{
			놵녳 = value;
		}
	}

	[Bindable("text")]
	public virtual string Text
	{
		get
		{
			if (string.IsNullOrEmpty(놵놉))
			{
				return Name;
			}
			return 놵놉;
		}
		set
		{
			SetValue(ref 놵놉, value, null, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놄놃());
		}
	}

	[Bindable("value")]
	public virtual object Value
	{
		get
		{
			return value;
		}
		set
		{
			if (this.value == value)
			{
				return;
			}
			if (value == null)
			{
				SetValue(ref this.value, value, null, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴놯());
				return;
			}
			if (IsValueTypeValid(value))
			{
				SetValue(ref this.value, ValidateValue(value), null, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴놯());
				return;
			}
			throw new InvalidCastException();
		}
	}

	public int SortIndex
	{
		[CompilerGenerated]
		get
		{
			return 놵놥;
		}
		[CompilerGenerated]
		set
		{
			놵놥 = value;
		}
	}

	public VisibilityMode VisibilityMode
	{
		[CompilerGenerated]
		get
		{
			return 놵놯;
		}
		[CompilerGenerated]
		set
		{
			놵놯 = value;
		}
	}

	public string Description
	{
		[CompilerGenerated]
		get
		{
			return 놵녾;
		}
		[CompilerGenerated]
		set
		{
			놵녾 = value;
		}
	}

	public SettingItemGroup Group
	{
		[CompilerGenerated]
		get
		{
			return 놵녬;
		}
		[CompilerGenerated]
		set
		{
			놵녬 = value;
		}
	}

	public SettingItemSeparatorGroup SeparatorGroup
	{
		[CompilerGenerated]
		get
		{
			return 놵녹;
		}
		[CompilerGenerated]
		set
		{
			놵녹 = value;
		}
	}

	public ISettingsGroup VisualGroup
	{
		[CompilerGenerated]
		get
		{
			return 놵녔;
		}
		[CompilerGenerated]
		set
		{
			놵녔 = value;
		}
	}

	[Bindable("enabled")]
	public bool Enabled
	{
		get
		{
			return 놵녠;
		}
		set
		{
			SetValue(ref 놵녠, value, null, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녲놁());
		}
	}

	public SettingItemValueChangingBehavior ValueChangingBehavior
	{
		[CompilerGenerated]
		get
		{
			return 놵놠;
		}
		[CompilerGenerated]
		set
		{
			놵놠 = value;
		}
	}

	public SettingItemValueChangingReason ValueChangingReason
	{
		[CompilerGenerated]
		get
		{
			return 놵놟;
		}
		[CompilerGenerated]
		set
		{
			놵놟 = value;
		}
	}

	[Bindable("visible")]
	public bool Visible
	{
		get
		{
			return 놵녓;
		}
		set
		{
			SetValue(ref 놵녓, value, null, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶놢());
		}
	}

	public bool IsVisualizationAllowed
	{
		get
		{
			if (VisibilityMode == VisibilityMode.Hidden)
			{
				return false;
			}
			if (Group != null)
			{
				return Group.IsVisualizationAllowed;
			}
			return true;
		}
	}

	public SettingItemRelation Relation
	{
		[CompilerGenerated]
		get
		{
			return 놵녽;
		}
		[CompilerGenerated]
		set
		{
			놵녽 = value;
		}
	}

	public bool UseEnabilityToggler
	{
		[CompilerGenerated]
		get
		{
			return 놵놏;
		}
		[CompilerGenerated]
		set
		{
			놵놏 = value;
		}
	}

	public event SettingItemEventHandler Updated
	{
		[CompilerGenerated]
		add
		{
			SettingItemEventHandler settingItemEventHandler = 놵녛;
			SettingItemEventHandler settingItemEventHandler2;
			do
			{
				settingItemEventHandler2 = settingItemEventHandler;
				SettingItemEventHandler settingItemEventHandler3 = (SettingItemEventHandler)Delegate.Combine(settingItemEventHandler2, value);
				settingItemEventHandler = Interlocked.CompareExchange(ref 놵녛, settingItemEventHandler3, settingItemEventHandler2);
			}
			while ((object)settingItemEventHandler != settingItemEventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			SettingItemEventHandler settingItemEventHandler = 놵녛;
			SettingItemEventHandler settingItemEventHandler2;
			do
			{
				settingItemEventHandler2 = settingItemEventHandler;
				SettingItemEventHandler settingItemEventHandler3 = (SettingItemEventHandler)Delegate.Remove(settingItemEventHandler2, value);
				settingItemEventHandler = Interlocked.CompareExchange(ref 놵녛, settingItemEventHandler3, settingItemEventHandler2);
			}
			while ((object)settingItemEventHandler != settingItemEventHandler2);
		}
	}

	public static IXElementSerialization DesserrializationFabric(XElement node)
	{
		string text = node?.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶놐())?.Value;
		if (text != null)
		{
			switch (text.Length)
			{
			case 18:
				switch (text[11])
				{
				case 'A':
					if (!(text == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놄뇇()))
					{
						break;
					}
					return new SettingItemAccount();
				case 'B':
					if (!(text == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놄놛()))
					{
						break;
					}
					return new SettingItemBoolean();
				case 'I':
					if (!(text == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놄놼()))
					{
						break;
					}
					return new SettingItemInteger();
				}
				break;
			case 26:
				switch (text[15])
				{
				case 'e':
					if (!(text == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놄놗()))
					{
						break;
					}
					return new SettingItemBooleanSwitcher();
				case 'Z':
					if (!(text == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놄뇂()))
					{
						break;
					}
					return new SettingItemTimeZoneManager();
				case 'F':
					if (!(text == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놄놩()))
					{
						break;
					}
					return new SettingItemTimeFrameConfig();
				}
				break;
			case 19:
				switch (text[13])
				{
				case 't':
					if (!(text == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놄녡()))
					{
						break;
					}
					return new SettingItemDateTime();
				case 's':
					if (!(text == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놄녦()))
					{
						break;
					}
					return new SettingItemPassword();
				case 'l':
					if (!(text == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놄놀()))
					{
						break;
					}
					return new SettingItemSelector();
				case 'm':
					if (!(text == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놄놔()))
					{
						break;
					}
					return new SettingItemTimeZone();
				case 'x':
					if (!(text == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놄놾()))
					{
						break;
					}
					return new SettingItemTextArea();
				}
				break;
			case 17:
				switch (text[16])
				{
				case 'l':
					if (!(text == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놄뇀()))
					{
						break;
					}
					return new SettingItemSymbol();
				case 'd':
					if (!(text == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놄놽()))
					{
						break;
					}
					return new SettingItemPeriod();
				case 'g':
					if (!(text == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놄녿()))
					{
						break;
					}
					return new SettingItemString();
				case 'n':
					if (!(text == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놄놁()))
					{
						break;
					}
					return new SettingItemAction();
				case 's':
					if (!(text == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놄녭()))
					{
						break;
					}
					return new SettingitemPoints();
				case 'e':
					if (!(text == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놄녱()))
					{
						break;
					}
					return new SettingItemDouble();
				case 'r':
					if (!(text == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놄놲()))
					{
						break;
					}
					return new SettingItemSlider();
				}
				break;
			case 15:
				switch (text[14])
				{
				case 'e':
					if (!(text == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놄놶()))
					{
						break;
					}
					return new SettingItemFile();
				case 't':
					if (!(text == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놄뇏()))
					{
						break;
					}
					return new SettingItemFont();
				case 'g':
					if (!(text == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놄녻()))
					{
						break;
					}
					return new SettingItemLong();
				}
				break;
			case 16:
				switch (text[11])
				{
				case 'G':
					if (!(text == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놄녙()))
					{
						break;
					}
					return new SettingItemGroup();
				case 'C':
					if (!(text == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놄놢()))
					{
						break;
					}
					return new SettingItemColor();
				case 'S':
					if (!(text == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놄녧()))
					{
						break;
					}
					return new SettingItemSound();
				case 'A':
					if (!(text == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놄녤()))
					{
						break;
					}
					return new SettingItemAlert();
				case 'O':
					if (!(text == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놄놆()))
					{
						break;
					}
					return new SettingItemOAuth();
				}
				break;
			case 25:
				switch (text[11])
				{
				case 'R':
					if (!(text == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놄뇎()))
					{
						break;
					}
					return new SettingItemRadioLocalized();
				case 'D':
					if (!(text == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놄놷()))
					{
						break;
					}
					return new SettingItemDoubleWithLink();
				}
				break;
			case 20:
				switch (text[11])
				{
				case 'A':
					if (!(text == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놄놜()))
					{
						break;
					}
					return new SettingItemAlignment();
				case 'P':
					if (!(text == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놄놨()))
					{
						break;
					}
					return new SettingItemPairColor();
				case 'C':
					if (!(text == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놄녢()))
					{
						break;
					}
					return new SettingItemCondition();
				}
				break;
			case 22:
				switch (text[11])
				{
				case 'L':
					if (!(text == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놄놞()))
					{
						break;
					}
					return new SettingItemLineOptions();
				case 'B':
					if (!(text == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놄놳()))
					{
						break;
					}
					return new SettingItemBigTextArea();
				}
				break;
			case 28:
				if (!(text == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놄높()))
				{
					break;
				}
				return new SettingItemSelectorLocalized();
			case 14:
				if (!(text == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놄녗()))
				{
					break;
				}
				return new SettingItemRss();
			case 32:
				if (!(text == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놄놺()))
				{
					break;
				}
				return new SettingItemFibonacciLevelOptions();
			case 41:
				if (!(text == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놄놅()))
				{
					break;
				}
				return new SettingItemMinotauroFibonacciLevelOptions();
			case 24:
				if (!(text == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놄녜()))
				{
					break;
				}
				return new SettingItemRangeSelector();
			case 27:
				if (!(text == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놄뇃()))
				{
					break;
				}
				return new SettingItemBooleanLocalized();
			case 31:
				if (!(text == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놄녯()))
				{
					break;
				}
				return new SettingItemClusterColoringLevel();
			case 33:
				if (!(text == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놄놮()))
				{
					break;
				}
				return new SettingItemOrderRequestParameters();
			case 23:
				if (!(text == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놄녫()))
				{
					break;
				}
				return new SettingItemIconedAction();
			}
		}
		return null;
	}

	public void Update()
	{
		놵녛?.Invoke(this, SettingItemEventArgs.Empty);
	}

	protected SettingItem(string name, object value, int sortIndex = 0)
		: this()
	{
		Name = name;
		this.value = value;
		SortIndex = sortIndex;
		VisibilityMode = VisibilityMode.Visible;
		ValueChangingBehavior = SettingItemValueChangingBehavior.Default;
		Enabled = true;
		Visible = true;
	}

	protected SettingItem()
	{
		ValueChangingReason = SettingItemValueChangingReason.Unknown;
	}

	protected SettingItem(SettingItem settingItem)
		: this()
	{
		Name = settingItem.Name;
		SortIndex = settingItem.SortIndex;
		Text = settingItem.Text;
		Description = settingItem.Description;
		Enabled = settingItem.Enabled;
		Group = settingItem.Group;
		Relation = settingItem.Relation;
		SeparatorGroup = settingItem.SeparatorGroup;
		VisibilityMode = settingItem.VisibilityMode;
		Visible = settingItem.Visible;
		VisualGroup = settingItem.VisualGroup;
		if (settingItem.value is ICloneable cloneable)
		{
			value = cloneable.Clone();
		}
		else
		{
			value = settingItem.Value;
		}
		ValueChangingBehavior = settingItem.ValueChangingBehavior;
		UseEnabilityToggler = settingItem.UseEnabilityToggler;
	}

	public abstract SettingItem GetCopy();

	protected abstract bool IsValueTypeValid(object value);

	protected virtual object ValidateValue(object value)
	{
		return value;
	}

	internal bool 녴(IList<SettingItem> P_0)
	{
		if (P_0 == null)
		{
			return false;
		}
		SettingItem itemByName = P_0.GetItemByName(Name);
		if (itemByName != null)
		{
			Value = itemByName.Value;
			return true;
		}
		return false;
	}

	internal virtual void 녴(object P_0, bool P_1 = false)
	{
		if (P_1)
		{
			SetValue(ref value, P_0, null, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴놯());
		}
		else
		{
			Value = P_0;
		}
	}

	internal virtual void 녴(SettingItem P_0)
	{
		녴(P_0.Value);
		VisibilityMode = P_0.VisibilityMode;
		SortIndex = P_0.SortIndex;
	}

	public int CompareTo(SettingItem other)
	{
		return SortIndex.CompareTo(other.SortIndex);
	}

	public override string ToString()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(14, 2);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵녠());
		defaultInterpolatedStringHandler.AppendFormatted(Name);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놄뇁());
		defaultInterpolatedStringHandler.AppendFormatted<object>(Value);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	public virtual XElement ToXElement()
	{
		XElement xElement = new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녲놾());
		xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놵(), Name));
		xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶놐(), GetType().Name));
		if (UseEnabilityToggler)
		{
			xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녲놁(), Enabled));
		}
		xElement.Add(ValueToXElement());
		return xElement;
	}

	protected virtual XElement ValueToXElement()
	{
		if (Value is IXElementSerialization iXElementSerialization)
		{
			return iXElementSerialization.ToXElement();
		}
		return new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴놯(), Value);
	}

	public virtual void FromXElement(XElement element, DeserializationInfo deserializationInfo)
	{
		Name = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놵()).Value;
		UseEnabilityToggler = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녲놁()) != null;
		Enabled = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녲놁())?.ToBool() ?? false;
		ValueFromXElement(element, deserializationInfo);
	}

	protected virtual void ValueFromXElement(XElement element, DeserializationInfo deserializationInfo)
	{
		XElement xElement = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴놯());
		if (xElement != null)
		{
			Value = xElement.Value;
		}
	}

	public virtual bool Equals(SettingItem other)
	{
		if (other == null)
		{
			return false;
		}
		if (this == other)
		{
			return true;
		}
		if (Text == other.Text && ValueEquals(other.Value) && Enabled == other.Enabled && Visible == other.Visible && Type == other.Type && Name == other.Name && SortIndex == other.SortIndex && VisibilityMode == other.VisibilityMode && Description == other.Description && object.Equals(SeparatorGroup, other.SeparatorGroup) && object.Equals(VisualGroup, other.VisualGroup) && ValueChangingReason == other.ValueChangingReason && ValueChangingBehavior == other.ValueChangingBehavior)
		{
			return UseEnabilityToggler == other.UseEnabilityToggler;
		}
		return false;
	}

	protected virtual bool ValueEquals(object other)
	{
		return object.Equals(Value, other);
	}

	public override bool Equals(object obj)
	{
		if (obj == null)
		{
			return false;
		}
		if (this == obj)
		{
			return true;
		}
		if (obj.GetType() != GetType())
		{
			return false;
		}
		return Equals((SettingItem)obj);
	}

	public override int GetHashCode()
	{
		HashCode hashCode = default(HashCode);
		hashCode.Add(Text);
		hashCode.Add(Value);
		hashCode.Add(Enabled);
		hashCode.Add(Visible);
		hashCode.Add((int)Type);
		hashCode.Add(Name);
		hashCode.Add(SortIndex);
		hashCode.Add((int)VisibilityMode);
		hashCode.Add(Description);
		hashCode.Add(SeparatorGroup);
		hashCode.Add(VisualGroup);
		hashCode.Add(ValueChangingReason);
		hashCode.Add((int)ValueChangingBehavior);
		hashCode.Add(UseEnabilityToggler);
		return hashCode.ToHashCode();
	}
}
