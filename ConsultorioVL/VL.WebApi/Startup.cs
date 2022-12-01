using AutoMapper;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System.Globalization;
using VL.Data.Context;
using VL.Data.Repositories;
using VL.Manager.Implementation;
using VL.Manager.Interfaces;
using VL.Manager.Mappings;
using VL.Manager.Validator;
using VL.WebApi.Configuration;

namespace VL.WebApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddFluentValidationConfiguration();

            services.AddDbContext<VlContext>(options => options.UseSqlServer(Configuration.GetConnectionString("VlConnection")));

            services.AddDependencyInjectionConfiguration();

            services.AddSwaggerConfiguration();

            services.AddAutoMapperConfiguration();
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwaggerConfiguration();

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
