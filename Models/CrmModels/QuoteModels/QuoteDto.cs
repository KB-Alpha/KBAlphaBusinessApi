using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KBAlphaBusinessApi.Models.CrmModels.QuoteModels
{
    public class QuoteDto
    {
        public QuoteDtoProperties Properties { get; set; }
    }

    public class QuoteDtoProperties
    {
        public string HsTitle { get; set; }
        public DateTime HsExpirationDate { get; set; }
    }
}
