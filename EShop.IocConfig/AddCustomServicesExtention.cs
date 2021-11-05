using EShop.DataLayer.Context;
using EShop.ViewModels.App;
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
            return services;
        }
    }
}
