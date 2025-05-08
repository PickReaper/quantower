using System;

namespace TradingPlatform.BusinessLayer;

public interface ISession
{
	string Name { get; }

	SessionType Type { get; }

	TimeSpan OpenTime { get; }

	TimeSpan CloseTime { get; }

	bool IsPrimary { get; }
}
