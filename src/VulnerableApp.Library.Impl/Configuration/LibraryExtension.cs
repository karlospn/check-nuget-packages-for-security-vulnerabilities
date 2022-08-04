using VulnerableApp.Library.Contracts;
using Microsoft.Extensions.DependencyInjection;

namespace VulnerableApp.Library.Impl.Configuration
{
    public static class LibraryExtension
    {
        public static IServiceCollection AddLibraryServices(this IServiceCollection services)
        {
            services.AddScoped<IFooService, FooService>();
           
            return services;
        }
    }
}