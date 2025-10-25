using Ims.CoreBusiness;
using Ims.UseCases.PluginInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ims.UseCases.Inventories
{
    public class ViewInventoriesByNameUseCase
    {
        private readonly IInventoryRepository inventoryRepository;

        public ViewInventoriesByNameUseCase(IInventoryRepository inventoryRepository)
        {
            this.inventoryRepository = inventoryRepository;
        }

        public async Task<IEnumerable<Inventory>> ExecuteAsync(string name = "")
        {
            return await inventoryRepository.GetInventoriesByNameAsync(name);
        }
    }
}
