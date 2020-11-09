using Microsoft.Extensions.DependencyInjection;
using ShoppingCart.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using ShoppingCart.Data.Repositories;
using ShoppingCart.Application.Interfaces;
using ShoppingCart.Application.Services;

namespace ShoppingCart.IOC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<IProductsRepository, ProductsRepository>();
            services.AddScoped<IProductsService, ProductsService>();

            //Explain AddScoped!!
            //Move Initialization of ShoppingCartDbContext to here and refine the dependencies

        }
    }
}
