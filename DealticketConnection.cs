using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using TradingPlatform.BusinessLayer.Integration;

namespace TradingPlatform.BusinessLayer;

public sealed class DealticketConnection : DealTicket, IConnectionBindedObject, ILoggable
{
	private readonly string 놫녠;

	string IConnectionBindedObject.ConnectionId => 놫녠;

	public string Event => base.Header;

	public string Message => _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶녠() + base.Description + _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶놠();

	public DealticketConnection(string connectionId, MessageDealTicket message)
	{
		놫녠 = connectionId;
		base.Header = message.Header;
		base.Description = message.Description;
		base.Type = message.DealTicketType;
	}
}
