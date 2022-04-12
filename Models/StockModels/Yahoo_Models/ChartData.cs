using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KBAlphaBusinessApi.Models.StockModels.Yahoo_Models
{
    public class ChartData
    {
        public Chart chart { get; set; }
    }

    public class Chart
    {
        public IList<ChartResult> result { get; set; }
        public object error { get; set; }
    }

    public class ChartResult
    {
        public Meta meta { get; set; }
        public IList<int> timestamp { get; set; }
        public IList<Comparisons> comparisons { get; set; }
        public Events events { get; set; }
        public Indicators indicators { get; set; }
    }

    public class Meta
    {
        public string currency { get; set; }
        public string symbol { get; set; }
        public string exchangeName { get; set; }
        public string instrumentType { get; set; }
        public int firstTradeDate { get; set; }
        public int regularMarketTime { get; set; }
        public int gmtoffset { get; set; }
        public string timezone { get; set; }
        public string exchangeTimezoneName { get; set; }
        public double regularMarketPrice { get; set; }
        public double chartPreviousClose { get; set; }
        public int priceHint { get; set; }
        public CurrentTradingPeriod currentTradingPeriod { get; set; }
        public string dataGranularity { get; set; }
        public string range { get; set; }
        public IList<string> validRanges { get; set; }
    }

    public class CurrentTradingPeriod
    {
        public Pre pre { get; set; }
        public Regular regular { get; set; }
        public Post post { get; set; }
    }

    public class Pre
    {
        public string timezone { get; set; }
        public int start { get; set; }
        public int end { get; set; }
        public int gmtoffset { get; set; }
    }

    public class Regular
    {
        public string timezone { get; set; }
        public int start { get; set; }
        public int end { get; set; }
        public int gmtoffset { get; set; }
    }

    public class Post
    {
        public string timezone { get; set; }
        public int start { get; set; }
        public int end { get; set; }
        public int gmtoffset { get; set; }
    }

    public class Comparisons
    {
        public string symbol { get; set; }
        public IList<double> high { get; set; }
        public IList<double> low { get; set; }
        public double chartPreviousClose { get; set; }
        public IList<double> close { get; set; }
        public IList<double> open { get; set; }
    }

    public class Events
    {
        public Dividends dividends { get; set; }
    }

    public class Dividends
    {
        public DividenedData number { get; set; }
    }

    public class DividenedData
    {
        public double amount { get; set; }
        public int date { get; set; }
    }

    public class Indicators
    {
        public IList<ChartQuote> quote { get; set; }
        public IList<Adjclose> adjclose { get; set; }
    }

    public class ChartQuote
    {
        public IList<double> open { get; set; }
        public IList<double> low { get; set; }
        public IList<double> high { get; set; }
        public IList<double> close { get; set; }
        public IList<int> volume { get; set; }
    }

    public class Adjclose
    {
        public IList<double> adjclose { get; set; }
    }
}
