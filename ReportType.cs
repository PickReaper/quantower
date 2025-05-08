using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TradingPlatform.BusinessLayer.Integration;

namespace TradingPlatform.BusinessLayer;

/// <summary>
/// Defines report request parameters from <see cref="P:TradingPlatform.BusinessLayer.ICustomizable.Settings" /> which can be used in <see cref="T:TradingPlatform.BusinessLayer.ReportRequestParameters" />
/// </summary>
public class ReportType : BusinessObject, IComparable, ICustomizable
{
	[CompilerGenerated]
	private int 놰놀;

	[CompilerGenerated]
	private string 놰놔;

	private IList<SettingItem> 놰놾;

	/// <summary>
	/// Gets report Id
	/// </summary>
	public int Id
	{
		[CompilerGenerated]
		get
		{
			return 놰놀;
		}
		[CompilerGenerated]
		private set
		{
			놰놀 = value;
		}
	}

	/// <summary>
	/// Gets report Name
	/// </summary>
	public string Name
	{
		[CompilerGenerated]
		get
		{
			return 놰놔;
		}
		[CompilerGenerated]
		private set
		{
			놰놔 = value;
		}
	}

	/// <summary>
	/// <see cref="T:TradingPlatform.BusinessLayer.ICustomizable" /> report settings 
	/// </summary>
	public IList<SettingItem> Settings
	{
		get
		{
			return 놰놾;
		}
		set
		{
			놰놾 = new List<SettingItem>();
			foreach (SettingItem item in value)
			{
				놰놾.Add(item.GetCopy());
			}
		}
	}

	internal ReportType(string P_0)
		: base(P_0)
	{
		놰놾 = new List<SettingItem>();
	}

	internal void 녴(MessageReportType P_0)
	{
		Id = P_0.Id;
		Name = P_0.Name;
		if (놰놾 == null)
		{
			놰놾 = new List<SettingItem>();
		}
		foreach (SettingItem parameter in P_0.Parameters)
		{
			놰놾.Add(parameter);
		}
	}

	internal ReportType 녴()
	{
		return new ReportType(base.ConnectionId)
		{
			Id = Id,
			Name = Name,
			Settings = Settings
		};
	}

	public int CompareTo(object obj)
	{
		return 0;
	}
}
