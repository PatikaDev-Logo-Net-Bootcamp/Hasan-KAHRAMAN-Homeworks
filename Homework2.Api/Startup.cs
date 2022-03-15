using Homework2.Api.Common;
using Homework2.Api.Middlewares;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace Homework2.Api
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
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Homework2.Api", Version = "v1" });
                //This code below ensures custom operation on swagger that enables client to write the version.
                c.OperationFilter<AddVersionHeaderParameterOperationFilter>();
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Homework2.Api v1"));
            }

            //a middleware that controls if client's app version is suitable with server's. 
            //if endpoints are Login and Register we skip version checking between server and client.
            //https://www.minepla.net/2020/01/asp-net-core-middleware-usewhen-ve-mapwhen/

            app.UseWhen(context => 
                !context.Request.Path.StartsWithSegments("/api/User/Login")
                && !context.Request.Path.StartsWithSegments("/api/User/Register"),
                    builder => builder.UseAppVersionControlMiddleware(Configuration.GetValue<string>("appVersion"))
            );

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
