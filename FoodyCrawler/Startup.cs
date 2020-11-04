using FoodyCrawler.Infrastructure;
using FoodyCrawler.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace FoodyCrawler
{
    public class Startup
    {
        protected IConfiguration Configuration { get; }

        public Startup()
        {
            Configuration = BuildConfiguration();
        }        

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddSwaggerGen();

            services.AddDbContext<FoodyContext>(
                options => options.UseSqlite(Configuration.GetConnectionString("DatabaseConfig")));

            services.AddScoped<IFoodyService, FoodyService>();
            
            services.AddScoped<IOrderService, OrderService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });

            app.UseCors(builder => builder
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }

        private IConfiguration BuildConfiguration()
        {
            var environmentName = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

            var builder = new ConfigurationBuilder();

            builder.Sources.Clear();

            builder.AddJsonFile("appsettings.json", true, false);

            builder.AddJsonFile($"appsettings.{environmentName}.json", true, false);

            builder.AddJsonFile("secrets/appsettings.secrets.json", true, false);

            if (environmentName == "Development")
            {
                builder.AddUserSecrets<Startup>();
            }

            builder.AddEnvironmentVariables();

            return builder.Build();
        }
    }
}
