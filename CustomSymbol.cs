using System;

namespace TradingPlatform.BusinessLayer;

/// <summary>
/// Base class for all Custom symbols: Synthetics, Custom Formulas, etc.
/// </summary>
public class CustomSymbol : Symbol, IDisposable
{
	public CustomSymbol(string connectionID)
		: base(connectionID)
	{
		base.Id = Guid.NewGuid().ToString();
	}

	public virtual void Dispose()
	{
	}
}
