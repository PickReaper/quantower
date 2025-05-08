using System;

namespace TradingPlatform.BusinessLayer;

public interface ISessionsContainer
{
	ISession[] ActiveSessions { get; }

	TimeZoneInfo TimeZone { get; }

	ISession[] GetSessionsForDate(DateTime dateTime);
}
