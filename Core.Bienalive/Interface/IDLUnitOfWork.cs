using Core.Bienalive.Entidades;
using Utilitarios.Interfaces.ConfiguracionRepositorio;

namespace Core.Bienalive.Interface
{
    public interface IDLUnitOfWork : IDisposable
    {
        #region Instancias
        /// <summary>Inicialización y verificación de la instancia del CrudSqlRepositorio - Services.</summary>
        ICrudSqlRepositorio<Services> DLServices { get; }
        ICrudSqlRepositorio<ServiceImages> DLServiceImages { get; }
        ICrudSqlRepositorio<Roles> DLRoles { get; }
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
