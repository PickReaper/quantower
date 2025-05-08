using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Xml.Linq;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using IdentityModel.Client;
using IdentityModel.OidcClient;
using TradingPlatform.BusinessLayer.Serialization;

namespace TradingPlatform.BusinessLayer;

[DataContract]
public class SettingItemOAuth : SettingItem
{
	[CompilerGenerated]
	private readonly OidcClientOptions 놻노;

	[CompilerGenerated]
	private readonly UpdateAuthorityUrlDelegate 놻녒;

	[CompilerGenerated]
	private readonly bool 놻녕;

	[CompilerGenerated]
	private readonly Parameters 놻녖;

	public override SettingItemType Type => SettingItemType.OAuth;

	[DataMember(Name = "Value")]
	private OAuthResult OAuthResultHolder
	{
		get
		{
			return (OAuthResult)Value;
		}
		set
		{
			Value = value;
		}
	}

	public OidcClientOptions OidcOptions
	{
		[CompilerGenerated]
		get
		{
			return 놻노;
		}
	}

	internal UpdateAuthorityUrlDelegate UpdateIdentityAuthorityUrl
	{
		[CompilerGenerated]
		get
		{
			return 놻녒;
		}
	}

	internal bool AllowOpenNewWindow
	{
		[CompilerGenerated]
		get
		{
			return 놻녕;
		}
	}

	internal Parameters BackChannelExtraParameters
	{
		[CompilerGenerated]
		get
		{
			return 놻녖;
		}
	}

	public SettingItemOAuth()
	{
	}

	public SettingItemOAuth(string name, OAuthResult passwordHolder, OidcClientOptions oidcClientOptions, int sortIndex = 0, UpdateAuthorityUrlDelegate updateIdentityAuthorityUrl = null, bool allowOpenNewWindow = false, Parameters backChannelExtraParameters = null)
		: base(name, passwordHolder, sortIndex)
	{
		놻노 = oidcClientOptions;
		놻녒 = updateIdentityAuthorityUrl;
		놻녕 = allowOpenNewWindow;
		놻녖 = backChannelExtraParameters;
	}

	protected SettingItemOAuth(SettingItemOAuth settingItem)
		: base(settingItem)
	{
		놻노 = settingItem.OidcOptions;
		놻녒 = settingItem.UpdateIdentityAuthorityUrl;
		놻녕 = settingItem.AllowOpenNewWindow;
		놻녖 = settingItem.BackChannelExtraParameters;
	}

	public override SettingItem GetCopy()
	{
		return new SettingItemOAuth(this);
	}

	protected override bool IsValueTypeValid(object value)
	{
		return value is OAuthResult;
	}

	protected override void ValueFromXElement(XElement element, DeserializationInfo deserializationInfo)
	{
		OAuthResult oAuthResult = new OAuthResult();
		XElement xElement = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭녹());
		if (xElement != null)
		{
			oAuthResult.FromXElement(xElement, deserializationInfo);
			OAuthResultHolder = oAuthResult;
		}
	}
}
