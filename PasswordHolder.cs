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
public class PasswordHolder : IXElementSerialization, ICloneable
{
	[CompilerGenerated]
	private string 녵놀;

	[CompilerGenerated]
	private bool 녵놔 = true;

	[CompilerGenerated]
	private string 녵놾;

	[CompilerGenerated]
	private bool 녵뇀;

	public string Password
	{
		[CompilerGenerated]
		get
		{
			return 녵놀;
		}
		[CompilerGenerated]
		set
		{
			녵놀 = value;
		}
	}

	[DataMember(Name = "Password")]
	private string EncryptedPassword
	{
		get
		{
			if (!SavePassword)
			{
				return string.Empty;
			}
			return Encryptor.녴(Password);
		}
		set
		{
			Password = Encryptor.놴(value);
		}
	}

	[DataMember(Name = "SavePassword")]
	public bool SavePassword
	{
		[CompilerGenerated]
		get
		{
			return 녵놔;
		}
		[CompilerGenerated]
		set
		{
			녵놔 = value;
		}
	}

	public string RecoverUrl
	{
		[CompilerGenerated]
		get
		{
			return 녵놾;
		}
		[CompilerGenerated]
		internal set
		{
			녵놾 = value;
		}
	}

	public bool FailedToRestorePassword
	{
		[CompilerGenerated]
		get
		{
			return 녵뇀;
		}
		[CompilerGenerated]
		private set
		{
			녵뇀 = value;
		}
	}

	public PasswordHolder(string Password = "", bool SavePassword = true, string recoverUrl = "")
	{
		this.Password = Password;
		this.SavePassword = SavePassword;
		RecoverUrl = recoverUrl;
	}

	public object Clone()
	{
		return new PasswordHolder(Password, SavePassword, RecoverUrl);
	}

	public XElement ToXElement()
	{
		XElement xElement = new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭놟());
		xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭녓(), EncryptedPassword));
		xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭녛(), SavePassword));
		return xElement;
	}

	public void FromXElement(XElement element, DeserializationInfo deserializationInfo)
	{
		EncryptedPassword = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭녓()).Value;
		SavePassword = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭녛()).ToBool();
		if (!string.IsNullOrEmpty(element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭녓()).Value) && string.IsNullOrEmpty(EncryptedPassword))
		{
			FailedToRestorePassword = true;
		}
	}
}
