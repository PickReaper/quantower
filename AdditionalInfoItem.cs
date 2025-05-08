using System;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using ProtoBuf;
using TradingPlatform.BusinessLayer.Integration;
using TradingPlatform.BusinessLayer.Serialization;

namespace TradingPlatform.BusinessLayer;

/// <summary>
/// The additional info item.
/// </summary>
[ProtoContract]
public class AdditionalInfoItem : ICloneable, IXElementSerialization, IEquatable<AdditionalInfoItem>
{
	[CompilerGenerated]
	private string 녞놌;

	[CompilerGenerated]
	private string 녞놕;

	[CompilerGenerated]
	private int 녞뇊;

	[CompilerGenerated]
	private string 녞놋;

	[CompilerGenerated]
	private string 녞녣;

	[CompilerGenerated]
	private ComparingType 녞녩;

	[CompilerGenerated]
	private object 녞놤;

	[CompilerGenerated]
	private bool 녞논;

	[CompilerGenerated]
	private AdditionalInfoItemFormatingType 녞녘;

	[CompilerGenerated]
	private string 녞노;

	[CompilerGenerated]
	private bool 녞녒;

	[CompilerGenerated]
	private bool 녞녕;

	[CompilerGenerated]
	private EditingInfo 녞녖;

	[CompilerGenerated]
	private IFormattingDescription 놫녴;

	/// <summary>
	/// ключ для апи, обязательно для заполнения и должен быть уникальным
	/// </summary>
	[ProtoMember(1)]
	public string Id
	{
		[CompilerGenerated]
		get
		{
			return 녞놌;
		}
		[CompilerGenerated]
		set
		{
			녞놌 = value;
		}
	}

	/// <summary>
	/// Gets or Sets the group info.
	/// </summary>
	[ProtoMember(2)]
	public string GroupInfo
	{
		[CompilerGenerated]
		get
		{
			return 녞놕;
		}
		[CompilerGenerated]
		set
		{
			녞놕 = value;
		}
	}

	/// <summary>
	/// Gets or Sets the sort index.
	/// </summary>
	[ProtoMember(3)]
	public int SortIndex
	{
		[CompilerGenerated]
		get
		{
			return 녞뇊;
		}
		[CompilerGenerated]
		set
		{
			녞뇊 = value;
		}
	}

	/// <summary>
	/// Gets or Sets the name key.
	/// </summary>
	[ProtoMember(4)]
	public string NameKey
	{
		[CompilerGenerated]
		get
		{
			return 녞놋;
		}
		[CompilerGenerated]
		set
		{
			녞놋 = value;
		}
	}

	/// <summary>
	/// Gets or Sets the tool tip key.
	/// </summary>
	[ProtoMember(5)]
	public string ToolTipKey
	{
		[CompilerGenerated]
		get
		{
			return 녞녣;
		}
		[CompilerGenerated]
		set
		{
			녞녣 = value;
		}
	}

	/// <summary>
	/// Gets or Sets the data type.
	/// </summary>
	[ProtoMember(6)]
	public ComparingType DataType
	{
		[CompilerGenerated]
		get
		{
			return 녞녩;
		}
		[CompilerGenerated]
		set
		{
			녞녩 = value;
		}
	}

	/// <summary>
	/// Gets or Sets the value.
	/// </summary>
	[ProtoIgnore]
	public object Value
	{
		[CompilerGenerated]
		get
		{
			return 녞놤;
		}
		[CompilerGenerated]
		set
		{
			녞놤 = value;
		}
	}

	/// <summary>
	/// Gets or Sets a value indicating whether hidden.
	/// </summary>
	[ProtoMember(7)]
	public bool Hidden
	{
		[CompilerGenerated]
		get
		{
			return 녞논;
		}
		[CompilerGenerated]
		set
		{
			녞논 = value;
		}
	}

	/// <summary>
	/// Gets or Sets the formating type.
	/// </summary>
	[ProtoMember(8)]
	public AdditionalInfoItemFormatingType FormatingType
	{
		[CompilerGenerated]
		get
		{
			return 녞녘;
		}
		[CompilerGenerated]
		set
		{
			녞녘 = value;
		}
	}

