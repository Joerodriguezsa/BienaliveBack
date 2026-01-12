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
            modelBuilder.ApplyConfiguration(new ServicesTimePriceMap());
            modelBuilder.ApplyConfiguration(new EmployeeServicesMap());
        }

        #endregion

        #region Entidades
        /// <value>Declaración de DbSet para la entidad Services.</value>

        /// <value>Declaración de DbSet para la entidad Users.</value>
        public virtual DbSet<Users> Users { get; set; }

        /// <value>Declaración de DbSet para la entidad Roles.</value>
        public virtual DbSet<Roles> Roles { get; set; }

        /// <value>Declaración de DbSet para la entidad Services.</value>
        public virtual DbSet<Services> Services { get; set; }

        /// <value>Declaración de DbSet para la entidad ServiceImages.</value>
        public virtual DbSet<ServiceImages> ServiceImages { get; set; }

        /// <value>Declaración de DbSet para la entidad ProductImages.</value>
        public virtual DbSet<ProductImages> ProductImages { get; set; }

        /// <value>Declaración de DbSet para la entidad Customers.</value>
        public virtual DbSet<Customers> Customers { get; set; }

        /// <value>Declaración de DbSet para la entidad Products.</value>
        public virtual DbSet<Products> Products { get; set; }

        /// <value>Declaración de DbSet para la entidad Appointments.</value>
        public virtual DbSet<Appointments> Appointments { get; set; }

        /// <value>Declaración de DbSet para la entidad AppointmentStatuses.</value>
        public virtual DbSet<AppointmentStatuses> AppointmentStatuses { get; set; }

        /// <value>Declaración de DbSet para la entidad Bookings.</value>
        public virtual DbSet<Bookings> Bookings { get; set; }

        /// <value>Declaración de DbSet para la entidad Invoices.</value>
        public virtual DbSet<Invoices> Invoices { get; set; }

        /// <value>Declaración de DbSet para la entidad Payments.</value>
        public virtual DbSet<Payments> Payments { get; set; }

        /// <value>Declaración de DbSet para la entidad PaymentMethods.</value>
        public virtual DbSet<PaymentMethods> PaymentMethods { get; set; }

        /// <value>Declaración de DbSet para la entidad Refunds.</value>
        public virtual DbSet<Refunds> Refunds { get; set; }

        /// <value>Declaración de DbSet para la entidad Sales.</value>
        public virtual DbSet<Sales> Sales { get; set; }

        /// <value>Declaración de DbSet para la entidad SaleItems.</value>
        public virtual DbSet<SaleItems> SaleItems { get; set; }

        /// <value>Declaración de DbSet para la entidad Schedules.</value>
        public virtual DbSet<Schedules> Schedules { get; set; }

        /// <value>Declaración de DbSet para la entidad ServicesTimePrice.</value>
        public virtual DbSet<ServicesTimePrice> ServicesTimePrice { get; set; }

        /// <value>Declaración de DbSet para la entidad TeamMembers.</value>
        public virtual DbSet<TeamMembers> TeamMembers { get; set; }

        /// <value>Declaración de DbSet para la entidad TeamServices.</value>
        public virtual DbSet<TeamServices> TeamServices { get; set; }

        /// <value>Declaración de DbSet para la entidad EmployeeServices.</value>
        public virtual DbSet<EmployeeServices> EmployeeServices { get; set; }
        #endregion

    }
}
