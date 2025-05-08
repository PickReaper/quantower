using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;

namespace TradingPlatform.BusinessLayer;

public class CustomHoliday : ICustomizable
{
	[CompilerGenerated]
	private bool 녶놭;

	[CompilerGenerated]
	private string 녶녲;

	[CompilerGenerated]
	private DateTime 녶뇋;

	public bool IsActive
	{
		[CompilerGenerated]
		get
		{
			return 녶놭;
		}
		[CompilerGenerated]
		set
		{
			녶놭 = value;
		}
	}

	public string Name
	{
		[CompilerGenerated]
		get
		{
			return 녶녲;
		}
		[CompilerGenerated]
		set
		{
			녶녲 = value;
		}
	}

	public DateTime Date
	{
		[CompilerGenerated]
		get
		{
			return 녶뇋;
		}
		[CompilerGenerated]
		set
		{
			녶뇋 = value;
		}
	}

	public IList<SettingItem> Settings
	{
		get
		{
			return new List<SettingItem>
			{
				new SettingItemBoolean(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭놫(), IsActive),
				new SettingItemString(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놝(), Name),
				new SettingItemDateTime(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭녪(), Date)
			};
		}
		set
		{
			IsActive = value.GetValueOrDefault(IsActive, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭놫());
			Name = value.GetValueOrDefault(Name, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놝());
			Date = value.GetValueOrDefault(Date, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭녪());
		}
	}
}
