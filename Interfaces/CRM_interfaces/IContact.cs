using KBAlphaBusinessApi.Models.CrmModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KBAlphaBusinessApi.Interfaces.CRM_interfaces
{
    public interface IContact
    {
        Task<object> PostContact(ContactDTO contactDetails);

        Contact GetContact(string id);

        Contact GetContacts();
    }
}
