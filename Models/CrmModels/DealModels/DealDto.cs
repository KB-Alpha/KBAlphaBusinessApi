using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KBAlphaBusinessApi.Models.CrmModels.DealModels
{
    public class DealDto
    {
        public DealDtoProperties properties { get; set; }
    }

    public class DealDtoProperties
    {
        public string amount { get; set; }
        public DateTime closedate { get; set; }
        public string dealname { get; set; }
        public string dealstage { get; set; }
        public string hubspot_owner_id { get; set; }
        public string pipeline { get; set; }
    }
}
