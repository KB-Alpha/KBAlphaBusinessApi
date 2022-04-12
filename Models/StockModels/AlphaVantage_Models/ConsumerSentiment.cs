using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KBAlphaBusinessApi.Models.StockModels.AlphaVantage_Models
{
    public class ConsumerSentiment
    {
        public string name { get; set; }
        public string interval { get; set; }
        public string unit { get; set; }
        public IList<Datum> data { get; set; }
    }

    public class Datum
    {
        public string date { get; set; }
        public string value { get; set; }
    }
}
