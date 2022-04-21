using KBAlphaBusinessApi.Interfaces.CRM_interfaces;
using KBAlphaBusinessApi.Models.CrmModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace KBAlphaBusinessApi.Controllers.Admin.CRM
{
    [Route("api/[controller]")]
    [ApiController]
    public class CRMController : ControllerBase
    {
        private IDeal _iDeal;

        private IQuote _iQuote;

        private IContact _iContact;

        public CRMController(IDeal iDeal, IQuote iQuote, IContact iContact)
        {
            _iDeal = iDeal;
            _iQuote = iQuote;
            _iContact = iContact;
        }

        #region Deal endpoints
        // GET: api/<CRMController>
        [HttpGet("deals")]
        public object GetAllDeals()
        {
            return _iDeal.GetDeals();
        }

        // GET api/<CRMController>/5
        [HttpGet("deal/{id}")]
        public object GetDeal(string id)
        {
            return _iDeal.GetDeal(id);
        }

        // POST api/<CRMController>
        //Create bulk deals
        [HttpPost("create/deal")]
        public void Post([FromBody] object deal)
        {
            _iDeal.CreateDeal(deal);
        }

        // PUT api/<CRMController>/5
        //update a deal
        [HttpPut("deal/update/{id}")]
        public void Put(string id, [FromBody] string value)
        {
            _iDeal.UpdateDeal(id);
        }

        // DELETE api/<CRMController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
        #endregion

        #region Contact endpoints
        [HttpPost("create/contact")]
        public object PostContact([FromBody] dynamic deal)
        {
            //Convert the deal object to a contactdto 
            try
            {
                var _deal = System.Text.Json.JsonSerializer.Serialize(deal);

                ContactDTO contact = JsonConvert.DeserializeObject<ContactDTO>(_deal);

                return _iContact.PostContact(contact);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
