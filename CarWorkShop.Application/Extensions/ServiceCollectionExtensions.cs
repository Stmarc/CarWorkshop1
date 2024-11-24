using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarWorkShop.Application.CarWorkshop.Commands.CreateCarWorkshop;
using CarWorkShop.Application.Mappings;

using FluentValidation;
using FluentValidation.AspNetCore;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
namespace CarWorkShop.Application.Extensions
{
    public static class ServiceCollectionExtensions
    {

        public static void AddAplication(this IServiceCollection services)
        {
            services.AddMediatR(typeof(CreateCarWorkshopCommand));


            services.AddAutoMapper(typeof(CarWorkshopMappingProfile));

            services.AddValidatorsFromAssemblyContaining<CreateCarWorkshopCommand>()
                .AddFluentValidationAutoValidation()
                .AddFluentValidationClientsideAdapters();
           
        }
    }
}
