namespace Core.Bienalive.EntidadesPersonalizadas.Bookings
{
    /// <summary>Inicialización de los parametros de la entidad Bookings.</summary>
    public class BusquedaBookings
    {
        /// <value>Id.</value>
        public long? Id { get; set; }

        /// <value>CustomerId.</value>
        public long? CustomerId { get; set; }

        /// <value>ServiceId.</value>
        public long? ServiceId { get; set; }

        /// <value>TeamMemberId.</value>
        public long? TeamMemberId { get; set; }

        /// <value>BookingDate.</value>
        public DateTime? BookingDate { get; set; }

        /// <value>Status.</value>
        public string? Status { get; set; }
    }
}
