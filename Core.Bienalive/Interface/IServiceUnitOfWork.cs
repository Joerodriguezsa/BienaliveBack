using Core.Bienalive.Interface.Repositorio;

namespace Core.Bienalive.Interface
{
    /// <summary>Contrato que provee cada uno de los servicios para ser implementados.</summary>
    public interface IServiceUnitOfWork
    {
        #region Instancias	
        /// <summary>Inicialización y verificación de la instancia para el servicio Services.</summary>
		public IDLServices ServicesService { get; }
        public IDLServiceImages ServiceImages { get; }
        public IDLRoles ServicesRoles { get; }
        #endregion
    }
}