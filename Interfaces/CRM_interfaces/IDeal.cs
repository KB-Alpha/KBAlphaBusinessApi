using KBAlphaBusinessApi.Models.CrmModels.DealModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KBAlphaBusinessApi.Interfaces.CRM_interfaces
{
    public interface IDeal
    {
        Task<object> GetDeals();

        Task<object> GetDeal(string _id);

        object CreateDeal(DealDto deal);

        Task DeleteDeal(string _id);

        Task UpdateDeal(string _id);

        Task ArchiveDeal(string _id);

        Task GetDealAssociates(object type);

        Task AssociateWithAnotherDeal(object type, object associateType);

        Task CreateDealBulk(object deal);

        Task UpdateDealsBulk();
    }
}
