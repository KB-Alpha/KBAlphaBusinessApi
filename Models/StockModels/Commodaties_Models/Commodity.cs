using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KBAlphaBusinessApi.Models.StockModels.Commodaties_Models
{
    public class Commodity
    {
        public string status { get; set; }
        public Meta meta { get; set; }
        public IList<Datum> data { get; set; }
    }

    public class Datum
    {
        public string type { get; set; }
        public string structure { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public Currency currency { get; set; }
        public Unit unit { get; set; }
        public PriceUnit price_unit { get; set; }
        public string latest_value_insertion_date { get; set; }
        public string oldest_available_date { get; set; }
        public string latest_available_date { get; set; }
        public string frequency { get; set; }
        public string source { get; set; }
        public string warning { get; set; }
        public object spec { get; set; }
        public FixedValue fixed_value { get; set; }
    }

    public class FixedValue
    {
        public bool is_fixed { get; set; }
        public object fixed_value { get; set; }
    }

    public class PriceUnit
    {
        public string name { get; set; }
        public string abbr { get; set; }
    }

    public class Unit
    {
        public string name { get; set; }
        public string abbr { get; set; }
        public int prefix { get; set; }
        public string suffix { get; set; }
        public string base_abbr { get; set; }
    }

    public class Currency
    {
        public string name { get; set; }
        public string code { get; set; }
        public string symbol { get; set; }
        public double prefix { get; set; }
        public string base_code { get; set; }
    }

    public class Meta
    {
        public int total { get; set; }
        public int per_page { get; set; }
        public int current_page { get; set; }
        public int last_page { get; set; }
        public int from { get; set; }
        public int to { get; set; }
        public bool has_more_pages { get; set; }
    }
}
