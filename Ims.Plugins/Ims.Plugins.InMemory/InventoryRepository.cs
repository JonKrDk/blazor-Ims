using Ims.CoreBusiness;
using Ims.UseCases.PluginInterfaces;
using Microsoft.Extensions.Logging;

namespace Ims.Plugins.InMemory
{
    public class InventoryRepository : IInventoryRepository
    {
        private readonly ILogger<InventoryRepository> logger;
        private List<Inventory> inventories = new List<Inventory>()
        {
            new Inventory { Id = 1, Name = "Bike Seat", Quantity = 10, Price = 2.0 },
            new Inventory { Id = 2, Name = "Bike Body", Quantity = 10, Price = 15.0 },
            new Inventory { Id = 3, Name = "Bike Wheels", Quantity = 20, Price = 8.0 },
            new Inventory { Id = 4, Name = "Bike Pedals", Quantity = 20, Price = 1.0 }
        };

        public InventoryRepository(ILogger<InventoryRepository> logger)
        {
            this.logger = logger;
        }

        public Task AddInventoryAsync(Inventory inventory)
        {
            if (inventories.Any(i => i.Name.Equals(inventory.Name, StringComparison.OrdinalIgnoreCase)))
            {
                return Task.CompletedTask;
            }

            var maxId = inventories.Max(q => q.Id);
            inventory.Id = maxId + 1;

            inventories.Add(inventory);
            return Task.CompletedTask;
        }

        public Task UpdateInventoryAsync(Inventory inventory)
        {
            if (inventories.Any(q => q.Id != inventory.Id && q.Name.Equals(inventory.Name, StringComparison.OrdinalIgnoreCase)))
            {
                return Task.CompletedTask;
            }

            if (!inventories.Any(q => q.Name.Equals(inventory.Name, StringComparison.OrdinalIgnoreCase)))
            {
                return Task.CompletedTask;
            }

            var inventoryToUpdate = inventories.FirstOrDefault(i => i.Id == inventory.Id);
            if (inventoryToUpdate is not null)
            {
                inventoryToUpdate.Name = inventory.Name;
                inventoryToUpdate.Quantity = inventory.Quantity;
                inventoryToUpdate.Price = inventory.Price;
            }

            return Task.CompletedTask;
        }

        public async Task<IEnumerable<Inventory>> GetInventoriesByNameAsync(string name)
        {
            logger.LogDebug("Getting inventories by name: {name}", name);

            if (string.IsNullOrWhiteSpace(name))
                return await Task.FromResult(inventories);

            return inventories.Where(q => q.Name.Contains(name, StringComparison.OrdinalIgnoreCase));
        }

        public async Task<Inventory?> GetInventoryByIdAsync(int id)
        {
            return await Task.FromResult(inventories.FirstOrDefault<Inventory>(q => q.Id == id));
        }
    }
}
