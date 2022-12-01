using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VL.Manager.Mappings;

namespace VL.WebApi.Configuration
{
    public static class AutoMapperConfig
    {
        public static void AddAutoMapperConfiguration(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(NovoClienteMappingProfile), 
                                   typeof(AlterarClienteMappingProfile)
                                   );
        }
    }
}
