using IdentityModel.OidcClient;

namespace TradingPlatform.BusinessLayer;

public static class OidcClientOptionsExtensions
{
	public static OidcClientOptions GetCopy(this OidcClientOptions oidc)
	{
		return new OidcClientOptions
		{
			Authority = oidc.Authority,
			ClientId = oidc.ClientId,
			ClientSecret = oidc.ClientSecret,
			RedirectUri = oidc.RedirectUri,
			PostLogoutRedirectUri = oidc.PostLogoutRedirectUri,
			Scope = oidc.Scope,
			ClockSkew = oidc.ClockSkew,
			LoadProfile = oidc.LoadProfile,
			ProviderInformation = oidc.ProviderInformation?.GetCopy()
		};
	}

	public static ProviderInformation GetCopy(this ProviderInformation providerInformation)
	{
		return new ProviderInformation
		{
			IssuerName = providerInformation.IssuerName,
			AuthorizeEndpoint = providerInformation.AuthorizeEndpoint,
			TokenEndpoint = providerInformation.TokenEndpoint,
			EndSessionEndpoint = providerInformation.EndSessionEndpoint,
			KeySet = providerInformation.KeySet
		};
	}
}
