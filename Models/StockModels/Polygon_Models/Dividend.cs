using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KBAlphaBusinessApi.Models.StockModels.Polygon_Models
{
    public class Dividend
    {
        public List<object> results { get; set; }
        public string status { get; set; }
        public string request_id { get; set; }
        public string next_url { get; set; }
    }
}
