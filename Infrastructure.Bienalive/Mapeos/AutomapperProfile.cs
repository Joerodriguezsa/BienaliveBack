namespace Infrastructure.Bienalive.Mapeos
{
    using AutoMapper;

    using Core.Bienalive.Entidades;
    
    using Core.Bienalive.Dto.Services;
    using Core.Bienalive.Dto.ServiceImages;
    using Core.Bienalive.Dto.Roles;
    using Core.Bienalive.Dto.Users;
    using Core.Bienalive.Dto.Customers;
    using Core.Bienalive.Dto.Products;
    using Core.Bienalive.Dto.ProductImages;
    using Core.Bienalive.Dto.Appointments;
    using Core.Bienalive.Dto.AppointmentStatuses;
    using Core.Bienalive.Dto.Bookings;
    using Core.Bienalive.Dto.Invoices;
    using Core.Bienalive.Dto.Payments;
    using Core.Bienalive.Dto.PaymentMethods;
    using Core.Bienalive.Dto.Refunds;
    using Core.Bienalive.Dto.Sales;
    using Core.Bienalive.Dto.SaleItems;
    using Core.Bienalive.Dto.Schedules;
    using Core.Bienalive.Dto.TeamMembers;
    using Core.Bienalive.Dto.TeamServices;

    using Core.Bienalive.EntidadesPersonalizadas.Services;
    using Core.Bienalive.EntidadesPersonalizadas.ServiceImages;
    using Core.Bienalive.EntidadesPersonalizadas.Roles;
    using Core.Bienalive.EntidadesPersonalizadas.Users;
    using Core.Bienalive.EntidadesPersonalizadas.Customers;
    using Core.Bienalive.EntidadesPersonalizadas.Products;
    using Core.Bienalive.EntidadesPersonalizadas.ProductImages;
    using Core.Bienalive.EntidadesPersonalizadas.Appointments;
    using Core.Bienalive.EntidadesPersonalizadas.AppointmentStatuses;
    using Core.Bienalive.EntidadesPersonalizadas.Bookings;
    using Core.Bienalive.EntidadesPersonalizadas.Invoices;
    using Core.Bienalive.EntidadesPersonalizadas.Payments;
    using Core.Bienalive.EntidadesPersonalizadas.PaymentMethods;
    using Core.Bienalive.EntidadesPersonalizadas.Refunds;
    using Core.Bienalive.EntidadesPersonalizadas.Sales;
    using Core.Bienalive.EntidadesPersonalizadas.SaleItems;
    using Core.Bienalive.EntidadesPersonalizadas.Schedules;
    using Core.Bienalive.EntidadesPersonalizadas.TeamMembers;
    using Core.Bienalive.EntidadesPersonalizadas.TeamServices;

    /// <summary>Mapeos entre Entidades <-> Dtos y viceversa.</summary>
    public class AutomapperProfile : Profile
    {

        #region Constructor

        /// <summary>Inicializa una nueva instancia de la clase <see cref="AutomapperProfile"/>.</summary>
        public AutomapperProfile()
        {
            // =========================
            // SERVICES
            // =========================
            CreateMap<Services, ServicesDto>().ReverseMap();
            CreateMap<ServicesDto, BusquedaServices>().ReverseMap();
            CreateMap<Services, CreacionServices>().ReverseMap();
            CreateMap<Services, ActualizacionServices>().ReverseMap();

            // =========================
            // SERVICE IMAGES
            // =========================
            CreateMap<ServiceImages, ServiceImagesDto>().ReverseMap();
            CreateMap<ServiceImagesDto, BusquedaServiceImages>().ReverseMap();
            CreateMap<ServiceImages, CreacionServiceImages>().ReverseMap();
            CreateMap<ServiceImages, ActualizacionServiceImages>().ReverseMap();

            // =========================
            // ROLES
            // =========================
            CreateMap<Roles, RolesDto>().ReverseMap();
            CreateMap<RolesDto, BusquedaRoles>().ReverseMap();
            CreateMap<Roles, CreacionRoles>().ReverseMap();
            CreateMap<Roles, ActualizacionRoles>().ReverseMap();

            // =========================
            // USERS
            // =========================
            CreateMap<Users, UsersDto>().ReverseMap();
            CreateMap<UsersDto, BusquedaUsers>().ReverseMap();
            CreateMap<Users, CreacionUsers>().ReverseMap();
            CreateMap<Users, ActualizacionUsers>().ReverseMap();

            // =========================
            // CUSTOMERS
            // =========================
            CreateMap<Customers, CustomersDto>().ReverseMap();
            CreateMap<CustomersDto, BusquedaCustomers>().ReverseMap();
            CreateMap<Customers, CreacionCustomers>().ReverseMap();
            CreateMap<Customers, ActualizacionCustomers>().ReverseMap();

            // =========================
            // PRODUCTS
            // =========================
            CreateMap<Products, ProductsDto>().ReverseMap();
            CreateMap<ProductsDto, BusquedaProducts>().ReverseMap();
            CreateMap<Products, CreacionProducts>().ReverseMap();
            CreateMap<Products, ActualizacionProducts>().ReverseMap();

            // =========================
            // PRODUCT IMAGES
            // =========================
            CreateMap<ProductImages, ProductImagesDto>().ReverseMap();
            CreateMap<ProductImagesDto, BusquedaProductImages>().ReverseMap();
            CreateMap<ProductImages, CreacionProductImages>().ReverseMap();
            CreateMap<ProductImages, ActualizacionProductImages>().ReverseMap();

            // =========================
            // APPOINTMENTS
            // =========================
            CreateMap<Appointments, AppointmentsDto>().ReverseMap();
            CreateMap<AppointmentsDto, BusquedaAppointments>().ReverseMap();
            CreateMap<Appointments, CreacionAppointments>().ReverseMap();
            CreateMap<Appointments, ActualizacionAppointments>().ReverseMap();

            // =========================
            // APPOINTMENT STATUSES
            // =========================
            CreateMap<AppointmentStatuses, AppointmentStatusesDto>().ReverseMap();
            CreateMap<AppointmentStatusesDto, BusquedaAppointmentStatuses>().ReverseMap();
            CreateMap<AppointmentStatuses, CreacionAppointmentStatuses>().ReverseMap();
            CreateMap<AppointmentStatuses, ActualizacionAppointmentStatuses>().ReverseMap();

            // =========================
            // BOOKINGS
            // =========================
            CreateMap<Bookings, BookingsDto>().ReverseMap();
            CreateMap<BookingsDto, BusquedaBookings>().ReverseMap();
            CreateMap<Bookings, CreacionBookings>().ReverseMap();
            CreateMap<Bookings, ActualizacionBookings>().ReverseMap();

            // =========================
            // INVOICES
            // =========================
            CreateMap<Invoices, InvoicesDto>().ReverseMap();
            CreateMap<InvoicesDto, BusquedaInvoices>().ReverseMap();
            CreateMap<Invoices, CreacionInvoices>().ReverseMap();
            CreateMap<Invoices, ActualizacionInvoices>().ReverseMap();

            // =========================
            // PAYMENTS
            // =========================
            CreateMap<Payments, PaymentsDto>().ReverseMap();
            CreateMap<PaymentsDto, BusquedaPayments>().ReverseMap();
            CreateMap<Payments, CreacionPayments>().ReverseMap();
            CreateMap<Payments, ActualizacionPayments>().ReverseMap();

            // =========================
            // PAYMENT METHODS
            // =========================
            CreateMap<PaymentMethods, PaymentMethodsDto>().ReverseMap();
            CreateMap<PaymentMethodsDto, BusquedaPaymentMethods>().ReverseMap();
            CreateMap<PaymentMethods, CreacionPaymentMethods>().ReverseMap();
            CreateMap<PaymentMethods, ActualizacionPaymentMethods>().ReverseMap();

            // =========================
            // REFUNDS
            // =========================
            CreateMap<Refunds, RefundsDto>().ReverseMap();
            CreateMap<RefundsDto, BusquedaRefunds>().ReverseMap();
            CreateMap<Refunds, CreacionRefunds>().ReverseMap();
            CreateMap<Refunds, ActualizacionRefunds>().ReverseMap();

            // =========================
            // SALES
            // =========================
            CreateMap<Sales, SalesDto>().ReverseMap();
            CreateMap<SalesDto, BusquedaSales>().ReverseMap();
            CreateMap<Sales, CreacionSales>().ReverseMap();
            CreateMap<Sales, ActualizacionSales>().ReverseMap();

            // =========================
            // SALE ITEMS
            // =========================
            CreateMap<SaleItems, SaleItemsDto>().ReverseMap();
            CreateMap<SaleItemsDto, BusquedaSaleItems>().ReverseMap();
            CreateMap<SaleItems, CreacionSaleItems>().ReverseMap();
            CreateMap<SaleItems, ActualizacionSaleItems>().ReverseMap();

            // =========================
            // SCHEDULES
            // =========================
            CreateMap<Schedules, SchedulesDto>().ReverseMap();
            CreateMap<SchedulesDto, BusquedaSchedules>().ReverseMap();
            CreateMap<Schedules, CreacionSchedules>().ReverseMap();
            CreateMap<Schedules, ActualizacionSchedules>().ReverseMap();

            // =========================
            // TEAM MEMBERS
            // =========================
            CreateMap<TeamMembers, TeamMembersDto>().ReverseMap();
            CreateMap<TeamMembersDto, BusquedaTeamMembers>().ReverseMap();
            CreateMap<TeamMembers, CreacionTeamMembers>().ReverseMap();
            CreateMap<TeamMembers, ActualizacionTeamMembers>().ReverseMap();

            // =========================
            // TEAM SERVICES
            // =========================
            CreateMap<TeamServices, TeamServicesDto>().ReverseMap();
            CreateMap<TeamServicesDto, BusquedaTeamServices>().ReverseMap();
            CreateMap<TeamServices, CreacionTeamServices>().ReverseMap();
            CreateMap<TeamServices, ActualizacionTeamServices>().ReverseMap();
        }

        #endregion
    }
}