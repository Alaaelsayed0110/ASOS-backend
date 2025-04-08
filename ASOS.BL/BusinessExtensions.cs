﻿using ASOS.BL;
using ASOS.BL.Managers.Category;
using ASOS.BL.Managers.Product;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace ASOS.DAL;

public static class BusinessExtensions
{
    public static void AddBusinessServices(this IServiceCollection services,IConfiguration configuration)
    { 
         services.AddScoped<IWomanManager, WomanManager>(); 
        services.AddScoped<ICategoryManager, CategoryManager>();

        services.AddScoped<IMenManager, MenManager>();
        services.AddScoped<IProductManager, ProductManager>();
    }
}
