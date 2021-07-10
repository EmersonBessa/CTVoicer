using CTVoicer.Veiculos.Bussiness.Intefaces;
using CTVoicer.Veiculos.Bussiness.Intefaces.ReadOnly;
using CTVoicer.Veiculos.Bussiness.Intefaces.Services;
using CTVoicer.Veiculos.Bussiness.Services;
using CTVoicer.Veiculos.Data.Context;
using CTVoicer.Veiculos.Data.Repository;
using CTVoicer.Veiculos.Data.Repository.ReadOnly;
using Microsoft.Extensions.DependencyInjection;

namespace CTVoicer.Veiculos.CrossCutting.Ioc
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<VeiculoContext>();

            services.AddScoped<IVeiculoRepository, VeiculoRepository>();
            services.AddScoped<IVeiculoService, VeiculoService>();
            services.AddScoped<IVeiculoReadOnlyRepository, VeiculoReadOnlyRepository>();

            services.AddScoped<ITipoVeiculoRepository, TipoVeiculoRepository>();
            services.AddScoped<ITipoVeiculoService, TipoVeiculoService>();
            services.AddScoped<ITipoVeiculoReadOnlyRepository, TipoVeiculoReadOnlyRepository>();

            services.AddScoped<ICorRepository, CorRepository>();
            services.AddScoped<ICorService, CorService>();
            services.AddScoped<ICorReadOnlyRepository, CorReadOnlyRepository>();


            //services.AddScoped<INotificador, Notificador>();

            return services;
        }
    }
}
