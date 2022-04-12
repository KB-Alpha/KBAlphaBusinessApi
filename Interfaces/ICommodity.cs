using KBAlphaBusinessApi.Models.StockModels.Commodaties_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KBAlphaBusinessApi.Interfaces
{
    public interface ICommodity
    {
        Task<object> GetCommodatyData(string symbol, string start_date, string end_date, string type, string base_currency);

        Commodity GetCommoData();

        Dictionary<string, string> GetCodes();

        Task<object> GetCommodatyTimeSeries(string code);

        Task<object> GetCommodatyDetails(string code);
    }
}
