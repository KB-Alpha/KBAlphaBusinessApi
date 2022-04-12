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
    public class CommodatiesController : ControllerBase
    {
        private ICommodity _iCommodity;

        public CommodatiesController(ICommodity iCommodity)
        {
            _iCommodity = iCommodity;
        }

        // GET: api/<CommodatiesController>
        [HttpGet("commoditydetails/{code}")]
        public object GetCommodityDetails( string code)
        {
            return _iCommodity.GetCommodatyDetails(code);
        }

        // GET: api/<CommodatiesController/timeseries/code>
        [HttpGet("timeseries/{code}")]
        public object GetTimeSeriesData(string code)
        {
            return _iCommodity.GetCommodatyTimeSeries(code);
        }

        // GET api/<CommodatiesController>/5
        [HttpGet("codes")]
        public object GetCommodityCodes()
        {
            return _iCommodity.GetCodes();
        }

    }
}
