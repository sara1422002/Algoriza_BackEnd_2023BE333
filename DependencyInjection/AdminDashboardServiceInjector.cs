﻿using Microsoft.Extensions.DependencyInjection;
using Repository;
using Microsoft.OpenApi.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Core.Service;

namespace DependencyInjection
{
    public class AdminDashboardServiceInjector
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddTransient<IAdminDashboardService, AdminDashboardServices>();
            services.AddTransient<IAdminDoctorPageService, AdminDoctorPageService>();
            services.AddTransient<IAdminPatientPageService, AdminPatientPageService>();
            services.AddTransient<IAdminSettingPageService, AdminSettingPageService>();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Your API", Version = "v1" });
            });


        }
        public async void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }

    }

}
