using System.Collections.Generic;
using System.Threading;

namespace TradingPlatform.BusinessLayer;

public delegate string UpdateAuthorityUrlDelegate(IEnumerable<SettingItem> settings, CancellationToken token);
