using Ims.CoreBusiness;
using Ims.UseCases.Inventories.Interfaces;
using Ims.UseCases.PluginInterfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ims.UseCases.Inventories
{
    public class AddInventoryUseCase : IAddInventoryUseCase
    {
        private readonly ILogger<AddInventoryUseCase> logger;
        private readonly IInventoryRepository inventoryRepository;

        public AddInventoryUseCase(ILogger<AddInventoryUseCase> logger, IInventoryRepository inventoryRepository)
        {
            this.logger = logger;
            this.inventoryRepository = inventoryRepository;
        }

        public async Task ExecuteAsync(Inventory inventory)
        {
            logger.LogInformation("Adding a new inventory item: {InventoryName}", inventory.Name);

            await this.inventoryRepository.AddInventoryAsync(inventory);
        }
    }
}
