namespace Core.Bienalive.Interface.Repositorio
{
    using Core.Bienalive.Entidades;
    using Core.Bienalive.EntidadesPersonalizadas.Users;

    public interface IDLUsers
    {
        #region Instancias

        /// <summary>Consulta la Users.</summary>
        /// <param name="parametrosBusqueda">Parametros de entrada para la consulta.</param>
        /// <returns>Lista de Users consultadas.</returns>
        Task<IEnumerable<Users>> ConsultarUsers(BusquedaUsers parametrosBusqueda);

        /// <summary>Crea la entidad Users.</summary>
        /// <param name="Users">Parametros de entrada para la creacion.</param>
        /// <returns>Entidad Users.</returns>
        Task<Users> CrearUsers(Users Users);

        /// <summary>Actualiza la Users.</summary>
        /// <param name="Users">Parámetros de entrada para la actualizacion de la Users.</param>
        /// <returns>Entidad Users Actualizada.</returns>
        Task<Users> ActualizarUsers(Users Users);

        /// <summary>Elimina la Users.</summary>
        /// <param name="Id">Parámetro de entrada para la Eliminacion de la Users.</param>
        /// <returns>Entidad Users Eliminada.</returns>
        Task<Users> EliminarUsers(int Id);

        #endregion
    }
}
