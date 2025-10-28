using Ims.CoreBusiness;
using Ims.UseCases.Inventories.Interfaces;
using Ims.UseCases.PluginInterfaces;
using Ims.UseCases.Products.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ims.UseCases.Products
{
    public class ViewProductsByNameUseCase : IViewProductsByNameUseCase
    {
        private readonly ILogger<ViewProductsByNameUseCase> logger;
        private readonly IProductRepository productRepository;

        public ViewProductsByNameUseCase(ILogger<ViewProductsByNameUseCase> logger, IProductRepository productRepository)
        {
            this.logger = logger;
            this.productRepository = productRepository;
        }

        public async Task<IEnumerable<Product>> ExecuteAsync(string name = "")
        {
            logger.LogDebug($"ViewProductsByNameUseCase.ExecuteAsync(name={name})");

            return await productRepository.GetProductsByNameAsync(name);
        }
    }
}
