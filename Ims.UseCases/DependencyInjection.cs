using Ims.UseCases.PluginInterfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ims.UseCases
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddUseCases(this IServiceCollection services)
        {
            // services.AddTransient<IInventoryRepository, InventoryRepository>();
            return services;
        }
    }
}
