namespace TradingPlatform.BusinessLayer;

public interface IRenamable
{
	string Name { get; set; }

	bool IsNameAllowed(string s, ref string error);
}
