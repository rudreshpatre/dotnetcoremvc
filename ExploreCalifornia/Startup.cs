using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ExploreCalifornia
{
    public class Startup
    {
        private readonly IConfiguration configuration;

        public Startup(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseExceptionHandler("/error.html");

            //if (env.IsDevelopment())
            if (configuration["EnableDeveloperExceptions"] == "True")
            {
                app.UseDeveloperExceptionPage();
            }


            //app.UseRouting();           

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/", async context =>
            //    {
            //        await context.Response.WriteAsync("Hello Rudresh!");
            //    });
            //});

            //app.Use(async (context, next) => {
            //    await context.Response.WriteAsync("Hello Rudresh Use! ");
            //    await next();
            //});

            app.UseFileServer();
            //app.UseStaticFiles();

            app.Use(async (context, next) =>
            {
                if (context.Request.Path.Value.Contains("invalid"))
                {
                    throw new Exception("ERROR");
                }
                await next();
            });

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello Rudresh Run!");
            });


        }
    }
}