	/// <summary>
	/// используется в связке с AccountAdditionalInfoItemFormatingType.CustomAsset для форматирования в заданном ассете
	/// </summary>
	[ProtoMember(9)]
	public string CustomAssetID
	{
		[CompilerGenerated]
		get
		{
			return 녞노;
		}
		[CompilerGenerated]
		set
		{
			녞노 = value;
		}
	}

	/// <summary>
	/// Gets or Sets a value indicating whether visible.
	/// </summary>
	[ProtoMember(10)]
	public bool Visible
	{
		[CompilerGenerated]
		get
		{
			return 녞녒;
		}
		[CompilerGenerated]
		set
		{
			녞녒 = value;
		}
	}

	/// <summary>
	/// Gets or Sets a value indicating whether is link.
	/// </summary>
	[ProtoMember(11)]
	public bool IsLink
	{
		[CompilerGenerated]
		get
		{
			return 녞녕;
		}
		[CompilerGenerated]
		set
		{
			녞녕 = value;
		}
	}

	[ProtoMember(12, IsRequired = false)]
	private string ProtoDynamicPropertySurrogateString
	{
		get
		{
			if (DataType != 0)
			{
				return null;
			}
			return (string)Value;
		}
		set
		{
			if (DataType == ComparingType.String && value != null)
			{
				Value = value;
			}
		}
	}

	[ProtoMember(13, IsRequired = false)]
	private int? ProtoDynamicPropertySurrogateInt
	{
		get
		{
			if (DataType != ComparingType.Int)
			{
				return null;
			}
			return (int)Value;
		}
		set
		{
			if (DataType == ComparingType.Int && value.HasValue)
			{
				Value = value;
			}
		}
	}

	[ProtoMember(14, IsRequired = false)]
	private double? ProtoDynamicPropertySurrogateDouble
	{
		get
		{
			if (DataType != ComparingType.Double)
			{
				return null;
			}
			return (double)Value;
		}
		set
		{
			if (DataType == ComparingType.Double && value.HasValue)
			{
				Value = value;
			}
		}
	}

	[ProtoMember(15, IsRequired = false)]
	private long? ProtoDynamicPropertySurrogateLong
	{
		get
		{
			if (DataType != ComparingType.Long)
			{
				return null;
			}
			return (long)Value;
		}
		set
		{
			if (DataType == ComparingType.Long && value.HasValue)
			{
				Value = value;
			}
		}
	}

	[ProtoMember(16, IsRequired = false)]
	private DateTime? ProtoDynamicPropertySurrogateDateTime
	{
		get
		{
			if (DataType != ComparingType.DateTime)
			{
				return null;
			}
			return (DateTime)Value;
		}
		set
		{
			if (DataType == ComparingType.DateTime && value.HasValue)
			{
				Value = value;
			}
		}
	}

	[ProtoMember(17, IsRequired = false)]
	private bool? ProtoDynamicPropertySurrogateBoolean
	{
		get
		{
			if (DataType != ComparingType.Boolean)
			{
				return null;
			}
			return (bool)Value;
		}
		set
		{
			if (DataType == ComparingType.Boolean && value.HasValue)
			{
				Value = value;
			}
		}
	}

	/// <summary>
	/// Gets or Sets the editing info.
	/// </summary>
	public EditingInfo EditingInfo
	{
		[CompilerGenerated]
		get
		{
			return 녞녖;
		}
		[CompilerGenerated]
		set
		{
			녞녖 = value;
		}
	}

