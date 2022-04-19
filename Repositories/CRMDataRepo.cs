using KBAlphaBusinessApi.Interfaces.CRM_interfaces;
using KBAlphaBusinessApi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;

namespace KBAlphaBusinessApi.Repositories
{
    public class CRMDataRepo : IDeal, IQuote
    {
        private string dealbaseEndpoint = "crm/v3/objects/deals";

        private string quotebaseEndpoint = "";
        public Task ArchiveDeal(string _id)
        {
            throw new NotImplementedException();
        }

        public Task AssociateWithAnotherDeal(object type, object associateType)
        {
            throw new NotImplementedException();
        }

        public Task<bool> CreateDeal(object deal)
        {
            StringContent content = new StringContent(deal.ToString());

            try
            {
                 var postStatus = APIConnector.Start_Post_Hubspot_Connection(dealbaseEndpoint, content);
            }
            catch (Exception)
            {
                throw;
            }
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

        public async Task<object> GetDeals()
        {

            try
            {
                var json =  APIConnector
                           .Start_Get_HubSpot_Connection(dealbaseEndpoint)
                           .Content
                           .ReadAsStringAsync()
                           .Result;

                var data = JsonConvert.DeserializeObject<object>(json);
                
                return data;
            }
            catch (Exception ex)
            {
                throw ex;
            }
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
