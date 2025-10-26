using Ims.CoreBusiness;
using Ims.UseCases.Inventories.Interfaces;
using Ims.UseCases.PluginInterfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ims.UseCases.Inventories
{
    public class EditInventoryUseCase : IEditInventoryUseCase
    {
        private readonly ILogger<EditInventoryUseCase> logger;
        private readonly IInventoryRepository inventoryResopisory;

        public EditInventoryUseCase(ILogger<EditInventoryUseCase> logger, IInventoryRepository inventoryResopisory)
        {
            this.logger = logger;
            this.inventoryResopisory = inventoryResopisory;
        }

        public async Task ExecuteAsync(Inventory inventory)
        {
            logger.LogDebug($"EditInventoryUseCase.ExecuteAsync(inventory={inventory})");
            await inventoryResopisory.UpdateInventoryAsync(inventory);
        }
    }
}
