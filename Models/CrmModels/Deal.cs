using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KBAlphaBusinessApi.Models.CrmModels
{
    public class Deal
    {
        public string id { get; set; }
        public Properties properties { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
        public bool archived { get; set; }
    }

    public class Properties
    {
        public string amount { get; set; }
        public DateTime closedate { get; set; }
        public DateTime createdate { get; set; }
        public string dealname { get; set; }
        public string dealstage { get; set; }
        public DateTime hs_lastmodifieddate { get; set; }
        public string hubspot_owner_id { get; set; }
        public string pipeline { get; set; }
    }
}
