namespace Core.Bienalive.Interface.Repositorio
{
    using Core.Bienalive.Entidades;
    using Core.Bienalive.EntidadesPersonalizadas.TeamServices;

    public interface IDLTeamServices
    {
        #region Instancias

        /// <summary>Consulta la TeamServices.</summary>
        /// <param name="parametrosBusqueda">Parametros de entrada para la consulta.</param>
        /// <returns>Lista de TeamServices consultadas.</returns>
        Task<IEnumerable<TeamServices>> ConsultarTeamServices(BusquedaTeamServices parametrosBusqueda);

        /// <summary>Crea la entidad TeamServices.</summary>
        /// <param name="TeamServices">Parametros de entrada para la creacion.</param>
        /// <returns>Entidad TeamServices.</returns>
        Task<TeamServices> CrearTeamServices(TeamServices TeamServices);

        /// <summary>Actualiza la TeamServices.</summary>
        /// <param name="TeamServices">Parámetros de entrada para la actualizacion de la TeamServices.</param>
        /// <returns>Entidad TeamServices Actualizada.</returns>
        Task<TeamServices> ActualizarTeamServices(TeamServices TeamServices);

        /// <summary>Elimina la TeamServices.</summary>
        /// <param name="Id">Parámetro de entrada para la Eliminacion de la TeamServices.</param>
        /// <returns>Entidad TeamServices Eliminada.</returns>
        Task<TeamServices> EliminarTeamServices(int Id);

        #endregion
    }
}
