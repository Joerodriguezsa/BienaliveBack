namespace Core.Bienalive.EntidadesPersonalizadas.Bookings
{
    /// <summary>Inicialización de los parametros de la entidad Bookings.</summary>
    public class BusquedaBookings
    {
        /// <value>Id.</value>
        public long? Id { get; set; }

        /// <value>CustomerId.</value>
        public long? CustomerId { get; set; }

        /// <value>TeamMemberId.</value>
        public long? TeamMemberId { get; set; }

        /// <value>ServiceTimePriceId.</value>
        public long? ServiceTimePriceId { get; set; }

        /// <value>StartAt.</value>
        public DateTime? StartAt { get; set; }

        /// <value>EndAt.</value>
        public DateTime? EndAt { get; set; }

        /// <value>Status.</value>
        public string? Status { get; set; }
    }
}
