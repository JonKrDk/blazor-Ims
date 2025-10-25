using Ims.CoreBusiness;
using Ims.UseCases.Inventories.Interfaces;
using Ims.UseCases.PluginInterfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ims.UseCases.Inventories
{
    public class ViewInventoriesByNameUseCase : IViewInventoriesByNameUseCase
    {
        private readonly ILogger<ViewInventoriesByNameUseCase> logger;
        private readonly IInventoryRepository inventoryRepository;

        public ViewInventoriesByNameUseCase(ILogger<ViewInventoriesByNameUseCase> logger, IInventoryRepository inventoryRepository)
        {
            this.logger = logger;
            this.inventoryRepository = inventoryRepository;
        }

        public async Task<IEnumerable<Inventory>> ExecuteAsync(string name = "")
        {
            logger.LogDebug($"ViewInventoriesByNameUseCase.ExecuteAsync(name={name})");

            return await inventoryRepository.GetInventoriesByNameAsync(name);
        }
    }
}
