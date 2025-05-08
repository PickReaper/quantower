using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using TradingPlatform.BusinessLayer.Integration;

namespace TradingPlatform.BusinessLayer;

/// <summary>
/// The account operation.
/// </summary>
public class AccountOperation : BusinessObject, IComparable
{
	[CompilerGenerated]
	private string 놄농;

	[CompilerGenerated]
	private string 놄념;

	[CompilerGenerated]
	private IList<SettingItem> 놄녨;

	private AccountOperationUpdateHandler 놄녺;

	private AccountOperationConfirmationHandler 놄놣;

	private AccountOperationExecuteHandler 놄녮;

	/// <summary>
	/// Gets the name.
	/// </summary>
	public string Name
	{
		[CompilerGenerated]
		get
		{
			return 놄농;
		}
		[CompilerGenerated]
		private set
		{
			놄농 = value;
		}
	}

	/// <summary>
	/// Gets the button text.
	/// </summary>
	public string ButtonText
	{
		[CompilerGenerated]
		get
		{
			return 놄념;
		}
		[CompilerGenerated]
		private set
		{
			놄념 = value;
		}
	}

	/// <summary>
	/// Gets the settings.
	/// </summary>
	public IList<SettingItem> Settings
	{
		[CompilerGenerated]
		get
		{
			return 놄녨;
		}
		[CompilerGenerated]
		private set
		{
			놄녨 = value;
		}
	}

	internal AccountOperation(string P_0)
		: base(P_0)
	{
	}

	/// <summary>
	///
	/// </summary>
	/// <param name="settings">The settings.</param>
	public void Update(IList<SettingItem> settings)
	{
		놄녺?.Invoke(settings);
	}

	/// <summary>
	/// Builds the confirmation.
	/// </summary>
	/// <param name="settings">The settings.</param>
	/// <returns>A string.</returns>
	public string BuildConfirmation(IList<SettingItem> settings)
	{
		return 놄놣?.Invoke(settings);
	}

	/// <summary>
	///
	/// </summary>
	/// <param name="settings">The settings.</param>
	public void Execute(IList<SettingItem> settings)
	{
		놄녮?.Invoke(settings);
	}

	internal void 녴(MessageAccountOperation P_0)
	{
		Name = P_0.Name;
		ButtonText = P_0.ButtonText;
		Settings = P_0.Settings.DeepCopy().ToList();
		놄녺 = P_0.UpdateHandler;
		놄놣 = P_0.BuildConfirmationHandler;
		놄녮 = P_0.ExecuteHandler;
	}

	/// <summary>
	/// Compare to.
	/// </summary>
	/// <param name="obj">The obj.</param>
	/// <returns>An int.</returns>
	public int CompareTo(object obj)
	{
		if (!(obj is AccountOperation accountOperation))
		{
			return 0;
		}
		return string.Compare(Name, accountOperation.Name, StringComparison.Ordinal);
	}
}
