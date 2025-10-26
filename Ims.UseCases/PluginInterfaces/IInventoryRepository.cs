using Ims.CoreBusiness;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ims.UseCases.PluginInterfaces
{
    public interface IInventoryRepository
    {
        Task AddInventoryAsync(Inventory inventory);
        Task UpdateInventoryAsync(Inventory inventory);
        Task<IEnumerable<Inventory>> GetInventoriesByNameAsync(string name);
        Task<Inventory?> GetInventoryByIdAsync(int id);
    }
}
