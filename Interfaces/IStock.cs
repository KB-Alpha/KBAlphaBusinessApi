using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KBAlphaBusinessApi.Interfaces
{
    public interface IStock
    {
        object GetDividendData(string ticker);

        object GetDividendExData();

        Task<object> GetEarningsData();

        Task<object> GetCPIData(string interval);

        object GetTrendingStockNews(string region);

    }
}
