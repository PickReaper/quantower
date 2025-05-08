using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;

namespace TradingPlatform.BusinessLayer;

/// <summary>
/// The account extensions.
/// </summary>
public static class AccountExtensions
{
	/// <summary>
	/// Returns a custom name if available otherwise, returns the name.
	/// </summary>
	/// <param name="account">The account.</param>
	public static string GetCurrentName(this Account account)
	{
		string text = Core.Instance.CustomAccountPropertiesProvider.GetProperty(account, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놛()) as string;
		if (!string.IsNullOrEmpty(text))
		{
			return text;
		}
		return account.Name;
	}

	/// <summary>
	/// Returns information about whether the account supports trading operations
	/// </summary>
	/// <param name="account">The account.</param>
	public static bool IsLocked(this Account account)
	{
		return Core.Instance.CustomAccountPropertiesProvider.GetProperty(account, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놼()) as bool? == true;
	}
}
