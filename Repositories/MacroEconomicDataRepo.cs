using KBAlphaBusinessApi.Helpers;
using KBAlphaBusinessApi.Interfaces;
using KBAlphaBusinessApi.Models.StockModels.AlphaVantage_Models;
using KBAlphaBusinessApi.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KBAlphaBusinessApi.Repositories
{
    public class MacroEconomicDataRepo : IMacroeconomic
    {
        private string _endpoint;

        private string key = Constants.Alpha_Vantage_Api_Key;

        public async Task<ConsumerSentiment> GetConsumerSentimentData()
        {
            try
            {
                _endpoint = Constants.AlphaVantageBaseUrl 
                            + $"query?function=CONSUMER_SENTIMENT&apikey={key}";

                var json = await APIConnector.Start_Alpha_Vantage_Connection(_endpoint).Content.ReadAsStringAsync();

                var consumerSentimentData = JsonConvert.DeserializeObject<ConsumerSentiment>(json);

                return consumerSentimentData;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<CPI> GetCPIData(string interval)
        {
            try
            {
                _endpoint = Constants.AlphaVantageBaseUrl + $"query?function=CPI&interval={interval}&apikey={key}";

                var json = await APIConnector.Start_Alpha_Vantage_Connection(_endpoint).Content.ReadAsStringAsync();

                var cpiData = JsonConvert.DeserializeObject<CPI>(json);

                return cpiData;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
