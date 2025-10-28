using Ims.UseCases.Inventories;
using Ims.UseCases.Inventories.Interfaces;
using Ims.UseCases.PluginInterfaces;
using Ims.UseCases.Products;
using Ims.UseCases.Products.Interfaces;
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
            services.AddTransient<IViewInventoriesByNameUseCase, ViewInventoriesByNameUseCase>();
            services.AddTransient<IAddInventoryUseCase, AddInventoryUseCase>();
            services.AddTransient<IEditInventoryUseCase, EditInventoryUseCase>();
            services.AddTransient<IDeleteInventoryUseCase, DeleteInventoryUseCase>();
            services.AddTransient<IGetInventoryByIdUseCase, GetInventoryByIdUseCase>();

            services.AddTransient<IViewProductsByNameUseCase, ViewProductsByNameUseCase>();

            return services;
        }
    }
}
