namespace Core.Bienalive.Interface.Repositorio
{
    using Core.Bienalive.Dto.TeamMembers;
    using Core.Bienalive.Entidades;
    using Core.Bienalive.EntidadesPersonalizadas.TeamMembers;

    public interface IDLTeamMembers
    {
        #region Instancias

        /// <summary>Consulta la TeamMembers.</summary>
        /// <param name="parametrosBusqueda">Parametros de entrada para la consulta.</param>
        /// <returns>Lista de TeamMembers consultadas.</returns>
        Task<IEnumerable<TeamMembers>> ConsultarTeamMembers(BusquedaTeamMembers parametrosBusqueda);

        Task<IEnumerable<TeamMembersDto>> ConsultarTeamMembersComplete(BusquedaTeamMembers parametrosBusqueda);

        /// <summary>Crea la entidad TeamMembers.</summary>
        /// <param name="TeamMembers">Parametros de entrada para la creacion.</param>
        /// <returns>Entidad TeamMembers.</returns>
        Task<TeamMembers> CrearTeamMembers(TeamMembers TeamMembers);

        /// <summary>Actualiza la TeamMembers.</summary>
        /// <param name="TeamMembers">Parámetros de entrada para la actualizacion de la TeamMembers.</param>
        /// <returns>Entidad TeamMembers Actualizada.</returns>
        Task<TeamMembers> ActualizarTeamMembers(TeamMembers TeamMembers);

        /// <summary>Elimina la TeamMembers.</summary>
        /// <param name="Id">Parámetro de entrada para la Eliminacion de la TeamMembers.</param>
        /// <returns>Entidad TeamMembers Eliminada.</returns>
        Task<TeamMembers> EliminarTeamMembers(long Id);

        #endregion
    }
}