	/// <summary>
	/// Gets or Sets the formatting description.
	/// </summary>
	public IFormattingDescription FormattingDescription
	{
		[CompilerGenerated]
		get
		{
			return 놫녴;
		}
		[CompilerGenerated]
		set
		{
			놫녴 = value;
		}
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="T:TradingPlatform.BusinessLayer.AdditionalInfoItem" /> class.
	/// </summary>
	public AdditionalInfoItem()
	{
		Visible = true;
	}

	/// <summary>
	///
	/// </summary>
	/// <param name="item">The item.</param>
	public virtual void Update(AdditionalInfoItem item)
	{
		GroupInfo = item.GroupInfo;
		SortIndex = item.SortIndex;
		NameKey = item.NameKey;
		ToolTipKey = item.ToolTipKey;
		DataType = item.DataType;
		Value = item.Value;
		Hidden = item.Hidden;
		Visible = item.Visible;
		IsLink = item.IsLink;
		Id = item.Id;
		FormatingType = item.FormatingType;
		CustomAssetID = item.CustomAssetID;
		EditingInfo = ((item.EditingInfo == null) ? null : new EditingInfo(item.EditingInfo));
		FormattingDescription = item.FormattingDescription;
	}

	/// <summary>
	///
	/// </summary>
	/// <returns>An object.</returns>
	public object Clone()
	{
		AdditionalInfoItem additionalInfoItem = new AdditionalInfoItem();
		additionalInfoItem.Update(this);
		return additionalInfoItem;
	}

	/// <summary>
	/// To the XML element.
	/// </summary>
	/// <returns>A XElement.</returns>
	public XElement ToXElement()
	{
		XElement xElement = new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶놁());
		xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶녭(), Id));
		xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶녱(), GroupInfo));
		xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶놲(), SortIndex));
		xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶높(), NameKey));
		xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶놶(), ToolTipKey));
		xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶뇏(), (int)DataType));
		xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴놯(), Value));
		xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놥(), Hidden));
		xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶녻(), (int)FormatingType));
		xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶녙(), CustomAssetID));
		xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶놢(), Visible));
		xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶녧(), IsLink));
		return xElement;
	}

	/// <summary>
	/// From the XML element.
	/// </summary>
	/// <param name="element">The element.</param>
	/// <param name="deserializationInfo">The deserialization info.</param>
	public void FromXElement(XElement element, DeserializationInfo deserializationInfo)
	{
		XElement xElement = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶녭());
		if (xElement != null)
		{
			Id = xElement.Value;
		}
		XElement xElement2 = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶녱());
		if (xElement2 != null)
		{
			GroupInfo = xElement2.Value;
		}
		XElement xElement3 = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶놲());
		if (xElement3 != null)
		{
			SortIndex = xElement3.ToInt();
		}
		XElement xElement4 = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶높());
		if (xElement4 != null)
		{
			NameKey = xElement4.Value;
		}
		XElement xElement5 = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶놶());
		if (xElement5 != null)
		{
			ToolTipKey = xElement5.Value;
		}
		XElement xElement6 = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶뇏());
		if (xElement6 != null)
		{
			DataType = (ComparingType)xElement6.ToInt();
		}
		XElement xElement7 = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴놯());
		if (xElement7 != null)
		{
			Value = DataType switch
			{
				ComparingType.Int => xElement7.ToInt(), 
				ComparingType.Double => xElement7.ToDouble(), 
				ComparingType.Long => xElement7.ToLong(), 
				ComparingType.DateTime => xElement7.ToDateTime(), 
				ComparingType.Boolean => xElement7.ToBool(), 
				_ => xElement7.Value, 
			};
		}
		XElement xElement8 = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놥());
		if (xElement8 != null)
		{
			Hidden = xElement8.ToBool();
		}
		XElement xElement9 = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶녻());
		if (xElement9 != null)
		{
			FormatingType = (AdditionalInfoItemFormatingType)xElement9.ToInt();
		}
		XElement xElement10 = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶녙());
		if (xElement10 != null)
		{
			CustomAssetID = xElement10.Value;
		}
		XElement xElement11 = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶놢());
		if (xElement11 != null)
		{
			Visible = xElement11.ToBool();
		}
		XElement xElement12 = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶녧());
		if (xElement12 != null)
		{
			IsLink = xElement12.ToBool();
		}
	}

	/// <summary>
	/// To the string.
	/// </summary>
	/// <returns>A string.</returns>
	public override string ToString()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(38, 4);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶녤());
		defaultInterpolatedStringHandler.AppendFormatted(Id);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶놆());
		defaultInterpolatedStringHandler.AppendFormatted(GroupInfo);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶뇎());
		defaultInterpolatedStringHandler.AppendFormatted(Visible);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶놷());
		defaultInterpolatedStringHandler.AppendFormatted(Hidden);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	public bool Equals(AdditionalInfoItem other)
	{
		if (other == null)
		{
			return false;
		}
		if (this == other)
		{
			return true;
		}
		if (NameKey == other.NameKey)
		{
			return object.Equals(Value, other.Value);
		}
		return false;
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
		return Equals((AdditionalInfoItem)obj);
	}

	public override int GetHashCode()
	{
		return HashCode.Combine(NameKey, Value);
	}
}
