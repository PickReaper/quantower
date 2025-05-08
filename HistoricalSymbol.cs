using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using TradingPlatform.BusinessLayer.History.Storage;
using TradingPlatform.BusinessLayer.Integration;
using TradingPlatform.BusinessLayer.Serialization;
using TradingPlatform.BusinessLayer.Utils;
using 녴;

namespace TradingPlatform.BusinessLayer;

public sealed class HistoricalSymbol : CustomSymbol, IHistoryDataReceiver, IXElementSerialization, IHistoryStorage
{
	public const string HISTORICAL_SYMBOL_CONNECTION_ID = "HISTORICAL_SYMBOL_CONNECTION_ID";

	private string 뇇놿;

	private HistoryStorage 뇇놄;

	public HistoricalSymbol()
		: base(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵놙())
	{
		base.Id = null;
		녴();
		base.Exchange = new Exchange(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵놙());
		base.Exchange.녴(new MessageExchange
		{
			Id = _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂뇀(),
			ExchangeName = _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰놬(),
			SortIndex = -1
		});
	}

	public void SetLocalStoragePath(string path)
	{
		if (!(뇇놿 == path))
		{
			뇇놄?.Dispose();
			뇇놿 = path;
			뇇놄 = HistoryStorage.Create(뇇놿);
			녴();
		}
	}

	private new void 녴()
	{
		if (string.IsNullOrEmpty(뇇놿))
		{
			historyMetadata = new HistoryMetadata();
			return;
		}
		HashSet<string> hashSet = new HashSet<string>();
		HashSet<Period> hashSet2 = new HashSet<Period>();
		HashSet<Period> hashSet3 = new HashSet<Period>();
		HashSet<HistoryType> hashSet4 = new HashSet<HistoryType>();
		HashSet<HistoryType> hashSet5 = new HashSet<HistoryType>();
		foreach (HistoryDescription allAvailableHistoryDescription in 뇇놄.GetAllAvailableHistoryDescriptions())
		{
			HistoryStorageInfo info = 뇇놄.GetInfo(allAvailableHistoryDescription, HistoryStorageInfoScope.StoredIntervals);
			if (info.StoredIntervals == null || !info.StoredIntervals.Any())
			{
				continue;
			}
			hashSet.Add(allAvailableHistoryDescription.Aggregation.Name);
			HistoryAggregation aggregation = allAvailableHistoryDescription.Aggregation;
			if (!(aggregation is HistoryAggregationTime historyAggregationTime))
			{
				if (!(aggregation is HistoryAggregationTick historyAggregationTick))
				{
					if (!(aggregation is HistoryAggregationTimeStatistics historyAggregationTimeStatistics))
					{
						if (aggregation is HistoryAggregationVolumeProfile historyAggregationVolumeProfile)
						{
							hashSet3.Add(historyAggregationVolumeProfile.Period);
						}
					}
					else
					{
						hashSet3.Add(historyAggregationTimeStatistics.Period);
					}
				}
				else
				{
					hashSet5.Add(historyAggregationTick.HistoryType);
				}
			}
			else
			{
				hashSet2.Add(historyAggregationTime.Period);
				hashSet4.Add(historyAggregationTime.HistoryType);
			}
		}
		historyMetadata = new HistoryMetadata
		{
			AllowedAggregations = hashSet.ToArray(),
			AllowedPeriodsHistoryAggregationTime = hashSet2.ToArray(),
			AllowedHistoryTypesHistoryAggregationTime = hashSet4.ToArray(),
			AllowedHistoryTypesHistoryAggregationTick = hashSet5.ToArray(),
			AllowedPeriodsHistoryAggregationTimeStatistics = hashSet3.ToArray(),
			DownloadingStep_Tick = TimeSpan.FromDays(1.0)
		};
	}

	private protected override HistoricalData 녴(HistoryRequestParameters P_0)
	{
		return new 놳(P_0, 뇇놄);
	}

