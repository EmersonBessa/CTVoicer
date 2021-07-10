using AutoMapper;
using CTVoicer.Veiculos.Bussiness.Models;
using CTVoicer.Veiculos.CrossCutting.Ioc;
using CTVoicer.Veiculos.Data.Context;
using CTVoicer.Veiculos.Web.AutoMapper;
using CTVoicer.Veiculos.Web.Configuration;
using CTVoicer.Veiculos.Web.ViewModels;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


namespace CTVoicer.Veiculos.Web
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IHostEnvironment hostEnvironment)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(hostEnvironment.ContentRootPath)
                .AddJsonFile("appsettings.json", true, true)
                .AddJsonFile($"appsettings.{hostEnvironment.EnvironmentName}.json", true, true)
                .AddEnvironmentVariables();

            if (hostEnvironment.IsDevelopment())
            {
                builder.AddUserSecrets<Startup>();
            }

            Configuration = builder.Build();
        }


        public void ConfigureServices(IServiceCollection services)
        {

            services.AddDbContext<VeiculoContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddAutoMapper(typeof(Startup));

            //var mappingConfig = new MapperConfiguration(mc =>
            //{
            //    mc.AddProfile(new AutoMapperConfig());
            //});

            //IMapper mapper = mappingConfig.CreateMapper();
            //services.AddSingleton(mapper);


            //var config = new MapperConfiguration(cfg =>
            //{
            //    cfg.CreateMap<Veiculo, VeiculoViewModel>();
            //    cfg.CreateMap<VeiculoViewModel, Veiculo>();
            //});
            //IMapper mapper = config.CreateMapper();
            //services.AddSingleton(mapper);


            services.AddHttpContextAccessor();
            services.AddMvcConfiguration();

            services.AddAntiforgery(o => o.HeaderName = "XSRF-TOKEN");
            services.AddControllersWithViews();
            services.AddRazorPages();

            services.ResolveDependencies();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/erro/500");
                app.UseStatusCodePagesWithRedirects("/erro/{0}");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseGlobalizationConfig();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }

}
