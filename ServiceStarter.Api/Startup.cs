using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ServiceStarter.Core;
using ServiceStarter.Domain;
using ServiceStarter.Domain.Inf;
using ServiceStarter.Infrastructure;
using ServiceStarter.Infrastructure.Middleware;

namespace ServiceStarter.Api
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
            services.AddControllers();

            services.AddSwaggerDocument(config =>
            {
                config.Title = "Service Starter API";
                config.Version = "v1";
            });

            services.RegisterPackage<DomainPackage>(Configuration);
            services.RegisterPackage<CorePackage>(Configuration);
            services.RegisterPackage<InfrastructurePackage>(Configuration);
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }


            app.UseRouting();
            app.UseCors(options =>
            {
                options.AllowAnyOrigin();
                options.AllowAnyHeader();
            });

            app.UseStaticFiles();
            app.UseCustomExceptions();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseOpenApi();
            app.UseReDoc();
        }
    }
}
