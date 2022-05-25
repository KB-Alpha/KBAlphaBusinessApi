using CsvHelper;
using KBAlphaBusinessApi.Helpers;
using KBAlphaBusinessApi.Interfaces;
using KBAlphaBusinessApi.Models.StockModels.AlphaVantage_Models;
using KBAlphaBusinessApi.Models.StockModels.Polygon_Models;
using KBAlphaBusinessApi.Models.StockModels.Yahoo_Models;
using KBAlphaBusinessApi.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Timers;

namespace KBAlphaBusinessApi.Repositories
{
    public class StockDataRepo : IStock
    {
        private string _endpoint;

        private Timer _timer;

        List<object> trendingStocks = new List<object>();

        List<TickerNewsResults> articls = new List<TickerNewsResults>();

        public async Task<object> GetCPIData(string interval)
        {
            _endpoint = Constants.AlphaVantageBaseUrl +
                        $"query?function=CPI&interval={interval}&apikey={Constants.Alpha_Vantage_Api_Key}";

            var json = await APIConnector.Start_Alpha_Vantage_Connection(_endpoint).Content.ReadAsStringAsync();

            var cpiData = JsonConvert.DeserializeObject<CPI>(json);

            return cpiData;
        }

        public object GetDividendData(string ticker)
        {
            throw new NotImplementedException();
        }

        public object GetDividendExData()
        {
            throw new NotImplementedException();
        }


        //Get the earnings data for US companies 
        public async Task<object> GetEarningsData()
        {
            _endpoint = Constants.AlphaVantageBaseUrl +
                $"query?function=EARNINGS_CALENDAR&horizon=3month&apikey={Constants.Alpha_Vantage_Api_Key}";
            APIConnector.Start_Alpha_Vantage_Connection(_endpoint);

            var download = APIConnector.Start_Alpha_Vantage_Connection(_endpoint).Content.ReadAsByteArrayAsync();

            try
            {
                using (MemoryStream stream = new MemoryStream(await download))
                {
                    stream.Position = 0;

                    using (StreamReader reader = new StreamReader(stream))
                    {
                        using (CsvReader csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                        {
                            //Read the csv
                            var records = csv.GetRecords<EarningsCalendar>().ToList();

                            return records;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public object GetTrendingStockNews(string region)
        {

            try
            {
                //Get Yahoo trending stock list
                _endpoint = Constants.BaseUrl + $"v1/finance/trending/{region}";

                //contact yahoo
                var json = APIConnector.Start_Yahoo_API_Conection(_endpoint).Content.ReadAsStringAsync().Result;

                //data list
                var data = JsonConvert.DeserializeObject<Trending>(json);
                
                var recomendedList = data.finance.result;

                //Add to global trending list
                foreach (var stock in recomendedList)
                {
                    foreach (var item in stock.quotes)
                    {
                        if(TickerCheck.CheckIsValidTicker(item.symbol))
                        trendingStocks.Add(item.symbol);
                    }
                }

                //Get the list of articles
                return GetNewsArticles(trendingStocks);
            }
            catch (Exception)
            {
                throw;
            }

            throw new NotImplementedException();
        }
    
        private void StartTimer()
        {
            _timer = new Timer(60000);

            _timer.Elapsed += Time_Elapsed;

            _timer.AutoReset = true;

            _timer.Enabled = true;
        }

        private List<TickerNewsResults> GetNewsArticles(List<object> recomendedList)
        {
            //Go to polgondata to get news

            //Start timer
            StartTimer();

            //rate limit on free is 5 call per minute
            int polyRateLimit = 5;

            try
            {

                foreach (var ticker in recomendedList)
                {

                    string url = Constants.PolygonBaseUrl + $"v2/reference/news?ticker={ticker}&limit=1";

                    var newJson = APIConnector.Start_Polygon_API_Connection(url).Content.ReadAsStringAsync().Result;

                    var newsData = JsonConvert.DeserializeObject<TickerNews>(newJson).results;

                    //check if newsData is null first
                    if(newsData != null)
                    //loop through the newsData
                    foreach (var item in newsData)
                    {
                        articls.Add(item);
                    }
                }

                return articls;
            }
            catch (Exception ex)
            {
                //log the exception
                //throw ex;

                return null;
            }
        }

        private void Time_Elapsed(object sender, ElapsedEventArgs e)
        {
            Debug.WriteLine("Hit the event handler: {0:HH:mm:ss.fff}", e.SignalTime);
        }
    }
}
