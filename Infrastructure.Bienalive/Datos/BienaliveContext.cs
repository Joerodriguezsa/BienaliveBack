namespace Infrastructure.Bienalive.Datos
{
    using Core.Bienalive.Entidades;
    using Infrastructure.Bienalive.Datos.Mapeos;
    using Microsoft.EntityFrameworkCore;

    /// <summary>Contexto para el manejo de peticiones de las tablas para la base de datos.</summary>
    public class BienaliveContext : DbContext
    {
        #region Constructor

        /// <summary>Inicializa una nueva instancia de la clase Context.</summary>
        public BienaliveContext()
        {
        }

        /// <summary>Inicializa una nueva instancia de la clase Context.</summary>
        public BienaliveContext(DbContextOptions<BienaliveContext> options)
            : base(options)
        {
        }


        /// <summary>Configuración del Contexto.</summary>
        /// <param name="optionsBuilder">Parámetros de configuración.</param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        }

        #endregion

        #region Métodos

        /// <summary>Configura el modelo mediante el ModelBuilder.</summary>
        /// <param name="modelBuilder">Objeto ModelBuilder usado para configurar el modelo.</param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.ApplyConfiguration(new ServicesMap());
        }

        #endregion

        #region Entidades
        /// <value>Declaración de DbSet para la entidad Services.</value>
        public virtual DbSet<Services> Servicess { get; set; }
        public virtual DbSet<ServiceImages> ServiceImages { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        #endregion

    }
}
