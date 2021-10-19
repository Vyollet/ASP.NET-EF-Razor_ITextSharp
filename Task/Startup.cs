using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace Task
{
    public class Startup
    {
        public Startup(IConfiguration _configuration)
        {
            Configuration = _configuration;
            
        }

        public IConfiguration Configuration { get; }
        
        public void ConfigureServices(IServiceCollection services)
        {
        
            //services.AddEntityFrameworkSqlite().AddDbContext<DataContext>(options=> options.UseSqlite(Configuration["ConnectionStrings:DefaultConnection"]));
            
            services.AddDbContext<DataContext>(options =>
            {
                options.UseSqlite(Configuration.GetConnectionString("DefaultConnection"));
            });

            services.AddMvc();

            services.AddMvc()
                .AddJsonOptions(options =>
                    options.SerializerSettings.PreserveReferencesHandling = PreserveReferencesHandling.All);
         
       }

        
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }
            
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            

            app.UseMvc();
        }
    }
}
