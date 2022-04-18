using KBAlphaBusinessApi.Interfaces.CRM_interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public CRMController(IDeal iDeal)
        {
            _iDeal = iDeal;
        }

        public CRMController(IQuote iQuote)
        {
            _iQuote = iQuote;
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
        [HttpPost("create/deals")]
        public void Post([FromBody] string value)
        {
            _iDeal.CreateDealBulk(value);
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
    }
}
