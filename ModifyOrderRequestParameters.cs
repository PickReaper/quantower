using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;

namespace TradingPlatform.BusinessLayer;

[Published]
public class ModifyOrderRequestParameters : OrderRequestParameters
{
	[CompilerGenerated]
	private string 놻녩;

	public override RequestType Type => RequestType.ModifyOrder;

	public override string Event
	{
		get
		{
			if (base.OrderType == null)
			{
				return string.Empty;
			}
			return base.OrderType.Name + _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰놳();
		}
	}

	/// <summary>
	/// Id of the order
	/// </summary>
	public string OrderId
	{
		[CompilerGenerated]
		get
		{
			return 놻녩;
		}
		[CompilerGenerated]
		set
		{
			놻녩 = value;
		}
	}

	[NotPublished]
	public ModifyOrderRequestParameters()
	{
	}

	public ModifyOrderRequestParameters(IOrder order)
		: base(order)
	{
		OrderId = order.Id;
		base.Quantity = order.RemainingQuantity;
	}

	public ModifyOrderRequestParameters(ModifyOrderRequestParameters original)
		: base(original)
	{
		OrderId = original.OrderId;
	}

	public override object Clone()
	{
		return new ModifyOrderRequestParameters(this);
	}

	public override string ToString()
	{
		return OrderId + _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂녙() + base.ToString() + _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놢();
	}
}
