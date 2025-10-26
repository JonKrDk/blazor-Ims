using Ims.CoreBusiness;

namespace Ims.UseCases.Inventories.Interfaces
{
    public interface IGetInventoryByIdUseCase
    {
        Task<Inventory?> ExecuteAsync(int id);
    }
}