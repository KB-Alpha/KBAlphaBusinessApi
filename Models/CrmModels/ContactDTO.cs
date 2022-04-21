using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KBAlphaBusinessApi.Models.CrmModels
{
    public class ContactDTO
    {
        public string Fullname { get; set; }
        public string Cellphone { get; set; }
        public string Email { get; set; }
        public string Company { get; set; }
        public string Message { get; set; }
    }
}
