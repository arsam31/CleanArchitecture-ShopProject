using Ecomerce.Application.Interfaces;
using Ecomerce.Application.Services;
using Ecommerce.Data.Repositories;
using Ecommerce.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Ecomerce.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //CleanArchitecture.Application
            services.AddScoped<IShopOwner, ShopOwnerService>();

            //CleanArchitecture.Domain.Interfaces | CleanArchitecture.Infra.Data.Repositories
            services.AddScoped<IShopOwnerRepository, ShopOwnerRepository>();
        }
    }
}
