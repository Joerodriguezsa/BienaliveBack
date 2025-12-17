namespace Core.Bienalive.Servicios
{
    using AutoMapper;
    using Core.Bienalive.Interface;
    using Core.Bienalive.Interface.Repositorio;

    /// <summary>Inicializacion de cada uno de los servicios dentro de la unidad de trabajo. </summary>
    public partial class ServiceUnitOfWork : IServiceUnitOfWork
    {
        #region Variables
        /// <summary>Instancia del servicio - Services.</summary>
		private readonly IDLServices _iServicesService;

        private readonly IDLServiceImages _iServiceImages;

        private readonly IDLRoles _iServiceRoles;

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

        #region Instancias
        /// <summary> Inicialización y verificación de la instancia para el servicio Services.</summary>
		public IDLServices ServicesService => _iServicesService ?? new Services(_iDLUnitOfWork);
        public IDLServiceImages ServiceImages => _iServiceImages ?? new ServiceImages(_iDLUnitOfWork);
        public IDLRoles ServicesRoles => _iServiceRoles ?? new ServiceRoles(_iDLUnitOfWork);
        #endregion
    }
}