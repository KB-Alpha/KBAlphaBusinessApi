using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KBAlphaBusinessApi.Models.StockModels.AlphaVantage_Models
{
    public class EarningsCalendar
    {
        public string symbol { get; set; }

        public string name { get; set; }

        public string reportDate { get; set; }

        public string fiscalDateEnding { get; set; }

        public string estimate { get; set; }

        public string currency { get; set; }
    }
}
