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
        private readonly ICrudSqlRepositorio<Services>? _iDLServices;
        private readonly ICrudSqlRepositorio<ServiceImages>? _iDLServiceImages;
        private readonly ICrudSqlRepositorio<Roles>? _iDLroles;

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
        /// <summary>Inicialización y verificación de la instancia del CrudSqlRepositorio - Services.</summary>
        public ICrudSqlRepositorio<Services> DLServices => _iDLServices ?? new CrudSqlRepositorio<Services>(_conexionBD);
        public ICrudSqlRepositorio<ServiceImages> DLServiceImages => _iDLServiceImages ?? new CrudSqlRepositorio<ServiceImages>(_conexionBD);
        public ICrudSqlRepositorio<Roles> DLRoles => _iDLroles ?? new CrudSqlRepositorio<Roles>(_conexionBD);
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
