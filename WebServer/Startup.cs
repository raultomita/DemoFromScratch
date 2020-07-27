using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;

namespace WebServer
{
    public class MyStartup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddRazorPages();
        }
        
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            //if (env.IsDevelopment())
            //{
            //    app.UseDeveloperExceptionPage();
            //}
            //else
            //{
                //app.UseExceptionHandler("/Error");
            //}

            app.UseRouting();
            app.UseEndpoints(enpoints =>
                {
                    enpoints.MapDefaultControllerRoute();
                });
        }

        private async Task GetUsers(HttpContext context)
        {
            await context.Response.WriteAsync("John, Marcus");
        }

        private async Task HelloWorld(HttpContext context)
        {
            await context.Response.WriteAsync("Hello, world!");

        }
    }
}
