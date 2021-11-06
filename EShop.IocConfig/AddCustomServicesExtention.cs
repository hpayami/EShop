using EShop.DataLayer.Context;
using EShop.Entities;
using EShop.Services.Contracts;
using EShop.Services.EFServices;
using EShop.ViewModels.App;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace EShop.IocConfig
{
    public static class AddCustomServicesExtention
    {
        public static IServiceCollection AddCustomService(this IServiceCollection services)
        {
            var provider = services.BuildServiceProvider();
            var connectionStrings = provider.GetRequiredService<IOptionsMonitor<ConnectionStrings>>()
                .CurrentValue;
            
            services.AddDbContext<EShopDbContext>(options =>
            {
                options.UseSqlServer(connectionStrings.EShopConnectionString);
            });

            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IUnitOfWork, EShopDbContext>();

            // Identity
            services.AddIdentity<User, Role>()
                .AddEntityFrameworkStores<EShopDbContext>()
                .AddDefaultTokenProviders();
            // END Identity

            return services;
        }
    }
}
