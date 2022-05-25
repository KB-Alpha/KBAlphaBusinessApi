using KBAlphaBusinessApi.Interfaces.CRM_interfaces;
using KBAlphaBusinessApi.Models.CrmModels;
using KBAlphaBusinessApi.Models.CrmModels.DealModels;
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
        private readonly IDeal _iDeal;

        private readonly IQuote _iQuote;

        private readonly IContact _iContact;

        public CRMController(IDeal iDeal, IQuote iQuote, IContact iContact)
        {
            _iDeal = iDeal;
            _iQuote = iQuote;
            _iContact = iContact;
        }

        #region Quote endpoints
        // POST api/<CRMController>
        //Send the quote to hubspot
        [HttpPost("create/quote")]
        public void PostQuote([FromBody] Quote quote)
        {
            _iQuote.CreateQuote(quote);
        }
        #endregion

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
        public object PostDeal([FromBody] dynamic deal)
        {
            try
            {
                var _deal = System.Text.Json.JsonSerializer.Serialize(deal);

                DealDto dealDto = JsonConvert.DeserializeObject<DealDto>(_deal);

                return _iDeal.CreateDeal(dealDto);
            }
            catch (Exception)
            {

                throw;
            }
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
        public object PostContact([FromBody] dynamic contact)
        {
            //Convert the deal object to a contactdto 
            try
            {
                var _contact = System.Text.Json.JsonSerializer.Serialize(contact);

                ContactDTO contactDto = JsonConvert.DeserializeObject<ContactDTO>(_contact);

                return _iContact.PostContact(contactDto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
