using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Xml.Linq;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using Platform.Utils;
using TradingPlatform.BusinessLayer.Serialization;

namespace TradingPlatform.BusinessLayer;

[Serializable]
[DataContract]
public class BusinessObjectInfo : IXElementSerialization, IEquatable<BusinessObjectInfo>
{
	[CompilerGenerated]
	private string 놫놯;

	[CompilerGenerated]
	private string 놫녾;

	[CompilerGenerated]
	private string 놫녬;

	[DataMember(Name = "Id")]
	public string Id
	{
		[CompilerGenerated]
		get
		{
			return 놫놯;
		}
		[CompilerGenerated]
		internal set
		{
			놫놯 = value;
		}
	}

	[DataMember(Name = "ConnectionId")]
	public string ConnectionId
	{
		[CompilerGenerated]
		get
		{
			return 놫녾;
		}
		[CompilerGenerated]
		internal set
		{
			놫녾 = value;
		}
	}

	[DataMember(Name = "Name")]
	public string Name
	{
		[CompilerGenerated]
		get
		{
			return 놫녬;
		}
		[CompilerGenerated]
		internal set
		{
			놫녬 = value;
		}
	}

	protected virtual bool NeedToEncryptInfo => false;

	public static BusinessObjectInfo Empty => new BusinessObjectInfo
	{
		Id = string.Empty,
		ConnectionId = string.Empty,
		Name = string.Empty
	};

	public virtual XElement ToXElement()
	{
		XElement xElement = new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶녬());
		xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶녭(), NeedToEncryptInfo ? Encryptor.녴(Id) : Id));
		xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놎뇉(), ConnectionId));
		xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놵(), NeedToEncryptInfo ? Encryptor.녴(Name) : Name));
		return xElement;
	}

	public virtual void FromXElement(XElement element, DeserializationInfo deserializationInfo)
	{
		string value = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶녭()).Value;
		if (NeedToEncryptInfo)
		{
			string text = Encryptor.놴(value);
			if (text != null)
			{
				Id = text;
				goto IL_0038;
			}
		}
		Id = value;
		goto IL_0038;
		IL_0038:
		ConnectionId = ConnectionsManager.녪녬.녴(element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놎뇉()).Value);
		string value2 = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놵()).Value;
		if (NeedToEncryptInfo)
		{
			string text2 = Encryptor.놴(value2);
			if (text2 != null)
			{
				Name = text2;
				return;
			}
		}
		Name = value2;
	}

	public override string ToString()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(6, 3);
		defaultInterpolatedStringHandler.AppendFormatted(ConnectionId);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놎놖());
		defaultInterpolatedStringHandler.AppendFormatted(Id);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놎놖());
		defaultInterpolatedStringHandler.AppendFormatted(Name);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	public bool Equals(BusinessObjectInfo other)
	{
		if ((object)other == null)
		{
			return false;
		}
		if ((object)this == other)
		{
			return true;
		}
		if (Id == other.Id && ConnectionId == other.ConnectionId)
		{
			return Name == other.Name;
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
		return Equals((BusinessObjectInfo)obj);
	}

	public override int GetHashCode()
	{
		return HashCode.Combine(Id, ConnectionId, Name);
	}

	public static bool operator ==(BusinessObjectInfo left, BusinessObjectInfo right)
	{
		return object.Equals(left, right);
	}

	public static bool operator !=(BusinessObjectInfo left, BusinessObjectInfo right)
	{
		return !object.Equals(left, right);
	}
}
