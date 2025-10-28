using Ims.UseCases.PluginInterfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Ims.Plugins.InMemory
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPluginsInMemory(this IServiceCollection services)
        {
            services.AddSingleton<IInventoryRepository, InventoryRepository>();
            services.AddSingleton<IProductRepository, ProductRepository>();

            return services;
        }
    }
}
