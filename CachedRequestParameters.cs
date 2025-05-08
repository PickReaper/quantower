namespace TradingPlatform.BusinessLayer;

public abstract class CachedRequestParameters : RequestParameters
{
	public abstract int GetCacheKey();

	protected CachedRequestParameters()
	{
	}

	protected CachedRequestParameters(CachedRequestParameters origin)
		: base(origin)
	{
	}
}
