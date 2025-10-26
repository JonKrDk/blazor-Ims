using Ims.CoreBusiness;
using Ims.UseCases.Inventories.Interfaces;
using Ims.UseCases.PluginInterfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ims.UseCases.Inventories
{
    public class GetInventoryByIdUseCase : IGetInventoryByIdUseCase
    {
        private readonly ILogger<EditInventoryUseCase> logger;
        private readonly IInventoryRepository inventoryRepository;

        public GetInventoryByIdUseCase(ILogger<EditInventoryUseCase> logger, IInventoryRepository inventoryRepository)
        {
            this.logger = logger;
            this.inventoryRepository = inventoryRepository;
        }

        public async Task<Inventory?> ExecuteAsync(int id)
        {
            logger.LogDebug($"GetInventoryByIdUseCase.ExecuteAsync(id={id})");
            return await inventoryRepository.GetInventoryByIdAsync(id);
        }
    }
}
