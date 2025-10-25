using Ims.CoreBusiness;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ims.UseCases.PluginInterfaces
{
    public interface IInventoryRepository
    {
        Task<IEnumerable<Inventory>> GetInventoriesByNameAsync(string name);
    }
}
