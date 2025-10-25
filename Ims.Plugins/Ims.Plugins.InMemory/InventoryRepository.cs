using Ims.CoreBusiness;
using Ims.UseCases.PluginInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ims.Plugins.InMemory
{
    public class InventoryRepository : IInventoryRepository
    {
        private List<Inventory> inventories = new List<Inventory>()
        {
            new Inventory { Id = 1, Name = "Bike Seat", Quantity = 10, Price = 2.0 },
            new Inventory { Id = 1, Name = "Bike Body", Quantity = 10, Price = 15.0 },
            new Inventory { Id = 1, Name = "Bike Wheels", Quantity = 20, Price = 8.0 },
            new Inventory { Id = 1, Name = "Bike Pedals", Quantity = 20, Price = 1.0 }
        };

        public async Task<IEnumerable<Inventory>> GetInventoriesByNameAsync(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                return await Task.FromResult(inventories);

            return inventories.Where(q => q.Name.Contains(name, StringComparison.OrdinalIgnoreCase));
        }
    }
}
