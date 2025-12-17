namespace Core.Bienalive.Interface.Repositorio
{
    using Core.Bienalive.Entidades;
    using Core.Bienalive.EntidadesPersonalizadas.Roles;

    public interface IDLRoles
    {
        #region Instancias

        /// <summary>Consulta la Roles.</summary>
        /// <param name="parametrosBusqueda">Parametros de entrada para la consulta.</param>
        /// <returns>Lista de Roless consultadas.</returns>
        Task<IEnumerable<Roles>> ConsultarRoles(BusquedaRoles parametrosBusqueda);

        /// <summary>Crea la entidad Roles.</summary>
        /// <param name="Roles">Parametros de entrada para la creacion.</param>
        /// <returns>Entidad Roles.</returns>
        Task<Roles> CrearRoles(Roles Roles);

        /// <summary>Actualiza la Roles.</summary>
        /// <param name="Roles">Parámetros de entrada para la actualizacion de la Roles.</param>
        /// <returns>Entidad Roles Actualizada.</returns>
        Task<Roles> ActualizarRoles(Roles Roles);

        /// <summary>Elimina la Roles.</summary>
        /// <param name="Id">Parámetro de entrada para la Eliminacion de la Roles.</param>
        /// <returns>Entidad Roles Eliminada.</returns>
        Task<Roles> EliminarRoles(int Id);
        #endregion
    }
}
