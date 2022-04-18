using KBAlphaBusinessApi.Interfaces.CRM_interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KBAlphaBusinessApi.Repositories
{
    public class CRMDataRepo : IDeal, IQuote
    {
        public Task ArchiveDeal(string _id)
        {
            throw new NotImplementedException();
        }

        public Task AssociateWithAnotherDeal(object type, object associateType)
        {
            throw new NotImplementedException();
        }

        public Task<bool> CreateDeal(object Deal)
        {
            throw new NotImplementedException();
        }

        public Task CreateDealBulk(object deal)
        {
            throw new NotImplementedException();
        }

        public Task DeleteDeal(string _id)
        {
            throw new NotImplementedException();
        }

        public Task<string> DeleteQuote(string _id)
        {
            throw new NotImplementedException();
        }

        public Task<object> GetAQuote(string _id)
        {
            throw new NotImplementedException();
        }

        public Task<object> GetDeal(string _id)
        {
            throw new NotImplementedException();
        }

        public Task GetDealAssociates(object type)
        {
            throw new NotImplementedException();
        }

        public Task<object> GetDeals()
        {
            throw new NotImplementedException();
        }

        public Task<IList<object>> GetQuotes(int batchNumber)
        {
            throw new NotImplementedException();
        }

        public Task UpdateDeal(string _id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateDealsBulk()
        {
            throw new NotImplementedException();
        }

        public Task UpdateQuote(string _id)
        {
            throw new NotImplementedException();
        }
    }
}
