namespace Infrastructure.Bienalive.Extenciones
{
    using Core.Bienalive.Interface;
    using Core.Bienalive.Servicios;
    using Infrastructure.Bienalive.Datos;
    using Infrastructure.Bienalive.Repositorio;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Utilitarios.ConfiguracionRepositorio;
    using Utilitarios.Interfaces.ConfiguracionRepositorio;

    /// <summary>Extensión para contexto de BD e inyección de dependencias.</summary>
    public static class ServiceCollectionExtension
    {
        #region Métodos

        /// <summary>Extensión para agregar configuración del contexto de base de datos.</summary>
        /// <param name="services">Especifica el contrato para una colección de descriptores de servicio.</param>
        public static void AgregarContextoBD(this IServiceCollection services, IConfiguration configuration)
        {
            // Configuración del Contexto.
            services.AddDbContext<BienaliveContext>(options =>options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"))); // Crear la propiedad para la cadena de conexión de cada conexión contexto.
            Console.WriteLine(configuration.GetConnectionString("DefaultConnection"));
        }

        /// <summary>Adhiere la inyección de dependencias a las clases.</summary>
        /// <param name="services">Especifica el contrato para una colección de descriptores de servicio.</param>
        public static void InyeccionDependencias(this IServiceCollection services)
        {
            // Repositorio Generico.
            services.AddScoped(typeof(ICrudSqlRepositorio<>), typeof(CrudSqlRepositorio<>));

            // Unidad de trabajo (Unit of Work).|
            services.AddTransient<IServiceUnitOfWork, ServiceUnitOfWork>();
            services.AddTransient<IDLUnitOfWork, DLUnitOfWork>();

            // Registrar el servicio de ciclo de vida de la app.
            services.AddHostedService<ApplicationLifetimeEventsHostedService>();
        }

        #endregion
    }
}

