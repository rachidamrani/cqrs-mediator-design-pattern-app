using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace DemoLibrary
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDemoLibrary(this IServiceCollection services)
        {
            services.AddMediatR(typeof(DependencyInjection).Assembly);

            return services;
        }
    }
}