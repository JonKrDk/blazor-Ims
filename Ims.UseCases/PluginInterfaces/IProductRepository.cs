using Ims.CoreBusiness;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ims.UseCases.PluginInterfaces
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetProductsByNameAsync(string name);
    }
}
