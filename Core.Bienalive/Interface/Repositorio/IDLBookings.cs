namespace Core.Bienalive.Interface.Repositorio
{
    using Core.Bienalive.Entidades;
    using Core.Bienalive.EntidadesPersonalizadas.Bookings;

    public interface IDLBookings
    {
        #region Instancias

        /// <summary>Consulta la Bookings.</summary>
        /// <param name="parametrosBusqueda">Parametros de entrada para la consulta.</param>
        /// <returns>Lista de Bookings consultadas.</returns>
        Task<IEnumerable<Bookings>> ConsultarBookings(BusquedaBookings parametrosBusqueda);

        /// <summary>Crea la entidad Bookings.</summary>
        /// <param name="Bookings">Parametros de entrada para la creacion.</param>
        /// <returns>Entidad Bookings.</returns>
        Task<Bookings> CrearBookings(Bookings Bookings);

        /// <summary>Actualiza la Bookings.</summary>
        /// <param name="Bookings">Parámetros de entrada para la actualizacion de la Bookings.</param>
        /// <returns>Entidad Bookings Actualizada.</returns>
        Task<Bookings> ActualizarBookings(Bookings Bookings);

        /// <summary>Elimina la Bookings.</summary>
        /// <param name="Id">Parámetro de entrada para la Eliminacion de la Bookings.</param>
        /// <returns>Entidad Bookings Eliminada.</returns>
        Task<Bookings> EliminarBookings(int Id);

        #endregion
    }
}
