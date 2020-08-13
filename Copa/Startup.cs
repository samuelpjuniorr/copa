using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CopaApi.Domain.Interfaces.Repository;
using CopaApi.Domain.Interfaces.Service;
using CopaApi.Infra.Context;
using CopaApi.Infra.Repositories;
using CopaApi.Services.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Copa
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

            services.AddDbContext<BDCopaContext>();
            
            services.AddCors();
            services.AddMvc();
            services.AddScoped<BDCopaContext, BDCopaContext>();

            //Services
            services.AddScoped<IEquipeService, EquipeService>();
            services.AddScoped<ICopaService, CopaService>();

            //Repositories
            services.AddScoped<IEquipeRepository, EquipeRepository>();
            services.AddScoped<ICopaRepository, CopaRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

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
