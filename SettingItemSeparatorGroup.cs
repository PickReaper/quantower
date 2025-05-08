namespace TradingPlatform.BusinessLayer;

/// <summary>
/// Typecasts setting as GroupBox item
/// </summary>
[Published]
public sealed class SettingItemSeparatorGroup : SettingItemVisualGroup
{
	private string 놵놳;

	public string Key
	{
		get
		{
			if (string.IsNullOrEmpty(놵놳))
			{
				return base.Text;
			}
			return 놵놳;
		}
		set
		{
			놵놳 = value;
		}
	}

	public SettingItemSeparatorGroup(string text = "", int sortIndex = 0)
		: base(text, sortIndex)
	{
	}
}
