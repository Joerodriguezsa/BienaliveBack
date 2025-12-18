namespace Infrastructure.Bienalive.Repositorio
{
    using Core.Bienalive.Entidades;
    using Core.Bienalive.Interface;
    using Infrastructure.Bienalive.Datos;
    using Utilitarios.ConfiguracionRepositorio;
    using Utilitarios.Interfaces.ConfiguracionRepositorio;

    public class DLUnitOfWork : IDLUnitOfWork
    {
        #region Variables

        /// <summary>Conexión a la base de datos.</summary>
        private readonly BienaliveContext _conexionBD;

        /// <summary>Instancia del CrudSqlRepositorio - Services.</summary>
        private ICrudSqlRepositorio<Services> _dlServices;
        private ICrudSqlRepositorio<ServiceImages> _dlServiceImages;
        private ICrudSqlRepositorio<ProductImages> _dlProductImages;
        private ICrudSqlRepositorio<Roles> _dlRoles;
        private ICrudSqlRepositorio<Users> _dlUsers;
        private ICrudSqlRepositorio<Customers> _dlCustomers;
        private ICrudSqlRepositorio<Products> _dlProducts;
        private ICrudSqlRepositorio<Appointments> _dlAppointments;
        private ICrudSqlRepositorio<AppointmentStatuses> _dlAppointmentStatuses;
        private ICrudSqlRepositorio<Bookings> _dlBookings;
        private ICrudSqlRepositorio<Invoices> _dlInvoices;
        private ICrudSqlRepositorio<Payments> _dlPayments;
        private ICrudSqlRepositorio<PaymentMethods> _dlPaymentMethods;
        private ICrudSqlRepositorio<Refunds> _dlRefunds;
        private ICrudSqlRepositorio<Sales> _dlSales;
        private ICrudSqlRepositorio<SaleItems> _dlSaleItems;
        private ICrudSqlRepositorio<Schedules> _dlSchedules;
        private ICrudSqlRepositorio<TeamMembers> _dlTeamMembers;
        private ICrudSqlRepositorio<TeamServices> _dlTeamServices;

        #endregion

        #region Constructor

        ///<summary>Inicializa una nueva instancia de la clase DLUnitOfWork.</summary>
        ///<param name="conexionSqlBD">Contexto de la conexión a base de datos.</param>
        public DLUnitOfWork(BienaliveContext conexionSqlBD)
        {
            _conexionBD = conexionSqlBD;
        }

        #endregion

        #region Instancias

        public ICrudSqlRepositorio<Services> DLServices =>
            _dlServices ??= new CrudSqlRepositorio<Services>(_conexionBD);

        public ICrudSqlRepositorio<ServiceImages> DLServiceImages =>
            _dlServiceImages ??= new CrudSqlRepositorio<ServiceImages>(_conexionBD);

        public ICrudSqlRepositorio<ProductImages> DLProductImages =>
            _dlProductImages ??= new CrudSqlRepositorio<ProductImages>(_conexionBD);

        public ICrudSqlRepositorio<Roles> DLRoles =>
            _dlRoles ??= new CrudSqlRepositorio<Roles>(_conexionBD);

        public ICrudSqlRepositorio<Users> DLUsers =>
            _dlUsers ??= new CrudSqlRepositorio<Users>(_conexionBD);

        public ICrudSqlRepositorio<Customers> DLCustomers =>
            _dlCustomers ??= new CrudSqlRepositorio<Customers>(_conexionBD);

        public ICrudSqlRepositorio<Products> DLProducts =>
            _dlProducts ??= new CrudSqlRepositorio<Products>(_conexionBD);

        public ICrudSqlRepositorio<Appointments> DLAppointments =>
            _dlAppointments ??= new CrudSqlRepositorio<Appointments>(_conexionBD);

        public ICrudSqlRepositorio<AppointmentStatuses> DLAppointmentStatuses =>
            _dlAppointmentStatuses ??= new CrudSqlRepositorio<AppointmentStatuses>(_conexionBD);

        public ICrudSqlRepositorio<Bookings> DLBookings =>
            _dlBookings ??= new CrudSqlRepositorio<Bookings>(_conexionBD);

        public ICrudSqlRepositorio<Invoices> DLInvoices =>
            _dlInvoices ??= new CrudSqlRepositorio<Invoices>(_conexionBD);

        public ICrudSqlRepositorio<Payments> DLPayments =>
            _dlPayments ??= new CrudSqlRepositorio<Payments>(_conexionBD);

        public ICrudSqlRepositorio<PaymentMethods> DLPaymentMethods =>
            _dlPaymentMethods ??= new CrudSqlRepositorio<PaymentMethods>(_conexionBD);

        public ICrudSqlRepositorio<Refunds> DLRefunds =>
            _dlRefunds ??= new CrudSqlRepositorio<Refunds>(_conexionBD);

        public ICrudSqlRepositorio<Sales> DLSales =>
            _dlSales ??= new CrudSqlRepositorio<Sales>(_conexionBD);

        public ICrudSqlRepositorio<SaleItems> DLSaleItems =>
            _dlSaleItems ??= new CrudSqlRepositorio<SaleItems>(_conexionBD);

        public ICrudSqlRepositorio<Schedules> DLSchedules =>
            _dlSchedules ??= new CrudSqlRepositorio<Schedules>(_conexionBD);

        public ICrudSqlRepositorio<TeamMembers> DLTeamMembers =>
            _dlTeamMembers ??= new CrudSqlRepositorio<TeamMembers>(_conexionBD);

        public ICrudSqlRepositorio<TeamServices> DLTeamServices =>
            _dlTeamServices ??= new CrudSqlRepositorio<TeamServices>(_conexionBD);

        #endregion 

        #region Liberar Conexión

        /// <summary>Libera la Conexión de BD.</summary>
        public void Dispose()
        {
            if (_conexionBD != null)
                _conexionBD.Dispose();
        }

        /// <summary>Libera la Conexión de BD.</summary>
        public async Task DisposeAsync()
        {
            if (_conexionBD != null)
                await _conexionBD.DisposeAsync();
        }

        #endregion

        #region Guardar Cambios

        /// <summary>Guardar cambios efectuados en la Conexión de BD.</summary>
        public void SaveChanges() => _conexionBD.SaveChanges();

        /// <summary>Guardar cambios efectuados en la Conexión de BD.</summary>
        public async Task SaveChangesAsync() => await _conexionBD.SaveChangesAsync();

        #endregion

    }
}