	public override List<OrderType> GetAlowedOrderTypes(OrderTypeUsage? usage)
	{
		return new List<OrderType>();
	}

	public IList<HistoryInterval> Load(HistoryRequestParameters requestParameters, out List<HistoryRequestParameters> historyParametersForServerRequest)
	{
		historyParametersForServerRequest = new List<HistoryRequestParameters> { requestParameters };
		return 뇇놄?.Load(requestParameters, out historyParametersForServerRequest);
	}

	public void Save(HistoryInterval historyInterval, bool wait = false)
	{
		if (뇇놄 != null)
		{
			뇇놄.Save(historyInterval, wait);
			녴();
		}
	}

	public void Delete(HistoryDescription description, Interval<DateTime> interval, bool wait = false)
	{
		if (뇇놄 != null)
		{
			뇇놄.Delete(description, interval, wait);
			뇇놄.녴();
			녴();
		}
	}

	public HistoryStorageInfo GetInfo(HistoryDescription description, HistoryStorageInfoScope scope)
	{
		return 뇇놄?.GetInfo(description, scope);
	}

	public List<HistoryDescription> GetAllAvailableHistoryDescriptions()
	{
		return 뇇놄.GetAllAvailableHistoryDescriptions();
	}

	public XElement ToXElement()
	{
		XElement xElement = new XElement(GetType().Name);
		xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶놐(), GetType().Name));
		xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰놊(), 뇇놿));
		MessageSymbol messageSymbol = ((IMessageBuilder<MessageSymbol>)this).BuildMessage();
		xElement.Add(messageSymbol.ToXElement());
		if (base.Product != null)
		{
			xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰놪(), ((IMessageBuilder<MessageAsset>)base.Product).BuildMessage().ToXElement()));
		}
		if (base.QuotingCurrency != null)
		{
			xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰놌(), ((IMessageBuilder<MessageAsset>)base.QuotingCurrency).BuildMessage().ToXElement()));
		}
		return xElement;
	}

	public void FromXElement(XElement element, DeserializationInfo deserializationInfo)
	{
		XElement xElement = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰놊());
		if (xElement != null)
		{
			SetLocalStoragePath(xElement.Value);
		}
		string text = _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰놕();
		XElement xElement2 = ((!(element.Name == text)) ? element.Element(text) : element);
		if (xElement2 != null)
		{
			MessageSymbol messageSymbol = new MessageSymbol(base.Id);
			messageSymbol.FromXElement(xElement2, deserializationInfo);
			녴(messageSymbol);
		}
		XElement xElement3 = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰놪());
		if (xElement3 != null)
		{
			XElement xElement4 = xElement3.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶놁());
			if (xElement4 != null)
			{
				Asset asset = new Asset(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵놙());
				MessageAsset messageAsset = new MessageAsset();
				messageAsset.FromXElement(xElement4, deserializationInfo);
				asset.녴(messageAsset);
				base.Product = asset;
			}
		}
		XElement xElement5 = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰놌());
		if (xElement5 != null)
		{
			XElement xElement6 = xElement5.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶놁());
			if (xElement6 != null)
			{
				Asset asset2 = new Asset(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵놙());
				MessageAsset messageAsset2 = new MessageAsset();
				messageAsset2.FromXElement(xElement6, deserializationInfo);
				asset2.녴(messageAsset2);
				base.QuotingCurrency = asset2;
			}
		}
		녴();
	}

	public void SaveHistory(HistoryHolder historyHolderFromProvider)
	{
		try
		{
			Save(new HistoryInterval
			{
				Description = new HistoryDescription(base.Id, historyHolderFromProvider.RequestParameters.Aggregation),
				Interval = historyHolderFromProvider.RequestParameters.Interval,
				History = historyHolderFromProvider.History
			}, wait: true);
		}
		catch (Exception ex)
		{
			Core.Instance.Loggers.Log(ex);
		}
	}
}
