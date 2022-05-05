using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BD;
using WBL;
namespace WebAppLab
{
    public static class ContainerExtensions
    {

        public static IServiceCollection AddDIContainer(this IServiceCollection services)
        {

            services.AddSingleton<IDataAccess,DataAccess>();

            services.AddTransient<IMarcaVehiculoService, MarcaVehiculoService>();
            services.AddTransient<IVehiculoService, VehiculoService>();
            services.AddTransient<IAlquilerService, AlquilerService>();
            services.AddTransient<IAgenciaService, AgenciaService>();
            services.AddTransient<IClientesService, ClientesService>();
            services.AddTransient<ICatalogoProvinciaService, CatalogoProvinciaService>();
            services.AddTransient<ICatalogoCantonService, CatalogoCantonService>();
            services.AddTransient<ICatalogoDistritoService, CatalogoDistritoService>();
            services.AddTransient<IUsuariosServices, UsuariosServices>();

            return services;
        }
    }
}
