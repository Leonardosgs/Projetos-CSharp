using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VL.Data.Repositories;
using VL.Manager.Implementation;
using VL.Manager.Interfaces;

namespace VL.WebApi.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void AddDependencyInjectionConfiguration(this IServiceCollection services)
        {
            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<IClienteManager, ClienteManager>();
        }
    }
}
