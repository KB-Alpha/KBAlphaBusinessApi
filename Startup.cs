using KBAlphaBusinessApi.Interfaces;
using KBAlphaBusinessApi.Interfaces.CRM_interfaces;
using KBAlphaBusinessApi.Repositories;
using KBAlphaBusinessApi.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Quartz;
using Quartz.Impl;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Threading.Tasks;

namespace KBAlphaBusinessApi
{
    public class Startup
    {

        private IScheduler _schedular;

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;

            _schedular = ConfigureScheduler().Result;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddTransient<IStock, StockDataRepo>();

            services.AddTransient<IDeal, CRMDataRepo>();

            services.AddTransient<IQuote, CRMDataRepo>();

            services.AddTransient<ICommodity, CommodityDataRepo>();

            services.AddTransient<IMacroeconomic, MacroEconomicDataRepo>();

            //Schedular
            services.AddSingleton(provider => _schedular);

            //Database
            services.AddSingleton<Database<object>>();
        }

        private void OnShutDown()
        {
            if (!_schedular.IsShutdown)
                _schedular.Shutdown();
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

        //Sets up the schedduler using quartz library
        public async Task<IScheduler> ConfigureScheduler()
        {
            NameValueCollection props = new NameValueCollection()
            {
                {"quartz.serlizer.type", "binary" }
            };


            // construct a scheduler factory using defaults
            StdSchedulerFactory factory = new StdSchedulerFactory();

            // get a scheduler
            IScheduler scheduler = factory.GetScheduler().Result;
            await scheduler.Start();

            return scheduler;
        }
    }
}
