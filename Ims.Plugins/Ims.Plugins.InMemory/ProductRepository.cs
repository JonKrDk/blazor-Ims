using Ims.CoreBusiness;
using Ims.UseCases.PluginInterfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ims.Plugins.InMemory
{
    public class ProductRepository : IProductRepository
    {
        private readonly ILogger<ProductRepository> logger;

        private List<Product> products = new List<Product>()
        {
            new Product { Id = 1, Name = "Bike", Quantity = 10, Price = 150.0 },
            new Product { Id = 2, Name = "Car", Quantity = 10, Price = 25000.0 }
        };

        public ProductRepository(ILogger<ProductRepository> logger)
        {
            this.logger = logger;
        }

        public Task AddProductAsync(Product product)
        {
            logger.LogDebug($"InventoryRepository.AddProductAsync(inventory={product})");

            if (products.Any(i => i.Name.Equals(product.Name, StringComparison.OrdinalIgnoreCase)))
            {
                return Task.CompletedTask;
            }

            var maxId = products.Max(q => q.Id);
            product.Id = maxId + 1;

            products.Add(product);
            return Task.CompletedTask;
        }

        public Task UpdateProductAsync(Product product)
        {
            logger.LogDebug($"InventoryRepository.UpdateProductAsync(product={product})");

            if (products.Any(q => q.Id != product.Id && q.Name.Equals(product.Name, StringComparison.OrdinalIgnoreCase)))
            {
                return Task.CompletedTask;
            }

            if (!products.Any(q => q.Name.Equals(product.Name, StringComparison.OrdinalIgnoreCase)))
            {
                return Task.CompletedTask;
            }

            var productToUpdate = products.FirstOrDefault(i => i.Id == product.Id);
            if (productToUpdate is not null)
            {
                productToUpdate.Name = product.Name;
                productToUpdate.Quantity = product.Quantity;
                productToUpdate.Price = product.Price;
            }

            return Task.CompletedTask;
        }

        public Task DeleteProductAsync(Product product)
        {
            logger.LogDebug($"InventoryRepository.DeletePoductAsync(product={product})");

            var productToDelete = products.FirstOrDefault(i => i.Id == product.Id);

            if (productToDelete is not null)
            {
                products.Remove(productToDelete);
            }

            return Task.CompletedTask;
        }

        public async Task<IEnumerable<Product>> GetProductsByNameAsync(string name)
        {
            logger.LogDebug($"ProductRepository.GetProductsByNameAsync(name={name}");


            if (string.IsNullOrWhiteSpace(name))
                return await Task.FromResult(products);

            return products.Where(q => q.Name.Contains(name, StringComparison.OrdinalIgnoreCase));
        }

        public async Task<Product?> GetProductByIdAsync(int id)
        {
            logger.LogDebug($"ProductRepository.GetProductByIdAsync(id={id}");

            return await Task.FromResult(products.FirstOrDefault<Product>(q => q.Id == id));
        }
    }
}
