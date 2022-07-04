using Domain.Contracts;
using Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Infrastructure
{
    public static class DI
    {
        public static void RegisterInfrastructure(this IServiceCollection services)
        {
            services.AddTransient<IHttpRequest, HttpRequest>();
        }
    }
}
