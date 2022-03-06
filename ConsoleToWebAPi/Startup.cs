using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleToWebAPi
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services) {
            services.AddControllers();
            services.AddTransient<CustomMiddleware>();
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) {
            //app.Run(async context => {
            //    await context.Response.WriteAsync("Hello from run");
            //});
            //app.Use(async (context, next) => {
            //    await context.Response.WriteAsync("Hello from use 1.1\n");
            //    await next();
            //    await context.Response.WriteAsync("Hello from use 1.2\n");
            //});

            //app.UseMiddleware<CustomMiddleware>();

            //app.Map("/razu", CustomCode);

            //app.Use(async (context, next) => {
            //    await context.Response.WriteAsync("Hello from use 2.1\n");
            //    await next();
            //    await context.Response.WriteAsync("Hello from use 2.2\n");
            //});

            //app.Use(async (context, next) => {
            //    await context.Response.WriteAsync("Hello from use 3.1\n");
            //});

            //app.Run(async context => {
            //    await context.Response.WriteAsync("Hello from run 2");
            //});

            if (env.IsDevelopment()) {
                app.UseDeveloperExceptionPage();
            }
            
            app.UseRouting();

            app.UseEndpoints(endpoints => {
                endpoints.MapControllers();
            });

        }

        private void CustomCode(IApplicationBuilder app)
        {
            app.Use(async (context, next) => {
                await context.Response.WriteAsync("Hello razu from map\n");
            });
        }
    }
}
