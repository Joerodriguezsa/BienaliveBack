using Core.Bienalive.Interface.Repositorio;

namespace Core.Bienalive.Interface
{
    /// <summary>Contrato que provee cada uno de los servicios para ser implementados.</summary>
    public interface IServiceUnitOfWork
    {
        #region Instancias	

        /// <summary>Inicialización y verificación de la instancia para el servicio Services.</summary>
        IDLServices ServicesService { get; }

        /// <summary>Inicialización y verificación de la instancia para el servicio ServiceImages.</summary>
        IDLServiceImages ServiceImages { get; }

        /// <summary>Inicialización y verificación de la instancia para el servicio ProductImages.</summary>
        IDLProductImages ProductImages { get; }

        /// <summary>Inicialización y verificación de la instancia para el servicio Roles.</summary>
        IDLRoles ServicesRoles { get; }

        /// <summary>Inicialización y verificación de la instancia para el servicio Users.</summary>
        IDLUsers Users { get; }

        /// <summary>Inicialización y verificación de la instancia para el servicio Customers.</summary>
        IDLCustomers Customers { get; }

        /// <summary>Inicialización y verificación de la instancia para el servicio Products.</summary>
        IDLProducts Products { get; }

        /// <summary>Inicialización y verificación de la instancia para el servicio Appointments.</summary>
        IDLAppointments Appointments { get; }

        /// <summary>Inicialización y verificación de la instancia para el servicio AppointmentStatuses.</summary>
        IDLAppointmentStatuses AppointmentStatuses { get; }

        /// <summary>Inicialización y verificación de la instancia para el servicio Bookings.</summary>
        IDLBookings Bookings { get; }

        /// <summary>Inicialización y verificación de la instancia para el servicio Invoices.</summary>
        IDLInvoices Invoices { get; }

        /// <summary>Inicialización y verificación de la instancia para el servicio Payments.</summary>
        IDLPayments Payments { get; }

        /// <summary>Inicialización y verificación de la instancia para el servicio PaymentMethods.</summary>
        IDLPaymentMethods PaymentMethods { get; }

        /// <summary>Inicialización y verificación de la instancia para el servicio Refunds.</summary>
        IDLRefunds Refunds { get; }

        /// <summary>Inicialización y verificación de la instancia para el servicio Sales.</summary>
        IDLSales Sales { get; }

        /// <summary>Inicialización y verificación de la instancia para el servicio SaleItems.</summary>
        IDLSaleItems SaleItems { get; }

        /// <summary>Inicialización y verificación de la instancia para el servicio Schedules.</summary>
        IDLSchedules Schedules { get; }

        /// <summary>Inicialización y verificación de la instancia para el servicio ServicesTimePrice.</summary>
        IDLServicesTimePrice ServicesTimePrice { get; }

        /// <summary>Inicialización y verificación de la instancia para el servicio TeamMembers.</summary>
        IDLTeamMembers TeamMembers { get; }

        /// <summary>Inicialización y verificación de la instancia para el servicio TeamServices.</summary>
        IDLTeamServices TeamServices { get; }

        #endregion
    }
}
