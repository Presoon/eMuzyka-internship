using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eMuzyka.Infrastructure.Database;
using eMuzyka.DTO.Provider;
using eMuzyka.DTO.Validators;
using eMuzyka.Domain.Entities;
using eMuzyka.Middleware;
using eMuzyka.Services;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Identity;

namespace eMuzyka
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers().AddFluentValidation();

            //db context & seeder
            services.AddDbContext<DatabaseContext>();
            services.AddScoped<DatabaseSeeder>();

            //services 
            services.AddScoped<IProviderService, ProviderService>();
            services.AddScoped<IAlbumService, AlbumService>();
            services.AddScoped<IAccountService, AccountService>();

            services.AddScoped<IPasswordHasher<Provider>, PasswordHasher<Provider>>();
            services.AddScoped<IValidator<RegisterProviderDto>, RegisterProviderDtoValidator>();

            //middleware
            services.AddScoped<ErrorHandlingMiddleware>();


            services.AddAutoMapper(this.GetType().Assembly);
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "eMuzyka", Version = "v1" });
            });
        }
        

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, DatabaseSeeder seeder)
        {

            seeder.Seed();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "eMuzyka v1"));
            }

            app.UseMiddleware<ErrorHandlingMiddleware>();

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
