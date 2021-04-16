using Microsoft.Extensions.DependencyInjection;
using CoopManagement.Data;
using CoopManagement.Data.Repository;
using CoopManagement.Interfaces;
using CoopManagement.Notificacoes;

namespace CoopManagement.Configurations
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<ApplicationDbContext>();
            services.AddScoped<ICursoRepository, CursoRepository>();
            services.AddScoped<ICooperadoRepository, CooperadoRepository>();
            services.AddScoped<INotificador, Notificador>();

            return services;
        }
    }
}
