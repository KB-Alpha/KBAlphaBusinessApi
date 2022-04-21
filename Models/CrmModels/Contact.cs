using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KBAlphaBusinessApi.Models.CrmModels
{
    public class Contact
    {
        public string id { get; set; }
        public ContactProperties properties { get; set; }
        //public DateTime createdAt { get; set; }
        //public DateTime updatedAt { get; set; }
        public bool archived { get; set; }
    }

    public class ContactProperties
    {
        public string company { get; set; }
        //public DateTime createdate { get; set; }
        public string email { get; set; }
        public string firstname { get; set; }
        // DateTime lastmodifieddate { get; set; }
        public string lastname { get; set; }
        public string phone { get; set; }
        public string website { get; set; }
    }
}
