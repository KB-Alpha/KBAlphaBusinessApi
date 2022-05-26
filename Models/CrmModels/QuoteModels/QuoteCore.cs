using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KBAlphaBusinessApi.Models.CrmModels.QuoteModels
{
    public class QuoteCore
    {
        public string id { get; set; }
        public QuoteProperties properties { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
        public bool archived { get; set; }
    }

    public class QuoteProperties
    {
        public DateTime hs_createdate { get; set; }
        public DateTime hs_expiration_date { get; set; }
        public string hs_quote_amount { get; set; }
        public string hs_quote_number { get; set; }
        public string hs_status { get; set; }
        public string hs_terms { get; set; }
        public string hs_title { get; set; }
        public string hubspot_owner_id { get; set; }
    }
}
