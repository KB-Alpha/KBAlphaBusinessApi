using CsvHelper;
using KBAlphaBusinessApi.Helpers;
using KBAlphaBusinessApi.Interfaces;
using KBAlphaBusinessApi.Models.StockModels.AlphaVantage_Models;
using KBAlphaBusinessApi.Services;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace KBAlphaBusinessApi.Repositories
{
    public class StockDataRepo : IStock
    {
        private string _endpoint;

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
    }
}
