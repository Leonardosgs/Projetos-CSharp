using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace VL.WebApi.Configuration
{
    public static class SwaggerConfig
    {
        public static void AddSwaggerConfiguration(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { 
                                                        Title = "Consultório VL", 
                                                        Version = "v1",
                                                        Description = "Api da aplicação Consultório VL",
                                                        Contact = new OpenApiContact
                                                        {
                                                            Name = "Leonardo dos Santos Gomes da SIlva",
                                                            Email = "leonardosgs@hotmail.com",
                                                            Url = new Uri("https://github.com/Leonardosgs")
                                                        },
                                                        License = new OpenApiLicense
                                                        {
                                                            Name = "OSD",
                                                            Url = new Uri("https://opensource.org/osd")
                                                        },
                                                        TermsOfService = new Uri("https://opensource.org/osd")

                });

                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath);
            });
        }

        public static void UseSwaggerConfiguration(this IApplicationBuilder app)
        {
            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.RoutePrefix = string.Empty;
                c.SwaggerEndpoint("./swagger/v1/swagger.json", "VL v1");
            });
        }
    }
}
