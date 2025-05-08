using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Xml.Linq;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using IdentityModel.Client;
using IdentityModel.OidcClient;
using IdentityModel.OidcClient.Results;
using Platform.Utils;
using TradingPlatform.BusinessLayer.Serialization;

namespace TradingPlatform.BusinessLayer;

[Serializable]
[DataContract]
public class OAuthResult : IXElementSerialization, ICloneable
{
	[CompilerGenerated]
	private string 녵놡;

	[CompilerGenerated]
	private string 녵놻;

	[CompilerGenerated]
	private string 녵놃;

	[CompilerGenerated]
	private bool 녵뇇;

	public string AccessToken
	{
		[CompilerGenerated]
		get
		{
			return 녵놡;
		}
		[CompilerGenerated]
		private set
		{
			녵놡 = value;
		}
	}

	internal string RefreshToken
	{
		[CompilerGenerated]
		get
		{
			return 녵놻;
		}
		[CompilerGenerated]
		private set
		{
			녵놻 = value;
		}
	}

	internal string IdentityToken
	{
		[CompilerGenerated]
		get
		{
			return 녵놃;
		}
		[CompilerGenerated]
		private set
		{
			녵놃 = value;
		}
	}

	internal LoginResult RequestTokenResult
	{
		set
		{
			AccessToken = value.AccessToken;
			RefreshToken = value.RefreshToken;
			IdentityToken = value.IdentityToken;
		}
	}

	internal RefreshTokenResult RequestRefreshResult
	{
		set
		{
			AccessToken = value.AccessToken;
			RefreshToken = value.RefreshToken;
			IdentityToken = value.IdentityToken;
		}
	}

	internal TokenResponse TokenResponce
	{
		set
		{
			AccessToken = value.AccessToken;
			RefreshToken = value.RefreshToken;
			IdentityToken = value.IdentityToken;
		}
	}

	public bool UseSavedTokens
	{
		[CompilerGenerated]
		get
		{
			return 녵뇇;
		}
		[CompilerGenerated]
		set
		{
			녵뇇 = value;
		}
	}

	[DataMember(Name = "EncryptedRefreshToken")]
	private string EncryptedRefreshToken
	{
		get
		{
			if (!UseSavedTokens)
			{
				return string.Empty;
			}
			return Encryptor.녴(RefreshToken);
		}
		set
		{
			RefreshToken = Encryptor.놴(value);
		}
	}

	public OAuthResult()
	{
		AccessToken = string.Empty;
		UseSavedTokens = true;
	}

	public OAuthResult(string accessToken)
	{
		AccessToken = accessToken;
		UseSavedTokens = true;
	}

	internal OAuthResult(string P_0, string P_1)
	{
		AccessToken = P_0;
		RefreshToken = P_1;
		UseSavedTokens = true;
	}

	public XElement ToXElement()
	{
		XElement xElement = new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭녹());
		xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭녔(), EncryptedRefreshToken));
		xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭녠(), UseSavedTokens));
		return xElement;
	}

	public void FromXElement(XElement element, DeserializationInfo deserializationInfo)
	{
		EncryptedRefreshToken = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭녔()).Value;
		UseSavedTokens = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭녠()).ToBool();
	}

	public object Clone()
	{
		return new OAuthResult
		{
			UseSavedTokens = UseSavedTokens,
			AccessToken = AccessToken,
			RefreshToken = RefreshToken,
			IdentityToken = IdentityToken
		};
	}
}
