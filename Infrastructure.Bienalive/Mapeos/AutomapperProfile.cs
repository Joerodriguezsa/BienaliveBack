namespace Infrastructure.Bienalive.Mapeos
{
    using AutoMapper;
    using Core.Bienalive.Dto.Roles;
    using Core.Bienalive.Dto.ServiceImages;
    using Core.Bienalive.Dto.Services;
    using Core.Bienalive.Entidades;
    using Core.Bienalive.EntidadesPersonalizadas.Roles;
    using Core.Bienalive.EntidadesPersonalizadas.ServiceImages;
    using Core.Bienalive.EntidadesPersonalizadas.Services;

    /// <summary>Mapeos entre Entidades <-> Dtos y viceversa.</summary>
    public class AutomapperProfile : Profile
    {

        #region Constructor

        /// <summary>Inicializa una nueva instancia de la clase <see cref="AutomapperProfile"/>.</summary>
        public AutomapperProfile()
        {
            /// <summary>Mapeo entre la entidad Services y el Dto Services(visceversa).</summary>
            CreateMap<Services, ServicesDto>().ReverseMap();

            /// <summary>Mapeo entre la entidad ServicesDto y ParametrosServices(visceversa).</summary>
            CreateMap<ServicesDto, BusquedaServices>().ReverseMap();

            /// <summary>Mapeo entre la entidad Services y el ParametrosCreacionServices(visceversa).</summary>
            CreateMap<Services, CreacionServices>().ReverseMap();

            /// <summary>Mapeo entre la entidad Services y el ParametrosActualizacionServices(visceversa).</summary>
            CreateMap<Services, ActualizacionServices>().ReverseMap();



            /// <summary>Mapeo entre la entidad Services y el Dto Services(visceversa).</summary>
            CreateMap<ServiceImages, ServiceImagesDto>().ReverseMap();

            /// <summary>Mapeo entre la entidad ServicesDto y ParametrosServices(visceversa).</summary>
            CreateMap<ServiceImagesDto, BusquedaServiceImages>().ReverseMap();

            /// <summary>Mapeo entre la entidad Services y el ParametrosCreacionServices(visceversa).</summary>
            CreateMap<ServiceImages, CreacionServiceImages>().ReverseMap();

            /// <summary>Mapeo entre la entidad Services y el ParametrosActualizacionServices(visceversa).</summary>
            CreateMap<ServiceImages, ActualizacionServiceImages>().ReverseMap();



            /// <summary>Mapeo entre la entidad Roles y el Dto Roles(visceversa).</summary>
            CreateMap<Roles, RolesDto>().ReverseMap();

            /// <summary>Mapeo entre la entidad RolesDto y ParametrosRoles(visceversa).</summary>
            CreateMap<RolesDto, BusquedaRoles>().ReverseMap();

            /// <summary>Mapeo entre la entidad Roles y el ParametrosCreacionRoles(visceversa).</summary>
            CreateMap<Roles, CreacionRoles>().ReverseMap();

            /// <summary>Mapeo entre la entidad Roles y el ParametrosActualizacionRoles(visceversa).</summary>
            CreateMap<Roles, ActualizacionRoles>().ReverseMap();
        }

        #endregion
    }
}