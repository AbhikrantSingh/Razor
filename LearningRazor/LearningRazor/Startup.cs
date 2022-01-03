    using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RazorPageTutorial.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningRazor
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
            services.AddRazorPages();
            services.AddSingleton<IAITemplateComparisionRepo, MockAITemplateComparisionResult>();
            
            services.AddSingleton<IEmployeeRepository, MockEmployeeRepository>();
            services.AddSingleton<ITemplateBetter, TemplateService>();

            services.AddSingleton<IJarvisBetter, JarvisBetterService>();

            services.AddSingleton<IPaginationService, PaginationService>();

            services.AddTransient<MockAITemplateComparisionResult>();
            /*
            services.AddTransient<IAITemplateComparisionRepo, MockAITemplateComparisionResult>();

            services.AddTransient<IEmployeeRepository, MockEmployeeRepository>();

            services.AddTransient<IJarvisBetter, JarvisBetterService>();

            services.AddTransient<IPaginationService, PaginationService>();
            */
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
