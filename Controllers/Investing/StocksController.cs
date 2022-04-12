using KBAlphaBusinessApi.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace KBAlphaBusinessApi.Controllers.Investing
{
    [Route("api/[controller]")]
    [ApiController]
    public class StocksController : ControllerBase
    {
        private readonly IStock _stockData;

        public StocksController(IStock stockData)
        {
            _stockData = stockData;
        }

        // GET: api/<StocksController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<StocksController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        //GET api/<StocksController>/
        //Get earnings calendar data
        [HttpGet("earnings/calendar")]
        public object GetEarningsData()
        {
            return _stockData.GetEarningsData();
        }

    }
}
