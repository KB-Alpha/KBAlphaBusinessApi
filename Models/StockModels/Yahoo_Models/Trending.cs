using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KBAlphaBusinessApi.Models.StockModels.Yahoo_Models
{
    public class Trending
    {
        public Finance finance { get; set; }
    }

    public class Finance
    {
        public IList<Result> result { get; set; }
        public object error { get; set; }
    }

    public class Result
    {
        public int count { get; set; }
        public IList<Quote> quotes { get; set; }
        public long jobTimestamp { get; set; }
        public long startInterval { get; set; }
    }

    public class Quote
    {
        public string symbol { get; set; }
    }
}
