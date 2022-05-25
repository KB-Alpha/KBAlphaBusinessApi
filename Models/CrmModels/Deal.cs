using KBAlphaBusinessApi.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KBAlphaBusinessApi.Models.CrmModels
{
    public class Deal
    {
        public string id { get; set; } = Guid.NewGuid().ToString();
        public DealProperties properties { get; set; }
        public DateTime createdAt { get; set; } = DateTime.Now;
        public DateTime updatedAt { get; set; } = DateTime.Now;
        public bool archived { get; set; } = false;
    }

    public class DealProperties
    {
        public string amount { get; set; }
        public string amount_in_home_currency { get; set; }
        public DateTime closedate { get; set; } 
        public DateTime createdate { get; set; }
        public string days_to_close { get; set; }
        public string dealname { get; set; }
        public string dealstage { get; set; }
        public string hs_all_owner_ids { get; set; }
        public string hs_closed_amount { get; set; }
        public string hs_closed_amount_in_home_currency { get; set; }
        public DateTime hs_createdate { get; set; } = DateTime.Now;
        public string hs_deal_stage_probability_shadow { get; set; }
        public string hs_forecast_amount { get; set; }
        public string hs_is_closed { get; set; }
        public string hs_is_closed_won { get; set; }
        public string hs_is_deal_split { get; set; }
        public DateTime hs_lastmodifieddate { get; set; } = DateTime.Now;
        public string hs_object_id { get; set; }
        public string hs_projected_amount { get; set; }
        public string hs_projected_amount_in_home_currency { get; set; }
        public string hs_user_ids_of_all_owners { get; set; }
        public DateTime hubspot_owner_assigneddate { get; set; } = DateTime.Now;
        public string hubspot_owner_id { get; set; } = Constants.HubSpot_Owner_Id;
        public string pipeline { get; set; }
    }
}
