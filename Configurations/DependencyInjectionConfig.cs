using CoopManagement.Data;
using CoopManagement.Data.Repository;
using CoopManagement.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace CoopManagement.Configurations
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<ApplicationDbContext>();
            services.AddScoped<ICursoRepository, CursoRepository>();
            services.AddScoped<ICooperadoRepository, CooperadoRepository>();

            return services;
        }
    }
}
