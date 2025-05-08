using System.IO;

namespace TradingPlatform.BusinessLayer;

public interface IBrandingInformation
{
	string ApplicationName { get; }

	string ApplicationID { get; }

	string CopyrightDetails { get; }

	string PrivacePolicyUrl { get; }

	string TermsOfUseUrl { get; }

	string OfficialWebSite { get; }

	string LiveChatUrl { get; }

	string UpdateUrl { get; }

	string PricingPageUrl { get; }

	string AccountDashboardUrl { get; }

	string WelcomeScreenText { get; }

	string HelpCustomURL { get; }

	string GitCustomURL { get; }

	string ReleaseNotesURL { get; }

	BrandingInformationHelpLink[] HelpLinks { get; }

	bool IsGrayLabel { get; }

	/// <summary>
	/// Get all available custom resources
	/// </summary>        
	string[] GetResourceNames();

	/// <summary>
	/// Get custom resource stream by name
	/// </summary>
	Stream GetResource(string resourceName);

	/// <summary>
	/// Check whether specified items was hidden by branding specification
	/// </summary>        
	/// <returns></returns>
	bool IsItemHidden(string itemType, string itemName);
}
