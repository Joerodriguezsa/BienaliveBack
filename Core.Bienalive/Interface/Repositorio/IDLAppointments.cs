namespace Core.Bienalive.Interface.Repositorio
{
    using Core.Bienalive.Entidades;
    using Core.Bienalive.EntidadesPersonalizadas.Appointments;

    public interface IDLAppointments
    {
        #region Instancias

        /// <summary>Consulta la Appointments.</summary>
        /// <param name="parametrosBusqueda">Parametros de entrada para la consulta.</param>
        /// <returns>Lista de Appointments consultadas.</returns>
        Task<IEnumerable<Appointments>> ConsultarAppointments(BusquedaAppointments parametrosBusqueda);

        /// <summary>Crea la entidad Appointments.</summary>
        /// <param name="Appointments">Parametros de entrada para la creacion.</param>
        /// <returns>Entidad Appointments.</returns>
        Task<Appointments> CrearAppointments(Appointments Appointments);

        /// <summary>Actualiza la Appointments.</summary>
        /// <param name="Appointments">Parámetros de entrada para la actualizacion de la Appointments.</param>
        /// <returns>Entidad Appointments Actualizada.</returns>
        Task<Appointments> ActualizarAppointments(Appointments Appointments);

        /// <summary>Elimina la Appointments.</summary>
        /// <param name="Id">Parámetro de entrada para la Eliminacion de la Appointments.</param>
        /// <returns>Entidad Appointments Eliminada.</returns>
        Task<Appointments> EliminarAppointments(long Id);

        #endregion
    }
}
