using Core.Bienalive.Entidades;
using Utilitarios.Interfaces.ConfiguracionRepositorio;

namespace Core.Bienalive.Interface
{
    public interface IDLUnitOfWork : IDisposable
    {
        #region Instancias
        /// <summary>Inicialización y verificación de la instancia del CrudSqlRepositorio - Services.</summary>
        ICrudSqlRepositorio<Services> DLServices { get; }

        /// <summary>Inicialización y verificación de la instancia del CrudSqlRepositorio - ServiceImages.</summary>
        ICrudSqlRepositorio<ServiceImages> DLServiceImages { get; }

        /// <summary>Inicialización y verificación de la instancia del CrudSqlRepositorio - Roles.</summary>
        ICrudSqlRepositorio<Roles> DLRoles { get; }

        /// <summary>Inicialización y verificación de la instancia del CrudSqlRepositorio - Users.</summary>
        ICrudSqlRepositorio<Users> DLUsers { get; }

        /// <summary>Inicialización y verificación de la instancia del CrudSqlRepositorio - Customers.</summary>
        ICrudSqlRepositorio<Customers> DLCustomers { get; }

        /// <summary>Inicialización y verificación de la instancia del CrudSqlRepositorio - Products.</summary>
        ICrudSqlRepositorio<Products> DLProducts { get; }

        /// <summary>Inicialización y verificación de la instancia del CrudSqlRepositorio - ProductImages.</summary>
        ICrudSqlRepositorio<ProductImages> DLProductImages { get; }

        /// <summary>Inicialización y verificación de la instancia del CrudSqlRepositorio - Appointments.</summary>
        ICrudSqlRepositorio<Appointments> DLAppointments { get; }

        /// <summary>Inicialización y verificación de la instancia del CrudSqlRepositorio - AppointmentStatuses.</summary>
        ICrudSqlRepositorio<AppointmentStatuses> DLAppointmentStatuses { get; }

        /// <summary>Inicialización y verificación de la instancia del CrudSqlRepositorio - Bookings.</summary>
        ICrudSqlRepositorio<Bookings> DLBookings { get; }

        /// <summary>Inicialización y verificación de la instancia del CrudSqlRepositorio - Invoices.</summary>
        ICrudSqlRepositorio<Invoices> DLInvoices { get; }

        /// <summary>Inicialización y verificación de la instancia del CrudSqlRepositorio - Payments.</summary>
        ICrudSqlRepositorio<Payments> DLPayments { get; }

        /// <summary>Inicialización y verificación de la instancia del CrudSqlRepositorio - PaymentMethods.</summary>
        ICrudSqlRepositorio<PaymentMethods> DLPaymentMethods { get; }

        /// <summary>Inicialización y verificación de la instancia del CrudSqlRepositorio - Sales.</summary>
        ICrudSqlRepositorio<Sales> DLSales { get; }

        /// <summary>Inicialización y verificación de la instancia del CrudSqlRepositorio - SaleItems.</summary>
        ICrudSqlRepositorio<SaleItems> DLSaleItems { get; }

        /// <summary>Inicialización y verificación de la instancia del CrudSqlRepositorio - Refunds.</summary>
        ICrudSqlRepositorio<Refunds> DLRefunds { get; }

        /// <summary>Inicialización y verificación de la instancia del CrudSqlRepositorio - Schedules.</summary>
        ICrudSqlRepositorio<Schedules> DLSchedules { get; }

        /// <summary>Inicialización y verificación de la instancia del CrudSqlRepositorio - ServicesTimePrice.</summary>
        ICrudSqlRepositorio<ServicesTimePrice> DLServicesTimePrice { get; }

        /// <summary>Inicialización y verificación de la instancia del CrudSqlRepositorio - TeamMembers.</summary>
        ICrudSqlRepositorio<TeamMembers> DLTeamMembers { get; }

        /// <summary>Inicialización y verificación de la instancia del CrudSqlRepositorio - TeamServices.</summary>
        ICrudSqlRepositorio<TeamServices> DLTeamServices { get; }
        #endregion

        #region Liberar Conexión

        /// <summary>Libera la Conexión de BD.</summary>        
        void Dispose();

        /// <summary>Libera la Conexión de BD.</summary>        
        Task DisposeAsync();

        #endregion

        #region Guardar Cambios

        /// <summary>Guardar cambios efectuados en la Conexión de BD.</summary>        
        void SaveChanges();

        /// <summary>Guardar cambios efectuados en la Conexión de BD.</summary>        
        Task SaveChangesAsync();

        #endregion
    }
}
