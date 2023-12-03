using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Core.Service;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Algoriza_BE_333.Repository;
using Microsoft.OpenApi.Models;
using Service;


namespace Algoriza_BE_333
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            //services.AddDbContext<ApplicationDbContext>(options =>
            //    options.UseSqlServer(Configure.GetConnectionString("@\"Data Source=(localdb)\\ProjectModels;Initial Catalog=Vezeeta;Integrated Security=True\"")));
            services.AddTransient<IAdminDashboardService, AdminDashboardServices>();
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
