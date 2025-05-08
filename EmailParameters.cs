namespace TradingPlatform.BusinessLayer;

/// <summary>
/// Все параметры, которые могут использоваться при отправке email
/// </summary>
public class EmailParameters
{
	public string[] address;

	public string subject;

	public string text;

	public string[] fileNames;

	public bool asFile;

	public SendMailCallbackDelegate callBack;
}
