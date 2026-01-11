namespace Core.Bienalive.Servicios
{
    using AutoMapper;
    using Core.Bienalive.Interface;
    using Core.Bienalive.Interface.Repositorio;

    /// <summary>Inicializacion de cada uno de los servicios dentro de la unidad de trabajo. </summary>
    public partial class ServiceUnitOfWork : IServiceUnitOfWork
    {
        #region Variables
        private IDLServices _servicesService;
        private IDLServiceImages _serviceImages;
        private IDLProductImages _productImages;
        private IDLRoles _serviceRoles;
        private IDLUsers _users;
        private IDLCustomers _customers;
        private IDLProducts _products;
        private IDLAppointments _appointments;
        private IDLAppointmentStatuses _appointmentStatuses;
        private IDLBookings _bookings;
        private IDLInvoices _invoices;
        private IDLPayments _payments;
        private IDLPaymentMethods _paymentMethods;
        private IDLRefunds _refunds;
        private IDLSales _sales;
        private IDLSaleItems _saleItems;
        private IDLSchedules _schedules;
        private IDLServicesTimePrice _servicesTimePrice;
        private IDLTeamMembers _teamMembers;
        private IDLTeamServices _teamServices;

        /// <summary>Declaración del DLUnitOfWork.</summary>
        private readonly IDLUnitOfWork _iDLUnitOfWork;

        /// <summary>Inyeccion de convertidor o resolutor de modelos.</summary>
        private readonly IMapper _iMapper;

        #endregion

        #region Constructor

        ///<summary>Inicializa una nueva instancia de la clase ServiceUnitOfWork.</summary>        
        /// <param name="iDLUnitOfWork">Inyección de dependencias de la unidad de trabajo - DLUnitOfWork.</param>
        /// <param name="iMapper">Inyección de convertidor o resolutor de modelos.</param>
        public ServiceUnitOfWork(IDLUnitOfWork iDLUnitOfWork, IMapper iMapper)
        {
            _iDLUnitOfWork = iDLUnitOfWork;
            _iMapper = iMapper;
        }

        #endregion

  //      #region Instancias
  //      /// <summary> Inicialización y verificación de la instancia para el servicio Services.</summary>
		//public IDLServices ServicesService => _iServicesService ?? new Services(_iDLUnitOfWork);
  //      public IDLServiceImages ServiceImages => _iServiceImages ?? new ServiceImages(_iDLUnitOfWork);
  //      public IDLRoles ServicesRoles => _iServiceRoles ?? new ServiceRoles(_iDLUnitOfWork);
  //      #endregion

        #region Instancias

        /// <summary>Inicialización y verificación de la instancia para el servicio Services.</summary>
        public IDLServices ServicesService =>
            _servicesService ??= new Services(_iDLUnitOfWork);

        /// <summary>Inicialización y verificación de la instancia para el servicio ServiceImages.</summary>
        public IDLServiceImages ServiceImages =>
            _serviceImages ??= new ServiceImages(_iDLUnitOfWork);

        /// <summary>Inicialización y verificación de la instancia para el servicio ProductImages.</summary>
        public IDLProductImages ProductImages =>
            _productImages ??= new ServiceProductImages(_iDLUnitOfWork);

        /// <summary>Inicialización y verificación de la instancia para el servicio Roles.</summary>
        public IDLRoles ServicesRoles =>
            _serviceRoles ??= new ServiceRoles(_iDLUnitOfWork);

        /// <summary>Inicialización y verificación de la instancia para el servicio Users.</summary>
        public IDLUsers Users =>
            _users ??= new ServiceUsers(_iDLUnitOfWork);

        /// <summary>Inicialización y verificación de la instancia para el servicio Customers.</summary>
        public IDLCustomers Customers =>
            _customers ??= new ServiceCustomers(_iDLUnitOfWork);

        /// <summary>Inicialización y verificación de la instancia para el servicio Products.</summary>
        public IDLProducts Products =>
            _products ??= new ServiceProducts(_iDLUnitOfWork);

        /// <summary>Inicialización y verificación de la instancia para el servicio Appointments.</summary>
        public IDLAppointments Appointments =>
            _appointments ??= new ServiceAppointments(_iDLUnitOfWork);

        /// <summary>Inicialización y verificación de la instancia para el servicio AppointmentStatuses.</summary>
        public IDLAppointmentStatuses AppointmentStatuses =>
            _appointmentStatuses ??= new ServiceAppointmentStatuses(_iDLUnitOfWork);

        /// <summary>Inicialización y verificación de la instancia para el servicio Bookings.</summary>
        public IDLBookings Bookings =>
            _bookings ??= new ServiceBookings(_iDLUnitOfWork);

        /// <summary>Inicialización y verificación de la instancia para el servicio Invoices.</summary>
        public IDLInvoices Invoices =>
            _invoices ??= new ServiceInvoices(_iDLUnitOfWork);

        /// <summary>Inicialización y verificación de la instancia para el servicio Payments.</summary>
        public IDLPayments Payments =>
            _payments ??= new ServicePayments(_iDLUnitOfWork);

        /// <summary>Inicialización y verificación de la instancia para el servicio PaymentMethods.</summary>
        public IDLPaymentMethods PaymentMethods =>
            _paymentMethods ??= new ServicePaymentMethods(_iDLUnitOfWork);

        /// <summary>Inicialización y verificación de la instancia para el servicio Refunds.</summary>
        public IDLRefunds Refunds =>
            _refunds ??= new ServiceRefunds(_iDLUnitOfWork);

        /// <summary>Inicialización y verificación de la instancia para el servicio Sales.</summary>
        public IDLSales Sales =>
            _sales ??= new ServiceSales(_iDLUnitOfWork);

        /// <summary>Inicialización y verificación de la instancia para el servicio SaleItems.</summary>
        public IDLSaleItems SaleItems =>
            _saleItems ??= new ServiceSaleItems(_iDLUnitOfWork);

        /// <summary>Inicialización y verificación de la instancia para el servicio Schedules.</summary>
        public IDLSchedules Schedules =>
            _schedules ??= new ServiceSchedules(_iDLUnitOfWork);

        /// <summary>Inicialización y verificación de la instancia para el servicio ServicesTimePrice.</summary>
        public IDLServicesTimePrice ServicesTimePrice =>
            _servicesTimePrice ??= new ServiceServicesTimePrice(_iDLUnitOfWork);

        /// <summary>Inicialización y verificación de la instancia para el servicio TeamMembers.</summary>
        public IDLTeamMembers TeamMembers =>
            _teamMembers ??= new ServiceTeamMembers(_iDLUnitOfWork);

        /// <summary>Inicialización y verificación de la instancia para el servicio TeamServices.</summary>
        public IDLTeamServices TeamServices =>
            _teamServices ??= new ServiceTeamServices(_iDLUnitOfWork);

        #endregion

        #region Transacciones

        /// <summary>Ejecuta una acción dentro de una transacción.</summary>
        public Task ExecuteInTransactionAsync(Func<Task> action) =>
            _iDLUnitOfWork.ExecuteInTransactionAsync(action);

        /// <summary>Ejecuta una acción dentro de una transacción y devuelve un resultado.</summary>
        public Task<T> ExecuteInTransactionAsync<T>(Func<Task<T>> action) =>
            _iDLUnitOfWork.ExecuteInTransactionAsync(action);

        #endregion
    }
}
