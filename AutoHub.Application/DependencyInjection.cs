using AutoHub.Application.Common.Behaviours;
using AutoHub.Application.Common.Interfaces;
using AutoHub.Application.Common.Services;
using AutoHub.Application.Features;
using AutoHub.Application.VehicleTypes;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace AutoHub.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

            services.AddSingleton(TimeProvider.System);

            services.AddScoped(typeof(ILookupService<>), typeof(LookupService<>));
            services.AddScoped<IVehicleTypeService, VehicleTypeService>();
            services.AddScoped<IFeatureService, FeatureService>();

            services.AddMediatR(cfg =>
            {
                cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
                cfg.AddOpenBehavior(typeof(ValidationBehaviour<,>));
            });

            return services;
        }
    }
}