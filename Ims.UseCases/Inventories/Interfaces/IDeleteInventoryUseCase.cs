using Ims.CoreBusiness;

namespace Ims.UseCases.Inventories.Interfaces
{
    public interface IDeleteInventoryUseCase
    {
        Task ExecuteAsync(Inventory inventory);
    }
}