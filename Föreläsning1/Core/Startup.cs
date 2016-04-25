using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Service;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Hosting;
using Microsoft.AspNet.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Core
{
    public class Startup
    {
        public IConfiguration Configuration { get; set; }
        public Startup()
        {
            var someData = new ConfigurationBuilder()
                            .AddJsonFile("data.json");

            Configuration = someData.Build();
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<ISupplier, Supplier>();  //lagt till en instans av 'supplier' sjävla
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, ISupplier supplier) //lagt till vår supplier här
        {
            app.UseIISPlatformHandler();

            app.Run(async (context) =>
            {
                //var jsonData = Configuration["carlProperty"];
                //await context.Response.WriteAsync("jsonData");

                var supplierData = supplier.GetDataFromSupplier();
                await context.Response.WriteAsync("supplierData");
            });
        }

        // Entry point for the application.
        public static void Main(string[] args) => WebApplication.Run<Startup>(args);
    }
}
