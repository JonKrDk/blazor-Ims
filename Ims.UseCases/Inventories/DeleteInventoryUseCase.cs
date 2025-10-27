using Ims.CoreBusiness;
using Ims.UseCases.Inventories.Interfaces;
using Ims.UseCases.PluginInterfaces;
using Microsoft.Extensions.Logging;

namespace Ims.UseCases.Inventories
{
    public class DeleteInventoryUseCase : IDeleteInventoryUseCase
    {
        private readonly ILogger<DeleteInventoryUseCase> logger;
        private readonly IInventoryRepository inventoryRepository;

        public DeleteInventoryUseCase(ILogger<DeleteInventoryUseCase> logger, IInventoryRepository inventoryRepository)
        {
            this.logger = logger;
            this.inventoryRepository = inventoryRepository;
        }

        public async Task ExecuteAsync(Inventory inventory)
        {
            logger.LogDebug($"DeleteInventoryUseCaseExecuteAsync(Inventory={inventory})");
            await this.inventoryRepository.DeleteInventoryAsync(inventory);
        }
    }
}
