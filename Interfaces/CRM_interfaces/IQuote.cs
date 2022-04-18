using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KBAlphaBusinessApi.Interfaces.CRM_interfaces
{
    public interface IQuote
    {
        Task<IList<object>> GetQuotes(int batchNumber);

        Task<object> GetAQuote(string _id);

        Task UpdateQuote(string _id);

        Task<string> DeleteQuote(string _id);
    }
}
