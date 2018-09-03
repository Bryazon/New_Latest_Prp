using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using WebApplication7.Data;
using WebApplication7.Data.Entities;
using WebApplication7.Data.Seeders;
using WebApplication7.Services.Formatting;

namespace WebApplication7
{
    public class Startup
    {
        private readonly IConfiguration config;
        private readonly IHostingEnvironment environment;

        public Startup(IConfiguration config, IHostingEnvironment env)
        {
            this.config = config;
            this.environment = env;


        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddDbContext<CBContext>(cfg =>
            {
                cfg.UseSqlServer(config.GetConnectionString("CBConnectionString"));
            });
            // Configure Identity
            services.AddIdentity<SystemUserLogin, IdentityRole>(options =>
            {
                // Configure identity options here.
                options.Password.RequireDigit = false;
                options.Password.RequiredLength = 8;
                options.Password.RequireLowercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.SignIn.RequireConfirmedEmail = true;
            })
            .AddEntityFrameworkStores<CBContext>(); // Tell Identity which EF DbContext to use

            services.AddAutoMapper();
            services.AddTransient<PropertyRepositorySeeder>();
            services.AddScoped<IPropertyRepository, PropertyRepository>(); 
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseCors(builder => builder.AllowAnyOrigin());
            app.UseAuthentication();
            app.UseMvc();

            if (env.IsDevelopment())
            {
                using (var scope = app.ApplicationServices.CreateScope())
                {
                    var seeder = scope.ServiceProvider.GetService<PropertyRepositorySeeder>();
                    seeder.Seed().Wait();
                }
            }
        }

    }
}
