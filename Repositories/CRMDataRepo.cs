using KBAlphaBusinessApi.Interfaces.CRM_interfaces;
using KBAlphaBusinessApi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;
using KBAlphaBusinessApi.Models.CrmModels;
using System.Text;
using System.Diagnostics;
using KBAlphaBusinessApi.Helpers;
using KBAlphaBusinessApi.Models.CrmModels.DealModels;

namespace KBAlphaBusinessApi.Repositories
{
    public class CRMDataRepo : IDeal, IQuote, IContact
    {
        private string dealbaseEndpoint = "crm/v3/objects/deals";

        private string quotebaseEndpoint = "crm/v3/objects/quotes";

        private string contactEndpoint = "crm/v3/objects/contacts";

        public Task ArchiveDeal(string _id)
        {
            throw new NotImplementedException();
        }

        public Task AssociateWithAnotherDeal(object type, object associateType)
        {
            throw new NotImplementedException();
        }

        //Create a deal from the contact
        public object CreateDeal(DealDto deal)
        {

            var json = JsonConvert.SerializeObject(deal);

            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

            try
            {
                 var postStatus = APIConnector.Start_Post_Hubspot_Connection(dealbaseEndpoint, content).Result;

                return postStatus;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            
        }

        public Task CreateDealBulk(object deal)
        {
            throw new NotImplementedException();
        }


        //Make a quote for a client
        public async Task<object> CreateQuote(object quoteDetails)
        {

            try
            {

                //first convert the argument into the correct model
                var json = JsonConvert.SerializeObject(quoteDetails);

                var data = new StringContent(json, Encoding.UTF8, "application/json");

                //log for debugging purposes
                Debug.WriteLine("*********************Quote Data: ", data);

                var response = await APIConnector.Start_Post_Hubspot_Connection(quotebaseEndpoint, data);

                return response;

            }
            catch (Exception ex)
            {
                //log the error
                Debug.WriteLine("Error ------>", ex.Message);
                return ex.Message;
            }
        }

        public Task DeleteDeal(string _id)
        {
            throw new NotImplementedException();
        }

        public Task<string> DeleteQuote(string _id)
        {
            throw new NotImplementedException();
        }

        public async Task<object> GetAQuote(string _id)
        {
            if(_id != null)
            try
            {
                    //generate the endpoint
                    string _endpoint = quotebaseEndpoint + $"/{_id}";


            }
            catch (Exception ex)
            {
                    return ex.Message;
            }
            throw new NotImplementedException();
        }

        public Contact GetContact(string id)
        {
            throw new NotImplementedException();
        }

        public Contact GetContacts()
        {
            throw new NotImplementedException();
        }

        public async Task<object> GetDeal(string _id)
        {
            string _endpoint = dealbaseEndpoint + "/" +_id;

            try
            {
                var json = APIConnector.Start_Get_HubSpot_Connection(_endpoint).Content.ReadAsStringAsync().Result;

                var data = JsonConvert.DeserializeObject<Deal>(json);

                return data;
            }
            catch (Exception)
            {
                throw;
            }
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


        //Posts contact from diffrent sources
        public async Task<object> PostContact(ContactDTO contactDetails)
        {

            //create a new object and set it to the one sent from the client
            Contact newContact = new Contact()
            {  
                 properties=new ContactProperties()
                 {
                      website = contactDetails.Message,
                      company = contactDetails.Company,
                      //createdate=DateTime.Now,
                      email=contactDetails.Email,
                      phone=contactDetails.Cellphone,
                      firstname=contactDetails.Fullname

                 },
                 id= Guid.NewGuid().ToString()
            };

            var json = JsonConvert.SerializeObject(newContact);

            var data = new StringContent(json, Encoding.UTF8, "application/json");

            try
            {
                var response = await APIConnector
                               .Start_Post_Hubspot_Connection(contactEndpoint, data);

                System.Diagnostics.Debug.WriteLine("Reponse CRM: " + response);

                return response;
            }
            catch (Exception ex)
            {
                throw ex;
            }
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
