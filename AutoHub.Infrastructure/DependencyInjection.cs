using AutoHub.Application.Common.Interfaces;
using AutoHub.Infrastructure.Persistence;
using AutoHub.Infrastructure.Persistence.Interceptors;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AutoHub.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddScoped<AuditableEntitySaveChangesInterceptor>();

            services.AddDbContext<ApplicationDbContext>((serviceProvider, options) =>
            {
                var connectionString = configuration.GetConnectionString("DefaultConnection")
                    ?? throw new InvalidOperationException(
                        "Connection string 'DefaultConnection' not found.");

                options.UseSqlServer(connectionString);

                options.AddInterceptors(
                    serviceProvider.GetRequiredService<AuditableEntitySaveChangesInterceptor>());
            });

            // Липсваше този ред — свързва интерфейса с реалната имплементация,
            // за да може всичко в Application слоя (LookupService<T> и др.)
            // да получи същата DbContext инстанция чрез IApplicationDbContext.
            services.AddScoped<IApplicationDbContext>(provider =>
                provider.GetRequiredService<ApplicationDbContext>());

            return services;
        }
    }
}