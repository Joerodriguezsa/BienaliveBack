namespace Core.Bienalive.Interface.Repositorio
{
    using Core.Bienalive.Entidades;
    using Core.Bienalive.EntidadesPersonalizadas.Schedules;

    public interface IDLSchedules
    {
        #region Instancias

        /// <summary>Consulta la Schedules.</summary>
        /// <param name="parametrosBusqueda">Parametros de entrada para la consulta.</param>
        /// <returns>Lista de Schedules consultadas.</returns>
        Task<IEnumerable<Schedules>> ConsultarSchedules(BusquedaSchedules parametrosBusqueda);

        /// <summary>Crea la entidad Schedules.</summary>
        /// <param name="Schedules">Parametros de entrada para la creacion.</param>
        /// <returns>Entidad Schedules.</returns>
        Task<Schedules> CrearSchedules(Schedules Schedules);

        /// <summary>Actualiza la Schedules.</summary>
        /// <param name="Schedules">Parámetros de entrada para la actualizacion de la Schedules.</param>
        /// <returns>Entidad Schedules Actualizada.</returns>
        Task<Schedules> ActualizarSchedules(Schedules Schedules);

        /// <summary>Elimina la Schedules.</summary>
        /// <param name="Id">Parámetro de entrada para la Eliminacion de la Schedules.</param>
        /// <returns>Entidad Schedules Eliminada.</returns>
        Task<Schedules> EliminarSchedules(int Id);

        #endregion
    }
}
