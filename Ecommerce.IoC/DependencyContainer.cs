using Ecommerce.Application.Services;
using Ecommerce.Data.Repositories;
using Ecommerce.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Ecommerce.Application.Interfaces;

namespace Ecommerce.IoC
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
