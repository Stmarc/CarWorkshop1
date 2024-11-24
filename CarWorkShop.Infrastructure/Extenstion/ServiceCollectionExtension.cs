using CarWorkShop.Domain.Interfaces;
using CarWorkShop.Infrastructure.Persistence;
using CarWorkShop.Infrastructure.Repository;
using CarWorkShop.Infrastructure.Seeders;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWorkShop.Infrastructure.Extenstion
{
    public static class ServiceCollectionExtension
    {
     

       
        public static void AddInfastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<CarWorkShopDbContext>(options => options.UseSqlServer(
                configuration.GetConnectionString("CarWorkshop")
));
            services.AddScoped<CarWorkshopSeeder>();

            services.AddScoped<ICarWorkShopRepository,CarWorkshopRepository>();
        }
    }




}
