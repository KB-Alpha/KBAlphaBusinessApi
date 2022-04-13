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
    public class MacroeconomicsController : ControllerBase
    {
        private IMacroeconomic _iMacroeconomics;

        public MacroeconomicsController(IMacroeconomic iMacroeconmics)
        {
            _iMacroeconomics = iMacroeconmics;
        }

        // GET: api/<MacroeconomicsController>
        [HttpGet("consumersentiment")]
        public object GetConsumerSentiment()
        {
            return _iMacroeconomics.GetConsumerSentimentData();
        }

        // GET api/<MacroeconomicsController>/5
        [HttpGet("cpi/{interval}")]
        public object GetCPI(string interval)
        {
            return _iMacroeconomics.GetCPIData(interval);
        }

    }
}
