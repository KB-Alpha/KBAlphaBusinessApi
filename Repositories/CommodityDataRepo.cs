using KBAlphaBusinessApi.Helpers;
using KBAlphaBusinessApi.Interfaces;
using KBAlphaBusinessApi.Models.StockModels.Commodaties_Models;
using KBAlphaBusinessApi.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KBAlphaBusinessApi.Repositories
{
    public class CommodityDataRepo : ICommodity
    {

        private string _endpoint;

        public Dictionary<string, string> GetCodes()
        {
            _endpoint = Constants.CommoPricesBaseUrl + "v2/open";

            Dictionary<string, string> codes = new Dictionary<string, string>();

            var json = APIConnector
                        .Start_Commo_Prices_Connection(_endpoint)
                        .Content
                        .ReadAsStringAsync()
                        .Result;

            var data = JsonConvert.DeserializeObject<Commodity>(json).data;

            foreach (var item in data)
            {
                codes.Add(item.code, item.name);
            }

            return codes;
        }

        public Commodity GetCommoData()
        {
            throw new NotImplementedException();
        }

        public Task<object> GetCommodatyData(string symbol, string start_date, string end_date, string type, string base_currency)
        {
            throw new NotImplementedException();
        }

        public Task<object> GetCommodatyDetails(string code)
        {
            throw new NotImplementedException();
        }

        public Task<object> GetCommodatyTimeSeries(string code)
        {
            throw new NotImplementedException();
        }
    }
}
