using KBAlphaBusinessApi.Models.StockModels.AlphaVantage_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KBAlphaBusinessApi.Interfaces
{
    public interface IMacroeconomic
    {
        Task<ConsumerSentiment> GetConsumerSentimentData();

        Task<CPI> GetCPIData(string interval);
    }
}
