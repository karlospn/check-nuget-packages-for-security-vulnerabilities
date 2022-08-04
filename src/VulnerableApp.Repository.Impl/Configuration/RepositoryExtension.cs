using VulnerableApp.Repository.Contracts;
using Microsoft.Extensions.DependencyInjection;


namespace VulnerableApp.Repository.Impl.Configuration
{
    public static class RepositoryExtension
    {
        public static IServiceCollection AddRepositoryServices(this IServiceCollection services)
        {
            services.AddTransient<IFooRepository, FooRepository>();
            
            return services;
        }

    }
}